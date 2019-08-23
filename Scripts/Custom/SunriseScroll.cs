using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class SunriseScroll: BaseSunriseScroll
	{
		

		[Constructable]
		public SunriseScroll() : this( 1 )
		{
		}

		[Constructable]
		public SunriseScroll( int amount ) : base( 0x0E34, amount )
		{
			Name = "Sunrise Scroll";
			Hue = 2369;
		}

		public SunriseScroll( Serial serial ) : base( serial )
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

			ItemID = 0x0E34;
			Name = "Sunrise Scroll";
		}
	}
}