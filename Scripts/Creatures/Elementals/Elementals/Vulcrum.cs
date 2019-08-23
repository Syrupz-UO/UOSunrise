using System;
using Server;
using System.Collections;
using System.Collections.Generic;
using Server.Misc;
using Server.Items;
using Server.Network;
using Server.Commands;
using Server.Commands.Generic;
using Server.Mobiles;
using Server.Accounting;
using Server.Regions;

namespace Server.Mobiles
{
	[CorpseName( "Vulcrum's corpse" )]
	public class Vulcrum : BaseCreature
	{
		//
		private DateTime m_NextPickup;
		//
		public override bool ReacquireOnMovement{ get{ return !Controlled; } }
		public override bool HasBreath{ get{ return true; } }
		public override void BreathDealDamage( Mobile target, int form ){ base.BreathDealDamage( target, 9 ); }

		[Constructable]
		public Vulcrum () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "Vulcrum";
			Title = "of the flame";
			Body = 16;
			Hue = 0x489;
			BaseSoundID = 838;
			EmoteHue = 123;

			SetStr( 796, 825 );
			SetDex( 86, 105 );
			SetInt( 436, 475 );

			SetHits( 11478, 11495 );

			SetDamage( 16, 22 );

			SetDamageType( ResistanceType.Physical, 65 );
			SetDamageType( ResistanceType.Fire, 65 );

			SetResistance( ResistanceType.Physical, 65, 65 );
			SetResistance( ResistanceType.Fire, 60, 70 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 65, 70 );
			SetResistance( ResistanceType.Energy, 65, 75 );

			SetSkill( SkillName.EvalInt, 80.1, 100.0 );
			SetSkill( SkillName.Magery, 80.1, 100.0 );
			SetSkill( SkillName.MagicResist, 99.1, 100.0 );
			SetSkill( SkillName.Tactics, 97.6, 100.0 );
			SetSkill( SkillName.Wrestling, 90.1, 92.5 );

			Fame = 15000;
			Karma = -15000;

			VirtualArmor = 75;

			PackItem( new SulfurousAsh( 50 ) );

			AddItem( new LighterSource() );
		}
		////////////////////
		
		public override void OnThink()
		{
			base.OnThink();
			if ( DateTime.Now < m_NextPickup )
				return;

			m_NextPickup = DateTime.Now + TimeSpan.FromSeconds( Utility.RandomMinMax( 10, 20 ) );

			switch( Utility.RandomMinMax( 0, 11 ) )
			{
				case 0:	Peace( Combatant ); break;
				case 1:	Undress( Combatant ); break;
				case 2:	Suppress( Combatant ); break;
				case 3:	Provoke( Combatant ); break;
			}
		}
			#region Peace
		private DateTime m_NextPeace;

		public void Peace( Mobile target )
		{
			if ( target == null || Deleted || !Alive || m_NextPeace > DateTime.Now || 0.1 < Utility.RandomDouble() )
				return;

			PlayerMobile p = target as PlayerMobile;

			if ( p != null && p.PeacedUntil < DateTime.Now && !p.Hidden && CanBeHarmful( p ) )
			{
				p.PeacedUntil = DateTime.Now + TimeSpan.FromMinutes( 1 );
				p.SendLocalizedMessage( 500616 ); // You hear lovely music, and forget to continue battling!
				p.FixedParticles( 0x376A, 1, 32, 0x15BD, EffectLayer.Waist );
				p.Combatant = null;

				PlaySound( 0x58D );
			}

			m_NextPeace = DateTime.Now + TimeSpan.FromSeconds( 10 );
		}
		#endregion

		#region Suppress
		private static Dictionary<Mobile, Timer> m_Suppressed = new Dictionary<Mobile, Timer>();
		private DateTime m_NextSuppress;

