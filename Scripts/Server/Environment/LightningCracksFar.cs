using System;
using Server.Items;
using Server.Network;
using Server.Mobiles;

namespace Server.Items
{
    public class LightningCracksFar : Item
	{
		public override bool HandlesOnMovement{ get{ return true; } }

		private DateTime m_NextSound;
		public DateTime NextSound{ get{ return m_NextSound; } set{ m_NextSound = value; } }

		public override void OnMovement( Mobile m, Point3D oldLocation )
		{
			if( m is PlayerMobile )
			{
				if ( DateTime.Now >= m_NextSound && Utility.InRange( m.Location, this.Location, 15 ) )
				{
					if ( Utility.RandomMinMax( 1, 4 ) == 1 )
					{
						Point3D bolt = new Point3D( ( this.X ), ( this.Y ), ( this.Z+5 ) );
						int sound = Utility.RandomList( 0x028, 0x029 );
						Effects.SendLocationEffect( bolt, m.Map, 0x2A4E, 30, 10, 0, 0 );
						m.PlaySound( sound );
					}
					m_NextSound = (DateTime.Now + TimeSpan.FromSeconds( 60 ));
				}
			}
		}

		[Constructable]
		public LightningCracksFar( ) : base( 0x215D )
		{
			Movable = false;
			Visible = false;
			Name = "lightning crackle";
		}

		public LightningCracksFar( Serial serial ) : base( serial )
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