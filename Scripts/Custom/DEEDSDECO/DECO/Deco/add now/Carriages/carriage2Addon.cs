
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class carriage2Addon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new carriage2AddonDeed();
			}
		}

		[ Constructable ]
		public carriage2Addon()
		{



			AddComplexComponent( (BaseAddon) this, 5836, 1, 1, 0, 2725, -1, "wagonwheel", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1993, 1, 1, 6, 2697, -1, "carriage", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1994, 0, 1, 6, 2697, -1, "carriage", 1);// 3
			AddComplexComponent( (BaseAddon) this, 5831, 1, -1, 0, 2725, -1, "carriage", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1995, 0, 0, 6, 2697, -1, "carriage", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1995, 1, 0, 6, 2697, -1, "carriage", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1994, 1, -1, 6, 2697, -1, "carriage", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1994, 0, -1, 6, 2697, -1, "carriage", 1);// 8
			AddComplexComponent( (BaseAddon) this, 5836, -1, 1, 0, 2725, -1, "wagonwheel", 1);// 9
			AddComplexComponent( (BaseAddon) this, 5831, -1, -1, 0, 2725, -1, "carriage", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1993, -1, -1, 6, 2697, -1, "carriage", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1994, -1, 0, 6, 2697, -1, "carriage", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1995, -1, 1, 6, 2697, -1, "carriage", 1);// 13
			AddComplexComponent( (BaseAddon) this, 448, -1, -2, 7, 2697, -1, "carriage", 1);// 14
			AddComplexComponent( (BaseAddon) this, 448, 1, 1, 7, 2697, -1, "carriage", 1);// 15
			AddComplexComponent( (BaseAddon) this, 448, -1, 1, 7, 2697, -1, "carriage", 1);// 16
			AddComplexComponent( (BaseAddon) this, 441, -2, -2, 7, 2697, -1, "carriage", 1);// 17
			AddComplexComponent( (BaseAddon) this, 441, 0, -2, 7, 2697, -1, "carriage", 1);// 18
			AddComplexComponent( (BaseAddon) this, 441, 0, 1, 7, 2697, -1, "carriage", 1);// 19
			AddComplexComponent( (BaseAddon) this, 442, -2, 1, 7, 2697, -1, "carriage", 1);// 20
			AddComplexComponent( (BaseAddon) this, 442, -2, -1, 7, 2697, -1, "carriage", 1);// 21
			AddComplexComponent( (BaseAddon) this, 442, -2, 0, 7, 2697, -1, "carriage", 1);// 22
			AddComplexComponent( (BaseAddon) this, 453, 1, 0, 7, 2697, 0, "carriage", 1);// 23
			AddComplexComponent( (BaseAddon) this, 442, 1, -1, 7, 2697, -1, "carriage", 1);// 24
			AddComplexComponent( (BaseAddon) this, 2963, -1, 0, 8, 2725, -1, "carriage", 1);// 25
			AddComplexComponent( (BaseAddon) this, 2964, -1, -1, 8, 2725, -1, "carriage", 1);// 26
			AddComplexComponent( (BaseAddon) this, 1993, 0, 1, 27, 2697, -1, "carriage", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1993, -1, 1, 27, 2697, -1, "carriage", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1994, 1, 0, 27, 2697, -1, "carriage", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1995, -1, 0, 27, 2697, -1, "carriage", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1995, 1, 1, 27, 2697, -1, "carriage", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1994, 0, 0, 27, 2697, -1, "carriage", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1995, -1, -1, 27, 2697, -1, "carriage", 1);// 33
			AddComplexComponent( (BaseAddon) this, 456, 0, 1, 7, 2697, -1, "carriage", 1);// 34
			AddComplexComponent( (BaseAddon) this, 456, 0, 1, 10, 2697, -1, "carriage", 1);// 35
			AddComplexComponent( (BaseAddon) this, 456, 0, 1, 13, 2697, -1, "carriage", 1);// 36
			AddComplexComponent( (BaseAddon) this, 456, 0, -2, 7, 2697, -1, "carriage", 1);// 37
			AddComplexComponent( (BaseAddon) this, 456, 0, -2, 10, 2697, -1, "carriage", 1);// 38
			AddComplexComponent( (BaseAddon) this, 456, 0, -2, 13, 2697, -1, "carriage", 1);// 39
			AddComplexComponent( (BaseAddon) this, 1994, 1, -1, 27, 2697, -1, "carriage", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1993, 0, -1, 27, 2697, -1, "carriage", 1);// 41
			AddComplexComponent( (BaseAddon) this, 2648, -1, 0, 28, 0, -1, "bedroll", 1);// 42
			AddComplexComponent( (BaseAddon) this, 2647, -1, 1, 28, 0, -1, "bedroll", 1);// 43
			AddComplexComponent( (BaseAddon) this, 2787, 1, 1, 7, 0, -1, "carriage", 1);// 44
			AddComplexComponent( (BaseAddon) this, 2788, -1, -1, 7, 0, -1, "carriage", 1);// 45
			AddComplexComponent( (BaseAddon) this, 2789, -1, 1, 7, 0, -1, "carriage", 1);// 46
			AddComplexComponent( (BaseAddon) this, 2790, 1, -1, 7, 0, -1, "carriage", 1);// 47
			AddComplexComponent( (BaseAddon) this, 2791, -1, 0, 7, 0, -1, "carriage", 1);// 48
			AddComplexComponent( (BaseAddon) this, 2792, 0, -1, 7, 0, -1, "carriage", 1);// 49
			AddComplexComponent( (BaseAddon) this, 2793, 1, 0, 7, 0, -1, "carriage", 1);// 50
			AddComplexComponent( (BaseAddon) this, 2794, 0, 1, 7, 0, -1, "carriage", 1);// 51
			AddComplexComponent( (BaseAddon) this, 2795, 0, 0, 7, 0, -1, "carriage", 1);// 52
			AddComplexComponent( (BaseAddon) this, 449, 1, 1, 7, 2697, -1, "carriage", 1);// 53
			AddComplexComponent( (BaseAddon) this, 448, 1, -2, 7, 2697, -1, "carriage", 1);// 54
			AddComplexComponent( (BaseAddon) this, 441, 1, 0, 7, 2697, -1, "carriage", 1);// 55
			AddComplexComponent( (BaseAddon) this, 2473, 1, -1, 28, 0, -1, "box", 1);// 56
			AddComplexComponent( (BaseAddon) this, 3647, 0, -1, 28, 0, -1, "box", 1);// 57
			AddComplexComponent( (BaseAddon) this, 456, -1, -2, 28, 2725, -1, "carriage", 1);// 58
			AddComplexComponent( (BaseAddon) this, 456, 0, -2, 28, 2725, -1, "carriage", 1);// 59
			AddComplexComponent( (BaseAddon) this, 456, 1, -2, 28, 2725, -1, "carriage", 1);// 60
			AddComplexComponent( (BaseAddon) this, 456, -1, 1, 28, 2725, -1, "carriage", 1);// 61
			AddComplexComponent( (BaseAddon) this, 456, 0, 1, 28, 2725, -1, "carriage", 1);// 62
			AddComplexComponent( (BaseAddon) this, 456, 1, 1, 28, 2725, -1, "carriage", 1);// 63
			AddComplexComponent( (BaseAddon) this, 457, -2, -1, 28, 2725, -1, "carriage", 1);// 64
			AddComplexComponent( (BaseAddon) this, 457, -2, 0, 28, 2725, -1, "carriage", 1);// 65
			AddComplexComponent( (BaseAddon) this, 457, -2, 1, 28, 2725, -1, "carriage", 1);// 66
			AddComplexComponent( (BaseAddon) this, 457, 1, -1, 28, 2725, -1, "carriage", 1);// 67
			AddComplexComponent( (BaseAddon) this, 457, 1, 0, 28, 2725, -1, "carriage", 1);// 68
			AddComplexComponent( (BaseAddon) this, 457, 1, 1, 28, 2725, -1, "carriage", 1);// 69
			AddComplexComponent( (BaseAddon) this, 459, -2, -2, 28, 2725, -1, "carriage", 1);// 70
			AddComplexComponent( (BaseAddon) this, 5511, -1, 2, 10, 0, -1, "carriage", 1);// 71
			AddComplexComponent( (BaseAddon) this, 5511, 1, 2, 10, 0, -1, "carriage", 1);// 72
			AddComplexComponent( (BaseAddon) this, 1993, 2, -1, 6, 2697, -1, "carriage", 1);// 73
			AddComplexComponent( (BaseAddon) this, 1995, 2, 1, 6, 2697, -1, "carriage", 1);// 74
			AddComplexComponent( (BaseAddon) this, 1996, 2, 0, 6, 2697, -1, "carriage", 1);// 75
			AddComplexComponent( (BaseAddon) this, 15872, 2, 0, 7, 2725, -1, "carriage", 1);// 76
			AddComplexComponent( (BaseAddon) this, 15872, 2, 1, 7, 2725, -1, "carriage", 1);// 77
			AddComplexComponent( (BaseAddon) this, 15872, 2, -1, 7, 2725, -1, "carriage", 1);// 78
			AddComplexComponent( (BaseAddon) this, 5662, 2, 1, 10, 0, -1, "carriage", 1);// 79
			AddComplexComponent( (BaseAddon) this, 10722, 2, 0, 0, 2725, -1, "hitch", 1);// 80
			AddComplexComponent( (BaseAddon) this, 10722, 2, -1, 0, 2725, -1, "hitch", 1);// 81
			AddComplexComponent( (BaseAddon) this, 10723, 2, 0, 0, 2725, -1, "hitch", 1);// 82
			AddComplexComponent( (BaseAddon) this, 10722, 3, -1, 0, 2725, -1, "hitch", 1);// 83
			AddComplexComponent( (BaseAddon) this, 10722, 3, 0, 0, 2725, -1, "hitch", 1);// 84
			AddComplexComponent( (BaseAddon) this, 5662, 2, -1, 10, 0, -1, "carriage", 1);// 85
			AddComplexComponent( (BaseAddon) this, 2581, 2, 2, 33, 0, 0, "", 1);// 86
			AddComplexComponent( (BaseAddon) this, 2581, 2, -1, 32, 0, 0, "", 1);// 87

		}

		public carriage2Addon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class carriage2AddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new carriage2Addon();
			}
		}

		[Constructable]
		public carriage2AddonDeed()
		{
			Name = "carriage2";
		}

		public carriage2AddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}