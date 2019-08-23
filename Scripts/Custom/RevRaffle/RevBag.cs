using System;
using System.Collections.Generic;
using System.Text;
using Server.Items;
using Server;

namespace Bittiez.RevRaffle
{
    public class RevBag : Bag
    {
        public RevBag(Serial serial) : base(serial) { }

        [Constructable]
        public RevBag() : base()
        {
            Name = "RevBag";
            Movable = false;
        }

        public override void Open(Mobile from)
        {
            this.DisplayTo(from);
        }
        public override bool OnDragDrop(Mobile from, Item dropped)
        {
            return false;
        }
        public override bool OnDragDropInto(Mobile from, Item item, Point3D p)
        {
            return false;
        }
        public override bool OnDragLift(Mobile from)
        {
            return false;
        }
        public override bool OnDroppedInto(Mobile from, Container target, Point3D p)
        {
            return false;
        }
        public override bool OnDroppedOnto(Mobile from, Item target)
        {
            return false;
        }

        public override bool Decays
        {
            get
            {
                return false;
            }
        }

        public override TimeSpan DecayTime
        {
            get
            {
                return TimeSpan.FromDays(365);
            }
        }


        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }
        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int v = reader.ReadInt();
        }

    }
}
