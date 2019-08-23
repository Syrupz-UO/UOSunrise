// Author:     Lucifer
// Version:    1.0
// Shard:      UO Extinction

using Server.Targeting; 
using System; 
using Server; 
using Server.Gumps; 
using Server.Network; 
using Server.Menus; 
using Server.Menus.Questions; 
using Server.Mobiles; 
using System.Collections; 

namespace Server.Items 
{ 
   	public class PetEXPDeed250000 : Item 
   	{     
      	[Constructable] 
      	public PetEXPDeed250000() : base( 0x14F0 )
      	{ 
         	Movable = true;
			Hue = 1050;
         	Name= "Pet Experience Scroll";
			Weight= 0;
		} 

		public PetEXPDeed250000( Serial serial ) : base( serial ) 
		{ 
		}
		
		public override void OnDoubleClick( Mobile from ) 
		{ 
			if ( !IsChildOf( from.Backpack ) )
			{
				from.SendLocalizedMessage( 1042001 );
			}
			else if( from.InRange( this.GetWorldLocation(), 2 ) ) 
			{
				from.SendMessage( "Select your pet." );
				from.Target = new PetEXPTarget250000( this );
			} 
			else 
			{ 
				from.SendLocalizedMessage( 500446 );
			}
		} 
		
        public override void GetProperties( ObjectPropertyList list )
        {
            base.GetProperties( list );        
            list.Add( "<BASEFONT COLOR=#7FCAE7>Value:" + "<BASEFONT COLOR=#FFFFFF> 250.000" + "<BASEFONT COLOR=#7FCAE7> Effects:" + "<BASEFONT COLOR=#FFFFFF> Increases Pet Experience");	
        }

		public override void Serialize( GenericWriter writer ) 
		{ 
			base.Serialize( writer ); 
			writer.Write( (int) 0 ); 
		} 

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 
			int version = reader.ReadInt(); 
		} 

  		private class PetEXPTarget250000 : Target 
		{ 
			private Mobile m_Owner; 
			private Item m_Deed; 

			public PetEXPTarget250000( Item deed ) : base ( 10, false, TargetFlags.None ) 
			{ 
				m_Deed = deed; 
			} 
          
			protected override void OnTarget( Mobile from, object target ) 
			{ 
				if ( target == from ) 
					from.SendMessage( "You cant add experience to yourself!" );

				else if ( target is PlayerMobile )
					from.SendMessage( "You cannot make someone powerful with this!" );

				else if ( target is Item )
					from.SendMessage( "This only works on your pet!" );

				else if ( target is BaseCreature ) 
				{ 
					BaseCreature c = (BaseCreature)target;
					
					if ( c.BodyValue == 400 || c.BodyValue == 401 && c.Controlled == false )
					{
						from.SendMessage( "You cannont give experience to a human!" );
					}
					else if ( c.ControlMaster != from && c.Controlled == false )
					{
						from.SendMessage( "You can only add experience on your own pet." );
					}
					else if ( c.Summoned )
					{
						from.SendMessage( "You cannot use this on summoned creatures." );
					}
					else if ( c.NextLevel <=250000 ) // HORUS
					{
						from.SendMessage( "You need less experience to level up." );
					}					
					else if ( c.Controlled == true && c.ControlMaster == from)
					{

						c.Exp += 250000;
						from.SendMessage("Your pet experience increased by 10.000");
						from.PlaySound( 0x23E );
						m_Deed.Delete();
					}
				}
			} 
		} 
   	} 
} 
