using System;
using Server.Items;
using Server.Network;
using Server.Mobiles;

namespace Server.Items
{
    public class ComputerConsole : Item
	{
		public override bool HandlesOnMovement{ get{ return true; } }

		private DateTime m_NextSound;
		public DateTime NextSound{ get{ return m_NextSound; } set{ m_NextSound = value; } }

		public override void OnMovement( Mobile m, Point3D oldLocation )
		{
			if( m is PlayerMobile )
			{
				if ( DateTime.Now >= m_NextSound && Utility.InRange( m.Location, this.Location, 10 ) )
				{
					if ( Utility.RandomMinMax( 1, 4 ) == 1 )
					{
						m.PlaySound( 0x54C );
					}
					m_NextSound = (DateTime.Now + TimeSpan.FromSeconds( 60 ));
				}
			}
		}

		[Constructable]
		public ComputerConsole( ) : base( 0x215D )
		{
			Movable = false;
			Visible = false;
			Name = "lightning crackle";
		}

		public ComputerConsole( Serial serial ) : base( serial )
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