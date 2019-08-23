using System;
 
namespace Server.Items
{
    public class JadeSkull : Item
    {
        [Constructable]
        public JadeSkull() : base( 39452 )
        {
            this.Name = "Jade Skull";
            this.Hue = 0;
        }
 
        public JadeSkull( Serial serial ) : base( serial )
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
