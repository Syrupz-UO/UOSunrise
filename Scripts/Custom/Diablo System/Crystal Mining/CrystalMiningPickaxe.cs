using System;
using Server;
using Server.Items;
using Server.Network;
using Server.Engines.Harvest;

namespace Server.Items
{
    [FlipableAttribute(0xE86, 0xE85)]
    public class CrystalMiningPickaxe : BaseAxe, IUsesRemaining
	{

		//public override int LabelNumber{ get{ return 1041281; } } // a Gem Mining Pickaxe
		public override HarvestSystem HarvestSystem{ get{ return CrystalMining.System; } }

		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.DoubleStrike; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.Disarm; } }

		public override int AosStrengthReq{ get{ return 50; } }
		public override int AosMinDamage{ get{ return 13; } }
		public override int AosMaxDamage{ get{ return 15; } }
		public override int AosSpeed{ get{ return 35; } }

		public override int OldStrengthReq{ get{ return 25; } }
		public override int OldMinDamage{ get{ return 1; } }
		public override int OldMaxDamage{ get{ return 15; } }
		public override int OldSpeed{ get{ return 35; } }

		public override WeaponAnimation DefAnimation{ get{ return WeaponAnimation.Slash1H; } }
		
		//public override bool CanBeWornByGargoyles{ get{ return true; } }

		[Constructable]
		public CrystalMiningPickaxe() : this( 50 )
		{
		}

		[Constructable]
		public CrystalMiningPickaxe( int uses ) : base( 0xE86 )
		{
			Name = "Crystal Miners Pickaxe";
			Weight = 11.0;
			Hue = 2062;
			UsesRemaining = uses;
			ShowUsesRemaining = true;
		}

		public CrystalMiningPickaxe( Serial serial ) : base( serial )
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
		}
	}
}