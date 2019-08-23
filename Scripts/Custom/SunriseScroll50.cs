using System;
using Server;
using Server.Items;

namespace Items
{
	public class SunriseScroll50 : SunriseGiftBox
	{
		[Constructable]
		public SunriseScroll50()
		{
			
			PlaceItemIn( 5, 5, new SunriseScroll(50) );
			
			
		}

		public SunriseScroll50( Serial serial ) : base( serial )
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