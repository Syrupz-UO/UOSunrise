using System;
using Server.Targeting;
using Server.Items;
using Server.Network;

namespace Server.Items
{
	public class MeatCakeMix : CookableFood
	{
		public override int LabelNumber{ get{ return 1041002; } }

		[Constructable]
		public MeatCakeMix() : base( 0x103F, 75 )
		{
			Name = "meat cake mix";

		}

		public MeatCakeMix( Serial serial ) : base( serial )
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
			return new MeatCake( this.Hue );
		}

	}
}