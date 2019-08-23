using System;
using Server;
using Server.Mobiles;

namespace Server.Items 
{ 
	public class DeathKnightWarhorse : EtherealMount 
	{ 
		[Constructable] 
		public DeathKnightWarhorse() : base( 11676, 0x3E92 ) 
		{ 
			Name = "Dread Horse";
			ItemID = 11676;
			Hue = 0x497;
		} 

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Evil Mount For Grandmaster Death Knights");
        } 

		public DeathKnightWarhorse( Serial serial ) : base( serial ) 
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
			if ( Name != "Dread Horse" )
				Name = "Dread Horse";
		} 
	}
}