

using System;
 
namespace Server.Items
{
    public class DurabilityDeed : Item
    {
        [Constructable]
        public DurabilityDeed( ) : base( 5360 )
        {
            Weight = 1.0;
            Stackable = true;
            Hue = 1090;
			Name = "+15 Durability - Page To Redeem";
        }
 
        public DurabilityDeed(Serial serial) : base(serial)
        {
        }
 
        public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer );
 
            writer.Write( (int) 0 );
        }
 
        public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
 
            int version = reader.ReadInt();
        }
    }
}
