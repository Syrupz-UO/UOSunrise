using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class BagOfAlchemicReagents : Bag
	{
		[Constructable]
		public BagOfAlchemicReagents() : this( 50 )
		{
		}

		[Constructable]
		public BagOfAlchemicReagents( int amount )
		{
			DropItem( new BlackPearl( amount ) );
			DropItem( new Bloodmoss( amount ) );
			DropItem( new Garlic( amount ) );
			DropItem( new Ginseng( amount ) );
			DropItem( new MandrakeRoot( amount ) );
			DropItem( new Nightshade( amount ) );
			DropItem( new SulfurousAsh( amount ) );
			DropItem( new SpidersSilk( amount ) );
			DropItem( new Brimstone( amount ) );
			DropItem( new ButterflyWings( amount ) );
			DropItem( new EyeOfToad( amount ) );
			DropItem( new FairyEgg( amount ) );
			DropItem( new GargoyleEar( amount ) );
			DropItem( new BeetleShell( amount ) );
			DropItem( new MoonCrystal( amount ) );
			DropItem( new PixieSkull( amount ) );
			DropItem( new RedLotus( amount ) );
			DropItem( new SeaSalt( amount ) );
			DropItem( new SilverWidow( amount ) );
			DropItem( new SwampBerries( amount ) );
		}

		public BagOfAlchemicReagents( Serial serial ) : base( serial )
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