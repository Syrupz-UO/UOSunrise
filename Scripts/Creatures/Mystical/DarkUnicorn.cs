using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "a dark unicorn corpse" )]
	public class DarkUnicorn : BaseCreature
	{
		[Constructable]
		public DarkUnicorn() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a dark unicorn";
			Body = 27;
			BaseSoundID = 0xA8;

			SetStr( 596, 625 );
			SetDex( 186, 205 );
			SetInt( 186, 225 );

			SetHits( 398, 415 );

			SetDamage( 22, 28 );

			SetDamageType( ResistanceType.Physical, 40 );
			SetDamageType( ResistanceType.Fire, 40 );
			SetDamageType( ResistanceType.Energy, 20 );

			SetResistance( ResistanceType.Physical, 55, 65 );
			SetResistance( ResistanceType.Fire, 30, 40 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 30, 40 );
			SetResistance( ResistanceType.Energy, 20, 30 );

			SetSkill( SkillName.EvalInt, 30.4, 70.0 );
			SetSkill( SkillName.Magery, 30.4, 70.0 );
			SetSkill( SkillName.MagicResist, 105.3, 120.0 );
			SetSkill( SkillName.Tactics, 117.6, 120.0 );
			SetSkill( SkillName.Wrestling, 100.5, 112.5 );

			Fame = 19000;
			Karma = -19000;

			VirtualArmor = 70;

			AddItem( new LightSource() );
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.Average );
			AddLoot( LootPack.LowScrolls );
			AddLoot( LootPack.Potions );
		}

		public override int GetAngerSound()
		{
			if ( !Controlled )
				return 0x16A;

			return base.GetAngerSound();
		}

		public override int Meat{ get{ return 5; } }
		public override int Hides{ get{ return 10; } }
		public override int Furs{ get{ return Utility.RandomList( 0, 0, 0, 5 ); } }
		public override FurType FurType{ get{ return FurType.Regular; } }

		public DarkUnicorn( Serial serial ) : base( serial )
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

			if ( BaseSoundID == 0x16A )
				BaseSoundID = 0xA8;
		}
	}
}