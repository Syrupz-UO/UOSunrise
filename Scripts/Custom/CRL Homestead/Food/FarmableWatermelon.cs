using System;
using Server;
using Server.Network;

namespace Server.Items
{
	public class FarmableWatermelon : FarmableCrop
	{
		public static int GetCropID()
		{
			return Utility.Random( 3166, 3 );
		}

		public override Item GetCropObject()
		{
			Watermelon watermelon = new Watermelon();
			return watermelon;
		}

		public override int GetPickedID()
		{
			return Utility.Random( 3166, 3 );
		}

		[Constructable]
		public FarmableWatermelon() : base( GetCropID() )
		{
		}

		public FarmableWatermelon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadEncodedInt();
		}
	}
}