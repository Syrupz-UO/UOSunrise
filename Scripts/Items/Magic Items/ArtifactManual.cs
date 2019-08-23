using System;
using Server;
using Server.Network;
using Server.Mobiles;
using Server.Items;
using System.Collections.Generic;
using Server.Misc;
using System.Collections;
using Server.Targeting;

namespace Server.Items
{
	public enum ArtyBookEffect
	{
		Charges
	}

    public class ArtifactManual : Item
	{
		private ArtyBookEffect m_ArtyBookEffect;
		private int m_Charges;

		[CommandProperty( AccessLevel.GameMaster )]
		public ArtyBookEffect Effect
		{
			get{ return m_ArtyBookEffect; }
			set{ m_ArtyBookEffect = value; InvalidateProperties(); }
		}

		[CommandProperty( AccessLevel.GameMaster )]
		public int Charges
		{
			get{ return m_Charges; }
			set{ m_Charges = value; InvalidateProperties(); }
		}

        [Constructable]
        public ArtifactManual() : base( 0xF05 )
		{
            Name = "Book of Rare Items";
			Hue = 0x961;
			ItemID = Utility.RandomList( 0xEA9, 0xF05 );
			Charges = Utility.RandomMinMax( 5, 25 );
			Weight = 1.0;
        }

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
            list.Add( 1070722, "This Can Identify An Item");
		}

        public override void OnDoubleClick( Mobile from )
		{
			if ( Charges > 0 )
			{
				Target t;

				if ( !IsChildOf( from.Backpack ) )
				{
					from.SendLocalizedMessage( 1060640 ); // The item must be in your backpack to use it.
				}
				else
				{
					from.SendMessage( "What do you want to research with this?" );
					t = new BookTarget( this );
					from.Target = t;
				}
			}
			else
			{
				from.SendMessage( "Finding nothing about it, you throw it away." );
				this.Delete();
			}
        }

		private class BookTarget : Target
		{
			private ArtifactManual m_Book;

			public BookTarget( ArtifactManual researched ) : base( 1, false, TargetFlags.None )
			{
				m_Book = researched;
			}

