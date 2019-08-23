using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;							//for connection to resource store data objects
using Server.Engines.VeteranRewards;
using Server.Engines.Plants;
using Server.Items.Crops;

namespace Server.Items
{
    //item derived from BaseResourceKey
    public class ToolKey : BaseStoreKey, IRewardItem
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
				
				entry.Add( new ResourceEntry( typeof( OilCloth ), "Oil Cloth" ) );
				entry.Add( new ResourceEntry( typeof( GardenTool ), "Garden Tool" ) );
				entry.Add( new ResourceEntry( typeof( Brush ), "Brush" ) );
				entry.Add( new ResourceEntry( typeof( BioTool ), "Bio Tool" ) );
				entry.Add( new ResourceEntry( typeof( ToyMakersKit ), "Toy Maker's Kit" ) );
				entry.Add( new ResourceEntry( typeof( Bottle ), "Empty Bottle" ) );
				entry.Add( new ResourceEntry( typeof( Basket ), "Basket" ) );
				entry.Add( new ResourceEntry( typeof( CrystallineJar ), "Crystalline Jar" ) );
				entry.Add( new ResourceEntry( typeof( Jar ), "Jar" ) );
				entry.Add( new ResourceEntry( typeof( AlchemyTub ), "Alchemy Tub" ) );
				entry.Add( new ResourceEntry( typeof( PotionKeg ), "Empty Keg" ) );
				entry.Add( new ResourceEntry( typeof( CheeseForm ), "Cheese Form" ) );
				entry.Add( new ResourceEntry( typeof( MilkBucket ), "Milk Bucket" ) );
				entry.Add( new ResourceEntry( typeof( BrewersTools ), "Brewer's Tools" ) );
				entry.Add( new ResourceEntry( typeof( BreweryLabelMaker ), "Brewery Label Maker" ) );
				entry.Add( new ResourceEntry( typeof( BakersBoard ), "Baker's Board" ) );
				entry.Add( new ResourceEntry( typeof( CooksCauldron ), "Cook's Cauldron" ) );
				entry.Add( new ResourceEntry( typeof( FryingPan ), "Frying Pan" ) );
				entry.Add( new ResourceEntry( typeof( Silverware ), "Silwerware" ) );				entry.Add( new ResourceEntry( typeof( Scissors ), "Scissors" ) );
				entry.Add( new ResourceEntry( typeof( Tray ), "Tray" ) );
				entry.Add( new ResourceEntry( typeof( JuicersTools ), "Juicer's Tools" ) );
				entry.Add( new ResourceEntry( typeof( FarmLabelMaker ), "Farm Label Maker" ) );
				entry.Add( new ResourceEntry( typeof( Boline ), "Boline" ) );
				entry.Add( new ResourceEntry( typeof( VinyardLabelMaker ), "Vinyard Label Maker" ) );
				entry.Add( new ResourceEntry( typeof( WinecraftersTools ), " Winecrafter's Tools" ) );
				entry.Add( new ResourceEntry( typeof( EmptyJug ), "Empty Jug" ) );
				entry.Add( new ResourceEntry( typeof( EmptyAleBottle ), "Empty Ale Bottle" ) );
				entry.Add( new ResourceEntry( typeof( EmptyMeadBottle ), "Empty Mead Bottle" ) );
				entry.Add( new ResourceEntry( typeof( AleKeg ), "Ale Keg" ) );
				entry.Add( new ResourceEntry( typeof( CiderKeg ), "Cider Keg" ) );
				entry.Add( new ResourceEntry( typeof( CocoaKeg ), "Cocoa Keg" ) );
				entry.Add( new ResourceEntry( typeof( CoffeeKeg ), "Coffee Keg" ) );
				entry.Add( new ResourceEntry( typeof( MeadKeg ), "Mead Keg" ) );
				entry.Add( new ResourceEntry( typeof( TeaKeg ), "Tea Keg" ) );
				entry.Add( new ResourceEntry( typeof( EmptyJuiceBottle ), "Empty Juice Bottle" ) );
				entry.Add( new ResourceEntry( typeof( JuiceKeg ), "Juice Keg" ) );
				
