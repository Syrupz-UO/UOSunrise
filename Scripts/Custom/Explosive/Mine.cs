using System;
using System.Collections.Generic;
using System.Text;
using Server.Mobiles;

namespace Server.Items
{
    public class Mine : Item
    {
        private Point3D loc;
        private Map map;
        private Mobile who;

        [Constructable]
        public Mine() :this(1)
        {
        }

        [Constructable]
        public Mine(int m)
            : base( 0x07D5)
        {
            Name="Land Mine";
            Hue = 987;
            Movable = true;
            Stackable = true;
            Amount = m;
            Name = Amount > 1 ? "mines" : "mine";
        }
		
		public override void AddNameProperties( ObjectPropertyList list )
		{

			//AddNameProperty( list );
			list.Add("<BASEFONT COLOR=#FF9633>Land Mine</BASEFONT>\r\n");
			list.Add("USE: Places a land mine at your feet.");
			
			
		
		}

        public override void OnDoubleClick(Mobile from)
        {
            if (!IsChildOf(from.Backpack))
            {
                from.SendMessage("That must be in your pack!");
                return;
            }
            from.SendMessage("You begin to arm the mine..");
            from.CantWalk = true;
            loc = from.Location;
            map = from.Map;
            who = from;
            Bittiez.Tools.Start_Timer_Delayed_Call(TimeSpan.FromSeconds(4), ArmMine);
            Amount -= 1;
        }
        protected override void OnAmountChange(int oldValue)
        {
            if (Amount < 1)
                this.Delete();
            if (Amount > 1) Name = "mines"; else Name = "mine"; 
        }

        public void ArmMine()
        {
            if ((IPoint3D)loc == null || map == null || who == null)
                return;
            new GroundMine(loc, map, who);
            who.CantWalk = false;
			who.SendMessage("You have placed a mine!");

        }

        public Mine(Serial serial)
            : base(serial)
        { }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
        }
    }



    public class GroundMine : Item
    {
        private Mobile Owner;

        [Constructable]
        public GroundMine(Point3D Location, Map map, Mobile Creator)
            : base(0x0913)
        {
            Name = "a dirt pile";
            //Hue = 987;
            Movable = false;
            Owner = Creator;
            MoveToWorld(Location, map);
        }

        public override bool OnMoveOver(Mobile m)
        {
            if (m is BaseCreature || m is PlayerMobile)
            {
                m.FixedParticles(0x36BD, 20, 10, 5044, EffectLayer.Head);
                m.PlaySound(0x307);
                m.DoHarmful(m, true);
                m.Damage(Utility.Random(30, 75));
				if(m is PlayerMobile);
				{
                m.SendMessage(38, "You stepped on a mine!");
                }
				this.Delete();
            }
            return base.OnMoveOver(m);
        }

        public override bool Decays
        {
            get
            {
                return true;
            }
        }
        public override TimeSpan DecayTime
        {
            get
            {
                return TimeSpan.FromMinutes(30);
            }
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (from == Owner)
            {
                if (from.GetDistanceToSqrt(this.Location) > 3)
                {
                    from.SendMessage("You must be closer to disarm this mine");
                    return;
                }
                from.SendMessage("You start to disarm the mine...");
                from.CantWalk = true;
                Bittiez.Tools.Start_Timer_Delayed_Call(TimeSpan.FromSeconds(4), DisArm);
            }
        }

        public void DisArm()
        {
            this.Delete();
            if (Owner != null)
            {
                Owner.SendMessage("You have disarmed the mine!");
                Owner.CantWalk = false;
                Owner.AddToBackpack(new Mine());
            }
        }





        public GroundMine(Serial serial)
            : base(serial)
        { }

        public override void Serialize(GenericWriter writer)
        {
            writer.Write(0);

            writer.Write(Owner);

            base.Serialize(writer);
        }

        public override void Deserialize(GenericReader reader)
        {
            int v = reader.ReadInt();

            if (v >= 0)
                Owner = reader.ReadMobile();


            base.Deserialize(reader);
        }
    }
}
