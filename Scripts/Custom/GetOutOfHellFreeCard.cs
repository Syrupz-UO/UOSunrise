using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server.Mobiles;

namespace Server.Items
{
	public class PlayerKillsTarget : Target // Create our targeting class (which we derive from the base target class)
	{
		private GetOutOfHellFreeCard m_Deed;

		public PlayerKillsTarget( GetOutOfHellFreeCard deed ) : base( 1, false, TargetFlags.None )
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
            int Kills = 10; 
            if (from.Kills <= 0) 
            {
                from.SendMessage("You're not a murderer, dumbass!"); 
                return; 
            }
            from.Kills--;
            from.SendMessage("You now have "+from.Kills+" murders."); 
			m_Deed.Delete();
		}
	}

	
		
	public class GetOutOfHellFreeCard : Item // Create the item class which is derived from the base item class
	{
		public override string DefaultName
		{
			get { return "a Get Out of Hell Free Card"; }
		}

		[Constructable]
		public GetOutOfHellFreeCard() : base( 0x14F0 )
		{
			Weight = 1.0;
			LootType = LootType.Blessed;
		}

		public GetOutOfHellFreeCard( Serial serial ) : base( serial )
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

  public override void AddNameProperties(ObjectPropertyList list)
        {
            base.AddNameProperties(list);
			
            list.Add("Removes ONE murder count"); 
        }
		
		public override bool DisplayLootType{ get{ return false; } }

		public override void OnDoubleClick( Mobile from ) // Override double click of the deed to call our target
		{
			if ( !IsChildOf( from.Backpack ) ) // Make sure its in their pack
			{
				// from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
				from.SendMessage("You consider your sins...");
			}
			else
			{
				from.SendLocalizedMessage( 1005018 ); // What would you like to bless? (Clothes Only)
				from.Target = new PlayerKillsTarget( this ); // Call our target
			}
			}
		}	
	}
}