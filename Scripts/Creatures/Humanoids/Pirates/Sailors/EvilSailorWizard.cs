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
	public class EvilSailorWizard : BaseCreature 
	{
        private SmallBoat m_SmallBoat;
        private bool boatspawn;
		private DateTime m_NextPickup;
		
		[Constructable] 
		public EvilSailorWizard() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 ) 
		{ 
			if ( this.Female = Utility.RandomBool() ) 
			{ 
				Body = 0x191; 
				Name = NameList.RandomName( "female" );
				switch ( Utility.RandomMinMax( 0, 8 ) )
				{
					case 0: Title = "the wizard"; break;
					case 1: Title = "the sorceress"; break;
					case 2: Title = "the mage"; break;
					case 3: Title = "the conjurer"; break;
					case 4: Title = "the magician"; break;
					case 5: Title = "the pirate"; break;
					case 6: Title = "the buccaneer"; break;
					case 7: Title = "the pirate"; break;
					case 8: Title = "the buccaneer"; break;
				}

				Utility.AssignRandomHair( this );
				HairHue = Utility.RandomHairHue();
			} 
			else 
			{ 
				Body = 0x190; 
				Name = NameList.RandomName( "male" );
				switch ( Utility.RandomMinMax( 0, 8 ) )
				{
					case 0: Title = "the wizard"; break;
					case 1: Title = "the sorcerer"; break;
					case 2: Title = "the mage"; break;
					case 3: Title = "the conjurer"; break;
					case 4: Title = "the magician"; break;
					case 5: Title = "the pirate"; break;
					case 6: Title = "the buccaneer"; break;
					case 7: Title = "the pirate"; break;
					case 8: Title = "the buccaneer"; break;
				}

				Utility.AssignRandomHair( this );
				int HairColor = Utility.RandomHairHue();
				FacialHairItemID = Utility.RandomList( 0, 8254, 8255, 8256, 8257, 8267, 8268, 8269 );
				HairHue = HairColor;
				FacialHairHue = HairColor;
			}

			Hue = Utility.RandomSkinHue();

            AddItem( new ElvenBoots( 0x83A ) );
            Item armor = new LeatherChest(); armor.Hue = 0x83A; AddItem( armor );
			AddItem( new FancyShirt( 0 ) );	
            AddItem( new Cloak( 0x83A ) );

            switch ( Utility.Random( 2 ))
			{
				case 0: AddItem( new LongPants ( 0xBB4 ) ); break;
				case 1: AddItem( new ShortPants ( 0xBB4 ) ); break;
			}				

			switch ( Utility.Random( 2 ))
			{
				case 0: AddItem( new Bandana ( 0x846 ) ); break;
				case 1: AddItem( new SkullCap ( 0x846 ) ); break;
			}		

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
			Karma = -2500;

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

		public EvilSailorWizard( Serial serial ) : base( serial )
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