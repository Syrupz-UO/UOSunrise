using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class SunriseGiftBox : GiftBox
	{
		public SunriseGiftBox()
		{
			Name = "Thank you for donating at UOSunrise!";
		}

		public void PlaceItemIn( int x, int y, Item item )
		{
			AddItem( item );
			item.Location = new Point3D( x, y, 0 );
		}

		public SunriseGiftBox( Serial serial ) : base( serial )
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