using System;
using System.Collections.Generic;
using Server;
using Server.Multis;
using Server.Network;

namespace Server.Items
{
	[Furniture]
	[Flipable( 0xC14, 0xC15 )]
	public class NewRuinedBookShelf : BaseContainer
	{
		[Constructable]
		public NewRuinedBookShelf() : base( 0xC14 )
		{
			Name = "ruined book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewRuinedBookShelf( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x19FF, 0x1A00 )]
	public class NewOldBookShelf : BaseContainer
	{
		[Constructable]
		public NewOldBookShelf() : base( 0x19FF )
		{
			Name = "old book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewOldBookShelf( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C43, 0x3C44 )]
	public class NewArmoireA : BaseContainer
	{
		[Constructable]
		public NewArmoireA() : base( 0x3C43 )
		{
			Name = "armoire";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmoireA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C45, 0x3C46 )]
	public class NewArmoireB : BaseContainer
	{
		[Constructable]
		public NewArmoireB() : base( 0x3C45 )
		{
			Name = "armoire";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmoireB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C47, 0x3C48 )]
	public class NewArmoireC : BaseContainer
	{
		[Constructable]
		public NewArmoireC() : base( 0x3C47 )
		{
			Name = "armoire";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmoireC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C89, 0x3C8A )]
	public class NewArmoireD : BaseContainer
	{
		[Constructable]
		public NewArmoireD() : base( 0x3C89 )
		{
			Name = "armoire";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmoireD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x38B, 0x38C )]
	public class NewArmoireE : BaseContainer
	{
		[Constructable]
		public NewArmoireE() : base( 0x38B )
		{
			Name = "armoire";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmoireE( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x38D, 0x38E )]
	public class NewArmoireF : BaseContainer
	{
		[Constructable]
		public NewArmoireF() : base( 0x38D )
		{
			Name = "armoire";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmoireF( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CC9, 0x3CCA )]
	public class NewArmoireG : BaseContainer
	{
		[Constructable]
		public NewArmoireG() : base( 0x3CC9 )
		{
			Name = "armoire";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmoireG( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CCB, 0x3CCC )]
	public class NewArmoireH : BaseContainer
	{
		[Constructable]
		public NewArmoireH() : base( 0x3CCB )
		{
			Name = "armoire";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmoireH( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CCD, 0x3CCE )]
	public class NewArmoireI : BaseContainer
	{
		[Constructable]
		public NewArmoireI() : base( 0x3CCD )
		{
			Name = "armoire";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmoireI( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3D26, 0x3D27 )]
	public class NewArmoireJ : BaseContainer
	{
		[Constructable]
		public NewArmoireJ() : base( 0x3D26 )
		{
			Name = "armoire";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmoireJ( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3BF1, 0x3BF2 )]
	public class NewArmorShelfA : BaseContainer
	{
		[Constructable]
		public NewArmorShelfA() : base( 0x3BF1 )
		{
			Name = "armor shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmorShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C31, 0x3C32 )]
	public class NewArmorShelfB : BaseContainer
	{
		[Constructable]
		public NewArmorShelfB() : base( 0x3C31 )
		{
			Name = "armor shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmorShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C63, 0x3C64 )]
	public class NewArmorShelfC : BaseContainer
	{
		[Constructable]
		public NewArmorShelfC() : base( 0x3C63 )
		{
			Name = "armor shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmorShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CAD, 0x3CAE )]
	public class NewArmorShelfD : BaseContainer
	{
		[Constructable]
		public NewArmorShelfD() : base( 0x3CAD )
		{
			Name = "armor shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmorShelfD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CEF, 0x3CF0 )]
	public class NewArmorShelfE : BaseContainer
	{
		[Constructable]
		public NewArmorShelfE() : base( 0x3CEF )
		{
			Name = "armor shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewArmorShelfE( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C3B, 0x3C3C )]
	public class NewBakerShelfA : BaseContainer
	{
		[Constructable]
		public NewBakerShelfA() : base( 0x3C3B )
		{
			Name = "baker shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBakerShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C65, 0x3C66 )]
	public class NewBakerShelfB : BaseContainer
	{
		[Constructable]
		public NewBakerShelfB() : base( 0x3C65 )
		{
			Name = "baker shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBakerShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C67, 0x3C68 )]
	public class NewBakerShelfC : BaseContainer
	{
		[Constructable]
		public NewBakerShelfC() : base( 0x3C67 )
		{
			Name = "baker shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBakerShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CBF, 0x3CC0 )]
	public class NewBakerShelfD : BaseContainer
	{
		[Constructable]
		public NewBakerShelfD() : base( 0x3CBF )
		{
			Name = "baker shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBakerShelfD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CC1, 0x3CC2 )]
	public class NewBakerShelfE : BaseContainer
	{
		[Constructable]
		public NewBakerShelfE() : base( 0x3CC1 )
		{
			Name = "baker shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBakerShelfE( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CF1, 0x3CF2 )]
	public class NewBakerShelfF : BaseContainer
	{
		[Constructable]
		public NewBakerShelfF() : base( 0x3CF1 )
		{
			Name = "baker shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBakerShelfF( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CF3, 0x3CF4 )]
	public class NewBakerShelfG : BaseContainer
	{
		[Constructable]
		public NewBakerShelfG() : base( 0x3CF3 )
		{
			Name = "baker shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBakerShelfG( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C41, 0x3C42 )]
	public class NewBlacksmithShelfA : BaseContainer
	{
		[Constructable]
		public NewBlacksmithShelfA() : base( 0x3C41 )
		{
			Name = "blacksmith shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBlacksmithShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C4B, 0x3C4C )]
	public class NewBlacksmithShelfB : BaseContainer
	{
		[Constructable]
		public NewBlacksmithShelfB() : base( 0x3C4B )
		{
			Name = "blacksmith shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBlacksmithShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C6B, 0x3C6C )]
	public class NewBlacksmithShelfC : BaseContainer
	{
		[Constructable]
		public NewBlacksmithShelfC() : base( 0x3C6B )
		{
			Name = "blacksmith shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBlacksmithShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CC5, 0x3CC6 )]
	public class NewBlacksmithShelfD : BaseContainer
	{
		[Constructable]
		public NewBlacksmithShelfD() : base( 0x3CC5 )
		{
			Name = "blacksmith shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBlacksmithShelfD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CF7, 0x3CF8 )]
	public class NewBlacksmithShelfE : BaseContainer
	{
		[Constructable]
		public NewBlacksmithShelfE() : base( 0x3CF7 )
		{
			Name = "blacksmith shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBlacksmithShelfE( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C15, 0x3C16 )]
	public class NewBookShelfA : BaseContainer
	{
		[Constructable]
		public NewBookShelfA() : base( 0x3C15 )
		{
			Name = "book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBookShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C2B, 0x3C2C )]
	public class NewBookShelfB : BaseContainer
	{
		[Constructable]
		public NewBookShelfB() : base( 0x3C2B )
		{
			Name = "book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBookShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C2D, 0x3C2E )]
	public class NewBookShelfC : BaseContainer
	{
		[Constructable]
		public NewBookShelfC() : base( 0x3C2D )
		{
			Name = "book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBookShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C33, 0x3C34 )]
	public class NewBookShelfD : BaseContainer
	{
		[Constructable]
		public NewBookShelfD() : base( 0x3C33 )
		{
			Name = "book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBookShelfD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C5F, 0x3C60 )]
	public class NewBookShelfE : BaseContainer
	{
		[Constructable]
		public NewBookShelfE() : base( 0x3C5F )
		{
			Name = "book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBookShelfE( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C61, 0x3C62 )]
	public class NewBookShelfF : BaseContainer
	{
		[Constructable]
		public NewBookShelfF() : base( 0x3C61 )
		{
			Name = "book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBookShelfF( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C79, 0x3C7A )]
	public class NewBookShelfG : BaseContainer
	{
		[Constructable]
		public NewBookShelfG() : base( 0x3C79 )
		{
			Name = "book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBookShelfG( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CA5, 0x3CA6 )]
	public class NewBookShelfH : BaseContainer
	{
		[Constructable]
		public NewBookShelfH() : base( 0x3CA5 )
		{
			Name = "book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBookShelfH( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CA7, 0x3CA8 )]
	public class NewBookShelfI : BaseContainer
	{
		[Constructable]
		public NewBookShelfI() : base( 0x3CA7 )
		{
			Name = "book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBookShelfI( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CAF, 0x3CB0 )]
	public class NewBookShelfJ : BaseContainer
	{
		[Constructable]
		public NewBookShelfJ() : base( 0x3CAF )
		{
			Name = "book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBookShelfJ( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CEB, 0x3CEC )]
	public class NewBookShelfK : BaseContainer
	{
		[Constructable]
		public NewBookShelfK() : base( 0x3CEB )
		{
			Name = "book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBookShelfK( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CED, 0x3CEE )]
	public class NewBookShelfL : BaseContainer
	{
		[Constructable]
		public NewBookShelfL() : base( 0x3CED )
		{
			Name = "book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBookShelfL( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3D05, 0x3D06 )]
	public class NewBookShelfM : BaseContainer
	{
		[Constructable]
		public NewBookShelfM() : base( 0x3D05 )
		{
			Name = "book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBookShelfM( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C29, 0x3C2A )]
	public class NewBowyerShelfA : BaseContainer
	{
		[Constructable]
		public NewBowyerShelfA() : base( 0x3C29 )
		{
			Name = "bowyer shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBowyerShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C5D, 0x3C5E )]
	public class NewBowyerShelfB : BaseContainer
	{
		[Constructable]
		public NewBowyerShelfB() : base( 0x3C5D )
		{
			Name = "bowyer shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBowyerShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CA3, 0x3CA4 )]
	public class NewBowyerShelfC : BaseContainer
	{
		[Constructable]
		public NewBowyerShelfC() : base( 0x3CA3 )
		{
			Name = "bowyer shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBowyerShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CE9, 0x3CEA )]
	public class NewBowyerShelfD : BaseContainer
	{
		[Constructable]
		public NewBowyerShelfD() : base( 0x3CE9 )
		{
			Name = "bowyer shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewBowyerShelfD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C6F, 0x3C70 )]
	public class NewCarpenterShelfA : BaseContainer
	{
		[Constructable]
		public NewCarpenterShelfA() : base( 0x3C6F )
		{
			Name = "carpenter shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewCarpenterShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CD7, 0x3CD8 )]
	public class NewCarpenterShelfB : BaseContainer
	{
		[Constructable]
		public NewCarpenterShelfB() : base( 0x3CD7 )
		{
			Name = "carpenter shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewCarpenterShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CFB, 0x3CFC )]
	public class NewCarpenterShelfC : BaseContainer
	{
		[Constructable]
		public NewCarpenterShelfC() : base( 0x3CFB )
		{
			Name = "carpenter shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewCarpenterShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C51, 0x3C52 )]
	public class NewClothShelfA : BaseContainer
	{
		[Constructable]
		public NewClothShelfA() : base( 0x3C51 )
		{
			Name = "cloth shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewClothShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C53, 0x3C54 )]
	public class NewClothShelfB : BaseContainer
	{
		[Constructable]
		public NewClothShelfB() : base( 0x3C53 )
		{
			Name = "cloth shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewClothShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C75, 0x3C76 )]
	public class NewClothShelfC : BaseContainer
	{
		[Constructable]
		public NewClothShelfC() : base( 0x3C75 )
		{
			Name = "cloth shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewClothShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C77, 0x3C78 )]
	public class NewClothShelfD : BaseContainer
	{
		[Constructable]
		public NewClothShelfD() : base( 0x3C77 )
		{
			Name = "cloth shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewClothShelfD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CDD, 0x3CDE )]
	public class NewClothShelfE : BaseContainer
	{
		[Constructable]
		public NewClothShelfE() : base( 0x3CDD )
		{
			Name = "cloth shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewClothShelfE( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CDF, 0x3CE0 )]
	public class NewClothShelfF : BaseContainer
	{
		[Constructable]
		public NewClothShelfF() : base( 0x3CDF )
		{
			Name = "cloth shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewClothShelfF( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CFF, 0x3D00 )]
	public class NewClothShelfG : BaseContainer
	{
		[Constructable]
		public NewClothShelfG() : base( 0x3CFF )
		{
			Name = "cloth shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewClothShelfG( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3D01, 0x3D02 )]
	public class NewClothShelfH : BaseContainer
	{
		[Constructable]
		public NewClothShelfH() : base( 0x3D01 )
		{
			Name = "cloth shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewClothShelfH( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3BF9, 0x3BFA )]
	public class NewDarkBookShelfA : BaseContainer
	{
		[Constructable]
		public NewDarkBookShelfA() : base( 0x3BF9 )
		{
			Name = "dark book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDarkBookShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3BFB, 0x3BFC )]
	public class NewDarkBookShelfB : BaseContainer
	{
		[Constructable]
		public NewDarkBookShelfB() : base( 0x3BFB )
		{
			Name = "dark book shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDarkBookShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3BFD, 0x3BFE )]
	public class NewDarkShelf : BaseContainer
	{
		[Constructable]
		public NewDarkShelf() : base( 0x3BFD )
		{
			Name = "dark shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDarkShelf( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C7F, 0x3C80 )]
	public class NewDrawersA : BaseContainer
	{
		[Constructable]
		public NewDrawersA() : base( 0x3C7F )
		{
			Name = "drawers";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrawersA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C81, 0x3C82 )]
	public class NewDrawersB : BaseContainer
	{
		[Constructable]
		public NewDrawersB() : base( 0x3C81 )
		{
			Name = "drawers";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrawersB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C83, 0x3C84 )]
	public class NewDrawersC : BaseContainer
	{
		[Constructable]
		public NewDrawersC() : base( 0x3C83 )
		{
			Name = "drawers";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrawersC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C85, 0x3C86 )]
	public class NewDrawersD : BaseContainer
	{
		[Constructable]
		public NewDrawersD() : base( 0x3C85 )
		{
			Name = "drawers";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrawersD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C87, 0x3C88 )]
	public class NewDrawersE : BaseContainer
	{
		[Constructable]
		public NewDrawersE() : base( 0x3C87 )
		{
			Name = "drawers";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrawersE( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CB5, 0x3CB6 )]
	public class NewDrawersF : BaseContainer
	{
		[Constructable]
		public NewDrawersF() : base( 0x3CB5 )
		{
			Name = "drawers";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrawersF( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CB7, 0x3CB8 )]
	public class NewDrawersG : BaseContainer
	{
		[Constructable]
		public NewDrawersG() : base( 0x3CB7 )
		{
			Name = "drawers";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrawersG( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CB9, 0x3CBA )]
	public class NewDrawersH : BaseContainer
	{
		[Constructable]
		public NewDrawersH() : base( 0x3CB9 )
		{
			Name = "drawers";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrawersH( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CBB, 0x3CBC )]
	public class NewDrawersI : BaseContainer
	{
		[Constructable]
		public NewDrawersI() : base( 0x3CBB )
		{
			Name = "drawers";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrawersI( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CBD, 0x3CBE )]
	public class NewDrawersJ : BaseContainer
	{
		[Constructable]
		public NewDrawersJ() : base( 0x3CBD )
		{
			Name = "drawers";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrawersJ( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3D0B, 0x3D0C )]
	public class NewDrawersK : BaseContainer
	{
		[Constructable]
		public NewDrawersK() : base( 0x3D0B )
		{
			Name = "drawers";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrawersK( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3D20, 0x3D21 )]
	public class NewDrawersL : BaseContainer
	{
		[Constructable]
		public NewDrawersL() : base( 0x3D20 )
		{
			Name = "drawers";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrawersL( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3D22, 0x3D23 )]
	public class NewDrawersM : BaseContainer
	{
		[Constructable]
		public NewDrawersM() : base( 0x3D22 )
		{
			Name = "drawers";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrawersM( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3D24, 0x3D25 )]
	public class NewDrawersN : BaseContainer
	{
		[Constructable]
		public NewDrawersN() : base( 0x3D24 )
		{
			Name = "drawers";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrawersN( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C27, 0x3C28 )]
	public class NewDrinkShelfA : BaseContainer
	{
		[Constructable]
		public NewDrinkShelfA() : base( 0x3C27 )
		{
			Name = "drink shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrinkShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C5B, 0x3C5C )]
	public class NewDrinkShelfB : BaseContainer
	{
		[Constructable]
		public NewDrinkShelfB() : base( 0x3C5B )
		{
			Name = "drink shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrinkShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CA1, 0x3CA2 )]
	public class NewDrinkShelfC : BaseContainer
	{
		[Constructable]
		public NewDrinkShelfC() : base( 0x3CA1 )
		{
			Name = "drink shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrinkShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CE7, 0x3CE8 )]
	public class NewDrinkShelfD : BaseContainer
	{
		[Constructable]
		public NewDrinkShelfD() : base( 0x3CE7 )
		{
			Name = "drink shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrinkShelfD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C1B, 0x3C1C )]
	public class NewDrinkShelfE : BaseContainer
	{
		[Constructable]
		public NewDrinkShelfE() : base( 0x3C1B )
		{
			Name = "liquor shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewDrinkShelfE( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3BFF, 0x3C00 )]
	public class NewHelmShelf : BaseContainer
	{
		[Constructable]
		public NewHelmShelf() : base( 0x3BFF )
		{
			Name = "helm shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewHelmShelf( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C4D, 0x3C4E )]
	public class NewHunterShelf : BaseContainer
	{
		[Constructable]
		public NewHunterShelf() : base( 0x3C4D )
		{
			Name = "hunter shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewHunterShelf( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C19, 0x3C1A )]
	public class NewKitchenShelfA : BaseContainer
	{
		[Constructable]
		public NewKitchenShelfA() : base( 0x3C19 )
		{
			Name = "kitchen shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewKitchenShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C39, 0x3C3A )]
	public class NewKitchenShelfB : BaseContainer
	{
		[Constructable]
		public NewKitchenShelfB() : base( 0x3C39 )
		{
			Name = "kitchen shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewKitchenShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3BF3, 0x3BF4 )]
	public class NewPotionShelf : BaseContainer
	{
		[Constructable]
		public NewPotionShelf() : base( 0x3BF3 )
		{
			Name = "potion shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewPotionShelf( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C35, 0x3C36 )]
	public class NewShelfA : BaseContainer
	{
		[Constructable]
		public NewShelfA() : base( 0x3C35 )
		{
			Name = "shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C3D, 0x3C3E )]
	public class NewShelfB : BaseContainer
	{
		[Constructable]
		public NewShelfB() : base( 0x3C3D )
		{
			Name = "shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C69, 0x3C6A )]
	public class NewShelfC : BaseContainer
	{
		[Constructable]
		public NewShelfC() : base( 0x3C69 )
		{
			Name = "shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C7B, 0x3C7C )]
	public class NewShelfD : BaseContainer
	{
		[Constructable]
		public NewShelfD() : base( 0x3C7B )
		{
			Name = "shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewShelfD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CB1, 0x3CB2 )]
	public class NewShelfE : BaseContainer
	{
		[Constructable]
		public NewShelfE() : base( 0x3CB1 )
		{
			Name = "shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewShelfE( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CC3, 0x3CC4 )]
	public class NewShelfF : BaseContainer
	{
		[Constructable]
		public NewShelfF() : base( 0x3CC3 )
		{
			Name = "shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewShelfF( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CF5, 0x3CF6 )]
	public class NewShelfG : BaseContainer
	{
		[Constructable]
		public NewShelfG() : base( 0x3CF5 )
		{
			Name = "shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewShelfG( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3D07, 0x3D08 )]
	public class NewShelfH : BaseContainer
	{
		[Constructable]
		public NewShelfH() : base( 0x3D07 )
		{
			Name = "shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewShelfH( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C37, 0x3C38 )]
	public class NewShoeShelfA : BaseContainer
	{
		[Constructable]
		public NewShoeShelfA() : base( 0x3C37 )
		{
			Name = "shoe shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewShoeShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C7D, 0x3C7E )]
	public class NewShoeShelfB : BaseContainer
	{
		[Constructable]
		public NewShoeShelfB() : base( 0x3C7D )
		{
			Name = "shoe shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewShoeShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CB3, 0x3CB4 )]
	public class NewShoeShelfC : BaseContainer
	{
		[Constructable]
		public NewShoeShelfC() : base( 0x3CB3 )
		{
			Name = "shoe shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewShoeShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3D09, 0x3D0A )]
	public class NewShoeShelfD : BaseContainer
	{
		[Constructable]
		public NewShoeShelfD() : base( 0x3D09 )
		{
			Name = "shoe shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewShoeShelfD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C4F, 0x3C50 )]
	public class NewSorcererShelfA : BaseContainer
	{
		[Constructable]
		public NewSorcererShelfA() : base( 0x3C4F )
		{
			Name = "sorcerer shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewSorcererShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C73, 0x3C74 )]
	public class NewSorcererShelfB : BaseContainer
	{
		[Constructable]
		public NewSorcererShelfB() : base( 0x3C73 )
		{
			Name = "sorcerer shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewSorcererShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CDB, 0x3CDC )]
	public class NewSorcererShelfC : BaseContainer
	{
		[Constructable]
		public NewSorcererShelfC() : base( 0x3CDB )
		{
			Name = "sorcerer shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewSorcererShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CFD, 0x3CFE )]
	public class NewSorcererShelfD : BaseContainer
	{
		[Constructable]
		public NewSorcererShelfD() : base( 0x3CFD )
		{
			Name = "sorcerer shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewSorcererShelfD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C57, 0x3C58 )]
	public class NewSupplyShelfA : BaseContainer
	{
		[Constructable]
		public NewSupplyShelfA() : base( 0x3C57 )
		{
			Name = "supply shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewSupplyShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C9D, 0x3C9E )]
	public class NewSupplyShelfB : BaseContainer
	{
		[Constructable]
		public NewSupplyShelfB() : base( 0x3C9D )
		{
			Name = "supply shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewSupplyShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CE3, 0x3CE4 )]
	public class NewSupplyShelfC : BaseContainer
	{
		[Constructable]
		public NewSupplyShelfC() : base( 0x3CE3 )
		{
			Name = "supply shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewSupplyShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C3F, 0x3C40 )]
	public class NewTailorShelfA : BaseContainer
	{
		[Constructable]
		public NewTailorShelfA() : base( 0x3C3F )
		{
			Name = "tailor shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewTailorShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C6D, 0x3C6E )]
	public class NewTailorShelfB : BaseContainer
	{
		[Constructable]
		public NewTailorShelfB() : base( 0x3C6D )
		{
			Name = "tailor shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewTailorShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CC7, 0x3CC8 )]
	public class NewTailorShelfC : BaseContainer
	{
		[Constructable]
		public NewTailorShelfC() : base( 0x3CC7 )
		{
			Name = "tailor shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewTailorShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CF9, 0x3CFA )]
	public class NewTailorShelfD : BaseContainer
	{
		[Constructable]
		public NewTailorShelfD() : base( 0x3CF9 )
		{
			Name = "tailor shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewTailorShelfD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C23, 0x3C24 )]
	public class NewTannerShelfA : BaseContainer
	{
		[Constructable]
		public NewTannerShelfA() : base( 0x3C23 )
		{
			Name = "tanner shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewTannerShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C49, 0x3C4A )]
	public class NewTannerShelfB : BaseContainer
	{
		[Constructable]
		public NewTannerShelfB() : base( 0x3C49 )
		{
			Name = "tanner shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewTannerShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C25, 0x3C26 )]
	public class NewTavernShelfC : BaseContainer
	{
		[Constructable]
		public NewTavernShelfC() : base( 0x3C25 )
		{
			Name = "tavern shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewTavernShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C59, 0x3C5A )]
	public class NewTavernShelfD : BaseContainer
	{
		[Constructable]
		public NewTavernShelfD() : base( 0x3C59 )
		{
			Name = "tavern shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewTavernShelfD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C9F, 0x3CA0 )]
	public class NewTavernShelfE : BaseContainer
	{
		[Constructable]
		public NewTavernShelfE() : base( 0x3C9F )
		{
			Name = "tavern shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewTavernShelfE( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CE5, 0x3CE6 )]
	public class NewTavernShelfF : BaseContainer
	{
		[Constructable]
		public NewTavernShelfF() : base( 0x3CE5 )
		{
			Name = "tavern shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewTavernShelfF( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C71, 0x3C72 )]
	public class NewTinkerShelfA : BaseContainer
	{
		[Constructable]
		public NewTinkerShelfA() : base( 0x3C71 )
		{
			Name = "tinker shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewTinkerShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CD9, 0x3CDA )]
	public class NewTinkerShelfB : BaseContainer
	{
		[Constructable]
		public NewTinkerShelfB() : base( 0x3CD9 )
		{
			Name = "tinker shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewTinkerShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3D03, 0x3D04 )]
	public class NewTinkerShelfC : BaseContainer
	{
		[Constructable]
		public NewTinkerShelfC() : base( 0x3D03 )
		{
			Name = "tinker shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewTinkerShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C2F, 0x3C30 )]
	public class NewTortureShelf : BaseContainer
	{
		[Constructable]
		public NewTortureShelf() : base( 0x3C2F )
		{
			Name = "torture shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewTortureShelf( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C17, 0x3C18 )]
	public class NewWizardShelfA : BaseContainer
	{
		[Constructable]
		public NewWizardShelfA() : base( 0x3C17 )
		{
			Name = "wizard shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewWizardShelfA( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C1D, 0x3C1E )]
	public class NewWizardShelfB : BaseContainer
	{
		[Constructable]
		public NewWizardShelfB() : base( 0x3C1D )
		{
			Name = "wizard shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewWizardShelfB( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C21, 0x3C22 )]
	public class NewWizardShelfC : BaseContainer
	{
		[Constructable]
		public NewWizardShelfC() : base( 0x3C21 )
		{
			Name = "wizard shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewWizardShelfC( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C55, 0x3C56 )]
	public class NewWizardShelfD : BaseContainer
	{
		[Constructable]
		public NewWizardShelfD() : base( 0x3C55 )
		{
			Name = "wizard shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewWizardShelfD( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3C9B, 0x3C9C )]
	public class NewWizardShelfE : BaseContainer
	{
		[Constructable]
		public NewWizardShelfE() : base( 0x3C9B )
		{
			Name = "wizard shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewWizardShelfE( Serial serial ) : base( serial )
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

//// ------------------------------------------------------------------------------------------------

	[Furniture]
	[Flipable( 0x3CE1, 0x3CE2 )]
	public class NewWizardShelfF : BaseContainer
	{
		[Constructable]
		public NewWizardShelfF() : base( 0x3CE1 )
		{
			Name = "wizard shelf";
			Weight = 10.0;
			GumpID = 0x987;
		}

		public NewWizardShelfF( Serial serial ) : base( serial )
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