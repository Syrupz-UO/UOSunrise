using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class MyTentSouthAddon : BaseAddon
	{
		public int TentColor;
		public int TentFound;

		[CommandProperty(AccessLevel.Owner)]
		public int Tent_Color { get { return TentColor; } set { TentColor = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.Owner)]
		public int Tent_Found { get { return TentFound; } set { TentFound = value; InvalidateProperties(); } }

		public override BaseAddonDeed Deed
		{
			get
			{
				return new MyTentSouthAddonDeed( Tent_Color, 1 );
			}
		}

		[Constructable]
		public MyTentSouthAddon() : this( 0 )
		{
		}

		[ Constructable ]
		public MyTentSouthAddon( int RelHue )
		{
			AddComplexComponent( (BaseAddon) this, 505, 1, -3, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 505, 0, -3, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 505, -1, -3, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 505, -2, -3, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 505, 3, -3, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 505, 2, -3, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 504, -3, -2, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 499, -3, -3, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 504, -3, 1, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 504, -3, 2, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 504, -3, 3, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 500, -3, 4, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 501, 4, -3, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 499, 3, -3, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 499, -3, 3, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1536, 0, -2, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1536, -1, -2, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1535, -2, 2, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1535, -2, 1, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1535, -2, 0, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1535, -2, -1, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1542, -2, -2, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1535, -2, 3, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 504, -3, 0, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 504, -3, -1, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1536, 1, -2, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1536, 2, -2, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1536, 3, -2, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1542, -1, -1, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1535, -1, 2, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1535, -1, 0, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1535, -1, 1, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1536, 0, -1, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1536, 1, -1, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1536, 2, -1, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1542, 0, 0, 26, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1535, 0, 1, 26, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1536, 1, 0, 26, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1541, 4, -2, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1543, -2, 4, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1543, -1, 3, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1543, 0, 2, 26, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1541, 3, -1, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1541, 2, 0, 26, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1544, 1, 1, 34, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1537, 1, 2, 26, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1538, 2, 1, 26, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1538, 3, 0, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1538, 3, 1, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1538, 3, 2, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1537, 0, 3, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1537, 1, 3, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1537, 2, 3, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1537, -1, 4, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1537, 0, 4, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1537, 1, 4, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1537, 2, 4, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1537, 3, 4, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1538, 4, -1, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1538, 4, 0, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1538, 4, 1, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1538, 4, 2, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1538, 4, 3, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1540, 2, 2, 26, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1540, 3, 3, 23, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 497, -2, 4, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 1540, 4, 4, 20, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 497, -1, 4, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 497, 2, 4, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 497, 3, 4, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 498, 4, -2, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 498, 4, -1, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 498, 4, 2, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 498, 4, 3, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 496, 4, 4, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 498, 4, 0, 0, RelHue, -1, "tent", 1);
			AddComplexComponent( (BaseAddon) this, 498, 4, 1, 0, RelHue, -1, "tent", 1);

			TentColor = RelHue;
		}

		public MyTentSouthAddon( Serial serial ) : base( serial )
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
            writer.Write( TentColor );
            writer.Write( TentFound );
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
            TentColor = reader.ReadInt();
            TentFound = reader.ReadInt();
		}
	}

	public class MyTentSouthAddonDeed : BaseAddonDeed
	{
		public int TentColor;
		public int TentFound;
		
		[CommandProperty(AccessLevel.Owner)]
		public int Tent_Color { get { return TentColor; } set { TentColor = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.Owner)]
		public int Tent_Found { get { return TentFound; } set { TentFound = value; InvalidateProperties(); } }

		public override BaseAddon Addon
		{
			get
			{
				return new MyTentSouthAddon( Tent_Color );
			}
		}

		[Constructable]
		public MyTentSouthAddonDeed() : this( 0, 0 )
		{
		}

		[Constructable]
		public MyTentSouthAddonDeed( int RelHue, int RelRolled )
		{
			Weight = 50;
			ItemID = 0xA59;

			/// COLOR ////////////////
			if ( Tent_Found > 0 ){ TentColor = Tent_Color; Hue  = Tent_Color; }
			else if ( RelRolled > 0 ){ TentColor = RelHue; Hue = RelHue; }
			else
			{
				switch ( Utility.RandomMinMax( 0, 6 ) ) 
				{
					case 0: Hue = Utility.RandomNeutralHue(); break;
					case 1: Hue = Utility.RandomRedHue(); break;
					case 2: Hue = Utility.RandomBlueHue(); break;
					case 3: Hue = Utility.RandomGreenHue(); break;
					case 4: Hue = Utility.RandomYellowHue(); break;
					case 5: Hue = Utility.RandomMetalHue(); break;
					case 6: Hue = 0; break;
				}
				TentColor = Hue;
			}

			Name = "Tent (South Door)";
			TentFound = 1;
		}

		public MyTentSouthAddonDeed( Serial serial ) : base( serial )
		{
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);

			list.Add( 1070722, "Can Be Dyed Different Colors");
			list.Add( 1049644, "Requires a Minimum 9x9 Plot of Land");
        } 

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
            writer.Write( TentColor );
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
            TentColor = reader.ReadInt();
		}
	}
}