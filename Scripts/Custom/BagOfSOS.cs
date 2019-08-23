using System;
using Server;
using Server.Items;

namespace Items
{
	public class BagOfSOS : SunriseGiftBox
	{
		[Constructable]
		public BagOfSOS()
		{
			
			PlaceItemIn( 5, 5, new SOS("felucca",4) );
			PlaceItemIn( 8, 5, new SOS("felucca",4) );
			PlaceItemIn( 9, 5, new SOS("felucca",4) );
			PlaceItemIn( 8, 5, new SOS("felucca",4) );
			PlaceItemIn( 9, 5, new SOS("felucca",4) );
			PlaceItemIn( 10, 5, new SOS("felucca",4) );
			PlaceItemIn( 10, 5, new SOS("felucca",4) );
			PlaceItemIn( 12, 5, new SOS("felucca",4) );
			PlaceItemIn( 12, 5, new SOS("felucca",4) );
			PlaceItemIn( 14, 5, new SOS("felucca",4) );
			
		}

		public BagOfSOS( Serial serial ) : base( serial )
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