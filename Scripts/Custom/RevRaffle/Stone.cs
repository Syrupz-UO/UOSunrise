using System;
using System.Collections.Generic;
using System.Text;
using Server;
using System.Collections;
using Server.Gumps;

namespace Bittiez.RevRaffle
{
    public class RevRaffle : Item
    {
        #region Stuff
        public static int Version = 12;
        private int m_Price = 0, m_TicketLimit;
        private Item m_Prize;
        private ArrayList m_Contestants = new ArrayList();
        private List<Contestant> m_NewContestants = new List<Contestant>();
        private DateTime m_Expiration;
        private bool SetUP = false;
        private RevBag m_Bag = new RevBag();

        public bool SETUP { get { return SetUP; } set { SetUP = value; } }
        public RevBag Bag { get { return m_Bag; } set { m_Bag = value; } }
        public int Price { get { return m_Price; } set { m_Price = value; } }
        public int TicketLimit { get { return m_TicketLimit; } set { m_TicketLimit = value; } }
        public Item Prize { get { return m_Prize; } set { m_Prize = value; } }
        public ArrayList Contestants { get { return m_Contestants; } set { m_Contestants = value; } }
        public List<Contestant> NewContestants { get { return m_NewContestants; } set { m_NewContestants = value; } }
        public DateTime Expiration { get { return m_Expiration; } set { m_Expiration = value; } }
        public string Date_String { get { return Expiration.ToShortDateString() + " " + Expiration.ToShortTimeString(); } }
        public string Prize_Name
        {
            get
            {
                string t;
                if (Prize != null)
                {
                    if (Prize.Name != null)
                    {
                        t = Prize.Name.Trim();
                        if (t.Length > 0)
                            return t;
                    }
                    return Prize.GetType().Name;
                }
                return "";

            }
        }
        public TimeSpan TimeLeft
        {
            get
            {
                DateTime Now = DateTime.Now;
                if (Expiration == null)
                    return TimeSpan.FromMilliseconds(6);
                if (Expiration > Now)
                {
                    TimeSpan TL = Expiration - Now;
                    return TL;
                }
                return TimeSpan.FromMilliseconds(0);
            }
        }
        public string Time_Left_String
        {
            get
            {
                if (TimeLeft.TotalDays > 1)
                    return string.Format("{0} Days", Math.Round(TimeLeft.TotalDays, 0));
                if (TimeLeft.TotalHours > 1)
                    return string.Format("{0} Hours", Math.Round(TimeLeft.TotalHours, 0));



                return string.Format("Less than 1 hour");
            }
        }
        public string Full_Time_Left
        {
            get
            {
                return string.Format(TimeLeft.Days.ToString() + ":{0}:{1}:{2}", TimeLeft.Hours.ToString(), TimeLeft.Minutes.ToString(), TimeLeft.Seconds.ToString());
            }
        }
        #endregion
        public static void Initialize()
        {
            Type t = ScriptCompiler.FindTypeByFullName("Bittiez.Tools");
            if (t == null)
            {
                Console.WriteLine("Bittiez Utilities is required for RevRaffle!");
                throw new Exception("Bittiez Utilities is required for RevRaffle!");
            }
            else
            {
                Bittiez.Tools.ConsoleWrite(ConsoleColor.Blue, "RevRaffle Version " + Bittiez.Tools.Format_Version(Version));
            }
        }

        [Constructable]
        public RevRaffle()
            : base(0xED4)
        {
            Movable = false;
            Hue = 0x476;
            Name = "RevRaffle";
        }
        public RevRaffle(Serial serial) : base(serial) { }

