// THIS IS A SERVUO DONATOR ONLY SCRIPT.
// DO NOT SHARE OR REPOST IT ANYWHERE.
// THANK YOU

using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Mobiles;
using Server.Targeting;
using Server.Commands;

/***
===========
Commands:
[InstantTame <double>

Use the Command InstantTame to Instantly tame a mobile. 
Optional parameter allows you to also set the mobile's Minimum Tame Skill to whatever you desire.
Setting it to 0 will allow any player to easily control the mobile, even if they have 0 Taming/Lore [ however, having some of both skills would be best ]
===========
Item:
InstantTameDeed

You can choose to simply add the item and it will act like a base command above, Instantly Taming the mobile without any effect on the Minimum Taming Skill.
*Note: In order to allow the item to change the Minimum Taming Skill, you must first set it's property, AlterMinTame, to true.
===========
***/

namespace Server.Items
{

    public class InstantTameDeed : Item
    {
        public static void Initialize()
        {
            CommandSystem.Register("InstantTame", AccessLevel.GameMaster, new CommandEventHandler(InstantTame_OnCommand));
		}


        [Usage("InstantTame <value>")]
        [Description("Instantly tames pet with option to change it's Minimum Tame Skill for easier control")]
        public static void InstantTame_OnCommand(CommandEventArgs e)
        {
            e.Mobile.SendMessage("Target the animal or beast you wish to instantly tame.");
			if( e.Length != 1 )
			{
				e.Mobile.Target = new InstaTameTarget(false );
			}
			else
			{
				e.Mobile.Target = new InstaTameTarget(true, e.GetDouble(0));
			}
        }
		
		private bool _AlterMinTame;
		private double _NewMinTame;

		[CommandProperty(AccessLevel.GameMaster)]
		public bool AlterMinTame 
		{ 
			get
			{
				return _AlterMinTame;
			}
			set
			{
				_AlterMinTame = value;
			}
		}
		
		[CommandProperty(AccessLevel.GameMaster)]
		public double NewMinTame 
		{ 
			get
			{
				return _NewMinTame;
			}
			set
			{
				_NewMinTame = value;
			}
		}
		
        [Constructable]
        public InstantTameDeed ()
            : base(0x14F0)
        {
            Weight = 1.0;
            Name = "Instant Taming Deed";
            LootType = LootType.Blessed;
            Hue = 572;
			
			_AlterMinTame = false;
			_NewMinTame = 0.00;
        }
		
		public override void GetProperties(ObjectPropertyList list)
		{
			base.GetProperties(list);
			
			if( AlterMinTame )
			{
				list.Add( String.Format("Sets Min. Taming required to {0}", NewMinTame) );
			}
		}

        public InstantTameDeed(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version 
			
			writer.Write( (bool)_AlterMinTame);
			writer.Write( (double)_NewMinTame);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            LootType = LootType.Blessed;

            int version = reader.ReadInt();
			
			_AlterMinTame = reader.ReadBool();
			_NewMinTame = reader.ReadDouble();
        }

        public override bool DisplayLootType { get { return false; } }

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack)) // Make sure its in their pack 
            {
                from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it. 
            }
            else
            {
                from.SendMessage("Target the animal or beast you wish to instantly tame.");
				
				from.Target = new InstaTameTarget(AlterMinTame, NewMinTame, this);
			}
		}
    }

    public class InstaTameTarget : Target
    {
        private InstantTameDeed m_Deed;
        bool Obey { get; set; }
		private readonly double m_Value;

        public InstaTameTarget(bool obey, double value = 0.00, InstantTameDeed deed = null)
            : base(15, false, TargetFlags.None)
        {
            if (deed != null)
            {
                m_Deed = deed;
            }
			
            Obey = obey;
			
			if( Obey )
			{
				m_Value = value;
			}
        }

        protected override void OnTarget(Mobile from, object target)
        {
            if (target is BaseCreature)
            {
                BaseCreature t = (BaseCreature)target;

                if (t.ControlMaster != null)
                {
                    from.SendMessage("That pet belongs to someone else!");
                }
                else if (t.Tamable == false)
                {
                    from.SendMessage("That creature cannot be tamed!");
                }
                else
                {
                    t.Controlled = true;
                    t.ControlMaster = from;
                    from.SendMessage("You have instantly tamed your target.");

                    if (m_Deed != null)
                    {
                        m_Deed.Delete(); // Delete the deed 
                    }
                    if (Obey == true)
                    {
                        t.MinTameSkill = m_Value;
                    }
                }

            }
            else
            {
                from.SendMessage("That is not a valid target.");
            }
        }
    }


}
