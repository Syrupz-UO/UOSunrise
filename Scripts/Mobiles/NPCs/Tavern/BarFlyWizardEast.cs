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
	public class BarFlyWizardEast : BasePerson
	{
		private DateTime m_NextTalk;
		public DateTime NextTalk{ get{ return m_NextTalk; } set{ m_NextTalk = value; } }

		[Constructable]
		public BarFlyWizardEast() : base( )
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

			Blessed = true;
			CantWalk = true;
			Direction = Direction.East;
			Title = TavernPatrons.GetTitle();
			Hue = Utility.RandomSkinHue();
			Utility.AssignRandomHair( this );
			SpeechHue = Utility.RandomDyedHue();
			NameHue = Utility.RandomOrangeHue();

			SetStr( 161, 175 );
			SetDex( 151, 165 );
			SetInt( 386, 400 );

			SetHits( 160, 175 );

			SetDamage( 8, 10 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 35, 45 );
			SetResistance( ResistanceType.Fire, 25, 30 );
			SetResistance( ResistanceType.Cold, 25, 30 );
			SetResistance( ResistanceType.Poison, 10, 20 );
			SetResistance( ResistanceType.Energy, 10, 20 );

			SetSkill( SkillName.DetectHidden, 80.0 );
			SetSkill( SkillName.EvalInt, 125.0 );
			SetSkill( SkillName.Poisoning, 60.0, 82.5 );
			SetSkill( SkillName.MagicResist, 83.5, 92.5 );
			SetSkill( SkillName.Magery, 125.0 );
			SetSkill( SkillName.Tactics, 125.0 );
			SetSkill( SkillName.Wrestling, 100 );

			Fame = 0;
			Karma = 0;
			VirtualArmor = 30;

			PackItem( new BlackStaff() );

			int aHue = RandomThings.GetRandomColor( 0 );

			AddItem( new Boots( Utility.RandomNeutralHue() ) );
			if ( 1 == Utility.RandomMinMax( 1, 2 ) ){ AddItem( new Cloak( aHue ) ); }

			int iArmor = Utility.RandomMinMax( 1, 3 );

			if ( iArmor == 1 )
			{
				Item cloth1 = new Robe();
					cloth1.Hue = aHue;
					AddItem( cloth1 );
				Item cloth2 = new WizardsHat();
					cloth2.Hue = aHue;
					AddItem( cloth2 );
			}
			else if ( iArmor == 2 )
			{
				Item cloth1 = new Robe();
					cloth1.Hue = aHue;
					AddItem( cloth1 );
			}
			else
			{
				Item cloth1 = new FancyShirt();
					cloth1.Hue = aHue;
					AddItem( cloth1 );
				Item cloth2 = new LongPants();
					cloth2.Hue = Utility.RandomNeutralHue();
					AddItem( cloth2 );
			}

			int HairColor = Utility.RandomHairHue();
			HairHue = HairColor;
			FacialHairHue = HairColor;
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

		public BarFlyWizardEast( Serial serial ) : base( serial )
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
	}
}