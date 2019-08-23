using System;
using Server;
using Server.Items;
using Server.Mobiles;



namespace Server.Items
{
    public class DocGPSTool : Item
    {
        [Constructable]
        public DocGPSTool() : base( 0x26A0
 )
        {
            Weight = 1.0;
            Name = "GPS Tool";
            Movable = true;
			this.Hue =33;
        }

        public DocGPSTool( Serial serial ) : base( serial )
        {
        }

        public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer );
            writer.Write( (int) 0 );
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize( reader );
            int version = reader.ReadInt();
        }  
}
}