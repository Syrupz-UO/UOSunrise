using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.Misc;

namespace Server.Mobiles
{
	[CorpseName( "a lizardman corpse" )]
	public class AlbinoLizardman : BaseCreature
	{
		public override InhumanSpeech SpeechType{ get{ return InhumanSpeech.Lizardman; } }

		[Constructable]
		public AlbinoLizardman() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = NameList.RandomName( "lizardman" );
                        Hue = 1150;
			Body = Utility.RandomList( 35, 36 );
			BaseSoundID = 417;

			SetStr( 96, 120 );
			SetDex( 86, 105 );
			SetInt( 76, 80 );

			SetHits( 258, 272 );

			SetDamage( 5, 13 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 45, 50 );
			SetResistance( ResistanceType.Fire, 15, 30 );
			SetResistance( ResistanceType.Cold, 15, 30 );
			SetResistance( ResistanceType.Poison, 10, 40 );

			SetSkill( SkillName.MagicResist, 75.1, 90.0 );
			SetSkill( SkillName.Tactics, 75.1, 90.0 );
			SetSkill( SkillName.Wrestling, 80.1, 90.0 );

			Fame = 2500;
			Karma = -2500;

			VirtualArmor = 38;

			if( Utility.RandomDouble() <= 0.01 ) PackItem( new BlessedStatue2() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override int Meat{ get{ return 1; } }
		public override int Hides{ get{ return 12; } }
		public override HideType HideType{ get{ return HideType.Barbed; } }

		public override void OnDeath( Container c )
		{
			base.OnDeath( c );	
			
			c.DropItem( new MerlinsNotes() );
		}

		public AlbinoLizardman( Serial serial ) : base( serial )
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
		}
	}
}