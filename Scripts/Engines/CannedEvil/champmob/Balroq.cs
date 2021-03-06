using System;
using Server;
using Server.Items;
using Server.Engines.CannedEvil;

namespace Server.Mobiles
{
	[CorpseName( "a Balroq corpse" )]
	public class ABalroq : BaseCreature
	{
		[Constructable]
		public ABalroq () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = " A Balroq";
			Body = 9;
            Hue = 2019;
			BaseSoundID = 357;

			SetStr( 850, 1485 );
			SetDex( 850, 2000 );
			SetInt( 251, 350 );

			SetHits( 1500, 2000 );

			SetDamage( 35, 95 );

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Fire, 25 );
			SetDamageType( ResistanceType.Energy, 25 );

			SetResistance( ResistanceType.Physical, 65, 80 );
			SetResistance( ResistanceType.Fire, 60, 80 );
			SetResistance( ResistanceType.Cold, 50, 60 );
			SetResistance( ResistanceType.Poison, 100 );
			SetResistance( ResistanceType.Energy, 40, 50 );

			SetSkill( SkillName.Anatomy, 25.1, 50.0 );
			SetSkill( SkillName.EvalInt, 90.1, 100.0 );
			SetSkill( SkillName.Magery, 95.5, 100.0 );
			SetSkill( SkillName.Meditation, 25.1, 50.0 );
			SetSkill( SkillName.MagicResist, 100.5, 150.0 );
			SetSkill( SkillName.Tactics, 90.1, 100.0 );
			SetSkill( SkillName.Wrestling, 90.1, 100.0 );

			Fame = 14000;
			Karma = -14000;

			VirtualArmor = 90;

			PackItem( new Longsword() );
			//if( Utility.RandomDouble() <= 0.01 ) PackItem( new SemidisRobe() );
		}

		public override void GenerateLoot()
		{
			if (this.Region is ChampionSpawnRegion)
			{
			return;
			}
			else
			{
			AddLoot( LootPack.FilthyRich, 2 );
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.MedScrolls, 2 );
			AddLoot( LootPack.Gems, 5 );
		}
		}
		public override bool CanRummageCorpses{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Deadly; } }
		public override int TreasureMapLevel{ get{ return 5; } }
		public override int Meat{ get{ return 1; } }
		public override bool AlwaysMurderer{ get{ return true; } }
		public override bool Uncalmable{ get{ return Core.SE; } }

		public ABalroq( Serial serial ) : base( serial )
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