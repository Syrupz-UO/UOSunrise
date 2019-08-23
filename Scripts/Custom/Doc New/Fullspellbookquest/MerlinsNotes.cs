using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	public class MerlinsNotes : Item
	{

		[Constructable]
		public MerlinsNotes() : this( 1 )
		{
		}

		[Constructable]
		public MerlinsNotes( int amount ) : base( 0x227B )
		{
			Name = "Festis Notes";
			Stackable = false;
			Amount = amount;
			Weight = 1.0;
		}

		public MerlinsNotes( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( (int) 0 ); // version
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}
}
