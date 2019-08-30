using System;
using Server.Network;
using Server.Items;
using System.Collections;

namespace Server.Items
{
	public class BloodyMarysApron : BaseMiddleTorso
	{

		[Constructable]
		public BloodyMarysApron() : base( 0x153D )
		{
			Weight = 1.0;
			Name = "Bloody Mary's apron";
			Hue = 138;
		}

        public BloodyMarysApron(Serial serial)
            : base(serial)
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
		
		public override bool OnEquip( Mobile from )
		{

			from.SendMessage( "You put on Bloody Mary's apron." );
				
			BeginBleed( from );
	
			return base.OnEquip( from );
		}

		public override void OnRemoved( IEntity parent )
		{
			if ( parent is Mobile )
			{
				Mobile from = ( Mobile ) parent;
				
				EndBleed ( from );

                from.SendMessage("You remove Bloody Mary's apron.");
			}

			base.OnRemoved( parent );
		}

		private static Hashtable m_Table = new Hashtable();

		public static bool IsBleeding( Mobile m )
		{
			return m_Table.Contains( m );
		}
		
		public static void BeginBleed( Mobile m  )
		{
			Timer t = (Timer)m_Table[m];

			if ( t != null )
				t.Stop();

			t = new InternalTimer( m );
			m_Table[m] = t;

			t.Start();
		}

		public static void DoBleed( Mobile m )
		{
			Blood blood = new Blood();
			blood.ItemID = Utility.Random( 0x122A, 5 );
			blood.MoveToWorld( m.Location, m.Map );
		}

		public static void EndBleed( Mobile m )
		{
			Timer t = (Timer)m_Table[m];

			if ( t == null )
				return;

			t.Stop();
			m_Table.Remove( m );
		}

		private class InternalTimer : Timer
		{
			private Mobile m_From;
			private int m_Count;

			public InternalTimer( Mobile from ) : base( TimeSpan.FromSeconds( 2.0 ), TimeSpan.FromSeconds( 2.0 ) )
			{
				m_From = from;
				Priority = TimerPriority.TwoFiftyMS;
			}

			protected override void OnTick()
			{
				DoBleed( m_From );
			}
		}
	}
}
