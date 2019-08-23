using System;
using Server;
using Server.Items;

namespace Items
{
	public class LargeHueRoomBag : KeyBag
	{
		[Constructable]
		public LargeHueRoomBag()
		{
			Hue = 0x20;
			PlaceItemIn( 30, 35, new HueRoomToken() );
			PlaceItemIn( 30, 35, new HueRoomToken() );
			PlaceItemIn( 30, 35, new HueRoomToken() );
			PlaceItemIn( 30, 35, new HueRoomToken() );
			PlaceItemIn( 30, 35, new HueRoomToken() );
			PlaceItemIn( 30, 35, new HueRoomToken() );
			PlaceItemIn( 30, 35, new HueRoomToken() );
			PlaceItemIn( 30, 35, new HueRoomToken() );
			PlaceItemIn( 30, 35, new HueRoomToken() );
			PlaceItemIn( 30, 35, new HueRoomToken() );
			
		}

		public LargeHueRoomBag( Serial serial ) : base( serial )
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