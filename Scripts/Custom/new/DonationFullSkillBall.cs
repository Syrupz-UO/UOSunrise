
using System;
using Server;
using Server.Network;
using Server.Mobiles;
using Server.Items;
using Server.Gumps;
using Server.Misc;

namespace Server.Items
{
   
   
   
   
    public class DonationFullSkillBall : Item
    {
		private int switches = 10;
			private DonationFullSkillBall m_SkillBall;
			private double val = 100;
 
 
		[Constructable]
        public DonationFullSkillBall():base(0xE73)
            
        {
			
            Weight = 1.0;
            Hue = 105;
            Name = "a skill ball";
            Movable = false;
            LootType = LootType.Blessed;
			ItemID=0xE73;
        }

        public override void OnDoubleClick(Mobile m)
        {

            if (m.Backpack != null && m.Backpack.GetAmount(typeof(DonationFullSkillBall)) > 0)
            {
               m.SendMessage("Thanks for supporting UOSunrise.");
               
							
                            Server.Skills skills = m.Skills;

                            for (int i = 0; i < skills.Length; ++i)
                                skills[i].Base = 100;
                            for (int i = 0; i < 55; ++i)
                            {
                               
                                    m.Skills[i].Base = val;
                            }

                          this.Delete();
            }
            else
                m.SendMessage(" You need to have the skill ball in your backpack.");

        }

        public DonationFullSkillBall(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)1); // version 
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

        }

    }
}