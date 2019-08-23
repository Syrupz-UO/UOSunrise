using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a wyrm corpse" )]
	public class SpinelWyrm : BaseCreature
	{
		public override int BreathPhysicalDamage{ get{ return 0; } }
		public override int BreathFireDamage{ get{ return 0; } }
		public override int BreathColdDamage{ get{ return 0; } }
		public override int BreathPoisonDamage{ get{ return 0; } }
		public override int BreathEnergyDamage{ get{ return 100; } }
		public override int BreathEffectHue{ get{ return 0x9C2; } }
		public override int BreathEffectSound{ get{ return 0x665; } }
		public override int BreathEffectItemID{ get{ return 0x3818; } }
		public override bool ReacquireOnMovement{ get{ return !Controlled; } }
		public override bool HasBreath{ get{ return true; } }
		public override void BreathDealDamage( Mobile target, int form ){ base.BreathDealDamage( target, 1 ); }

		[Constructable]
		public SpinelWyrm () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = NameList.RandomName( "dragon" );
			Title = "the spinel wyrm";
			BaseSoundID = 362;
			Body = Server.Mobiles.Wyrms.WyrmBody();
			Hue = Server.Misc.MaterialInfo.GetMaterialColor( "spinel", "monster", 0 );

			SetStr( 721, 760 );
			SetDex( 101, 130 );
			SetInt( 386, 425 );

			SetHits( 433, 456 );

			SetDamage( 17, 25 );

			SetDamageType( ResistanceType.Physical, 75 );
			SetDamageType( ResistanceType.Energy, 25 );

			SetResistance( ResistanceType.Physical, 55, 70 );
			SetResistance( ResistanceType.Fire, 40, 50 );
			SetResistance( ResistanceType.Energy, 80, 90 );
			SetResistance( ResistanceType.Poison, 40, 50 );
			SetResistance( ResistanceType.Cold, 40, 50 );

			SetSkill( SkillName.EvalInt, 99.1, 100.0 );
			SetSkill( SkillName.Magery, 99.1, 100.0 );
			SetSkill( SkillName.MagicResist, 99.1, 100.0 );
			SetSkill( SkillName.Tactics, 97.6, 100.0 );
			SetSkill( SkillName.Wrestling, 90.1, 100.0 );

			Fame = 18000;
			Karma = -18000;

			VirtualArmor = 64;

			Tamable = true;
			ControlSlots = 3;
			MinTameSkill = 96.3;
		}

		public override void OnDeath( Container c )
		{
			base.OnDeath( c );

			Item scale = new HardScales( Utility.RandomMinMax( 15, 20 ), "spinel scales" );
   			c.DropItem(scale);
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 2 );
			AddLoot( LootPack.Average );
			AddLoot( LootPack.Gems, Utility.Random( 1, 5 ) );
		}

		public override int GetAttackSound(){ return 0x63E; }	// A
		public override int GetDeathSound(){ return 0x63F; }	// D
		public override int GetHurtSound(){ return 0x640; }		// H
		public override bool AutoDispel{ get{ return !Controlled; } }
		public override int TreasureMapLevel{ get{ return 5; } }
		public override bool BleedImmune{ get{ return true; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Gold; } }
		public override bool CanAngerOnTame { get { return true; } }

		public SpinelWyrm( Serial serial ) : base( serial )
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

			Body = Server.Mobiles.Wyrms.WyrmBody();
		}
	}
}