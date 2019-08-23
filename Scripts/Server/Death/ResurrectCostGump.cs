using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Items;
using Server.Misc;
using Server.Network;
using Server.Mobiles;

namespace Server.Gumps
{
	public class ResurrectCostGump : Gump
	{
		private int m_Price;
		private int m_Healer;
		private int m_Bank;
		private int m_ResurrectType;

		public ResurrectCostGump( Mobile owner, int healer ) : base( 150, 50 )
		{
			m_Healer = healer;
			m_Price = 250; //GetPlayerInfo.GetResurrectCost( owner );
			m_Bank = Banker.GetBalance( owner );
			m_ResurrectType = 0;

			string sText = "";

			if ( m_Price > 0 )
			{
				if ( m_Price > m_Bank )
				{
					if ( m_Healer != 2 )
					{
						sText = "You currently do not have enough gold in the bank to provide an offering to the healer. Do you wish to plead to the healer for your life back now, without providing tribute? ";
					}
					else
					{
						sText = "You currently do not have enough gold in the bank to provide an offering to the shrine. Do you wish to plead to the gods for your life back now, without providing tribute? ";
					}
					m_ResurrectType = 1;
				}
				else
				{
					if ( m_Healer != 2 )
					{
						sText = "You currently have enough gold in the bank to provide an offering to the healer. Do you wish to offer the tribute to the healer for your life back?.";
					}
					else
					{
						sText = "You currently have enough gold in the bank to provide an offering to the shrine. Do you wish to offer the tribute to the gods for your life back?.";
					}
					m_ResurrectType = 2;
				}
			}
			else
			{
				if ( m_Healer != 2 )
				{
					sText = "Do you wish to have the healer return you to life?.";
				}
				else
				{
					sText = "Do you wish to have the gods return you to life?.";
				}
			}

			string sGrave = "RETURN TO THE LIVING";
			switch ( Utility.RandomMinMax( 0, 3 ) )
			{
				case 0:	sGrave = "YOUR LIFE BACK";			break;
				case 1:	sGrave = "YOUR RESURRECTION";		break;
				case 2:	sGrave = "RETURN TO THE LIVING";	break;
				case 3:	sGrave = "RETURN FROM THE DEAD";	break;
			}

            this.Closable=false;
			this.Disposable=true;
			this.Dragable=true;
			this.Resizable=false;

			AddPage(0);

			AddImage(0, 0, 154);
			AddImage(300, 201, 154);
			AddImage(0, 201, 154);
			AddImage(300, 0, 154);
			AddImage(298, 199, 129);
			AddImage(2, 199, 129);
			AddImage(298, 2, 129);
			AddImage(2, 2, 129);
			AddImage(7, 6, 145);
			AddImage(8, 257, 142);
			AddImage(253, 285, 144);
			AddImage(171, 47, 132);
			AddImage(379, 8, 134);
			AddImage(167, 7, 156);
			AddImage(209, 11, 156);
			AddImage(189, 10, 156);
			AddImage(170, 44, 159);

			AddItem(190, 63, 3);
			AddItem(168, 63, 2);

			AddButton(162, 365, 4023, 4023, 1, GumpButtonType.Reply, 0);
			AddButton(389, 365, 4020, 4020, 2, GumpButtonType.Reply, 0);

			if ( m_Price > 0 )
			{
				AddHtml( 101, 271, 190, 22, @"<BODY><BASEFONT Color=White><BIG>Resurrection Tribute</BIG></BASEFONT></BODY>", (bool)false, (bool)false);
				AddHtml( 307, 271, 116, 22, @"<BODY><BASEFONT Color=#FCFF00><BIG>" + String.Format("{0} Gold", m_Price ) + "</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddHtml( 101, 305, 190, 22, @"<BODY><BASEFONT Color=White><BIG>Gold in the Bank</BIG></BASEFONT></BODY>", (bool)false, (bool)false);
				AddHtml( 307, 305, 116, 22, @"<BODY><BASEFONT Color=#FCFF00><BIG>" + String.Format("{0} Gold", m_Bank ) + "</BIG></BASEFONT></BODY>", (bool)false, (bool)false);
			}

			AddHtml( 259, 91, 305, 22, @"<BODY><BASEFONT Color=White><BIG><CENTER>" + sGrave + "</CENTER></BIG></BASEFONT></BODY>", (bool)false, (bool)false);

			AddHtml( 100, 155, 477, 103, @"<BODY><BASEFONT Color=#FCFF00><BIG>" + sText + "</BIG></BASEFONT></BODY>", (bool)false, (bool)false);
		}

		private static void ResurrectNow( object state )
		{
			Mobile m = state as Mobile;
			m.CloseGump( typeof( ResurrectNowGump ) );
			m.SendGump( new ResurrectNowGump( m ) );
		}

		public override void OnResponse( NetState state, RelayInfo info )
		{
			Mobile from = state.Mobile;

			from.CloseGump( typeof( ResurrectCostGump ) );

			if( info.ButtonID == 1 )
			{
				if( from.Map == null || !from.Map.CanFit( from.Location, 16, false, false ) )
				{
					from.SendLocalizedMessage( 502391 ); // Thou can not be resurrected there!
					return;
				}

				if ( m_ResurrectType == 2  )
				{
					from.SendLocalizedMessage( 1060398, m_Price.ToString() ); // ~1_AMOUNT~ gold has been withdrawn from your bank box.
					from.SendLocalizedMessage( 1060022, Banker.GetBalance( from ).ToString() ); // You have ~1_AMOUNT~ gold in cash remaining in your bank box.
				}
				else if ( m_ResurrectType == 1 && from.SkillsTotal > 200 && ( from.RawDex + from.RawInt + from.RawStr ) > 90 )
				{
					if( from.Fame > 0 ) // 10% FAME LOSS
					{
						int amount = (int)(from.Fame * 0.10);
						if ( from.Fame - amount < 0 ){ amount = from.Fame; }
							if ( from.Fame < 1 ){ from.Fame = 0; }
						Misc.Titles.AwardFame( from, -amount, true );
					}

					if( from.Karma > 0 ) // 10% KARMA LOSS
					{
						int amount = (int)(from.Karma * 0.10);
						if ( from.Karma - amount < 0 ){ amount = from.Karma; }
							if ( from.Karma < 1 ){ from.Karma = 0; }
						Misc.Titles.AwardKarma( from, -amount, true );
					}

					/*double loss = 0.95;

					if( from.RawStr * loss > 10 )
						from.RawStr = (int)(from.RawStr * loss);
							if ( from.RawStr < 10 ){ from.RawStr = 10; }
					if( from.RawInt * loss > 10 )
						from.RawInt = (int)(from.RawInt * loss);
							if ( from.RawInt < 10 ){ from.RawInt = 10; }
					if( from.RawDex * loss > 10 )
						from.RawDex = (int)(from.RawDex * loss);
							if ( from.RawDex < 10 ){ from.RawDex = 10; }

					for( int s = 0; s < from.Skills.Length; s++ )
					{
						if( from.Skills[s].Base * loss > 35 )
							from.Skills[s].Base *= loss;
					}*/
				}

				from.PlaySound( 0x214 );
				from.FixedEffect( 0x376A, 10, 16 );

				from.Resurrect();

				from.Hits = from.HitsMax;
				from.Stam = from.StamMax;
				from.Mana = from.ManaMax;
				from.Hidden = true;
			}
			else
			{
				from.SendMessage( "You decide to remain in the spirit realm." );
				Timer.DelayCall( TimeSpan.FromSeconds( 5.0 ), ResurrectNow, from );
				return;
			}
		}
	}
}