using System;

namespace Server.Items
{
    [FlipableAttribute(0x4BAB, 0x4BAC)]
    public class BasketOfRolls : Item
    {
        int m_charges;

        [Constructable]
        public BasketOfRolls()
            : base(0x4BAB)
        {
            this.Name = "basket of rolls";
            this.Weight = 3.0;
            this.Stackable = false;
            this.m_charges = 13;
        }

        public BasketOfRolls(Serial serial)
            : base(serial)
        {
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (m_charges > 0)
            {
                from.AddToBackpack(new DinnerRoll());
                m_charges -= 1;
                this.InvalidateProperties();
                if (m_charges == 0)
                    this.Delete();
            }
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            list.Add(1060741, this.m_charges.ToString()); // charges: ~1_val~
        }

        public override void OnSingleClick(Mobile from)
        {
            base.OnSingleClick(from);

            this.LabelTo(from, 1060741, this.m_charges.ToString()); // charges: ~1_val~
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version

            writer.Write(m_charges);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            m_charges = reader.ReadInt();
        }
    }

    public class DinnerRoll : Food
    {
        [Constructable]
        public DinnerRoll()
            : base(1, 0x09EA)
        {
            this.Name = "dinner roll";
            this.Weight = 1.0;
            this.FillFactor = 1;
            this.Stackable = true;
        }

        public DinnerRoll(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

        }
    }
}