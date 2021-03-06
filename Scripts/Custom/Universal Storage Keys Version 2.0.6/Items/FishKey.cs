﻿using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;							//for connection to resource store data objects
using Server.Engines.BulkOrders;
using Server.Engines.VeteranRewards;

namespace Server.Items
{
    //item inherited from BaseResourceKey
    public class FishKey : BaseStoreKey, IRewardItem
    {
        private bool m_IsRewardItem;

        [CommandProperty(AccessLevel.Seer)]
        public bool IsRewardItem
        {
            get { return m_IsRewardItem; }
            set { m_IsRewardItem = value; InvalidateProperties(); }
        }

		public override int DisplayColumns{ get{ return 2; } }
		
		public override List<StoreEntry> EntryStructure
		{
			get
			{
				List<StoreEntry> entry = new List<StoreEntry>();
				entry.Add(new ResourceEntry(typeof(Fish),"Fish"));
				entry.Add(new ResourceEntry(typeof(BigFish),"Big Fish"));
				entry.Add(new ResourceEntry(typeof(NewFish),"New Fish"));
				
				entry.Add(new ResourceEntry(typeof(PrizedFish),"Prized Fish"));
				entry.Add(new ResourceEntry(typeof(PeculiarFish),"Peculiar Fish"));
			
				
				entry.Add(new ResourceEntry(typeof(WondrousFish),"Wondrous Fish"));
				entry.Add(new ResourceEntry(typeof(TrulyRareFish),"Truly Rare Fish"));
			
				entry.Add(new ResourceEntry(typeof(FishSteak),"Fish Steak"));
				entry.Add(new ResourceEntry(typeof(FlukeFishSteak),"Fluke Fish Steak"));
				entry.Add(new ResourceEntry(typeof(HalibutFishSteak),"Halibut Fish Steak"));
				entry.Add(new ResourceEntry(typeof(RawFishSteak),"Raw Fish Steak"));
				entry.Add(new ResourceEntry(typeof(ParrotFishSteak),"Parrot Fish Steak"));
				entry.Add(new ResourceEntry(typeof(RawParrotFishSteak),"Raw Parrot Fish Steak"));
				entry.Add(new ResourceEntry(typeof(RedSnapperFishSteak),"Red Snapper Fish Steak"));
				entry.Add(new ResourceEntry(typeof(SalmonFishSteak),"Salmon Fish Steak"));
				entry.Add(new ResourceEntry(typeof(TroutFishSteak),"Trout Fish Steak"));
				
				entry.Add(new ResourceEntry(typeof(ElixirFishing),"Elixir of Fishing"));
				entry.Add(new ResourceEntry(typeof(FabledFishingNet),"Fabled Fishing Net"));
				entry.Add(new ResourceEntry(typeof(FishingPole),"Fishing Pole"));
				entry.Add(new ResourceEntry(typeof(FishingNet),"Fishing Net"));
				entry.Add(new ResourceEntry(typeof(SpecialFishingNet),"Special Fishing Net"));
				
				
			//	entry.Add( new GenericEntry( typeof( Fish ), "Fish", "Amount" ) );
				//entry.Add( new GenericDistinguishableEntry( typeof( Fish ) ) );
				//entry.Add( new GenericDistinguishableEntry( typeof( Fish ), "0x22B1", "0x22B1", "Amount" ) );
			//	entry.Add( new GenericDistinguishableEntry( typeof( Fish ), "ItemID", "0x9CE", "Amount" ) );
			//	entry.Add( new GenericDistinguishableEntry( typeof( Fish ), "ItemID", "0x9CF", "Amount" ) );
				
				return entry;
			}
		}
		
        [Constructable]
        public FishKey() : base(0x0)        // hue 1929
        {
            ItemID = 0xFFA;
            Name = "Fish Bucket";
			LootType=LootType.Blessed;
        }

        //this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
        protected override ItemStore GenerateItemStore()
        {
            //load the basic store info
            ItemStore store = base.GenerateItemStore();

            //properties of this storage device
            store.Label = "Fish Storage";

            store.Dynamic = false;
            store.OfferDeeds = false;
            return store;
        }

        //serial constructor
        public FishKey(Serial serial) : base(serial)
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