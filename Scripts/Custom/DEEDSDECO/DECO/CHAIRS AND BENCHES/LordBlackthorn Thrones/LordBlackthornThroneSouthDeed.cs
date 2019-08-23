using System;
using Server;

namespace Server.Items
{
	public class LordBlackthornThroneSouthAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new LordBlackthornThroneSouthDeed(); } }


		[Constructable]
		public LordBlackthornThroneSouthAddon()
		{
			AddComponent( new AddonComponent( 19482 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 19483 ), 1, 0, 0 );
			AddComponent( new AddonComponent( 19484 ), 2, 0, 0 );
		}

		public LordBlackthornThroneSouthAddon( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}

	public class LordBlackthornThroneSouthDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new LordBlackthornThroneSouthAddon(); } }
		//public override int LabelNumber{ get{ return 1098354; } } // Lord Blackthorn's Throne [Replica]

		[Constructable]
		public LordBlackthornThroneSouthDeed()
		{
			Name = "Lord Blackthorn's Throne South [Replica]";
		}

		public LordBlackthornThroneSouthDeed( Serial serial ) : base( serial )
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