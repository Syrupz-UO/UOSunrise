using System;
using Server.Engines.Craft;
using Server.Network;
using System.Collections.Generic;

namespace Server.Items
{
	[Flipable( 0x2B6D, 0x3164 )]
	public class WolfMask : BaseHat
	{
		public override int BasePhysicalResistance{ get{ return 5; } }
		public override int BaseFireResistance{ get{ return 3; } }
		public override int BaseColdResistance{ get{ return 8; } }
		public override int BasePoisonResistance{ get{ return 4; } }
		public override int BaseEnergyResistance{ get{ return 4; } }

		public override int InitMinHits{ get{ return 20; } }
		public override int InitMaxHits{ get{ return 30; } }

		[Constructable]
		public WolfMask() : this( 0 )
		{
		}

		[Constructable]
		public WolfMask( int hue ) : base( 0x2B6D, hue )
		{
			Name = "wolf mask";
			Weight = 5.0;
		}

		public WolfMask( Serial serial ) : base( serial )
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