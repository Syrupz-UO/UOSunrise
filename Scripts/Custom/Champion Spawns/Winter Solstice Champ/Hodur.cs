using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Misc;
using Server.Spells;
using Server.Spells.Third;
using Server.Spells.Sixth;
using Server.Spells.Seventh;
using Server.Items;
using Server.Targeting;

namespace Server.Mobiles
{
	[CorpseName( "the God Of Winter's corpse" )]
	public class Hodur : BaseCreature
	{

		public override WeaponAbility GetWeaponAbility()
		{
			return Utility.RandomBool() ? WeaponAbility.BleedAttack : WeaponAbility.CrushingBlow;
		}

		public override bool IgnoreYoungProtection { get { return Core.ML; } }
		public override bool AlwaysMurderer{ get{ return true; } }
		private int i_PsCount;
		public int PsCount{ get{ return i_PsCount; } set { i_PsCount = value; InvalidateProperties(); } }
		private bool i_ChampionSpawn;
		public bool ChampionSpawn{ get{ return i_ChampionSpawn; } set { i_ChampionSpawn = value; InvalidateProperties(); } }
		
		[Constructable]
		public Hodur() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.1, 0.4 )
		{
			Name = "Set";
			Title = "Hodur God Of Winter";
			Body = 400;
			Hue = 0;
			BaseSoundID = 377;

			AddItem( new ThighBoots( 0x51D ) );
			
			Item item;
			
			item = new BodySash();
			item.Hue = 1152;
			AddItem( item );
			
			item = new Cloak();
			item.Hue = 1152;
			AddItem( item );			

			PlateArms arms = new PlateArms();
			arms.Hue = 1151;
                        arms.Movable = false;
			AddItem(arms);

			PlateChest chest = new PlateChest();
			chest.Hue = 1151;
                        chest.Movable = false;
			AddItem(chest);

			PlateGloves gloves = new PlateGloves();
			gloves.Hue = 1151;
                        gloves.Movable = false;
			AddItem(gloves);

			PlateGorget gorget = new PlateGorget();
			gorget.Hue = 1151;
                        gorget.Movable = false;
			AddItem(gorget);

			PlateHelm helm = new PlateHelm();
			helm.Hue = 1151;
                        helm.Movable = false;
			AddItem(helm);

			PlateLegs legs = new PlateLegs();
			legs.Hue = 1151;
                        legs.Movable = false;
			AddItem(legs);

			SetStr( 1198, 1207 );
			SetDex( 127, 135 );
			SetInt( 495, 546 );

			SetHits( 25000 );

			SetDamage( 27, 31 );

			SetDamageType( ResistanceType.Physical, 80 );
			SetDamageType( ResistanceType.Cold, 20 );
			
			SetResistance( ResistanceType.Physical, 78, 89 );
			SetResistance( ResistanceType.Fire, 30, 46 );
			SetResistance( ResistanceType.Cold, 97, 100 );
			SetResistance( ResistanceType.Poison, 71, 80 );
			SetResistance( ResistanceType.Energy, 70, 80 );

			SetSkill( SkillName.Wrestling, 110.4, 112.3 );
			SetSkill( SkillName.Tactics, 114.0, 118.5 );
			SetSkill( SkillName.MagicResist, 114.1, 132.0 );
			SetSkill( SkillName.Magery, 90.9, 99.8 );
			SetSkill( SkillName.EvalInt, 90.7, 98.7 );
			SetSkill( SkillName.Meditation, 90.4, 98.8 );
			
			Fame = 24000;
			Karma = -24000;

			VirtualArmor = 80;

			PackGold( 9500, 16500 );

			if( Utility.RandomDouble() <= 0.15 ) PackItem( new WeaponBlessDeed() );
		}

