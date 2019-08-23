using System;
using Server;
using Server.Mobiles;
using Server.Misc;
using Server.Network;

namespace Server.Items
{
	public class KillerTile : Item
	{
		[Constructable]
		public KillerTile() : base(0x4228)
		{
			Movable = false;
			Visible = false;
			Name = "killer";
		}

		public KillerTile(Serial serial) : base(serial)
		{
		}

		public override bool OnMoveOver( Mobile m )
		{
			if ( m is PlayerMobile && m.Blessed == false && m.Alive && m.AccessLevel == AccessLevel.Player && Server.Misc.SeeIfGemInBag.GemInPocket( m ) == false )
			{
				m.LocalOverheadMessage(MessageType.Emote, 0x22, true, "You made a fatal mistake!");
				m.Damage( 10000, m );
				LoggingFunctions.LogKillTile( m, this.Name );
			}
			return true;
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