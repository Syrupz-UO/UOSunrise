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
	public class Citizen : BaseCreature
	{
		private DateTime m_NextTalk;
		public DateTime NextTalk{ get{ return m_NextTalk; } set{ m_NextTalk = value; } }

		[Constructable]
		public Citizen() : base( AIType.AI_Citizen, FightMode.None, 10, 1, 0.2, 0.4 )
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

			switch ( Utility.Random( 3 ) )
			{
				case 0: Server.Misc.IntelligentAction.DressUpWizards( this ); break;
				case 1: Server.Misc.IntelligentAction.DressUpFighters( this, "" ); break;
				case 2: Server.Misc.IntelligentAction.DressUpRogues( this, "" ); break;
			}

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

			int HairColor = Utility.RandomHairHue();
			HairHue = HairColor;
			FacialHairHue = HairColor;
		}

		public override void OnMovement( Mobile m, Point3D oldLocation )
		{
			Region reg = Region.Find( this.Location, this.Map );
			if ( DateTime.Now >= m_NextTalk && InRange( m, 30 ) )
			{
				if ( Utility.RandomBool() ){ TavernPatrons.GetChatter( this ); }
				m_NextTalk = (DateTime.Now + TimeSpan.FromSeconds( Utility.RandomMinMax( 15, 45 ) ));
			}
		}

		public static void PopulateCities()
		{
			ArrayList wanderers = new ArrayList();
			foreach ( Mobile wanderer in World.Mobiles.Values )
			{
				if ( wanderer is Citizen )
				{
					wanderers.Add( wanderer );
				}
			}
			for ( int i = 0; i < wanderers.Count; ++i )
			{
				Mobile person = ( Mobile )wanderers[ i ];
				Effects.SendLocationParticles( EffectItem.Create( person.Location, person.Map, EffectItem.DefaultDuration ), 0x3728, 10, 10, 2023 );
				person.PlaySound( 0x1FE );
				person.Delete();
			}

			ArrayList meetingSpots = new ArrayList();
			foreach ( Item item in World.Items.Values )
			{
				if ( item is MeetingSpots )
				{
					meetingSpots.Add( item );
				}
			}
			for ( int i = 0; i < meetingSpots.Count; ++i )
			{
				Item spot = ( Item )meetingSpots[ i ];
				if ( PeopleMeetingHere() ){ CreateCitizens( spot ); }
			}
		}

		public static void CreateCitizens ( Item spot )
		{
			int total = 0;
			int mod = 2;

			bool mount = false; if ( Utility.RandomBool() ){ mount = true; mod = 3; }

			Point3D cit1 = new Point3D( ( spot.X-2 ), ( spot.Y ),   	spot.Z );	Direction dir1 = Direction.East;
			Point3D cit2 = new Point3D( ( spot.X   ), ( spot.Y-mod ),   spot.Z );	Direction dir2 = Direction.South;
			Point3D cit3 = new Point3D( ( spot.X+mod ), ( spot.Y ),   	spot.Z );	Direction dir3 = Direction.West;
			Point3D cit4 = new Point3D( ( spot.X   ), ( spot.Y+2 ),		spot.Z );	Direction dir4 = Direction.North;

			if ( Utility.RandomMinMax( 1, 2 ) == 1 )
			{
				total++;
				Mobile citizen1 = new Citizen();
				citizen1.MoveToWorld( cit1, spot.Map );
				if ( mount ){ MountCitizen ( citizen1 ); }
				citizen1.Direction = dir1;
				((BaseCreature)citizen1).ControlSlots = 2;
				Effects.SendLocationParticles( EffectItem.Create( citizen1.Location, citizen1.Map, EffectItem.DefaultDuration ), 0x3728, 10, 10, 2023 );
				citizen1.PlaySound( 0x1FE );
			}
			if ( Utility.RandomMinMax( 1, 3 ) == 1 )
			{
				total++;
				Mobile citizen2 = new Citizen();
				citizen2.MoveToWorld( cit2, spot.Map );
				if ( mount ){ MountCitizen ( citizen2 ); }
				citizen2.Direction = dir2;
				((BaseCreature)citizen2).ControlSlots = 3;
				Effects.SendLocationParticles( EffectItem.Create( citizen2.Location, citizen2.Map, EffectItem.DefaultDuration ), 0x3728, 10, 10, 2023 );
				citizen2.PlaySound( 0x1FE );
			}
			if ( Utility.RandomMinMax( 1, 4 ) == 1 || total == 0 )
			{
				total++;
				Mobile citizen3 = new Citizen();
				citizen3.MoveToWorld( cit3, spot.Map );
				if ( mount ){ MountCitizen ( citizen3 ); }
				citizen3.Direction = dir3;
				((BaseCreature)citizen3).ControlSlots = 4;
				Effects.SendLocationParticles( EffectItem.Create( citizen3.Location, citizen3.Map, EffectItem.DefaultDuration ), 0x3728, 10, 10, 2023 );
				citizen3.PlaySound( 0x1FE );
			}
			if ( Utility.RandomMinMax( 1, 4 ) == 1 || total < 2 )
			{
				total++;
				Mobile citizen4 = new Citizen();
				citizen4.MoveToWorld( cit4, spot.Map );
				if ( mount ){ MountCitizen ( citizen4 ); }
				citizen4.Direction = dir4;
				((BaseCreature)citizen4).ControlSlots = 5;
				Effects.SendLocationParticles( EffectItem.Create( citizen4.Location, citizen4.Map, EffectItem.DefaultDuration ), 0x3728, 10, 10, 2023 );
				citizen4.PlaySound( 0x1FE );
			}
		}

		public static void MountCitizen ( Mobile m )
		{
			if ( m.Map == Map.Trammel && m.X >= 2954 && m.Y >= 893 && m.X <= 3028 && m.Y <= 969 ){ /* DO NOTHING IN CASTLE BRITISH */ }
			else if ( m.Map == Map.Felucca && m.X >= 1759 && m.Y >= 2195 && m.X <= 1821 && m.Y <= 2241 ){ /* DO NOTHING IN CASTLE OF KNOWLEDGE */ }
			else
			{
				switch ( Utility.Random( 14 ) )
				{
					case 0: new Horse().Rider = m; break;
					case 1: new Horse().Rider = m; break;
					case 2: new Horse().Rider = m; break;
					case 3: new Horse().Rider = m; break;
					case 4: new Horse().Rider = m; break;
					case 5: new Horse().Rider = m; break;
					case 6: new Horse().Rider = m; break;
					case 7: new Horse().Rider = m; break;
					case 8: new GreatBear().Rider = m; break;
					case 9: new DireBear().Rider = m; break;
					case 10: new PolarBear().Rider = m; break;
					case 11: new KodiakBear().Rider = m; break;
					case 12: new ForestOstard().Rider = m; break;
					case 13: new DesertOstard().Rider = m; break;
				}
			}
		}

		public static bool PeopleMeetingHere()
		{
			if ( Utility.RandomMinMax( 1, 2 ) == 1 )
				return true;

			return false;
		}

		public Citizen( Serial serial ) : base( serial )
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