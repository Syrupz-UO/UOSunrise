using System;

namespace Server.Items
{
	public class DDCopper : Item
	{
		public override double DefaultWeight
		{
			get { return ( Core.ML ? ( 0.02 / 3 ) : 0.02 ); }
		}

		[Constructable]
		public DDCopper() : this( 1 )
		{
		}

		[Constructable]
		public DDCopper( int amountFrom, int amountTo ) : this( Utility.RandomMinMax( amountFrom, amountTo ) )
		{
		}

		[Constructable]
		public DDCopper( int amount ) : base( 0xEF0 )
		{
			Name = "copper coins";
			Hue = 0x83E;
			Stackable = true;
			Amount = amount;
			Light = LightType.Circle150;
		}

		public DDCopper( Serial serial ) : base( serial )
		{
		}

		public override int GetDropSound()
		{
			if ( Amount <= 1 )
				return 0x2E4;
			else if ( Amount <= 5 )
				return 0x2E5;
			else
				return 0x2E6;
		}

		protected override void OnAmountChange( int oldValue )
		{
			int newValue = this.Amount;
		}

		public override void OnDoubleClick( Mobile from )
		{
			BankBox box = from.FindBankNoCreate();

			if ( box != null && IsChildOf( box ) )
			{
				Delete();
				int nRate = 10;

				int nCoins = this.Amount;
				int nGold = (int)Math.Floor((decimal)(this.Amount / nRate));
				int nChange = this.Amount - ( nGold * nRate );

				if ( ( nGold > 0 ) && ( nChange > 0 ) )
				{
					from.AddToBackpack ( new Gold( nGold ) );
				}
				else if ( nGold > 0 )
				{
					from.AddToBackpack ( new Gold( nGold ) );
				}

				if ( nChange > 0 ){ from.AddToBackpack ( new DDCopper( nChange ) ); }
			}
			else
			{
				from.SendLocalizedMessage( 1047026 ); // That must be in your bank box to use it.
			}
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
			Light = LightType.Circle150;
			Name = "copper coins";
			Hue = 0x83E;
		}
	}

	// -----------------------------------------------------------------------------------------------------------------------

	public class DDSilver : Item
	{
		public override double DefaultWeight
		{
			get { return ( Core.ML ? ( 0.02 / 3 ) : 0.02 ); }
		}

		[Constructable]
		public DDSilver() : this( 1 )
		{
		}

		[Constructable]
		public DDSilver( int amountFrom, int amountTo ) : this( Utility.RandomMinMax( amountFrom, amountTo ) )
		{
		}

		[Constructable]
		public DDSilver( int amount ) : base( 0xEF0 )
		{
			Name = "silver coins";
			Stackable = true;
			Amount = amount;
			Hue = 0x9C4;
			Light = LightType.Circle150;
		}

		public DDSilver( Serial serial ) : base( serial )
		{
		}

		public override int GetDropSound()
		{
			if ( Amount <= 1 )
				return 0x2E4;
			else if ( Amount <= 5 )
				return 0x2E5;
			else
				return 0x2E6;
		}

		protected override void OnAmountChange( int oldValue )
		{
			int newValue = this.Amount;
		}

		public override void OnDoubleClick( Mobile from )
		{
			BankBox box = from.FindBankNoCreate();

			if ( box != null && IsChildOf( box ) )
			{
				Delete();
				int nRate = 5;

				int nCoins = this.Amount;
				int nGold = (int)Math.Floor((decimal)(this.Amount / nRate));
				int nChange = this.Amount - ( nGold * nRate );

				if ( ( nGold > 0 ) && ( nChange > 0 ) )
				{
					from.AddToBackpack ( new Gold( nGold ) );
				}
				else if ( nGold > 0 )
				{
					from.AddToBackpack ( new Gold( nGold ) );
				}

				if ( nChange > 0 ){ from.AddToBackpack ( new DDSilver( nChange ) ); }
			}
			else
			{
				from.SendLocalizedMessage( 1047026 ); // That must be in your bank box to use it.
			}
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
			Name = "silver coins";
			Hue = 0x9C4;
			Light = LightType.Circle150;
		}
	}

	// -----------------------------------------------------------------------------------------------------------------------

	public class DDJewels : Item
	{
		public override double DefaultWeight
		{
			get { return ( Core.ML ? ( 0.02 / 3 ) : 0.02 ); }
		}

		[Constructable]
		public DDJewels() : this( 1 )
		{
		}

		[Constructable]
		public DDJewels( int amountFrom, int amountTo ) : this( Utility.RandomMinMax( amountFrom, amountTo ) )
		{
		}

		[Constructable]
		public DDJewels( int amount ) : base( 0xEF0 )
		{
			Name = "jewels";
			Stackable = true;
			Amount = amount;
			Light = LightType.Circle150;
		}

		public DDJewels( Serial serial ) : base( serial )
		{
		}

		public override int GetDropSound()
		{
			if ( Amount <= 1 )
				return 0x2E4;
			else if ( Amount <= 5 )
				return 0x2E5;
			else
				return 0x2E6;
		}

		public override void OnDoubleClick( Mobile from )
		{
			BankBox box = from.FindBankNoCreate();

			if ( box != null && IsChildOf( box ) )
			{
				Delete();
				int nGold = this.Amount * 2;
				from.AddToBackpack ( new Gold( nGold ) );
			}
			else
			{
				from.SendLocalizedMessage( 1047026 ); // That must be in your bank box to use it.
			}
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

	// -----------------------------------------------------------------------------------------------------------------------

	public class DDXormite : Item
	{
		public override double DefaultWeight
		{
			get { return ( Core.ML ? ( 0.02 / 3 ) : 0.02 ); }
		}

		[Constructable]
		public DDXormite() : this( 1 )
		{
		}

		[Constructable]
		public DDXormite( int amountFrom, int amountTo ) : this( Utility.RandomMinMax( amountFrom, amountTo ) )
		{
		}

		[Constructable]
		public DDXormite( int amount ) : base( 0xEF0 )
		{
			Name = "xormite coins";
			Stackable = true;
			Amount = amount;
			Hue = 0xB96;
			Light = LightType.Circle150;
		}

		public DDXormite( Serial serial ) : base( serial )
		{
		}

		public override int GetDropSound()
		{
			if ( Amount <= 1 )
				return 0x2E4;
			else if ( Amount <= 5 )
				return 0x2E5;
			else
				return 0x2E6;
		}

		public override void OnDoubleClick( Mobile from )
		{
			BankBox box = from.FindBankNoCreate();

			if ( box != null && IsChildOf( box ) )
			{
				Delete();
				int nGold = this.Amount * 3;
				from.AddToBackpack ( new Gold( nGold ) );
			}
			else
			{
				from.SendLocalizedMessage( 1047026 ); // That must be in your bank box to use it.
			}
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