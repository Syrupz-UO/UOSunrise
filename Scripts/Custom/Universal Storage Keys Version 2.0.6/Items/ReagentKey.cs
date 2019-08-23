using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;							//for connection to resource store data objects
using Server.Engines.VeteranRewards;
using Server.Misc;
using Server.Spells;
using Server.ACC.CSS.Systems.Avatar;
using Server.ACC.CSS.Systems.Cleric;
using Server.ACC.CSS.Systems.Druid;
using Server.ACC.CSS.Systems.Bard;
using Server.ACC.CSS.Systems.Ranger;
using Server.ACC.CSS.Systems.Rogue;


namespace Server.Items
{
    //item derived from BaseResourceKey
    public class ReagentKey : BaseStoreKey, IRewardItem
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
			//	entry.Add( new ResourceEntry( typeof( FertileDirt ), "Fertile Dirt", 0, 25, 0, 0  ) );
				entry.Add(new ResourceEntry(typeof(UnknownReagent),"Unitentified Reagents"));
                entry.Add(new ResourceEntry(typeof(BlackPearl),"Black Pearl"));
                entry.Add(new ResourceEntry(typeof(Bloodmoss),"Bloodmoss"));
                entry.Add(new ResourceEntry(typeof(MandrakeRoot),"Mandrake Root"));
                entry.Add(new ResourceEntry(typeof(SpidersSilk),"Spider's Silk"));
                entry.Add(new ResourceEntry(typeof(Nightshade),"Nightshade"));
                entry.Add(new ResourceEntry(typeof(SulfurousAsh),"Sulfurous Ash"));
                entry.Add(new ResourceEntry(typeof(Garlic),"Garlic"));
                entry.Add(new ResourceEntry(typeof(Ginseng),"Ginseng"));
                entry.Add(new ResourceEntry(typeof(NoxCrystal),"Nox Crystal"));
                entry.Add(new ResourceEntry(typeof(PigIron),"Pig Iron"));
                entry.Add(new ResourceEntry(typeof(GraveDust),"Grave Dust"));
                entry.Add(new ResourceEntry(typeof(BatWing),"Bat Wing"));
                entry.Add(new ResourceEntry(typeof(DaemonBlood),"Daemon Blood"));
                entry.Add(new ResourceEntry(typeof(Bottle),"Empty Bottle"));
                entry.Add(new ResourceEntry(typeof(PotionKeg),"Potion Keg"));
                entry.Add(new ResourceEntry(typeof(FertileDirt),"Fertile Dirt"));
                entry.Add(new ResourceEntry(typeof(KeyRing),"Key Ring"));
                entry.Add(new ResourceEntry(typeof(Beeswax),"Beeswax"));
                entry.Add(new ResourceEntry(typeof(DaemonBone),"Daemon Bone"));
                entry.Add(new ResourceEntry(typeof(DeadWood),"Dead Wood"));
                entry.Add(new ResourceEntry(typeof(Bone),"Bone"));
                entry.Add(new ResourceEntry(typeof(Sand),"Sand"));
                entry.Add(new ResourceEntry(typeof(BlankScroll),"Blank Scroll"));

