
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
	public class CouchFireplaceRugNorthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {18149, 1, -2, 12}, {18644, -3, -2, 0}, {18058, 3, -2, 14}// 38	59	87	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new CouchFireplaceRugNorthAddonDeed();
			}
		}

		[ Constructable ]
		public CouchFireplaceRugNorthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 5692, -2, 2, 5, 2823, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1180, 2, -1, 0, 2823, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 5691, 1, 3, 5, 2823, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1801, -1, 3, 0, 2018, -1, "couch", 1);// 4
			AddComplexComponent( (BaseAddon) this, 1180, 1, 2, 0, 2823, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1180, 1, 1, 0, 2823, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1180, 2, -2, 0, 2823, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1180, 1, 0, 0, 2823, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1180, 0, 0, 0, 2823, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1180, 0, 1, 0, 2823, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 1180, 0, 2, 0, 2823, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1801, -2, 3, 0, 2018, -1, "couch", 1);// 12
			AddComplexComponent( (BaseAddon) this, 5691, 0, 3, 5, 2823, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1180, -3, 0, 0, 2823, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 7628, 0, 2, 0, 1845, -1, "cushion", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1180, -1, 1, 0, 2823, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1180, -2, -1, 0, 2823, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1180, -2, 2, 0, 2823, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1801, 0, 3, 0, 2018, -1, "couch", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1180, -3, 1, 0, 2823, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 10749, 2, -2, 2, 2018, 1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 5691, 2, 3, 5, 2823, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 1180, -1, 3, 0, 2823, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1180, -1, 2, 0, 2823, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1801, -2, 2, 0, 2018, -1, "couch", 1);// 25
			AddComplexComponent( (BaseAddon) this, 7626, 2, 2, 0, 1845, -1, "cushion", 1);// 26
			AddComplexComponent( (BaseAddon) this, 16437, 0, 1, 2, 2018, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1180, -3, 2, 0, 2823, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 16436, 1, 0, 2, 2018, -1, "", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1801, 2, 3, 0, 2018, -1, "couch", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1180, 2, 3, 0, 2823, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1180, 1, 3, 0, 2823, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 1180, 0, 3, 0, 2823, -1, "", 1);// 33
			AddComplexComponent( (BaseAddon) this, 7628, 1, 2, 0, 1845, -1, "cushion", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1180, 2, 2, 0, 2823, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 16435, 0, 0, 2, 2018, -1, "", 1);// 36
			AddComplexComponent( (BaseAddon) this, 18176, -1, -2, 2, 2018, -1, "FirePlace", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1180, 2, 1, 0, 2823, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 1180, -2, -2, 0, 2823, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 1180, -1, -2, 0, 2823, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 1180, 0, -2, 0, 2823, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 1180, 1, -2, 0, 2823, -1, "", 1);// 43
			AddComplexComponent( (BaseAddon) this, 10749, 1, -2, 2, 2018, 1, "", 1);// 44
			AddComplexComponent( (BaseAddon) this, 6572, 1, -2, 5, 0, 0, "", 1);// 45
			AddComplexComponent( (BaseAddon) this, 7628, -1, 2, 0, 1845, -1, "cushion", 1);// 46
			AddComplexComponent( (BaseAddon) this, 10749, 0, -2, 2, 2018, 1, "", 1);// 47
			AddComplexComponent( (BaseAddon) this, 1180, -3, -2, 0, 2823, -1, "", 1);// 48
			AddComplexComponent( (BaseAddon) this, 1180, -3, -1, 0, 2823, -1, "", 1);// 49
			AddComplexComponent( (BaseAddon) this, 1180, -2, 1, 0, 2823, -1, "", 1);// 50
			AddComplexComponent( (BaseAddon) this, 1180, -2, 0, 0, 2823, -1, "", 1);// 51
			AddComplexComponent( (BaseAddon) this, 1180, -2, 3, 0, 2823, -1, "", 1);// 52
			AddComplexComponent( (BaseAddon) this, 1180, -3, 3, 0, 2823, -1, "", 1);// 53
			AddComplexComponent( (BaseAddon) this, 18178, 1, -2, 11, 2018, -1, "mantle", 1);// 54
			AddComplexComponent( (BaseAddon) this, 19389, -1, -2, 11, 1157, -1, "Dice", 1);// 55
			AddComplexComponent( (BaseAddon) this, 19537, -2, 3, 5, 0, 0, "", 1);// 56
			AddComplexComponent( (BaseAddon) this, 1180, 1, -1, 0, 2823, -1, "", 1);// 57
			AddComplexComponent( (BaseAddon) this, 1180, -1, 0, 0, 2823, -1, "", 1);// 58
			AddComplexComponent( (BaseAddon) this, 1180, -1, -1, 0, 2823, -1, "", 1);// 60
			AddComplexComponent( (BaseAddon) this, 1180, 0, -1, 0, 2823, -1, "", 1);// 61
			AddComplexComponent( (BaseAddon) this, 16438, 1, 1, 2, 2018, -1, "", 1);// 62
			AddComplexComponent( (BaseAddon) this, 18178, 2, -2, 11, 2018, -1, "mantle", 1);// 63
			AddComplexComponent( (BaseAddon) this, 5691, -1, 3, 5, 2823, -1, "", 1);// 64
			AddComplexComponent( (BaseAddon) this, 1801, 1, 3, 0, 2018, -1, "couch", 1);// 65
			AddComplexComponent( (BaseAddon) this, 6572, 2, -2, 5, 0, 0, "", 1);// 66
			AddComplexComponent( (BaseAddon) this, 18178, 0, -2, 11, 2018, -1, "mantle", 1);// 67
			AddComplexComponent( (BaseAddon) this, 6572, 0, -2, 5, 0, 0, "", 1);// 68
			AddComplexComponent( (BaseAddon) this, 1180, 2, 0, 0, 2823, -1, "", 1);// 69
			AddComplexComponent( (BaseAddon) this, 5692, 3, 2, 5, 2823, -1, "", 1);// 70
			AddComplexComponent( (BaseAddon) this, 1180, 4, 3, 0, 2823, -1, "", 1);// 71
			AddComplexComponent( (BaseAddon) this, 1801, 3, 2, 0, 2018, -1, "couch", 1);// 72
			AddComplexComponent( (BaseAddon) this, 1180, 3, 0, 0, 2823, -1, "", 1);// 73
			AddComplexComponent( (BaseAddon) this, 1180, 3, 3, 0, 2823, -1, "", 1);// 74
			AddComplexComponent( (BaseAddon) this, 1180, 3, -1, 0, 2823, -1, "", 1);// 75
			AddComplexComponent( (BaseAddon) this, 1180, 4, -2, 0, 2823, -1, "", 1);// 76
			AddComplexComponent( (BaseAddon) this, 1180, 4, -1, 0, 2823, -1, "", 1);// 77
			AddComplexComponent( (BaseAddon) this, 1180, 4, 0, 0, 2823, -1, "", 1);// 78
			AddComplexComponent( (BaseAddon) this, 1180, 4, 1, 0, 2823, -1, "", 1);// 79
			AddComplexComponent( (BaseAddon) this, 1801, 3, 3, 0, 2018, -1, "couch", 1);// 80
			AddComplexComponent( (BaseAddon) this, 1180, 3, -2, 0, 2823, -1, "", 1);// 81
			AddComplexComponent( (BaseAddon) this, 1180, 3, 1, 0, 2823, -1, "", 1);// 82
			AddComplexComponent( (BaseAddon) this, 1180, 3, 2, 0, 2823, -1, "", 1);// 83
			AddComplexComponent( (BaseAddon) this, 19537, 3, 3, 5, 0, 0, "", 1);// 84
			AddComplexComponent( (BaseAddon) this, 1180, 4, 2, 0, 2823, -1, "", 1);// 85
			AddComplexComponent( (BaseAddon) this, 18176, 3, -2, 3, 2018, -1, "FirePlace", 1);// 86

		}

		public CouchFireplaceRugNorthAddon( Serial serial ) : base( serial )
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

	public class CouchFireplaceRugNorthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new CouchFireplaceRugNorthAddon();
			}
		}

		[Constructable]
		public CouchFireplaceRugNorthAddonDeed()
		{
			Name = "CouchFireplaceRugNorth";
		}

		public CouchFireplaceRugNorthAddonDeed( Serial serial ) : base( serial )
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