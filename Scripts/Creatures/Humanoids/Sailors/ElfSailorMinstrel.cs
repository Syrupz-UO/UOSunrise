using System;
using Server;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;
using System.Collections.Generic;
using Server.Targeting;
using Server.Multis;

namespace Server.Mobiles
{
	public class ElfSailorMinstrel : BaseCreature
	{
        private SmallBoat m_SmallBoat;
        private bool boatspawn;
		private DateTime m_NextPickup;

		[Constructable]
		public ElfSailorMinstrel() : base( AIType.AI_Archer, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();

			switch ( Utility.RandomMinMax( 0, 8 ) )
			{
				case 0: Title = "the elf bard"; break;
				case 1: Title = "the elf minstrel"; break;
				case 2: Title = "the elf troubadour"; break;
				case 3: Title = "the elf musician"; break;
				case 4: Title = "the elf balladeer"; break;
				case 5: Title = "the elf sailor"; break;
				case 6: Title = "the elf fisherman"; break;
				case 7: Title = "the elf sailor"; break;
				case 8: Title = "the elf fisherman"; break;
			}

			Race = Race.Elf;
			Hue = Utility.RandomSkinHue();
			HairHue = Utility.RandomHairHue();

			if ( this.Female = Utility.RandomBool() )
			{
				Body = 606;
				Name = NameList.RandomName( "elf_female" );
				AddItem( new Skirt( RandomThings.GetRandomColor(0) ) );
				Utility.AssignRandomHair( this );
			}
			else
			{
				Body = 605;
				Name = NameList.RandomName( "elf_male" );
				AddItem( new ShortPants( RandomThings.GetRandomColor(0) ) );
				Utility.AssignRandomHair( this );
			}

			SetStr( 86, 100 );
			SetDex( 81, 95 );
			SetInt( 61, 75 );

			SetDamage( 10, 23 );

			SetSkill( SkillName.Archery, 80.1, 90.0 );
			SetSkill( SkillName.Wrestling, 66.0, 97.5 );
			SetSkill( SkillName.MagicResist, 25.0, 47.5 );
			SetSkill( SkillName.Tactics, 65.0, 87.5 );

			Fame = 2000;
			Karma = 2000;

			AddItem( new Boots( Utility.RandomNeutralHue() ) );
			AddItem( new FancyShirt( RandomThings.GetRandomColor(0) ));
			
			switch ( Utility.Random( 4 ))
			{
				case 0: AddItem( new FeatheredHat( RandomThings.GetRandomColor(0) ) ); break;
				case 1: AddItem( new FloppyHat( RandomThings.GetRandomColor(0) ) ); break;
				case 2: AddItem( new StrawHat( RandomThings.GetRandomColor(0) ) ); break;
				case 3: AddItem( new SkullCap( RandomThings.GetRandomColor(0) ) ); break;
			}

			switch ( Utility.Random( 2 ))
			{
				case 0: AddItem( new Crossbow() ); PackItem( new Bolt( Utility.RandomMinMax( 5, 15 ) ) ); break;
				case 1: AddItem( new Bow() ); PackItem( new Arrow( Utility.RandomMinMax( 5, 15 ) ) ); break;
			}

			switch ( Utility.Random( 5 ))
			{
				case 0: PackItem( new BambooFlute() );	SpeechHue = 0x504; break;
				case 1: PackItem( new Drums() );		SpeechHue = 0x38; break;
				case 2: PackItem( new Tambourine() );	SpeechHue = 0x52; break;
				case 3: PackItem( new LapHarp() );		SpeechHue = 0x45; break;
				case 4: PackItem( new Lute() );			SpeechHue = 0x4C; break;
			}
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
		}

		public override void OnDelete()
		{
			if( m_SmallBoat != null )
			{
				Point3D splash1 = new Point3D(m_SmallBoat.X, (m_SmallBoat.Y+2), m_SmallBoat.Z);
				Point3D splash2 = new Point3D((m_SmallBoat.X+1), m_SmallBoat.Y, m_SmallBoat.Z);
				Point3D splash3 = new Point3D((m_SmallBoat.X-1), (m_SmallBoat.Y+2), m_SmallBoat.Z);
				Point3D splash4 = new Point3D(m_SmallBoat.X, (m_SmallBoat.Y-2), m_SmallBoat.Z);

				Effects.PlaySound( m_SmallBoat.Location, m_SmallBoat.Map, 0x026 );

				Effects.SendLocationEffect( splash1, m_SmallBoat.Map, 0x352D, 16, 4 );
				Effects.SendLocationEffect( splash2, m_SmallBoat.Map, 0x352D, 16, 4 );
				Effects.SendLocationEffect( splash3, m_SmallBoat.Map, 0x352D, 16, 4 );
				Effects.SendLocationEffect( splash4, m_SmallBoat.Map, 0x352D, 16, 4 );

				m_SmallBoat.Delete();
            }

			base.OnDelete();
		}