				entry.Add( new ResourceEntry( typeof( Brimstone ), "Brimstone" ) );
				entry.Add( new ResourceEntry( typeof( ButterflyWings ), "ButterflyWings" ) );
				entry.Add( new ResourceEntry( typeof( EyeOfToad ), "EyeOfToad" ) );
				entry.Add( new ResourceEntry( typeof( FairyEgg ), "FairyEgg" ) );
				entry.Add( new ResourceEntry( typeof( GargoyleEar ), "GargoyleEar" ) );
				entry.Add( new ResourceEntry( typeof( BeetleShell ), "BeetleShell" ) );
				entry.Add( new ResourceEntry( typeof( MoonCrystal ), "MoonCrystal" ) );
				entry.Add( new ResourceEntry( typeof(PixieSkull ), "PixieSkull" ) );
				entry.Add( new ResourceEntry( typeof(RedLotus  ), "RedLotus " ) );
				entry.Add( new ResourceEntry( typeof( SeaSalt ), "SeaSalt" ) );
				entry.Add( new ResourceEntry( typeof( SilverWidow ), "SilverWidow" ) );
				entry.Add( new ResourceEntry( typeof( SwampBerries ), "SwampBerries" ) );
				
				
				//
						entry.Add( new ToolEntry( typeof( ScribesPen ), "Scribe's Pen" ) );
				entry.Add( new ResourceEntry( typeof( BlankScroll ), "Blank Scrolls" ) );
				entry.Add( new ResourceEntry( typeof( RecallRune ), "Blank Runes" ) );
				entry.Add(new ResourceEntry(typeof(UnknownScroll),"Unitentified Scroll"));
				entry.Add( new ColumnSeparationEntry() );
				//entry.Add( new ListEntry( typeof( Spellbook ), typeof( SpellbookListEntry ), "Spell Books" ) );
				entry.Add( new ResourceEntry( typeof( ClumsyScroll ), "Clumsy" ) );
				entry.Add( new ResourceEntry( typeof( CreateFoodScroll ), "Create Food" ) );
				entry.Add( new ResourceEntry( typeof( FeeblemindScroll ), "Feeblemind" ) );
				entry.Add( new ResourceEntry( typeof( HealScroll ), "Heal" ) );
				entry.Add( new ResourceEntry( typeof( MagicArrowScroll ), "Magic Arrow" ) );
				entry.Add( new ResourceEntry( typeof( NightSightScroll ), "Night Sight" ) );
				entry.Add( new ResourceEntry( typeof( ReactiveArmorScroll ), "Reactive Armor" ) );
				entry.Add( new ResourceEntry( typeof( WeakenScroll ), "Weaken" ) );
				entry.Add( new ColumnSeparationEntry() );
				entry.Add( new ResourceEntry( typeof( AgilityScroll ), "Agility" ) );
				entry.Add( new ResourceEntry( typeof( CunningScroll ), "Cunning" ) );
				entry.Add( new ResourceEntry( typeof( CureScroll ), "Cure" ) );
				entry.Add( new ResourceEntry( typeof( HarmScroll ), "Harm" ) );
				entry.Add( new ResourceEntry( typeof( MagicTrapScroll ), "Magic Trap" ) );
				entry.Add( new ResourceEntry( typeof( MagicUnTrapScroll ), "Magic Untrap" ) );
				entry.Add( new ResourceEntry( typeof( ProtectionScroll ), "Protection" ) );
				entry.Add( new ResourceEntry( typeof( StrengthScroll ), "Strength" ) );
				entry.Add( new ColumnSeparationEntry() );
				entry.Add( new ResourceEntry( typeof( BlessScroll ), "Bless" ) );
				entry.Add( new ResourceEntry( typeof( FireballScroll ), "Fireball" ) );
				entry.Add( new ResourceEntry( typeof( MagicLockScroll ), "Magic Lock" ) );
				entry.Add( new ResourceEntry( typeof( PoisonScroll ), "Poison" ) );
				entry.Add( new ResourceEntry( typeof( TelekinisisScroll ), "Telekinisis" ) );
				entry.Add( new ResourceEntry( typeof( TeleportScroll ), "Teleport" ) );
				entry.Add( new ResourceEntry( typeof( UnlockScroll ), "Unlock" ) );
				entry.Add( new ResourceEntry( typeof( WallOfStoneScroll ), "Wall of Stone" ) );
				entry.Add( new ColumnSeparationEntry() );
				entry.Add( new ResourceEntry( typeof( ArchCureScroll ), "Arch Cure" ) );
				entry.Add( new ResourceEntry( typeof( ArchProtectionScroll ), "Arch Protection" ) );
				entry.Add( new ResourceEntry( typeof( CurseScroll ), "Curse" ) );
				entry.Add( new ResourceEntry( typeof( FireFieldScroll ), "Fire Field" ) );
				entry.Add( new ResourceEntry( typeof( GreaterHealScroll ), "Greater Heal" ) );
				entry.Add( new ResourceEntry( typeof( LightningScroll ), "Lightning" ) );
				entry.Add( new ResourceEntry( typeof( ManaDrainScroll ), "Mana Drain" ) );
				entry.Add( new ResourceEntry( typeof( RecallScroll ), "Recall" ) );
				entry.Add( new ColumnSeparationEntry() );
				entry.Add( new ResourceEntry( typeof( BladeSpiritsScroll ), "Blade Spirits" ) );
				entry.Add( new ResourceEntry( typeof( DispelFieldScroll ), "Dispel Field" ) );
				entry.Add( new ResourceEntry( typeof( IncognitoScroll ), "Incognito" ) );
				entry.Add( new ResourceEntry( typeof( MagicReflectScroll ), "Magic Reflection" ) );
				entry.Add( new ResourceEntry( typeof( MindBlastScroll ), "Mind Blast" ) );
				entry.Add( new ResourceEntry( typeof( ParalyzeScroll ), "Paralyze" ) );
				entry.Add( new ResourceEntry( typeof( PoisonFieldScroll ), "Poison Field" ) );
				entry.Add( new ResourceEntry( typeof( SummonCreatureScroll ), "Summ. Creature" ) );
				entry.Add( new ColumnSeparationEntry() );
				entry.Add( new ResourceEntry( typeof( DispelScroll ), "Dispel" ) );
				entry.Add( new ResourceEntry( typeof( EnergyBoltScroll ), "EnergyBolt" ) );
				entry.Add( new ResourceEntry( typeof( ExplosionScroll ), "Explosion" ) );
				entry.Add( new ResourceEntry( typeof( InvisibilityScroll ), "Invisibility" ) );
				entry.Add( new ResourceEntry( typeof( MarkScroll ), "Mark" ) );
				entry.Add( new ResourceEntry( typeof( MassCurseScroll ), "Mass Curse" ) );
				entry.Add( new ResourceEntry( typeof( ParalyzeFieldScroll ), "Paralyze Field" ) );
				entry.Add( new ResourceEntry( typeof( RevealScroll ), "Reveal" ) );
				entry.Add( new ColumnSeparationEntry() );
				entry.Add( new ResourceEntry( typeof( ChainLightningScroll ), "Chain Lightning" ) );
				entry.Add( new ResourceEntry( typeof( EnergyFieldScroll ), "Energy Field" ) );
				entry.Add( new ResourceEntry( typeof( FlamestrikeScroll ), "Flame Strike" ) );
				entry.Add( new ResourceEntry( typeof( GateTravelScroll ), "Gate Travel" ) );
				entry.Add( new ResourceEntry( typeof( ManaVampireScroll ), "ManaVampire" ) );
				entry.Add( new ResourceEntry( typeof( MassDispelScroll ), "Mass Dispel" ) );
				entry.Add( new ResourceEntry( typeof( MeteorSwarmScroll ), "Meteor Swarm" ) );
				entry.Add( new ResourceEntry( typeof( PolymorphScroll ), "Polymorph" ) );
				entry.Add( new ColumnSeparationEntry() );
				entry.Add( new ResourceEntry( typeof( EarthquakeScroll ), "Earthquake" ) );
				entry.Add( new ResourceEntry( typeof( EnergyVortexScroll ), "Energy Vortex" ) );
				entry.Add( new ResourceEntry( typeof( ResurrectionScroll ), "Resurrection" ) );
				entry.Add( new ResourceEntry( typeof( SummonAirElementalScroll ), "Air Elemental" ) );
				entry.Add( new ResourceEntry( typeof( SummonDaemonScroll ), "Summ. Daemon" ) );
				entry.Add( new ResourceEntry( typeof( SummonEarthElementalScroll ), "Earth Elemental" ) );
				entry.Add( new ResourceEntry( typeof( SummonFireElementalScroll ), "Fire Elemental" ) );
				entry.Add( new ResourceEntry( typeof( SummonWaterElementalScroll ), "Water Elemental" ) );
				entry.Add( new ColumnSeparationEntry() );
				entry.Add( new ResourceEntry( typeof( AnimateDeadScroll ), "Animate Dead" ) );
				entry.Add( new ResourceEntry( typeof( BloodOathScroll ), "Blood Oath" ) );
				entry.Add( new ResourceEntry( typeof( CorpseSkinScroll ), "Corpse Skin" ) );
				entry.Add( new ResourceEntry( typeof( CurseWeaponScroll ), "Curse Weapon" ) );
				entry.Add( new ResourceEntry( typeof( EvilOmenScroll ), "Evil Omen" ) );
				entry.Add( new ResourceEntry( typeof( ExorcismScroll ), "Exorcism" ) );
				entry.Add( new ResourceEntry( typeof( HorrificBeastScroll ), "Horrific Beast" ) );
				entry.Add( new ResourceEntry( typeof( LichFormScroll ), "Lich Form" ) );
				entry.Add( new ColumnSeparationEntry() );
				entry.Add( new ResourceEntry( typeof( MindRotScroll ), "Mind Rot" ) );
				entry.Add( new ResourceEntry( typeof( PainSpikeScroll ), "Pain Spike" ) );
				entry.Add( new ResourceEntry( typeof( PoisonStrikeScroll ), "Poison Strike" ) );
				entry.Add( new ResourceEntry( typeof( StrangleScroll ), "Strangle" ) );
				entry.Add( new ResourceEntry( typeof( SummonFamiliarScroll ), "Summ. Familiar" ) );
				entry.Add( new ResourceEntry( typeof( VampiricEmbraceScroll ), "Vamp. Embrace" ) );
				entry.Add( new ResourceEntry( typeof( VengefulSpiritScroll ), "Vengeful Spirit" ) );
				entry.Add( new ResourceEntry( typeof( WitherScroll ), "Wither" ) );
				entry.Add( new ResourceEntry( typeof( WraithFormScroll ), "Wraith Form" ) );
				
