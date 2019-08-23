using System;
using Server;

namespace Server.Items
{
	public class BlackCrystal : Item
	{
		[Constructable]
		public BlackCrystal() : base( 0x2DA )
		{
			Movable = false;
			Hue = 1109;
		}
		
		public BlackCrystal( Serial serial ) : base( serial )
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