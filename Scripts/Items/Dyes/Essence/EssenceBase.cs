using System;
using Server;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Misc;
using Server.Mobiles;
using Server.Network;

namespace Server.Items
{
	public class EssenceBase : BaseAddon
	{
		public string ItemType;
		[CommandProperty(AccessLevel.Owner)]
		public string Item_Type { get { return ItemType; } set { ItemType = value; InvalidateProperties(); } }

		public int ItemColor;
		[CommandProperty(AccessLevel.Owner)]
		public int Item_Color { get { return ItemColor; } set { ItemColor = value; InvalidateProperties(); } }

		public int ItemHairColor;
		[CommandProperty(AccessLevel.Owner)]
		public int Item_HairColor { get { return ItemHairColor; } set { ItemHairColor = value; InvalidateProperties(); } }

		public string ItemName;
		[CommandProperty(AccessLevel.Owner)]
		public string Item_Name { get { return ItemName; } set { ItemName = value; InvalidateProperties(); } }

		[ Constructable ]
		public EssenceBase( string orb )
		{
			Light = LightType.Circle150;
			string sPed = "an ornately ";
			switch( Utility.RandomMinMax( 0, 10 ) )
			{
				case 0: sPed = "an ornately ";		break;
				case 1: sPed = "a beautifully ";	break;
				case 2: sPed = "an expertly ";		break;
				case 3: sPed = "an artistically ";	break;
				case 4: sPed = "an exquisitely ";	break;
				case 5: sPed = "a decoratively ";	break;
				case 6: sPed = "an ancient ";		break;
				case 7: sPed = "an old ";			break;
				case 8: sPed = "an unusually ";		break;
				case 9: sPed = "a curiously ";		break;
				case 10: sPed = "an oddly ";		break;
			}
			sPed = sPed + "carved pedestal";

			string sThing = ItemName = "Essence of the Drow";
			int iColor = ItemColor = 1316;
			ItemHairColor = 1150;
			ItemType = "drow";
			if ( orb == "ork" ){ iColor = ItemColor = 0x1CB; ItemHairColor = 0x455; sThing = ItemName = "Essence of the Ork"; ItemType = "ork"; }
			else if ( orb == "tritun" ){ iColor = ItemColor = 0x555; ItemHairColor = 0x554; sThing = ItemName = "Essence of the Tritun"; ItemType = "tritun"; }
			else if ( orb == "vampire" ){ iColor = ItemColor = 0x47E; ItemHairColor = 0x497; sThing = ItemName = "Essence of the Vampire"; ItemType = "vampire"; }
			else if ( orb == "ghost" ){ iColor = ItemColor = 0x47E; ItemHairColor = 0x47E; sThing = ItemName = "Essence of the Ghost"; ItemType = "ghost"; }
			else if ( orb == "demon" ){ iColor = ItemColor = 0x5B5; ItemHairColor = 0x497; sThing = ItemName = "Essence of the Demon"; ItemType = "demon"; }
			else if ( orb == "ice" ){ iColor = ItemColor = 0x482; ItemHairColor = 0x47E; sThing = ItemName = "Essence of the Snow"; ItemType = "ice"; }
			else if ( orb == "fire" ){ iColor = ItemColor = 0x489; ItemHairColor = 0x496; sThing = ItemName = "Essence of the Flame"; ItemType = "fire"; }
			else if ( orb == "shadow" ){ iColor = ItemColor = 0x497; ItemHairColor = 0x497; sThing = ItemName = "Essence of the Shadows"; ItemType = "shadow"; }
			else if ( orb == "dark" ){ iColor = ItemColor = 1; ItemHairColor = 1; sThing = ItemName = "Essence of the Dark"; ItemType = "dark"; }

			AddComplexComponent( (BaseAddon) this, 0xE2E, 0, 0, 5, iColor, 29, sThing, 1);
			AddComplexComponent( (BaseAddon) this, 5703, 0, 0, 0, 0, 29, sPed, 1);
			AddComplexComponent( (BaseAddon) this, 13042, 0, 0, 0, 0, -1, "", 1);
		}

		public EssenceBase( Serial serial ) : base( serial )
		{
		}

		public override bool HandlesOnMovement{ get{ return true; } }
		private DateTime m_NextTalk;
		public DateTime NextTalk{ get{ return m_NextTalk; } set{ m_NextTalk = value; } }
		public override void OnMovement( Mobile m, Point3D oldLocation )
		{
			if( m is PlayerMobile )
			{
				if ( DateTime.UtcNow >= m_NextTalk && Utility.InRange( m.Location, this.Location, 2 ) )
				{
					m.PrivateOverheadMessage(MessageType.Regular, 1150, false, "I could use that item on the pedestal to take it.", m.NetState);
					m_NextTalk = (DateTime.UtcNow + TimeSpan.FromSeconds( 30 ));
				}
			}
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

		public override void OnComponentUsed( AddonComponent ac, Mobile from )
		{
			if ( !from.InRange( GetWorldLocation(), 2 ) )
			{
				from.SendMessage( "You will have to get closer to take that." );
			}
			else 
			{
				ArrayList targets = new ArrayList();
				foreach ( Item item in World.Items.Values )
				if ( item is EssenceOrb )
				{
					if ( ((EssenceOrb)item).m_Owner == from && ((EssenceOrb)item).m_Type == ItemType )
						targets.Add( item );
				}
				for ( int i = 0; i < targets.Count; ++i )
				{
					Item item = ( Item )targets[ i ];
					item.Delete();
				}

				EssenceOrb orbI = new EssenceOrb();
				orbI.m_Owner = from;
				orbI.m_Type = ItemType;
				orbI.m_MorphHue = ItemColor;
				orbI.m_MorphHairHue = ItemHairColor;
				orbI.m_MorphName = ItemName;

            	orbI.m_OriginalName = "Essence of " + from.Name;
            	orbI.m_Status = 0;
				orbI.Hue = ItemColor;
				orbI.Name = ItemName;

				from.AddToBackpack( orbI );

				EssenceBaseEmpty Pedul = new EssenceBaseEmpty();
				Pedul.ItemType = ItemType;
				Pedul.MoveToWorld (new Point3D(this.X, this.Y, this.Z), this.Map);
				from.SendMessage( "You have taken the " + ItemName + "!" );
				this.Delete();
			}
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
            writer.Write( ItemType );
            writer.Write( ItemColor );
            writer.Write( ItemHairColor );
            writer.Write( ItemName );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
            ItemType = reader.ReadString();
			ItemColor = reader.ReadInt();
			ItemHairColor = reader.ReadInt();
			ItemName = reader.ReadString();
		}
	}
}