				entry.Add( new ResourceEntry( typeof( RogueCharmScroll ), "Charm" ) );
				entry.Add( new ResourceEntry( typeof( RogueFalseCoinScroll ), "False Coin" ) );
				entry.Add( new ResourceEntry( typeof( RogueIntimidationScroll ), "Intimidation" ) );
				entry.Add( new ResourceEntry( typeof( WraithFormScroll ), "Wraith Form" ) );
				entry.Add( new ResourceEntry( typeof( RogueShadowScroll ), "Shadow" ) );
				entry.Add( new ResourceEntry( typeof( RogueSlyFoxScroll ), "Sly Fox" ) );
				
				entry.Add( new ResourceEntry( typeof( RangerFireBowScroll ), "Fire Bow" ) );
				entry.Add( new ResourceEntry( typeof( RangerHuntersAimScroll ), "Hunter's Aim" ) );
				entry.Add( new ResourceEntry( typeof( RangerIceBowScroll ), "Ice Bow" ) );
				entry.Add( new ResourceEntry( typeof( RangerLightningBowScroll ), "Lightning Bow" ) );
				entry.Add( new ResourceEntry( typeof( RangerNoxBowScroll ), "Nox Bow" ) );
				entry.Add( new ResourceEntry( typeof( RangerPhoenixFlightScroll ), "Phoenix Flight" ) );
				entry.Add( new ResourceEntry( typeof( RangerFamiliarScroll ), "Ranger Familiar" ) );
				entry.Add( new ResourceEntry( typeof( RangerSummonMountScroll ), "Summon Mount" ) );
				
