using System;
using System.Collections.Generic;
using System.Text;
using Server.Targeting;
using Server;
using Server.Items;
using Server.Gumps;

namespace Bittiez.RevRaffle
{
    public class RevTarget : Target
    {
        private RevRaffle REVR;
        public RevTarget(RevRaffle RF)
            : base(20, false, TargetFlags.None)
        {
            REVR = RF;
        }

        protected override void OnTarget(Mobile m, object targeted)
        {
            if (targeted == null)
                return;
            if (!(targeted is Item))
            {
                sm(m, "That is not a valid item.");
                return;
            }
            Item prize = targeted as Item;

            if (REVR == null || REVR.Bag == null)
            {
                Bittiez.Tools.ConsoleWrite(ConsoleColor.Red, "RevRaffle Error 1.");
                return;
            }

            REVR.Prize = prize;
            prize.Movable = false;

            #region Empty bag

            List<Item> i = REVR.Bag.AcquireItems();
            List<Item> d = new List<Item>();
            foreach (Item ii in i)
                d.Add(ii);
            foreach (Item ii in d)
                ii.Delete();
            #endregion
            REVR.Bag.AddItem(prize);
            Point3D loc = REVR.Location;
            loc.Z += 10;
            REVR.Bag.MoveToWorld(loc, REVR.Map);


            RevGuide.SendGump(m, RevGuide.PAGE.Props, REVR);
            sm(m, "Item set..");
            REVR.SETUP = true;
            REVR.InvalidateProperties();
            REVR.Expire();
        }

        private void sm(Mobile who, string message)
        {
            who.SendMessage(38, message);
        }
    }
}
