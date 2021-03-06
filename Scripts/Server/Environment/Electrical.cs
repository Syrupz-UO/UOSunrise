using System;
using Server.Items;
using Server.Network;
using Server.Mobiles;

namespace Server.Items
{
    public class Electrical : Item
	{
		public override bool HandlesOnMovement{ get{ return true; } }

		private DateTime m_NextSound;
		public DateTime NextSound{ get{ return m_NextSound; } set{ m_NextSound = value; } }

		public override void OnMovement( Mobile m, Point3D oldLocation )
		{
			if( m is PlayerMobile )
			{
				if ( DateTime.UtcNow >= m_NextSound && Utility.InRange( m.Location, this.Location, 10 ) )
				{
					if ( Utility.RandomMinMax( 1, 2 ) == 1 )
					{
						m.PlaySound( 0x5C3 );
					}
					m_NextSound = (DateTime.UtcNow + TimeSpan.FromSeconds( 30 ));
				}
			}
		}

		[Constructable]
		public Electrical( ) : base( 0x215D )
		{
			Movable = false;
			Visible = false;
			Name = "lightning crackle";
		}

		public Electrical( Serial serial ) : base( serial )
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);
			writer.Write((int) 0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);
			int version = reader.ReadInt();
		}
	}	
}