using System;
using Server;
using Server.Items;

namespace Items
{
	public class BagOfStorageKeys : KeyBag
	{
		[Constructable]
		public BagOfStorageKeys()
		{
			Hue = 0x20;
			PlaceItemIn( 30, 35, new AddonDeedKey() );
			PlaceItemIn( 50, 35, new AdventurerKey() );
			PlaceItemIn( 70, 35, new ArmorKey() );
			PlaceItemIn( 90, 35, new ArmoryKey() );
			PlaceItemIn( 30, 55, new BardsKey() );
			PlaceItemIn( 30, 35, new BODKey() );
			PlaceItemIn( 50, 35, new ChampSkullKey() );
			PlaceItemIn( 70, 35, new ChefKey() );
			PlaceItemIn( 90, 35, new ClothingKey() );
			PlaceItemIn( 30, 55, new IngotKey() );
			PlaceItemIn( 30, 35, new FishKey() );
			PlaceItemIn( 50, 35, new JewelryKey() );
			PlaceItemIn( 70, 35, new PotionKey() );
			PlaceItemIn( 90, 35, new PSKey() );
			PlaceItemIn( 30, 55, new ReagentKey () );
			PlaceItemIn( 30, 35, new ToolKey() );
			PlaceItemIn( 50, 35, new WeaponKey() );
			PlaceItemIn( 70, 35, new PetKey() );
			PlaceItemIn( 70, 35, new  MasterItemStoreKey() );
			
		}

		public BagOfStorageKeys( Serial serial ) : base( serial )
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