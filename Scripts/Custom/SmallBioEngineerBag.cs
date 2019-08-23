using System;
using Server;
using Server.Items;

namespace Items
{
	public class SmallBioEngineerBag : KeyBag
	{
		[Constructable]
		public SmallBioEngineerBag()
		{
			Hue = 0x20;
			PlaceItemIn( 30, 35, new Organics(1000) );
			PlaceItemIn( 50, 35, new EmptyDNAVial(25) );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() ); //5
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			PlaceItemIn( 70, 35, new EmptyDNAVialSet() );
			
			PlaceItemIn( 70, 35, new BioTool() ); 
			PlaceItemIn( 70, 35, new BioTool() ); //2
		}

		public SmallBioEngineerBag( Serial serial ) : base( serial )
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