using System;
using Server.Targeting;
using Server.Items;
using Server.Network;

namespace Server.Items
{
	public class VegetableCakeMix : CookableFood
	{
		public override int LabelNumber{ get{ return 1041002; } }

		[Constructable]
		public VegetableCakeMix() : base( 0x103F, 75 )
		{
			Name = "vegetable cake mix";

		}

		public VegetableCakeMix( Serial serial ) : base( serial )
		{
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

		public override Food Cook()
		{
			return new VegetableCake( this.Hue );
		}

	}
}