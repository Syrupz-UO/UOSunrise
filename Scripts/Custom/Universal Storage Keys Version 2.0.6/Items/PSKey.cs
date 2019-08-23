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
    [Flipable(0x9A95,0x9AA7)]
    public class PSKey : BaseStoreKey, IRewardItem
    {
        private bool m_IsRewardItem;

        [CommandProperty(AccessLevel.Seer)]
        public bool IsRewardItem
        {
            get { return m_IsRewardItem; }
            set { m_IsRewardItem = value; InvalidateProperties(); }
        }

        public override int DisplayColumns { get { return 1; } }

        public override List<StoreEntry> EntryStructure
        {
            get
            {
                List<StoreEntry> entry = base.EntryStructure;

                entry.Add
                (
                    new StashEntry
                    (
                        typeof(PowerScroll),"Power Scroll",5000,new StashSortData
                        (
                            new StashSortEntry[]
                            {
                                new StashSortEntry( "Value", "Value" ),
                                new StashSortEntry( "Skill", "Skill" )
                            }
                        )
                    )
                );

                entry.Add
                (
                    new StashEntry
                    (
                        typeof(StatCapScroll),"Stat Cap Scroll",5000,new StashSortData
                        (
                            new StashSortEntry[]
                            {
                                new StashSortEntry( "Value", "Value" )})));
	//////////////////////////////////////////////////////////////////////////////////
	 entry.Add
                (
                    new StashEntry
                    (
                        typeof(PetPowerScroll),"Pet Power Scroll",5000,new StashSortData
                        (
                            new StashSortEntry[]
                            {
                                new StashSortEntry( "Value", "Value" ),
								new StashSortEntry( "Skill", "Skill" )
								})));
	//////////////////////////////////////////////////////////////////////////////////							
entry.Add
                (
                    new StashEntry
                    (
                        typeof(ScrollofTranscendence),"Scroll of Transcendence",5000,new StashSortData
                        (
                            new StashSortEntry[]
                            {
                                new StashSortEntry( "Value", "Value" ),
								new StashSortEntry( "Skill", "Skill" )
								})));
/////////////////////////////////////////////////////////////////////////////////////
								return entry;
            }
        }

        [Constructable]
        public PSKey() : base(0x0)      // hue 1153
        {
            ItemID = 8793;
            Name = "Ultimate Power Scroll Book";
			LootType=LootType.Blessed;
        }

        //this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
        protected override ItemStore GenerateItemStore()
        {
            //load the basic store info
            ItemStore store = base.GenerateItemStore();

            //properties of this storage device
            store.Label = "PS Storage";

            store.Dynamic = false;
            store.OfferDeeds = false;
            return store;
        }

        //serial constructor
        public PSKey(Serial serial) : base(serial)
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