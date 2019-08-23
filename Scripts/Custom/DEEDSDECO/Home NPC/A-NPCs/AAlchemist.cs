using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Multis;
using Server.ContextMenus;

namespace Server.Mobiles
{
	public class AAlchemist : BaseVendor
	{
		public override bool NoHouseRestrictions{ get{ return true; } }
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
        protected override List<SBInfo> SBInfos { get { return m_SBInfos; } }
		[Constructable]
		public AAlchemist() : base( "The Alchemist" )
		{
		    CantWalk = true;
			
			SetSkill( SkillName.Alchemy, 85.0, 100.0 );
			SetSkill( SkillName.TasteID, 65.0, 88.0 );
		}

		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBAlchemist() );
		}

		public override VendorShoeType ShoeType
		{
			get{ return Utility.RandomBool() ? VendorShoeType.Shoes : VendorShoeType.Sandals; }
		}

		public override void InitOutfit()
		{
			base.InitOutfit();

			AddItem( new Server.Items.Robe( Utility.RandomPinkHue() ) );
		}

		public AAlchemist( Serial serial ) : base( serial )
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

			int version = reader.ReadInt();
		}
		
			public override void GetContextMenuEntries( Mobile from,  List<ContextMenuEntry> list )
		{
			BaseHouse house = BaseHouse.FindHouseAt( from );

			if ( house != null && from.Alive )
			{
				if ( house.IsOwner( from ) && house.IsInside( from )  )
				{
					AAlchemist.GetContextMenuEntries( from, this, list );
				}

				base.GetContextMenuEntries( from, list );
			}
		}

        public static void GetContextMenuEntries(Mobile from, BaseVendor vendor, List<ContextMenuEntry> list)
		{
			list.Add( new AAlchemistCancelMenu( from, vendor ) );
		}

		private class AAlchemistCancelMenu : ContextMenuEntry
		{
			private BaseVendor m_Vendor;
			private Mobile m_Mobile;

			public AAlchemistCancelMenu(Mobile from, BaseVendor vendor) : base(6129, 3) //Dismissal
			{
				m_Vendor = vendor as AAlchemist;
				m_Mobile = from;
			}
			public override void OnClick()
			{
				m_Vendor.Delete();
			
			}
		}
	}
}