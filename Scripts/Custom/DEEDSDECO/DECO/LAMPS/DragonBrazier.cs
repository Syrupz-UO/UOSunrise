using System;

namespace Server.Items
{
	public class DragonBrazier : Item
	{
		[Constructable]
		public DragonBrazier() : base(6477)
		{
			Name = "DragonBrazier";
			Weight = 1.0;
		}

		public DragonBrazier(Serial serial) : base(serial)
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

			if ( Weight == 4.0 )
				Weight = 1.0;
		}
	}
}
