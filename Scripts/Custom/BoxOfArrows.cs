using System;
using Server;
using Server.Items;

namespace Items
{
	public class BoxOfArrows : SunriseGiftBox
	{
		[Constructable]
		public BoxOfArrows()
		{
			
			PlaceItemIn( 5, 5, new ALightningArrow(100) );
			PlaceItemIn( 5, 10, new ArmorPiercingArrow(100) );
			PlaceItemIn( 5, 15, new ExplosiveArrow(100) );
			PlaceItemIn( 5, 20, new PoisonArrow(100) );
			PlaceItemIn( 5, 25, new FreezeArrow(100) );
		}

		public BoxOfArrows( Serial serial ) : base( serial )
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