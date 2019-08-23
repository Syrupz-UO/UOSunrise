using System;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.ContextMenus;
using Server.Gumps;
using Server.Misc;
using Server.Network;
using Server.Spells;
using Server.Accounting;
using System.Collections.Generic;

namespace Server.Mobiles
{
	[CorpseName( "Gastin's corpse" )]
	public class Gastin : Mobile
	{
                public virtual bool IsInvulnerable{ get{ return true; } }
		[Constructable]
		public Gastin()
		{
			Name = "Gastin";
                        Title = "the Crazed Farmer";
			Body = 0x190;
			Hue = Utility.RandomSkinHue();
			Blessed = true;

			Boots b = new Boots();
                        b.Hue = 1;
                        AddItem( b );

                        LongPants lp = new LongPants();
                        lp.Hue = 292;
                        AddItem( lp );

		        FancyShirt fs = new FancyShirt();
                        fs.Hue = 1153;
                        AddItem( fs );

	                Pitchfork pf = new Pitchfork();
                        AddItem( pf );
                        
                        AddItem( new LongHair(1337));
                     

			
		}

		public Gastin( Serial serial ) : base( serial )
		{
		}

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list) 
	        { 
	                base.GetContextMenuEntries( from, list ); 
        	        list.Add( new GastinEntry( from, this ) ); 
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

		public class GastinEntry : ContextMenuEntry
		{
			private Mobile m_Mobile;
			private Mobile m_Giver;
			
			public GastinEntry( Mobile from, Mobile giver ) : base( 6146, 3 )
			{
				m_Mobile = from;
				m_Giver = giver;
			}

			public override void OnClick()
			{
				

                          if( !( m_Mobile is PlayerMobile ) )
					return;
				
				PlayerMobile mobile = (PlayerMobile) m_Mobile;

				{
					if ( ! mobile.HasGump( typeof( GastinGump ) ) )
					{
						mobile.SendGump( new GastinGump( mobile ));
						
					} 
				}
			}
		}

		public override bool OnDragDrop( Mobile from, Item dropped )
		{          		
         	        Mobile m = from;
			PlayerMobile mobile = m as PlayerMobile;
			Account acct=(Account)from.Account;
			bool BagofStrengthReceived = Convert.ToBoolean( acct.GetTag("BagofStrengthReceived") );

			if ( mobile != null)
			{
				if( dropped is PrizedLeather )
         		{
         			if(dropped.Amount!=20)
         			{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "I need 20 of them!", mobile.NetState );
         				return false;
         			}

					if ( !BagofStrengthReceived ) //added account tag check
		                {
					dropped.Delete(); 
					mobile.AddToBackpack( new BagOfStrength() );
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "Thank you so much!  Here is your bag as promised!", mobile.NetState );
                                        acct.SetTag( "BagofStrengthReceived", "true" );

				
         		        }
				else //what to do if account has already been tagged
         			{
         				this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "Thank you for bringing me even more leather!", mobile.NetState );
         				mobile.AddToBackpack( new Gold( 3000 ) );
         				dropped.Delete();
         			}
         		}
				else
         		{
					this.PrivateOverheadMessage( MessageType.Regular, 1153, false, "I have no need for this item.", mobile.NetState );
     			}
			}
			return false;
		}
	}
}