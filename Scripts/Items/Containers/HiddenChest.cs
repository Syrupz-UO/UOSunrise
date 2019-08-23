using System;
using Server;
using Server.Network;
using Server.Mobiles;
using Server.Items;
using Server.Spells;
using System.Collections.Generic;
using Server.Misc;
using System.Collections;
using Server.Regions;

namespace Server.Items
{
	public class HiddenChest : Item
	{
		[Constructable]
		public HiddenChest() : base(0x2163)
		{
			Movable = false;
			Name = "a hidden chest";
			Visible = false;
		}

		public HiddenChest(Serial serial) : base(serial)
		{
		}

		public override bool OnMoveOver( Mobile m )
		{
			if ( m is PlayerMobile && m.AccessLevel == AccessLevel.Player && !m.Blessed )
			{
				if ( m.Alive && m.CheckSkill( SkillName.DetectHidden, 0, 100 ) )
				{
					m.LocalOverheadMessage(Network.MessageType.Emote, 0x3B2, false, "Your eye catches something nearby.");
					Map map = m.Map;
					string where = Server.Misc.Worlds.GetRegionName( m.Map, m.Location );

					int money = Utility.RandomMinMax( 100, 200 );

					int level = (int)(m.Skills[SkillName.DetectHidden].Value / 10);
						if (level < 1){level = 1;}
						if (level > 10){level = 10;}

					switch( Utility.RandomMinMax( 1, level ) )
					{
						case 1: level = 1; break;
						case 2: level = 2; break;
						case 3: level = 3; break;
						case 4: level = 4; break;
						case 5: level = 5; break;
						case 6: level = 6; break;
						case 7: level = 7; break;
						case 8: level = 8; break;
						case 9: level = 9; break;
						case 10: level = 10; break;
					}

					if ( Utility.RandomMinMax( 1, 3 ) > 1 )
					{
						Gold coins = new Gold( ( money * level ) );

						bool validLocation = false;
						Point3D loc = this.Location;

						for ( int j = 0; !validLocation && j < 10; ++j )
						{
							int x = X + Utility.Random( 3 ) - 1;
							int y = Y + Utility.Random( 3 ) - 1;
							int z = map.GetAverageZ( x, y );

							if ( validLocation = map.CanFit( x, y, this.Z, 16, false, false ) )
								loc = new Point3D( x, y, Z );
							else if ( validLocation = map.CanFit( x, y, z, 16, false, false ) )
								loc = new Point3D( x, y, z );
						}

						coins.MoveToWorld( loc, map );
						Effects.SendLocationParticles( EffectItem.Create( coins.Location, coins.Map, EffectItem.DefaultDuration ), 0x376A, 9, 32, 5024 );
						Effects.PlaySound( coins.Location, coins.Map, 0x1FA );
					}
					else
					{
						HiddenBox mBox = new HiddenBox( level, where, m );

						bool validLocation = false;
						Point3D loc = this.Location;

						for ( int j = 0; !validLocation && j < 10; ++j )
						{
							int x = X + Utility.Random( 3 ) - 1;
							int y = Y + Utility.Random( 3 ) - 1;
							int z = map.GetAverageZ( x, y );

							if ( validLocation = map.CanFit( x, y, this.Z, 16, false, false ) )
								loc = new Point3D( x, y, Z );
							else if ( validLocation = map.CanFit( x, y, z, 16, false, false ) )
								loc = new Point3D( x, y, z );
						}

						mBox.MoveToWorld( loc, map );
						Effects.SendLocationParticles( EffectItem.Create( mBox.Location, mBox.Map, EffectItem.DefaultDuration ), 0x376A, 9, 32, 5024 );
						Effects.PlaySound( mBox.Location, mBox.Map, 0x1FA );
					}
				}
			}

			this.Delete();
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