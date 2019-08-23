using System;
using Server;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Gumps;
using Server.Network;
using Server.Menus;
using Server.ContextMenus;
using Server.Menus.Questions; 
using Server.Targeting;
using Server.Engines.Harvest;
using Server.Regions;
using Server.Mobiles;

namespace Server.Mobiles
{
	#region Mining Beetle
    [CorpseName("an Mining beetle corpse")]
    public class MiningBeetle : BaseCreature
    {
		// Tass23 Mining Tile Check 	
		private bool IsMiningTile(int X, int Y, Map map)
		{
           
			LandTile list = map.Tiles.GetLandTile( X, Y );
			for (int l = 0; l < m_MountainAndCaveTiles.Length; l++)
			{
				if (m_MountainAndCaveTiles[l] == list.ID) return true;
			}
				return false;
			}	
		// End Check: Thankx to Tass23			
        private static int[] m_MountainAndCaveTiles = new int[]
			{
				220, 221, 222, 223, 224, 225, 226, 227, 228, 229,
				230, 231, 236, 237, 238, 239, 240, 241, 242, 243,
				244, 245, 246, 247, 252, 253, 254, 255, 256, 257,
				258, 259, 260, 261, 262, 263, 268, 269, 270, 271,
				272, 273, 274, 275, 276, 277, 278, 279, 286, 287,
				288, 289, 290, 291, 292, 293, 294, 296, 296, 297,
				321, 322, 323, 324, 467, 468, 469, 470, 471, 472,
				473, 474, 476, 477, 478, 479, 480, 481, 482, 483,
				484, 485, 486, 487, 492, 493, 494, 495, 543, 544,
				545, 546, 547, 548, 549, 550, 551, 552, 553, 554,
				555, 556, 557, 558, 559, 560, 561, 562, 563, 564,
				565, 566, 567, 568, 569, 570, 571, 572, 573, 574,
				575, 576, 577, 578, 579, 581, 582, 583, 584, 585,
				586, 587, 588, 589, 590, 591, 592, 593, 594, 595,
				596, 597, 598, 599, 600, 601, 610, 611, 612, 613,

				1010, 1741, 1742, 1743, 1744, 1745, 1746, 1747, 1748, 1749,
				1750, 1751, 1752, 1753, 1754, 1755, 1756, 1757, 1771, 1772,
				1773, 1774, 1775, 1776, 1777, 1778, 1779, 1780, 1781, 1782,
				1783, 1784, 1785, 1786, 1787, 1788, 1789, 1790, 1801, 1802,
				1803, 1804, 1805, 1806, 1807, 1808, 1809, 1811, 1812, 1813,
				1814, 1815, 1816, 1817, 1818, 1819, 1820, 1821, 1822, 1823,
				1824, 1831, 1832, 1833, 1834, 1835, 1836, 1837, 1838, 1839,
				1840, 1841, 1842, 1843, 1844, 1845, 1846, 1847, 1848, 1849,
				1850, 1851, 1852, 1853, 1854, 1861, 1862, 1863, 1864, 1865,
				1866, 1867, 1868, 1869, 1870, 1871, 1872, 1873, 1874, 1875,
				1876, 1877, 1878, 1879, 1880, 1881, 1882, 1883, 1884, 1981,
				1982, 1983, 1984, 1985, 1986, 1987, 1988, 1989, 1990, 1991,
				1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999, 2000, 2001,
				2002, 2003, 2004, 2028, 2029, 2030, 2031, 2032, 2033, 2100,
				2101, 2102, 2103, 2104, 2105,
				
				0x453B, 0x453C, 0x453D, 0x453E, 0x453F, 0x4540, 0x4541,
				0x4542, 0x4543, 0x4544,	0x4545, 0x4546, 0x4547, 0x4548,
				0x4549, 0x454A, 0x454B, 0x454C, 0x454D, 0x454E,	0x454F
			};
			
        public bool m_Mine;
        private DateTime m_NextUse;
        [CommandProperty(AccessLevel.GameMaster)]
        public DateTime NextUse { get { return m_NextUse; } set { m_NextUse = value; } }