				entry.Add( new ResourceEntry( typeof( Scissors ), "Scissors" ) );
				entry.Add( new ResourceEntry( typeof( PlantBowl ), "Plant Bowl", 0, 25, 0, 0  ) );
				entry.Add( new ToolEntry( typeof( Shovel ), new Type[]{ typeof( SturdyShovel ) }, "Shovel", 0, 35, -10, -10 ) );
                entry.Add(new ToolEntry(typeof(TinkerTools),"Tinkering",0,30,0,0));
                entry.Add(new ToolEntry(typeof(SmithHammer),new Type[] { typeof(Tongs),typeof(SledgeHammer) },"Blacksmithy",0,30,-5,0));
                entry.Add(new ToolEntry(typeof(SewingKit),"Tailoring",0,30,-5,3));
                entry.Add(new ToolEntry(typeof(Nails),new Type[] { typeof(Saw),typeof(Hammer),typeof(Scorp),typeof(DrawKnife),typeof(DovetailSaw),typeof(Froe),typeof(Inshave),typeof(JointingPlane) },"Carpentry",0,30,-10,5));
                entry.Add(new ToolEntry(typeof(FletcherTools),"Fletching",0,35,0,0));
                entry.Add(new ToolEntry(typeof(MortarPestle),"Alchemy",0,30,0,0));
                entry.Add(new ToolEntry(typeof(ScribesPen),"Inscription",0,30,0,0));
                entry.Add(new ToolEntry(typeof(Skillet),new Type[] { typeof(FlourSifter),typeof(RollingPin) },"Cooking",0,30,0,0));
                entry.Add(new ColumnSeparationEntry());
                entry.Add(new ToolEntry(typeof(MalletAndChisel),"Stone Crafting",0,30,0,0));
                entry.Add(new ToolEntry(typeof(Shovel),new Type[] { typeof(SturdyShovel),typeof(Pickaxe),typeof(SturdyPickaxe) },"Mining",0,35,-10,-10));
                entry.Add(new ToolEntry(typeof(Hatchet),"Lumberjacking",0,30,-5,0));
                entry.Add(new ToolEntry(typeof(GargoylesPickaxe),"Gargoyle's Pickaxe",0,30,-5,-5));
                entry.Add(new ToolEntry(typeof(ProspectorsTool),"Prospector's Tool",0,30,0,0));
                entry.Add(new ToolEntry(typeof(MapmakersPen),"Cartography",0,30,0,0));
                entry.Add(new ToolEntry(typeof(Blowpipe),"Glassblowing",0,40,0,0));
                entry.Add(new ToolEntry(typeof(TaxidermyKit),"Taxidermy",0,30,0,0));
				//this item really shows off the flexibility you have in creating cool customized combo items
				entry.Add( new ToolEntry( typeof( SmithHammer ), "Smith Hammer", 0, 30, -5, 0 ) );
				entry.Add( new ToolEntry( typeof( Tongs ), "Tongs", 0, 30, -5, 0 ) );
				entry.Add( new ToolEntry( typeof( SledgeHammer ), "Sledge Hammer", 0, 30, -5, 0 ) );
					entry.Add( new AncientSmithyHammerToolEntry( 10, "+10 ASH", 0, 20, 0, 0 ) );
				entry.Add( new AncientSmithyHammerToolEntry( 15, "+15 ASH", 0, 20, 0, 0 ) );
				entry.Add( new AncientSmithyHammerToolEntry( 30, "+30 ASH", 0, 20, 0, 0 ) );
				entry.Add( new AncientSmithyHammerToolEntry( 60, "+60 ASH", 0, 20, 0, 0 ) );
				entry.Add( new RunicToolEntry( typeof( RunicHammer ), CraftResource.DullCopper, "Dull Copper", 0, 30, -5, 0 ) );
				entry.Add( new RunicToolEntry( typeof( RunicHammer ), CraftResource.ShadowIron, "Shadow Iron", 0, 30, -5, 0 ) );
				entry.Add( new RunicToolEntry( typeof( RunicHammer ), CraftResource.Copper, "Copper", 0, 30, -5, 0 ) );
				entry.Add( new RunicToolEntry( typeof( RunicHammer ), CraftResource.Bronze, "Bronze", 0, 30, -5, 0 ) );
				entry.Add( new RunicToolEntry( typeof( RunicHammer ), CraftResource.Gold, "Gold", 0, 30, -5, 0 ) );
				entry.Add( new RunicToolEntry( typeof( RunicHammer ), CraftResource.Agapite, "Agapite", 0, 30, -5, 0 ) );
				entry.Add( new RunicToolEntry( typeof( RunicHammer ), CraftResource.Verite, "Verite", 0, 30, -5, 0 ) );
				entry.Add( new RunicToolEntry( typeof( RunicHammer ), CraftResource.Valorite, "Valorite", 0, 30, -5, 0 ) );
				entry.Add( new ColumnSeparationEntry() );
				entry.Add( new RunicToolEntry( typeof( RunicSewingKit ), CraftResource.SpinedLeather, "Spined", 0, 30, -5, 3 ) );
				entry.Add( new RunicToolEntry( typeof( RunicSewingKit ), CraftResource.HornedLeather, "Horned", 0, 30, -5, 3 ) );
				entry.Add( new RunicToolEntry( typeof( RunicSewingKit ), CraftResource.BarbedLeather, "Barbed", 0, 30, -5, 3 ) );
				 entry.Add(new ResourceEntry(typeof(Spoon),"Spoon"));
				entry.Add(new ResourceEntry(typeof(Goblet),"Goblet"));
				
                return entry;
            }
        }

        [Constructable]
        public ToolKey() : base(0x0)    //hue 45
        {
            ItemID = 7867;          //toolbox
            Name = "Tool Box";
			LootType=LootType.Blessed;

            //tools withdrawn can have no less than 50 charges on them.
            _Store.MinWithdrawAmount = 50;
        }

        //this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
        protected override ItemStore GenerateItemStore()
        {
            //load the basic store info
            ItemStore store = base.GenerateItemStore();

            //properties of this storage device
            store.Label = "Tool Storage";

            store.Dynamic = false;
            store.OfferDeeds = true;

            return store;
        }

        //serial constructor
        public ToolKey(Serial serial) : base(serial)
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