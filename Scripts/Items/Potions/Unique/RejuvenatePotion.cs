using System;
using Server;

namespace Server.Items
{
	public class RejuvenatePotion : BaseRejuvenatePotion
	{
		public override int MinRejuv { get{ return 75; } }
		public override int MaxRejuv { get{ return 125; } }
		public override double Delay { get{ return 4; } }

		[Constructable]
		public RejuvenatePotion( ) : base( PotionEffect.Rejuvenate )
		{
			Name = "rejuvenate potion";
			Hue = Server.Items.PotionKeg.GetPotionColor( this );
		}

		public RejuvenatePotion( Serial serial ) : base( serial )
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
