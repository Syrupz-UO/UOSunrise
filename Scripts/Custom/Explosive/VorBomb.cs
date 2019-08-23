using System;
using Server;

namespace Server.Items
{
	public class VorBomb : BaseBomb
	{
		[Constructable]
		public VorBomb() : base()
		{
			Name = "Dirty Bomb";
			Hue = 2522;
			Weight = 10.0;
			CountDown = 10.0;
			MinDamage = 10;
			MaxDamage = 50;
			ExplosionRange = 20;
		}

		public override void AddNameProperties( ObjectPropertyList list )
		{
			
			string msg = String.Format ( "<font color='Green'>Dirty Bomb</font>" );


			AddNameProperty( list );
			list.Add(msg);
			list.Add("USE: Places a land mine at your feet.");
			list.Add("You must remain still while placing on the ground!");
			
		
		}
		
		public VorBomb( Serial serial ) : base( serial )
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