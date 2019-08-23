using System;
using Server.Items;

namespace Server.Items
{

        [DynamicFliping]
	[Flipable( 0x1947, 0x1948 )]
	public class BlessedStatue2 : Item
	{
		[Constructable]
		public BlessedStatue2() : base(0x1947)
		{
			Movable = true;
			Weight = 20.0;
		}

		public BlessedStatue2(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int) 0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();

			if ( Weight == 6.0 )
				Weight = 20.0;
		}
	}
}