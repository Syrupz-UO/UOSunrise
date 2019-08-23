using System;
using Server;
using Server.Mobiles;

namespace Server.Items
{
	public class TotemOfVoid : MagicTalisman
	{
		public override int LabelNumber{ get{ return 1075035; } } // Totem of the Void

		[Constructable]
		public TotemOfVoid() : base( 0x2F5B )
		{
			Hue = 0x2D0;
			Attributes.RegenHits = 10;
			Attributes.LowerManaCost = 50;
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Artifact");
        }

		public TotemOfVoid( Serial serial ) :  base( serial )
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