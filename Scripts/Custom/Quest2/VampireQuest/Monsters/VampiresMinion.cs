//////////////////////////
//Created by LostSinner//
////////////////////////
using System;
using System.Collections;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	[CorpseName( "a Vampire Minion's corpse" )]
	public class VampiresMinion : BaseCreature
	{
		[Constructable]
		public VampiresMinion() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Title = "the Vampires Minion";
			Name = "the Walking Dead";
			Body = Utility.RandomList( 50, 56 );
			BaseSoundID = 0x48D;
			Hue = 37;

			SetStr( 160, 175 );
			SetDex( 56, 75 );
			SetInt( 16, 40 );

			SetHits( 400, 470 );

			SetDamage( 10, 12 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 15, 20 );
			SetResistance( ResistanceType.Fire, 5, 10 );
			SetResistance( ResistanceType.Cold, 25, 40 );
			SetResistance( ResistanceType.Poison, 25, 35 );
			SetResistance( ResistanceType.Energy, 5, 15 );

			SetSkill( SkillName.MagicResist, 45.1, 60.0 );
			SetSkill( SkillName.Tactics, 45.1, 60.0 );
			SetSkill( SkillName.Wrestling, 45.1, 55.0 );

			Fame = 450;
			Karma = -450;

			VirtualArmor = 16;
			

			switch ( Utility.Random( 5 ))
			{	
				case 0: PackItem( new VampiresMinionArms() ); break;
				case 1: PackItem( new VampiresMinionGloves() ); break;
				case 2: PackItem( new VampiresMinionHelmet() ); break;
				case 3: PackItem( new VampiresMinionLegs() ); break;
				case 4: PackItem( new VampiresMinionChest() ); break;
			}
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.Average );
			AddLoot( LootPack.MedScrolls, 2 );
			AddLoot( LootPack.Gems, 5 );
		}

		public override Poison PoisonImmune{ get{ return Poison.Lesser; } }

		public VampiresMinion( Serial serial ) : base( serial )
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
