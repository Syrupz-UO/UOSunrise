using System; 
using Server; 
using Server.Gumps; 
using Server.Network; 

    namespace Server.Items 
    { 

    public class HueRoomToken : Item 
    {
        //public override int LabelNumber { get { return 1076790; } }
    [Constructable] 
    public HueRoomToken() : this( null ) 
    { 
    } 

    [Constructable]
        public HueRoomToken(String name): base(0xE99)
    {
        Name = "Hue Room Token";
        Stackable = true;
        Weight = 1.0;
        LootType = LootType.Blessed;
		//Hue=33;
        
    }

        public HueRoomToken(Serial serial)
            : base(serial) 
    { 
    } 

    public override void OnDoubleClick( Mobile from ) 
    { 
    if ( !IsChildOf( from.Backpack ) ) 
    { 
    from.SendMessage( "Use this at the hue room to color items" ); 
    } 
    else 
    {
        from.SendGump(new ShadowTokenGump(from, this)); 
    } 
    } 

    public override void Serialize ( GenericWriter writer) 
    { 
    base.Serialize ( writer ); 

    writer.Write ( (int) 0); 
    } 

    public override void Deserialize( GenericReader reader ) 
    { 
    base.Deserialize ( reader ); 

    int version = reader.ReadInt(); 
    } 
    } 
    }
