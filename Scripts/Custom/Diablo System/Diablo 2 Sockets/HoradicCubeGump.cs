///////////////////////////////////////////
/////    Horadic Cube Gump V 2.0      /////
/////  Created by Lunatic Thrasher    /////
///// 	www.bluedragonsociety.com     /////
/////	        Thanks To:            /////
/////           KillerBeeZ            /////
/////	   for H Cube version 1.0     /////
///////////////////////////////////////////
using System; 
using Server; 
using Server.Items;
using System.Collections;
using Server.Multis;
using Server.Mobiles;
using Server.Network;
using Server.Gumps; 
using Server.Menus; 
using Server.Menus.Questions;  
using Server.Misc;  
using Server.Targeting;
using Server.Prompts;
using Server.ContextMenus;
using Server.Regions;
 
//HoradicCubeGump
public class HoradicCubeGump : Gump 
{ 
	
	public HoradicCubeGump( Mobile m ) : base( 200,100 )
	{
	this.Closable=true;
	this.Disposable=false;
	this.Dragable=true;
	this.Resizable=false;

	this.AddPage(1);
	this.AddBackground(50, 30, 514, 350, 9270);
	this.AddAlphaRegion( 50, 30, 514, 350 );
	this.AddImage(50, 400, 9271);
	this.AddImage(50, 360, 10451);
	this.AddImage(150, 400, 9271);
	this.AddImage(175, 400, 9271);
	this.AddImage(200, 400, 9271);
	this.AddImage(250, 400, 9271);
	this.AddImage(350, 400, 9271);
	this.AddImage(375, 400, 9271);
	this.AddImage(400, 400, 9271);
	this.AddImage(490, 360, 10451);
	//this.AddImage(270, 155, 1418);
	
	this.AddImage(86, 38, 10451);
	this.AddImage(90, 40, 9804);
	this.AddImage(446, 38, 10451);
	this.AddImage(450, 40, 9804);
	this.AddButton(450, 115, 12011, 12011, 0, GumpButtonType.Page, 3);//Next
	this.AddLabel(247, 45, 32, "The Horadic Cube" );
	this.AddLabel(195, 65, 43, "+ + + Transmutation System + + +" );
	this.AddButton(293, 360, 22153, 22154, 0, GumpButtonType.Page, 2);
	this.AddLabel(195, 380, 43, "+3 Chipped Gems to 1 Flawed Gem+");
	
	this.AddButton(130, 136, 4024, 4025, 1, GumpButtonType.Reply, 0);
	this.AddLabel(165, 133, 32, "3 Chipped Amythyst to 1 Flawed Amythyst" );
	this.AddLabel(165, 147, 143, "Transmute three Chipped To get one Flawed Gem!" );
	
	this.AddButton(130, 166, 4024, 4025, 2, GumpButtonType.Reply, 0);
	this.AddLabel(165, 163, 32, "3 Chipped Amythyst to 1 Flawed Diamond" );
	this.AddLabel(165, 177, 143, "Transmute three Chipped To get one Flawed Gem!" );
	
	this.AddButton(130, 196, 4024, 4025, 3, GumpButtonType.Reply, 0);
	this.AddLabel(165, 193, 32, "3 Chipped Emerald to 1 Flawed Emerald" );
	this.AddLabel( 165, 207, 143, "Transmute three Chipped To get one Flawed Gem!" );
	
	this.AddButton(130, 226, 4024, 4025, 4, GumpButtonType.Reply, 0);
	this.AddLabel(165, 223, 32, "3 Chipped Ruby to 1 Flawed Ruby" );
	this.AddLabel( 165, 237, 143, "Transmute three Chipped To get one Flawed Gem!" );
	
	this.AddButton(130, 256, 4024, 4025, 5, GumpButtonType.Reply, 0);
	this.AddLabel(165, 253, 32, "3 Chipped Sapphire to 1 Flawed Sapphire" );
	this.AddLabel( 165, 267, 143, "Transmute three Chipped To get one Flawed Gem!" );
	
	this.AddButton(130, 286, 4024, 4025, 6, GumpButtonType.Reply, 0);
	this.AddLabel(165, 283, 32, "3 Chipped Skull to 1 Flawed Skull" );
	this.AddLabel( 165, 297, 143, "Transmute three Chipped To get one Flawed Skull!" );

	this.AddButton(130, 316, 4024, 4025, 7, GumpButtonType.Reply, 0);
	this.AddLabel(165, 313, 32, "3 Chipped Topaz to 1 Flawed Topaz" );
	this.AddLabel( 165, 327, 143, "Transmute three Chipped To get one Flawed Gem!" );
	////////////////////////////////////////////////////////////////////////
	this.AddPage(3);
	this.AddBackground(50, 30, 514, 350, 9270);
	this.AddAlphaRegion( 50, 30, 514, 350 );
	this.AddImage(50, 400, 9271);
	this.AddImage(50, 360, 10451);
	this.AddImage(150, 400, 9271);
	this.AddImage(175, 400, 9271);
	this.AddImage(200, 400, 9271);
	this.AddImage(250, 400, 9271);
	this.AddImage(350, 400, 9271);
	this.AddImage(375, 400, 9271);
	this.AddImage(400, 400, 9271);
	this.AddImage(490, 360, 10451);

	this.AddImage(86, 38, 10451);
	this.AddImage(90, 40, 9804);
	this.AddImage(446, 38, 10451);
	this.AddImage(450, 40, 9804);
	this.AddButton(75, 115, 12017, 12017, 0, GumpButtonType.Page, 1);//Previous
	this.AddButton(450, 115, 12011, 12011, 0, GumpButtonType.Page, 4);//Next
	this.AddLabel(247, 45, 32, "The Horadic Cube" );
	this.AddLabel(195, 65, 43, "+ + + Transmutation System + + +" );
	this.AddButton(293, 360, 22153, 22154, 0, GumpButtonType.Page, 2);
	this.AddLabel(195, 380, 43, " +3 Flawed Gems to 1 Plain Gem+");
	
	this.AddButton(130, 136, 4024, 4025, 8, GumpButtonType.Reply, 0);
	this.AddLabel(165, 133, 32, "3 Flawed Amethyst to 1 Plain Amethyst" );
	this.AddLabel( 165, 147, 143, "Transmute three Flawed To get one Plain Gem!" );
	
	this.AddButton(130, 166, 4024, 4025, 9, GumpButtonType.Reply, 0);
	this.AddLabel(165, 163, 32, "3 Flawed Diamonds to 1 Plain Diamond" );
	this.AddLabel( 165, 177, 143, "Transmute three Flawed To get one Plain Gem!" );
	
	this.AddButton(130, 196, 4024, 4025, 10, GumpButtonType.Reply, 0);
	this.AddLabel(165, 193, 32, "3 Flawed Emeralds to 1 Plain Emerald" );
	this.AddLabel( 165, 207, 143, "Transmute three Flawed To get one Plain Gem!" );
	
	this.AddButton(130, 226, 4024, 4025, 11, GumpButtonType.Reply, 0);
	this.AddLabel(165, 223, 32, "3 Flawed Ruby to 1 Plain Ruby" );
	this.AddLabel( 165, 237, 143, "Transmute three Flawed To get one Plain Gem!" );
	
	this.AddButton(130, 256, 4024, 4025, 12, GumpButtonType.Reply, 0);
	this.AddLabel(165, 253, 32, "3 Flawed Sapphire to 1 Plain Sapphire" );
	this.AddLabel( 165, 267, 143, "Transmute three Flawed To get one Plain Gem!" );
	
	this.AddButton(130, 286, 4024, 4025, 13, GumpButtonType.Reply, 0);
	this.AddLabel(165, 283, 32, "3 Flawed Skull to 1 Plain Skull" );
	this.AddLabel( 165, 297, 143, "Transmute three Flawed To get one Plain Skull!" );

	this.AddButton(130, 316, 4024, 4025, 14, GumpButtonType.Reply, 0);
	this.AddLabel(165, 313, 32, "3 Flawed Topaz to 1 Plain Topaz" );
	this.AddLabel( 165, 327, 143, "Transmute three Flawed To get one Plain Gem!" );
	////////////////////////////////////////////////////////////////////////
	this.AddPage(4);
	this.AddBackground(50, 30, 514, 350, 9270);
	this.AddAlphaRegion( 50, 30, 514, 350 );
	this.AddImage(50, 400, 9271);
	this.AddImage(50, 360, 10451);
	this.AddImage(150, 400, 9271);
	this.AddImage(175, 400, 9271);
	this.AddImage(200, 400, 9271);
	this.AddImage(250, 400, 9271);
	this.AddImage(350, 400, 9271);
	this.AddImage(375, 400, 9271);
	this.AddImage(400, 400, 9271);
	this.AddImage(490, 360, 10451);

	this.AddImage(86, 38, 10451);
	this.AddImage(90, 40, 9804);
	this.AddImage(446, 38, 10451);
	this.AddImage(450, 40, 9804);
	this.AddButton(75, 115, 12017, 12017, 0, GumpButtonType.Page, 3);//Previous
	this.AddButton(450, 115, 12011, 12011, 0, GumpButtonType.Page, 5);//Next
	this.AddLabel(247, 45, 32, "The Horadic Cube" );
	this.AddLabel(195, 65, 43, "+ + + Transmutation System + + +" );
	this.AddButton(293, 360, 22153, 22154, 0, GumpButtonType.Page, 2);
	this.AddLabel(195, 380, 43, "+3 Plain Gems to 1 Flawless Gem+");
	
	this.AddButton(130, 136, 4024, 4025, 15, GumpButtonType.Reply, 0);
	this.AddLabel(165, 133, 32, "3 Plain Amethyst to 1 Flawless Amethyst" );
	this.AddLabel( 165, 147, 143, "Transmute three Plain To get one Flawless Gem!" );
	
	this.AddButton(130, 166, 4024, 4025, 16, GumpButtonType.Reply, 0);
	this.AddLabel(165, 163, 32, "3 Plain Diamonds to 1 Flawless Diamonds" );
	this.AddLabel( 165, 177, 143, "Transmute three Plain To get one Flawless Gem!" );
	
	this.AddButton(130, 196, 4024, 4025, 17, GumpButtonType.Reply, 0);
	this.AddLabel(165, 193, 32, "3 Plain Emeralds to 1 Flawless Emerald" );
	this.AddLabel( 165, 207, 143, "Transmute three Plain To get one Flawless Gem!" );
	
	this.AddButton(130, 226, 4024, 4025, 18, GumpButtonType.Reply, 0);
	this.AddLabel(165, 223, 32, "3 Plain Ruby to 1 Flawless Ruby" );
	this.AddLabel( 165, 237, 143, "Transmute three Plain To get one Flawless Gem!" );
	
	this.AddButton(130, 256, 4024, 4025, 19, GumpButtonType.Reply, 0);
	this.AddLabel(165, 253, 32, "3 Plain Sapphire to 1 Flawless Sapphire" );
	this.AddLabel( 165, 267, 143, "Transmute three Plain To get one Flawless Gem!" );
	
	this.AddButton(130, 286, 4024, 4025, 20, GumpButtonType.Reply, 0);
	this.AddLabel(165, 283, 32, "3 Plain Skull to 1 Flawless Skull" );
	this.AddLabel( 165, 297, 143, "Transmute three Plain To get one Flawless Skull!" );

	this.AddButton(130, 316, 4024, 4025, 21, GumpButtonType.Reply, 0);
	this.AddLabel(165, 313, 32, "3 Plain Topaz to 1 Flawless Topaz" );
	this.AddLabel( 165, 327, 143, "Transmute three Plain To get one Flawless Gem!" );
	////////////////////////////////////////////////////////////////////////
	this.AddPage(5);
	this.AddBackground(50, 30, 514, 350, 9270);
	this.AddAlphaRegion( 50, 30, 514, 350 );
	this.AddImage(50, 400, 9271);
	this.AddImage(50, 360, 10451);
	this.AddImage(150, 400, 9271);
	this.AddImage(175, 400, 9271);
	this.AddImage(200, 400, 9271);
	this.AddImage(250, 400, 9271);
	this.AddImage(350, 400, 9271);
	this.AddImage(375, 400, 9271);
	this.AddImage(400, 400, 9271);
	this.AddImage(490, 360, 10451);

	this.AddImage(86, 38, 10451);
	this.AddImage(90, 40, 9804);
	this.AddImage(446, 38, 10451);
	this.AddImage(450, 40, 9804);
	this.AddButton(75, 115, 12017, 12017, 0, GumpButtonType.Page, 4);//Previous
	this.AddButton(450, 115, 12011, 12011, 0, GumpButtonType.Page, 6);//Next
	this.AddLabel(247, 45, 32, "The Horadic Cube" );
	this.AddLabel(195, 65, 43, "+ + + Transmutation System + + +" );
	this.AddButton(293, 360, 22153, 22154, 0, GumpButtonType.Page, 2);
	this.AddLabel(195, 380, 43, "+3 Flawless Gems to 1 Perfect Gem+");
	
	this.AddButton(130, 136, 4024, 4025, 22, GumpButtonType.Reply, 0);
	this.AddLabel(165, 133, 32, "3 Flawless Amethyst to 1 Perfect Amethyst" );
	this.AddLabel( 165, 147, 143, "Transmute three Flawless To get one Perfect Gem!" );
	
	this.AddButton(130, 166, 4024, 4025, 23, GumpButtonType.Reply, 0);
	this.AddLabel(165, 163, 32, "3 Flawless Diamonds to 1 Perfect Diamond" );
	this.AddLabel( 165, 177, 143, "Transmute three Flawless To get one Perfect Gem!" );
	
	this.AddButton(130, 196, 4024, 4025, 24, GumpButtonType.Reply, 0);
	this.AddLabel(165, 193, 32, "3 Flawless Emeralds to 1 Perfect Emerald" );
	this.AddLabel( 165, 207, 143, "Transmute three Flawless To get one Perfect Gem!" );
	
	this.AddButton(130, 226, 4024, 4025, 25, GumpButtonType.Reply, 0);
	this.AddLabel(165, 223, 32, "3 Flawless Ruby to 1 Perfect Ruby" );
	this.AddLabel( 165, 237, 143, "Transmute three Flawless To get one Perfect Gem!" );
	
	this.AddButton(130, 256, 4024, 4025, 26, GumpButtonType.Reply, 0);
	this.AddLabel(165, 253, 32, "3 Flawless Sapphire to 1 Perfect Sapphire" );
	this.AddLabel( 165, 267, 143, "Transmute three Flawless To get one Perfect Gem!" );
	
	this.AddButton(130, 286, 4024, 4025, 27, GumpButtonType.Reply, 0);
	this.AddLabel(165, 283, 32, "3 Flawless Skull to 1 Perfect Skull" );
	this.AddLabel( 165, 297, 143, "Transmute three Flawless To get one Perfect Skull!" );

	this.AddButton(130, 316, 4024, 4025, 28, GumpButtonType.Reply, 0);
	this.AddLabel(165, 313, 32, "3 Flawless Topaz to 1 Perfect Topaz" );
	this.AddLabel( 165, 327, 143, "Transmute three Flawless To get one Perfect Gem!" );
	////////////////////////////////////////////////////////////////////////
	this.AddPage(6);
	this.AddBackground(50, 30, 514, 350, 9270);
	this.AddAlphaRegion( 50, 30, 514, 350 );
	this.AddImage(50, 400, 9271);
	this.AddImage(50, 360, 10451);
	this.AddImage(150, 400, 9271);
	this.AddImage(175, 400, 9271);
	this.AddImage(200, 400, 9271);
	this.AddImage(250, 400, 9271);
	this.AddImage(350, 400, 9271);
	this.AddImage(375, 400, 9271);
	this.AddImage(400, 400, 9271);
	this.AddImage(490, 360, 10451);

	this.AddImage(86, 38, 10451);
	this.AddImage(90, 40, 9804);
	this.AddImage(446, 38, 10451);
	this.AddImage(450, 40, 9804);
	this.AddButton(75, 115, 12017, 12017, 0, GumpButtonType.Page, 5);//Previous
	//this.AddButton(450, 115, 12011, 12011, 0, GumpButtonType.Page, 6);//Next
	this.AddLabel(247, 45, 32, "The Horadic Cube" );
	this.AddLabel(195, 65, 43, "+ + + Transmutation System + + +" );
	this.AddButton(293, 360, 22153, 22154, 0, GumpButtonType.Page, 2);
	this.AddLabel(195, 380, 43, "+ + +Gems to Socketed Items+ + +");
	
	this.AddButton(130, 136, 4024, 4025, 29, GumpButtonType.Reply, 0);
	this.AddLabel(165, 133, 32, "6 Perfect Topazes for a random socketed Weapon" );
	this.AddLabel( 165, 147, 143, "Transmutes Gems to get random Socketed Weapon!" );
	
	this.AddButton(130, 166, 4024, 4025, 30, GumpButtonType.Reply, 0);
	this.AddLabel(165, 163, 32, "6 Perfect Skulls for random socketed Armor" );
	this.AddLabel( 165, 177, 143, "Transmutes Gems to get random Socketed Armor!" );
	
	this.AddButton(130, 196, 4024, 4025, 31, GumpButtonType.Reply, 0);
	this.AddLabel(165, 193, 32, "6 Perfect Amethysts for a random socketed Shield" );
	this.AddLabel( 165, 207, 143, "Transmutes Gems to get random Socketed Shield!" );
	
	/*this.AddButton(90, 226, 4024, 4025, 25, GumpButtonType.Reply, 0);
	this.AddLabel(125, 223, 3, "3 Flawless Ruby to 1 Perfect Ruby" );
	this.AddLabel( 125, 237, 68, "Transmute three Flawless To get one Perfect Gem!" );
	
	this.AddButton(90, 256, 4024, 4025, 26, GumpButtonType.Reply, 0);
	this.AddLabel(125, 253, 3, "3 Flawless Sapphire to 1 Perfect Sapphire" );
	this.AddLabel( 125, 267, 68, "Transmute three Flawless To get one Perfect Gem!" );
	
	this.AddButton(90, 286, 4024, 4025, 27, GumpButtonType.Reply, 0);
	this.AddLabel(125, 283, 3, "3 Flawless Skull to 1 Perfect Skull" );
	this.AddLabel( 125, 297, 68, "Transmute three Flawless To get one Perfect Skull!" );

	this.AddButton(90, 316, 4024, 4025, 28, GumpButtonType.Reply, 0);
	this.AddLabel(125, 313, 3, "3 Flawless Topaz to 1 Perfect Topaz" );
	this.AddLabel( 125, 327, 68, "Transmute three Flawless To get one Perfect Gem!" );*/
	////////////////////////////////////////////////////////////////////////
	this.AddPage(2);
	this.AddBackground(50, 30, 514, 350, 9270);
	this.AddAlphaRegion( 50, 30, 514, 350 );
	this.AddImage(50, 400, 9271);
	this.AddImage(50, 360, 10451);
	this.AddImage(150, 400, 9271);
	this.AddImage(175, 400, 9271);
	this.AddImage(200, 400, 9271);
	this.AddImage(250, 400, 9271);
	this.AddImage(350, 400, 9271);
	this.AddImage(375, 400, 9271);
	this.AddImage(400, 400, 9271);
	this.AddImage(490, 360, 10451);
	this.AddButton(290, 360, 1150, 1150, 0, GumpButtonType.Page, 1);
	this.AddImage(86, 38, 10451);
	this.AddImage(90, 40, 9804);
	this.AddImage(446, 38, 10451);
	this.AddImage(450, 40, 9804);
	this.AddLabel(195, 380, 43, "+ + + Transmutation System + + +");
	this.AddLabel(230, 45, 32, "The Diablo Horadic Cube" );
	this.AddLabel(205, 65, 43, "Version 1.0 By Lunatic Thrasher" );
	this.AddHtml( 160, 95, 300, 250, 
	"<center>This is a tribute to one of the best rpg's I ever played, Diablo2!" +
	" With the Horadic Cube you will be able to transmute 3 chipped, flawed, plain and flawless gems into the next better gem." +
	" I am also adding the transmutation of 6 perfect topazes for a random socketed weapon, the transmutation of 6 perfect skulls for a random socketed armor piece, the transmutation of 6 perfect amythysts for a random socketed shield" +
	" So please have fun with this system and hope it brings back some good rpg memories. It should not be to hard to add your own transmute options, just add the code for more pages and more transmutations.</center>", true, true );
	}
	
