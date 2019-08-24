using System;
using Server;
using Server.Misc;
using Server.Items;
using System.Collections;
using System.Collections.Generic;
using Server.Targeting;
using Server.Multis;

namespace Server.Mobiles 
{
	public class ElfSailorWizard : BaseCreature 
	{
        private SmallBoat m_SmallBoat;
        private bool boatspawn;
		private DateTime m_NextPickup;
		
		[Constructable] 
		public ElfSailorWizard() : base( AIType.AI_Mage, FightMode.Aggressor, 10, 1, 0.2, 0.4 ) 
		{
			if ( this.Female = Utility.RandomBool() ) 
			{ 
				Body = 606;
				Name = NameList.RandomName( "elf_female" );
				switch ( Utility.RandomMinMax( 0, 5 ) )
				{
					case 0: Title = "the elf wizard"; break;
					case 1: Title = "the elf sorceress"; break;
					case 2: Title = "the elf mage"; break;
					case 3: Title = "the elf conjurer"; break;
					case 4: Title = "the elf magician"; break;
					case 5: Title = "the elf sailor"; break;
					case 6: Title = "the elf fisherman"; break;
					case 7: Title = "the elf sailor"; break;
					case 8: Title = "the elf fisherman"; break;
				}

				Utility.AssignRandomHair( this );
			} 
			else 
			{ 
				Body = 605;
				Name = NameList.RandomName( "elf_male" );
				switch ( Utility.RandomMinMax( 0, 5 ) )
				{
					case 0: Title = "the elf wizard"; break;
					case 1: Title = "the elf sorcerer"; break;
					case 2: Title = "the elf mage"; break;
					case 3: Title = "the elf conjurer"; break;
					case 4: Title = "the elf magician"; break;
					case 5: Title = "the elf sailor"; break;
					case 6: Title = "the elf fisherman"; break;
					case 7: Title = "the elf sailor"; break;
					case 8: Title = "the elf fisherman"; break;
				}

				Utility.AssignRandomHair( this );
			}

			Race = Race.Elf;
			Hue = Utility.RandomSkinHue();
			HairHue = Utility.RandomHairHue();

			int clothHue = Utility.RandomMinMax( 0, 12 );

			Robe robe = new Robe( );
				robe.Hue = RandomThings.GetRandomColor( clothHue );
				AddItem( robe );

			if ( 50 > Utility.Random( 100 ) )
			{ 
				WizardsHat hat = new WizardsHat( );
					hat.Hue = RandomThings.GetRandomColor( clothHue );
					AddItem( hat );
			}

			Item boots = new ThighBoots( );
				boots.Hue = Utility.RandomNeutralHue();
				AddItem( boots );

			SetStr( 76, 100 );
			SetDex( 76, 95 );
			SetInt( 36, 60 );

			SetHits( 46, 60 );

			SetDamage( 7, 11 );

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Cold, 50 );

			SetResistance( ResistanceType.Physical, 25, 30 );
			SetResistance( ResistanceType.Cold, 15, 25 );
			SetResistance( ResistanceType.Poison, 10, 20 );

			SetSkill( SkillName.EvalInt, 55.1, 70.0 );
			SetSkill( SkillName.Magery, 55.1, 70.0 );
			SetSkill( SkillName.MagicResist, 55.1, 70.0 );
			SetSkill( SkillName.Tactics, 45.1, 60.0 );
			SetSkill( SkillName.Wrestling, 45.1, 55.0 );

			Fame = 2500;
			Karma = 2500;

			VirtualArmor = 28;

			PackReg( Utility.RandomMinMax( 2, 8 ) );
			PackReg( Utility.RandomMinMax( 2, 8 ) );
			PackReg( Utility.RandomMinMax( 2, 8 ) );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
			AddLoot( LootPack.LowScrolls );
		}
		
		public override bool ClickTitle{ get{ return false; } }
		public override bool ShowFameTitle{ get{ return false; } }
		public override int TreasureMapLevel{ get{ return Utility.RandomMinMax( 1, 3 ); } }
		public override bool AlwaysAttackable{ get{ return true; } }

		public override void OnThink()
		{
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

			m_NextPickup = DateTime.UtcNow + TimeSpan.FromSeconds( Utility.RandomMinMax( 1, 2 ) );
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

		public ElfSailorWizard( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
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