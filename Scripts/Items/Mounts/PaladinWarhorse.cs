using System;
using Server;
using Server.Mobiles;

namespace Server.Items 
{ 
	public class PaladinWarhorse : EtherealMount 
	{ 
		[Constructable] 
		public PaladinWarhorse() : base( 11676, 0x3E92 ) 
		{ 
			Name = "Knight Warhorse";
			ItemID = 11676;
			Hue = 0x430;
		} 

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Holy Mount For Grandmaster Knights");
        } 

		public PaladinWarhorse( Serial serial ) : base( serial ) 
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
			if ( Name != "Knight Warhorse" )
				Name = "Knight Warhorse";
		} 
	}
}