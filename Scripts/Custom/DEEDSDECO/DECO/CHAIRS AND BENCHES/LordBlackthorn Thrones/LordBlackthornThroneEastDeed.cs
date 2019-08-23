using System;
using Server;

namespace Server.Items
{
	public class LordBlackthornThroneEastAddon : BaseAddon
	{
		public override BaseAddonDeed Deed{ get{ return new LordBlackthornThroneEastDeed(); } }

		[Constructable]
		public LordBlackthornThroneEastAddon()
		{
			AddComponent( new AddonComponent( 19485 ), 0, 0, 0 );
			AddComponent( new AddonComponent( 19486 ), 0, 1, 0 );
			AddComponent( new AddonComponent( 19487 ), 0, 2, 0 );
		}

		public LordBlackthornThroneEastAddon( Serial serial ) : base( serial )
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

	public class LordBlackthornThroneEastDeed : BaseAddonDeed
	{
		public override BaseAddon Addon{ get{ return new LordBlackthornThroneEastAddon(); } }
		//public override int LabelNumber{ get{ return 1098354; } } // Lord Blackthorn's Throne [Replica]

		[Constructable]
		public LordBlackthornThroneEastDeed()
		{
			Name = "Lord Blackthorn's Throne East [Replica]";
		}

		public LordBlackthornThroneEastDeed( Serial serial ) : base( serial )
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