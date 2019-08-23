using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;							//for connection to resource store data objects
using Server.Engines.VeteranRewards;

namespace Server.Items
{
    //item derived from BaseResourceKey
    [Flipable(0x185D,0x185E)]
    public class PotionKey : BaseStoreKey, IRewardItem
    {
        private bool m_IsRewardItem;

        [CommandProperty(AccessLevel.Seer)]
        public bool IsRewardItem
        {
            get { return m_IsRewardItem; }
            set { m_IsRewardItem = value; InvalidateProperties(); }
        }

		//set the # of columns of entries to display on the gump.. default is 2
		public override int DisplayColumns{ get{ return 3; } }
		
		
		public override List<StoreEntry> EntryStructure
		{
			get
			{
				List<StoreEntry> entry = base.EntryStructure;
				
				
				entry.Add( new ResourceEntry( typeof( UnknownKeg ), "Unitentified Keg" ) );
				entry.Add(new ResourceEntry(typeof(UnknownLiquid),"Unitentified Liquid"));
				entry.Add( new ResourceEntry( typeof( CurePotionPet ), "Pet Cure Potion" ) );
				entry.Add( new ResourceEntry( typeof( GreaterCurePotionPet ), "Greater Pet Cure Potion" ) );
				entry.Add( new ResourceEntry( typeof( GreaterHealPotionPet ), "Greater Pet Heal Potion" ) );
				entry.Add( new ResourceEntry( typeof( HealPotionPet ), "Pet Heal Potion" ) );
				entry.Add( new ResourceEntry( typeof( PetResurrectPotion ), "Pet Resurrect Potion" ) );
				entry.Add( new ResourceEntry( typeof( PetShrinkPotion ), "Pet Shrink Potion" ) );
				
				entry.Add( new ResourceEntry( typeof( BlackPetDye ), "Black Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( BlazePetDye ), "Blaze Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( BloodPetDye ), "Blood Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( GoldPetDye ), "Gold Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( IceBluePetDye ), "Ice Blue Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( IceGreenPetDye ), "Ice Green Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( MossGreenPetDye ), "Moss Green Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( PinkPetDye ), "Pink Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( WhitePetDye ), "White Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( BluePetDye ), "Blue Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( GreenPetDye ), "Green Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( OrangePetDye ), "Orange Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( PurplePetDye ), "Purple Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( RedPetDye ), "Red Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( YellowPetDye ), "Yellow Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( FrostBluePetDye ), "Frost Blue Pet Dye" ) );
				entry.Add( new ResourceEntry( typeof( IceWhitePetDye ), "Ice White Pet Dye" ) );
				//entry.Add( new ResourceEntry( typeof( Bottle ), "Empty Bottle" ) );
				
				
				entry.Add( new ResourceEntry( typeof( AutoResPotion ), "AutoRes Potion" ) );
				entry.Add( new ResourceEntry( typeof( BottleOfAcid), "Bottle of Acid" ) );
				//entry.Add( new ResourceEntry( typeof( CanopicJar ), "Canopic Jar" ) );
				entry.Add( new ResourceEntry( typeof( DurabilityPotion ), "Durability Potion" ) );
			//	entry.Add( new ResourceEntry( typeof( EmptyCanopicJar ), "Empty Canopic Jar" ) );
				entry.Add( new ResourceEntry( typeof( EvilSkull ), "Evil Skull" ) );
				entry.Add( new ResourceEntry( typeof( HairDyeBottle ), "Hair Dye Bottle" ) );
				entry.Add( new ResourceEntry( typeof( HairDyePotion ), "Hair Dye Potion" ) );
				entry.Add( new ResourceEntry( typeof( HairOilPotion ), "Hair Oil Potion" ) );
				entry.Add( new ResourceEntry( typeof( HolyWater ), "Holy Water" ) );
				entry.Add( new ResourceEntry( typeof( InvulnerabilityPotion ), "Invulnerability Potion" ) );
				//entry.Add( new ResourceEntry( typeof( MonsterSplatter ), "Monster Splatter" ) );
				entry.Add( new ResourceEntry( typeof( NecroSkinPotion ), "Necro Skin Potion" ) );
				//entry.Add( new ResourceEntry( typeof( PotionCauldron ), "Potion Cauldron" ) );
				entry.Add( new ResourceEntry( typeof( RepairPotion ), "Repair Potion" ) );
				entry.Add( new ResourceEntry( typeof( ResurrectPotion ), "Resurrect Potion" ) );
				entry.Add( new ResourceEntry( typeof( SuperPotion ), "Super Potion" ) );
				entry.Add( new ResourceEntry( typeof( ConflagrationPotion ), "Conflagration Potion" ) );
				entry.Add( new ResourceEntry( typeof( GreaterConflagrationPotion ), "Greater Conflagration Potion" ) );
				entry.Add( new ResourceEntry( typeof( GreaterAgilityPotion ), "Greater Agility Potion" ) );
				entry.Add( new ResourceEntry( typeof( ConfusionBlastPotion ), "Confusion Blast Potion" ) );
				entry.Add( new ResourceEntry( typeof( GreaterConfusionBlastPotion ), "Greater Confusion Blast Potion" ) );
				entry.Add( new ResourceEntry( typeof( GreaterCurePotion ), "Greater Cure Potion" ) );
				entry.Add( new ResourceEntry( typeof( FrostbitePotion ), "Frostbite Potion" ) );
				entry.Add( new ResourceEntry( typeof( GreaterFrostbitePotion ), "Greater Frostbite Potion" ) );
				entry.Add( new ResourceEntry( typeof( LethalPoisonPotion ), "Lethal Poison Potion" ) );
				entry.Add( new ResourceEntry( typeof( VenomSack ), "Venom Sack" ) );
				entry.Add( new ResourceEntry( typeof( NightSightPotion ), "Night Sight Potion" ) );
				entry.Add( new ResourceEntry( typeof( GreaterInvisibilityPotion ), "Greater Invisibility Potion" ) );
				entry.Add( new ResourceEntry( typeof( InvisibilityPotion ), "Invisibility Potion" ) );
				entry.Add( new ResourceEntry( typeof( GreaterManaPotion ), "Greater Mana Potion" ) );
				entry.Add( new ResourceEntry( typeof( GreaterRejuvenatePotion ), "Greater Rejuvenate Potion" ) );
				entry.Add( new ResourceEntry( typeof( LesserInvisibilityPotion ), "Lesser Invisibility Potion" ) );
				entry.Add( new ResourceEntry( typeof( LesserManaPotion ), "Lesser Mana Potion" ) );
				entry.Add( new ResourceEntry( typeof( LesserRejuvenatePotion ), "Lesser Rejuvenate Potion" ) );
				entry.Add( new ResourceEntry( typeof( ManaPotion ), "Mana Potion" ) );
				entry.Add( new ResourceEntry( typeof( RejuvenatePotion ), "Rejuvenate Potion" ) );
				entry.Add( new ResourceEntry( typeof( OilAmethyst ), "Amethyst Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilCaddellite ), "Caddellite Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilEmerald ), "Emerald Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilGarnet ), "Garnet Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilIce ), "Ice Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilJade ), "Jade Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilLeather ), "Leather Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilMarble ), "Marble Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilMetal ), "Metal Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilOnyx ), "Onyx Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilQuartz ), "Quartz Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilRuby ), "Ruby Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilSapphire ), "Sapphire Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilSilver ), "Silver Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilSpinel ), "Spinel Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilStarRuby ), "Star Ruby Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilTopaz ), "Topaz Oil" ) );
				entry.Add( new ResourceEntry( typeof( OilWood ), "Wood Oil" ) );
				entry.Add( new ResourceEntry( typeof( LiquidFire ), "Liquid Fire" ) );
				entry.Add( new ResourceEntry( typeof( LiquidGoo ), "Liquid Goo" ) );
				entry.Add( new ResourceEntry( typeof( LiquidIce ), "Liquid Ice" ) );
				entry.Add( new ResourceEntry( typeof( LiquidPain ), "Liquid Pain" ) );
				entry.Add( new ResourceEntry( typeof( LiquidRot ), "Liquid Rot" ) );
				entry.Add( new ResourceEntry( typeof( MixtureDiseasedSlime ), "Diseased Slime Mixture" ) );
				entry.Add( new ResourceEntry( typeof( MixtureFireSlime ), "Fire Slime Mixture" ) );
				entry.Add( new ResourceEntry( typeof( MixtureIceSlime ), "Ice Slime Mixture" ) );
				entry.Add( new ResourceEntry( typeof( MixtureRadiatedSlime ), "Radiated Slime Mixture" ) );
				entry.Add( new ResourceEntry( typeof( MixtureSlime ), "Slime Mixture" ) );
				entry.Add( new ResourceEntry( typeof( ElixirAlchemy ), "Elixir of Alchemy" ) );
				entry.Add( new ResourceEntry( typeof( ElixirAnimalTaming ), "Elixir of Animal Taming" ) );
				entry.Add( new ResourceEntry( typeof( ElixirAnimalLore ), "Elixir of Animal Lore" ) );
				entry.Add( new ResourceEntry( typeof( ElixirAnatomy ), "Elixir of Anatomy" ) );
				entry.Add( new ResourceEntry( typeof( ElixirArchery ), "Elixir of Archery" ) );
				entry.Add( new ResourceEntry( typeof( ElixirArmsLore ), "Elixir of Arms Lore" ) );
				entry.Add( new ResourceEntry( typeof( ElixirBegging ), "Elixir of Begging" ) );
				entry.Add( new ResourceEntry( typeof( ElixirBlacksmith ), "Elixir of Blacksmithy" ) );
				entry.Add( new ResourceEntry( typeof( ElixirCamping ), "Elixir of Camping" ) );
				entry.Add( new ResourceEntry( typeof( ElixirCarpentry ), "Elixir of Carpentry" ) );
				entry.Add( new ResourceEntry( typeof( ElixirCartography ), "Elixir of Cartography" ) );
				entry.Add( new ResourceEntry( typeof( ElixirCooking ), "Elixir of Cooking" ) );
				entry.Add( new ResourceEntry( typeof( ElixirDetectHidden ), "Elixir of Detect Hidden" ) );
				entry.Add( new ResourceEntry( typeof( ElixirDiscordance ), "Elixir of Discordance" ) );
				entry.Add( new ResourceEntry( typeof( ElixirEvalInt ), "Elixir of Evaluate Intelligence" ) );
				entry.Add( new ResourceEntry( typeof( ElixirFencing ), "Elixir of Fencing" ) );
				entry.Add( new ResourceEntry( typeof( ElixirFishing ), "Elixir of Fishing" ) );
				entry.Add( new ResourceEntry( typeof( ElixirFletching ), "Elixir of Fletching" ) );
				entry.Add( new ResourceEntry( typeof( ElixirFocus ), "Elixir of Focus" ) );
				entry.Add( new ResourceEntry( typeof( ElixirForensics ), "Elixir of Forensics" ) );
				entry.Add( new ResourceEntry( typeof( ElixirHealing ), "Elixir of Healing" ) );
				entry.Add( new ResourceEntry( typeof( ElixirHerding ), "Elixir of Herding" ) );
				entry.Add( new ResourceEntry( typeof( ElixirHiding ), "Elixir of Hiding" ) );
				entry.Add( new ResourceEntry( typeof( ElixirInscribe ), "Elixir of Inscription" ) );
				entry.Add( new ResourceEntry( typeof( ElixirItemID ), "Elixir of ItemID" ) );
				entry.Add( new ResourceEntry( typeof( ElixirLockpicking ), "Elixir of Lockpicking" ) );
				entry.Add( new ResourceEntry( typeof( ElixirLumberjacking ), "Elixir of Lumberjacking" ) );
				entry.Add( new ResourceEntry( typeof( ElixirMacing ), "Elixir of Macing" ) );
				entry.Add( new ResourceEntry( typeof( ElixirMagicResist ), "Elixir of Magic Resist" ) );
				entry.Add( new ResourceEntry( typeof( ElixirMeditation ), "Elixir of Meditation" ) );
				entry.Add( new ResourceEntry( typeof( ElixirMining ), "Elixir of Mining" ) );
				entry.Add( new ResourceEntry( typeof( ElixirMusicianship ), "Elixir of Musicianship" ) );
				entry.Add( new ResourceEntry( typeof( ElixirParry ), "Elixir of Parry" ) );
				entry.Add( new ResourceEntry( typeof( ElixirPeacemaking ), "Elixir of Peacmaking" ) );
				entry.Add( new ResourceEntry( typeof( ElixirPoisoning ), "Elixir of Poisoning" ) );
				entry.Add( new ResourceEntry( typeof( ElixirProvocation ), "Elixir of Provocation" ) );
				entry.Add( new ResourceEntry( typeof( ElixirRemoveTrap ), "Elixir of Remove Trap" ) );
				entry.Add( new ResourceEntry( typeof( ElixirSnooping ), "Elixir of Snooping" ) );
				entry.Add( new ResourceEntry( typeof( ElixirSpiritSpeak ), "Elixir of Spirit Speak" ) );
				entry.Add( new ResourceEntry( typeof( ElixirStealing ), "Elixir of Stealing" ) );
				entry.Add( new ResourceEntry( typeof( ElixirStealth ), "Elixir of Stealth" ) );
				entry.Add( new ResourceEntry( typeof( ElixirSwords ), "Elixir of Swords" ) );
				entry.Add( new ResourceEntry( typeof( ElixirTactics ), "Elixir of Tactivs" ) );
				entry.Add( new ResourceEntry( typeof( ElixirTailoring ), "Elixir of Tailoring"  ) );
				entry.Add( new ResourceEntry( typeof( ElixirTasteID ), "Elixir of TasteID" ) );
				entry.Add( new ResourceEntry( typeof( ElixirTinkering ), "Elixir of Tinkering" ) );
				entry.Add( new ResourceEntry( typeof( ElixirTracking ), "Elixir of Tracking" ) );
				entry.Add( new ResourceEntry( typeof( ElixirVeterinary ), "Elixir of Veterinary" ) );
				entry.Add( new ResourceEntry( typeof( ElixirWrestling ), "Elixir of Wrestling" ) );
				
				
				
				
				
				entry.Add( new PotionEntry( typeof( AgilityPotion ), "Agility", 0, 20, 3, 0 ) );
				entry.Add( new PotionEntry( typeof( GreaterAgilityPotion ), "Greater Agility", 0, 20, 3, 0  ) );
				entry.Add( new PotionEntry( typeof( LesserCurePotion ), "Lesser Cure", 0, 20, -5, 0  ) );
				entry.Add( new PotionEntry( typeof( CurePotion ), "Cure Poison", 0, 20, -5, 0  ) );
				entry.Add( new PotionEntry( typeof( GreaterCurePotion ), "Greater Cure", 0, 20, -5, 0  ) );
				entry.Add( new PotionEntry( typeof( LesserExplosionPotion ), "Lesser Explosion", 0, 20, 7, 0  ) );
				entry.Add( new PotionEntry( typeof( ExplosionPotion ), "Explosion", 0, 20, 7, 0  ) );
				entry.Add( new PotionEntry( typeof( GreaterExplosionPotion ), "Greater Explosion", 0, 20, 7, 0  ) );
				entry.Add( new PotionEntry( typeof( LesserHealPotion ), "Lesser Heal", 0, 20, -7, 0  ) );
				entry.Add( new PotionEntry( typeof( HealPotion ), "Heal", 0, 20, -7, 0  ) );
				entry.Add( new PotionEntry( typeof( GreaterHealPotion ), "Greater Heal", 0, 20, -7, 0  ) );
				entry.Add( new PotionEntry( typeof( LesserPoisonPotion ), "Lesser Poison", 0, 20, 0, 0  ) );
				entry.Add( new PotionEntry( typeof( PoisonPotion ), "Poison", 0, 20, 0, 0  ) );
				entry.Add( new PotionEntry( typeof( GreaterPoisonPotion ), "Greater Poison", 0, 20, 0, 0  ) );
				entry.Add( new PotionEntry( typeof( DeadlyPoisonPotion ), "Deadly Poison", 0, 20, 0, 0  ) );
				entry.Add( new PotionEntry( typeof( RefreshPotion ), "Refresh", 0, 20, -10, 0  ) );
				entry.Add( new PotionEntry( typeof( TotalRefreshPotion ), "Total Refresh", 0, 20, -10, 0  ) );
				entry.Add( new PotionEntry( typeof( StrengthPotion ), "Strength", 0, 20, -5, 0  ) );
				entry.Add( new PotionEntry( typeof( GreaterStrengthPotion ), "Greater Strength", 0, 20, -5, 0  ) );
				entry.Add( new PotionEntry( typeof( NightSightPotion ), "Night Sight", 0, 20, 2, 0  ) );
				
				return entry;
            }
        }

        [Constructable]
        public PotionKey() : base(0x0)      //hue 48
        {
            ItemID = 0x185E;            //full vials
            Name = "Potion Storage";
			LootType=LootType.Blessed;
        }

        //this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
        protected override ItemStore GenerateItemStore()
        {
            //load the basic store info
            ItemStore store = base.GenerateItemStore();

            //properties of this storage device
            store.Label = "Potion Storage";

            store.Dynamic = false;
            store.OfferDeeds = true;

            return store;
        }

        //serial constructor
        public PotionKey(Serial serial) : base(serial)
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