				entry.Add( new ResourceEntry( typeof( DruidBlendWithForestScroll ), "Blend With Forest" ) );
				entry.Add( new ResourceEntry( typeof( DruidFamiliarScroll ), "Druid Familiar" ) );
				entry.Add( new ResourceEntry( typeof( DruidEnchantedGroveScroll ), "Enchanted Grove" ) );
				entry.Add( new ResourceEntry( typeof( DruidGraspingRootsScroll ), "Grasping Roots" ) );
				entry.Add( new ResourceEntry( typeof( DruidHollowReedScroll ), "Hollow Reed" ) );
				entry.Add( new ResourceEntry( typeof( DruidLeafWhirlwindScroll ), "Leaf Whirlwind" ) );
				entry.Add( new ResourceEntry( typeof( DruidLureStoneScroll ), "Lure Stone" ) );
				entry.Add( new ResourceEntry( typeof( DruidMushroomGatewayScroll ), "Mushroom Gateway" ) );
				entry.Add( new ResourceEntry( typeof( DruidNaturesPassageScroll ), "Nature's Passage" ) );
				entry.Add( new ResourceEntry( typeof( DruidPackOfBeastScroll ), "Pack of Beasts" ) );
				entry.Add( new ResourceEntry( typeof( DruidRestorativeSoilScroll ), "Restorative Soil" ) );
				entry.Add( new ResourceEntry( typeof( DruidShieldOfEarthScroll ), "Shield of Earth" ) );
				entry.Add( new ResourceEntry( typeof( DruidSpringOfLifeScroll ), "Spring of Life" ) );
				entry.Add( new ResourceEntry( typeof( DruidStoneCircleScroll ), "Stone Circle" ) );
				entry.Add( new ResourceEntry( typeof( DruidSwarmOfInsectsScroll ), "Swarm of Insects" ) );
				entry.Add( new ResourceEntry( typeof( DruidVolcanicEruptionScroll ), "Volcanic Eruption" ) );
				
				
				entry.Add( new ResourceEntry( typeof( ClericAngelicFaithScroll ), "Angelic Faith" ) );
				entry.Add( new ResourceEntry( typeof( ClericBanishEvilScroll ), "Banish Evil" ) );
				entry.Add( new ResourceEntry( typeof( ClericDampenSpiritScroll ), "Dampen Spirit" ) );
				entry.Add( new ResourceEntry( typeof( ClericDivineFocusScroll ), "Divine Focus" ) );
				entry.Add( new ResourceEntry( typeof( ClericHammerOfFaithScroll ), "Hammer of Faith" ) );
				entry.Add( new ResourceEntry( typeof( ClericPurgeScroll ), "Purge" ) );
				entry.Add( new ResourceEntry( typeof( ClericRestorationScroll ), "Restoration" ) );
				entry.Add( new ResourceEntry( typeof( ClericSacredBoonScroll ), "Sacred Boon" ) );
				entry.Add( new ResourceEntry( typeof( ClericSacrificeScroll ), "Sacrifice" ) );
				entry.Add( new ResourceEntry( typeof( ClericSmiteScroll ), "Smite" ) );
				entry.Add( new ResourceEntry( typeof( ClericTouchOfLifeScroll ), "Touch of Life" ) );
				entry.Add( new ResourceEntry( typeof( ClericTrialByFireScroll ), "Trial by Fire" ) );
				
				
				entry.Add( new ResourceEntry( typeof( BardArmysPaeonScroll ), "Army's Paeon" ) );
				entry.Add( new ResourceEntry( typeof( BardEnchantingEtudeScroll ), "Enchanting Etude" ) );
				entry.Add( new ResourceEntry( typeof( BardEnergyCarolScroll ), "Energy Carol" ) );
				entry.Add( new ResourceEntry( typeof( BardEnergyThrenodyScroll ), "Energy Threnody" ) );
				entry.Add( new ResourceEntry( typeof( BardFireCarolScroll ), "Fire Carol" ) );
				entry.Add( new ResourceEntry( typeof( BardFireThrenodyScroll ), "Fire Threnody" ) );
				entry.Add( new ResourceEntry( typeof( BardFoeRequiemScroll ), "Foe Requiem" ) );
				entry.Add( new ResourceEntry( typeof( BardIceCarolScroll ), "Ice Carol" ) );
				entry.Add( new ResourceEntry( typeof( BardIceThrenodyScroll ), "Ice Threnody" ) );
				entry.Add( new ResourceEntry( typeof( BardKnightsMinneScroll ), "Knight's Menne" ) );
				entry.Add( new ResourceEntry( typeof( BardMagesBalladScroll ), "Mage's Ballad" ) );
				entry.Add( new ResourceEntry( typeof( BardMagicFinaleScroll ), "MagicFinale" ) );
				entry.Add( new ResourceEntry( typeof( BardPoisonCarolScroll ), "Poison Carol" ) );
				entry.Add( new ResourceEntry( typeof( BardPoisonThrenodyScroll ), "Poison Threnody" ) );
				entry.Add( new ResourceEntry( typeof( BardSheepfoeMamboScroll  ), "Sheepfoe Mambo" ) );
				entry.Add( new ResourceEntry( typeof( BardSinewyEtudeScroll ), "Sinewy Etude" ) );
				
				entry.Add( new ResourceEntry( typeof( AvatarHeavenlyLightScroll ), "Heavenly Light" ) );
				entry.Add( new ResourceEntry( typeof( AvatarHeavensGateScroll ), "Heaven's Gate" ) );
				entry.Add( new ResourceEntry( typeof( AvatarMarkOfGodsScroll ), "Mark of Gods" ) );
			
				
				//
                return entry;
            }
        }

        [Constructable]
        public ReagentKey() : base(0x0)     // hue 33
        {
            ItemID = 0x18DE;            //fancy mandrake root
            Name = "Caster's Keys";
			LootType=LootType.Blessed;
        }

        //this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
        protected override ItemStore GenerateItemStore()
        {
            //load the basic store info
            ItemStore store = base.GenerateItemStore();

            //properties of this storage device
            store.Label = "Reagent Storage";

            store.Dynamic = false;
            store.OfferDeeds = true;
            return store;
        }

        //serial constructor
        public ReagentKey(Serial serial) : base(serial)
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