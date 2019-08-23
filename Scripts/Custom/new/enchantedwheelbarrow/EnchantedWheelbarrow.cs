using Server;
using System;
using Server.Items;
using Server.Mobiles;
using Server.Engines.Plants;

namespace Server.Items
{
    [Flipable(41192, 41193)]
    public class EnchantedWheelbarrow : Item, IUsesRemaining
    {
        public override int LabelNumber { get { return 1125214; } } // enchanted wheelbarrow

        private int m_UsesRemaining;

        [CommandProperty(AccessLevel.GameMaster)]
        public int UsesRemaining
        {
            get { return m_UsesRemaining; }
            set { m_UsesRemaining = value; if (m_UsesRemaining <= 0) Delete(); else InvalidateProperties(); }
        }       

        public bool ShowUsesRemaining { get { return true; } set { } }

        [Constructable]
        public EnchantedWheelbarrow() : base(41192)
        {
            UsesRemaining = 10;
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (m_UsesRemaining > 0)
            {
                Item item = null;

                switch (Utility.Random(28))
                {
                    case 0: item = new WheelbarrowBullrushes(); break;
                    case 1: item = new WheelbarrowCactus(); break;
                    case 2: item = new WheelbarrowCampion(); break;
                    case 3: item = new WheelbarrowCampion2(); break;
                    case 4:
                        item = new WheelbarrowPottedPlantGrey();
                        if (0.10 > Utility.RandomDouble())
                            item = new WheelbarrowPottedPlantRed(); break;
                    case 5: item = new WheelbarrowCenturyPlant(); break;
                    case 6: item = new WheelbarrowFlax1Plant(); break;
                    case 7: item = new WheelbarrowFlax2Plant(); break;
                    case 8: item = new WheelbarrowFlax3Plant(); break;
                    case 9: item = new WheelbarrowFlowervine1(); break;
                    case 10: item = new WheelbarrowFlowervine2(); break;
                    case 11: item = new WheelbarrowFoxglove(); break;
                    case 12: item = new WheelbarrowLillies(); break;
                    case 13: item = new WheelbarrowLillies2(); break;
                    case 14: item = new WheelbarrowOrfluer(); break;
                    case 15: item = new WheelbarrowOrfuer(); break;
                    case 16: item = new WheelbarrowPampasgrass(); break;
                    case 17: item = new WheelbarrowPoppies(); break;
                    case 18: item = new WheelbarrowPoppies2(); break;
                    case 19: item = new WheelbarrowPoppies3(); break;
                    case 20: item = new WheelbarrowSnowdrop1(); break;
                    case 21: item = new WheelbarrowSnowdrop2(); break;
                    case 22: item = new WheelbarrowSnowdrop3(); break;
                    case 23: item = new WheelbarrowSpike(); break;
                    case 24: item = new WheelbarrowVanilla(); break;
                    case 25: item = new WheelbarrowVanilla2(); break;
                    case 26: item = new WheelbarrowWaterlillies(); break;
                    case 27: item = new WheelbarrowWaterlillies2(); break;
                    
                }

                if (item != null)
                {
                    if (from.Backpack == null || !from.Backpack.TryDropItem(from, item, false))
                        item.MoveToWorld(from.Location, from.Map);

                    UsesRemaining--;
                }
            }
        }
                
        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            if (ShowUsesRemaining)
                list.Add(1049116, m_UsesRemaining.ToString()); // [ Charges: ~1_CHARGES~ ]
        }

        public EnchantedWheelbarrow(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
            writer.Write(m_UsesRemaining);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int v = reader.ReadInt();
            m_UsesRemaining = reader.ReadInt();
        }
    }
}



