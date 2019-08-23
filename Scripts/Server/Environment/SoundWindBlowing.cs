using System;
using Server.Items;
using Server.Network;
using Server.Mobiles;

namespace Server.Items
{
    public class SoundWindBlowing : Item
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
						int sound = Utility.RandomList( 0x014, 0x015, 0x016, 0x565, 0x566, 0x567, 0x654 );
						m.PlaySound( sound );
					}
					m_NextSound = (DateTime.Now + TimeSpan.FromSeconds( 60 ));
				}
			}
		}

		[Constructable]
		public SoundWindBlowing( ) : base( 0x215D )
		{
			Movable = false;
			Visible = false;
			Name = "sound of wind";
		}

		public SoundWindBlowing( Serial serial ) : base( serial )
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