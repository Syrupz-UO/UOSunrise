using System;
using Server;
using Server.Network;

namespace Server.Items
{
	public class FarmableTomato : FarmableCrop
	{
		public static int GetCropID()
		{
			return 0x0DEE;
		}

		public override Item GetCropObject()
		{
			Tomato Tomato = new Tomato();

			Tomato.ItemID = 0x9D0;

			return Tomato;
		}

		public override int GetPickedID()
		{
			return 0x0DEC;
		}

		[Constructable]
		public FarmableTomato() : base( GetCropID() )
		{
			Name = "tomato plant";
		}

		public FarmableTomato( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.WriteEncodedInt( 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadEncodedInt();
		}
	}

	[FlipableAttribute( 0x9D0, 0x9D0 )]
	public class Tomato : Food
	{
		[Constructable]
		public Tomato() : this( 1 )
		{
		}

		[Constructable]
		public Tomato( int amount ) : base( amount, 0x9D0 )
		{
			Name = "tomato";
			this.Weight = 1.0;
			this.FillFactor = 1;
		}

		public Tomato( Serial serial ) : base( serial )
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