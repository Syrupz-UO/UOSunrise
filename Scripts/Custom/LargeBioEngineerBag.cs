using System;
using Server;
using Server.Items;

namespace Items
{
	public class LargeBioEngineerBag : KeyBag
	{
		[Constructable]
		public LargeBioEngineerBag()
		{
			Hue = 0x20;
			PlaceItemIn( 30, 35, new Organics(2000) );
			PlaceItemIn( 50, 35, new EmptyDNAVial(100) );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() ); //
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() ); //25
			PlaceItemIn( 70, 35, new BioTool() ); //
			PlaceItemIn( 70, 35, new BioTool() ); 
			PlaceItemIn( 70, 35, new BioTool() ); 
			PlaceItemIn( 70, 35, new BioTool() ); 
			PlaceItemIn( 70, 35, new BioTool() ); //5
		}

		public LargeBioEngineerBag( Serial serial ) : base( serial )
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