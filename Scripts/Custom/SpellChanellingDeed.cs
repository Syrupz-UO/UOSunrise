using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server.Mobiles;

namespace Server.Items
{
	public class SpellChannelTargtet : Target // Create our targeting class (which we derive from the base target class)
	{
		private SpellChannelDeed m_Deed;

		public SpellChannelTargtet( SpellChannelDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}

		protected override void OnTarget( Mobile from, object target ) // Override the protected OnTarget() for our feature
		{
			if (from == null)
                return;
			
			if ( m_Deed.Deleted || m_Deed.RootParent != from )
				return;
				

			if (target is BaseShield)
			{
				BaseShield armor = (BaseShield)target;
				armor.Attributes.SpellChanneling=1;
			} 
			if(target is BaseWeapon)
			{
				BaseWeapon weapon = (BaseWeapon)target;
				weapon.Attributes.SpellChanneling=1;
			}
			
			else
			{
			from.SendMessage("That is not a valid target!");	
			return;
			}	
				
				
		
				
            
			//int maxSlots = 10; 
            //if (from.FollowersMax >= maxSlots) 
            //{
              //  from.SendMessage("You already have the max amount of follower slots!"); 
                //return; 
            //}
            //from.FollowersMax++;
            //from.SendMessage("You now possess "+from.FollowersMax+" follower slots."); 
			m_Deed.Delete();
		}
	}

	public class SpellChannelDeed : Item // Create the item class which is derived from the base item class
	{
		public override string DefaultName
		{
			get { return "a spell channeling deed"; }
		}

		[Constructable]
		public SpellChannelDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			LootType = LootType.Blessed;
		}

		public SpellChannelDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			LootType = LootType.Blessed;

			int version = reader.ReadInt();
		}

		public override bool DisplayLootType{ get{ return false; } }

		public override void OnDoubleClick( Mobile from ) // Override double click of the deed to call our target
		{
			if ( !IsChildOf( from.Backpack ) ) // Make sure its in their pack
			{
				 from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
			else
			{
				from.SendLocalizedMessage( 1005018 ); // What would you like to bless? (Clothes Only)
				from.Target = new SpellChannelTargtet( this ); // Call our target
			}
			}
		}	
	}
