///////////////////////////////////////////////////////////
/// The Playground UO - New Backpack Style Deed - By Doc //
//////////////////////////////////////////////////////////
using System;
using Server;
using Server.Misc;
using Server.Items;
using Server.Gumps;
using Server.Network;
using Server.Commands;
using Server.Mobiles;

namespace Server.Items 
{
	public class NewPackDeed : Item
	{ 
		[Constructable] 
		public NewPackDeed() :  base( 0x14F0 ) 
		{ 
			Weight = 1.0; 
			Hue = 1153; 
			Name = "New Backpack Style Deed - EMPTY BACKPACK FIRST EXCEPT FOR THIS DEED!!!"; 
			
			
		}

		public override void OnDoubleClick( Mobile m ) 
		{		
			
            
			m.CloseGump( typeof( NewpackGump ) );
			m.SendGump ( new NewpackGump() );
			this.Delete();
		} 

		public NewPackDeed( Serial serial ) : base( serial ) 
		{ 
		} 
       
		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 
			writer.Write( (int) 1 ); 
		}

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 
			int version = reader.ReadInt(); 
		} 
	}
}

namespace Server.Gumps
{
    public class NewpackGump : Server.Gumps.Gump
    {
        Mobile caller;
		
	 public NewpackGump() : base( 50,50 )
        {	
		    Closable = true;
			Disposable = true;
			Dragable = true;
			Resizable = false;

			AddPage(0);
			AddBackground(7, 7, 777, 384, 9200);
			AddButton(99, 305, 247, 248, (int)Buttons.Button1, GumpButtonType.Reply, 0);
			AddButton(360, 305, 247, 248, (int)Buttons.Button2, GumpButtonType.Reply, 0);
			AddButton(612, 305, 247, 248, (int)Buttons.Button3, GumpButtonType.Reply, 0);
			AddLabel(110, 280, 2139, @"Bloody");
			AddLabel(373, 280, 2139, @"Furry");
			AddLabel(620, 280, 2139, @"Straps");
			AddLabel(304, 12, 2139, @"The Playground UO");
			AddImage(527, 71, 30558);
			AddImage(20, 71, 30562);
			AddImage(275, 71, 30560);
			AddButton(614, 345, 2453, 2455, (int)Buttons.Button4, GumpButtonType.Reply, 0);
			AddLabel(174, 35, 154, @"Choose a new backpack style or click --->  for the default backpack:");
			AddLabel(183, 347, 154, @"MAKE SURE YOUR BACKPACK IS EMPTY EXCEPT FOR THIS DEED!!");
			AddButton(608, 35, 247, 248, (int)Buttons.Button5, GumpButtonType.Reply, 0);
			

            
        }

        public enum Buttons
		{
			Button1,
			Button2,
			Button3,
			Button4,
			Button5,
		}

		 public override void OnResponse(NetState sender, RelayInfo info)
        {
             Mobile from = sender.Mobile;

            switch(info.ButtonID)
            {
                case (int)Buttons.Button1:
				{
					Container pack = from.Backpack;
                    if ( pack != null )
                    pack.Delete();               //  remove default backpack 
                    pack = new BloodyBackpack();// create the new pack
                    from.AddItem( pack );       // add new pack to the player/paperdoll
			        pack.Movable = false;
					break;
				}
				case (int)Buttons.Button2:
				{
					Container pack = from.Backpack;
                    if ( pack != null )
                    pack.Delete(); 
                    pack = new FurryBackpack();
                    from.AddItem( pack );
			        pack.Movable = false;
					break;
				}
				case (int)Buttons.Button3:
				{
					Container pack = from.Backpack;
                    if ( pack != null )
                    pack.Delete(); 
                    pack = new StrapsBackpack();
                    from.AddItem( pack );
			        pack.Movable = false;
					break;
				}
				case (int)Buttons.Button4:
				{
					
					break;
				}
				case (int)Buttons.Button5:
				{
					Container pack = from.Backpack;
                    if ( pack != null )
                    pack.Delete(); 
                    pack = new Backpack();
                    from.AddItem( pack );
			        pack.Movable = false;
					break;
					break;
				}

            }
        }
    }
}