using System;
using System.Collections;
using Server.Misc;
using Server.Items;
using Server.Targeting;
using Server.Engines.CannedEvil;

namespace Server.Mobiles
{
	[CorpseName( "a ratman archer corpse" )]
	public class ARatmanArcher : BaseCreature
	{
		public override InhumanSpeech SpeechType{ get{ return InhumanSpeech.Ratman; } }

		[Constructable]
		public ARatmanArcher() : base( AIType.AI_Archer, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = NameList.RandomName( "ratman" );
			Title = "the ratman";
			Body = 42;
			BaseSoundID = 437;

			SetStr( 146, 180 );
			SetDex( 101, 130 );
			SetInt( 116, 140 );

			SetHits( 88, 108 );

			SetDamage( 4, 10 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 40, 55 );
			SetResistance( ResistanceType.Fire, 10, 20 );
			SetResistance( ResistanceType.Cold, 10, 20 );
			SetResistance( ResistanceType.Poison, 10, 20 );
			SetResistance( ResistanceType.Energy, 10, 20 );

			SetSkill( SkillName.Anatomy, 60.2, 100.0 );
			SetSkill( SkillName.Archery, 80.1, 90.0 );
			SetSkill( SkillName.MagicResist, 65.1, 90.0 );
			SetSkill( SkillName.Tactics, 50.1, 75.0 );
			SetSkill( SkillName.Wrestling, 50.1, 75.0 );

			Fame = 6500;
			Karma = -6500;

			VirtualArmor = 56;

			AddItem( new Bow() );
			PackItem( new Arrow( Utility.RandomMinMax( 5, 15 ) ) ); // WIZARD CHANGED
		}

		public override void GenerateLoot()
		{
			if (this.Region is ChampionSpawnRegion)
			{
			return;
			}
			else
			{
			AddLoot( LootPack.Rich );
		}
		}
		public override bool CanRummageCorpses{ get{ return true; } }
		public override int Hides{ get{ return 8; } }

		public ARatmanArcher( Serial serial ) : base( serial )
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
