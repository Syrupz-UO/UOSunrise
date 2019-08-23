using System;
using Server;
using System.IO;
using Server.Gumps;
using Server.Items;
using Server.Network;
using Server.Mobiles;
using Server.Accounting;
using System.Collections;
using Server.Commands;
using System.Text;

namespace Server.Gumps
{
	public class PlayerSuggestion : Gump
	{
		public PlayerSuggestion()
			: base( 0, 0 )
		{
			this.Closable=true;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;
			this.AddPage(0);
			this.AddBackground(256, 207, 298, 287, 9200);
			this.AddLabel(353, 228, 0, @"Player Suggestion:");//Suggestion
			this.AddButton(377, 464, 247, 248, (int)Buttons.Button1, GumpButtonType.Reply, 0);
			this.AddAlphaRegion(280, 251, 251, 202);
			this.AddImage(450, 466, 5411);
			this.AddImage(347, 466, 5411);
			this.AddTextEntry(280, 252, 253, 202, 0, (int)Buttons.TextEntry1, @"");

		}
		
		public enum Buttons
		{
			Button1,
			TextEntry1,
		}
		
		public override void OnResponse(Server.Network.NetState sender, RelayInfo info)
		{
			Mobile from = sender.Mobile;
			Account acct = (Account)from.Account;
			
			switch ( info.ButtonID )
			{
				case (int)Buttons.Button1:
				string tudo = (string)info.GetTextEntry( (int)Buttons.TextEntry1 ).Text;
					
				Console.WriteLine("");
                Console.WriteLine("{0} From Account {1} Sent a Suggestion", from.Name, acct.Username);//from.Name of account send a suggestion
				Console.WriteLine("");
						
				if ( !Directory.Exists( "Player Suggestions" ) ) //create directory
					Directory.CreateDirectory( "Player Suggestions" );
						
				using ( StreamWriter op = new StreamWriter("Player Suggestions/PlayerSuggestion.txt", true) )
				{	
						op.WriteLine("");
						op.WriteLine("Name Of Character: {0}, Account:{1}",from.Name,acct.Username);
						op.WriteLine("Message: {0}", tudo);
						op.WriteLine("");	
				}
						
				from.SendMessage("Thanks for your suggestion!");//thanks for your suggestion
						
				break;		
			}
		}		
	}
}