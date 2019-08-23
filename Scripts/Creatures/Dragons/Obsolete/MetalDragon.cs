using System;
using Server;
using Server.Items;
using Server.Misc;

namespace Server.Mobiles
{
	[CorpseName( "a dragon corpse" )]
	public class MetalDragon : BaseCreature
	{
		public override bool ReacquireOnMovement{ get{ return !Controlled; } }
		public override bool HasBreath{ get{ return true; } }
		public override void BreathDealDamage( Mobile target, int form ){ base.BreathDealDamage( target, 9 ); }

		[Constructable]
		public MetalDragon () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a metallic dragon";
			Body = 59;
			BaseSoundID = 362;
			Hue = MaterialInfo.GetMaterialColor( "copper", "monster", Hue );

			SetStr( 796, 825 );
			SetDex( 86, 105 );
			SetInt( 436, 475 );

			SetHits( 478, 495 );

			SetDamage( 16, 22 );

			SetDamageType( ResistanceType.Physical, 75 );
			SetDamageType( ResistanceType.Fire, 25 );

			SetResistance( ResistanceType.Physical, 55, 65 );
			SetResistance( ResistanceType.Fire, 60, 70 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 25, 35 );
			SetResistance( ResistanceType.Energy, 35, 45 );

			SetSkill( SkillName.EvalInt, 30.1, 40.0 );
			SetSkill( SkillName.Magery, 30.1, 40.0 );
			SetSkill( SkillName.MagicResist, 99.1, 100.0 );
			SetSkill( SkillName.Tactics, 97.6, 100.0 );
			SetSkill( SkillName.Wrestling, 90.1, 92.5 );

			Fame = 15000;
			Karma = -15000;

			VirtualArmor = 60;

			Tamable = true;
			ControlSlots = 3;
			MinTameSkill = 93.9;
		}

		public override void OnAfterSpawn()
		{
			bool IsChromatic = false;
			switch ( Utility.RandomMinMax( 0, 20 ) )
			{
				case 0: Hue = MaterialInfo.GetMaterialColor( "jade", "monster", 0 ); IsChromatic = true; break;  // jade
				case 1: Hue = MaterialInfo.GetMaterialColor( "onyx", "monster", 0 ); IsChromatic = true; break;  // onyx
				case 2: Hue = MaterialInfo.GetMaterialColor( "quartz", "monster", 0 ); IsChromatic = true; break;  // quartz
				case 3: Hue = MaterialInfo.GetMaterialColor( "ruby", "monster", 0 ); IsChromatic = true; break;  // ruby
				case 4: Hue = MaterialInfo.GetMaterialColor( "sapphire", "monster", 0 ); IsChromatic = true; break;  // sapphire
				case 5: Hue = MaterialInfo.GetMaterialColor( "spinel", "monster", 0 ); IsChromatic = true; break;  // spinel
				case 6: Hue = MaterialInfo.GetMaterialColor( "topaz", "monster", 0 ); IsChromatic = true; break;  // topaz
				case 7: Hue = MaterialInfo.GetMaterialColor( "amethyst", "monster", 0 ); IsChromatic = true; break;  // amethyst
				case 8: Hue = MaterialInfo.GetMaterialColor( "emerald", "monster", 0 ); IsChromatic = true; break;  // emerald
				case 9: Hue = MaterialInfo.GetMaterialColor( "garnet", "monster", 0 ); IsChromatic = true; break;  // garnet
				case 10: Hue = MaterialInfo.GetMaterialColor( "silver", "monster", 0 ); break;  // silver
				case 11: Hue = MaterialInfo.GetMaterialColor( "star ruby", "monster", 0 ); IsChromatic = true; break; // star ruby
				case 12: Hue = MaterialInfo.GetMaterialColor( "copper", "monster", Hue ); break; // Copper
				case 13: Hue = MaterialInfo.GetMaterialColor( "verite", "monster", Hue ); break; // Verite
				case 14: Hue = MaterialInfo.GetMaterialColor( "valorite", "monster", Hue ); break; // Valorite
				case 15: Hue = MaterialInfo.GetMaterialColor( "agapite", "monster", Hue ); break; // Agapite
				case 16: Hue = MaterialInfo.GetMaterialColor( "bronze", "monster", Hue ); break; // Bronze
				case 17: Hue = MaterialInfo.GetMaterialColor( "dull copper", "monster", Hue ); break; // Dull Copper
				case 18: Hue = MaterialInfo.GetMaterialColor( "gold", "monster", Hue ); break; // Gold
				case 19: Hue = MaterialInfo.GetMaterialColor( "shadow iron", "monster", Hue ); break; // Shadow Iron
				case 20:
					if ( Worlds.IsExploringSeaAreas( this ) == true ){ Hue = MaterialInfo.GetMaterialColor( "nepturite", "monster", 0 ); }
					else if ( Worlds.GetMyWorld( this.Map, this.Location, this.X, this.Y ) == "the Savaged Empire" ){ Hue = MaterialInfo.GetMaterialColor( "steel", "monster", Hue ); }
					else if ( Worlds.GetMyWorld( this.Map, this.Location, this.X, this.Y ) == "the Serpent Island" ){ Hue = MaterialInfo.GetMaterialColor( "obsidian", "monster", Hue ); }
					else if ( Worlds.GetMyWorld( this.Map, this.Location, this.X, this.Y ) == "the Island of Umber Veil" ){ Hue = MaterialInfo.GetMaterialColor( "brass", "monster", Hue ); }
					else if ( Worlds.GetMyWorld( this.Map, this.Location, this.X, this.Y ) == "the Underworld" && this.Map == Map.TerMur ){ Hue = MaterialInfo.GetMaterialColor( "xormite", "monster", Hue ); }
					else if ( Worlds.GetMyWorld( this.Map, this.Location, this.X, this.Y ) == "the Underworld" ){ Hue = MaterialInfo.GetMaterialColor( "copper", "mithril", Hue ); }
					break; // Special
			}

			if ( IsChromatic ){ this.Name = "a chromatic dragon"; }

			base.OnAfterSpawn();
		}

