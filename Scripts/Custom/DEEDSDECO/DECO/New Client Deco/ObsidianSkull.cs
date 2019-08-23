using System;
 
namespace Server.Items
{
    public class ObsidianSkull : Item
    {
        [Constructable]
        public ObsidianSkull() : base( 39455 )
        {
            this.Name = "Obsidian Skull";
            this.Hue = 0;
        }
 
        public ObsidianSkull( Serial serial ) : base( serial )
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
