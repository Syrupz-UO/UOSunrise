using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;							//for connection to resource store data objects
using Server.Engines.VeteranRewards;
using Server.Engines.Plants;

namespace Server.Items
{
    //item inherited from BaseResourceKey
    public class ChefKey : BaseStoreKey, IRewardItem
    {
        private bool m_IsRewardItem;

        [CommandProperty(AccessLevel.Seer)]
        public bool IsRewardItem
        {
            get { return m_IsRewardItem; }
            set { m_IsRewardItem = value; InvalidateProperties(); }
        }

        public override int DisplayColumns { get { return 3; } }

        public override List<StoreEntry> EntryStructure
        {
            get
            {
                List<StoreEntry> entry = base.EntryStructure;

					//TODO: this may need some fixing up
					
				entry.Add( new ResourceEntry( typeof( FertileDirt ), "Fertile Dirt", 0, 25, 0, 0  ) );
				entry.Add( new ListEntry( typeof( Seed ), typeof( SeedListEntry ), "Seeds" ) );
				
				
				
				//note: need harvest system for this
				
				entry.Add( new ColumnSeparationEntry() );
			/*	entry.Add( new ResourceEntry( typeof( CabbageSeed ), "Cabbage Seed" ) );
				entry.Add( new ResourceEntry( typeof( CarrotSeed ), "Carrot Seed" ) );
				entry.Add( new ResourceEntry( typeof( CornSeed ), "Corn Seed" ) );
				entry.Add( new ResourceEntry( typeof( CottonSeed ), "Cotton Seed" ) );
				entry.Add( new ResourceEntry( typeof( FlaxSeed ), "Flax Seed" ) );
				entry.Add( new ResourceEntry( typeof( GarlicSeed ), "Garlic Seed" ) );
				entry.Add( new ResourceEntry( typeof( LettuceSeed ), "Lettuce Seed" ) );
				entry.Add( new ResourceEntry( typeof( OnionSeed ), "Onion Seed" ) );
				entry.Add( new ResourceEntry( typeof( WheatSeed ), "Wheat Seed" ) );
	*/
				entry.Add( new BeverageEntry( typeof( Pitcher ), BeverageType.Water, "Water", 0, 20, -3, 0 ) );	
				entry.Add( new ResourceEntry( typeof( Pitcher ), "Empty Pitcher", 0, 20, -3, 0 ) );
				entry.Add( new BeverageEntry( typeof( Pitcher ), BeverageType.Ale, "Ale", 0, 20, -3, 0 ) );
				entry.Add( new BeverageEntry( typeof( Pitcher ), BeverageType.Cider, "Cider", 0, 20, -3, 0 ) );
				entry.Add( new BeverageEntry( typeof( Pitcher ), BeverageType.Liquor, "Liquor", 0, 20, -3, 0 ) );
				entry.Add( new BeverageEntry( typeof( Pitcher ), BeverageType.Milk, "Milk", 0, 20, -3, 0 ) );
				entry.Add( new BeverageEntry( typeof( Pitcher ), BeverageType.Water, "Water", 0, 20, -3, 0 ) );
				entry.Add( new BeverageEntry( typeof( Pitcher ), BeverageType.Wine, "Wine", 0, 20, -3, 0 ) );
				entry.Add( new ResourceEntry( typeof( RawRibs ), "Raw Ribs" ) );
				entry.Add( new ResourceEntry( typeof( RawBird ), "Raw Bird" ) );
				entry.Add( new ResourceEntry( typeof( RawChickenLeg ), "Raw Chicken Leg" ) );
				entry.Add( new ResourceEntry( typeof( RawLambLeg ), "Raw Lamb Leg" ) );
				entry.Add( new ResourceEntry( typeof( RawFishSteak ), "Raw Fishsteak" ) );
				entry.Add( new ResourceEntry( typeof( Sausage ), "Sausage" ) );
				entry.Add( new ResourceEntry( typeof( Ribs ), "Ribs" ) );
				entry.Add( new ResourceEntry( typeof( CookedBird ), "Bird" ) );
				entry.Add( new ResourceEntry( typeof( ChickenLeg ), "Chicken Leg" ) );
				entry.Add( new ResourceEntry( typeof( LambLeg ), "Lamb Leg" ) );
				entry.Add( new ResourceEntry( typeof( FishSteak ), "Fishsteak" ) );
				
                entry.Add(new ResourceEntry(typeof(SackFlour),"Flour",0,25,0,0));
                entry.Add(new ResourceEntry(typeof(Eggs),"Eggs"));
				entry.Add(new ResourceEntry(typeof(JarHoney),"Jar of Honey"));
				entry.Add(new BeverageEntry(typeof(Pitcher),BeverageType.Water,"Water",0,20,-3,0));                
				entry.Add(new ResourceEntry(typeof(Dough),"Dough"));                
				entry.Add(new ResourceEntry(typeof(SweetDough),"Sweet Dough"));
                entry.Add(new ResourceEntry(typeof(CakeMix),"Cake Mix"));
                entry.Add(new ResourceEntry(typeof(CookieMix),"Cookie Mix"));
                entry.Add(new ResourceEntry(typeof(Apple),"Apple"));
                entry.Add(new ResourceEntry(typeof(Pear),"Pear"));
                entry.Add(new ResourceEntry(typeof(Peach),"Peach"));
                entry.Add(new ResourceEntry(typeof(Pumpkin),"Pumpkin"));
                entry.Add(new ResourceEntry(typeof(WoodenBowlOfCarrots),"Bowl of Carrots"));
                entry.Add(new ResourceEntry(typeof(WoodenBowlOfCorn),"Bowl of Corn"));
                entry.Add(new ResourceEntry(typeof(WoodenBowlOfLettuce),"Bowl of Lettuce"));
                entry.Add(new ResourceEntry(typeof(WoodenBowlOfPeas),"Bowl of Peas"));
                entry.Add(new ResourceEntry(typeof(WoodenBowlOfStew),"Bowl of Stew"));
                entry.Add(new ResourceEntry(typeof(TribalBerry),"Tribal Berry"));
               
				//entry.Add(new ResourceEntry(typeof(DriedBeef),"Dried Beef"));
				//entry.Add(new ResourceEntry(typeof(StaleBread),"Stale Bread"));
			


				
                return entry;
            }
        }

        [Constructable]
        public ChefKey() : base(0x0)    // hue 5
        {
            ItemID = 0x9ED;             //cauldron
            Name = "Chef's Storage";
			LootType=LootType.Blessed;
        }

        //this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
        protected override ItemStore GenerateItemStore()
        {
            //load the basic store info
            ItemStore store = base.GenerateItemStore();

            //properties of this storage device
            store.Label = "Chef's Tools";

            store.OfferDeeds = false;
            return store;
        }

        //serial constructor
        public ChefKey(Serial serial) : base(serial)
        {
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            if (m_IsRewardItem)
                list.Add(1076217); // 1st Year Veteran Reward
        }

        //events

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0);

            writer.Write((bool)m_IsRewardItem);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            m_IsRewardItem = reader.ReadBool();
        }
    }
}