	public int m_SocketWeaponRoll = Utility.Random( 102 );
	public int m_SocketArmorRoll = Utility.Random( 148 );
	public int m_SocketShieldRoll = Utility.Random( 16 );
		
	public override void OnResponse( NetState sender, RelayInfo info )
	{
		Mobile from = sender.Mobile;

		switch ( info.ButtonID )
		{
		
		// Chipped 2 Flawed page one
		case 1:
			{
			Item[] ChippedAmethyst = from.Backpack.FindItemsByType( typeof( ChippedAmethyst ) );
			if ( from.Backpack.ConsumeTotal( typeof( ChippedAmethyst ), 3 ) )
			{
			FlawedAmethyst FlawedAmethyst = new FlawedAmethyst();
			from.AddToBackpack( FlawedAmethyst );
			from.SendMessage( 55, "A Flawed Amethyst has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
			
		case 2:
			{
			Item[] ChippedDiamond = from.Backpack.FindItemsByType( typeof( ChippedDiamond ) );
			if ( from.Backpack.ConsumeTotal( typeof( ChippedDiamond ), 3 ) )
			{
			FlawedDiamond FlawedDiamond = new FlawedDiamond();
			from.AddToBackpack( FlawedDiamond );
			from.SendMessage( 55, "A Flawed Diamond has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
		   break;
			} 
			
		case 3:
			{
			Item[] ChippedEmerald = from.Backpack.FindItemsByType( typeof( ChippedEmerald ) );
			if ( from.Backpack.ConsumeTotal( typeof( ChippedEmerald ), 3 ) )
			{
			FlawedEmerald FlawedEmerald = new FlawedEmerald();
			from.AddToBackpack( FlawedEmerald );
			from.SendMessage( 55, "A Flawed Emerald has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			}
			
		case 4:
			{
			Item[] ChippedRuby = from.Backpack.FindItemsByType( typeof( ChippedRuby ) );
			if ( from.Backpack.ConsumeTotal( typeof( ChippedRuby ), 3 ) )
			{
			FlawedRuby FlawedRuby = new FlawedRuby();
			from.AddToBackpack( FlawedRuby );
			from.SendMessage( 55, "A Flawed Ruby has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 5:
			{
			Item[] ChippedSapphire = from.Backpack.FindItemsByType( typeof( ChippedSapphire ) );
			if ( from.Backpack.ConsumeTotal( typeof( ChippedSapphire ), 3 ) )
			{
			FlawedSapphire FlawedSapphire = new FlawedSapphire();
			from.AddToBackpack( FlawedSapphire );
			from.SendMessage( 55, "A Flawed Sapphire has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 6:
			{
			Item[] ChippedSkull = from.Backpack.FindItemsByType( typeof( ChippedSkull ) );
			if ( from.Backpack.ConsumeTotal( typeof( ChippedSkull ), 3 ) )
			{
			FlawedSkull FlawedSkull = new FlawedSkull();
			from.AddToBackpack( FlawedSkull );
			from.SendMessage( 55, "A Flawed Skull has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		// Flawed 2 Plain page 3	
		case 7:
			{
			Item[] ChippedTopaz = from.Backpack.FindItemsByType( typeof( ChippedTopaz ) );
			if ( from.Backpack.ConsumeTotal( typeof( ChippedTopaz ), 3 ) )
			{
			FlawedTopaz FlawedTopaz = new FlawedTopaz();
			from.AddToBackpack( FlawedTopaz );
			from.SendMessage( 55, "A Flawed Topaz has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 8:
			{
			Item[] FlawedAmethyst = from.Backpack.FindItemsByType( typeof( FlawedAmethyst ) );
			if ( from.Backpack.ConsumeTotal( typeof( FlawedAmethyst ), 3 ) )
			{
			PlainAmethyst PlainAmethyst = new PlainAmethyst();
			from.AddToBackpack( PlainAmethyst );
			from.SendMessage( 55, "A Plain Amethyst has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 9:
			{
			Item[] FlawedDiamond = from.Backpack.FindItemsByType( typeof( FlawedDiamond ) );
			if ( from.Backpack.ConsumeTotal( typeof( FlawedDiamond ), 3 ) )
			{
			PlainDiamond PlainDiamond = new PlainDiamond();
			from.AddToBackpack( PlainDiamond );
			from.SendMessage( 55, "A Plain Diamond has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 10:
			{
			Item[] FlawedEmerald = from.Backpack.FindItemsByType( typeof( FlawedEmerald ) );
			if ( from.Backpack.ConsumeTotal( typeof( FlawedEmerald ), 3 ) )
			{
			PlainEmerald PlainEmerald = new PlainEmerald();
			from.AddToBackpack( PlainEmerald );
			from.SendMessage( 55, "A Plain Emerald has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 11:
			{
			Item[] FlawedRuby = from.Backpack.FindItemsByType( typeof( FlawedRuby ) );
			if ( from.Backpack.ConsumeTotal( typeof( FlawedRuby ), 3 ) )
			{
			PlainRuby PlainRuby = new PlainRuby();
			from.AddToBackpack( PlainRuby );
			from.SendMessage( 55, "A Plain Ruby has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 12:
			{
			Item[] FlawedSapphire = from.Backpack.FindItemsByType( typeof( FlawedSapphire ) );
			if ( from.Backpack.ConsumeTotal( typeof( FlawedSapphire ), 3 ) )
			{
			PlainSapphire PlainSapphire = new PlainSapphire();
			from.AddToBackpack( PlainSapphire );
			from.SendMessage( 55, "A Plain Sapphire has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 13:
			{
			Item[] FlawedSkull = from.Backpack.FindItemsByType( typeof( FlawedSkull ) );
			if ( from.Backpack.ConsumeTotal( typeof( FlawedSkull ), 3 ) )
			{
			PlainSkull PlainSkull = new PlainSkull();
			from.AddToBackpack( PlainSkull );
			from.SendMessage( 55, "A Plain Skull has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 14:
			{
			Item[] FlawedTopaz = from.Backpack.FindItemsByType( typeof( FlawedTopaz ) );
			if ( from.Backpack.ConsumeTotal( typeof( FlawedTopaz ), 3 ) )
			{
			PlainTopaz PlainTopaz = new PlainTopaz();
			from.AddToBackpack( PlainTopaz );
			from.SendMessage( 55, "A Plain Topaz has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		// Plain 2 Flawless	paged four
		case 15:
			{
			Item[] PlainAmethyst = from.Backpack.FindItemsByType( typeof( PlainAmethyst ) );
			if ( from.Backpack.ConsumeTotal( typeof( PlainAmethyst ), 3 ) )
			{
			FlawlessAmethyst FlawlessAmethyst = new FlawlessAmethyst();
			from.AddToBackpack( FlawlessAmethyst );
			from.SendMessage( 55, "A Flawless Amethyst has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 16:
			{
			Item[] PlainDiamond = from.Backpack.FindItemsByType( typeof( PlainDiamond ) );
			if ( from.Backpack.ConsumeTotal( typeof( PlainDiamond ), 3 ) )
			{
			FlawlessDiamond FlawlessDiamond = new FlawlessDiamond();
			from.AddToBackpack( FlawlessDiamond );
			from.SendMessage( 55, "A Flawless Diamond has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 17:
			{
			Item[] PlainEmerald = from.Backpack.FindItemsByType( typeof( PlainEmerald ) );
			if ( from.Backpack.ConsumeTotal( typeof( PlainEmerald ), 3 ) )
			{
			FlawlessEmerald FlawlessEmerald = new FlawlessEmerald();
			from.AddToBackpack( FlawlessEmerald );
			from.SendMessage( 55, "A Flawless Emerald has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 

		case 18:
			{
			Item[] PlainRuby = from.Backpack.FindItemsByType( typeof( PlainRuby ) );
			if ( from.Backpack.ConsumeTotal( typeof( PlainRuby ), 3 ) )
			{
			FlawlessRuby FlawlessRuby = new FlawlessRuby();
			from.AddToBackpack( FlawlessRuby );
			from.SendMessage( 55, "A Flawless Ruby has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 19:
			{
			Item[] PlainSapphire = from.Backpack.FindItemsByType( typeof( PlainSapphire ) );
			if ( from.Backpack.ConsumeTotal( typeof( PlainSapphire ), 3 ) )
			{
			FlawlessSapphire FlawlessSapphire = new FlawlessSapphire();
			from.AddToBackpack( FlawlessSapphire );
			from.SendMessage( 55, "A Flawless Sapphire has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 20:
			{
			Item[] PlainSkull = from.Backpack.FindItemsByType( typeof( PlainSkull ) );
			if ( from.Backpack.ConsumeTotal( typeof( PlainSkull ), 3 ) )
			{
			FlawlessSkull FlawlessSkull = new FlawlessSkull();
			from.AddToBackpack( FlawlessSkull );
			from.SendMessage( 55, "A Flawless Skull has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 21:
			{
			Item[] PlainTopaz = from.Backpack.FindItemsByType( typeof( PlainTopaz ) );
			if ( from.Backpack.ConsumeTotal( typeof( PlainTopaz ), 3 ) )
			{
			FlawlessTopaz FlawlessTopaz = new FlawlessTopaz();
			from.AddToBackpack( FlawlessTopaz );
			from.SendMessage( 55, "A Flawless Topaz has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			}  
			
		// Flawless 2 Perfect page five	
		case 22:
			{
			Item[] FlawlessAmethyst = from.Backpack.FindItemsByType( typeof( FlawlessAmethyst ) );
			if ( from.Backpack.ConsumeTotal( typeof( FlawlessAmethyst ), 3 ) )
			{
			PerfectAmethyst PerfectAmethyst = new PerfectAmethyst();
			from.AddToBackpack( PerfectAmethyst );
			from.SendMessage( 55, "A Perfect Amethyst has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			}
		case 23:
			{
			Item[] FlawlessDiamond = from.Backpack.FindItemsByType( typeof( FlawlessDiamond ) );
			if ( from.Backpack.ConsumeTotal( typeof( FlawlessDiamond ), 3 ) )
			{
			PerfectDiamond PerfectDiamond = new PerfectDiamond();
			from.AddToBackpack( PerfectDiamond );
			from.SendMessage( 55, "A Perfect Diamond has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 24:
			{
			Item[] FlawlessEmerald = from.Backpack.FindItemsByType( typeof( FlawlessEmerald ) );
			if ( from.Backpack.ConsumeTotal( typeof( FlawlessEmerald ), 3 ) )
			{
			PerfectDiabloEmerald PerfectDiabloEmerald = new PerfectDiabloEmerald();
			from.AddToBackpack( PerfectDiabloEmerald );
			from.SendMessage( 55, "A Perfect Emerald has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			}
		case 25:
			{
			Item[] FlawlessRuby = from.Backpack.FindItemsByType( typeof( FlawlessRuby ) );
			if ( from.Backpack.ConsumeTotal( typeof( FlawlessRuby ), 3 ) )
			{
			PerfectRuby PerfectRuby = new PerfectRuby();
			from.AddToBackpack( PerfectRuby );
			from.SendMessage( 55, "A Perfect Ruby has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 26:
			{
			Item[] FlawlessSapphire = from.Backpack.FindItemsByType( typeof( FlawlessSapphire ) );
			if ( from.Backpack.ConsumeTotal( typeof( FlawlessSapphire ), 3 ) )
			{
			PerfectSapphire PerfectSapphire = new PerfectSapphire();
			from.AddToBackpack( PerfectSapphire );
			from.SendMessage( 55, "A Perfect Sapphire has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			}
		case 27:
			{
			Item[] FlawlessSkull = from.Backpack.FindItemsByType( typeof( FlawlessSkull ) );
			if ( from.Backpack.ConsumeTotal( typeof( FlawlessSkull ), 3 ) )
			{
			PerfectSkull PerfectSkull = new PerfectSkull();
			from.AddToBackpack( PerfectSkull );
			from.SendMessage( 55, "A Perfect Skull has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 28:
			{
			Item[] FlawlessTopaz = from.Backpack.FindItemsByType( typeof( FlawlessTopaz ) );
			if ( from.Backpack.ConsumeTotal( typeof( FlawlessTopaz ), 3 ) )
			{
			PerfectTopaz PerfectTopaz = new PerfectTopaz();
			from.AddToBackpack( PerfectTopaz );
			from.SendMessage( 55, "A Perfect Topaz has been placed in your pack." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			}
			
		// Other Transmutes	page six	
		case 29:
			{
			Item[] PerfectTopaz = from.Backpack.FindItemsByType( typeof( PerfectTopaz ) );
			if ( from.Backpack.ConsumeTotal( typeof( PerfectTopaz ), 6 ) )
			{
				if ( m_SocketWeaponRoll == 0 )
				{
					from.AddToBackpack( new SocketedAxe() );
				}
				else if ( m_SocketWeaponRoll == 1 )
				{
					from.AddToBackpack( new SocketedBattleAxe() );
				}
				else if ( m_SocketWeaponRoll == 2 )
				{
					from.AddToBackpack( new SocketedDoubleAxe() );
				}
				else if ( m_SocketWeaponRoll == 3 )
				{
					from.AddToBackpack( new SocketedExecutionersAxe() );
				}
				else if ( m_SocketWeaponRoll == 4 )
				{
					from.AddToBackpack( new SocketedLargeBattleAxe() );
				}
				else if ( m_SocketWeaponRoll == 5 )
				{
					from.AddToBackpack( new SocketedTwoHandedAxe() );
				}
				else if ( m_SocketWeaponRoll == 6 )
				{
					from.AddToBackpack( new SocketedWarAxe() );
				}
				else if ( m_SocketWeaponRoll == 7 )
				{
					from.AddToBackpack( new SocketedDagger() );
				}
				else if ( m_SocketWeaponRoll == 8 )
				{
					from.AddToBackpack( new SocketedClub() );
				}
				else if ( m_SocketWeaponRoll == 9 )
				{
					from.AddToBackpack( new SocketedHammerPick() );
				}
				else if ( m_SocketWeaponRoll == 10 )
				{
					from.AddToBackpack( new SocketedMace() );
				}
				else if ( m_SocketWeaponRoll == 11 )
				{
					from.AddToBackpack( new SocketedMaul() );
				}
				else if ( m_SocketWeaponRoll == 12 )
				{
					from.AddToBackpack( new SocketedScepter() );
				}
				else if ( m_SocketWeaponRoll == 13 )
				{
					from.AddToBackpack( new SocketedWarHammer() );
				}
				else if ( m_SocketWeaponRoll == 14 )
				{
					from.AddToBackpack( new SocketedWarMace() );
				}
				else if ( m_SocketWeaponRoll == 15 )
				{
					from.AddToBackpack( new SocketedBardiche() );
				}
				else if ( m_SocketWeaponRoll == 16 )
				{
					from.AddToBackpack( new SocketedHalberd() );
				}
				else if ( m_SocketWeaponRoll == 17 )
				{
					from.AddToBackpack( new SocketedScythe() );
				}
				else if ( m_SocketWeaponRoll == 18 )
				{
					from.AddToBackpack( new SocketedBow() );
				}
				else if ( m_SocketWeaponRoll == 19 )
				{
					from.AddToBackpack( new SocketedCompositeBow() );
				}
				else if ( m_SocketWeaponRoll == 20 )
				{
					from.AddToBackpack( new SocketedCrossbow() );
				}
				else if ( m_SocketWeaponRoll == 21 )
				{
					from.AddToBackpack( new SocketedHeavyCrossbow() );
				}
				else if ( m_SocketWeaponRoll == 22 )
				{
					from.AddToBackpack( new SocketedRepeatingCrossbow() );
				}
				else if ( m_SocketWeaponRoll == 23 )
				{
					from.AddToBackpack( new SocketedBladedStaff() );
				}
				else if ( m_SocketWeaponRoll == 24 )
				{
					from.AddToBackpack( new SocketedDoubleBladedStaff() );
				}
				else if ( m_SocketWeaponRoll == 25 )
				{
					from.AddToBackpack( new SocketedPike() );
				}
				else if ( m_SocketWeaponRoll == 26 )
				{
					from.AddToBackpack( new SocketedShortSpear() );
				}
				else if ( m_SocketWeaponRoll == 27 )
				{
					from.AddToBackpack( new SocketedSpear() );
				}
				else if ( m_SocketWeaponRoll == 28 )
				{
					from.AddToBackpack( new SocketedWarFork() );
				}
				else if ( m_SocketWeaponRoll == 29 )
				{
					from.AddToBackpack( new SocketedPitchfork() );
				}
				else if ( m_SocketWeaponRoll == 30 )
				{
					from.AddToBackpack( new SocketedBlackStaff() );
				}
				else if ( m_SocketWeaponRoll == 31 )
				{
					from.AddToBackpack( new SocketedGnarledStaff() );
				}
				else if ( m_SocketWeaponRoll == 32 )
				{
					from.AddToBackpack( new SocketedQuarterStaff() );
				}
				else if ( m_SocketWeaponRoll == 33 )
				{
					from.AddToBackpack( new SocketedBoneHarvester() );
				}
				else if ( m_SocketWeaponRoll == 34 )
				{
					from.AddToBackpack( new SocketedBroadsword() );
				}
				else if ( m_SocketWeaponRoll == 35 )
				{
					from.AddToBackpack( new SocketedCrescentBlade() );
				}
				else if ( m_SocketWeaponRoll == 36 )
				{
					from.AddToBackpack( new SocketedCutlass() );
				}
				else if ( m_SocketWeaponRoll == 37 )
				{
					from.AddToBackpack( new SocketedKatana() );
				}
				else if ( m_SocketWeaponRoll == 38 )
				{
					from.AddToBackpack( new SocketedKryss() );
				}
				else if ( m_SocketWeaponRoll == 39 )
				{
					from.AddToBackpack( new SocketedLance() );
				}
				else if ( m_SocketWeaponRoll == 40 )
				{
					from.AddToBackpack( new SocketedLongSword() );
				}
				else if ( m_SocketWeaponRoll == 41 )
				{
					from.AddToBackpack( new SocketedScimitar() );
				}
				else if ( m_SocketWeaponRoll == 42 )
				{
					from.AddToBackpack( new SocketedVikingSword() );
				}
				else if ( m_SocketWeaponRoll == 43 )
				{
					from.AddToBackpack( new SocketedJukaBow() );
				}
				else if ( m_SocketWeaponRoll == 44 )
				{
					from.AddToBackpack( new SocketedYumi() );
				}
				else if ( m_SocketWeaponRoll == 45 )
				{
					from.AddToBackpack( new SocketedElvenCompositeLongbow() );
				}
				else if ( m_SocketWeaponRoll == 46 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				///////////////////////////////////////////////////////
				else if ( m_SocketWeaponRoll == 47 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 48 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 49 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 50 )
				{
					from.AddToBackpack( new SocketedThinLongsword() );
				}
				else if ( m_SocketWeaponRoll == 51 )
				{
					from.AddToBackpack( new SocketedWakizashi() );
				}
				else if ( m_SocketWeaponRoll == 52 )
				{
					from.AddToBackpack( new SocketedTetsubo() );
				}
				else if ( m_SocketWeaponRoll == 53 )
				{
					from.AddToBackpack( new SocketedTessen() );
				}
				else if ( m_SocketWeaponRoll == 54 )
				{
					from.AddToBackpack( new SocketedTekagi() );
				}
				else if ( m_SocketWeaponRoll == 55 )
				{
					from.AddToBackpack( new SocketedSai() );
				}
				else if ( m_SocketWeaponRoll == 56 )
				{
					from.AddToBackpack( new SocketedNunchaku() );
				}
				else if ( m_SocketWeaponRoll == 57 )
				{
					from.AddToBackpack( new SocketedNoDachi() );
				}
				else if ( m_SocketWeaponRoll == 58 )
				{
					from.AddToBackpack( new SocketedLajatang() );
				}
				else if ( m_SocketWeaponRoll == 59 )
				{
					from.AddToBackpack( new SocketedKama() );
				}
				else if ( m_SocketWeaponRoll == 60 )
				{
					from.AddToBackpack( new SocketedDaisho() );
				}
				else if ( m_SocketWeaponRoll == 61 )
				{
					from.AddToBackpack( new SocketedBokuto() );
				}
				else if ( m_SocketWeaponRoll == 62 )
				{
					from.AddToBackpack( new SocketedWildStaff() );
				}
				else if ( m_SocketWeaponRoll == 63 )
				{
					from.AddToBackpack( new SocketedWarCleaver() );
				}
				else if ( m_SocketWeaponRoll == 64 )
				{
					from.AddToBackpack( new SocketedRuneBlade() );
				}
				else if ( m_SocketWeaponRoll == 65 )
				{
					from.AddToBackpack( new SocketedRadiantScimitar() );
				}
				else if ( m_SocketWeaponRoll == 66 )
				{
					from.AddToBackpack( new SocketedOrnateAxe() );
				}
				else if ( m_SocketWeaponRoll == 67 )
				{
					from.AddToBackpack( new SocketedLeafblade() );
				}
				else if ( m_SocketWeaponRoll == 68 )
				{
					from.AddToBackpack( new SocketedElvenSpellblade() );
				}
				else if ( m_SocketWeaponRoll == 69 )
				{
					from.AddToBackpack( new SocketedElvenMachete() );
				}
				else if ( m_SocketWeaponRoll == 70 )
				{
					from.AddToBackpack( new SocketedDiamondMace() );
				}
				else if ( m_SocketWeaponRoll == 71 )
				{
					from.AddToBackpack( new SocketedAssassinSpike() );
				}
				else if ( m_SocketWeaponRoll == 72 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 73 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 74 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 75 )
				{
					from.AddToBackpack( new SocketedGlassSword() );
				}
				else if ( m_SocketWeaponRoll == 76 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 77 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 78 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 79 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 80 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 81 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 82 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 83 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 84 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 85 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 86 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 87 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 88 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 89 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 90 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 91 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 92 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 93 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 94 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 95 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 96 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 97 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 98 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 99 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 100 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				else if ( m_SocketWeaponRoll == 101 )
				{
					from.AddToBackpack( new SocketedMagicalShortbow() );
				}
				from.SendMessage( 55, "You have Transmuted the Gems into a Socketed Weapon." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			} 
			
		case 30:
			{
			Item[] PerfectSkull = from.Backpack.FindItemsByType( typeof( PerfectSkull ) );
			if ( from.Backpack.ConsumeTotal( typeof( PerfectSkull ), 6 ) )
			{
				if ( m_SocketArmorRoll == 0 )
				{
					from.AddToBackpack( new SocketedBoneArms() );
				}
				else if ( m_SocketArmorRoll == 1 )
				{
					from.AddToBackpack( new SocketedBoneChest() );
				}
				else if ( m_SocketArmorRoll == 2 )
				{
					from.AddToBackpack( new SocketedBoneGloves() );
				}
				else if ( m_SocketArmorRoll == 3 )
				{
					from.AddToBackpack( new SocketedBoneLegs() );
				}
				else if ( m_SocketArmorRoll == 4 )
				{
					from.AddToBackpack( new SocketedChainChest() );
				}
				else if ( m_SocketArmorRoll == 5 )
				{
					from.AddToBackpack( new SocketedChainLegs() );
				}
				else if ( m_SocketArmorRoll == 6 )
				{
					from.AddToBackpack( new SocketedBascinet() );
				}
				else if ( m_SocketArmorRoll == 7 )
				{
					from.AddToBackpack( new SocketedBoneHelm() );
				}
				else if ( m_SocketArmorRoll == 8 )
				{
					from.AddToBackpack( new SocketedChainCoif() );
				}
				else if ( m_SocketArmorRoll == 9 )
				{
					from.AddToBackpack( new SocketedCloseHelm() );
				}
				else if ( m_SocketArmorRoll == 10 )
				{
					from.AddToBackpack( new SocketedHelmet() );
				}
				else if ( m_SocketArmorRoll == 11 )
				{
					from.AddToBackpack( new SocketedLeatherCap() );
				}
				else if ( m_SocketArmorRoll == 12 )
				{
					from.AddToBackpack( new SocketedNorseHelm() );
				}
				else if ( m_SocketArmorRoll == 13 )
				{
					from.AddToBackpack( new SocketedOrcHelm() );
				}
				else if ( m_SocketArmorRoll == 14 )
				{
					from.AddToBackpack( new SocketedPlateHelm() );
				}
				else if ( m_SocketArmorRoll == 15 )
				{
					from.AddToBackpack( new SocketedFemaleLeatherChest() );
				}
				else if ( m_SocketArmorRoll == 16 )
				{
					from.AddToBackpack( new SocketedLeatherArms() );
				}
				else if ( m_SocketArmorRoll == 17 )
				{
					from.AddToBackpack( new SocketedLeatherBustierArms() );
				}
				else if ( m_SocketArmorRoll == 18 )
				{
					from.AddToBackpack( new SocketedLeatherChest() );
				}
				else if ( m_SocketArmorRoll == 19 )
				{
					from.AddToBackpack( new SocketedLeatherGloves() );
				}
				else if ( m_SocketArmorRoll == 20 )
				{
					from.AddToBackpack( new SocketedLeatherGorget() );
				}
				else if ( m_SocketArmorRoll == 21 )
				{
					from.AddToBackpack( new SocketedLeatherLegs() );
				}
				else if ( m_SocketArmorRoll == 22 )
				{
					from.AddToBackpack( new SocketedLeatherShorts() );
				}
				else if ( m_SocketArmorRoll == 23 )
				{
					from.AddToBackpack( new SocketedLeatherSkirt() );
				}
				else if ( m_SocketArmorRoll == 24 )
				{
					from.AddToBackpack( new SocketedFemalePlateChest() );
				}
				else if ( m_SocketArmorRoll == 25 )
				{
					from.AddToBackpack( new SocketedPlateArms() );
				}
				else if ( m_SocketArmorRoll == 26 )
				{
					from.AddToBackpack( new SocketedPlateChest() );
				}
				else if ( m_SocketArmorRoll == 27 )
				{
					from.AddToBackpack( new SocketedPlateGloves() );
				}
				else if ( m_SocketArmorRoll == 28 )
				{
					from.AddToBackpack( new SocketedPlateGorget() );
				}
				else if ( m_SocketArmorRoll == 29 )
				{
					from.AddToBackpack( new SocketedPlateLegs() );
				}
				else if ( m_SocketArmorRoll == 30 )
				{
					from.AddToBackpack( new SocketedRingmailArms() );
				}
				else if ( m_SocketArmorRoll == 31 )
				{
					from.AddToBackpack( new SocketedRingmailChest() );
				}
				else if ( m_SocketArmorRoll == 32 )
				{
					from.AddToBackpack( new SocketedRingmailGloves() );
				}
				else if ( m_SocketArmorRoll == 33 )
				{
					from.AddToBackpack( new SocketedRingmailLegs() );
				}
				else if ( m_SocketArmorRoll == 34 )
				{
					from.AddToBackpack( new SocketedFemaleStuddedChest() );
				}
				else if ( m_SocketArmorRoll == 35 )
				{
					from.AddToBackpack( new SocketedStuddedArms() );
				}
				else if ( m_SocketArmorRoll == 36 )
				{
					from.AddToBackpack( new SocketedStuddedBustierArms() );
				}
				else if ( m_SocketArmorRoll == 37 )
				{
					from.AddToBackpack( new SocketedStuddedChest() );
				}
				else if ( m_SocketArmorRoll == 38 )
				{
					from.AddToBackpack( new SocketedStuddedGloves() );
				}
				else if ( m_SocketArmorRoll == 39 )
				{
					from.AddToBackpack( new SocketedStuddedGorget() );
				}
				else if ( m_SocketArmorRoll == 40 )
				{
					from.AddToBackpack( new SocketedStuddedLegs() );
				}
				else if ( m_SocketArmorRoll == 41 )
				{
					from.AddToBackpack( new SocketedDragonLegs() );
				}
				else if ( m_SocketArmorRoll == 42 )
				{
					from.AddToBackpack( new SocketedDragonHelm() );
				}
				else if ( m_SocketArmorRoll == 43 )
				{
					from.AddToBackpack( new SocketedDragonGloves() );
				}
				else if ( m_SocketArmorRoll == 44 )
				{
					from.AddToBackpack( new SocketedDragonChest() );
				}
				else if ( m_SocketArmorRoll == 45 )
				{
					from.AddToBackpack( new SocketedDragonArms() );
				}
				else if ( m_SocketArmorRoll == 46 )
				{
					from.AddToBackpack( new SocketedDaemonLegs() );
				}
				else if ( m_SocketArmorRoll == 47 )
				{
					from.AddToBackpack( new SocketedDaemonGloves() );
				}
				else if ( m_SocketArmorRoll == 48 )
				{
					from.AddToBackpack( new SocketedDaemonChest() );
				}
				else if ( m_SocketArmorRoll == 49 )
				{
					from.AddToBackpack( new SocketedDaemonArms() );
				}
				else if ( m_SocketArmorRoll == 50 )
				{
					from.AddToBackpack( new SocketedChainHatsuburi() );
				}
				else if ( m_SocketArmorRoll == 51 )
				{
					from.AddToBackpack( new SocketedLeatherDo() );
				}
				else if ( m_SocketArmorRoll == 52 )
				{
					from.AddToBackpack( new SocketedLeatherJingasa() );
				}
				else if ( m_SocketArmorRoll == 53 )
				{
					from.AddToBackpack( new SocketedLeatherHiroSode() );
				}
				else if ( m_SocketArmorRoll == 54 )
				{
					from.AddToBackpack( new SocketedLeatherHaidate() );
				}
				else if ( m_SocketArmorRoll == 55 )
				{
					from.AddToBackpack( new SocketedStuddedDo() );
				}
				else if ( m_SocketArmorRoll == 56 )
				{
					from.AddToBackpack( new SocketedStuddedSuneate() );
				}
				else if ( m_SocketArmorRoll == 57 )
				{
					from.AddToBackpack( new SocketedStuddedMempo() );
				}
				else if ( m_SocketArmorRoll == 58 )
				{
					from.AddToBackpack( new SocketedLeatherSuneate() );
				}
				else if ( m_SocketArmorRoll == 59 )
				{
					from.AddToBackpack( new SocketedLeatherNinjaPants() );
				}
				else if ( m_SocketArmorRoll == 60 )
				{
					from.AddToBackpack( new SocketedLeatherNinjaMitts() );
				}
				else if ( m_SocketArmorRoll == 61 )
				{
					from.AddToBackpack( new SocketedLeatherNinjaJacket() );
				}
				else if ( m_SocketArmorRoll == 62 )
				{
					from.AddToBackpack( new SocketedLeatherNinjaHood() );
				}
				else if ( m_SocketArmorRoll == 63 )
				{
					from.AddToBackpack( new SocketedLeatherMempo() );
				}
				else if ( m_SocketArmorRoll == 64 )
				{
					from.AddToBackpack( new SocketedStuddedHiroSode() );
				}
				else if ( m_SocketArmorRoll == 65 )
				{
					from.AddToBackpack( new SocketedStuddedHaidate() );
				}
				else if ( m_SocketArmorRoll == 66 )
				{
					from.AddToBackpack( new SocketedPlateHiroSode() );
				}
				else if ( m_SocketArmorRoll == 67 )
				{
					from.AddToBackpack( new SocketedPlateBattleKabuto() );
				}
				else if ( m_SocketArmorRoll == 68 )
				{
					from.AddToBackpack( new SocketedLightPlateJingasa() );
				}
				else if ( m_SocketArmorRoll == 69 )
				{
					from.AddToBackpack( new SocketedHeavyPlateJingasa() );
				}
				else if ( m_SocketArmorRoll == 70 )
				{
					from.AddToBackpack( new SocketedDecorativePlateKabuto() );
				}
				else if ( m_SocketArmorRoll == 71 )
				{
					from.AddToBackpack( new SocketedPlateHatsuburi() );
				}
				else if ( m_SocketArmorRoll == 72 )
				{
					from.AddToBackpack( new SocketedPlateHaidate() );
				}
				else if ( m_SocketArmorRoll == 73 )
				{
					from.AddToBackpack( new SocketedStandardPlateKabuto() );
				}
				else if ( m_SocketArmorRoll == 74 )
				{
					from.AddToBackpack( new SocketedSmallPlateJingasa() );
				}
				else if ( m_SocketArmorRoll == 75 )
				{
					from.AddToBackpack( new SocketedPlateSuneate() );
				}
				else if ( m_SocketArmorRoll == 76 )
				{
					from.AddToBackpack( new SocketedPlateDo() );
				}
				else if ( m_SocketArmorRoll == 77 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 78 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 79 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 80 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 81 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 82 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 83 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 84 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 85 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 86 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 87 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 88 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 89 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 90 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 91 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 92 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 93 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 94 )
				{
					from.AddToBackpack( new SocketedRangerLegs() );
				}
				else if ( m_SocketArmorRoll == 95 )
				{
					from.AddToBackpack( new SocketedRangerGorget() );
				}
				else if ( m_SocketArmorRoll == 96 )
				{
					from.AddToBackpack( new SocketedRangerGloves() );
				}
				else if ( m_SocketArmorRoll == 97 )
				{
					from.AddToBackpack( new SocketedRangerChest() );
				}
				else if ( m_SocketArmorRoll == 98 )
				{
					from.AddToBackpack( new SocketedRangerArms() );
				}
				else if ( m_SocketArmorRoll == 99 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 100 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 101 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 102 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 103 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 104 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 105 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 106 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 107 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 108 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 109 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 110 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 111 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 112 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 113 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 114 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 115 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 116 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 117 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 118 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 119 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 120 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 111 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 112 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 113 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 114 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 115 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 116 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 117 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 118 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 119 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 120 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 121 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 122 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 123 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 124 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 125 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 126 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 127 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 128 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 129 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 130 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 131 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 132 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 133 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 134 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 135 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 136 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 137 )
				{
					from.AddToBackpack( new SocketedPlateHelm() );
				}
				else if ( m_SocketArmorRoll == 138 )
				{
					from.AddToBackpack( new SocketedOrcHelm() );
				}
				else if ( m_SocketArmorRoll == 139 )
				{
					from.AddToBackpack( new SocketedNorseHelm() );
				}
				else if ( m_SocketArmorRoll == 140 )
				{
					from.AddToBackpack( new SocketedLeatherCap() );
				}
				else if ( m_SocketArmorRoll == 141 )
				{
					from.AddToBackpack( new SocketedHelmet() );
				}
				else if ( m_SocketArmorRoll == 142 )
				{
					from.AddToBackpack( new SocketedDaemonHelm() );
				}
				else if ( m_SocketArmorRoll == 143 )
				{
					from.AddToBackpack( new SocketedCloseHelm() );
				}
				else if ( m_SocketArmorRoll == 144 )
				{
					from.AddToBackpack( new SocketedPlateMempo() );
				}
				else if ( m_SocketArmorRoll == 145 )
				{
					from.AddToBackpack( new SocketedChainCoif() );
				}
				else if ( m_SocketArmorRoll == 146 )
				{
					from.AddToBackpack( new SocketedBoneHelm() );
				}
				else if ( m_SocketArmorRoll == 147 )
				{
					from.AddToBackpack( new SocketedBascinet() );
				}
				from.SendMessage( 55, "You have Transmuted the Gems into a piece of Socketed Armor." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			}

		case 31:
			{
			Item[] PerfectAmethyst = from.Backpack.FindItemsByType( typeof( PerfectAmethyst ) );
			if ( from.Backpack.ConsumeTotal( typeof( PerfectAmethyst ), 6 ) )
			{
				if ( m_SocketShieldRoll == 0 )
				{
					from.AddToBackpack( new SocketedBronzeShield() );
				}
				else if ( m_SocketShieldRoll == 1 )
				{
					from.AddToBackpack( new SocketedBuckler() );
				}
				else if ( m_SocketShieldRoll == 2 )
				{
					from.AddToBackpack( new SocketedHeaterShield() );
				}
				else if ( m_SocketShieldRoll == 3 )
				{
					from.AddToBackpack( new SocketedMetalKiteShield() );
				}
				else if ( m_SocketShieldRoll == 4 )
				{
					from.AddToBackpack( new SocketedMetalShield() );
				}
				else if ( m_SocketShieldRoll == 5 )
				{
					from.AddToBackpack( new SocketedWoodenKiteShield() );
				}
				else if ( m_SocketShieldRoll == 6 )
				{
					from.AddToBackpack( new SocketedWoodenShield() );
				}
				if ( m_SocketShieldRoll == 7 )
				{
					from.AddToBackpack( new SocketedHeaterShield() );
				}
				else if ( m_SocketShieldRoll == 8 )
				{
					from.AddToBackpack( new SocketedHeaterShield() );
				}
				else if ( m_SocketShieldRoll == 9 )
				{
					from.AddToBackpack( new SocketedHeaterShield() );
				}
				else if ( m_SocketShieldRoll == 10 )
				{
					from.AddToBackpack( new SocketedHeaterShield() );
				}
				else if ( m_SocketShieldRoll == 11 )
				{
					from.AddToBackpack( new SocketedHeaterShield() );
				}
				else if ( m_SocketShieldRoll == 12 )
				{
					from.AddToBackpack( new SocketedHeaterShield() );
				}
				else if ( m_SocketShieldRoll == 13 )
				{
					from.AddToBackpack( new SocketedHeaterShield() );
				}
				else if ( m_SocketShieldRoll == 14 )
				{
					from.AddToBackpack( new SocketedHeaterShield() );
				}
				else if ( m_SocketShieldRoll == 15 )
				{
					from.AddToBackpack( new SocketedHeaterShield() );
				}
				from.SendMessage( 55, "You have Transmuted the Gems into a Socketed Shield." );
			}
			else
			{
			from.SendGump( new HoradicCubeGump( from) );
			from.SendMessage( 38, "You do not have the correct gems for that." );
			}
			break;
			}
		}
	}
}
