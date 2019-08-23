
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
	public class TSKBathTubEastAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4241, -1, 1, 5}, {13422, 0, 0, 7}, {13422, 0, -1, 7}// 16	18	19	
			, {13422, 0, -2, 7}, {13422, -1, -2, 7}, {13422, -1, -1, 7}// 20	24	25	
			, {13422, -1, 0, 7}, {16454, -2, 3, 3}, {3332, 2, -1, 11}// 26	29	41	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TSKBathTubEastAddonDeed();
			}
		}

		[ Constructable ]
		public TSKBathTubEastAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 1900, 1, 0, 3, 1153, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1900, 1, -1, 3, 1153, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1900, 1, 1, 3, 1153, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1900, 1, -2, 3, 1153, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 4845, 1, -3, 0, 1166, -1, "", 1);// 5
			AddComplexComponent( (BaseAddon) this, 1902, 2, 0, 3, 1153, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 1900, 1, -3, 3, 1153, -1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 5646, 2, -3, 1, 1166, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1900, 2, -1, 3, 1153, -1, "", 1);// 9
			AddComplexComponent( (BaseAddon) this, 1910, 2, 1, 3, 1153, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 6420, 1, -2, 8, 1166, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1902, 2, -2, 3, 1153, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 1912, 2, -3, 3, 1153, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 5646, -2, -3, 1, 1166, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 5645, -2, -3, 1, 1166, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1900, 0, 1, 3, 1153, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1900, 0, -3, 3, 1153, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 4976, -1, -3, 8, 0, -1, "Scrubber", 1);// 22
			AddComplexComponent( (BaseAddon) this, 1900, -1, -3, 3, 1153, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 19461, -1, 1, 8, 0, -1, "BathSalts", 1);// 27
			AddComplexComponent( (BaseAddon) this, 1900, -1, 1, 3, 1153, -1, "", 1);// 28
			AddComplexComponent( (BaseAddon) this, 1900, -2, 1, 3, 1153, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1900, -2, 0, 3, 1153, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 1900, -2, -1, 3, 1153, -1, "", 1);// 32
			AddComplexComponent( (BaseAddon) this, 6196, -1, -1, 8, 0, -1, "Faucet", 1);// 33
			AddComplexComponent( (BaseAddon) this, 1900, -2, -2, 3, 1153, -1, "", 1);// 34
			AddComplexComponent( (BaseAddon) this, 1900, -2, -3, 3, 1153, -1, "", 1);// 35
			AddComplexComponent( (BaseAddon) this, 3837, -2, -2, 8, 0, -1, "Conditioner", 1);// 36
			AddComplexComponent( (BaseAddon) this, 3835, -2, -3, 8, 0, -1, "Shampoo", 1);// 37
			AddComplexComponent( (BaseAddon) this, 4834, -2, 0, 0, 1166, -1, "", 1);// 38
			AddComplexComponent( (BaseAddon) this, 6211, -2, 1, 8, 0, -1, "BubbleBath", 1);// 39
			AddComplexComponent( (BaseAddon) this, 5645, -2, 1, 1, 1166, -1, "", 1);// 40
			AddComplexComponent( (BaseAddon) this, 4551, 2, -1, 8, 1150, -1, "", 1);// 42
			AddComplexComponent( (BaseAddon) this, 7870, 2, -1, 15, 41, -1, "Columbine", 1);// 43

		}

		public TSKBathTubEastAddon( Serial serial ) : base( serial )
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

	public class TSKBathTubEastAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TSKBathTubEastAddon();
			}
		}

		[Constructable]
		public TSKBathTubEastAddonDeed()
		{
			Name = "TSKBathTubEast";
		}

		public TSKBathTubEastAddonDeed( Serial serial ) : base( serial )
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