			public void GiveCraftPowerScroll() //Generate power scroll routine and add to pack
		{
            List<Mobile> toGive = new List<Mobile>(); //no idea :(

            List<AggressorInfo> list = Aggressors; //I think it add list players that attacked it
			for ( int i = 0; i < list.Count; ++i )
			{
				AggressorInfo info = (AggressorInfo)list[i];

				if ( info.Attacker.Player && info.Attacker.Alive && (DateTime.UtcNow - info.LastCombatTime) < TimeSpan.FromSeconds( 30.0 ) && !toGive.Contains( info.Attacker ) )
					toGive.Add( info.Attacker );
			}

			list = Aggressed; //I think it add list of players it attacked
			for ( int i = 0; i < list.Count; ++i )
			{
				AggressorInfo info = (AggressorInfo)list[i];

				if ( info.Defender.Player && info.Defender.Alive && (DateTime.UtcNow - info.LastCombatTime) < TimeSpan.FromSeconds( 30.0 ) && !toGive.Contains( info.Defender ) )
					toGive.Add( info.Defender );
			}
			if ( toGive.Count == 0 )//if nobody attacked it and it didn't attack anybody then break operation and no ps MUAH
				return;

			// Randomize //absolutly no idea
			for ( int i = 0; i < toGive.Count; ++i )
			{
				int rand = Utility.Random( toGive.Count );
				Mobile hold = toGive[i];
				toGive[i] = toGive[rand];
				toGive[rand] = hold;
			}

			PsCount = ChampionSpawn ? 5 : 2; //set how many ps to give if it spawned using champ spawn or normal spawn
			for ( int i = 0; i < PsCount; ++i ) 
			{
				Mobile m = (Mobile)toGive[i % toGive.Count];
				int level;
				double random = Utility.RandomDouble();
				if ( 0.25 >= random ) // select the level of the ps
					level = 120;
				else if ( 0.55 >= random )
					level = 115;
				else
					level = 110;
			
				
				
				switch ( Utility.Random( 36 )) // select which skill to use in the ps
				{ 
					case 0: m.AddToBackpack( new PowerScroll( SkillName.Blacksmith, level ) ); break; // give blacksmith ps acording to the ps level we selected before
					case 1: m.AddToBackpack( new PowerScroll( SkillName.Tailoring, level ) ); break;  
					case 2: m.AddToBackpack( new PowerScroll( SkillName.Tinkering, level ) ); break; 
					case 3: m.AddToBackpack( new PowerScroll( SkillName.Mining, level ) ); break;  
					case 4: m.AddToBackpack( new PowerScroll( SkillName.Carpentry, level ) ); break;  
					case 5: m.AddToBackpack( new PowerScroll( SkillName.Alchemy, level ) ); break; 
					case 6: m.AddToBackpack( new PowerScroll( SkillName.Fletching, level ) ); break; 
					case 7: m.AddToBackpack( new PowerScroll( SkillName.Inscribe, level ) ); break;  
					case 8: m.AddToBackpack( new PowerScroll( SkillName.Cooking, level ) ); break;  
					case 9: m.AddToBackpack( new PowerScroll( SkillName.Cartography, level ) ); break;  
					case 10: m.AddToBackpack( new PowerScroll( SkillName.Lumberjacking, level ) ); break; 
					case 11: m.AddToBackpack( new PowerScroll( SkillName.Lockpicking, level ) ); break; 
					case 12: m.AddToBackpack( new PowerScroll( SkillName.Anatomy, level ) ); break; 
					case 13: m.AddToBackpack( new PowerScroll( SkillName.AnimalLore, level ) ); break; 
					case 14: m.AddToBackpack( new PowerScroll( SkillName.AnimalTaming, level ) ); break; 
					case 15: m.AddToBackpack( new PowerScroll( SkillName.ArmsLore, level ) ); break; 
					case 16: m.AddToBackpack( new PowerScroll( SkillName.Begging, level ) ); break; 
					case 17: m.AddToBackpack( new PowerScroll( SkillName.DetectHidden, level ) ); break; 
					case 18: m.AddToBackpack( new PowerScroll( SkillName.Discordance, level ) ); break; 
					case 19: m.AddToBackpack( new PowerScroll( SkillName.EvalInt, level ) ); break; 
					case 20: m.AddToBackpack( new PowerScroll( SkillName.Forensics, level ) ); break; 
					case 21: m.AddToBackpack( new PowerScroll( SkillName.Hiding, level ) ); break; 
					case 22: m.AddToBackpack( new PowerScroll( SkillName.Inscribe, level ) ); break; 
					case 23: m.AddToBackpack( new PowerScroll( SkillName.ItemID, level ) ); break; 
					case 24: m.AddToBackpack( new PowerScroll( SkillName.Meditation, level ) ); break; 
					case 25: m.AddToBackpack( new PowerScroll( SkillName.Peacemaking, level ) ); break; 
					case 26: m.AddToBackpack( new PowerScroll( SkillName.Poisoning, level ) ); break; 
					case 27: m.AddToBackpack( new PowerScroll( SkillName.Provocation, level ) ); break;
					case 28: m.AddToBackpack( new PowerScroll( SkillName.RemoveTrap, level ) ); break;
					case 29: m.AddToBackpack( new PowerScroll( SkillName.Snooping, level ) ); break;
					case 30: m.AddToBackpack( new PowerScroll( SkillName.SpiritSpeak, level ) ); break;
					case 31: m.AddToBackpack( new PowerScroll( SkillName.Stealing, level ) ); break;
					case 32: m.AddToBackpack( new PowerScroll( SkillName.Stealth, level ) ); break;
					case 33: m.AddToBackpack( new PowerScroll( SkillName.TasteID, level ) ); break;
					case 34: m.AddToBackpack( new PowerScroll( SkillName.Tracking, level ) ); break;
					case 35: m.AddToBackpack( new PowerScroll( SkillName.Wrestling, level ) ); break;
					
				} 		
				m.SendLocalizedMessage( 1049524 ); // You have received a scroll of power!
				if (Utility.Random(100) < 5) // 5% chance to drop
				{
					switch ( Utility.Random( 310 )) //select random number between 0-46
					{
						
						
				case 0: m.AddToBackpack( new GlassSword() ); break;
                case 1: m.AddToBackpack( new JesterHatofChuckles() ); break;
                case 2: m.AddToBackpack( new  SamuraiHelm() ); break;
                case 3: m.AddToBackpack( new BlazeOfDeath() ); break;
                case 4: m.AddToBackpack( new  BurglarsBandana() ); break;
                case 5: m.AddToBackpack( new EnchantedTitanLegBone() ); break;
                case 6: m.AddToBackpack( new EarringsOfTheVile() ); break;
                case 7: m.AddToBackpack( new ShaminoCrossbow() ); break;
                case 8: m.AddToBackpack( new CavortingClub() ); break;
                case 9: m.AddToBackpack( new GwennosHarp() ); break;
                case 10: m.AddToBackpack( new QuiverOfInfinity() ); break;
                case 11: m.AddToBackpack( new EarringsOfProtection() ); break;
                case 12: m.AddToBackpack( new LuckyNecklace() ); break;
                case 13: m.AddToBackpack( new HolySword() ); break;
                case 14: m.AddToBackpack( new DupresShield() ); break;
                case 15: m.AddToBackpack( new EarringBoxSet() ); break;
                case 16: m.AddToBackpack( new IolosLute() ); break;
                case 17: m.AddToBackpack( new NightsKiss() ); break;
                case 18: m.AddToBackpack( new  OrcishVisage() ); break;
                case 19: m.AddToBackpack( new ShieldOfInvulnerability() ); break;
                case 20: m.AddToBackpack( new VioletCourage() ); break;
                case 21: m.AddToBackpack( new WrathOfTheDryad() ); break;
                case 22: m.AddToBackpack( new GlovesOfThePugilist() ); break;
                case 23: m.AddToBackpack( new CandelabraOfSouls() ); break;
                case 24: m.AddToBackpack( new  ArcaneArms() ); break;
                case 25: m.AddToBackpack( new LunaLance() ); break;
                case 26: m.AddToBackpack( new  NoxRangersHeavyCrossbow() ); break;
                case 27: m.AddToBackpack( new PolarBearMask() ); break;
                case 28: m.AddToBackpack( new StaffOfPower() ); break;
                case 29: m.AddToBackpack( new HeartOfTheLion() ); break;
                case 30: m.AddToBackpack( new PixieSwatter() ); break;
                case 31: m.AddToBackpack( new DreadPirateHat() ); break;
                case 32: m.AddToBackpack( new ColdBlood() ); break;
                case 33: m.AddToBackpack( new GlovesOfAegis() ); break;
                case 34: m.AddToBackpack( new SilvanisFeywoodBow() ); break;
                case 35: m.AddToBackpack( new TheNightReaper() ); break;
                case 36: m.AddToBackpack( new BlightGrippedLongbow() ); break;
                case 37: m.AddToBackpack( new ColdForgedBlade() ); break;
                case 38: m.AddToBackpack( new LuminousRuneBlade() ); break;
                case 39: m.AddToBackpack( new OverseerSunderedBlade() ); break;
                case 40: m.AddToBackpack( new PhantomStaff() ); break;
                case 41: m.AddToBackpack( new RuneCarvingKnife() ); break;
                case 42: m.AddToBackpack( new JackalsTunic() ); break;
				case 43: m.AddToBackpack( new ArcaneCap() ); break;
                case 44: m.AddToBackpack( new ArcaneGloves() ); break;
                case 45: m.AddToBackpack( new ArcaneGorget() ); break;
                case 46: m.AddToBackpack( new ArcaneLeggings() ); break;//
				case 47: m.AddToBackpack( new ArcaneTunic() ); break;
                case 48: m.AddToBackpack( new ArmorOfInsight() ); break;
                case 49: m.AddToBackpack( new ArmorOfNobility() ); break;
                case 50: m.AddToBackpack( new ArmsOfAegis() ); break;
				case 51: m.AddToBackpack( new ArmsOfFortune() ); break;
                case 52: m.AddToBackpack( new GlovesOfFortune() ); break;
                case 53: m.AddToBackpack( new GlovesOfInsight() ); break;
                case 54: m.AddToBackpack( new GlovesOfTheFallenKing() ); break;
				case 55: m.AddToBackpack( new GlovesOfTheHarrower() ); break;
                case 56: m.AddToBackpack( new GorgetOfAegis() ); break;
                case 57: m.AddToBackpack( new GorgetOfFortune() ); break;
                case 58: m.AddToBackpack( new GorgetOfInsight() ); break;
				case 59: m.AddToBackpack( new HelmOfAegis() ); break;
                case 60: m.AddToBackpack( new HolyKnightsArmPlates() ); break;
                case 61: m.AddToBackpack( new LeggingsOfAegis() ); break;
                case 62: m.AddToBackpack( new LeggingsOfFire() ); break;
				case 63: m.AddToBackpack( new LegsOfFortune() ); break;
                case 64: m.AddToBackpack( new LegsOfInsight() ); break;
                case 65: m.AddToBackpack( new LegsOfNobility() ); break;
                case 66: m.AddToBackpack( new LegsOfTheFallenKing() ); break;
				case 67: m.AddToBackpack( new LegsOfTheHarrower() ); break;
                case 68: m.AddToBackpack( new MidnightGloves() ); break;
                case 69: m.AddToBackpack( new MidnightHelm() ); break;
                case 70: m.AddToBackpack( new ArmsOfInsight() ); break;
				case 71: m.AddToBackpack( new ArmsOfNobility() ); break;
                case 72: m.AddToBackpack( new ArmsOfTheFallenKing() ); break;
                case 73: m.AddToBackpack( new ArmsOfTheHarrower() ); break;
                case 74: m.AddToBackpack( new BraceletOfTheElements() ); break;
				case 75: m.AddToBackpack( new BraceletOfTheVile() ); break;
				case 76: m.AddToBackpack( new CapOfFortune() ); break;
                case 77: m.AddToBackpack( new CapOfTheFallenKing() ); break;
                case 78: m.AddToBackpack( new CoifOfBane() ); break;
                case 79: m.AddToBackpack( new CoifOfFire() ); break;
				case 80: m.AddToBackpack( new DivineArms() ); break;
				case 81: m.AddToBackpack( new DivineGloves() ); break;
                case 82: m.AddToBackpack( new DivineGorget() ); break;
                case 83: m.AddToBackpack( new DivineLeggings() ); break;
                case 84: m.AddToBackpack( new DivineTunic() ); break;
				case 85: m.AddToBackpack( new HolyKnightsGloves() ); break;
				case 86: m.AddToBackpack( new HolyKnightsGorget() ); break;
                case 87: m.AddToBackpack( new HolyKnightsLegging() ); break;
                case 88: m.AddToBackpack( new HolyKnightsPlateHelm() ); break;
                case 89: m.AddToBackpack( new HuntersArms() ); break;
				case 90: m.AddToBackpack( new HuntersGloves() ); break;
				case 91: m.AddToBackpack( new HuntersGorget() ); break;
                case 92: m.AddToBackpack( new HuntersLeggings() ); break;
                case 93: m.AddToBackpack( new HuntersTunic() ); break;
                case 94: m.AddToBackpack( new InquisitorsArms() ); break;
				case 95: m.AddToBackpack( new InquisitorsGorget() ); break;
                case 96: m.AddToBackpack( new InquisitorsGorget() ); break;
                case 97: m.AddToBackpack( new InquisitorsHelm() ); break;
                case 98: m.AddToBackpack( new InquisitorsLeggings() ); break;
				case 99: m.AddToBackpack( new InquisitorsTunic() ); break;
				case 100: m.AddToBackpack( new JackalsArms() ); break;
                case 101: m.AddToBackpack( new MidnightLegs() ); break;
                case 102: m.AddToBackpack( new MidnightTunic() ); break;
                case 103: m.AddToBackpack( new RingOfHealth() ); break;
				case 104: m.AddToBackpack( new RingOfTheMagician() ); break;
                case 105: m.AddToBackpack( new ShadowDancerArms() ); break;
                case 106: m.AddToBackpack( new ShadowDancerCap() ); break;
                case 107: m.AddToBackpack( new ShadowDancerGloves() ); break;
				case 108: m.AddToBackpack( new ShadowDancerGorget() ); break;
				case 109: m.AddToBackpack( new ShadowDancerTunic() ); break;
                case 110: m.AddToBackpack( new TotemArms() ); break;
                case 111: m.AddToBackpack( new TotemGloves() ); break;
                case 112: m.AddToBackpack( new TotemGorget() ); break;
				case 113: m.AddToBackpack( new TotemLeggings() ); break;
                case 114: m.AddToBackpack( new TotemTunic() ); break;
                case 115: m.AddToBackpack( new TunicOfAegis() ); break;
                case 116: m.AddToBackpack( new EarringsOfHealth() ); break;
				case 117: m.AddToBackpack( new EarringsOfTheElements() ); break;
				case 118: m.AddToBackpack( new EarringsOfTheMagician() ); break;
                case 119: m.AddToBackpack( new YashimotosHatsuburi() ); break;
                case 120: m.AddToBackpack( new WarriorsClasp() ); break;
				case 121: m.AddToBackpack( new VampiricDaisho() ); break;
				case 122: m.AddToBackpack( new TownGuardsHalberd() ); break;
				case 123: m.AddToBackpack( new SwiftStrike() ); break;
                case 124: m.AddToBackpack( new SprintersSandals() ); break;
                case 125: m.AddToBackpack( new ShimmeringTalisman() ); break;
                case 126: m.AddToBackpack( new ShadowBlade() ); break;
				case 127: m.AddToBackpack( new JackalsGloves() ); break;
				case 128: m.AddToBackpack( new JackalsHelm() ); break;
				case 129: m.AddToBackpack( new JackalsHelm() ); break;
                case 130: m.AddToBackpack( new JackalsLeggings() ); break;
                case 131: m.AddToBackpack( new MauloftheBeast() ); break;
                case 132: m.AddToBackpack( new MarbleShield() ); break;
				case 133: m.AddToBackpack( new MagiciansMempo() ); break;
				case 134: m.AddToBackpack( new MagiciansIllusion() ); break;
				case 135: m.AddToBackpack( new MagesBand() ); break;
				case 136: m.AddToBackpack( new MadmansHatchet() ); break;
				case 137: m.AddToBackpack( new LuckyEarrings() ); break;
				case 138: m.AddToBackpack( new LeggingsOfEnlightenment() ); break;
				case 139: m.AddToBackpack( new TunicOfBane() ); break;
				case 140: m.AddToBackpack( new TunicOfTheFallenKing() ); break;
				case 141: m.AddToBackpack( new TunicOfTheHarrower() ); break;
				case 142: m.AddToBackpack( new Fortifiedarms() ); break;
				case 143: m.AddToBackpack( new FesteringWound() ); break;
				case 144: m.AddToBackpack( new FalseGodsScepter() ); break;
				case 145: m.AddToBackpack( new EternalFlame() ); break;
				case 146: m.AddToBackpack( new DupresCollar() ); break;
				case 147: m.AddToBackpack( new DeathsMask() ); break;
				case 148: m.AddToBackpack( new DarkNeck() ); break;
				case 149: m.AddToBackpack( new DarkLordsPitchfork() ); break;
				case 150: m.AddToBackpack( new CircletOfTheSorceress() ); break;
				case 151: m.AddToBackpack( new RoyalGuardsGorget() ); break;
				case 152: m.AddToBackpack( new RoyalGuardsChestplate() ); break;
				case 153: m.AddToBackpack( new RoyalArchersBow() ); break;
				case 154: m.AddToBackpack( new RobeOfTreason() ); break;
				case 155: m.AddToBackpack( new Retort() ); break;
				case 156: m.AddToBackpack( new RamusNecromanticScalpel() ); break;
				case 157: m.AddToBackpack( new PowerSurge() ); break;
				case 158: m.AddToBackpack( new Pestilence() ); break;
				case 159: m.AddToBackpack( new LeggingsOfDeceit() ); break;
				case 160: m.AddToBackpack( new KamiNarisIndestructableDoubleAxe() ); break;
				case 161: m.AddToBackpack( new JinBaoriOfGoodFortune() ); break;
				case 162: m.AddToBackpack( new JadeScimitar() ); break;
				case 163: m.AddToBackpack( new Indecency() ); break;
				case 164: m.AddToBackpack( new HellForgedArms() ); break;
				case 165: m.AddToBackpack( new GlovesOfRegeneration() ); break;
				case 166: m.AddToBackpack( new CircletOfTheSorceress() ); break;
				case 167: m.AddToBackpack( new GlovesOfCorruption() ); break;
				case 168: m.AddToBackpack( new DarkGuardiansChest() ); break;
				case 169: m.AddToBackpack( new BalancingDeed() ); break;
				case 170: m.AddToBackpack( new AuraOfShadows() ); break;
				case 171: m.AddToBackpack( new ArmsOfToxicity() ); break;
				case 172: m.AddToBackpack( new ArcticBeacon() ); break;
				case 173: m.AddToBackpack( new ArcanicRobe() ); break;
				case 174: m.AddToBackpack( new Annihilation() ); break;		
				case 175: m.AddToBackpack( new NoxNightlight() ); break;
				case 176: m.AddToBackpack( new NoxBow() ); break;
				case 177: m.AddToBackpack( new NordicVikingSword() ); break;
				case 178: m.AddToBackpack( new MinersPickaxe() ); break;
				case 179: m.AddToBackpack( new VoiceOfTheFallenKing() ); break;
				case 180: m.AddToBackpack( new ShadowDancerLeggings() ); break;
				case 181: m.AddToBackpack( new OrnateCrownOfTheHarrower() ); break;
				case 182: m.AddToBackpack( new MidnightBracers() ); break;
				case 183: m.AddToBackpack( new LeggingsOfBane() ); break;
				case 184: m.AddToBackpack( new JackalsCollar() ); break;
				case 185: m.AddToBackpack( new GeishasObi() ); break;
				case 186: m.AddToBackpack( new Fury() ); break;
				case 187: m.AddToBackpack( new FurCapeOfTheSorceress() ); break;
				case 188: m.AddToBackpack( new FortunateBlades() ); break;
				case 189: m.AddToBackpack( new Quell() ); break;
				case 190: m.AddToBackpack( new OrcChieftainHelm() ); break;
				case 191: m.AddToBackpack( new GladiatorsCollar() ); break;
				case 192: m.AddToBackpack( new FangOfRactus() ); break;
				case 193: m.AddToBackpack( new CrownOfTalKeesh() ); break;
				case 194: m.AddToBackpack( new Calm() ); break;
				case 195: m.AddToBackpack( new AcidProofRobe() ); break;
				case 196: m.AddToBackpack( new AngeroftheGods() ); break;
				case 197: m.AddToBackpack( new AngelicEmbrace() ); break;
				case 198: m.AddToBackpack( new AbysmalGloves() ); break;
				case 199: m.AddToBackpack( new RobeOfTheEquinox() ); break;
				case 200: m.AddToBackpack( new ArcaneShield() ); break;
				case 201: m.AddToBackpack( new ZyronicClaw() ); break;
				case 202: m.AddToBackpack( new TitansHammer() ); break;
				case 203: m.AddToBackpack( new TheTaskmaster() ); break;
				case 204: m.AddToBackpack( new TheDryadBow() ); break;
				case 205: m.AddToBackpack( new TheDragonSlayer() ); break;
				case 206: m.AddToBackpack( new TheBeserkersMaul() ); break;		
				case 207: m.AddToBackpack( new InquisitorsResolution() ); break;
				case 208: m.AddToBackpack( new HolyKnightsBreastplate() ); break;
				case 209: m.AddToBackpack( new HelmOfInsight() ); break;
				case 210: m.AddToBackpack( new GauntletsOfNobility() ); break;
				case 211: m.AddToBackpack( new ArmorOfFortune() ); break;
				case 212: m.AddToBackpack( new TheRobeOfBritanniaAri() ); break;
				case 213: m.AddToBackpack( new SamaritanRobe() ); break;
				case 214: m.AddToBackpack( new RoyalGuardSurvivalKnife() ); break;
				case 215: m.AddToBackpack( new OblivionsNeedle() ); break;
				case 216: m.AddToBackpack( new LieutenantOfTheBritannianRoyalGuard() ); break;
				case 217: m.AddToBackpack( new SpiritOfTheTotem() ); break;
				case 218: m.AddToBackpack( new HuntersHeaddress() ); break;
				case 219: m.AddToBackpack( new HatOfTheMagi() ); break;
				case 220: m.AddToBackpack( new DivineCountenance() ); break;
				case 221: m.AddToBackpack( new CrimsonCincture() ); break;
				case 222: m.AddToBackpack( new RingOfTheVile() ); break;
				case 223: m.AddToBackpack( new RingOfTheElements() ); break;
				case 224: m.AddToBackpack( new OrnamentOfTheMagician() ); break;
				case 225: m.AddToBackpack( new BraceletOfHealth() ); break;
				case 226: m.AddToBackpack( new StaffOfTheMagi() ); break;
				case 227: m.AddToBackpack( new SerpentsFang() ); break;
				case 228: m.AddToBackpack( new LegacyOfTheDreadLord() ); break;
				case 229: m.AddToBackpack( new Frostbringer() ); break;
				case 230: m.AddToBackpack( new BreathOfTheDead() ); break;
				case 231: m.AddToBackpack( new QuiverOfElements() ); break;
				case 232: m.AddToBackpack( new QuiverOfRage() ); break;
				case 233: m.AddToBackpack( new RighteousAnger() ); break;
				case 234: m.AddToBackpack( new RobeOfTheEclipse() ); break;
				case 235: m.AddToBackpack( new QuiverOfLightning() ); break;
				case 236: m.AddToBackpack( new GuantletsOfAnger() ); break;
				case 237: m.AddToBackpack( new EmbroideredOakLeafCloak() ); break;
				case 238: m.AddToBackpack( new DjinnisRing() ); break;
				case 239: m.AddToBackpack( new Subdue() ); break;
				case 240: m.AddToBackpack( new ShroudOfDeciet() ); break;
				case 241: m.AddToBackpack( new EverlastingLoaf() ); break;
				case 242: m.AddToBackpack( new PolarBearBoots() ); break;
				case 243: m.AddToBackpack( new Stormbringer() ); break;
				case 244: m.AddToBackpack( new StaffofSnakes() ); break;
				case 245: m.AddToBackpack( new RobinHoodsFeatheredHat() ); break;
				case 246: m.AddToBackpack( new AxeoftheMinotaur() ); break;
				case 247: m.AddToBackpack( new QuiverOfIce() ); break;
				case 248: m.AddToBackpack( new QuiverOfFire() ); break;
				case 249: m.AddToBackpack( new QuiverOfBlight() ); break;
				case 250: m.AddToBackpack( new ElvenQuiver() ); break;
				case 251: m.AddToBackpack( new Aegis() ); break;
				case 252: m.AddToBackpack( new EverlastingBottle() ); break;
				case 253: m.AddToBackpack( new Excalibur() ); break;
				case 254: m.AddToBackpack( new AchillesShield() ); break;
				case 255: m.AddToBackpack( new AilricsLongbow() ); break;
				case 256: m.AddToBackpack( new RobinHoodsBow() ); break;
				case 257: m.AddToBackpack( new BowofthePhoenix() ); break;
				case 258: m.AddToBackpack( new SoulSeeker() ); break;
				case 259: m.AddToBackpack( new TalonBite() ); break;
				case 260: m.AddToBackpack( new WildfireBow() ); break;
				case 261: m.AddToBackpack( new TotemOfVoid() ); break;
				case 262: m.AddToBackpack( new Windsong() ); break;
				case 263: m.AddToBackpack( new KodiakBearMask() ); break;
				case 264: m.AddToBackpack( new AchillesSpear() ); break;
				case 265: m.AddToBackpack( new PolarBearCape() ); break;
				case 266: m.AddToBackpack( new BeltofHercules() ); break;
				case 267: m.AddToBackpack( new HammerofThor() ); break;
				case 268: m.AddToBackpack( new GandalfsRobe() ); break;
				case 269: m.AddToBackpack( new ConansHelm() ); break;
				case 270: m.AddToBackpack( new SkullChest() ); break;
				case 271: m.AddToBackpack( new VampiresRobe() ); break;
				case 272: m.AddToBackpack( new EssenceOfBattle() ); break;
				case 273: m.AddToBackpack( new QuiverOfRage() ); break;
				case 274: m.AddToBackpack( new GrayMouserCloak() ); break;
				case 275: m.AddToBackpack( new CandleCold() ); break;
				case 276: m.AddToBackpack( new CandleEnergy() ); break;
				case 277: m.AddToBackpack( new GrimReapersRobe() ); break;
				case 278: m.AddToBackpack( new GrimReapersScythe() ); break;
				case 279: m.AddToBackpack( new RobeOfTeleportation() ); break;
				case 280: m.AddToBackpack( new GlovesOfDexterity() ); break;
				case 281: m.AddToBackpack( new ColoringBook() ); break;
				case 282: m.AddToBackpack( new ConansSword() ); break;
				case 283: m.AddToBackpack( new ShardThrasher() ); break;
				case 284: m.AddToBackpack( new ConansLoinCloth() ); break;
				case 285: m.AddToBackpack( new ResilientBracer() ); break;
				case 286: m.AddToBackpack( new MelisandesCorrodedHatchet() ); break;
				case 287: m.AddToBackpack( new BootsofHermes() ); break;
				case 288: m.AddToBackpack( new CandleFire() ); break;
				case 289: m.AddToBackpack( new CandleWizard() ); break;
				case 290: m.AddToBackpack( new GrimReapersMask() ); break;
				case 291: m.AddToBackpack( new TorchOfTrapFinding() ); break;
				case 292: m.AddToBackpack( new MaulOfTheTitans() ); break;
				case 293: m.AddToBackpack( new GemOfSeeing() ); break;
				case 294: m.AddToBackpack( new BagOfHolding() ); break;
				case 295: m.AddToBackpack( new SinbadsSword() ); break;
				case 296: m.AddToBackpack( new BeggarsRobe() ); break;
				case 297: m.AddToBackpack( new PendantOfTheMagi() ); break;
				case 298: m.AddToBackpack( new GiantBlackjack() ); break;
				case 299: m.AddToBackpack( new BloodwoodSpirit() ); break;
				case 300: m.AddToBackpack( new FleshRipper() ); break;
				case 301: m.AddToBackpack( new CandlePoison() ); break;
				case 302: m.AddToBackpack( new CandleNecromancer() ); break;
				case 303: m.AddToBackpack( new GrimReapersLantern() ); break;
				case 304: m.AddToBackpack( new RodOfResurrection() ); break;
				case 305: m.AddToBackpack( new HelmOfBrilliance() ); break;
				case 306: m.AddToBackpack( new DaggerOfVenom() ); break;
				case 307: m.AddToBackpack( new ArcaneGorget() ); break;
                case 308: m.AddToBackpack( new ArcaneLeggings() ); break;
						
	
						
					}
					m.SendMessage( "You have recieved a runic tool."); 
				}
			}
		}

