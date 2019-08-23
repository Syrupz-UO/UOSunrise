using System;
using System.Text;
using Server;

namespace Bittiez.RevRaffle
{

    public class SETTINGS
    {
        public static int LabelHue = 42;
        public static int ValueHue = 67;
        public static int Width = 400, Height = 300;
        public static string Limit = "You cannot purchase any more tickets because you are at your limit.";
        public static string Purchase = "You have purchased {0} tickets."; // {0} = amount of tickets purchased
        public static string Not_Enough_Gold = "You need {0} gold coins to purchase {1} tickets."; //{0} = total cost, {1} = total tickets
        public static AccessLevel Set_Up_AccessLevel = AccessLevel.Counselor;
    }
}
