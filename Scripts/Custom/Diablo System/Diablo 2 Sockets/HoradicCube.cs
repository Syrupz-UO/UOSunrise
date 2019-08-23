///////////////////////////////////////////
/////   	Horadic Cube V 2.0        /////
/////      Created by ManofWar        /////
///// 	www.bluedragonsociety.com     /////
/////	        Thanks To:            /////
/////           KillerBeeZ            /////
/////	   for H Cube version 1.0     /////
///////////////////////////////////////////
using System; 
using Server; 
using Server.Gumps; 
using Server.Network; 
using Server.Menus; 
using Server.Menus.Questions; 
using Server.Misc; 
using Server.Mobiles; 
using Server.Targeting;
using Server.Items;
using System.Collections;
using Server.Prompts;
using Server.ContextMenus;
using Server.Multis;
using Server.Regions;

namespace Server.Items 
{ 
	[Flipable( 0x2DF3, 0x2DF4 )]
	public class HoradicCube : Item 
	{
		[Constructable] 
		public HoradicCube() : base( 0x2DF4) 
		{
			Hue = 0x485;
			Name = "The Horadric Cube"; 
		}
	
		public HoradicCube( Serial serial ) : base( serial ) 
		{ 
		}
		
		public override void OnDoubleClick( Mobile from )
		{

			if (IsChildOf(from.Backpack))
			{
				from.CloseGump( typeof( HoradicCubeGump ) );
				from.SendGump( new HoradicCubeGump( from ) );
			}
			else
			from.SendLocalizedMessage( 1042001 );// That must be in your pack for you to use it.
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