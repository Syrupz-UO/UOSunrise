using System;
using Server;
using Server.Items;

namespace Server.Mobiles
{
	[CorpseName( "a wyrm corpse" )]
	public class LavaDragon : BaseCreature
	{
		public override bool ReacquireOnMovement{ get{ return !Controlled; } }
		public override bool HasBreath{ get{ return true; } }
		public override void BreathDealDamage( Mobile target, int form ){ base.BreathDealDamage( target, 9 ); }

		[Constructable]
		public LavaDragon () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = NameList.RandomName( "dragon" );
			Title = "the fire wyrm";
			Body = Server.Mobiles.Wyrms.WyrmBody();
			Hue = 1161;
			BaseSoundID = 362;

			SetStr( 796, 825 );
			SetDex( 86, 105 );
			SetInt( 436, 475 );

			SetHits( 478, 495 );

			SetDamage( 16, 22 );

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Fire, 50 );

			SetResistance( ResistanceType.Physical, 55, 65 );
			SetResistance( ResistanceType.Fire, 100 );
			SetResistance( ResistanceType.Cold, 15, 25 );
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
			MinTameSkill = 96.3;

			if ( 1 == Utility.RandomMinMax( 0, 2 ) )
			{
				switch ( Utility.RandomMinMax( 0, 5 ) )
				{
					case 0: PackItem( new LavaSkinLegs() ); break;
					case 1: PackItem( new LavaSkinGloves() ); break;
					case 2: PackItem( new LavaSkinGorget() ); break;
					case 3: PackItem( new LavaSkinArms() ); break;
					case 4: PackItem( new LavaSkinChest() ); break;
					case 5: PackItem( new LavaSkinHelm() ); break;
				}
			}
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 2 );
			AddLoot( LootPack.Gems, 8 );
		}

		public override int GetAttackSound(){ return 0x63E; }	// A
		public override int GetDeathSound(){ return 0x63F; }	// D
		public override int GetHurtSound(){ return 0x640; }		// H
		public override bool AutoDispel{ get{ return !Controlled; } }
		public override int TreasureMapLevel{ get{ return 5; } }
		public override int Meat{ get{ return 19; } }
		public override int Hides{ get{ return 20; } }
		public override HideType HideType{ get{ return HideType.Volcanic; } }
		public override int Scales{ get{ return 7; } }
		public override ScaleType ScaleType{ get{ return ( ScaleType.Red ); } }
		public override FoodType FavoriteFood{ get{ return FoodType.Meat | FoodType.Meat; } }
		public override bool CanAngerOnTame { get { return true; } }

		public LavaDragon( Serial serial ) : base( serial )
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