		public override bool OnBeforeDeath()
		{
			if( m_SmallBoat != null )
			{
				Point3D splash1 = new Point3D(m_SmallBoat.X, (m_SmallBoat.Y+2), m_SmallBoat.Z);
				Point3D splash2 = new Point3D((m_SmallBoat.X+1), m_SmallBoat.Y, m_SmallBoat.Z);
				Point3D splash3 = new Point3D((m_SmallBoat.X-1), (m_SmallBoat.Y+2), m_SmallBoat.Z);
				Point3D splash4 = new Point3D(m_SmallBoat.X, (m_SmallBoat.Y-2), m_SmallBoat.Z);

				Point3D wreck = new Point3D(m_SmallBoat.X, (m_SmallBoat.Y-1), m_SmallBoat.Z);

				Effects.PlaySound( m_SmallBoat.Location, m_SmallBoat.Map, 0x026 );

				Effects.SendLocationEffect( splash1, m_SmallBoat.Map, 0x352D, 16, 4 );
				Effects.SendLocationEffect( splash2, m_SmallBoat.Map, 0x352D, 16, 4 );
				Effects.SendLocationEffect( splash3, m_SmallBoat.Map, 0x352D, 16, 4 );
				Effects.SendLocationEffect( splash4, m_SmallBoat.Map, 0x352D, 16, 4 );

				if ( Utility.RandomMinMax( 1, 3 ) == 1 )
				{
					LootChest MyChest = new LootChest( Utility.RandomMinMax( 1, 8 ) );
					MyChest.Name = "Chest Plundered from " + this.Name + " " + this.Title;
					MyChest.MoveToWorld( wreck, Map );
				}

				m_SmallBoat.Delete();
			}

			return base.OnBeforeDeath();   
		}

		public override void OnDeath( Container c )
		{
			base.OnDeath( c );

			switch( Utility.RandomMinMax( 0, 15 ) )
			{
				case 0:		c.DropItem( new ArmysPaeonScroll() ); break;
				case 1:		c.DropItem( new EnchantingEtudeScroll() ); break;
				case 2:		c.DropItem( new EnergyCarolScroll() ); break;
				case 3:		c.DropItem( new EnergyThrenodyScroll() ); break;
				case 4:		c.DropItem( new FireCarolScroll() ); break;
				case 5:		c.DropItem( new FireThrenodyScroll() ); break;
				case 6:		c.DropItem( new FoeRequiemScroll() ); break;
				case 7:		c.DropItem( new IceCarolScroll() ); break;
				case 8:		c.DropItem( new IceThrenodyScroll() ); break;
				case 9:		c.DropItem( new KnightsMinneScroll() ); break;
				case 10:	c.DropItem( new MagesBalladScroll() ); break;
				case 11:	c.DropItem( new MagicFinaleScroll() ); break;
				case 12:	c.DropItem( new PoisonCarolScroll() ); break;
				case 13:	c.DropItem( new PoisonThrenodyScroll() ); break;
				case 14:	c.DropItem( new SheepfoeMamboScroll() ); break;
				case 15:	c.DropItem( new SinewyEtudeScroll() ); break;
			}

			if ( Utility.RandomMinMax( 1, 4 ) == 1 ){ c.DropItem( new RawFishSteak( Utility.RandomMinMax( 1, 8 ) ) ); }
			if ( Utility.RandomMinMax( 1, 4 ) == 1 ){ c.DropItem( new Fish( Utility.RandomMinMax( 1, 8 ) ) ); }
			if ( Utility.RandomMinMax( 1, 4 ) == 1 ){ c.DropItem( new FishingPole() ); }
			if ( Utility.RandomMinMax( 1, 4 ) == 1 ){ c.DropItem( new NewFish() ); }
			if ( Utility.RandomMinMax( 1, 4 ) == 1 ){ c.DropItem( new Sextant() ); }
			if ( Utility.RandomMinMax( 1, 10 ) == 1 )
			{
				HighSeasRelic goods = new HighSeasRelic();
				goods.RelicGoldValue = goods.RelicGoldValue + (int)(this.RawStatTotal/3);
				c.DropItem(goods);
			}
		}

