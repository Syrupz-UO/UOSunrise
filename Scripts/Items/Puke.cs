using System;
using Server.Items;
using Server.Network;
using Server.Mobiles;

namespace Server.Items
{
	public class Puke : Item 
	{ 
		[Constructable] 
		public Puke() : base( Utility.RandomList( 0xf3b, 0xf3c ) ) 
		{ 
			Name = "A Pile of Puke"; 
			Hue = 0x557; 
			Movable = false; 

			ItemRemovalTimer thisTimer = new ItemRemovalTimer( this ); 
			thisTimer.Start();
		} 

		public override void OnSingleClick( Mobile from ) 
		{ 
			this.LabelTo( from, this.Name ); 
		} 
  
		public Puke( Serial serial ) : base( serial ) 
		{ 
		} 

		public override void Serialize(GenericWriter writer) 
		{ 
			base.Serialize( writer ); 
			writer.Write( (int) 0 ); 
		} 

		public override void Deserialize(GenericReader reader) 
		{ 
			base.Deserialize( reader ); 
			int version = reader.ReadInt(); 

			this.Delete(); // none when the world starts 
		} 
	}
}