		public void Suppress( Mobile target )
		{
			if ( target == null || m_Suppressed.ContainsKey( target ) || Deleted || !Alive || m_NextSuppress > DateTime.Now || 0.1 < Utility.RandomDouble() )
				return;

			TimeSpan delay = TimeSpan.FromSeconds( Utility.RandomMinMax( 20, 80 ) );

			if ( !target.Hidden && CanBeHarmful( target ) )
			{
				target.SendLocalizedMessage( 1072061 ); // You hear jarring music, suppressing your strength.

				for ( int i = 0; i < target.Skills.Length; i++ )
				{
					Skill s = target.Skills[ i ];

					target.AddSkillMod( new TimedSkillMod( s.SkillName, true, s.Base * -0.28, delay ) );
				}

				int count = (int) Math.Round( delay.TotalSeconds / 1.25 );
				Timer timer = new AnimateTimer( target, count );
				m_Suppressed.Add( target, timer );
				timer.Start();

				PlaySound( 0x58C );
			}

			m_NextSuppress = DateTime.Now + TimeSpan.FromSeconds( 10 );
		}

		public static void SuppressRemove( Mobile target )
		{
			if ( target != null && m_Suppressed.ContainsKey( target ) )
			{
				Timer timer = m_Suppressed[ target ];

				if ( timer != null || timer.Running )
					timer.Stop();

				m_Suppressed.Remove( target );
			}
		}

		private class AnimateTimer : Timer
		{
			private Mobile m_Owner;
			private int m_Count;

			public AnimateTimer( Mobile owner, int count ) : base( TimeSpan.Zero, TimeSpan.FromSeconds( 1.25 ) )
			{
				m_Owner = owner;
				m_Count = count;
			}

			protected override void OnTick()
			{
				if ( m_Owner.Deleted || !m_Owner.Alive || m_Count-- < 0 )
				{
					SuppressRemove( m_Owner );
				}
				else
					m_Owner.FixedParticles( 0x376A, 1, 32, 0x15BD, EffectLayer.Waist );
			}
		}
		#endregion

		#region Undress
		private DateTime m_NextUndress;

		public void Undress( Mobile target )
		{
			if ( target == null || Deleted || !Alive || m_NextUndress > DateTime.Now || 0.005 < Utility.RandomDouble() )
				return;

			if ( target.Player && target.Female && !target.Hidden && CanBeHarmful( target ) )
			{
				UndressItem( target, Layer.OuterTorso );
				UndressItem( target, Layer.InnerTorso );
				UndressItem( target, Layer.MiddleTorso );
				UndressItem( target, Layer.Pants );
				UndressItem( target, Layer.Shirt );

				target.SendLocalizedMessage( 1072196 ); // The satyr's music makes your blood race. Your clothing is too confining.
			}

			m_NextUndress = DateTime.Now + TimeSpan.FromMinutes( 1 );
		}

		public void UndressItem( Mobile m, Layer layer )
		{
			Item item = m.FindItemOnLayer( layer );

			if ( item != null && item.Movable )
				m.PlaceInBackpack( item );
		}
		#endregion

		#region Provoke
		private DateTime m_NextProvoke;

		public void Provoke( Mobile target )
		{
			if ( target == null || Deleted || !Alive || m_NextProvoke > DateTime.Now || 0.05 < Utility.RandomDouble() )
				return;

			foreach ( Mobile m in GetMobilesInRange( RangePerception ) )
			{
				if ( m is BaseCreature )
				{
					BaseCreature c = (BaseCreature) m;

					if ( c == this || c == target || c.Unprovokable || c.IsParagon ||  c.BardProvoked || c.AccessLevel != AccessLevel.Player || !c.CanBeHarmful( target ) )
						continue;

					c.Provoke( this, target, true );

					if ( target.Player )
						target.SendLocalizedMessage( 1072062 ); // You hear angry music, and start to fight.

					PlaySound( 0x58A );
					break;
				}
			}

			m_NextProvoke = DateTime.Now + TimeSpan.FromSeconds( 10 );
		}
		#endregion
		////////////////////
		public override void OnDeath( Container c )
		{
			base.OnDeath( c );

			ArrayList targets = new ArrayList();
			foreach ( Item item in World.Items.Values )
			if ( item is StaffPartFire )
			{
				targets.Add( item );
			}
			for ( int i = 0; i < targets.Count; ++i )
			{
				Item item = ( Item )targets[ i ];
				item.Delete();
			}

   			c.DropItem( new StaffPartFire() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 3 );
			AddLoot( LootPack.Gems );
		}

