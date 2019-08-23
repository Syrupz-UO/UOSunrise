/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
~~~~~~~    Ultimate Hue Room Generation System
~~~~~~~~~~          designed by MightyHythloth
~~~~~~~~~~~~~~~~
                with credits to the following:
~~~~~~~~~~~~~~~~~~~~
               Lord_GreyWolf - Equation Coding
          tangentzero - Precursor for dye tubs
Cottonballs (Revision of [hue, author unknown)
~~~~~~~~~~~~~~~~~~~~~~~~
Feel free to modify for your use... but please 
leave all credits if you distribute it further
~~~~~~~~~~~~~~~~~~~~~~~~~~~~
~~~  UltimateDyeTub.cs and HueRoomGen.cs  ~~~~
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

using System;
using System.Collections;
using Server;
using Server.Commands;
using Server.Items;
using Server.Mobiles;
using Server.Targeting;

namespace Server.Items
{
	public class UltimateTubTarget : Target
	{
		private Item m_Item;

		public UltimateTubTarget( Item item ) : base( 12, false, TargetFlags.None )
		{
			m_Item = item;
		}

		protected override void OnTarget( Mobile from, object target )
		{
		
			

			if (target is BaseJewel || target is BaseArmor || target is BaseClothing || target is BaseShield || target is BaseWeapon || target is EtherealMount || target is BaseSuit || target is BaseContainer || target is Item )
			{
				
				Item a = from.Backpack.FindItemByType(typeof(HueRoomToken));
					if (a != null)
					{		
				Item item = (Item)target;

				if (item.RootParent == from) // Make sure its in their pack or they are wearing it
					item.Hue = m_Item.Hue;
					a.Delete();
					}
				else
					from.SendMessage("You can only dye objects that are in your backpack or on your person!");
			}
			
			// Begin Enable Pets
			else if (target is BaseCreature)
			{
				Item a = from.Backpack.FindItemByType(typeof(HueRoomToken));
					if (a != null)
					{
					BaseCreature c = target as BaseCreature;
					
					if (c.Controlled && c.ControlMaster == from)
					{
						c.Hue = m_Item.Hue;
						a.Delete(); // Delete the token
						from.SendMessage( "Removed 1 hue room token from your backpack and hued your pet." );
						
					}
					
					else
						from.SendMessage("You can only dye animals whom you control!");
				}

			} // End enable pets.
			else
				from.SendMessage("Invalid target.");
		}
	}
	
	public class UltimateDyeTub : Item
	{
		private bool m_Redyable;

		[Constructable]
		public UltimateDyeTub() : base( 0xFAB )
		{
			Weight = 0.0;
			Hue = 0;
			Name = "UOSunrise Dye Tub";
			m_Redyable = false;
			Movable = false;
		}

		public UltimateDyeTub( Serial serial ) : base( serial )
		{
		}

		public override void OnDoubleClick( Mobile from )
		{
			{
				from.Target = new UltimateTubTarget( this );
				from.SendMessage( "You may now hue your backpack and worn equipment for 1 hue room token" );
				from.SendMessage( "& You may also hue your pets for 1 hue room token each." );
			}
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			if ( Name == "UOSunrise Dye Tub" )
			{
				int intNumber = this.Hue;
				string strNumber = intNumber.ToString("#");
				Name = strNumber;
			}
		}
	}
}
