using System;
using Server.Items;

namespace Server.Items
{
	public class DonationBoltStone : Item
	{
		private bool m_ChargeForBolts;
		private int m_PriceForBolts;
		private int m_AmountOfBolts;
		
		[CommandProperty( AccessLevel.GameMaster )]
		public bool ChargeForBolts { get{ return m_ChargeForBolts; } set{ m_ChargeForBolts = value; } }
		
		[CommandProperty( AccessLevel.GameMaster )]
		public int PriceForBolts { get{ return m_PriceForBolts; } set{ m_PriceForBolts = value; } }
		
		[CommandProperty( AccessLevel.GameMaster )]
		public int AmountOfBolts { get{ return m_AmountOfBolts; } set{ m_AmountOfBolts = value; } }
		
		[Constructable]
		public DonationBoltStone() : base ( 3699 )
		{
			Name = "A Donation Bolt Stone";
			Movable = false;
			Hue = 2181;
			
			//Default Settings
			ChargeForBolts = false;
			PriceForBolts = 0;
			AmountOfBolts = 1000;
		}
		
		public override void OnDoubleClick( Mobile from )
		{
			Container pack = from.Backpack;
			Container bank = from.BankBox;
			
			if ( bank != null || pack != null )
			{
				if ( ChargeForBolts )
				{
					if ( pack.ConsumeTotal( typeof( Gold ), PriceForBolts ) )
					{
						PackBag( from, AmountOfBolts );
						from.SendMessage( "{0} gold has been removed from your backpack.", PriceForBolts );
					}
					else if ( bank.ConsumeTotal( typeof( Gold ), PriceForBolts ) )
					{
						PackBag( from, AmountOfBolts );
						from.SendMessage( "{0} gold has been removed from your bankbox.", PriceForBolts );
					}
					else
						from.SendMessage( "You do not have enough funds for that." );
				}
				else
				{
					PackBag( from, AmountOfBolts );
					from.SendMessage( "500 Bolts have been placed into your backpack." );
				}
			}
			else
			{
				if ( bank == null )
					from.SendMessage( "You do not have a bankbox. Please contact a staff member immediately and report this issue." );
					
				if ( pack == null )
					from.SendMessage( "You do not have a backpack. Please contact a staff member aimmediately and report this issue." );
			}
		}
		
		public void PackBag( Mobile from, int count )
		{
			Bolt Bolt = new Bolt( 500 );
			Bolt.Hue = 0;
			
			if ( !from.AddToBackpack( Bolt ) )
			{
				if ( !from.BankBox.TryDropItem( from, Bolt, false ) )
				{
					from.SendMessage( "Your bank box is full." );
				}
				else if ( from.BankBox.TryDropItem( from, Bolt, false ) )
				{
					from.SendMessage( "Your Backpack is too full, so the item has been placed in your bank." );
				}
				else
				{
					Bolt.Location = from.Location;
					Bolt.Map = from.Map;
					from.SendMessage( "Your Backpack and Bank box is too full to carry all that." );
					from.SendMessage( "The bag fall to the ground, be sure to put it in your bank or something!" );
				}
			}
		}
		
		public DonationBoltStone( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( ( int ) 1 );
			
			writer.Write( ( bool )m_ChargeForBolts );
			writer.Write( ( int )m_PriceForBolts );
			writer.Write( ( int )m_AmountOfBolts );
		}
		
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			
			switch ( version )
			{
				case 1:
				{
					m_ChargeForBolts = reader.ReadBool();
					m_PriceForBolts = reader.ReadInt();
					m_AmountOfBolts = reader.ReadInt();
					goto case 0;
				}
				case 0:
				{
					break;
				}
			}
		}
	}
}