using System;
using System.Collections;
using System.Collections.Generic;

using Server.Spells;
using Server.ACC.CSS.Systems.Avatar;
using Server.ACC.CSS.Systems.Cleric;
using Server.ACC.CSS.Systems.Druid;
using Server.ACC.CSS.Systems.Bard;
using Server.ACC.CSS.Systems.Ranger;
using Server.ACC.CSS.Systems.Rogue;
using Server;
using Server.Misc;
using Server.Gumps;
using Server.Items;
using Server.Mobiles;
using Server.Accounting;

using Server.Items;
using Felladrin.Items;

namespace Server.Voting
{
	/// <summary>
	/// Provides a derivable class to create items that hold VoteSites and to handle Voting.
	/// </summary>
	public class VoteItem : Item
	{
		private static VoteItem _Instance;
		/// <summary>
		/// Gets an instance of VoteItem that can be used to allow voting without the need of an ingame object.
		/// </summary>
		public static VoteItem Instance
		{
			get
			{
				if (_Instance == null || _Instance.Deleted)
				{
					_Instance = new VoteItem(0);
					_Instance.Movable = false;
					_Instance.Visible = false;
					_Instance.Internalize();
				}

				return _Instance;
			}
		}

		private bool _Messages = true;
		/// <summary>
		/// Gets or Sets a value indecating whether messages should be sent to a vote request sender on various events.
		/// </summary>
		[CommandProperty(AccessLevel.GameMaster)]
		public bool Messages { get { return _Messages; } set { _Messages = value; } }

		private VoteSite _VoteSite;
		/// <summary>
		/// Gets or Sets the vote website profile. 
		/// Exposes options to configure the vote site, such as Name and URL.
		/// </summary>
		[CommandProperty(AccessLevel.GameMaster)]
		public VoteSite VoteSite
		{
			get
			{
				if (_VoteSite == null)
				{ _VoteSite = new VoteSite(this); }

				return _VoteSite;
			}
			set
			{
				_VoteSite = value;
				InvalidateProperties();
			}
		}

		public VoteItem(int itemID)
			: base(itemID)
		{ }

		public VoteItem(Serial serial)
			: base(serial)
		{ }

		public virtual void CastVote(Mobile from)
		{ VoteHelper.CastVote(from, VoteSite); }

		public virtual void OnVote(Mobile from, VoteStatus status)
		{
		
				
			if (from == null || from.Deleted)
			{ return; }

			switch (status)
			{
				case VoteStatus.Success:
					{
						if (VoteSite.Valid)
						{
				
				
						/////////////						
							if (_Messages)
							{ from.SendMessage("Thank you, {0} , for voting on {1}! A reward has been placed in your backpack.",from.Name, VoteSite.Name); }

							from.LaunchBrowser(VoteSite.URL);
							VoteHelper.SetLastVoteTime(from, VoteSite);
							Reward(from);	
						}
						else
						{
							if (_Messages)
							{ from.SendMessage(0x22, "Sorry, voting is currently unavailable."); }
						}
					} break;
				case VoteStatus.Invalid:
					{
						if (_Messages)
						{ from.SendMessage(0x22, "Sorry, voting is currently unavailable."); }
					} break;
				case VoteStatus.TooEarly:
					{
						if (_Messages)
						{
							TimeSpan timeLeft = VoteHelper.GetTimeLeft(from, VoteSite);
							from.SendMessage(0x22, "Sorry, you can not vote at {0} for {1}.", VoteSite.Name, VoteHelper.GetFormattedTime(timeLeft));
						}
					} break;
				case VoteStatus.Custom: { } break;
			}
					
		}
		
		public virtual bool OnBeforeVote(Mobile from)
		{ return true; }

		public virtual void OnAfterVote(Mobile from, VoteStatus status)
		{ }

		public override void OnDoubleClick(Mobile from)
		{
			if (from == null || from.Deleted)
			{ return; }

			CastVote(from);

			base.OnDoubleClick(from);
		}
		
