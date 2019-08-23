using System;
using Server;
using Server.Mobiles;

namespace Server.Items
{
	[Flipable(0xE41, 0xE40)]
    public class BankChest : Item
	{
        [Constructable]
        public BankChest() : base(0xE41)
		{
            Name = "Bank Chest";
        }

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
            list.Add(1070722, "Double Click To Open Bank Box");
        } 

        public override void OnDoubleClick(Mobile from)
		{
			if ( from.InRange( this.GetWorldLocation(), 4 ) )
			{
				BankBox box = from.BankBox;
				if (box != null)
					box.Open();
			}
			else
			{
				from.SendLocalizedMessage( 502138 ); // That is too far away for you to use
			}
        }

        public BankChest( Serial serial ) : base( serial )
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