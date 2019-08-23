using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;							//for connection to resource store data objects
using Server.Engines.VeteranRewards;

namespace Server.Items
{
    //item derived from BaseResourceKey
    public class IngotKey : BaseStoreKey, IRewardItem
    {
        private bool m_IsRewardItem;

        [CommandProperty(AccessLevel.Seer)]
        public bool IsRewardItem
        {
            get { return m_IsRewardItem; }
            set { m_IsRewardItem = value; InvalidateProperties(); }
        }

        public override List<StoreEntry> EntryStructure
        {
            get
            {
                List<StoreEntry> entry = base.EntryStructure;

                entry.Add(new ResourceEntry(typeof(IronIngot),"Iron"));
                entry.Add(new ResourceEntry(typeof(DullCopperIngot),"Dull"));
                entry.Add(new ResourceEntry(typeof(ShadowIronIngot),"Shadow"));
                entry.Add(new ResourceEntry(typeof(CopperIngot),"Copper"));
                entry.Add(new ResourceEntry(typeof(BronzeIngot),"Bronze"));
                entry.Add(new ResourceEntry(typeof(GoldIngot),"Gold"));
                entry.Add(new ResourceEntry(typeof(AgapiteIngot),"Agapite"));
                entry.Add(new ResourceEntry(typeof(VeriteIngot),"Verite"));
                entry.Add(new ResourceEntry(typeof(ValoriteIngot),"Valorite"));
				entry.Add( new ResourceEntry( typeof( NepturiteIngot ), "Nepturite" ) );
				entry.Add( new ResourceEntry( typeof( ObsidianIngot ), "Obsidian" ) );
				entry.Add( new ResourceEntry( typeof( SteelIngot ), "Steel" ) );
				entry.Add( new ResourceEntry( typeof( BrassIngot ), "Brass" ) );
				entry.Add( new ResourceEntry( typeof( MithrilIngot ), "Mithril" ) );
				entry.Add( new ResourceEntry( typeof( XormiteIngot ), "Xormite" ) );
				entry.Add( new ResourceEntry( typeof( DwarvenIngot ), "Dwarven" ) );
				
				entry.Add(new ResourceEntry(typeof(IronOre),"Iron"));
                entry.Add(new ResourceEntry(typeof(DullCopperOre),"Dull"));
                entry.Add(new ResourceEntry(typeof(ShadowIronOre),"Shadow"));
                entry.Add(new ResourceEntry(typeof(CopperOre),"Copper"));
                entry.Add(new ResourceEntry(typeof(BronzeOre),"Bronze"));
                entry.Add(new ResourceEntry(typeof(GoldOre),"Gold"));
                entry.Add(new ResourceEntry(typeof(AgapiteOre),"Agapite"));
                entry.Add(new ResourceEntry(typeof(VeriteOre),"Verite"));
                entry.Add(new ResourceEntry(typeof(ValoriteOre),"Valorite"));
				entry.Add( new ResourceEntry( typeof( NepturiteOre ), "Nepturite" ) );
				entry.Add( new ResourceEntry( typeof( ObsidianOre ), "Obsidian" ) );
				//entry.Add( new ResourceEntry( typeof( SteelOre ), "Steel" ) );
				//entry.Add( new ResourceEntry( typeof( BrassOre ), "Brass" ) );
				entry.Add( new ResourceEntry( typeof( MithrilOre ), "Mithril" ) );
				entry.Add( new ResourceEntry( typeof( XormiteOre ), "Xormite" ) );
				entry.Add( new ResourceEntry( typeof( DwarvenOre ), "Dwarven" ) );
				entry.Add( new ResourceEntry( typeof( DugUpCoal ), "Dug up Coal" ) );
				entry.Add( new ResourceEntry( typeof( DugUpZinc ), "Dug up Zinc" ) );
				entry.Add( new ResourceEntry( typeof( Coal ), "Coal" ) );
				
				int height = 40;
				
			
				entry.Add( new ResourceEntry( typeof( Granite ), "Plain", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( DullCopperGranite ), "Dull", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( ShadowIronGranite ), "Shadow", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( CopperGranite ), "Copper", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( BronzeGranite ), "Bronze", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( GoldGranite ), "Gold", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( AgapiteGranite ), "Agapite", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( VeriteGranite ), "Verite", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( ValoriteGranite ), "Valorite", 0, height, 0, 0 ) );
				
				entry.Add( new ResourceEntry( typeof( NepturiteGranite ), "Nepturite", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( ObsidianGranite ), "Obsidian", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( MithrilGranite ), "Mithril", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( XormiteGranite ), "Xormite", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( DwarvenGranite ), "Dwarven", 0, height, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( Board ), new Type[]{ typeof( Log ) }, "Plain" ) );
				
				entry.Add( new ResourceEntry( typeof( AshLog ), new Type[]{ typeof( Log ) }, "Ash" ) );
				entry.Add( new ResourceEntry( typeof( CherryLog ), new Type[]{ typeof( Log ) }, "Cherry" ) );
				entry.Add( new ResourceEntry( typeof( EbonyLog ), new Type[]{ typeof( Log ) }, "Ebony Tree" ) );
				entry.Add( new ResourceEntry( typeof( GoldenOakLog ), new Type[]{ typeof( Log ) }, "Golden Oak Tree" ) );
				entry.Add( new ResourceEntry( typeof( HickoryLog ), new Type[]{ typeof( Log ) }, "Hickory Tree" ) );
				entry.Add( new ResourceEntry( typeof( MahoganyLog ), new Type[]{ typeof( Log ) }, "Mahogany Tree" ) );
				entry.Add( new ResourceEntry( typeof( OakLog ), new Type[]{ typeof( Log ) }, "Oak Tree" ) );
				entry.Add( new ResourceEntry( typeof( PineLog ), new Type[]{ typeof( Log ) }, "Pine Tree" ) );
				entry.Add( new ResourceEntry( typeof( GhostLog ), new Type[]{ typeof( Log ) }, "Ghost Tree" ) );
				entry.Add( new ResourceEntry( typeof( RosewoodLog ), new Type[]{ typeof( Log ) }, "Rosewood Tree" ) );
				entry.Add( new ResourceEntry( typeof( WalnutLog ), new Type[]{ typeof( Log ) }, "Walnut Tree" ) );
				entry.Add( new ResourceEntry( typeof( PetrifiedLog ), new Type[]{ typeof( Log ) }, "Petrified Tree" ) );
				entry.Add( new ResourceEntry( typeof( DriftwoodLog ), new Type[]{ typeof( Log ) }, "Driftwood Tree" ) );
				entry.Add( new ResourceEntry( typeof( ElvenLog ), new Type[]{ typeof( Log ) }, "Elven Tree" ) );
				
				entry.Add( new ResourceEntry( typeof( Board ), new Type[]{ typeof( Board ) }, "Plain" ) );
				entry.Add( new ResourceEntry( typeof( AshBoard ), new Type[]{ typeof( Log ) }, "Ash" ) );
				entry.Add( new ResourceEntry( typeof( CherryBoard ), new Type[]{ typeof( Log ) }, "Cherry" ) );
				entry.Add( new ResourceEntry( typeof( EbonyBoard ), new Type[]{ typeof( Log ) }, "Ebony Tree" ) );
				entry.Add( new ResourceEntry( typeof( GoldenOakBoard ), new Type[]{ typeof( Log ) }, "Golden Oak Tree" ) );
				entry.Add( new ResourceEntry( typeof( HickoryBoard ), new Type[]{ typeof( Log ) }, "Hickory Tree" ) );
				entry.Add( new ResourceEntry( typeof( MahoganyBoard ), new Type[]{ typeof( Log ) }, "Mahogany Tree" ) );
				entry.Add( new ResourceEntry( typeof( OakBoard ), new Type[]{ typeof( Log ) }, "Oak Tree" ) );
				entry.Add( new ResourceEntry( typeof( PineBoard ), new Type[]{ typeof( Log ) }, "Pine Tree" ) );
				entry.Add( new ResourceEntry( typeof( GhostBoard ), new Type[]{ typeof( Log ) }, "Ghost Tree" ) );
				entry.Add( new ResourceEntry( typeof( RosewoodBoard ), new Type[]{ typeof( Log ) }, "Rosewood Tree" ) );
				entry.Add( new ResourceEntry( typeof( WalnutBoard ), new Type[]{ typeof( Log ) }, "Walnut Tree" ) );
				entry.Add( new ResourceEntry( typeof( PetrifiedBoard ), new Type[]{ typeof( Log ) }, "Petrified Tree" ) );
				entry.Add( new ResourceEntry( typeof( DriftwoodBoard ), new Type[]{ typeof( Log ) }, "Driftwood Tree" ) );
				entry.Add( new ResourceEntry( typeof( ElvenBoard ), new Type[]{ typeof( Log ) }, "Elven Tree" ) );
		
				
				entry.Add( new ResourceEntry( typeof( Kindling ), "Kindling" ) );
				entry.Add( new ResourceEntry( typeof( Shaft ), "Shaft" ) );
				entry.Add( new ResourceEntry( typeof( Feather ), "Feather" ) );
				entry.Add( new ResourceEntry( typeof( Arrow ), "Arrow" ) );
				entry.Add( new ResourceEntry( typeof( Bolt ), "Bolt" ) );
				
				entry.Add( new ResourceEntry( typeof( Leather ), new Type[]{ typeof( Hides ) }, "Leather", 0, 30, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( SpinedLeather ), new Type[]{ typeof( SpinedHides ) }, "Spined Leather", 0, 30, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( HornedLeather ), new Type[]{ typeof( HornedHides ) }, "Horned Leather", 0, 30, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( BarbedLeather ), new Type[]{ typeof( BarbedHides ) }, "Barbed Leather", 0, 30, 0, 0 ) );
				
				entry.Add( new ResourceEntry( typeof( NecroticLeather ), new Type[]{ typeof( NecroticHides ) }, "Necrotic Leather", 0, 30, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( VolcanicLeather ), new Type[]{ typeof( VolcanicHides ) }, "Volcanic Leather", 0, 30, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( FrozenLeather ), new Type[]{ typeof( FrozenHides ) }, "Frozen Leather", 0, 30, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( GoliathLeather ), new Type[]{ typeof( GoliathHides ) }, "Goliath Leather", 0, 30, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( DraconicLeather ), new Type[]{ typeof( DraconicHides ) }, "Draconic Leather", 0, 30, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( HellishLeather ), new Type[]{ typeof( HellishHides ) }, "Hellish Leather", 0, 30, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( DinosaurLeather ), new Type[]{ typeof( DinosaurHides ) }, "Dinosaur Leather", 0, 30, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( AlienLeather ), new Type[]{ typeof( AlienHides ) }, "Alien Leather", 0, 30, 0, 0 ) );
	
				//entry.Add( new ColumnSeparationEntry() );
				
				entry.Add( new ResourceEntry( typeof( UncutCloth ), new Type[]{ typeof( Cloth ) }, "Cloth", 0, 30, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( BoltOfCloth ), "Bolt of Cloth" , 0, 50, 0, 0 ) );
				entry.Add( new ResourceEntry( typeof( LightYarn ), new Type[]{ typeof( DarkYarn ), typeof( LightYarnUnraveled ) }, "Yarn" ) );
				entry.Add( new ResourceEntry( typeof( SpoolOfThread ), "Spool of Thread" ) );
				entry.Add( new ResourceEntry( typeof( Wool ), "Wool" ) );
				entry.Add( new ResourceEntry( typeof( Cotton ), "Cotton" ) );
				entry.Add( new ResourceEntry( typeof( Flax ), "Flax" ) );
				entry.Add( new ColumnSeparationEntry() );
				
				entry.Add( new ResourceEntry( typeof( RedScales ), "Red Scales" ) );
				entry.Add( new ResourceEntry( typeof( YellowScales ), "Yellow Scales" ) );
				entry.Add( new ResourceEntry( typeof( BlackScales ), "Black Scales" ) );
				entry.Add( new ResourceEntry( typeof( GreenScales ), "Green Scales" ) );
				entry.Add( new ResourceEntry( typeof( WhiteScales ), "White Scales" ) );
				entry.Add( new ResourceEntry( typeof( BlueScales ), "Blue Scales" ) );
				entry.Add( new ResourceEntry( typeof( DinosaurScales ), "Dinosaur Scales" ) );
				
				entry.Add( new ResourceEntry( typeof( Crystals ), "Crystals" ) );
				entry.Add( new ResourceEntry( typeof( LargeCrystal ), "Large Crystal" ) );
				entry.Add( new ResourceEntry( typeof( Amber ), "Amber", 0, 25, -11, 9 ) );
				entry.Add( new ResourceEntry( typeof( Amethyst ), "Amethyst", 0, 25, -11, 9 ) );
				entry.Add( new ResourceEntry( typeof( Citrine ), "Citrine", 0, 25, -13, 9 ) );
				entry.Add( new ResourceEntry( typeof( Diamond ), "Diamond", 0, 25, -5, 9 ) );
				entry.Add( new ResourceEntry( typeof( Emerald ), "Emerald", 0, 25, 7, 9 ) );
				entry.Add( new ResourceEntry( typeof( Ruby ), "Ruby", 0, 25, 7, 9 ) );
				entry.Add( new ResourceEntry( typeof( Sapphire ), "Sapphire", 0, 25, 6, 9 ) );
				entry.Add( new ResourceEntry( typeof( StarSapphire ), "Star Sapphire", 0, 25, -7, 9 ) );
				entry.Add( new ResourceEntry( typeof( Tourmaline ), "Tourmaline", 0, 25, 11, 8 ) );
				
                return entry;
            }
        }

        [Constructable]
        public IngotKey() : base(0x0)       //hue 0x14
        {
            ItemID = 0x1BE8;            //pile of ingots
            Name = "Crafter Keys";
			LootType=LootType.Blessed;
        }

        //this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
        protected override ItemStore GenerateItemStore()
        {
            //load the basic store info
            ItemStore store = base.GenerateItemStore();

            //properties of this storage device
            store.Label = "Ingot Storage";

            store.Dynamic = false;
            store.OfferDeeds = true;
            return store;
        }

        //serial constructor
        public IngotKey(Serial serial) : base(serial)
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