        public override bool SubdueBeforeTame { get { return true; } }

        [Constructable]
        public MiningBeetle()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a Mining beetle";
            Body = 0x317;
            BaseSoundID = 397;

            SetStr(831);
            SetDex(74, 80);
            SetInt(45);

            SetHits(801);
            SetMana(45);

            SetDamage(15, 20);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 55, 60);
            SetResistance(ResistanceType.Fire, 20, 25);
            SetResistance(ResistanceType.Cold, 20, 25);
            SetResistance(ResistanceType.Poison, 35, 40);
            SetResistance(ResistanceType.Energy, 50, 60);

            SetSkill(SkillName.Anatomy, 85, 90);
            SetSkill(SkillName.MagicResist, 30.1, 35);
            SetSkill(SkillName.Tactics, 91.5, 92);
            SetSkill(SkillName.Wrestling, 99.8, 100);
            SetSkill(SkillName.Blacksmith, 120.0);
            SetSkill(SkillName.Mining, 50);
            Skills.Mining.Cap = 120;

            Fame = 2000;
            Karma = -2000;

            VirtualArmor = 38;

            Tamable = true;
            ControlSlots = 4;
            MinTameSkill = 71.1;

            Container pack = Backpack;
            if (pack != null) pack.Delete();
            pack = new StrongBackpack();
            pack.Movable = false;
            AddItem(pack);

