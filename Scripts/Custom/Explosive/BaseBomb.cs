using System;
using System.Collections;
using Server;
using Server.Network;
using Server.Targeting;
using Server.Spells;

namespace Server.Items
{
	public abstract class BaseBomb : Item

	{
		public int m_MinDamage;
		public int m_MaxDamage;
		public double m_CountDown;
		public int m_ExplosionRange;
		public BaseBomb m_BB;
		public bool m_IsActivated = false;
		public bool m_IsDefusable = true;

		private static int m_X;
		private static int m_Y;
		private static Map m_Map;

		public BaseBomb() : base( 0x9A8 )
		{
		}

		public BaseBomb( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version

			writer.Write( m_MinDamage );
			writer.Write( m_MaxDamage );
			writer.Write( m_CountDown );
			writer.Write( m_ExplosionRange );
			writer.Write( m_IsDefusable );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();

			m_MinDamage = reader.ReadInt();
			m_MaxDamage = reader.ReadInt();
			m_CountDown = reader.ReadDouble();
			m_ExplosionRange = reader.ReadInt();
			m_IsDefusable = reader.ReadBool();
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public int MinDamage{ get{ return m_MinDamage; } set{ m_MinDamage = value; InvalidateProperties(); } }

		[CommandProperty( AccessLevel.GameMaster )]
		public int MaxDamage{ get{ return m_MaxDamage; } set{ m_MaxDamage = value; InvalidateProperties(); } }

		[CommandProperty( AccessLevel.GameMaster )]
		public double CountDown{ get{ return m_CountDown; } set{ m_CountDown = value; InvalidateProperties(); } }

		[CommandProperty( AccessLevel.GameMaster )]
		public int ExplosionRange{ get{ return m_ExplosionRange; } 
			
			set{ m_ExplosionRange = value; InvalidateProperties();
				if (m_ExplosionRange >= 81)
				{
					m_ExplosionRange = 80;
				}
			} 
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public bool IsActivated{ get{ return m_IsActivated; } }

		[CommandProperty( AccessLevel.GameMaster )]
		public bool IsDefusable{ get{ return m_IsDefusable; } set{ m_IsDefusable = value; InvalidateProperties(); } }

		public virtual object FindParent( Mobile from )
		{
			Mobile m = this.HeldBy;

			if ( m != null && m.Holding == this )
				return m;

			object obj = this.RootParent;

			if ( obj != null )
				return obj;

			if ( Map == Map.Internal )
				return from;

			return this;
		}

		private Timer m_Timer;

		private ArrayList m_Users;

		public override void OnDoubleClick( Mobile from )
		{
			if ( Core.AOS && (from.Paralyzed || from.Frozen || (from.Spell != null && from.Spell.IsCasting)) )
			{
				from.SendMessage( "You cant place a bomb while paralyzed" );
				return;
			}

			if (IsActivated)
			{
				from.SendMessage( "This bomb is already ticking!" );

				if (IsDefusable)
				{
					from.SendMessage( "You should try to defuse the bomb before somebody gets hurt!" );
					return;
				}
			}

			from.RevealingAction();
			from.SendMessage( "You have placed the bomb and set the clock to {0} seconds!", m_CountDown );

			int Xx = from.X;
			int Yy = from.Y;
			int Zz = from.Z;
			Map mmaapp = from.Map;

			this.m_IsActivated = true;
			this.MoveToWorld( new Point3D( Xx, Yy, Zz ), mmaapp );
			this.Movable = false;

			if ( m_Users == null )
				m_Users = new ArrayList();

			if ( !m_Users.Contains( from ) )
				m_Users.Add( from );

			if ( m_Timer == null )
			{
				int countdownaddone = ((int)m_CountDown + 1);
				int countdown = (int)m_CountDown;
				m_Timer = Timer.DelayCall( TimeSpan.FromSeconds( 0.75 ), TimeSpan.FromSeconds( 1.0 ), countdownaddone, new TimerStateCallback( Detonate_OnTick ), new object[]{ from, countdown } );
			}
			base.OnDoubleClick(from);
		}

		private void Detonate_OnTick( object state )
		{
			if ( Deleted )
				return;

			object[] states = (object[])state;
			Mobile from = (Mobile)states[0];
			int timer = (int)states[1];

			object parent = FindParent( from );

			if ( timer == 0 )
			{
				Explode();
			}
			else
			{
				if ( parent is Item )
					((Item)parent).PublicOverheadMessage( MessageType.Regular, 0x22, false, timer.ToString() );
				else if ( parent is Mobile )
					((Mobile)parent).PublicOverheadMessage( MessageType.Regular, 0x22, false, timer.ToString() );

				states[1] = timer - 1;
			}
		}

		public void Explode()
		{
			if ( Deleted )
				return;

			Map map = this.Map;

			if ( map != null )
			{
				for ( int x = -m_ExplosionRange; x <= m_ExplosionRange; ++x )
				{
					for ( int y = -m_ExplosionRange; y <= m_ExplosionRange; ++y )
					{
						double dist = Math.Sqrt(x*x+y*y);

						if ( dist <= m_ExplosionRange )
						new ExplosionTimer(map, X + x, Y + y, m_MinDamage, m_MaxDamage, m_BB ).Start();

						Delete();
						
					}
				}
			}
		}
	}

	public class ExplosionTimer : Timer
	{
		private Map n_Map;
		private int n_X, n_Y;
		private int n_MinDamage;
		private int n_MaxDamage;
		private BaseBomb n_Bomb;

		public ExplosionTimer( Map map, int x, int y, int mindamage, int maxdamage, BaseBomb bb ) : base( TimeSpan.FromSeconds( Utility.RandomDouble() * 10.0 ) ) 
		{
			n_Map = map;
			n_X = x;
			n_Y = y;
			n_MinDamage = mindamage;
			n_MaxDamage = maxdamage;
			n_Bomb = bb;
		}

		protected override void OnTick()
		{
			int z = n_Map.GetAverageZ( n_X, n_Y );
			bool canFit = n_Map.CanFit( n_X, n_Y, z, 6, false, false );

			for ( int i = -3; !canFit && i <= 3; ++i )
			{
				canFit = n_Map.CanFit( n_X, n_Y, z + i, 6, false, false );

				if ( canFit )
					z += i;
			}

			if ( !canFit )
				return;

			Gold g = new Gold( 1 );
				
			g.MoveToWorld( new Point3D( n_X, n_Y, z ), n_Map );

			
			switch ( Utility.Random( 3 ) )
			{
				case 0: // Fire column
				{
					Effects.SendLocationParticles( EffectItem.Create( g.Location, g.Map, EffectItem.DefaultDuration ), 0x3709, 10, 30, 5052 );
					Effects.PlaySound( g, g.Map, 0x208 );
					DoDamage(g, n_MinDamage, n_MaxDamage);

					break;
				}
				case 1: // Explosion
				{
					Effects.SendLocationParticles( EffectItem.Create( g.Location, g.Map, EffectItem.DefaultDuration ), 0x36BD, 20, 10, 5044 );
					Effects.PlaySound( g, g.Map, 0x307 );
					DoDamage(g, n_MinDamage, n_MaxDamage);

					break;
				}
				case 2: // Ball of fire
				{
					Effects.SendLocationParticles( EffectItem.Create( g.Location, g.Map, EffectItem.DefaultDuration ), 0x36FE, 10, 10, 5052 );
					DoDamage(g, n_MinDamage, n_MaxDamage);

					break;
				}
			}
			g.Delete();
		}

		public static void DoDamage(Item g, int mindmg, int maxdmg)
		{
			ArrayList list = new ArrayList();

			foreach ( Mobile m in g.GetMobilesInRange( 2 ))
			{
				if ( !m.CanBeHarmful( m ) )
					continue;

				if ( m is Server.Mobiles.BaseCreature && (((Server.Mobiles.BaseCreature)m).Controlled || ((Server.Mobiles.BaseCreature)m).Summoned ))
					list.Add( m );
				else if ( m.Player )
					list.Add( m );
			}

			foreach ( Mobile m in list )
			{
				m.DoHarmful( m );

				m.FixedParticles( 0x36BD, 50, 50, 5052, EffectLayer.Waist );

				int toStrike = Utility.RandomMinMax( mindmg, maxdmg );

				m.Damage( toStrike, m );

				if( 0.8 >= Utility.RandomDouble())
					m.SendMessage( "You are caught in the powerful blast!" );
			}
		}
	}
}