		public override bool BleedImmune{ get{ return true; } }
		public override int TreasureMapLevel{ get{ return 4; } }
		public override bool Unprovokable{ get{ return true; } }

		public override bool OnBeforeDeath()
		{
			VulcrumChest MyChest = new VulcrumChest();
			MyChest.MoveToWorld( Location, Map );

			QuestGlow MyGlow = new QuestGlow();
			MyGlow.MoveToWorld( Location, Map );

			return base.OnBeforeDeath();
		}

		public Vulcrum( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			if ( BaseSoundID == 274 )
				BaseSoundID = 838;
		}
	}
}


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Server.Items
{
	public class VulcrumChest : Item
	{
		[Constructable]
		public VulcrumChest() : base( 0xE40 )
		{
			Name = "Vulcrum's Vault";
			Movable = false;
			Hue = 0x4EA;
			ItemRemovalTimer thisTimer = new ItemRemovalTimer( this ); 
			thisTimer.Start(); 
		}

		public VulcrumChest( Serial serial ) : base( serial )
		{
		}

		public override void OnDoubleClick( Mobile from )
		{
			if ( from.InRange( this.GetWorldLocation(), 2 ) )
			{
				from.SendSound( 0x3D );
				from.PrivateOverheadMessage(MessageType.Regular, 1150, false, "You have pulled Vulcrum's Vault toward you.", from.NetState);

				LootChest MyChest = new LootChest( 6 );
				MyChest.Name = "Vulcrum's Vault";
				MyChest.Hue = 0x4EA;

				if ( from is PlayerMobile )
				{
					if ( GetPlayerInfo.LuckyKiller( from.Luck ) )
					{
						Item arty = ArtifactBuilder.CreateArtifact( "random" );
						MyChest.DropItem( arty );
					}
					if ( GetPlayerInfo.LuckyKiller( from.Luck ) && !Server.Items.CharacterDatabase.GetSpecialsKilled( from, "Vulcrum" ) )
					{
						Server.Items.CharacterDatabase.SetSpecialsKilled( from, "Vulcrum" );
						ManualOfItems lexicon = new ManualOfItems();
							lexicon.Hue = 0x4EA;
							lexicon.Name = "Tome of Vulcrum Relics";
							lexicon.m_Charges = 1;
							lexicon.m_Skill_1 = 0;
							lexicon.m_Skill_2 = 0;
							lexicon.m_Skill_3 = 0;
							lexicon.m_Skill_4 = 0;
							lexicon.m_Skill_5 = 0;
							lexicon.m_Value_1 = 0.0;
							lexicon.m_Value_2 = 0.0;
							lexicon.m_Value_3 = 0.0;
							lexicon.m_Value_4 = 0.0;
							lexicon.m_Value_5 = 0.0;
							lexicon.m_Slayer_1 = 19;
							lexicon.m_Slayer_2 = 0;
							lexicon.m_Owner = from;
							lexicon.m_Extra = "of Vulcrum of the Flame";
							lexicon.m_FromWho = "Taken from Vulcrum";
							lexicon.m_HowGiven = "Acquired by";
							lexicon.m_Points = 200;
							lexicon.m_Hue = 0x4EA;
							MyChest.DropItem( lexicon );
					}
				}

				MyChest.MoveToWorld( from.Location, from.Map );

				LoggingFunctions.LogGenericQuest( from, "defeated Vulcrum of the Flame" );
				this.Delete();
			}
			else
			{
				from.SendLocalizedMessage( 502138 ); // That is too far away for you to use
			}
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
			this.Delete(); // none when the world starts 
		}

		public class ItemRemovalTimer : Timer 
		{ 
			private Item i_item; 
			public ItemRemovalTimer( Item item ) : base( TimeSpan.FromMinutes( 10.0 ) ) 
			{ 
				Priority = TimerPriority.OneSecond; 
				i_item = item; 
			} 

			protected override void OnTick() 
			{ 
				if (( i_item != null ) && ( !i_item.Deleted ))
				{
					i_item.Delete();
				}
			} 
		} 
	}
}
