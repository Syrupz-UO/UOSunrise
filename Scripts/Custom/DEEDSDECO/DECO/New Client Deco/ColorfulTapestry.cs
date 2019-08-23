using System;
 
namespace Server.Items
{
    public class ColorfulTapestry : Item
    {
        [Constructable]
        public ColorfulTapestry() : base( 17092 )
        {
            this.Name = "Colorful Tapestry";
            this.Hue = 0;
        }
 
        public ColorfulTapestry( Serial serial ) : base( serial )
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
