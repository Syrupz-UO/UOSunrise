using System; using Server; using Server.Commands;using Server.Gumps; using Server.Network;using Server.Items;using Server.Mobiles;namespace Server.Gumps
{ public class FullSpellBookQuestGump : Gump { 
public static void Initialize() { 
CommandSystem.Register( "FullSpellBookQuestGump", AccessLevel.GameMaster, new CommandEventHandler( FullSpellBookQuestGump_OnCommand ) ); 
}
private static void FullSpellBookQuestGump_OnCommand( CommandEventArgs e ) 
{
e.Mobile.SendGump( new FullSpellBookQuestGump( e.Mobile ) ); } 
public FullSpellBookQuestGump( Mobile owner ) : base( 50,50 ) 
{
//----------------------------------------------------------------------------------------------------
AddPage( 0 );AddImageTiled(  54, 33, 369, 400, 2624 );AddAlphaRegion( 54, 33, 369, 400 );AddImageTiled( 416, 39, 44, 389, 203 );
//--------------------------------------Window size bar--------------------------------------------
AddImage( 97, 49, 9005 );AddImageTiled( 58, 39, 29, 390, 10460 );AddImageTiled( 412, 37, 31, 389, 10460 );
AddLabel( 140, 60, 0x34, "Festis The mage" );
//----------------------/----------------------------------------------/
AddHtml( 107, 140, 300, 230, " < BODY > " + 
"<BASEFONT COLOR=YELLOW>A moment of your time traveler....<BR>" +
"<BASEFONT COLOR=YELLOW>I am Festis. A great and wise mage.<BR>" +
"<BASEFONT COLOR=YELLOW>I am also lazier than Grizzly Adams and am looking for someone to fetch something I have lost.<BR>" +
"<BASEFONT COLOR=YELLOW>While recently helping my new pupil, Jandra, in Haven I lost my notes.<BR>" +
"<BASEFONT COLOR=YELLOW>We were practicing sword play on some lizardmen in the lizardman cave dungeon.<BR>" +
"<BASEFONT COLOR=YELLOW>A lizardman rushed from the bushes and grabbed my lunch.<BR>" +
"<BASEFONT COLOR=YELLOW>In the lunch were my notes. And alas my sandwich.<BR>" +
"<BASEFONT COLOR=YELLOW>My sandwich I am sure to say has long since ceased to exist.<BR>" +
"<BASEFONT COLOR=YELLOW>But if you were to make your way to the lizardman dungeon and locate the lizardman and my notes I would be forever in your debt.<BR>" +
"<BASEFONT COLOR=YELLOW>And don't forget to keep your eyes out for my sandwich as well. One can always hope.<BR>" +
"</BODY>", false, true);
//----------------------/----------------------------------------------/
AddImage( 430, 9, 10441);AddImageTiled( 40, 38, 17, 391, 9263 );AddImage( 6, 25, 10421 );AddImage( 34, 12, 10420 );AddImageTiled( 94, 25, 342, 15, 10304 );AddImageTiled( 40, 427, 415, 16, 10304 );AddImage( -10, 314, 10402 );AddImage( 56, 150, 10411 );AddImage( 155, 120, 2103 );AddImage( 136, 84, 96 );AddButton( 225, 390, 0xF7, 0xF8, 0, GumpButtonType.Reply, 0 ); }
//----------------------/----------------------------------------------/
public override void OnResponse( NetState state, RelayInfo info ){ Mobile from = state.Mobile; switch ( info.ButtonID ) { case 0:{ break; }}}}}