		public override bool OnBeforeDeath( ) //what happens before it dies
		{
			if ( m_Timer != null )
				m_Timer.Stop();
			
			GiveCraftPowerScroll(); //call the generate ps routine

			switch (Utility.Random(30)) //select random number between 0-29
			{
				case 0: PackItem( new GargoylesAxe()); break;
				case 1: PackItem( new GargoylesPickaxe()); break;
				//case 2: PackItem( new GargoylesKnife()); break;
				//case 3: PackItem( new GargoylesKnife()); break;
				case 4: PackItem( new ProspectorsTool()); break;
				//case 5: PackItem( new LumberjackingProspectorsTool()); break;
			}
			if (ChampionSpawn == false) //if it wasn't spawned as part of champ spawn then don't add gold.
				return true;

			Map map = this.Map; //set variable map to hold the current map

			if ( map != null ) //if the map isn't null (anti crash check) coontinue
			{
				for ( int x = -8; x <= 8; ++x ) //for 8x8 location
				{
					for ( int y = -8; y <= 8; ++y )
					{
						double dist = Math.Sqrt(x*x+y*y);

						if ( dist <= 8 )
							new GoldTimer( map, X + x, Y + y ).Start(); //spawn gold on timers
					}
				}
			}
			return true;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.UltraRich, 8 );
			AddLoot( LootPack.Gems, 13 );
			AddLoot( LootPack.MedScrolls, 11 );
		}

		public Hodur( Serial serial ) : base( serial )
		{
		}

		public override int Meat{ get{ return 8; } }
		public override int TreasureMapLevel{ get{ return 5; } }
		public override bool BardImmune{ get{ return !Core.SE; } }
		public override bool Unprovokable{ get{ return Core.SE; } }
		public override bool Uncalmable{ get{ return Core.SE; } }
		public override bool AutoDispel{ get{ return true; } }
		public override bool BleedImmune{ get{ return true; } }

		public void DrainLife()
		{
			ArrayList list = new ArrayList();

			foreach ( Mobile m in this.GetMobilesInRange( 10 ) )
			{
				if ( m == this || !CanBeHarmful( m ) )
					continue;

				if ( m is BaseCreature && (((BaseCreature)m).Controlled || ((BaseCreature)m).Summoned || ((BaseCreature)m).Team != this.Team) )
					list.Add( m );
				else if ( m.Player )
					list.Add( m );
			}

			foreach ( Mobile m in list )
			{
				DoHarmful( m );

				m.FixedParticles( 0x374A, 10, 15, 5013, 0x496, 0, EffectLayer.Waist );
				m.PlaySound( 0x231 );

				m.SendMessage( "Your Soul is Mine!" );

				int toDrain = Utility.RandomMinMax( 10, 40 );

				Hits += toDrain;
				m.Damage( toDrain, this );
			}
		}

		public override void OnGaveMeleeAttack( Mobile defender )
		{
			base.OnGaveMeleeAttack( defender );

			if ( 0.1 >= Utility.RandomDouble() )
				DrainLife();
		}

		public override void OnGotMeleeAttack( Mobile attacker )
		{
			base.OnGotMeleeAttack( attacker );

			if ( 0.1 >= Utility.RandomDouble() )
				DrainLife();
		}
		
		private Timer m_Timer;
		private string m_Name;
		private int m_Hue;

		public override void OnThink()
		{
			base.OnThink();
			
			if ( Combatant == null )
				return;	
				
			if ( Hits > 0.8 * HitsMax && Utility.RandomDouble() < 0.05 )
				FireRing();				
				
			if ( Combatant.Player && Name != Combatant.Name )
				Morph();	
		}
		
		public virtual void Morph()
		{
			m_Name = Name;
			m_Hue = Hue;
			
			Body = Combatant.Body; 
			Hue = Combatant.Hue; 
			Name = Combatant.Name;
			Female = Combatant.Female;
			Title = Combatant.Title;
  				
			foreach ( Item item in Combatant.Items )
			{
				if ( item.Layer != Layer.Backpack && item.Layer != Layer.Mount )
					if ( FindItemOnLayer( item.Layer ) == null )
						AddItem( new ClonedItem( item ) );
			}
			
			PlaySound( 0x511 );
			FixedParticles( 0x376A, 1, 14, 5045, EffectLayer.Waist );
			
			if ( m_Timer != null )
				m_Timer.Stop();
			
			m_Timer = Timer.DelayCall( TimeSpan.FromSeconds( 5 ), TimeSpan.FromSeconds( 5 ), new TimerCallback( EndMorph ) );
		}
		
		public void DeleteItems()
		{		
			for ( int i = Items.Count - 1; i >= 0; i -- )
				if ( Items[ i ] is ClonedItem )
					Items[ i ].Delete();
					
			if ( Backpack != null )
			{
				for ( int i = Backpack.Items.Count - 1; i >= 0; i -- )
					if ( Backpack.Items[ i ] is ClonedItem )
						Backpack.Items[ i ].Delete();
			}
		}
		
		public virtual void EndMorph()
		{
			if ( Combatant != null && Name == Combatant.Name )
				return;
		
			DeleteItems();
			
			if ( m_Timer != null )
			{
				m_Timer.Stop();		
				m_Timer = null;	
			}
				
			if ( Combatant != null )
			{
				Morph();				
				return;
			}
			
			Body = 400;
			Title = null;
			Name = m_Name;
			Hue = m_Hue;
			
			PlaySound( 0x511 );
			FixedParticles( 0x376A, 1, 14, 5045, EffectLayer.Waist );
		}
		
		private static int[] m_North = new int[]
		{
			-1, -1, 
			1, -1,
			-1, 2,
			1, 2
		};
		
		private static int[] m_East = new int[]
		{
			-1, 0,
			2, 0
		};
		
		public virtual void FireRing()
		{
			for ( int i = 0; i < m_North.Length; i += 2 ) 
			{
				Point3D p = Location;
				
				p.X += m_North[ i ];
				p.Y += m_North[ i + 1 ];
				
				IPoint3D po = p as IPoint3D;
				
				SpellHelper.GetSurfaceTop( ref po );
				
				Effects.SendLocationEffect( po, Map, 0x3E27, 50 );
			}
			
			for ( int i = 0; i < m_East.Length; i += 2 ) 
			{
				Point3D p = Location;
				
				p.X += m_East[ i ];
				p.Y += m_East[ i + 1 ];
				
				IPoint3D po = p as IPoint3D;
				
				SpellHelper.GetSurfaceTop( ref po );
				
				Effects.SendLocationEffect( po, Map, 0x3E31, 50 );
			}
		}
		
		
		public override void OnAfterDelete()
		{					
			if ( m_Timer != null )
				m_Timer.Stop();
				
			base.OnAfterDelete();	
		}
		
		public override void Damage( int amount, Mobile from )
		{
			base.Damage( amount, from );
						
			if ( Combatant == null || Hits > HitsMax * 0.2 || Utility.RandomBool() )
				return;	
							
			new InvisibilitySpell( this, null ).Cast();
			
			Target target = Target;
			
			if ( target != null )
				target.Invoke( this, this );
				
			Timer.DelayCall( TimeSpan.FromSeconds( 1 ), new TimerCallback( Teleport ) );
		}
		
		public virtual void Teleport()
		{				
			if ( Combatant == null )
				return;
						
			// 20 tries to teleport
			for ( int tries = 0; tries < 20; tries ++ )
			{
				int x = Utility.RandomMinMax( 5, 7 ); 
				int y = Utility.RandomMinMax( 5, 7 );
				
				if ( Utility.RandomBool() )
					x *= -1;
					
				if ( Utility.RandomBool() )
					y *= -1;
				
				Point3D p = new Point3D( X + x, Y + y, 0 );
				IPoint3D po = new LandTarget( p, Map ) as IPoint3D;
				
				if ( po == null )
					continue;
					
				SpellHelper.GetSurfaceTop( ref po );

				if ( InRange( p, 12 ) && InLOS( p ) && Map.CanSpawnMobile( po.X, po.Y, po.Z ) )
				{					
					
					Point3D from = Location;
					Point3D to = new Point3D( po );
	
					Location = to;
					ProcessDelta();
					
					FixedParticles( 0x376A, 9, 32, 0x13AF, EffectLayer.Waist );
					PlaySound( 0x1FE );
										
					return;					
				}
			}		
			
			RevealingAction();
		}
		
			private class GoldTimer : Timer
		{
			private Map m_Map;
			private int m_X, m_Y;

			public GoldTimer( Map map, int x, int y ) : base( TimeSpan.FromSeconds( Utility.RandomDouble() * 10.0 ) )
			{
				m_Map = map;
				m_X = x;
				m_Y = y;
			}

			protected override void OnTick()
			{
				int z = m_Map.GetAverageZ( m_X, m_Y );
				bool canFit = m_Map.CanFit( m_X, m_Y, z, 6, false, false );

				for ( int i = -3; !canFit && i <= 3; ++i )
				{
					canFit = m_Map.CanFit( m_X, m_Y, z + i, 6, false, false );

					if ( canFit )
						z += i;
				}

				if ( !canFit )
					return;

				Gold g = new Gold( 5, 10 );
				
				g.MoveToWorld( new Point3D( m_X, m_Y, z ), m_Map );

				if ( 0.5 >= Utility.RandomDouble() )
				{
					switch ( Utility.Random( 3 ) )
					{
						case 0: // Fire column
						{
							Effects.SendLocationParticles( EffectItem.Create( g.Location, g.Map, EffectItem.DefaultDuration ), 0x3709, 10, 30, 5052 );
							Effects.PlaySound( g, g.Map, 0x208 );

							break;
						}
						case 1: // Explosion
						{
							Effects.SendLocationParticles( EffectItem.Create( g.Location, g.Map, EffectItem.DefaultDuration ), 0x36BD, 20, 10, 5044 );
							Effects.PlaySound( g, g.Map, 0x307 );

							break;
						}
						case 2: // Ball of fire
						{
							Effects.SendLocationParticles( EffectItem.Create( g.Location, g.Map, EffectItem.DefaultDuration ), 0x36FE, 10, 10, 5052 );

							break;
						}
					}
				}
			}
		}
	

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}

		private class ClonedItem : Item
		{	
			public ClonedItem( Item oItem ) : base( oItem.ItemID )
			{
				Name = oItem.Name;
				Weight = oItem.Weight;
				Hue = oItem.Hue;
				Layer = oItem.Layer;
			}
	
			public override DeathMoveResult OnParentDeath( Mobile parent )
			{
			        return DeathMoveResult.RemainEquiped;
			}
			
			public override DeathMoveResult OnInventoryDeath( Mobile parent )
			{
			        Delete();
			        return base.OnInventoryDeath( parent );
			}
	
			public ClonedItem( Serial serial ) : base( serial )
			{
			}
	
			public override void Serialize( GenericWriter writer )
			{
				base.Serialize( writer );
				
				writer.Write( (int) 0 ); // version
			}
	
			public override void Deserialize( GenericReader reader )
			{
				base.Deserialize( reader );
				
				int version = reader.ReadInt();
			}
		}
	}
}

