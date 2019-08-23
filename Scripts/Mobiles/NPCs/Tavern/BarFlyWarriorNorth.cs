using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;
using System.Text;
using Server;
using Server.Commands;
using Server.Commands.Generic;
using System.IO;
using Server.Mobiles;
using System.Threading;
using Server.Gumps;
using Server.Accounting;
using Server.Regions;

namespace Server.Mobiles
{
	public class BarFlyWarriorNorth : BasePerson
	{
		private DateTime m_NextTalk;
		public DateTime NextTalk{ get{ return m_NextTalk; } set{ m_NextTalk = value; } }

		[Constructable]
		public BarFlyWarriorNorth() : base( )
		{
			if ( Utility.RandomMinMax( 1, 2 ) == 1 ) 
			{ 
				Body = 401; 
				Name = NameList.RandomName( "female" );
			}
			else 
			{ 
				Body = 400; 			
				Name = NameList.RandomName( "male" ); 
				FacialHairItemID = Utility.RandomList( 0, 0, 8254, 8255, 8256, 8257, 8267, 8268, 8269 );
			}

			Direction = Direction.North;
			Blessed = true;
			CantWalk = true;
			Title = TavernPatrons.GetTitle();
			Hue = Utility.RandomSkinHue();
			Utility.AssignRandomHair( this );
			SpeechHue = Utility.RandomDyedHue();
			NameHue = Utility.RandomOrangeHue();

			SetStr( 386, 400 );
			SetDex( 151, 165 );
			SetInt( 161, 175 );

			SetHits( 300, 400 );

			SetDamage( 8, 10 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 35, 45 );
			SetResistance( ResistanceType.Fire, 25, 30 );
			SetResistance( ResistanceType.Cold, 25, 30 );
			SetResistance( ResistanceType.Poison, 10, 20 );
			SetResistance( ResistanceType.Energy, 10, 20 );

			SetSkill( SkillName.DetectHidden, 80.0 );
			SetSkill( SkillName.Anatomy, 125.0 );
			SetSkill( SkillName.Poisoning, 60.0, 82.5 );
			SetSkill( SkillName.MagicResist, 83.5, 92.5 );
			SetSkill( SkillName.Swords, 125.0 );
			SetSkill( SkillName.Tactics, 125.0 );
			SetSkill( SkillName.Wrestling, 100 );

			Fame = 0;
			Karma = 0;
			VirtualArmor = 30;

			PackItem( new Longsword() );

			AddItem( new Boots( Utility.RandomNeutralHue() ) );
			if ( 1 == Utility.RandomMinMax( 1, 2 ) ){ AddItem( new Cloak( RandomThings.GetRandomColor( 0 ) ) ); }

			int aHue = Utility.RandomList( 0x973, 0x966, 0x96D, 0x972, 0x8A5, 0x979, 0x89F, 0x8AB, 0, Utility.RandomMetalHue(), Utility.RandomMetalHue(), Utility.RandomMetalHue(), Utility.RandomMetalHue(), Utility.RandomMetalHue(), Utility.RandomMetalHue(), Utility.RandomMetalHue() );
			int lHue = Utility.RandomList( 0x8AC, 0x845, 0x851, 0x47E, 0x4AA, 0xB85, 0x497, 0x89F, 0x483, 0, Utility.RandomMetalHue(), Utility.RandomMetalHue(), Utility.RandomMetalHue(), Utility.RandomMetalHue(), Utility.RandomMetalHue(), Utility.RandomMetalHue(), Utility.RandomMetalHue() );

			int iArmor = Utility.RandomMinMax( 1, 4 );

			if ( iArmor == 1 )
			{
				Item cloth1 = new PlateArms();
					cloth1.Hue = aHue;
					AddItem( cloth1 );
				Item cloth2 = new PlateGorget();
					cloth2.Hue = aHue;
					AddItem( cloth2 );
				Item cloth3 = new PlateLegs();
					cloth3.Hue = aHue;
					AddItem( cloth3 );
				Item cloth4 = new PlateChest();
					cloth4.Hue = aHue;
					AddItem( cloth4 );
			}
			else if ( iArmor == 2 )
			{
				Item cloth1 = new ChainChest();
					cloth1.Hue = aHue;
					AddItem( cloth1 );
				Item cloth2 = new ChainLegs();
					cloth2.Hue = aHue;
					AddItem( cloth2 );
				Item cloth3 = new RingmailArms();
					cloth3.Hue = aHue;
					AddItem( cloth3 );
				Item cloth4 = new PlateGorget();
					cloth4.Hue = aHue;
					AddItem( cloth4 );
			}
			else if ( iArmor == 3 )
			{
				Item cloth1 = new StuddedChest();
					cloth1.Hue = lHue;
					AddItem( cloth1 );
				Item cloth2 = new StuddedArms();
					cloth2.Hue = lHue;
					AddItem( cloth2 );
				Item cloth3 = new StuddedLegs();
					cloth3.Hue = lHue;
					AddItem( cloth3 );
				Item cloth4 = new StuddedGorget();
					cloth4.Hue = lHue;
					AddItem( cloth4 );
			}
			else
			{
				Item cloth1 = new LeatherArms();
					cloth1.Hue = lHue;
					AddItem( cloth1 );
				Item cloth2 = new LeatherChest();
					cloth2.Hue = lHue;
					AddItem( cloth2 );
				Item cloth3 = new LeatherGorget();
					cloth3.Hue = lHue;
					AddItem( cloth3 );
				Item cloth4 = new LeatherLegs();
					cloth4.Hue = lHue;
					AddItem( cloth4 );
			}

			int HairColor = Utility.RandomHairHue();
			HairHue = HairColor;
			FacialHairHue = HairColor;
		}

		public BarFlyWarriorNorth( Serial serial ) : base( serial )
		{
		}

		public override void OnMovement( Mobile m, Point3D oldLocation )
		{
			Region reg = Region.Find( this.Location, this.Map );
			if ( DateTime.Now >= m_NextTalk && InRange( m, 30 ) )
			{
				TavernPatrons.GetChatter( this );
				m_NextTalk = (DateTime.Now + TimeSpan.FromSeconds( Utility.RandomMinMax( 15, 45 ) ));
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
		}
	}
}