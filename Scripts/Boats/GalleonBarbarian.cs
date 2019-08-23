using System;
using Server;
using Server.Items;

namespace Server.Multis
{
	public class GalleonBarbarian : BaseBoat
	{
		public override int NorthID{ get{ return 0x18; } }
		public override int  EastID{ get{ return 0x19; } }
		public override int SouthID{ get{ return 0x1A; } }
		public override int  WestID{ get{ return 0x1B; } }

		public override int HoldDistance{ get{ return 8; } }
		public override int TillerManDistance{ get{ return -8; } }

		public override Point2D StarboardOffset{ get{ return new Point2D(  4, -1 ); } }
		public override Point2D      PortOffset{ get{ return new Point2D( -4, -1 ); } }

		public override Point3D MarkOffset{ get{ return new Point3D( 0, 0, 3 ); } }

		public override BaseDockedBoat DockedBoat{ get{ return new GalleonBarbarianBoat( this ); } }

		[Constructable]
		public GalleonBarbarian()
		{
		}

		public GalleonBarbarian( Serial serial ) : base( serial )
		{
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int)0 );
		}
	}

	public class GalleonBarbarianDeed : BaseBoatDeed
	{
		public override BaseBoat Boat{ get{ return new GalleonBarbarian(); } }

		[Constructable]
		public GalleonBarbarianDeed() : base( 0x18, new Point3D( 0, -1, 0 ) )
		{
			Name = "barbaric ship";
		}

		public GalleonBarbarianDeed( Serial serial ) : base( serial )
		{
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int)0 );
		}
	}

	public class GalleonBarbarianBoat : BaseDockedBoat
	{
		public override BaseBoat Boat{ get{ return new GalleonBarbarian(); } }

		public GalleonBarbarianBoat( BaseBoat boat ) : base( 0x18, new Point3D( 0, -1, 0 ), boat )
		{
		}

		public GalleonBarbarianBoat( Serial serial ) : base( serial )
		{
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int)0 );
		}
	}
}