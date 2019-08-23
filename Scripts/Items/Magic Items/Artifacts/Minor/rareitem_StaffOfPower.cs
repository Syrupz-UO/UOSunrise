using System;
using Server;
using Server.Mobiles;

namespace Server.Items
{
	public class StaffOfPower : BlackStaff
	{
		public override int InitMinHits{ get{ return 80; } }
		public override int InitMaxHits{ get{ return 160; } }

		public override int LabelNumber{ get{ return 1070692; } }

		[Constructable]
		public StaffOfPower()
		{
			Hue = 0x4F2;
			WeaponAttributes.MageWeapon = 15;
			Attributes.SpellChanneling = 1;
			Attributes.SpellDamage = 20;
			Attributes.CastRecovery = 2;
			Attributes.LowerManaCost = 20;
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			list.Add( 1070722, "Artifact");
        }
////////////////////////////DOC ALLOW ONLY IF QUEST DONE///////////////////////////////////////////////////////
		public override bool OnEquip( Mobile from ) 
		{ 
			
				PlayerMobile mobile = (PlayerMobile) from;
				
			string staff = ProTag.Get(mobile, "Staff");
			int result = int.Parse(staff); 
			
		    if( result == 1) //Check to see if bound to a serial.
			{ 
      			return true; //player finished quest and can equip it.
      		} 
           
      		else 
      		{ 
      			from.SendMessage( "You have not completed this quest and cannot equip the Ultimate Staff of Power." ); 
				return false; //Disallow any one else from equiping the item.
			} 
		}
	
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////		
		public StaffOfPower( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}