            AddItem(new Gold(600));
            PackItem(new IronOre(5));
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
            AddLoot(LootPack.Gems);
        }

        public override void OnDeath(Container c)
        {
            base.OnDeath(c);

            if (Utility.RandomDouble() < 0.1)
                c.DropItem(new IBAxe());

            if (Utility.RandomDouble() < 0.15)
                c.DropItem(new IBShovel());

        }

        public override bool CanRummageCorpses { get { return true; } }
        public override int Meat { get { return 1; } }
        public override FoodType FavoriteFood { get { return FoodType.Meat; } }
        public override DeathMoveResult GetInventoryMoveResultFor(Item item) { return DeathMoveResult.MoveToCorpse; }
        public override bool AllowEquipFrom(Mobile from) { return (ControlMaster != null && ControlMaster == from); }
        public override bool CanBeRenamedBy(Mobile from) { return (ControlMaster != null && ControlMaster == from); }
        public override bool CanPaperdollBeOpenedBy(Mobile from) { return false; }
        public override bool CheckNonlocalDrop(Mobile from, Item item, Item target) { return PackAnimal.CheckAccess(this, from); }
        public override bool CheckNonlocalLift(Mobile from, Item item) { return PackAnimal.CheckAccess(this, from); }

        public override bool OnBeforeDeath()
        {
            if (!base.OnBeforeDeath()) return false;
            PackAnimal.CombineBackpacks(this);
            return base.OnBeforeDeath();
        }

        public override bool IsSnoop(Mobile from)
        {
            if (PackAnimal.CheckAccess(this, from)) return false;
            return base.IsSnoop(from);
        }

        public override bool OnDragDrop(Mobile from, Item item)
        {
            this.Skills.Mining.Cap = 120;
            if (CheckFeed(from, item)) return true;
            if (PackAnimal.CheckAccess(this, from))
            {
                if (item is BaseOre)
                {
                    BaseOre m_Ore = item as BaseOre;

                    int toConsume = m_Ore.Amount;

                    if (toConsume > 30000)
                    {
                        toConsume = 30000;
                    }
                    else if (m_Ore.Amount < 1)
                    {
                        from.SendLocalizedMessage(501989); // You burn away the impurities but are left with no useable metal.
                        m_Ore.Delete();
                        return true;
                    }

                    BaseIngot ingot = m_Ore.GetIngot();
                    ingot.Amount = toConsume * 2;

                    m_Ore.Consume(toConsume);

                    this.Hue = m_Ore.Hue;

                    from.PlaySound(0x57);

                    AddToBackpack(item);
                    AddToBackpack(ingot);
                    return true;
                }
            }

            return base.OnDragDrop(from, item);
        }

        public override void OnSpeech(SpeechEventArgs args)
        {
            string said = args.Speech.ToLower();
            Mobile from = args.Mobile;
            string bmine = this.Name + " " + "mine";
            string bmine2 = bmine.ToLower();
            string bbreak = this.Name + " " + "takebreak";
            string bbreak2 = bbreak.ToLower();
            string bbreak3 = this.Name + " " + "take break";
            string bbreak4 = bbreak3.ToLower();
            if (said == this.Name.ToLower())
            {
                if (from == this.ControlMaster)
                {
                    this.Say("Yes?");
                }
                else
                {
                   
                        this.Say("You are not my master.");
                       
                    }
                }
            
            else if ((said == "mine" || said == bmine2) && from == this.ControlMaster) { m_Mine = true; ControlOrder = OrderType.Stay; }
            else if ((said == "takebreak" || said == "take break" || said == bbreak2 || said == bbreak4) && from == this.ControlMaster) m_Mine = false;
            base.OnSpeech(args);
        }

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);
            PackAnimal.GetContextMenuEntries(this, from, list);
        }

		public override void OnThink()
        {
            if (this.Region.IsPartOf(typeof(HouseRegion))) m_NextUse = DateTime.Now + TimeSpan.FromSeconds(2.5);
            else if (this.Alive && this.m_Mine && this.m_NextUse <= DateTime.Now && Loyalty > 50)
            {
                Container backpack = this.Backpack;
                if (backpack == null) { m_NextUse = DateTime.Now + TimeSpan.FromSeconds(2.5); base.OnThink(); return; }
                if (backpack.TotalWeight >= backpack.MaxWeight || backpack.TotalItems >= backpack.MaxItems) { m_NextUse = DateTime.Now + TimeSpan.FromSeconds(2.5); base.OnThink(); return; }
                IBShovel ibshovel = (IBShovel)backpack.FindItemByType(typeof(IBShovel));
                //Shovel shovel = (Shovel)backpack.FindItemByType(typeof(Shovel));
                if (ibshovel != null)
                {
                    if (this.DoDisposeOre(this.X, this.Y, this.Z, this.Map, this))
                    {
                        ibshovel.UsesRemaining -= 1;
                        if (ibshovel != null && !ibshovel.Deleted && ibshovel.UsesRemaining <= 0) ibshovel.Delete();
                    }
                }
                else if (ibshovel != null)
                {
                    if (this.DoDisposeOre(this.X, this.Y, this.Z, this.Map, this))
                    {
                        ibshovel.UsesRemaining -= 1;
                        if (ibshovel != null && !ibshovel.Deleted && ibshovel.UsesRemaining <= 0) ibshovel.Delete();
                    }
                }
                m_NextUse = DateTime.Now + TimeSpan.FromSeconds(2.5);
            }
            base.OnThink();
        }

        public bool DoDisposeOre(int x, int y, int z, Map map, Mobile from)
        {
            HarvestBank bank = Mining.System.OreAndStone.GetBank(map, x, y);
            if (bank == null)
            {
                this.Say("I can not mine here");
                return false;
            }
            if (bank.Current <= 0) return false;
            HarvestVein vein = bank.DefaultVein;
            if (vein == null)
            {
                this.Say("I can not mine here");
                return false;
            }
            HarvestDefinition def = Mining.System.OreAndStone;
            HarvestResource res = vein.PrimaryResource;
            BaseOre ore = Mining.System.Construct(res.Types[0], null) as BaseOre;
            if (ore == null) return false;
            if (ore.Resource > CraftResource.Iron)
            {
                double minskill = 0.0;
                double minskill2 = 0.0;
                double maxskill = 0.0;
                double skillbase = this.Skills.Mining.Base;
                if (this.Skills.Mining.Base < 120.0) this.Say("skill = {0}", Convert.ToString(skillbase));
                switch (ore.Resource)
                {
                    case CraftResource.Iron: { minskill = 00.0; minskill2 = 00.0; maxskill = 100.0; } break;
                    case CraftResource.DullCopper: { minskill = 60.0; minskill2 = 25.0; maxskill = 105.0; } break;
                    case CraftResource.ShadowIron: { minskill = 65.0; minskill2 = 30.0; maxskill = 110.0; } break;
                    case CraftResource.Copper: { minskill = 70.0; minskill2 = 35.0; maxskill = 115.0; } break;
                    case CraftResource.Gold: { minskill = 75.0; minskill2 = 40.0; maxskill = 120.0; } break;
                    case CraftResource.Agapite: { minskill = 80.0; minskill2 = 45.0; maxskill = 120.0; } break;
                    case CraftResource.Verite: { minskill = 85.0; minskill2 = 50.0; maxskill = 120.0; } break;
                    case CraftResource.Valorite: { minskill = 90.0; minskill2 = 55.0; maxskill = 120.0; } break;
					
					case CraftResource.Nepturite: { minskill = 114.0; minskill2 = 64.0; maxskill = 120.0; } break;
					case CraftResource.Obsidian: { minskill = 119.0; minskill2 = 69.0; maxskill = 120.0; } break;
					case CraftResource.Mithril: { minskill = 123.0; minskill2 = 74.0; maxskill = 120.0; } break;
					case CraftResource.Xormite: { minskill = 128.0; minskill2 = 78.0; maxskill = 120.0; } break;
					case CraftResource.Dwarven: { minskill = 133.0; minskill2 = 83.0; maxskill = 120.0; } break;
					
					
                }
                if (Utility.RandomDouble() <= 0.30 || skillbase < minskill) { ore = new IronOre(); minskill = 00.0; minskill2 = 00.0; maxskill = 100.0; }
                if (!(from.CheckSkill(SkillName.Mining, minskill2, maxskill)))
                {
                    ore.Delete();
                    return false;
                }
            }
            ore.Amount = (map == Map.Felucca ? 2 : 1);
            if (from != null) from.AddToBackpack(ore);
            else ore.Delete();
            bank.Consume( ore.Amount, this);
            this.Hue = ore.Hue;
            
            return true;
        }

        public MiningBeetle(Serial serial): base(serial)
        {
        }
            public override void Serialize(GenericWriter writer)
            {
                base.Serialize(writer);
                writer.Write((int)0);
            }

            public override void Deserialize(GenericReader reader)
            {
                base.Deserialize(reader);
                int version = reader.ReadInt();
            }
        }
		#endregion
		#region Lumberjacking Beetle
    [CorpseName("a Lumberjacking beetle corpse")]
    public class LumberjackingBeetle : BaseCreature
    {
		// Tass23 Tree Tile Check 
		private bool IsTreeTiles(int X, int Y, Map map)
		{
           
			LandTile list = map.Tiles.GetLandTile( X, Y );
			for (int l = 0; l < m_TreeTiles.Length; l++)
			{
				if (m_TreeTiles[l] == list.ID) return true;
			}
				return false;
			}
		// End Check: Thankx to Tass23
        private static int[] m_TreeTiles = new int[]
			{
            0x4CCA, 0x4CCB, 0x4CCC, 0x4CCD, 0x4CD0, 0x4CD3, 0x4CD6, 0x4CD8,
            0x4CDA, 0x4CDD, 0x4CE0, 0x4CE3, 0x4CE6, 0x4CF8, 0x4CFB, 0x4CFE,
            0x4D01, 0x4D41, 0x4D42, 0x4D43, 0x4D44, 0x4D57, 0x4D58, 0x4D59,
            0x4D5A, 0x4D5B, 0x4D6E, 0x4D6F, 0x4D70, 0x4D71, 0x4D72, 0x4D84,
            0x4D85, 0x4D86, 0x52B5, 0x52B6, 0x52B7, 0x52B8, 0x52B9, 0x52BA,
            0x52BB, 0x52BC, 0x52BD,
            0x4CCE, 0x4CCF, 0x4CD1, 0x4CD2, 0x4CD4, 0x4CD5, 0x4CD7, 0x4CD9,
            0x4CDB, 0x4CDC, 0x4CDE, 0x4CDF, 0x4CE1, 0x4CE2, 0x4CE4, 0x4CE5,
            0x4CE7, 0x4CE8, 0x4CF9, 0x4CFA, 0x4CFC, 0x4CFD, 0x4CFF, 0x4D00,
            0x4D02, 0x4D03, 0x4D45, 0x4D46, 0x4D47, 0x4D48, 0x4D49, 0x4D4A,
            0x4D4B, 0x4D4C, 0x4D4D, 0x4D4E, 0x4D4F, 0x4D50, 0x4D51, 0x4D52,
            0x4D53, 0x4D5C, 0x4D5D, 0x4D5E, 0x4D5F, 0x4D60, 0x4D61, 0x4D62,
            0x4D63, 0x4D64, 0x4D65, 0x4D66, 0x4D67, 0x4D68, 0x4D69, 0x4D73,
            0x4D74, 0x4D75, 0x4D76, 0x4D77, 0x4D78, 0x4D79, 0x4D7A, 0x4D7B,
            0x4D7C, 0x4D7D, 0x4D7E, 0x4D7F, 0x4D87, 0x4D88, 0x4D89, 0x4D8A,
            0x4D8B, 0x4D8C, 0x4D8D, 0x4D8E, 0x4D8F, 0x4D90, 0x4D95, 0x4D96,
            0x4D97, 0x4D99, 0x4D9A, 0x4D9B, 0x4D9D, 0x4D9E, 0x4D9F, 0x4DA1,
            0x4DA2, 0x4DA3, 0x4DA5, 0x4DA6, 0x4DA7, 0x4DA9, 0x4DAA, 0x4DAB,
            0x52BE, 0x52BF, 0x52C0, 0x52C1, 0x52C2, 0x52C3, 0x52C4, 0x52C5,
            0x52C6, 0x52C7
			};
			
        public bool m_Ljack;
        private DateTime m_NextUse;
        [CommandProperty(AccessLevel.GameMaster)]
        public DateTime NextUse { get { return m_NextUse; } set { m_NextUse = value; } }

        public override bool SubdueBeforeTame { get { return true; } }

        [Constructable]
        public LumberjackingBeetle()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a Lumberjacking beetle";
            Body = 0x317;
            BaseSoundID = 397;

            SetStr(831);
            SetDex(74, 80);
            SetInt(45);

            SetHits(801);
            SetMana(45);

            SetDamage(15, 20);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 55, 60);
            SetResistance(ResistanceType.Fire, 20, 25);
            SetResistance(ResistanceType.Cold, 20, 25);
            SetResistance(ResistanceType.Poison, 35, 40);
            SetResistance(ResistanceType.Energy, 50, 60);

            SetSkill(SkillName.Anatomy, 85, 90);
            SetSkill(SkillName.MagicResist, 30.1, 35);
            SetSkill(SkillName.Tactics, 91.5, 92);
            SetSkill(SkillName.Wrestling, 99.8, 100);
            SetSkill(SkillName.Carpentry, 120.0);
            SetSkill(SkillName.Lumberjacking, 50);
            Skills.Lumberjacking.Cap = 120;

            Fame = 2000;
            Karma = -2000;

            VirtualArmor = 38;

            Tamable = true;
            ControlSlots = 4;
            MinTameSkill = 71.1;

            Container pack = Backpack;
            if (pack != null) pack.Delete();
            pack = new StrongBackpack();
            pack.Movable = false;
            AddItem(pack);

            AddItem(new Gold(600));
            PackItem(new Log(5));
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
            AddLoot(LootPack.Gems);
        }

        public override void OnDeath(Container c)
        {
            base.OnDeath(c);

            if (Utility.RandomDouble() < 0.1)
                c.DropItem(new IBShovel());

            if (Utility.RandomDouble() < 0.15)
                c.DropItem(new IBAxe());

        }

        public override bool CanRummageCorpses { get { return true; } }
        public override int Meat { get { return 1; } }
        public override FoodType FavoriteFood { get { return FoodType.Meat; } }
        public override DeathMoveResult GetInventoryMoveResultFor(Item item) { return DeathMoveResult.MoveToCorpse; }
        public override bool AllowEquipFrom(Mobile from) { return (ControlMaster != null && ControlMaster == from); }
        public override bool CanBeRenamedBy(Mobile from) { return (ControlMaster != null && ControlMaster == from); }
        public override bool CanPaperdollBeOpenedBy(Mobile from) { return false; }
        public override bool CheckNonlocalDrop(Mobile from, Item item, Item target) { return PackAnimal.CheckAccess(this, from); }
        public override bool CheckNonlocalLift(Mobile from, Item item) { return PackAnimal.CheckAccess(this, from); }

        public override bool OnBeforeDeath()
        {
            if (!base.OnBeforeDeath()) return false;
            PackAnimal.CombineBackpacks(this);
            return base.OnBeforeDeath();
        }

        public override bool IsSnoop(Mobile from)
        {
            if (PackAnimal.CheckAccess(this, from)) return false;
            return base.IsSnoop(from);
        }

