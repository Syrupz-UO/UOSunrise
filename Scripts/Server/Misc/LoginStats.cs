using System;
using Server.Network;
using Server.Engines.Quests;
using Server.Mobiles;
using System.Collections.Generic;

using Server.Gumps;  // UNIQUE NAMING SYSTEM

namespace Server.Misc
{
    public class LoginStats
    {
        public static void Initialize()
        {
            // Register our event handler
            EventSink.Login += new LoginEventHandler(EventSink_Login);
        }

        private static void EventSink_Login(LoginEventArgs args)
        {
            int userCount = NetState.Instances.Count;
            int itemCount = World.Items.Count;
            int mobileCount = World.Mobiles.Count;
          //  Init CS = Init.Chat_Server;
           // CS.LastMessage = CHAN.WORLD;

            Mobile m = args.Mobile;
			
			if (args.Mobile is PlayerMobile)
			{
			PlayerMobile pm = args.Mobile as PlayerMobile;
			pm.SendGump(new ShowTool(pm));
			}

			if ( m.AccessLevel >= AccessLevel.GameMaster )
				m.SendMessage( "You can type '[helpadmin' to learn the commands for this server." );
			else
				m.SendMessage( "You can use the 'Help' button on your paperdoll for more information." );








		/*		string messages = "Use [pm to send mail. [Helpinfo for player commands. [viewissues to report problems or suggestions. There is a Wiki and forum on uosunrise.com";
				Bittiez.BoxerChat.Chat.AddMessage(CS.Messages, args.Mobile, messages, 1);
            Bittiez.BoxerChat.Chat.SendGump((int)CHAN.WORLD, args.Mobile);
            foreach (Item i in World.Items.Values)
                if (i is Gold)
                {
                    goldcount += ((Gold)i).Amount;
                }
                else if (i is BankCheck)
                    goldcount += ((BankCheck)i).Worth;

            string message = String.Format("There {0} currently {1} user{2} with {3} item{4} {5} mobile{6} in the world.",userCount == 1 ? "is" : "are",userCount, userCount == 1 ? "" : "s",itemCount, itemCount == 1 ? "" : "s",mobileCount, mobileCount == 1 ? "" : "s");
            //
           // need to fix message order and staff/player notification
            //
            
            if (args.Mobile is PlayerMobile && args.Mobile.AccessLevel < AccessLevel.Counselor)
			{
            
            Bittiez.BoxerChat.Chat.AddMessage(CS.Messages, args.Mobile, message, 1);
            Bittiez.BoxerChat.Chat.SendGump((int)CHAN.WORLD, args.Mobile);
			}*/
				//Unique Naming System//
			#region CheckName
			if ( ( m.Name == CharacterCreation.GENERIC_NAME || !CharacterCreation.CheckDupe(m, m.Name) ) && m.AccessLevel < AccessLevel.GameMaster )
			{
				m.CantWalk = true;
				m.SendGump( new NameChangeGump( m) );
				

			}
			#endregion
			//Unique Naming System//
			
	




			
            
        }
            
        }
    }

