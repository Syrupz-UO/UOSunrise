using System;
using Server;
using Server.Gumps;
using Server.Network;
using Server.Commands;
using Bittiez.RevRaffle;
using Server.Items;
using System.Collections.Generic;

namespace Server.Gumps
{
    public class RevGuide : Gump
    {
        public enum PAGE
        {
            Price = 1,
            Date = 2,
            TicketLimit = 7,
            Props = 3,
            PlayerScreen = 4,
            EditPrice = 5,
            EditDate = 6,
            EditTicketLimit = 8
        }

        private int w = SETTINGS.Width, h = SETTINGS.Height;

        private RevRaffle REVR;

        Mobile caller;
        public RevGuide(Mobile from, RevRaffle RS, PAGE page)
            : base(50, 50)
        {
            REVR = RS;
            caller = from;
            this.Closable = page == PAGE.Props || page == PAGE.PlayerScreen ? true : false;
            this.Disposable = page == PAGE.Props || page == PAGE.PlayerScreen ? true : false;
            this.Dragable = true;
            this.Resizable = false;

            AddPage(0);
            AddBackground(0, 0, w, h, 9270);
            AddPage(1);

            ShowPage(page, from);
        }

        private void ShowPage(PAGE page, Mobile from)
        {
            int Button_Bot = h - 31, Button_2 = h - 57, ItemLoc = w - 55;
            switch (page)
            {
                #region Guide Pages
                default:
                case PAGE.Price:
                    {
                        AddLabel(14, 81, 42, @"Please type a price:");
                        AddTextEntry(14, 102, 384, 20, 38, 0, @"30");
                        AddButton(w - 43, Button_Bot, 1154, 1155, 1001, GumpButtonType.Reply, 1001);
                        break;
                    }
                case PAGE.Date:
                    {
                        AddLabel(14, 81, 42, @"Expiration time from now:");

                        AddLabel(14, 102, 42, @"Days");
                        AddTextEntry(14, 118, 100, 20, 38, 0, @"0");

                        AddLabel(114, 102, 42, @"Hours");
                        AddTextEntry(114, 118, 100, 20, 38, 1, @"5");

                        AddLabel(214, 102, 42, @"Minutes");
                        AddTextEntry(214, 118, 100, 20, 38, 2, @"30");

                        AddButton(w - 43, Button_Bot, 1154, 1155, 1002, GumpButtonType.Reply, 1002);
                        break;
                    }
                case PAGE.TicketLimit:
                    {
                        AddLabel(14, 81, 42, @"Please type a ticket purchase limit:");
                        AddTextEntry(14, 102, 384, 20, 38, 0, @"50");
                        AddButton(w - 43, Button_Bot, 1154, 1155, 1003, GumpButtonType.Reply, 1003);
                        break;
                    }
                #endregion
                #region Norm Pages
                case PAGE.Props:
                    {

                        AddLabel(14, 20, 42, @"RevRaffle");
                        #region Checks
                        if (REVR.Price < 1)
                        {
                            SendGump(from, PAGE.Price, REVR);
                            return;
                        }
                        if (REVR.Expiration == null)
                        {
                            SendGump(from, PAGE.Date, REVR);
                            return;
                        }
                        if (REVR.Prize == null)
                        {
                            from.SendMessage(38, "Please select an item.");
                            from.Target = new RevTarget(REVR);
                            return;
                        }
                        #endregion
                        AddItem(ItemLoc, 20, REVR.Prize.ItemID, REVR.Prize.Hue);

                        AddLabel(14, 50, SETTINGS.LabelHue, @"Item:");
                        AddLabel(44, 50, SETTINGS.ValueHue, @REVR.Prize_Name);

                        AddLabel(14, 70, SETTINGS.LabelHue, @"Price:");
                        AddLabel(48, 70, SETTINGS.ValueHue, @REVR.Price.ToString());

                        AddLabel(14, 90, SETTINGS.LabelHue, @"Expiration:");
                        AddLabel(74, 90, SETTINGS.ValueHue, @REVR.Date_String);

                        AddLabel(14, 110, SETTINGS.LabelHue, @"Time Left:");
                        AddLabel(78, 110, SETTINGS.ValueHue, @REVR.Full_Time_Left);

                        AddButton(250, Button_Bot, 2445, 2445, 5001, GumpButtonType.Reply, 5001);
                        AddLabel(250 + 30, Button_Bot, 42, "Set Price");

                        AddButton(130, Button_Bot, 2445, 2445, 5002, GumpButtonType.Reply, 5002);
                        AddLabel(130 + 30, Button_Bot, 42, "Set Date");

                        AddButton(10, Button_Bot, 2445, 2445, 2003, GumpButtonType.Reply, 2003);
                        AddLabel(10 + 30, Button_Bot, 42, "Set Item");

                        AddButton(10, Button_2, 2445, 2445, 2004, GumpButtonType.Reply, 2004);
                        AddLabel(13, Button_2 + 1, 42, "View Buy Screen");

                        AddButton(130, Button_2, 2445, 2445, 5003, GumpButtonType.Reply, 5003);
                        AddLabel(130 + 20, Button_2, 42, "End Early");

                        AddButton(250, Button_2, 2445, 2445, 5004, GumpButtonType.Reply, 5004);
                        AddLabel(250 + 20, Button_2, 42, "Ticket Lim.");
                        break;
                    }
                case PAGE.PlayerScreen:
                    {
                        AddLabel(14, 20, 42, @"RevRaffle");
                        #region Checks
                        if (REVR.Price < 1)
                        {
                            return;
                        }
                        if (REVR.Expiration == null)
                        {
                            return;
                        }
                        if (REVR.Prize == null)
                        {
                            return;
                        }
                        #endregion
                        AddItem(ItemLoc, 20, REVR.Prize.ItemID, REVR.Prize.Hue);

                        AddLabel(14, 50, SETTINGS.LabelHue, @"Item:");
                        AddLabel(44, 50, SETTINGS.ValueHue, @REVR.Prize_Name);

                        AddLabel(14, 70, SETTINGS.LabelHue, @"Price:");
                        AddLabel(48, 70, SETTINGS.ValueHue, @REVR.Price.ToString());

                        AddLabel(14, 90, SETTINGS.LabelHue, @"Expiration:");
                        AddLabel(74, 90, SETTINGS.ValueHue, @REVR.Date_String);

                        AddLabel(14, 110, SETTINGS.LabelHue, @"Time Left:");
                        AddLabel(78, 110, SETTINGS.ValueHue, @REVR.Full_Time_Left);

                        AddLabel(14, 130, SETTINGS.LabelHue, @"Your tickets:");
                        AddLabel(93, 130, SETTINGS.ValueHue, @Contestant.GetTickets(REVR.NewContestants, from).ToString());

                        AddLabel(14, Button_Bot, 42, "Tickets:");
                        AddTextEntry(60, Button_Bot, 50, 20, 38, 0, "1");
                        AddButton(111, Button_Bot, 2445, 2445, 4001, GumpButtonType.Reply, 4001);
                        AddLabel(111 + 20, Button_Bot, 42, "Buy Tickets");
                        break;
                    }
                #endregion
                #region Edit Pages
                case PAGE.EditPrice:
                    {
                        AddLabel(14, 81, 42, @"Please type a price:");
                        AddTextEntry(14, 102, 384, 20, 38, 0, @"30");
                        AddButton(w - 43, Button_Bot, 1154, 1155, 2001, GumpButtonType.Reply, 2001);
                        break;
                    }
                case PAGE.EditDate:
                    {
                        AddLabel(14, 81, 42, @"Expiration time from now:");

                        AddLabel(14, 102, 42, @"Days");
                        AddTextEntry(14, 118, 100, 20, 38, 0, @"0");

                        AddLabel(114, 102, 42, @"Hours");
                        AddTextEntry(114, 118, 100, 20, 38, 1, @"5");

                        AddLabel(214, 102, 42, @"Minutes");
                        AddTextEntry(214, 118, 100, 20, 38, 2, @"30");

                        AddButton(w - 43, Button_Bot, 1154, 1155, 2002, GumpButtonType.Reply, 2002);
                        break;
                    }
                case PAGE.EditTicketLimit:
                    {
                        AddLabel(14, 81, 42, @"Please type a ticket limit:");
                        AddTextEntry(14, 102, 384, 20, 38, 0, @"50");
                        AddButton(w - 43, Button_Bot, 1154, 1155, 2005, GumpButtonType.Reply, 2005);
                        break;
                    }
                #endregion
            }
        }

