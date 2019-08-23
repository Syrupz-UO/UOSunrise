using System;
using Server;
using Server.Misc;

namespace Server.Items
{
	public class MagicJewelryRing : GoldRing
	{
		[Constructable]
		public MagicJewelryRing()
		{
			Resource = CraftResource.None;
			Name = "ring";

			if ( Hue == 0 ){ Server.Misc.MaterialInfo.ColorMetal( this, 0 ); }
		}

		public MagicJewelryRing( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
	public class MagicJewelryNecklace : GoldNecklace
	{
		[Constructable]
		public MagicJewelryNecklace()
		{
			Resource = CraftResource.None;

			if ( Hue == 0 )
			{
				ItemID = Utility.RandomList( 0x1085, 0x1089, 0x1088 );

				Name = "necklace";
					if ( Utility.RandomMinMax( 0, 1 ) == 1 ){ Name = "amulet"; }

					if ( ItemID == 0x1085 || ItemID == 0x1089 )
					{
						Name = "beads";
					}

				Server.Misc.MaterialInfo.ColorMetal( this, 0 );
			}
		}

		public MagicJewelryNecklace( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
	public class MagicJewelryEarrings : GoldEarrings
	{
		[Constructable]
		public MagicJewelryEarrings()
		{
			Resource = CraftResource.None;
			Name = "earrings";

			if ( Hue == 0 ){ Server.Misc.MaterialInfo.ColorMetal( this, 0 ); }
		}

		public MagicJewelryEarrings( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
	public class MagicJewelryBracelet : GoldBracelet
	{
		[Constructable]
		public MagicJewelryBracelet()
		{
			Resource = CraftResource.None;
			Name = "bracelet";

			if ( Hue == 0 ){ Server.Misc.MaterialInfo.ColorMetal( this, 0 ); }
		}

		public MagicJewelryBracelet( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
	public class MagicJewelryCirclet : GoldBracelet
	{
		[Constructable]
		public MagicJewelryCirclet()
		{
			ItemID = Utility.RandomList( 0x2B6F, 0x3166 );
			Layer = Layer.Helm;
			Resource = CraftResource.None;
			Name = "circlet";

			if ( Hue == 0 ){ Server.Misc.MaterialInfo.ColorMetal( this, 0 ); }
		}

		public MagicJewelryCirclet( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}