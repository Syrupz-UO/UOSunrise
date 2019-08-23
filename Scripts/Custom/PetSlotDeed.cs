using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server.Mobiles;

namespace Server.Items
{
	public class PlayerSlotTarget : Target // Create our targeting class (which we derive from the base target class)
	{
		private PetSlotDeed m_Deed;

		public PlayerSlotTarget( PetSlotDeed deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}

		protected override void OnTarget( Mobile from, object target ) // Override the protected OnTarget() for our feature
		{
			if ( m_Deed.Deleted || m_Deed.RootParent != from )
				return;

			if (target is PlayerMobile)
			{
				if (from == null)
                return;
            int maxSlots = 10; 
            if (from.FollowersMax >= maxSlots) 
            {
                from.SendMessage("You already have the max amount of follower slots!"); 
                return; 
            }
            from.FollowersMax++;
            from.SendMessage("You now possess "+from.FollowersMax+" follower slots."); 
			m_Deed.Delete();
		}
	}

	public class PetSlotDeed : Item // Create the item class which is derived from the base item class
	{
		public override string DefaultName
		{
			get { return "a +1 pet slot deed"; }
		}

		[Constructable]
		public PetSlotDeed() : base( 0x14F0 )
		{
			Weight = 1.0;
			LootType = LootType.Blessed;
		}

		public PetSlotDeed( Serial serial ) : base( serial )
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
				from.Target = new PlayerSlotTarget( this ); // Call our target
			}
			}
		}	
	}
}