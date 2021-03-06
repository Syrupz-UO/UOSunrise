
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

namespace HElegantFlowers
{
	public class HElegantFlowersAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {3204, 0, 0, 8}, {3208, 0, 0, 8}// 1	7	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new HElegantFlowersAddonDeed();
			}
		}

		[ Constructable ]
		public HElegantFlowersAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2886, 0, 0, 5, 1082, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 3614, 1, 0, 11, 116, -1, "rose", 1);// 3
			AddComplexComponent( (BaseAddon) this, 3614, 0, 0, 11, 2081, -1, "Rose", 1);// 4
			AddComplexComponent( (BaseAddon) this, 5019, 0, 0, 3, 1082, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 4179, 1, 0, 11, 1675, -1, "Forget me not", 2);// 6
			AddComplexComponent( (BaseAddon) this, 4176, 1, 1, 21, 1281, -1, "flower", 1);// 8
			AddComplexComponent( (BaseAddon) this, 4180, 0, 1, 10, 1675, -1, "Forget me not", 2);// 9
			AddComplexComponent( (BaseAddon) this, 3195, 0, 1, 13, 2800, -1, "Peony", 1);// 10
			AddComplexComponent( (BaseAddon) this, 7107, 0, 0, 0, 1082, -1, "bottom", 1);// 11

		}

		public HElegantFlowersAddon( Serial serial ) : base( serial )
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

	public class HElegantFlowersAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new HElegantFlowersAddon();
			}
		}

		[Constructable]
		public HElegantFlowersAddonDeed()
		{
			Name = "HElegantFlowers";
		}

		public HElegantFlowersAddonDeed( Serial serial ) : base( serial )
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