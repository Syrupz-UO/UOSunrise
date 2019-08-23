using System;
using Server;

namespace Server.Items
{
	public abstract class BaseSunriseScroll : Item
	{
		public override double DefaultWeight
		{
			get { return 0.1; }
		}

		public BaseSunriseScroll( int itemID ) : this( itemID, 1 )
		{
		}

		public BaseSunriseScroll( int itemID, int amount ) : base( itemID )
		{
			Stackable = true;
			Amount = amount;
		}

		public BaseSunriseScroll( Serial serial ) : base( serial )
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
	}
}