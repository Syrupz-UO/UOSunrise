
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
	public class TSKBathRoomSouthAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {16442, 3, -2, 4}, {13422, -1, -1, 8}, {13422, -1, 0, 8}// 9	26	32	
			, {4239, 2, 0, 6}, {13422, -2, -1, 8}, {13422, -2, 0, 8}// 33	34	36	
			, {13422, 0, -1, 8}, {13422, 0, 0, 8}, {3332, -1, 2, 13}// 38	40	43	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TSKBathRoomSouthAddonDeed();
			}
		}

		[ Constructable ]
		public TSKBathRoomSouthAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 5645, -3, -2, 1, 1166, -1, "", 1);// 1
			AddComplexComponent( (BaseAddon) this, 1900, -1, -2, 4, 1153, -1, "", 1);// 2
			AddComplexComponent( (BaseAddon) this, 1900, 0, -2, 4, 1153, -1, "", 1);// 3
			AddComplexComponent( (BaseAddon) this, 1900, 1, -2, 4, 1153, -1, "", 1);// 4
			AddComplexComponent( (BaseAddon) this, 6211, 1, -2, 9, 0, -1, "BubbleBath", 1);// 5
			AddComplexComponent( (BaseAddon) this, 4845, 0, -2, 0, 1166, -1, "", 1);// 6
			AddComplexComponent( (BaseAddon) this, 3835, -3, -2, 9, 0, -1, "Shampoo", 1);// 7
			AddComplexComponent( (BaseAddon) this, 5646, -3, -2, 1, 1166, -1, "", 1);// 8
			AddComplexComponent( (BaseAddon) this, 1900, -2, -2, 4, 1153, -1, "", 1);// 10
			AddComplexComponent( (BaseAddon) this, 5646, 1, -2, 2, 1166, -1, "", 1);// 11
			AddComplexComponent( (BaseAddon) this, 1900, -3, -2, 4, 1153, -1, "", 1);// 12
			AddComplexComponent( (BaseAddon) this, 5645, -3, 2, 1, 1166, -1, "", 1);// 13
			AddComplexComponent( (BaseAddon) this, 4834, -2, 2, 10, 1166, -1, "", 1);// 14
			AddComplexComponent( (BaseAddon) this, 1910, 1, 2, 4, 1153, -1, "", 1);// 15
			AddComplexComponent( (BaseAddon) this, 1901, 0, 2, 4, 1153, -1, "", 1);// 16
			AddComplexComponent( (BaseAddon) this, 1900, -1, 2, 4, 1153, -1, "", 1);// 17
			AddComplexComponent( (BaseAddon) this, 1901, -2, 2, 4, 1153, -1, "", 1);// 18
			AddComplexComponent( (BaseAddon) this, 1911, -3, 2, 4, 1153, -1, "", 1);// 19
			AddComplexComponent( (BaseAddon) this, 1900, -3, 1, 4, 1153, -1, "", 1);// 20
			AddComplexComponent( (BaseAddon) this, 6420, 1, 1, 9, 1166, -1, "", 1);// 21
			AddComplexComponent( (BaseAddon) this, 1900, 1, 1, 4, 1153, -1, "", 1);// 22
			AddComplexComponent( (BaseAddon) this, 1900, 0, 1, 4, 1153, -1, "", 1);// 23
			AddComplexComponent( (BaseAddon) this, 1900, -1, 1, 4, 1153, -1, "", 1);// 24
			AddComplexComponent( (BaseAddon) this, 1900, -2, 1, 4, 1153, -1, "", 1);// 25
			AddComplexComponent( (BaseAddon) this, 1900, 1, 0, 4, 1153, -1, "", 1);// 27
			AddComplexComponent( (BaseAddon) this, 6199, -1, -1, 9, 0, -1, "Faucet", 1);// 28
			AddComplexComponent( (BaseAddon) this, 19461, 1, -1, 9, 0, -1, "BathSalts", 1);// 29
			AddComplexComponent( (BaseAddon) this, 1900, -3, 0, 4, 1153, -1, "", 1);// 30
			AddComplexComponent( (BaseAddon) this, 1900, -3, -1, 4, 1153, -1, "", 1);// 31
			AddComplexComponent( (BaseAddon) this, 4977, -3, 0, 9, 0, -1, "Scrubber", 1);// 35
			AddComplexComponent( (BaseAddon) this, 3837, -3, -1, 9, 0, -1, "Conditioner", 1);// 37
			AddComplexComponent( (BaseAddon) this, 1900, 1, -1, 4, 1153, -1, "", 1);// 39
			AddComplexComponent( (BaseAddon) this, 4551, -1, 2, 10, 1150, -1, "", 1);// 41
			AddComplexComponent( (BaseAddon) this, 7870, -1, 2, 17, 41, -1, "Columbine", 1);// 42

		}

		public TSKBathRoomSouthAddon( Serial serial ) : base( serial )
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

	public class TSKBathRoomSouthAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TSKBathRoomSouthAddon();
			}
		}

		[Constructable]
		public TSKBathRoomSouthAddonDeed()
		{
			Name = "TSKBathRoomSouth";
		}

		public TSKBathRoomSouthAddonDeed( Serial serial ) : base( serial )
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