        public static void SendGump(Mobile from, PAGE page, RevRaffle REVR)
        {
            if (from.HasGump(typeof(RevGuide)))
                from.CloseGump(typeof(RevGuide));
            from.SendGump(new RevGuide(from, REVR, page));
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            Mobile from = sender.Mobile;

            switch (info.ButtonID)
            {
                case 0:
                    {
                        break;
                    }
                #region Guide Pages
                case 1001:
                    {
                        string text = info.TextEntries[0].Text;
                        int PR = Convert.ToInt32(text);
                        if (REVR != null)
                        {
                            REVR.Price = PR;
                            from.SendMessage("Price set..");
                        }
                        SendGump(from, PAGE.TicketLimit, REVR);
                        break;
                    }
                case 1002:
                    {
                        string days = info.TextEntries[0].Text;
                        string hours = info.TextEntries[1].Text;
                        string minutes = info.TextEntries[2].Text;

                        int d, h, m;
                        try
                        {
                            d = Convert.ToInt32(days);
                            h = Convert.ToInt32(hours);
                            m = Convert.ToInt32(minutes);
                        }
                        catch
                        {
                            from.SendMessage(38, "You did not enter a valid number, please try again. Numbers must be actual numbers, no letters or characters will work.");
                            SendGump(from, PAGE.Date, REVR);
                            return;
                        }

                        DateTime dt = DateTime.UtcNow;
                        dt = dt.AddDays(d);
                        dt = dt.AddHours(h);
                        dt = dt.AddMinutes(m);

                        REVR.Expiration = dt;
                        from.SendMessage("Expiration: " + REVR.Date_String);
                        from.SendMessage(38, "Please select an item.");
                        from.Target = new RevTarget(REVR);
                        break;
                    }
                case 1003:
                    {
                        string text = info.TextEntries[0].Text;
                        int PR = Convert.ToInt32(text);
                        if (REVR != null)
                        {
                            REVR.TicketLimit = PR;
                            from.SendMessage("Ticket limit set..");
                        }
                        SendGump(from, PAGE.Date, REVR);
                        break;
                    }
                #endregion
                #region Edit Pages
                case 2001:
                    {
                        string text = info.TextEntries[0].Text;
                        int PR = Convert.ToInt32(text);
                        if (REVR != null)
                        {
                            REVR.Price = PR;
                            from.SendMessage("Price set..");
                        }
                        SendGump(from, PAGE.Props, REVR);
                        break;
                    }
                case 2002:
                    {
                        string days = info.TextEntries[0].Text;
                        string hours = info.TextEntries[1].Text;
                        string minutes = info.TextEntries[2].Text;
                        int d, h, m;
                        try
                        {
                            d = Convert.ToInt32(days);
                            h = Convert.ToInt32(hours);
                            m = Convert.ToInt32(minutes);
                        }
                        catch
                        {
                            from.SendMessage(38, "You did not enter a valid number, please try again. Numbers must be actual numbers, no letters or characters will work.");
                            SendGump(from, PAGE.EditDate, REVR);
                            return;
                        }

                        DateTime dt = DateTime.UtcNow;
                        dt = dt.AddDays(d);
                        dt = dt.AddHours(h);
                        dt = dt.AddMinutes(m);

                        REVR.Expiration = dt;
                        from.SendMessage("Expiration: " + REVR.Date_String);
                        SendGump(from, PAGE.Props, REVR);
                        break;
                    }
                case 2003:
                    {
                        from.SendMessage(38, "Please select an item.");
                        from.Target = new RevTarget(REVR);
                        break;
                    }
                case 2004:
                    {
                        SendGump(from, PAGE.PlayerScreen, REVR);
                        break;
                    }
                case 2005:
                    {
                        string text = info.TextEntries[0].Text;
                        int PR = Convert.ToInt32(text);
                        if (REVR != null)
                        {
                            REVR.TicketLimit = PR;
                            from.SendMessage("Ticket Limit set..");
                        }
                        SendGump(from, PAGE.Props, REVR);
                        break;
                    }
                #endregion
                #region Player Pages
                case 4001:
                    {
                        string text = info.TextEntries[0].Text;
                        int AMT, Tickets = Contestant.GetTickets(REVR.NewContestants, from);
                        try { AMT = Convert.ToInt32(text); }
                        catch { AMT = 1; }

                        if (AMT > 0)
                        {
                            if (Tickets >= REVR.TicketLimit)
                            {
                                from.SendMessage(SETTINGS.LabelHue, SETTINGS.Limit);
                                break;
                            }

                            if (Tickets + AMT > REVR.TicketLimit)
                            {
                                AMT = REVR.TicketLimit - Tickets;
                            }


                            int Cost = AMT * REVR.Price;
                            if (from.Backpack.ConsumeTotal(typeof(Gold), Cost) || from.BankBox.ConsumeTotal(typeof(Gold), Cost))
                            {
                                bool CU = false;
                                foreach (Contestant c in REVR.NewContestants)
                                    if (from == c.Player)
                                    {
                                        c.Tickets += AMT;
                                        CU = true;
                                        break;
                                    }

                                if(!CU)REVR.NewContestants.Add(new Contestant(from, AMT));

                                from.SendMessage(SETTINGS.LabelHue, string.Format(SETTINGS.Purchase, AMT.ToString()));
                                REVR.InvalidateProperties();
                            }
                            else
                            {
                                from.SendMessage(SETTINGS.LabelHue, string.Format(SETTINGS.Not_Enough_Gold, Cost.ToString(), AMT.ToString()));
                            }
                        }
                        break;
                    }
                case 4002:
                    {
                        SendGump(from, PAGE.PlayerScreen, REVR);
                        break;
                    }
                #endregion
                #region EditSend
                case 5001:
                    {
                        SendGump(from, PAGE.EditPrice, REVR);
                        break;
                    }
                case 5002:
                    {
                        SendGump(from, PAGE.EditDate, REVR);
                        break;
                    }
                case 5003:
                    {
                        REVR.Expiration = DateTime.UtcNow.Subtract(TimeSpan.FromDays(1));
                        REVR.Expire();
                        break;
                    }
                case 5004:
                    {
                        SendGump(from, PAGE.EditTicketLimit, REVR);
                        break;
                    }
                #endregion
            }
        }
    }

    public class Contestant
    {
        private Mobile m_Player;
        private int m_Tickets;

        public Mobile Player { get { return m_Player; } set { m_Player = value; } }
        public int Tickets { get { return m_Tickets; } set { m_Tickets = value; } }

        public Contestant(Mobile who, int tickets)
        {
            m_Player = who;
            m_Tickets = tickets;
        }

        public static List<Mobile> Return_Contestant_List(List<Contestant> Con)
        {
            List<Mobile> cons = new List<Mobile>();
            foreach (Contestant c in Con)
            {
                for (int i = 0; i > c.Tickets; i++)
                    cons.Add(c.m_Player);
            }
            return cons;
        }

        public static int GetTickets(List<Contestant> Con, Mobile For)
        {
            foreach (Contestant c in Con)
            {
                if (c.Player == For)
                    return c.Tickets;
            }
            return 0;
        }

        public static int TotalTickets(List<Contestant> Con)
        {
            int i = 0;
            foreach (Contestant c in Con)
                i += c.m_Tickets;
            return i;
        }

    }
}