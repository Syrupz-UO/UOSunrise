using System;
using Server;
using Server.Engines.Harvest;

namespace Server.Items
{
	public class CraftsmanShovel : BaseHarvestTool
	{
		public override HarvestSystem HarvestSystem{ get{ return Mining.System; } }

		[Constructable]
		public CraftsmanShovel() : this( 1500 )
		{
		}

		[Constructable]
		public CraftsmanShovel( int uses ) : base( uses, 0xF39 )
		{
			Weight = 1.0;
			Hue=2080;
			Name="Craftsman Shovel";
		}

		public CraftsmanShovel( Serial serial ) : base( serial )
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