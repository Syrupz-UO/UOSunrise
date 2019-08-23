using System;
using Server;

namespace Server.Items
{
	public class LesserRejuvenatePotion : BaseRejuvenatePotion
	{
		public override int MinRejuv { get{ return 50; } }
		public override int MaxRejuv { get{ return 75; } }
		public override double Delay { get{ return 2; } }

		[Constructable]
		public LesserRejuvenatePotion( ) : base( PotionEffect.RejuvenateLesser )
		{
			Name = "lesser rejuvenate potion";
			ItemID = 0x23BD;
			Hue = Server.Items.PotionKeg.GetPotionColor( this );
		}

		public LesserRejuvenatePotion( Serial serial ) : base( serial )
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