/*        public override bool OnDragDrop(Mobile from, Item item)
        {
            this.Skills.Lumberjacking.Cap = 120;
            if (CheckFeed(from, item)) return true;
            if (PackAnimal.CheckAccess(this, from))
            {
                if (item is BaseLog)
                {
                    BaseLog m_Log = item as BaseLog;

                    int toConsume = m_Log.Amount;

                    if (toConsume > 30000)
                    {
                        toConsume = 30000;
                    }
                    else if (m_Log.Amount < 1)
                    {
                        from.SendLocalizedMessage(501989); // You burn away the impurities but are left with no useable metal.
                        m_Log.Delete();
                        return true;
                    }

                    BaseLog log = m_Log.Axe(from, axe);

                    m_Log.Consume(toConsume);

                    this.Hue = m_Log.Hue;

                    from.PlaySound(0x57);

                    AddToBackpack(item);
                    AddToBackpack(new Log(10));
                    return true;
                }
            }

            return base.OnDragDrop(from, item);
        }*/

        public override void OnSpeech(SpeechEventArgs args)
        {
            string said = args.Speech.ToLower();
            Mobile from = args.Mobile;
            string bjack = this.Name + " " + "lumberjack";
            string bjack2 = bjack.ToLower();
            string bbreak = this.Name + " " + "takebreak";
            string bbreak2 = bbreak.ToLower();
            string bbreak3 = this.Name + " " + "take break";
            string bbreak4 = bbreak3.ToLower();
            if (said == this.Name.ToLower())
            {
                if (from == this.ControlMaster)
                {
                    this.Say("Yes?");
                }
                else
                {
                   
                        this.Say("You are not my master.");
                       
                    }
                }
            
            else if ((said == "lumberjack" || said == bjack2) && from == this.ControlMaster) { m_Ljack = true; ControlOrder = OrderType.Stay; }
            else if ((said == "takebreak" || said == "take break" || said == bbreak2 || said == bbreak4) && from == this.ControlMaster) m_Ljack = false;
            base.OnSpeech(args);
        }

        public override void GetContextMenuEntries(Mobile from, List<ContextMenuEntry> list)
        {
            base.GetContextMenuEntries(from, list);
            PackAnimal.GetContextMenuEntries(this, from, list);
        }

		public override void OnThink()
        {
            if (this.Region.IsPartOf(typeof(HouseRegion))) m_NextUse = DateTime.Now + TimeSpan.FromSeconds(2.5);
            else if (this.Alive && this.m_Ljack && this.m_NextUse <= DateTime.Now && Loyalty > 50)
            {
                Container backpack = this.Backpack;
                if (backpack == null) { m_NextUse = DateTime.Now + TimeSpan.FromSeconds(2.5); base.OnThink(); return; }
                if (backpack.TotalWeight >= backpack.MaxWeight || backpack.TotalItems >= backpack.MaxItems) { m_NextUse = DateTime.Now + TimeSpan.FromSeconds(2.5); base.OnThink(); return; }
                IBAxe ibaxe = (IBAxe)backpack.FindItemByType(typeof(IBAxe));
                //Shovel shovel = (Shovel)backpack.FindItemByType(typeof(Shovel));
                if (ibaxe != null)
                {
                    if (this.DoDisposeLog(this.X, this.Y, this.Z, this.Map, this))
                    {
                        ibaxe.UsesRemaining -= 1;
                        if (ibaxe != null && !ibaxe.Deleted && ibaxe.UsesRemaining <= 0) ibaxe.Delete();
                    }
                }
                else if (ibaxe != null)
                {
                    if (this.DoDisposeLog(this.X, this.Y, this.Z, this.Map, this))
                    {
                        ibaxe.UsesRemaining -= 1;
                        if (ibaxe != null && !ibaxe.Deleted && ibaxe.UsesRemaining <= 0) ibaxe.Delete();
                    }
                }
                m_NextUse = DateTime.Now + TimeSpan.FromSeconds(2.5);
            }
            base.OnThink();
        }

        public bool DoDisposeLog(int x, int y, int z, Map map, Mobile from)
        {
            HarvestBank bank = Lumberjacking.System.Definition.GetBank(map, x, y);
            if (bank == null)
            {
                this.Say("I can not lumberjack here");
                return false;
            }
            if (bank.Current <= 0) return false;
            HarvestVein vein = bank.DefaultVein;
            if (vein == null)
            {
                this.Say("I can not mine here");
                return false;
            }
            HarvestDefinition def = Lumberjacking.System.Definition;
            HarvestResource res = vein.PrimaryResource;
            Log log = Lumberjacking.System.Construct(res.Types[0], null) as Log;
            if (log == null) return false;
            if (log.Resource > CraftResource.RegularWood)
            {
                double minskill = 0.0;
                double minskill2 = 0.0;
                double maxskill = 0.0;
                double skillbase = this.Skills.Lumberjacking.Base;
                if (this.Skills.Lumberjacking.Base < 120.0) this.Say("skill = {0}", Convert.ToString(skillbase));
                switch (log.Resource)
                {
                    case CraftResource.RegularWood: { minskill = 00.0; minskill2 = 00.0; maxskill = 100.0; } break;
                    case CraftResource.AshTree: { minskill = 55.0; minskill2 = 25.0; maxskill = 105.0; } break;
                    case CraftResource.CherryTree: { minskill = 60.0; minskill2 = 30.0; maxskill = 110.0; } break;
                    case CraftResource.EbonyTree: { minskill = 65.0; minskill2 = 35.0; maxskill = 115.0; } break;
                    case CraftResource.GoldenOakTree: { minskill = 70.0; minskill2 = 40.0; maxskill = 120.0; } break;
                    case CraftResource.HickoryTree: { minskill = 75.0; minskill2 = 45.0; maxskill = 120.0; } break;
                    case CraftResource.MahoganyTree: { minskill = 80.0; minskill2 = 50.0; maxskill = 120.0; } break;
					
					case CraftResource.OakTree: { minskill = 85.0; minskill2 = 50.0; maxskill = 120.0; } break;
					case CraftResource.PineTree: { minskill = 90.0; minskill2 = 50.0; maxskill = 120.0; } break;
					case CraftResource.RosewoodTree: { minskill = 95.0; minskill2 = 50.0; maxskill = 120.0; } break;
					case CraftResource.WalnutTree: { minskill = 100.0; minskill2 = 50.0; maxskill = 120.0; } break;
					case CraftResource.ElvenTree: { minskill = 100.1; minskill2 = 50.0; maxskill = 120.0; } break;
					
					
                }
                if (Utility.RandomDouble() <= 0.30 || skillbase < minskill) { log = new Log(); minskill = 00.0; minskill2 = 00.0; maxskill = 100.0; }
                if (!(from.CheckSkill(SkillName.Lumberjacking, minskill2, maxskill)))
                {
                    log.Delete();
                    return false;
                }
            }
            log.Amount = (map == Map.Felucca ? 2 : 1);
            if (from != null) from.AddToBackpack(log);
            else log.Delete();
            bank.Consume( log.Amount, this);
            this.Hue = log.Hue;
            
            return true;
        }

        public LumberjackingBeetle(Serial serial): base(serial)
        {
        }
            public override void Serialize(GenericWriter writer)
            {
                base.Serialize(writer);
                writer.Write((int)0);
            }

            public override void Deserialize(GenericReader reader)
            {
                base.Deserialize(reader);
                int version = reader.ReadInt();
            }
        }
		#endregion
    }