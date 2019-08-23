/* Created by Hammerhand & Milva */

using System;
using Server.Items;
using Server.Targeting;
using Server.Network;
using Server.Engines.Harvest;

namespace Server.Items
{

    public class GoldPan : BaseHarvestTool, IUsesRemaining
    {
        public override HarvestSystem HarvestSystem { get { return GoldPanning.System; } }

        [Constructable]
        public GoldPan(): this(50)
        {
            Name = "a Gold Pan";
        }
        [Constructable]
        public GoldPan(int uses): base(uses, 0x9D7)
        {
            Name = "a Gold Pan";
            Weight = 2.0;
            Hue = 2401;
            Movable = true;
            UsesRemaining = uses;
            ShowUsesRemaining = true;
        }

        public GoldPan(Serial serial): base(serial)
        {
        }

        public override void OnSingleClick(Mobile from)
        {
            if (this.Name != null)
            {
                from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", this.Name));
            }
            else
            {
                from.Send(new AsciiMessage(Serial, ItemID, MessageType.Label, 0, 3, "", "a Gold Pan"));
            }
        }
		
		public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}