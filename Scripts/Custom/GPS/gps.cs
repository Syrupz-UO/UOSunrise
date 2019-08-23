using System;
using Server;
using Server.Gumps;
using Server.Mobiles;
using Server.Network;
using Server.Commands;
using System.Collections.Generic;

namespace Server.Gumps
{
    public class GpsGump : Gump
    {
        public static void Initialize()
        {
            CommandSystem.Register("gps", AccessLevel.GameMaster, new CommandEventHandler(Showart_OnCommand));
        }

        [Usage("gps")]
        [Description("gps")]
        public static void Showart_OnCommand(CommandEventArgs e)
        {

            e.Mobile.SendGump(new GpsGump(e.Mobile, 16383));
        }


        private Mobile m_From;
        private int m_newstart;
        private static Point3D m_Location;
        

        public GpsGump(Mobile from, int index) //int index
            : base(600, 100)
        {

         
				
			
			
			


            this.Closable=true;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;
			
            this.AddPage(0);
            this.AddBackground(0, 0, 220, 36, 311); // width adjust var 3 - Doc 36
            //this.AddLabel(16, 9, 33, String.Format("{0} : ", map));
			this.AddLabel(90, 30, 33, String.Format("{0}  ", from.Region.Name));
			
            int xLong = 0, yLat = 0;
            int xMins = 0, yMins = 0;
            bool xEast = false, ySouth = false;

            if (Server.Items.Sextant.Format(from.Location, from.Map, ref xLong, ref yLat, ref xMins, ref yMins, ref xEast, ref ySouth))
            {

                string location = String.Format("{0}° {1}'{2}, {3}° {4}'{5}", yLat, yMins, ySouth ? "S" : "N", xLong, xMins, xEast ? "E" : "W");
            }
            this.AddLabel(90, 9, 33, String.Format("{0}° {1}'{2}, {3}° {4}'{5}", yLat, yMins, ySouth ? "S" : "N", xLong, xMins, xEast ? "E" : "W"));





        }
    }
}
