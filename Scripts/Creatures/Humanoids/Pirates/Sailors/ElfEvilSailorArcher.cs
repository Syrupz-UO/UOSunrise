using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;
using Server;
using System.Collections.Generic;
using Server.Targeting;
using Server.Multis;

namespace Server.Mobiles
{
	public class ElfEvilSailorArcher : BaseCreature
	{
        private SmallBoat m_SmallBoat;
        private bool boatspawn;
		private DateTime m_NextPickup;

		[Constructable]
		public ElfEvilSailorArcher() : base( AIType.AI_Archer, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			SpeechHue = Utility.RandomDyedHue();

			switch ( Utility.RandomMinMax( 0, 4 ) )
			{
				case 0: Title = "the drow buccaneer"; break;
				case 1: Title = "the drow pirate"; break;
				case 2: Title = "the drow privateer"; break;
				case 3: Title = "the drow archer"; break;
				case 4: Title = "the drow freebooter"; break;
			}

			Race = Race.Elf;
			Hue = 1316;
            HairHue = 1150;

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
			Karma = -2000;

            AddItem( new ElvenBoots( 0x6F8 ) );
            Item armor = new LeatherChest(); armor.Hue = 0x6F8; AddItem( armor );
			AddItem( new FancyShirt( 0 ) );	

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

			switch ( Utility.Random( 2 ))
			{
				case 0: AddItem( new Crossbow() ); PackItem( new Bolt( Utility.RandomMinMax( 15, 55 ) ) ); break;
				case 1: AddItem( new Bow() ); PackItem( new Arrow( Utility.RandomMinMax( 15, 55 ) ) ); break;
			}
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Average );
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

		public ElfEvilSailorArcher( Serial serial ) : base( serial )
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