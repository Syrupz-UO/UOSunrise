
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
	public class FullPottySetupEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {9236, -1, 2, 2}// 20	
		};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new FullPottySetupEastAddonDeed();
			}
		}

		[ Constructable ]
		public FullPottySetupEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1300, -1, 0, 2, 1346, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1300, 0, 0, 2, 1346, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1801, 0, 0, 0, 1153, -1, "toilet", 1);// 3
			AddComplexComponent( (BaseAddon) this, 16453, -1, 0, 12, 1346, -1, "mirror", 1);// 4
			AddComplexComponent( (BaseAddon) this, 16902, 0, 0, 5, 1346, -1, "lid", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1300, -1, -1, 2, 1346, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 8, -2, -1, 2, 1888, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 1300, 0, -1, 2, 1346, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 19257, -1, 0, 4, 1153, -1, "tank", 1);// 9
			AddComplexComponent( (BaseAddon) this, 8, -2, 0, 2, 1888, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 8, -2, -2, 2, 1888, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1300, 1, -1, 2, 1346, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1300, 1, 0, 2, 1346, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 1300, 0, 1, 2, 1346, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 18406, -1, 1, 2, 1153, -1, "Tissue", 1);// 15
			AddComplexComponent( (BaseAddon) this, 8, -2, 2, 2, 1888, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 18908, 2, 1, 17, 1153, -1, "Flusher", 1);// 17
			AddComplexComponent( (BaseAddon) this, 7713, 1, 1, 2, 0, -1, "Readers Digest", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1300, -1, 1, 2, 1346, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1300, 1, 1, 2, 1346, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 8, -2, 1, 2, 1888, -1, "", 1);// 22

		}

		public FullPottySetupEastAddon( Serial serial ) : base( serial )
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

	public class FullPottySetupEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new FullPottySetupEastAddon();
			}
		}

		[Constructable]
		public FullPottySetupEastAddonDeed()
		{
			Name = "FullPottySetupEast";
		}

		public FullPottySetupEastAddonDeed( Serial serial ) : base( serial )
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