		public override void OnDeath( Container c )
		{
			base.OnDeath( c );

			string metal = "Iron";

			if ( this.Hue == MaterialInfo.GetMaterialColor( "onyx", "monster", 0 ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "onyx scales" );
				c.DropItem(scale);
				metal = "Onyx";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "quartz", "monster", 0 ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "quartz scales" );
				c.DropItem(scale);
				metal = "Quartz";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "ruby", "monster", 0 ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "ruby scales" );
				c.DropItem(scale);
				metal = "Ruby";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "sapphire", "monster", 0 ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "sapphire scales" );
				c.DropItem(scale);
				metal = "Sapphire";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "spinel", "monster", 0 ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "spinel scales" );
				c.DropItem(scale);
				metal = "Spinel";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "topaz", "monster", 0 ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "topaz scales" );
				c.DropItem(scale);
				metal = "Topaz";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "amethyst", "monster", 0 ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "amethyst scales" );
				c.DropItem(scale);
				metal = "Amethyst";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "emerald", "monster", 0 ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "emerald scales" );
				c.DropItem(scale);
				metal = "Emerald";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "garnet", "monster", 0 ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "garnet scales" );
				c.DropItem(scale);
				metal = "Garnet";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "silver", "monster", 0 ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "silver scales" );
				c.DropItem(scale);
				metal = "Silver";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "star ruby", "monster", 0 ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "star ruby scales" );
				c.DropItem(scale);
				metal = "Star Ruby";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "jade", "monster", 0 ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "jade scales" );
				c.DropItem(scale);
				metal = "Jade";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "copper", "monster", Hue ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "copper scales" );
				c.DropItem(scale);
				metal = "Copper";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "verite", "monster", Hue ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "verite scales" );
				c.DropItem(scale);
				metal = "Verite";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "valorite", "monster", Hue ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "valorite scales" );
				c.DropItem(scale);
				metal = "Valorite";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "agapite", "monster", Hue ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "agapite scales" );
				c.DropItem(scale);
				metal = "Agapite";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "bronze", "monster", Hue ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "bronze scales" );
				c.DropItem(scale);
				metal = "Bronze";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "dull copper", "monster", Hue ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "dull copper scales" );
				c.DropItem(scale);
				metal = "Dull Copper";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "gold", "monster", Hue ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "gold scales" );
				c.DropItem(scale);
				metal = "Golden";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "shadow iron", "monster", Hue ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "shadow iron scales" );
				c.DropItem(scale);
				metal = "Shadow Iron";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "brass", "monster", Hue ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "brass scales" );
				c.DropItem(scale);
				metal = "Brass";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "steel", "monster", Hue ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "steel scales" );
				c.DropItem(scale);
				metal = "Steel";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "mithril", "monster", Hue ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "mithril scales" );
				c.DropItem(scale);
				metal = "Mithril";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "xormite", "monster", Hue ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "xormite scales" );
				c.DropItem(scale);
				metal = "Xormite";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "obsidian", "monster", Hue ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "obsidian scales" );
				c.DropItem(scale);
				metal = "Obsidian";
			}
			else if ( this.Hue == MaterialInfo.GetMaterialColor( "nepturite", "monster", Hue ) )
			{
				Item scale = new HardScales( Utility.RandomMinMax( 10, 50 ), "nepturite scales" );
				c.DropItem(scale);
				metal = "Nepturite";
			}

			Mobile killer = this.LastKiller;
			if ( killer != null )
			{
				if ( killer is BaseCreature )
					killer = ((BaseCreature)killer).GetMaster();

				if ( killer is PlayerMobile )
				{
					if ( GetPlayerInfo.LuckyKiller( killer.Luck ) && Utility.RandomMinMax( 1, 25 ) == 1 )
					{
						DragonLamp lamp = new DragonLamp();
						lamp.Hue = this.Hue;
						lamp.LampName = "";
						lamp.LampColor = metal;
						c.DropItem( lamp );
					}
				}
			}
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 2 );
			AddLoot( LootPack.Gems, 8 );
		}

		public override bool AutoDispel{ get{ return !Controlled; } }
		public override int TreasureMapLevel{ get{ return 4; } }
		public override bool BleedImmune{ get{ return true; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Gold; } }
		public override bool CanAngerOnTame { get { return true; } }

		public MetalDragon( Serial serial ) : base( serial )
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