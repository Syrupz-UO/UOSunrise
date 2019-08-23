using System;
using Server;

namespace Server.Items
{
	public class LesserHealPotion : BaseHealPotion
	{
		public override int MinHeal { get{ return 50; } }
		public override int MaxHeal { get{ return 75; } }
		// public override double Delay{ get{ return (Core.AOS ? 3.0 : 10.0); } }
		public override double Delay { get{ return 2; } }

		[Constructable]
		public LesserHealPotion() : base( PotionEffect.HealLesser )
		{
			ItemID = 0x25FD;
		}

		public LesserHealPotion( Serial serial ) : base( serial )
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