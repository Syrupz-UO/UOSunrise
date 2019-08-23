/////////////////////////////////////////////////
//                                             //
// Automatically generated by the              //
// AddonGenerator script by Arya               //
//                                             //
/////////////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class ChoppinBlockSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed
		{
			get
			{
				return new ChoppinBlockSouthAddonDeed();
			}
		}

		[ Constructable ]
		public ChoppinBlockSouthAddon()
		{
			AddonComponent ac;
			ac = new AddonComponent( 4730 );
			AddComponent( ac, 1, -1, 0 );
			ac = new AddonComponent( 4731 );
			AddComponent( ac, 0, -1, 0 );
			ac = new AddonComponent( 4732 );
			AddComponent( ac, -1, -1, 0 );
			ac = new AddonComponent( 4724 );
			AddComponent( ac, 1, 1, 0 );
			ac = new AddonComponent( 4725 );
			AddComponent( ac, 0, 1, 0 );
			ac = new AddonComponent( 4726 );
			AddComponent( ac, -1, 1, 0 );
			ac = new AddonComponent( 4727 );
			AddComponent( ac, -1, 0, 0 );
			ac = new AddonComponent( 4728 );
			AddComponent( ac, 0, 0, 0 );
			ac = new AddonComponent( 4729 );
			AddComponent( ac, 1, 0, 0 );

		}

		public ChoppinBlockSouthAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class ChoppinBlockSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new ChoppinBlockSouthAddon();
			}
		}

		[Constructable]
		public ChoppinBlockSouthAddonDeed()
		{
			Name = "ChoppinBlockSouth";
		}

		public ChoppinBlockSouthAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}