		public static void Reward(Mobile from)
		{
			Container pack = from.Backpack;
			////////////////
							//////////DOC VOTE REWARDS//////////////
							
				//// Give 1 reward from the following each for loop			
                switch (Utility.Random(2))
                {
					
			 
				 case 0:pack.AddItem( new Kudos (1));break;
				 case 1:pack.AddItem( new Kudos (3));break;
				 
				 
				}
				/// Now 5 % chance of an artifact for each for loop.
				 if (Utility.Random(100) < 2) // 5% chance to drop
                {
				switch (Utility.Random(221))
				{
				
                case 0: pack.AddItem( new GlassSword() ); break;
                case 1: pack.AddItem( new JesterHatofChuckles() ); break;
                case 2: pack.AddItem( new  SamuraiHelm() ); break;
                case 3: pack.AddItem( new BlazeOfDeath() ); break;
                case 4: pack.AddItem( new  BurglarsBandana() ); break;
                case 5: pack.AddItem( new EnchantedTitanLegBone() ); break;
                case 6: pack.AddItem( new EarringsOfTheVile() ); break;
                case 7: pack.AddItem( new ShaminoCrossbow() ); break;
                case 8: pack.AddItem( new CavortingClub() ); break;
                case 9: pack.AddItem( new GwennosHarp() ); break;
                case 10: pack.AddItem( new QuiverOfInfinity() ); break;
                case 11: pack.AddItem( new EarringsOfProtection() ); break;
                case 12: pack.AddItem( new LuckyNecklace() ); break;
                case 13: pack.AddItem( new HolySword() ); break;
                case 14: pack.AddItem( new DupresShield() ); break;
                case 15: pack.AddItem( new EarringBoxSet() ); break;
                case 16: pack.AddItem( new IolosLute() ); break;
                case 17: pack.AddItem( new NightsKiss() ); break;
                case 18: pack.AddItem( new  OrcishVisage() ); break;
                case 19: pack.AddItem( new ShieldOfInvulnerability() ); break;
                case 20: pack.AddItem( new VioletCourage() ); break;
                case 21: pack.AddItem( new WrathOfTheDryad() ); break;
                case 22: pack.AddItem( new GlovesOfThePugilist() ); break;
                case 23: pack.AddItem( new CandelabraOfSouls() ); break;
                case 24: pack.AddItem( new  ArcaneArms() ); break;
                case 25: pack.AddItem( new LunaLance() ); break;
                case 26: pack.AddItem( new  NoxRangersHeavyCrossbow() ); break;
                case 27: pack.AddItem( new PolarBearMask() ); break;
                case 28: pack.AddItem( new StaffOfPower() ); break;
                case 29: pack.AddItem( new HeartOfTheLion() ); break;
                case 30: pack.AddItem( new PixieSwatter() ); break;
                case 31: pack.AddItem( new DreadPirateHat() ); break;
                case 32: pack.AddItem( new ColdBlood() ); break;
                case 33: pack.AddItem( new GlovesOfAegis() ); break;
                case 34: pack.AddItem( new SilvanisFeywoodBow() ); break;
                case 35: pack.AddItem( new TheNightReaper() ); break;
                case 36: pack.AddItem( new BlightGrippedLongbow() ); break;
                case 37: pack.AddItem( new ColdForgedBlade() ); break;
                case 38: pack.AddItem( new LuminousRuneBlade() ); break;
                case 39: pack.AddItem( new OverseerSunderedBlade() ); break;
                case 40: pack.AddItem( new PhantomStaff() ); break;
                case 41: pack.AddItem( new RuneCarvingKnife() ); break;
                case 42: pack.AddItem( new JackalsTunic() ); break;
				case 43: pack.AddItem( new ArcaneCap() ); break;
                case 44: pack.AddItem( new ArcaneGloves() ); break;
                case 45: pack.AddItem( new ArcaneGorget() ); break;
                case 46: pack.AddItem( new ArcaneLeggings() ); break;//
				case 47: pack.AddItem( new ArcaneTunic() ); break;
                case 48: pack.AddItem( new ArmorOfInsight() ); break;
                case 49: pack.AddItem( new ArmorOfNobility() ); break;
                case 50: pack.AddItem( new ArmsOfAegis() ); break;
				case 51: pack.AddItem( new ArmsOfFortune() ); break;
                case 52: pack.AddItem( new GlovesOfFortune() ); break;
                case 53: pack.AddItem( new GlovesOfInsight() ); break;
                case 54: pack.AddItem( new GlovesOfTheFallenKing() ); break;
				case 55: pack.AddItem( new GlovesOfTheHarrower() ); break;
                case 56: pack.AddItem( new GorgetOfAegis() ); break;
                case 57: pack.AddItem( new GorgetOfFortune() ); break;
                case 58: pack.AddItem( new GorgetOfInsight() ); break;
				case 59: pack.AddItem( new HelmOfAegis() ); break;
                case 60: pack.AddItem( new HolyKnightsArmPlates() ); break;
                case 61: pack.AddItem( new LeggingsOfAegis() ); break;
                case 62: pack.AddItem( new LeggingsOfFire() ); break;
				case 63: pack.AddItem( new LegsOfFortune() ); break;
                case 64: pack.AddItem( new LegsOfInsight() ); break;
                case 65: pack.AddItem( new LegsOfNobility() ); break;
                case 66: pack.AddItem( new LegsOfTheFallenKing() ); break;
				case 67: pack.AddItem( new LegsOfTheHarrower() ); break;
                case 68: pack.AddItem( new MidnightGloves() ); break;
                case 69: pack.AddItem( new MidnightHelm() ); break;
                case 70: pack.AddItem( new ArmsOfInsight() ); break;
				case 71: pack.AddItem( new ArmsOfNobility() ); break;
                case 72: pack.AddItem( new ArmsOfTheFallenKing() ); break;
                case 73: pack.AddItem( new ArmsOfTheHarrower() ); break;
                case 74: pack.AddItem( new BraceletOfTheElements() ); break;
				case 75: pack.AddItem( new BraceletOfTheVile() ); break;
				case 76: pack.AddItem( new CapOfFortune() ); break;
                case 77: pack.AddItem( new CapOfTheFallenKing() ); break;
                case 78: pack.AddItem( new CoifOfBane() ); break;
                case 79: pack.AddItem( new CoifOfFire() ); break;
				case 80: pack.AddItem( new DivineArms() ); break;
				case 81: pack.AddItem( new DivineGloves() ); break;
                case 82: pack.AddItem( new DivineGorget() ); break;
                case 83: pack.AddItem( new DivineLeggings() ); break;
                case 84: pack.AddItem( new DivineTunic() ); break;
				case 85: pack.AddItem( new HolyKnightsGloves() ); break;
				case 86: pack.AddItem( new HolyKnightsGorget() ); break;
                case 87: pack.AddItem( new HolyKnightsLegging() ); break;
                case 88: pack.AddItem( new HolyKnightsPlateHelm() ); break;
                case 89: pack.AddItem( new HuntersArms() ); break;
				case 90: pack.AddItem( new HuntersGloves() ); break;
				case 91: pack.AddItem( new HuntersGorget() ); break;
                case 92: pack.AddItem( new HuntersLeggings() ); break;
                case 93: pack.AddItem( new HuntersTunic() ); break;
                case 94: pack.AddItem( new InquisitorsArms() ); break;
				case 95: pack.AddItem( new InquisitorsGorget() ); break;
                case 96: pack.AddItem( new InquisitorsGorget() ); break;
                case 97: pack.AddItem( new InquisitorsHelm() ); break;
                case 98: pack.AddItem( new InquisitorsLeggings() ); break;
				case 99: pack.AddItem( new InquisitorsTunic() ); break;
				case 100: pack.AddItem( new JackalsArms() ); break;
                case 101: pack.AddItem( new MidnightLegs() ); break;
                case 102: pack.AddItem( new MidnightTunic() ); break;
                case 103: pack.AddItem( new RingOfHealth() ); break;
				case 104: pack.AddItem( new RingOfTheMagician() ); break;
                case 105: pack.AddItem( new ShadowDancerArms() ); break;
                case 106: pack.AddItem( new ShadowDancerCap() ); break;
                case 107: pack.AddItem( new ShadowDancerGloves() ); break;
				case 108: pack.AddItem( new ShadowDancerGorget() ); break;
				case 109: pack.AddItem( new ShadowDancerTunic() ); break;
                case 110: pack.AddItem( new TotemArms() ); break;
                case 111: pack.AddItem( new TotemGloves() ); break;
                case 112: pack.AddItem( new TotemGorget() ); break;
				case 113: pack.AddItem( new TotemLeggings() ); break;
                case 114: pack.AddItem( new TotemTunic() ); break;
                case 115: pack.AddItem( new TunicOfAegis() ); break;
                case 116: pack.AddItem( new EarringsOfHealth() ); break;
				case 117: pack.AddItem( new EarringsOfTheElements() ); break;
				case 118: pack.AddItem( new EarringsOfTheMagician() ); break;
                case 119: pack.AddItem( new YashimotosHatsuburi() ); break;
                case 120: pack.AddItem( new WarriorsClasp() ); break;
				case 121: pack.AddItem( new VampiricDaisho() ); break;
				case 122: pack.AddItem( new TownGuardsHalberd() ); break;
				case 123: pack.AddItem( new SwiftStrike() ); break;
                case 124: pack.AddItem( new SprintersSandals() ); break;
              //  case 125: pack.AddItem( new ShimmeringTalisman() ); break;
                case 126: pack.AddItem( new ShadowBlade() ); break;
				case 127: pack.AddItem( new JackalsGloves() ); break;
				case 128: pack.AddItem( new JackalsHelm() ); break;
				case 129: pack.AddItem( new JackalsHelm() ); break;
                case 130: pack.AddItem( new JackalsLeggings() ); break;
                case 131: pack.AddItem( new MauloftheBeast() ); break;
                case 132: pack.AddItem( new MarbleShield() ); break;
				case 133: pack.AddItem( new MagiciansMempo() ); break;
				case 134: pack.AddItem( new MagiciansIllusion() ); break;
				case 135: pack.AddItem( new MagesBand() ); break;
				case 136: pack.AddItem( new MadmansHatchet() ); break;
				case 137: pack.AddItem( new LuckyEarrings() ); break;
				case 138: pack.AddItem( new LeggingsOfEnlightenment() ); break;
				case 139: pack.AddItem( new TunicOfBane() ); break;
				case 140: pack.AddItem( new TunicOfTheFallenKing() ); break;
				case 141: pack.AddItem( new TunicOfTheHarrower() ); break;
				case 142: pack.AddItem( new Fortifiedarms() ); break;
				case 143: pack.AddItem( new FesteringWound() ); break;
				case 144: pack.AddItem( new FalseGodsScepter() ); break;
				case 145: pack.AddItem( new EternalFlame() ); break;
				case 146: pack.AddItem( new DupresCollar() ); break;
				case 147: pack.AddItem( new DeathsMask() ); break;
				case 148: pack.AddItem( new DarkNeck() ); break;
				case 149: pack.AddItem( new DarkLordsPitchfork() ); break;
				case 150: pack.AddItem( new CircletOfTheSorceress() ); break;
				case 151: pack.AddItem( new RoyalGuardsGorget() ); break;
				case 152: pack.AddItem( new RoyalGuardsChestplate() ); break;
				case 153: pack.AddItem( new RoyalArchersBow() ); break;
				case 154: pack.AddItem( new RobeOfTreason() ); break;
				case 155: pack.AddItem( new Retort() ); break;
				case 156: pack.AddItem( new RamusNecromanticScalpel() ); break;
				case 157: pack.AddItem( new PowerSurge() ); break;
				case 158: pack.AddItem( new Pestilence() ); break;
				case 159: pack.AddItem( new LeggingsOfDeceit() ); break;
				case 160: pack.AddItem( new KamiNarisIndestructableDoubleAxe() ); break;
				case 161: pack.AddItem( new JinBaoriOfGoodFortune() ); break;
				case 162: pack.AddItem( new JadeScimitar() ); break;
				case 163: pack.AddItem( new Indecency() ); break;
				case 164: pack.AddItem( new HellForgedArms() ); break;
				case 165: pack.AddItem( new GlovesOfRegeneration() ); break;
				case 166: pack.AddItem( new CircletOfTheSorceress() ); break;
				case 167: pack.AddItem( new GlovesOfCorruption() ); break;
				case 168: pack.AddItem( new DarkGuardiansChest() ); break;
				case 169: pack.AddItem( new BalancingDeed() ); break;
				case 170: pack.AddItem( new AuraOfShadows() ); break;
				case 171: pack.AddItem( new ArmsOfToxicity() ); break;
				case 172: pack.AddItem( new ArcticBeacon() ); break;
				case 173: pack.AddItem( new ArcanicRobe() ); break;
				case 174: pack.AddItem( new Annihilation() ); break;		
				case 175: pack.AddItem( new NoxNightlight() ); break;
				case 176: pack.AddItem( new NoxBow() ); break;
				case 177: pack.AddItem( new NordicVikingSword() ); break;
				case 178: pack.AddItem( new MinersPickaxe() ); break;
				case 179: pack.AddItem( new VoiceOfTheFallenKing() ); break;
				case 180: pack.AddItem( new ShadowDancerLeggings() ); break;
				case 181: pack.AddItem( new OrnateCrownOfTheHarrower() ); break;
				case 182: pack.AddItem( new MidnightBracers() ); break;
				case 183: pack.AddItem( new LeggingsOfBane() ); break;
				case 184: pack.AddItem( new JackalsCollar() ); break;
				case 185: pack.AddItem( new GeishasObi() ); break;
				case 186: pack.AddItem( new Fury() ); break;
				case 187: pack.AddItem( new FurCapeOfTheSorceress() ); break;
				case 188: pack.AddItem( new FortunateBlades() ); break;
				case 189: pack.AddItem( new Quell() ); break;
				case 190: pack.AddItem( new OrcChieftainHelm() ); break;
				case 191: pack.AddItem( new GladiatorsCollar() ); break;
				case 192: pack.AddItem( new FangOfRactus() ); break;
				case 193: pack.AddItem( new CrownOfTalKeesh() ); break;
				case 194: pack.AddItem( new Calm() ); break;
				case 195: pack.AddItem( new AcidProofRobe() ); break;
				case 196: pack.AddItem( new AngeroftheGods() ); break;
				case 197: pack.AddItem( new AngelicEmbrace() ); break;
				case 198: pack.AddItem( new AbysmalGloves() ); break;
				case 199: pack.AddItem( new RobeOfTheEquinox() ); break;
				case 200: pack.AddItem( new ArcaneShield() ); break;
				case 201: pack.AddItem( new ZyronicClaw() ); break;
				case 202: pack.AddItem( new TitansHammer() ); break;
				case 203: pack.AddItem( new TheTaskmaster() ); break;
				case 204: pack.AddItem( new TheDryadBow() ); break;
				case 205: pack.AddItem( new TheDragonSlayer() ); break;
				case 206: pack.AddItem( new TheBeserkersMaul() ); break;		
				case 207: pack.AddItem( new InquisitorsResolution() ); break;
				case 208: pack.AddItem( new HolyKnightsBreastplate() ); break;
				case 209: pack.AddItem( new HelmOfInsight() ); break;
				case 210: pack.AddItem( new GauntletsOfNobility() ); break;
				case 211: pack.AddItem( new ArmorOfFortune() ); break;
				case 212: pack.AddItem( new TheRobeOfBritanniaAri() ); break;
				case 213: pack.AddItem( new SamaritanRobe() ); break;
				case 214: pack.AddItem( new RoyalGuardSurvivalKnife() ); break;
				case 215: pack.AddItem( new OblivionsNeedle() ); break;
				case 216: pack.AddItem( new LieutenantOfTheBritannianRoyalGuard() ); break;
				case 217: pack.AddItem( new SpiritOfTheTotem() ); break;
				case 218: pack.AddItem( new HuntersHeaddress() ); break;
				case 219: pack.AddItem( new HatOfTheMagi() ); break;
				case 220: pack.AddItem( new DivineCountenance() ); break;
				case 221: pack.AddItem( new CrimsonCincture() ); break;
				case 222: pack.AddItem( new RingOfTheVile() ); break;
				case 223: pack.AddItem( new RingOfTheElements() ); break;
				case 224: pack.AddItem( new OrnamentOfTheMagician() ); break;
				case 225: pack.AddItem( new BraceletOfHealth() ); break;
				case 226: pack.AddItem( new StaffOfTheMagi() ); break;
				case 227: pack.AddItem( new SerpentsFang() ); break;
				case 228: pack.AddItem( new LegacyOfTheDreadLord() ); break;
				case 229: pack.AddItem( new Frostbringer() ); break;
				case 230: pack.AddItem( new BreathOfTheDead() ); break;
				case 231: pack.AddItem( new QuiverOfElements() ); break;
				case 232: pack.AddItem( new QuiverOfRage() ); break;
				case 233: pack.AddItem( new RighteousAnger() ); break;
				case 234: pack.AddItem( new RobeOfTheEclipse() ); break;
				case 235: pack.AddItem( new QuiverOfLightning() ); break;
				case 236: pack.AddItem( new GuantletsOfAnger() ); break;
				case 237: pack.AddItem( new EmbroideredOakLeafCloak() ); break;
				case 238: pack.AddItem( new DjinnisRing() ); break;
				case 239: pack.AddItem( new Subdue() ); break;
				case 240: pack.AddItem( new ShroudOfDeciet() ); break;
				case 241: pack.AddItem( new EverlastingLoaf() ); break;
				case 242: pack.AddItem( new PolarBearBoots() ); break;
				case 243: pack.AddItem( new Stormbringer() ); break;
				case 244: pack.AddItem( new StaffofSnakes() ); break;
				case 245: pack.AddItem( new RobinHoodsFeatheredHat() ); break;
				case 246: pack.AddItem( new AxeoftheMinotaur() ); break;
				case 247: pack.AddItem( new QuiverOfIce() ); break;
				case 248: pack.AddItem( new QuiverOfFire() ); break;
				case 249: pack.AddItem( new QuiverOfBlight() ); break;
				case 250: pack.AddItem( new ElvenQuiver() ); break;
				case 251: pack.AddItem( new Aegis() ); break;
				case 252: pack.AddItem( new EverlastingBottle() ); break;
				case 253: pack.AddItem( new Excalibur() ); break;
				case 254: pack.AddItem( new AchillesShield() ); break;
				case 255: pack.AddItem( new AilricsLongbow() ); break;
				case 256: pack.AddItem( new RobinHoodsBow() ); break;
				case 257: pack.AddItem( new BowofthePhoenix() ); break;
				case 258: pack.AddItem( new SoulSeeker() ); break;
				case 259: pack.AddItem( new TalonBite() ); break;
				case 260: pack.AddItem( new WildfireBow() ); break;
				case 261: pack.AddItem( new TotemOfVoid() ); break;
				case 262: pack.AddItem( new Windsong() ); break;
				case 263: pack.AddItem( new KodiakBearMask() ); break;
				case 264: pack.AddItem( new AchillesSpear() ); break;
				case 265: pack.AddItem( new PolarBearCape() ); break;
				case 266: pack.AddItem( new BeltofHercules() ); break;
				case 267: pack.AddItem( new HammerofThor() ); break;
				case 268: pack.AddItem( new GandalfsRobe() ); break;
				case 269: pack.AddItem( new ConansHelm() ); break;
				case 270: pack.AddItem( new SkullChest() ); break;
				case 271: pack.AddItem( new VampiresRobe() ); break;
				case 272: pack.AddItem( new EssenceOfBattle() ); break;
				case 273: pack.AddItem( new QuiverOfRage() ); break;
				case 274: pack.AddItem( new GrayMouserCloak() ); break;
				case 275: pack.AddItem( new CandleCold() ); break;
				case 276: pack.AddItem( new CandleEnergy() ); break;
				case 277: pack.AddItem( new GrimReapersRobe() ); break;
				case 278: pack.AddItem( new GrimReapersScythe() ); break;
				case 279: pack.AddItem( new RobeOfTeleportation() ); break;
				case 280: pack.AddItem( new GlovesOfDexterity() ); break;
				case 281: pack.AddItem( new ColoringBook() ); break;
				case 282: pack.AddItem( new ConansSword() ); break;
				case 283: pack.AddItem( new ShardThrasher() ); break;
				case 284: pack.AddItem( new ConansLoinCloth() ); break;
				case 285: pack.AddItem( new ResilientBracer() ); break;
				case 286: pack.AddItem( new MelisandesCorrodedHatchet() ); break;
				case 287: pack.AddItem( new BootsofHermes() ); break;
				case 288: pack.AddItem( new CandleFire() ); break;
				case 289: pack.AddItem( new CandleWizard() ); break;
				case 290: pack.AddItem( new GrimReapersMask() ); break;
				case 291: pack.AddItem( new TorchOfTrapFinding() ); break;
				case 292: pack.AddItem( new MaulOfTheTitans() ); break;
				case 293: pack.AddItem( new GemOfSeeing() ); break;
				case 294: pack.AddItem( new BagOfHolding() ); break;
				case 295: pack.AddItem( new SinbadsSword() ); break;
				case 296: pack.AddItem( new BeggarsRobe() ); break;
				case 297: pack.AddItem( new PendantOfTheMagi() ); break;
				case 298: pack.AddItem( new GiantBlackjack() ); break;
				case 299: pack.AddItem( new BloodwoodSpirit() ); break;
				case 300: pack.AddItem( new FleshRipper() ); break;
				case 301: pack.AddItem( new CandlePoison() ); break;
				case 302: pack.AddItem( new CandleNecromancer() ); break;
				case 303: pack.AddItem( new GrimReapersLantern() ); break;
				case 304: pack.AddItem( new RodOfResurrection() ); break;
				case 305: pack.AddItem( new HelmOfBrilliance() ); break;
				case 306: pack.AddItem( new DaggerOfVenom() ); break;
				case 307: pack.AddItem( new ArcaneGorget() ); break;
                case 308: pack.AddItem( new ArcaneLeggings() ); break;
				}
				/* Mobile Chatter = from;
                string Message;
				Message = String.Format( "{0} won an artifact for voting! Vote for your chance for an artifact.", from.Name);
                Init CS = Init.Chat_Server;
                CS.LastMessage = CHAN.WORLD;
                Bittiez.BoxerChat.Chat.AddMessage(CS.Messages, Chatter, Message, 1);
                Bittiez.BoxerChat.Chat.SendGump((int)CHAN.WORLD, Chatter); //Send the chatter the gump if it is closed*/
		}
		}
		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			int version = 0;

			writer.Write(version);

			switch (version)
			{
				case 0:
					{
						writer.Write(_Messages);
						VoteSite.Serialize(writer);
					} break;
			}
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();

			switch (version)
			{
				case 0:
					{
						_Messages = reader.ReadBool();
						VoteSite.Deserialize(reader);
					} break;
			}
		}
	}
}