			protected override void OnTarget( Mobile from, object targeted )
			{
				if ( targeted is Item )
				{
					Item iBook = targeted as Item;

					if ( !iBook.IsChildOf( from.Backpack ) )
					{
						from.SendMessage( "You can only examine an item in your pack." );
					}
					else if ( ( iBook.IsChildOf( from.Backpack ) ) && ( iBook is UnknownReagent ) ) //////////////////////////////////////////////////////////////////////////
					{
						m_Book.Charges = m_Book.Charges - 1;
						UnknownReagent weed = targeted as UnknownReagent;
						Container pack = from.Backpack;

						int RegCount = weed.RegAmount;
						if ( RegCount < 1 ){ RegCount = 1; }

						int reagentType = Utility.RandomMinMax( 0, 15 );
						string reagentName = "";

						if ( reagentType == 0 ){ from.AddToBackpack( new BlackPearl( RegCount ) ); reagentName = "black pearl"; }
						else if ( reagentType == 1 ){ from.AddToBackpack( new Bloodmoss( RegCount ) ); reagentName = "bloodmoss"; }
						else if ( reagentType == 2 ){ from.AddToBackpack( new Garlic( RegCount ) ); reagentName = "garlic"; }
						else if ( reagentType == 3 ){ from.AddToBackpack( new Ginseng( RegCount ) ); reagentName = "ginseng"; }
						else if ( reagentType == 4 ){ from.AddToBackpack( new MandrakeRoot( RegCount ) ); reagentName = "mandrake root"; }
						else if ( reagentType == 5 ){ from.AddToBackpack( new Nightshade( RegCount ) ); reagentName = "nightshade"; }
						else if ( reagentType == 6 ){ from.AddToBackpack( new SulfurousAsh( RegCount ) ); reagentName = "sulfurous ash"; }
						else if ( reagentType == 7 ){ from.AddToBackpack( new SpidersSilk( RegCount ) ); reagentName = "spiders silk"; }
						else if ( reagentType == 8 ){ from.AddToBackpack( new BatWing( RegCount ) ); reagentName = "bat wing"; }
						else if ( reagentType == 9 ){ from.AddToBackpack( new GraveDust( RegCount ) ); reagentName = "grave dust"; }
						else if ( reagentType == 10 ){ from.AddToBackpack( new DaemonBlood( RegCount ) ); reagentName = "daemon blood"; }
						else if ( reagentType == 11 ){ from.AddToBackpack( new NoxCrystal( RegCount ) ); reagentName = "nox crystal"; }
						else if ( reagentType == 12 ){ from.AddToBackpack( new PigIron( RegCount ) ); reagentName = "pig iron"; }
						else if ( reagentType == 13 ){ from.AddToBackpack( new SackFlour() ); RegCount=1; reagentName = "regular flour"; }
						else if ( reagentType == 14 ){ from.AddToBackpack( new FertileDirt() ); RegCount=1; reagentName = "plain dirt"; }
						else { from.AddToBackpack( new Sand() ); RegCount=1; reagentName = "some sand"; }

						if ( RegCount < 2 ){ from.SendMessage( "This seems to be " + reagentName + "." ); }
						else { from.SendMessage( "This seems to be " + RegCount + " " + reagentName + "." ); }
						weed.Delete();
					}
					else if ( ( iBook.IsChildOf( from.Backpack ) ) && ( iBook is UnknownScroll ) ) //////////////////////////////////////////////////////////////////////////
					{
						m_Book.Charges = m_Book.Charges - 1;
						Container pack = from.Backpack;
						UnknownScroll rolls = (UnknownScroll)targeted;

						int paperType = 1;

						if ( rolls.ScrollType == 1 ) // MAGERY
						{
							if ( rolls.ScrollLevel == 2 ){ paperType = Utility.RandomMinMax( 13, 24 ); }
							else if ( rolls.ScrollLevel == 3 ){ paperType = Utility.RandomMinMax( 25, 36 ); }
							else if ( rolls.ScrollLevel == 4 ){ paperType = Utility.RandomMinMax( 37, 48 ); }
							else if ( rolls.ScrollLevel == 5 ){ paperType = Utility.RandomMinMax( 49, 60 ); }
							else if ( rolls.ScrollLevel == 6 ){ paperType = Utility.RandomMinMax( 57, 64 ); }
							else { paperType = Utility.RandomMinMax( 1, 12 ); }
						}
						else if ( rolls.ScrollType == 3 ) // BARD
						{
							paperType = Utility.RandomMinMax( 82, 97 );
						}
						else
						{
							if ( rolls.ScrollLevel == 2 ){ paperType = Utility.RandomMinMax( 68, 70 ); }
							else if ( rolls.ScrollLevel == 3 ){ paperType = Utility.RandomMinMax( 71, 73 ); }
							else if ( rolls.ScrollLevel == 4 ){ paperType = Utility.RandomMinMax( 74, 76 ); }
							else if ( rolls.ScrollLevel == 5 ){ paperType = Utility.RandomMinMax( 77, 79 ); }
							else if ( rolls.ScrollLevel == 6 ){ paperType = Utility.RandomMinMax( 80, 81 ); }
							else { paperType = Utility.RandomMinMax( 65, 67 ); }
						}

						string paperName = "";

						if ( Utility.RandomMinMax( 1, 100 ) > 10 )
						{
							if ( paperType == 1 ){ from.AddToBackpack( new ReactiveArmorScroll() ); paperName = "reactive armor"; }
							else if ( paperType == 2 ){ from.AddToBackpack( new ClumsyScroll() ); paperName = "clumsy"; }
							else if ( paperType == 3 ){ from.AddToBackpack( new CreateFoodScroll() ); paperName = "create food"; }
							else if ( paperType == 4 ){ from.AddToBackpack( new FeeblemindScroll() ); paperName = "feeblemind"; }
							else if ( paperType == 5 ){ from.AddToBackpack( new HealScroll() ); paperName = "heal"; }
							else if ( paperType == 6 ){ from.AddToBackpack( new MagicArrowScroll() ); paperName = "magic arrow"; }
							else if ( paperType == 7 ){ from.AddToBackpack( new NightSightScroll() ); paperName = "night sight"; }
							else if ( paperType == 8 ){ from.AddToBackpack( new WeakenScroll() ); paperName = "weaken"; }
							else if ( paperType == 9 ){ from.AddToBackpack( new AgilityScroll() ); paperName = "agility"; }
							else if ( paperType == 10 ){ from.AddToBackpack( new CunningScroll() ); paperName = "cunning"; }
							else if ( paperType == 11 ){ from.AddToBackpack( new CureScroll() ); paperName = "cure"; }
							else if ( paperType == 12 ){ from.AddToBackpack( new HarmScroll() ); paperName = "harm"; }
							else if ( paperType == 13 ){ from.AddToBackpack( new MagicTrapScroll() ); paperName = "magic trap"; }
							else if ( paperType == 14 ){ from.AddToBackpack( new MagicUnTrapScroll() ); paperName = "magic untrap"; }
							else if ( paperType == 15 ){ from.AddToBackpack( new ProtectionScroll() ); paperName = "protection"; }
							else if ( paperType == 16 ){ from.AddToBackpack( new StrengthScroll() ); paperName = "strength"; }
							else if ( paperType == 17 ){ from.AddToBackpack( new BlessScroll() ); paperName = "bless"; }
							else if ( paperType == 18 ){ from.AddToBackpack( new FireballScroll() ); paperName = "fireball"; }
							else if ( paperType == 19 ){ from.AddToBackpack( new MagicLockScroll() ); paperName = "magic lock"; }
							else if ( paperType == 20 ){ from.AddToBackpack( new PoisonScroll() ); paperName = "poison"; }
							else if ( paperType == 21 ){ from.AddToBackpack( new TelekinisisScroll() ); paperName = "telekinesis"; }
							else if ( paperType == 22 ){ from.AddToBackpack( new TeleportScroll() ); paperName = "teleport"; }
							else if ( paperType == 23 ){ from.AddToBackpack( new UnlockScroll() ); paperName = "unlock"; }
							else if ( paperType == 24 ){ from.AddToBackpack( new WallOfStoneScroll() ); paperName = "wall of stone"; }
							else if ( paperType == 25 ){ from.AddToBackpack( new ArchCureScroll() ); paperName = "arch cure"; }
							else if ( paperType == 26 ){ from.AddToBackpack( new ArchProtectionScroll() ); paperName = "arch protection"; }
							else if ( paperType == 27 ){ from.AddToBackpack( new CurseScroll() ); paperName = "curse"; }
							else if ( paperType == 28 ){ from.AddToBackpack( new FireFieldScroll() ); paperName = "fire field"; }
							else if ( paperType == 29 ){ from.AddToBackpack( new GreaterHealScroll() ); paperName = "greater heal"; }
							else if ( paperType == 30 ){ from.AddToBackpack( new LightningScroll() ); paperName = "lightning"; }
							else if ( paperType == 31 ){ from.AddToBackpack( new ManaDrainScroll() ); paperName = "mana drain"; }
							else if ( paperType == 32 ){ from.AddToBackpack( new RecallScroll() ); paperName = "recall"; }
							else if ( paperType == 33 ){ from.AddToBackpack( new BladeSpiritsScroll() ); paperName = "blade spirits"; }
							else if ( paperType == 34 ){ from.AddToBackpack( new DispelFieldScroll() ); paperName = "dispel field"; }
							else if ( paperType == 35 ){ from.AddToBackpack( new IncognitoScroll() ); paperName = "incognito"; }
							else if ( paperType == 36 ){ from.AddToBackpack( new MagicReflectScroll() ); paperName = "magic reflect"; }
							else if ( paperType == 37 ){ from.AddToBackpack( new MindBlastScroll() ); paperName = "mind blast"; }
							else if ( paperType == 38 ){ from.AddToBackpack( new ParalyzeScroll() ); paperName = "paralyze"; }
							else if ( paperType == 39 ){ from.AddToBackpack( new PoisonFieldScroll() ); paperName = "poison field"; }
							else if ( paperType == 40 ){ from.AddToBackpack( new SummonCreatureScroll() ); paperName = "summon creature"; }
							else if ( paperType == 41 ){ from.AddToBackpack( new DispelScroll() ); paperName = "dispel"; }
							else if ( paperType == 42 ){ from.AddToBackpack( new EnergyBoltScroll() ); paperName = "energy bolt"; }
							else if ( paperType == 43 ){ from.AddToBackpack( new ExplosionScroll() ); paperName = "explosion"; }
							else if ( paperType == 44 ){ from.AddToBackpack( new InvisibilityScroll() ); paperName = "invisibility"; }
							else if ( paperType == 45 ){ from.AddToBackpack( new MarkScroll() ); paperName = "mark"; }
							else if ( paperType == 46 ){ from.AddToBackpack( new MassCurseScroll() ); paperName = "mass curse"; }
							else if ( paperType == 47 ){ from.AddToBackpack( new ParalyzeFieldScroll() ); paperName = "paralyze field"; }
							else if ( paperType == 48 ){ from.AddToBackpack( new RevealScroll() ); paperName = "reveal"; }
							else if ( paperType == 49 ){ from.AddToBackpack( new ChainLightningScroll() ); paperName = "chain lightning"; }
							else if ( paperType == 50 ){ from.AddToBackpack( new EnergyFieldScroll() ); paperName = "energy field"; }
							else if ( paperType == 51 ){ from.AddToBackpack( new FlamestrikeScroll() ); paperName = "flamestrike"; }
							else if ( paperType == 52 ){ from.AddToBackpack( new GateTravelScroll() ); paperName = "gate travel"; }
							else if ( paperType == 53 ){ from.AddToBackpack( new ManaVampireScroll() ); paperName = "mana vampire"; }
							else if ( paperType == 54 ){ from.AddToBackpack( new MassDispelScroll() ); paperName = "mass dispel"; }
							else if ( paperType == 55 ){ from.AddToBackpack( new MeteorSwarmScroll() ); paperName = "meteor swarm"; }
							else if ( paperType == 56 ){ from.AddToBackpack( new PolymorphScroll() ); paperName = "polymorph"; }
							else if ( paperType == 57 ){ from.AddToBackpack( new EarthquakeScroll() ); paperName = "earthquake"; }
							else if ( paperType == 58 ){ from.AddToBackpack( new EnergyVortexScroll() ); paperName = "energy vortex"; }
							else if ( paperType == 59 ){ from.AddToBackpack( new ResurrectionScroll() ); paperName = "resurrection"; }
							else if ( paperType == 60 ){ from.AddToBackpack( new SummonAirElementalScroll() ); paperName = "summon air elemental"; }
							else if ( paperType == 61 ){ from.AddToBackpack( new SummonDaemonScroll() ); paperName = "summon daemon"; }
							else if ( paperType == 62 ){ from.AddToBackpack( new SummonEarthElementalScroll() ); paperName = "summon earth elemental"; }
							else if ( paperType == 63 ){ from.AddToBackpack( new SummonFireElementalScroll() ); paperName = "summon fire elemental"; }
							else if ( paperType == 64 ){ from.AddToBackpack( new SummonWaterElementalScroll() ); paperName = "summon water elemental"; }
							else if ( paperType == 65 ){ from.AddToBackpack( new CurseWeaponScroll() ); paperName = "curse weapon"; }
							else if ( paperType == 66 ){ from.AddToBackpack( new BloodOathScroll() ); paperName = "blood oath"; }
							else if ( paperType == 67 ){ from.AddToBackpack( new CorpseSkinScroll() ); paperName = "corpse skin"; }
							else if ( paperType == 68 ){ from.AddToBackpack( new EvilOmenScroll() ); paperName = "evil omen"; }
							else if ( paperType == 69 ){ from.AddToBackpack( new PainSpikeScroll() ); paperName = "pain spike"; }
							else if ( paperType == 70 ){ from.AddToBackpack( new WraithFormScroll() ); paperName = "wraith form"; }
							else if ( paperType == 71 ){ from.AddToBackpack( new MindRotScroll() ); paperName = "mind rot"; }
							else if ( paperType == 72 ){ from.AddToBackpack( new SummonFamiliarScroll() ); paperName = "summon familiar"; }
							else if ( paperType == 73 ){ from.AddToBackpack( new AnimateDeadScroll() ); paperName = "animate dead"; }
							else if ( paperType == 74 ){ from.AddToBackpack( new HorrificBeastScroll() ); paperName = "horrific beast"; }
							else if ( paperType == 75 ){ from.AddToBackpack( new PoisonStrikeScroll() ); paperName = "poison strike"; }
							else if ( paperType == 76 ){ from.AddToBackpack( new WitherScroll() ); paperName = "wither"; }
							else if ( paperType == 77 ){ from.AddToBackpack( new StrangleScroll() ); paperName = "strangle"; }
							else if ( paperType == 78 ){ from.AddToBackpack( new LichFormScroll() ); paperName = "lich form"; }
							else if ( paperType == 79 ){ from.AddToBackpack( new ExorcismScroll() ); paperName = "exorcism"; }
							else if ( paperType == 80 ){ from.AddToBackpack( new VengefulSpiritScroll() ); paperName = "vengeful spirit"; }
							else if ( paperType == 81 ){ from.AddToBackpack( new VampiricEmbraceScroll() ); paperName = "vampiric embrace"; }
							else if ( paperType == 82 ){ from.AddToBackpack( new ArmysPaeonScroll() ); paperName = "army's paeon sheet music"; }
							else if ( paperType == 83 ){ from.AddToBackpack( new EnchantingEtudeScroll() ); paperName = "enchanting etude sheet music"; }
							else if ( paperType == 84 ){ from.AddToBackpack( new EnergyCarolScroll() ); paperName = "energy carol sheet music"; }
							else if ( paperType == 85 ){ from.AddToBackpack( new EnergyThrenodyScroll() ); paperName = "energy threnody sheet music"; }
							else if ( paperType == 86 ){ from.AddToBackpack( new FireCarolScroll() ); paperName = "fire carol sheet music"; }
							else if ( paperType == 87 ){ from.AddToBackpack( new FireThrenodyScroll() ); paperName = "fire threnody sheet music"; }
							else if ( paperType == 88 ){ from.AddToBackpack( new FoeRequiemScroll() ); paperName = "foe requiem sheet music"; }
							else if ( paperType == 89 ){ from.AddToBackpack( new IceCarolScroll() ); paperName = "ice carol sheet music"; }
							else if ( paperType == 90 ){ from.AddToBackpack( new IceThrenodyScroll() ); paperName = "ice threnody sheet music"; }
							else if ( paperType == 91 ){ from.AddToBackpack( new KnightsMinneScroll() ); paperName = "knight's minne sheet music"; }
							else if ( paperType == 92 ){ from.AddToBackpack( new MagesBalladScroll() ); paperName = "mage's ballad sheet music"; }
							else if ( paperType == 93 ){ from.AddToBackpack( new MagicFinaleScroll() ); paperName = "magic finale sheet music"; }
							else if ( paperType == 94 ){ from.AddToBackpack( new PoisonCarolScroll() ); paperName = "poison carol sheet music"; }
							else if ( paperType == 95 ){ from.AddToBackpack( new PoisonThrenodyScroll() ); paperName = "poison threnody sheet music"; }
							else if ( paperType == 96 ){ from.AddToBackpack( new SheepfoeMamboScroll() ); paperName = "shepherd's dance sheet music"; }
							else { from.AddToBackpack( new SinewyEtudeScroll() ); paperName = "sinewy etude sheet music"; }

							from.SendMessage( "This seems to be a scroll of " + paperName + "." );
						}
						else
						{
							int nJunk = Utility.RandomMinMax( 1, 6 );

							switch( nJunk )
							{
								case 1: paperName = "useless scribbles"; break;
								case 2: paperName = "a useless recipe"; break;
								case 3: paperName = "a useless list of monsters"; break;
								case 4: paperName = "useless writings"; break;
								case 5: paperName = "a useless drawing"; break;
								case 6: paperName = "a useless map"; break;
							}
							from.SendMessage( "This seems to be " + paperName + "." );
						}

						rolls.Delete();
					}
					else if ( ( iBook.IsChildOf( from.Backpack ) ) && ( iBook is UnknownLiquid ) ) //////////////////////////////////////////////////////////////////////////
					{
						m_Book.Charges = m_Book.Charges - 1;
						Item brew = targeted as Item;
						Container pack = from.Backpack;

						int potionType = Utility.RandomMinMax( 0, 40 );
						string potionName = "";

						if ( potionType == 0 ){ from.AddToBackpack( new NightSightPotion() ); potionName = "night sight potion"; }
						else if ( potionType == 1 ){ from.AddToBackpack( new LesserCurePotion() ); potionName = "lesser cure potion"; }
						else if ( potionType == 2 ){ from.AddToBackpack( new CurePotion() ); potionName = "cure potion"; }
						else if ( potionType == 3 ){ from.AddToBackpack( new GreaterCurePotion() ); potionName = "greater cure potion"; }
						else if ( potionType == 4 ){ from.AddToBackpack( new AgilityPotion() ); potionName = "agility potion"; }
						else if ( potionType == 5 ){ from.AddToBackpack( new GreaterAgilityPotion() ); potionName = "greater agility potion"; }
						else if ( potionType == 6 ){ from.AddToBackpack( new StrengthPotion() ); potionName = "strength"; }
						else if ( potionType == 7 ){ from.AddToBackpack( new GreaterStrengthPotion() ); potionName = "greater strength potion"; }
						else if ( potionType == 8 ){ from.AddToBackpack( new LesserPoisonPotion() ); potionName = "lesser poison"; }
						else if ( potionType == 9 ){ from.AddToBackpack( new PoisonPotion() ); potionName = "poison"; }
						else if ( potionType == 10 ){ from.AddToBackpack( new GreaterPoisonPotion() ); potionName = "greater poison"; }
						else if ( potionType == 11 ){ from.AddToBackpack( new DeadlyPoisonPotion() ); potionName = "deadly poison"; }
						else if ( potionType == 12 ){ from.AddToBackpack( new RefreshPotion() ); potionName = "refresh potion"; }
						else if ( potionType == 13 ){ from.AddToBackpack( new TotalRefreshPotion() ); potionName = "total refresh potion"; }
						else if ( potionType == 14 ){ from.AddToBackpack( new LesserHealPotion() ); potionName = "lesser heal potion"; }
						else if ( potionType == 15 ){ from.AddToBackpack( new HealPotion() ); potionName = "heal potion"; }
						else if ( potionType == 16 ){ from.AddToBackpack( new GreaterHealPotion() ); potionName = "greater heal potion"; }
						else if ( potionType == 17 ){ from.AddToBackpack( new LesserExplosionPotion() ); potionName = "lesser explosion potion"; }
						else if ( potionType == 18 ){ from.AddToBackpack( new ExplosionPotion() ); potionName = "explosion potion"; }
						else if ( potionType == 19 ){ from.AddToBackpack( new GreaterExplosionPotion() ); potionName = "greater explosion potion"; }
						else if ( potionType == 20 ){ from.AddToBackpack( new LesserInvisibilityPotion() ); potionName = "lesser invisibility potion"; }
						else if ( potionType == 21 ){ from.AddToBackpack( new InvisibilityPotion() ); potionName = "invisibility potion"; }
						else if ( potionType == 22 ){ from.AddToBackpack( new GreaterInvisibilityPotion() ); potionName = "greater invisibility potion"; }
						else if ( potionType == 23 ){ from.AddToBackpack( new LesserRejuvenatePotion() ); potionName = "lesser rejuvenation potion"; }
						else if ( potionType == 24 ){ from.AddToBackpack( new RejuvenatePotion() ); potionName = "rejuvenation potion"; }
						else if ( potionType == 25 ){ from.AddToBackpack( new GreaterRejuvenatePotion() ); potionName = "greater rejuvenation potion"; }
						else if ( potionType == 26 ){ from.AddToBackpack( new LesserManaPotion() ); potionName = "lesser mana potion"; }
						else if ( potionType == 27 ){ from.AddToBackpack( new ManaPotion() ); potionName = "mana potion"; }
						else if ( potionType == 28 ){ from.AddToBackpack( new GreaterManaPotion() ); potionName = "greater mana potion"; }
						else if ( potionType == 29 ){ from.AddToBackpack( new InvulnerabilityPotion() ); potionName = "invulnerability potion"; }
						else if ( potionType == 30 ){ from.AddToBackpack( new AutoResPotion() ); potionName = "resurrection potion"; }
						else if ( potionType == 31 ){ from.AddToBackpack( new OilMetal() ); potionName = "metal enhancement oil"; }
						else if ( potionType == 32 ){ from.AddToBackpack( new OilLeather() ); potionName = "leather enhancement oil"; }
						else if ( potionType == 33 ){ from.AddToBackpack( new BottleOfAcid() ); potionName = "acid"; }
						else if ( potionType == 34 ){ from.AddToBackpack( new MagicalDyes() ); potionName = "magical dye"; }
						else if ( potionType == 35 ){ from.AddToBackpack( new BeverageBottle(BeverageType.Ale) ); potionName = "ale"; }
						else if ( potionType == 36 ){ from.AddToBackpack( new BeverageBottle(BeverageType.Wine) ); potionName = "wine"; }
						else if ( potionType == 37 ){ from.AddToBackpack( new BeverageBottle(BeverageType.Liquor) ); potionName = "liquor"; }
						else if ( potionType == 38 ){ from.AddToBackpack( new BeverageBottle(BeverageType.Ale) ); potionName = "ale"; }
						else if ( potionType == 39 ){ from.AddToBackpack( new BeverageBottle(BeverageType.Wine) ); potionName = "wine"; }
						else { from.AddToBackpack( new BeverageBottle(BeverageType.Liquor) ); potionName = "liquor"; }

						from.SendMessage( "This seems to be a bottle of " + potionName + "." );
						brew.Delete();
					}
					else if ( ( iBook.IsChildOf( from.Backpack ) ) && ( iBook is UnknownKeg ) ) //////////////////////////////////////////////////////////////////////////
					{
						m_Book.Charges = m_Book.Charges - 1;
						Item brew = targeted as Item;
						Container pack = from.Backpack;
						Item Kitem = new PotionKeg();
						PotionKeg barrel = (PotionKeg)Kitem;
						UnknownKeg tub = (UnknownKeg)brew;
						barrel.Held = tub.KegFilled;
						int nBarrel = 0;

						int potionType = Utility.RandomMinMax( 1, 36 );

						if ( potionType == 1 ){ barrel.Type = PotionEffect.Nightsight; }
						else if ( potionType == 2 ){ barrel.Type = PotionEffect.CureLesser; }
						else if ( potionType == 3 ){ barrel.Type = PotionEffect.Cure; }
						else if ( potionType == 4 ){ barrel.Type = PotionEffect.CureGreater; }
						else if ( potionType == 5 ){ barrel.Type = PotionEffect.Agility; }
						else if ( potionType == 6 ){ barrel.Type = PotionEffect.AgilityGreater; }
						else if ( potionType == 7 ){ barrel.Type = PotionEffect.Strength; }
						else if ( potionType == 8 ){ barrel.Type = PotionEffect.StrengthGreater; }
						else if ( potionType == 9 ){ barrel.Type = PotionEffect.PoisonLesser; }
						else if ( potionType == 10 ){ barrel.Type = PotionEffect.Poison; }
						else if ( potionType == 11 ){ barrel.Type = PotionEffect.PoisonGreater; }
						else if ( potionType == 12 ){ barrel.Type = PotionEffect.PoisonDeadly; }
						else if ( potionType == 13 ){ barrel.Type = PotionEffect.Refresh; }
						else if ( potionType == 14 ){ barrel.Type = PotionEffect.RefreshTotal; }
						else if ( potionType == 15 ){ barrel.Type = PotionEffect.HealLesser; }
						else if ( potionType == 16 ){ barrel.Type = PotionEffect.Heal; }
						else if ( potionType == 17 ){ barrel.Type = PotionEffect.HealGreater; }
						else if ( potionType == 18 ){ barrel.Type = PotionEffect.ExplosionLesser; }
						else if ( potionType == 19 ){ barrel.Type = PotionEffect.Explosion; }
						else if ( potionType == 20 ){ barrel.Type = PotionEffect.ExplosionGreater; }
						else if ( potionType == 21 ){ barrel.Type = PotionEffect.InvisibilityLesser; }
						else if ( potionType == 22 ){ barrel.Type = PotionEffect.Invisibility; }
						else if ( potionType == 23 ){ barrel.Type = PotionEffect.InvisibilityGreater; }
						else if ( potionType == 24 ){ barrel.Type = PotionEffect.RejuvenateLesser; }
						else if ( potionType == 25 ){ barrel.Type = PotionEffect.Rejuvenate; }
						else if ( potionType == 26 ){ barrel.Type = PotionEffect.RejuvenateGreater; }
						else if ( potionType == 27 ){ barrel.Type = PotionEffect.ManaLesser; }
						else if ( potionType == 28 ){ barrel.Type = PotionEffect.Mana; }
						else if ( potionType == 29 ){ barrel.Type = PotionEffect.ManaGreater; }
						else if ( potionType == 30 ){ barrel.Type = PotionEffect.PoisonLethal; }
						else if ( potionType == 31 ){ barrel.Type = PotionEffect.Invulnerability; }

						if ( potionType > 31 )
						{
							nBarrel = 1;
							from.AddToBackpack( new Keg() );
							Effects.PlaySound(from.Location, from.Map, 0x026);
							from.SendMessage( "This seems to be barrel of dirty water, which you dump out." );
						}

						if ( nBarrel == 0 )
						{
							Server.Items.PotionKeg.SetColorKeg( barrel, barrel );
							from.AddToBackpack( barrel );
							from.SendMessage( "This seems to be a " + barrel.Name + "." );
						}

						brew.Delete();
					}
					else if ( ( iBook.IsChildOf( from.Backpack ) ) && ( iBook is UnknownWand ) ) //////////////////////////////////////////////////////////////////////////
					{
						m_Book.Charges = m_Book.Charges - 1;

						if ( Utility.RandomMinMax( 1, 100 ) > 10 )
						{
							Server.Items.UnknownWand.WandType( (Item)targeted, from, from );
						}
						else
						{
							int nJunk = Utility.RandomMinMax( 1, 5 );
							string stickName = "";
							switch( nJunk )
							{
								case 1: stickName = "a useless stick"; break;
								case 2: stickName = "a wand that was never enchanted"; break;
								case 3: stickName = "a fake wand"; break;
								case 4: stickName = "nothing magical at all"; break;
								case 5: stickName = "a simple metal rod"; break;
							}

							from.SendMessage( "This seems to be " + stickName + ", so you throw it away." );
						}
						((Item)targeted).Delete();
					}
					else if ( ( iBook.IsChildOf( from.Backpack ) ) && ( iBook is UnidentifiedArtifact ) ) //////////////////////////////////////////////////////////////////////////
					{
						m_Book.Charges = m_Book.Charges - 1;
						UnidentifiedArtifact relic = (UnidentifiedArtifact)iBook;
						Container pack = (Container)relic;
							List<Item> items = new List<Item>();
							foreach (Item item in pack.Items)
							{
								items.Add(item);
							}
							foreach (Item item in items)
							{
								from.AddToBackpack ( item );
							}

						from.SendMessage("You successfully identify the artifact.");
						relic.Delete();
					}
					else if ( ( iBook.IsChildOf( from.Backpack ) ) && ( iBook is UnidentifiedItem ) ) //////////////////////////////////////////////////////////////////////////
					{
						m_Book.Charges = m_Book.Charges - 1;
						UnidentifiedItem relic = (UnidentifiedItem)iBook;
						Container pack = (Container)relic;
							List<Item> items = new List<Item>();
							foreach (Item item in pack.Items)
							{
								items.Add(item);
							}
							foreach (Item item in items)
							{
								from.AddToBackpack ( item );
							}

						from.SendMessage("You successfully identify the item.");
						relic.Delete();
					}
					else
					{
						from.SendMessage( "You cannot find any information on that." );
					}
				}
				else
				{
					from.SendMessage( "You cannot find any information on that." );
				}
			}
		}

        public ArtifactManual( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
			writer.Write( (int) m_ArtyBookEffect );
			writer.Write( (int) m_Charges );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			switch ( version )
			{
				case 0:
				{
					m_ArtyBookEffect = (ArtyBookEffect)reader.ReadInt();
					m_Charges = (int)reader.ReadInt();

					break;
				}
			}
	    }

		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );
			list.Add( 1060741, m_Charges.ToString() );
		}
    }
}