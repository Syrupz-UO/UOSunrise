using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a wyrm corpse" )]
	public class IceDragon : BaseCreature
	{
		public override int BreathPhysicalDamage{ get{ return 0; } }
		public override int BreathFireDamage{ get{ return 0; } }
		public override int BreathColdDamage{ get{ return 100; } }
		public override int BreathPoisonDamage{ get{ return 0; } }
		public override int BreathEnergyDamage{ get{ return 0; } }
		public override int BreathEffectHue{ get{ return 0x481; } }
		public override int BreathEffectSound{ get{ return 0x64F; } }
		public override bool ReacquireOnMovement{ get{ return !Controlled; } }
		public override bool HasBreath{ get{ return true; } }
		public override void BreathDealDamage( Mobile target, int form ){ base.BreathDealDamage( target, 12 ); }

		[Constructable]
		public IceDragon () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = NameList.RandomName( "dragon" );
			Title = "the ice wyrm";
			Body = 46;
			Hue = 1154;
			BaseSoundID = 362;

			SetStr( 796, 825 );
			SetDex( 86, 105 );
			SetInt( 436, 475 );

			SetHits( 478, 495 );

			SetDamage( 16, 22 );

			SetDamageType( ResistanceType.Physical, 75 );
			SetDamageType( ResistanceType.Cold, 25 );

			SetResistance( ResistanceType.Physical, 65, 75 );
			SetResistance( ResistanceType.Cold, 80, 90 );
			SetResistance( ResistanceType.Fire, 40, 60 );
			SetResistance( ResistanceType.Poison, 60, 70 );
			SetResistance( ResistanceType.Energy, 60, 70 );

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
			MinTameSkill = 96.3;

			if ( 1 == Utility.RandomMinMax( 0, 2 ) )
			{
				switch ( Utility.RandomMinMax( 0, 5 ) )
				{
					case 0: PackItem( new IcySkinLegs() ); break;
					case 1: PackItem( new IcySkinGloves() ); break;
					case 2: PackItem( new IcySkinGorget() ); break;
					case 3: PackItem( new IcySkinArms() ); break;
					case 4: PackItem( new IcySkinChest() ); break;
					case 5: PackItem( new IcySkinHelm() ); break;
				}
			}
		}

		public override void OnDeath( Container c )
		{
			base.OnDeath( c );

			Item scale = new HardScales( Utility.RandomMinMax( 15, 20 ), "ice scales" );
   			c.DropItem(scale);
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 2 );
			AddLoot( LootPack.Gems, 8 );
		}

		public override int GetAttackSound(){ return 0x63E; }	// A
		public override int GetDeathSound(){ return 0x63F; }	// D
		public override int GetHurtSound(){ return 0x640; }		// H
		public override int Hides{ get{ return 20; } }
		public override HideType HideType{ get{ if ( Utility.RandomBool() ){ return HideType.Frozen; } else { return HideType.Draconic; } } }
		public override bool AutoDispel{ get{ return !Controlled; } }
		public override int TreasureMapLevel{ get{ return 5; } }
		public override bool BleedImmune{ get{ return true; } }
		public override FoodType FavoriteFood{ get{ return FoodType.Gold; } }
		public override bool CanAngerOnTame { get { return true; } }

		public IceDragon( Serial serial ) : base( serial )
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