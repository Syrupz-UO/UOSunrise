using System;
using Server;

namespace Server.Items
{
	public class UnicornHorn : Item
	{
		[Constructable]
		public UnicornHorn() : base( 0x2DB7 )
		{
			Name = "unicorn horn";
			Weight = 1.0;
			Hue = 0x47E;
		}

		public UnicornHorn( Serial serial ) : base( serial )
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