		public override bool ClickTitle{ get{ return false; } }
		public override bool ShowFameTitle{ get{ return false; } }
		public override int TreasureMapLevel{ get{ return Utility.RandomMinMax( 1, 3 ); } }
		public override bool AlwaysAttackable{ get{ return true; } }

		public override void OnThink()
		{
			base.OnThink();

  			if( boatspawn == false )
  			{
				Map map = this.Map;
				
  				if ( map == null )
  					return;
  					
				m_SmallBoat = new SmallBoat();
				Point3D loc = this.Location;
				Point3D loccrew = this.Location;
				loc = new Point3D( this.X, this.Y-1, this.Z );
				this.Z = 0;
				m_SmallBoat.Hue = 0x5BE;
				m_SmallBoat.PPlank.Hue = 0x5BE;
				m_SmallBoat.SPlank.Hue = 0x5BE;
				m_SmallBoat.TillerMan.Hue = 0x5BE;
				m_SmallBoat.Hold.Hue = 0x5BE;
				m_SmallBoat.BoatDoor.Hue = 0x5BE;
				m_SmallBoat.MoveToWorld(loc, map);
				m_SmallBoat.MoveToWorld(loc, map);
				boatspawn = true;
			}
		
			base.OnThink();
			if ( DateTime.UtcNow < m_NextPickup )
				return;

        	if (m_SmallBoat == null)
			{
				return;
			} 

			m_NextPickup = DateTime.UtcNow + TimeSpan.FromSeconds( Utility.RandomMinMax( 5, 10 ) );

			switch( Utility.RandomMinMax( 0, 7 ) )
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
			if ( target == null || Deleted || !Alive || m_NextPeace > DateTime.UtcNow || 0.1 < Utility.RandomDouble() )
				return;

			PlayerMobile p = target as PlayerMobile;

			if ( p != null && p.PeacedUntil < DateTime.UtcNow && !p.Hidden && CanBeHarmful( p ) )
			{
				p.PeacedUntil = DateTime.UtcNow + TimeSpan.FromMinutes( 1 );
				p.SendLocalizedMessage( 500616 ); // You hear lovely music, and forget to continue battling!
				p.FixedParticles( 0x376A, 1, 32, 0x15BD, EffectLayer.Waist );
				p.Combatant = null;

				PlaySound( this.SpeechHue );
			}

			m_NextPeace = DateTime.UtcNow + TimeSpan.FromSeconds( 10 );
		}
		#endregion

		#region Suppress
		private static Dictionary<Mobile, Timer> m_Suppressed = new Dictionary<Mobile, Timer>();
		private DateTime m_NextSuppress;

		public void Suppress( Mobile target )
		{
			if ( target == null || m_Suppressed.ContainsKey( target ) || Deleted || !Alive || m_NextSuppress > DateTime.UtcNow || 0.1 < Utility.RandomDouble() )
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

				PlaySound( this.SpeechHue );
			}

			m_NextSuppress = DateTime.UtcNow + TimeSpan.FromSeconds( 10 );
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
			if ( target == null || Deleted || !Alive || m_NextUndress > DateTime.UtcNow || 0.005 < Utility.RandomDouble() )
				return;

			if ( target.Player && target.Female && !target.Hidden && CanBeHarmful( target ) )
			{
				UndressItem( target, Layer.OuterTorso );
				UndressItem( target, Layer.InnerTorso );
				UndressItem( target, Layer.MiddleTorso );
				UndressItem( target, Layer.Pants );
				UndressItem( target, Layer.Shirt );

				target.SendMessage( "The music makes your blood race. Your clothing is too confining." );
			}

			m_NextUndress = DateTime.UtcNow + TimeSpan.FromMinutes( 1 );
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
			if ( target == null || Deleted || !Alive || m_NextProvoke > DateTime.UtcNow || 0.05 < Utility.RandomDouble() )
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

					PlaySound( this.SpeechHue );
					break;
				}
			}

			m_NextProvoke = DateTime.UtcNow + TimeSpan.FromSeconds( 10 );
		}
		#endregion

		public ElfSailorMinstrel( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
			writer.Write( (Item)m_SmallBoat );
			writer.Write( (bool)boatspawn );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
            m_SmallBoat = reader.ReadItem() as SmallBoat;
            boatspawn = reader.ReadBool();
		}
	}
}