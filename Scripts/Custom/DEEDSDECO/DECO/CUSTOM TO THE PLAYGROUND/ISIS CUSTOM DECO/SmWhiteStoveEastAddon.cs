
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
	public class SmWhiteStoveEastAddon : BaseAddon
	{
         
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new SmWhiteStoveEastAddonDeed();
			}
		}

		[ Constructable ]
		public SmWhiteStoveEastAddon()
		{



			AddComplexComponent( (BaseAddon) this, 1801, 0, 0, 5, 1153, -1, "Stove", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1801, 0, 1, 5, 1153, -1, "Stove", 1);// 2
			AddComplexComponent( (BaseAddon) this, 5381, 0, 0, 11, 1, -1, "burner", 1);// 3
			AddComplexComponent( (BaseAddon) this, 5381, 0, 1, 11, 1, -1, "burner", 1);// 4
			AddComplexComponent( (BaseAddon) this, 9232, 1, 0, 0, 1150, -1, "oven", 1);// 5
			AddComplexComponent( (BaseAddon) this, 9232, 1, 1, 0, 1150, -1, "oven", 1);// 6
			AddComplexComponent( (BaseAddon) this, 272, -1, 1, 8, 1153, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 272, -1, 0, 8, 1153, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 6931, -1, 1, 11, 1, -1, "knobs", 1);// 9
			AddComplexComponent( (BaseAddon) this, 6931, 0, 1, 22, 1, -1, "knobs", 1);// 10
			AddComplexComponent( (BaseAddon) this, 3555, 0, 0, 11, 0, 0, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 3555, 0, 1, 12, 0, 0, "", 1);// 12

		}

		public SmWhiteStoveEastAddon( Serial serial ) : base( serial )
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

	public class SmWhiteStoveEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new SmWhiteStoveEastAddon();
			}
		}

		[Constructable]
		public SmWhiteStoveEastAddonDeed()
		{
			Name = "SmWhiteStoveEast";
		}

		public SmWhiteStoveEastAddonDeed( Serial serial ) : base( serial )
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