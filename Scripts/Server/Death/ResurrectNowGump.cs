using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Items;
using Server.Network;
using Server.Mobiles;
using Server.Gumps;
using Server.Misc;

namespace Server 
{ 
	public class AutoRessurection
	{ 
		public static void Initialize()
		{
			EventSink.PlayerDeath += new PlayerDeathEventHandler(EventSink_PlayerDeath);
		}

		private static void EventSink_PlayerDeath(PlayerDeathEventArgs e)
		{
			Mobile m = e.Mobile;

			if ( ( m != null ) && ( !m.Alive ) )
			{
				Timer.DelayCall( TimeSpan.FromSeconds( 5.0 ), ResurrectNow, m );
			}
		}

		private static void ResurrectNow( object state )
		{
			Mobile m = state as Mobile;
			m.CloseGump( typeof( ResurrectNowGump ) );
			m.SendGump( new ResurrectNowGump( m ) );
		}
	}
}

namespace Server.Gumps
{
	public class ResurrectNowGump : Gump
	{
		public ResurrectNowGump( Mobile from ): base( 50, 20 )
		{
			from.Stam = from.StamMax;
				from.Mana = from.ManaMax;
            int HealCost = 250;  //GetPlayerInfo.GetResurrectCost( from );
			int BankGold = Banker.GetBalance( from );
			
			string sText = "Do you wish to plead to the gods for your life back now? You may also continue on in your spirit form and seek out a shrine or healer.";
			bool ResPenalty = false;

			if ( from.SkillsTotal > 200 && ( from.RawDex + from.RawInt + from.RawStr ) > 90 )
			{
				ResPenalty = false;

				if ( BankGold >= HealCost )
					sText = "Do you wish to plead to the gods for your life back now?   You have enough gold in the bank to offer the resurrection tribute, so perhaps you may want to find a shrine or healer instead of suffering the penalties.";
				else
					sText = "Do you wish to plead to the gods for your life back now?   You cannot afford the resurrection tribute due to the lack of gold in the bank, so perhaps you may want to do this.";
			}

			string sGrave = "YOU HAVE DIED!";
			switch ( Utility.RandomMinMax( 0, 3 ) )
			{
				case 0:	sGrave = "YOU HAVE DIED!";			break;
				case 1:	sGrave = "YOU HAVE PERISHED!";		break;
				case 2:	sGrave = "YOU MET YOUR END!";		break;
				case 3:	sGrave = "YOUR LIFE HAS ENDED!";	break;
			}

            this.Closable=true;
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

			AddItem(173, 64, 4455);
			AddItem(186, 85, 3810);
			AddItem(209, 102, 3808);

			AddButton(162, 365, 4023, 4023, 1, GumpButtonType.Reply, 0);
			AddButton(389, 365, 4020, 4020, 2, GumpButtonType.Reply, 0);

			if ( ResPenalty )
			{
				AddHtml( 101, 271, 190, 22, @"<BODY><BASEFONT Color=White><BIG>Resurrection Tribute</BIG></BASEFONT></BODY>", (bool)false, (bool)false);
				AddHtml( 307, 271, 116, 22, @"<BODY><BASEFONT Color=#FCFF00><BIG>" + String.Format("{0} Gold", HealCost ) + "</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddHtml( 101, 305, 190, 22, @"<BODY><BASEFONT Color=White><BIG>Gold in the Bank</BIG></BASEFONT></BODY>", (bool)false, (bool)false);
				AddHtml( 307, 305, 116, 22, @"<BODY><BASEFONT Color=#FCFF00><BIG>" + Banker.GetBalance( from ).ToString() + " Gold</BIG></BASEFONT></BODY>", (bool)false, (bool)false);
			}

			AddHtml( 267, 95, 306, 22, @"<BODY><BASEFONT Color=White><BIG><CENTER>" + sGrave + "</CENTER></BIG></BASEFONT></BODY>", (bool)false, (bool)false);

			AddHtml( 100, 155, 477, 103, @"<BODY><BASEFONT Color=#FCFF00><BIG>" + sText + "</BIG></BASEFONT></BODY>", (bool)false, (bool)false);
		}

		public override void OnResponse( NetState state, RelayInfo info )
		{
			Mobile from = state.Mobile;

			from.CloseGump( typeof( ResurrectNowGump ) );

			if ( info.ButtonID == 1 && !from.Alive )
			{
				from.PlaySound( 0x214 );
				from.FixedEffect( 0x376A, 10, 16 );

				from.Resurrect();

				if ( from.SkillsTotal > 200 && ( from.RawDex + from.RawInt + from.RawStr ) > 90 )
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

				from.Hits = from.HitsMax;
				from.Stam = from.StamMax;
				from.Mana = from.ManaMax;
				from.Hidden = true;
			}
			else { return; }
		}
	}
}