        public override void OnDoubleClick(Mobile from)
        {
            if (!SetUP && from.AccessLevel >= SETTINGS.Set_Up_AccessLevel)
            {
                if (from.HasGump(typeof(RevGuide)))
                    from.CloseGump(typeof(RevGuide));
                from.SendGump(new RevGuide(from, this, RevGuide.PAGE.Price));
                return;
            }
            if (SetUP && from.AccessLevel >= SETTINGS.Set_Up_AccessLevel)
            {
                RevGuide.SendGump(from, RevGuide.PAGE.Props, this);
                return;
            }
            if (SetUP)
            {
                RevGuide.SendGump(from, RevGuide.PAGE.PlayerScreen, this);
                return;
            }

            base.OnDoubleClick(from);
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);
            try
            {
                if (SetUP)
                {
                    string Stats = "";
                    Stats += "<BASEFONT COLOR=#FFFFFF>Expiration: <BASEFONT COLOR=#1DF0101>" + Date_String + "<br>";
                    Stats += "<BASEFONT COLOR=#FFFFFF>Price: <BASEFONT COLOR=#1DF0101>" + Price.ToString() + "<br>";
                    Stats += "<BASEFONT COLOR=#FFFFFF>Item: <BASEFONT COLOR=#1DF0101>" + Prize_Name + "<br>";
                    Stats += "<BASEFONT COLOR=#FFFFFF>Tickets Purchased: <BASEFONT COLOR=#1DF0101>" + Contestant.TotalTickets(NewContestants) + "<br>";
                    Stats += "<BASEFONT COLOR=#FFFFFF>Time Left: <BASEFONT COLOR=#1DF0101>" + Time_Left_String;
                    Stats += "<BASEFONT COLOR=#FFFFFF>";
                    list.Add(Stats);
                }


            }
            catch (Exception e) { Bittiez.Tools.ConsoleWrite(ConsoleColor.Red, "RevRaffle error 2. [" + e.Message + "]"); }
        }

        public void Expire()
        {
            if (SetUP)
                if (TimeLeft.TotalMilliseconds < 5)
                {
                    List<Mobile> Const = Contestant.Return_Contestant_List(m_NewContestants);
                    if (Const.Count > 0)
                    {
                        int r = Utility.Random(Const.Count);
                        Mobile Winner = (Mobile)Const[r];
                        int I = 0;
                        while (Winner == null && I < Const.Count)
                        {
                            r = Utility.Random(Const.Count);
                            Winner = (Mobile)Const[r];
                            I++;
                        }

                        if (Winner != null)
                        {
                            List<Mobile> Players = Bittiez.Tools.List_Connected_Players();
                            foreach (Mobile m in Players)
                            {
                                if (m.HasGump(typeof(RevGuide)))
                                    m.CloseGump(typeof(RevGuide));
                                m.SendMessage(38, "The Raffle for a " + Prize_Name + " has ended, the winner was " + Winner.RawName + "!");
                            }
                            Prize.Movable = true;
                            Winner.AddToBackpack(Prize);
                        }
                    }
                    reset();
                }
                else
                {
                    Bittiez.Tools.Start_Timer_Delayed_Call(TimeSpan.FromMinutes(5), Expire);
                }
        }

        public void reset()
        {
            List<Item> IB = Bittiez.Tools.List_Items_In_Container(m_Bag, true);
            foreach (Item i in IB)
                i.Delete();
            m_Bag.Delete();
            m_Price = 0;
            m_Prize = null;
            m_Contestants = new ArrayList();
            m_NewContestants = new List<Contestant>();
            m_Expiration = DateTime.Now;
            SetUP = false;
            m_Bag = new RevBag();
            InvalidateProperties();
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(3);
            //v 2
            m_Contestants = new ArrayList();
            foreach (Contestant c in m_NewContestants)
            {
                for (int i = 0; i < c.Tickets; i++)
                    m_Contestants.Add(c.Player);
            }

            //v 1
            writer.Write(m_Price);
            writer.Write(m_Prize);
            writer.Write(m_Bag);
            writer.Write(m_Expiration);
            writer.WriteMobileList(m_Contestants);
            writer.Write(SetUP);

            //v 3
            writer.Write(TicketLimit);

        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int v = reader.ReadInt();

            if (v >= 1)
            {
                m_Price = reader.ReadInt();
                m_Prize = reader.ReadItem();
                m_Bag = (RevBag)reader.ReadItem();
                m_Expiration = reader.ReadDateTime();
                m_Contestants = reader.ReadMobileList();
                SetUP = reader.ReadBool();
            }
            if (v >= 2)
            {
                bool CU;
                foreach (Mobile m in m_Contestants)
                {
                    CU = false;
                    foreach (Contestant c in NewContestants)
                        if (m == c.Player)
                        {
                            c.Tickets += 1;
                            CU = true;
                            break;
                        }

                    if (!CU) NewContestants.Add(new Contestant(m, 1));
                }
            }
            if (v >= 3)
            {
                TicketLimit = reader.ReadInt();
            }

            Bittiez.Tools.Start_Timer_Delayed_Call(TimeSpan.FromMinutes(5), Expire);
        }
    }
}
