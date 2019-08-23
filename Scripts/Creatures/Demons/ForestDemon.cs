using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Engines.Plants;

namespace Server.Mobiles
{
	[CorpseName( "a demon corpse" )]
	public class ForestDemon : BaseCreature
	{
		public override double DispelDifficulty{ get{ return 125.0; } }
		public override double DispelFocus{ get{ return 45.0; } }

		[Constructable]
		public ForestDemon () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = NameList.RandomName( "daemon" );
			switch ( Utility.RandomMinMax( 0, 4 ) )
			{
				case 0: Title = "the forest demon"; break;
				case 1: Title = "the demon of the woods"; break;
				case 2: Title = "of demonic woodlands"; break;
				case 3: Title = "of demonic forests"; break;
				case 4: Title = "the woodland demon"; break;
			}
			Body = 9;
			BaseSoundID = 357;
			Hue = 0xB97;

			SetStr( 476, 505 );
			SetDex( 76, 95 );
			SetInt( 301, 325 );

			SetHits( 286, 303 );

			SetDamage( 7, 14 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 45, 60 );
			SetResistance( ResistanceType.Fire, 50, 60 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 20, 30 );
			SetResistance( ResistanceType.Energy, 30, 40 );

			SetSkill( SkillName.EvalInt, 70.1, 80.0 );
			SetSkill( SkillName.Magery, 70.1, 80.0 );
			SetSkill( SkillName.MagicResist, 85.1, 95.0 );
			SetSkill( SkillName.Tactics, 70.1, 80.0 );
			SetSkill( SkillName.Wrestling, 60.1, 80.0 );

			Fame = 15000;
			Karma = -15000;

			VirtualArmor = 58;
			ControlSlots = Core.SE ? 4 : 5;

			PackItem( new Log( 10 ) );

			switch ( Utility.RandomMinMax( 0, 5 ) )
			{
				case 0: Item weed1 = new PlantHerbalism_Leaf(); weed1.Amount = Utility.RandomMinMax( 1, 3 ); PackItem( weed1 ); break;
				case 1: Item weed2 = new PlantHerbalism_Flower(); weed2.Amount = Utility.RandomMinMax( 1, 3 ); PackItem( weed2 ); break;
				case 2: Item weed3 = new PlantHerbalism_Mushroom(); weed3.Amount = Utility.RandomMinMax( 1, 3 ); PackItem( weed3 ); break;
				case 3: Item weed4 = new PlantHerbalism_Lilly(); weed4.Amount = Utility.RandomMinMax( 1, 3 ); PackItem( weed4 ); break;
				case 4: Item weed5 = new PlantHerbalism_Cactus(); weed5.Amount = Utility.RandomMinMax( 1, 3 ); PackItem( weed5 ); break;
				case 5: Item weed6 = new PlantHerbalism_Grass(); weed6.Amount = Utility.RandomMinMax( 1, 3 ); PackItem( weed6 ); break;
			}

			if ( Utility.Random( 100 ) > 60 )
			{
				int seed_to_give = Utility.Random( 100 );

				if ( seed_to_give > 90 )
				{
					Seed reward;

					PlantType type;
					switch ( Utility.Random( 17 ) )
					{
						case 0: type = PlantType.CampionFlowers; break;
						case 1: type = PlantType.Poppies; break;
						case 2: type = PlantType.Snowdrops; break;
						case 3: type = PlantType.Bulrushes; break;
						case 4: type = PlantType.Lilies; break;
						case 5: type = PlantType.PampasGrass; break;
						case 6: type = PlantType.Rushes; break;
						case 7: type = PlantType.ElephantEarPlant; break;
						case 8: type = PlantType.Fern; break;
						case 9: type = PlantType.PonytailPalm; break;
						case 10: type = PlantType.SmallPalm; break;
						case 11: type = PlantType.CenturyPlant; break;
						case 12: type = PlantType.WaterPlant; break;
						case 13: type = PlantType.SnakePlant; break;
						case 14: type = PlantType.PricklyPearCactus; break;
						case 15: type = PlantType.BarrelCactus; break;
						default: type = PlantType.TribarrelCactus; break;
					}
						PlantHue hue;
						switch ( Utility.Random( 4 ) )
						{
							case 0: hue = PlantHue.Pink; break;
							case 1: hue = PlantHue.Magenta; break;
							case 2: hue = PlantHue.FireRed; break;
							default: hue = PlantHue.Aqua; break;
						}

						PackItem( new Seed( type, hue, false ) );
				}
				else if ( seed_to_give > 70 )
				{
					PackItem( Engines.Plants.Seed.RandomPeculiarSeed( Utility.RandomMinMax( 1, 4 ) ) );
				}
				else if ( seed_to_give > 40 )
				{
					PackItem( Engines.Plants.Seed.RandomBonsaiSeed() );
				}
				else
				{
					PackItem( new Engines.Plants.Seed() );
				}
			}
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.Average, 2 );
			AddLoot( LootPack.MedScrolls, 2 );
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Deadly; } }
		public override int TreasureMapLevel{ get{ return 4; } }
		public override bool BleedImmune{ get{ return true; } }
		public override int Hides{ get{ return 18; } }
		public override HideType HideType{ get{ return HideType.Hellish; } }

		public override bool OnBeforeDeath()
		{
			this.Body = 47;
			return base.OnBeforeDeath();
		}

		public override void OnDeath( Container c )
		{
			base.OnDeath( c );
			if ( 1 == Utility.RandomMinMax( 1, 3 ) )
			{
				int quantity = 1;
				switch ( Utility.RandomMinMax( 0, 10 ) )
				{
					case 0: quantity = 2; break;
					case 1: quantity = 2; break;
					case 2: quantity = 2; break;
					case 3: quantity = 2; break;
					case 4: quantity = 3; break;
				}
				OilWood loot = new OilWood();
				loot.Amount = quantity;
				c.DropItem(loot);
			}
			if ( 1 == Utility.RandomMinMax( 1, 2 ) )
			{
				int quantity = 1;
				switch ( Utility.RandomMinMax( 0, 10 ) )
				{
					case 0: quantity = 2; break;
					case 1: quantity = 2; break;
					case 2: quantity = 2; break;
					case 3: quantity = 2; break;
					case 4: quantity = 3; break;
				}
				MysticalTreeSap loot = new MysticalTreeSap();
				loot.Amount = quantity;
				c.DropItem(loot);
			}
			if ( 1 == Utility.RandomMinMax( 1, 2 ) )
			{
				int quantity = 1;
				switch ( Utility.RandomMinMax( 0, 10 ) )
				{
					case 0: quantity = 2; break;
					case 1: quantity = 2; break;
					case 2: quantity = 2; break;
					case 3: quantity = 2; break;
					case 4: quantity = 3; break;
				}
				ReaperOil loot = new ReaperOil();
				loot.Amount = quantity;
				c.DropItem(loot);
			}
		}

		public ForestDemon( Serial serial ) : base( serial )
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
