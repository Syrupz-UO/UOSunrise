using System;
using Server;

namespace Server.Spells
{
	public class Initializer
	{
		public static void Initialize()
		{
			// First circle
			Register( 00, typeof( First.ClumsySpell ) );
			Register( 01, typeof( First.CreateFoodSpell ) );
			Register( 02, typeof( First.FeeblemindSpell ) );
			Register( 03, typeof( First.HealSpell ) );
			Register( 04, typeof( First.MagicArrowSpell ) );
			Register( 05, typeof( First.NightSightSpell ) );
			Register( 06, typeof( First.ReactiveArmorSpell ) );
			Register( 07, typeof( First.WeakenSpell ) );

			// Second circle
			Register( 08, typeof( Second.AgilitySpell ) );
			Register( 09, typeof( Second.CunningSpell ) );
			Register( 10, typeof( Second.CureSpell ) );
			Register( 11, typeof( Second.HarmSpell ) );
			Register( 12, typeof( Second.MagicTrapSpell ) );
			Register( 13, typeof( Second.RemoveTrapSpell ) );
			Register( 14, typeof( Second.ProtectionSpell ) );
			Register( 15, typeof( Second.StrengthSpell ) );

			// Third circle
			Register( 16, typeof( Third.BlessSpell ) );
			Register( 17, typeof( Third.FireballSpell ) );
			Register( 18, typeof( Third.MagicLockSpell ) );
			Register( 19, typeof( Third.PoisonSpell ) );
			Register( 20, typeof( Third.TelekinesisSpell ) );
			Register( 21, typeof( Third.TeleportSpell ) );
			Register( 22, typeof( Third.UnlockSpell ) );
			Register( 23, typeof( Third.WallOfStoneSpell ) );

			// Fourth circle
			Register( 24, typeof( Fourth.ArchCureSpell ) );
			Register( 25, typeof( Fourth.ArchProtectionSpell ) );
			Register( 26, typeof( Fourth.CurseSpell ) );
			Register( 27, typeof( Fourth.FireFieldSpell ) );
			Register( 28, typeof( Fourth.GreaterHealSpell ) );
			Register( 29, typeof( Fourth.LightningSpell ) );
			Register( 30, typeof( Fourth.ManaDrainSpell ) );
			Register( 31, typeof( Fourth.RecallSpell ) );

			// Fifth circle
			Register( 32, typeof( Fifth.BladeSpiritsSpell ) );
			Register( 33, typeof( Fifth.DispelFieldSpell ) );
			Register( 34, typeof( Fifth.IncognitoSpell ) );
			Register( 35, typeof( Fifth.MagicReflectSpell ) );
			Register( 36, typeof( Fifth.MindBlastSpell ) );
			Register( 37, typeof( Fifth.ParalyzeSpell ) );
			Register( 38, typeof( Fifth.PoisonFieldSpell ) );
			Register( 39, typeof( Fifth.SummonCreatureSpell ) );

			// Sixth circle
			Register( 40, typeof( Sixth.DispelSpell ) );
			Register( 41, typeof( Sixth.EnergyBoltSpell ) );
			Register( 42, typeof( Sixth.ExplosionSpell ) );
			Register( 43, typeof( Sixth.InvisibilitySpell ) );
			Register( 44, typeof( Sixth.MarkSpell ) );
			Register( 45, typeof( Sixth.MassCurseSpell ) );
			Register( 46, typeof( Sixth.ParalyzeFieldSpell ) );
			Register( 47, typeof( Sixth.RevealSpell ) );

			// Seventh circle
			Register( 48, typeof( Seventh.ChainLightningSpell ) );
			Register( 49, typeof( Seventh.EnergyFieldSpell ) );
			Register( 50, typeof( Seventh.FlameStrikeSpell ) );
			Register( 51, typeof( Seventh.GateTravelSpell ) );
			Register( 52, typeof( Seventh.ManaVampireSpell ) );
			Register( 53, typeof( Seventh.MassDispelSpell ) );
			Register( 54, typeof( Seventh.MeteorSwarmSpell ) );
			Register( 55, typeof( Seventh.PolymorphSpell ) );

			// Eighth circle
			Register( 56, typeof( Eighth.EarthquakeSpell ) );
			Register( 57, typeof( Eighth.EnergyVortexSpell ) );
			Register( 58, typeof( Eighth.ResurrectionSpell ) );
			Register( 59, typeof( Eighth.AirElementalSpell ) );
			Register( 60, typeof( Eighth.SummonDaemonSpell ) );
			Register( 61, typeof( Eighth.EarthElementalSpell ) );
			Register( 62, typeof( Eighth.FireElementalSpell ) );
			Register( 63, typeof( Eighth.WaterElementalSpell ) );

			if ( Core.AOS )
			{
				// Necromancy spells
				Register( 100, typeof( Necromancy.AnimateDeadSpell ) );
				Register( 101, typeof( Necromancy.BloodOathSpell ) );
				Register( 102, typeof( Necromancy.CorpseSkinSpell ) );
				Register( 103, typeof( Necromancy.CurseWeaponSpell ) );
				Register( 104, typeof( Necromancy.EvilOmenSpell ) );
				Register( 105, typeof( Necromancy.HorrificBeastSpell ) );
				Register( 106, typeof( Necromancy.LichFormSpell ) );
				Register( 107, typeof( Necromancy.MindRotSpell ) );
				Register( 108, typeof( Necromancy.PainSpikeSpell ) );
				Register( 109, typeof( Necromancy.PoisonStrikeSpell ) );
				Register( 110, typeof( Necromancy.StrangleSpell ) );
				Register( 111, typeof( Necromancy.SummonFamiliarSpell ) );
				Register( 112, typeof( Necromancy.VampiricEmbraceSpell ) );
				Register( 113, typeof( Necromancy.VengefulSpiritSpell ) );
				Register( 114, typeof( Necromancy.WitherSpell ) );
				Register( 115, typeof( Necromancy.WraithFormSpell ) );
				Register( 116, typeof( Necromancy.ExorcismSpell ) );

				// NEW POTION EFFECTS ADDED BY WIZARD //
				Register( 131, typeof( Undead.SpectreShadowSpell ) );
				Register( 132, typeof( Undead.ManaLeechSpell ) );
				Register( 133, typeof( Undead.UndeadCurePoisonSpell ) );
				Register( 134, typeof( Undead.HellsBrandSpell ) );
				Register( 135, typeof( Undead.UndeadGraveyardGatewaySpell ) );
				Register( 136, typeof( Undead.RetchedAirSpell ) );
				Register( 137, typeof( Undead.UndeadEyesSpell ) );
				Register( 138, typeof( Undead.UndeadWallOfSpikesSpell ) );
				Register( 139, typeof( Undead.VampireGiftSpell ) );
				Register( 140, typeof( Undead.UndeadBloodPactSpell ) );
				Register( 141, typeof( Undead.NecroPoisonSpell ) );
				Register( 142, typeof( Undead.HellsGateSpell ) );
				Register( 143, typeof( Undead.GhostlyImagesSpell ) );
				Register( 144, typeof( Undead.GhostPhaseSpell ) );
				Register( 145, typeof( Undead.NecroUnlockSpell ) );
				Register( 146, typeof( Undead.PhantasmSpell ) );

        		Register( 147, typeof( Herbalist.ShieldOfEarthSpell ) );
        		Register( 148, typeof( Herbalist.WoodlandProtectionSpell ) );
        		Register( 149, typeof( Herbalist.ProtectiveFairySpell ) );
        		Register( 150, typeof( Herbalist.HerbalHealingSpell ) );
       			Register( 151, typeof( Herbalist.GraspingRootsSpell ) );
				Register( 152, typeof( Herbalist.BlendWithForestSpell ) );
				Register( 153, typeof( Herbalist.SwarmOfInsectsSpell ) );
      			Register( 154, typeof( Herbalist.VolcanicEruptionSpell ) );
			 	Register( 155, typeof( Herbalist.TreefellowSpell ) );
			 	Register( 156, typeof( Herbalist.StoneCircleSpell ) );
				Register( 157, typeof( Herbalist.DruidicRuneSpell ) );
				Register( 158, typeof( Herbalist.LureStoneSpell ) );
				Register( 159, typeof( Herbalist.NaturesPassageSpell ) );
				Register( 160, typeof( Herbalist.MushroomGatewaySpell ) );
				Register( 161, typeof( Herbalist.RestorativeSoilSpell ) );
				Register( 162, typeof( Herbalist.FireflySpell ) );

				// Paladin abilities
				Register( 200, typeof( Chivalry.CleanseByFireSpell ) );
				Register( 201, typeof( Chivalry.CloseWoundsSpell ) );
				Register( 202, typeof( Chivalry.ConsecrateWeaponSpell ) );
				Register( 203, typeof( Chivalry.DispelEvilSpell ) );
				Register( 204, typeof( Chivalry.DivineFurySpell ) );
				Register( 205, typeof( Chivalry.EnemyOfOneSpell ) );
				Register( 206, typeof( Chivalry.HolyLightSpell ) );
				Register( 207, typeof( Chivalry.NobleSacrificeSpell ) );
				Register( 208, typeof( Chivalry.RemoveCurseSpell ) );
				Register( 209, typeof( Chivalry.SacredJourneySpell ) );

				// Samurai abilities
				Register( 400, typeof( Bushido.HonorableExecution ) );
				Register( 401, typeof( Bushido.Confidence ) );
				Register( 402, typeof( Bushido.Evasion ) );
				Register( 403, typeof( Bushido.CounterAttack ) );
				Register( 404, typeof( Bushido.LightningStrike ) );
				Register( 405, typeof( Bushido.MomentumStrike ) );

				// Ninja abilities
				Register( 500, typeof( Ninjitsu.FocusAttack ) );
				Register( 501, typeof( Ninjitsu.DeathStrike ) );
				Register( 502, typeof( Ninjitsu.AnimalForm ) );
				Register( 503, typeof( Ninjitsu.KiAttack ) );
				Register( 504, typeof( Ninjitsu.SurpriseAttack ) );
				Register( 505, typeof( Ninjitsu.Backstab ) );
				Register( 506, typeof( Ninjitsu.Shadowjump ) );
				Register( 507, typeof( Ninjitsu.MirrorImage ) );

				if( Core.ML )
				{
					Register( 600, typeof( Spellweaving.ArcaneCircleSpell ) );
					Register( 601, typeof( Spellweaving.GiftOfRenewalSpell ) );
					//Register( 602, typeof( Spellweaving.ImmolatingWeaponSpell ) );
					Register( 603, typeof( Spellweaving.AttuneWeaponSpell ) );
					Register( 604, typeof( Spellweaving.ThunderstormSpell ) );
					Register( 605, typeof( Spellweaving.NatureFurySpell ) );
					Register( 606, typeof( Spellweaving.SummonFeySpell ) );
					Register( 607, typeof( Spellweaving.SummonFiendSpell ) );
					Register( 608, typeof( Spellweaving.ReaperFormSpell ) );
					//Register( 609, typeof( Spellweaving.WildfireSpell ) );
					Register( 610, typeof( Spellweaving.EssenceOfWindSpell ) );
					//Register( 611, typeof( Spellweaving.DryadAllureSpell ) );
					Register( 612, typeof( Spellweaving.EtherealVoyageSpell ) );
					Register( 613, typeof( Spellweaving.WordOfDeathSpell ) );
					Register( 614, typeof( Spellweaving.GiftOfLifeSpell ) );
					//Register( 615, typeof( Spellweaving.ArcaneEmpowermentSpell ) );
				}

				// WIZARD SPELLS FOR CERTAIN ITEMS //
				Register( 700, typeof( Magical.SummonSnakesSpell ) );
				Register( 701, typeof( Magical.SummonDragonSpell ) );
				Register( 702, typeof( Magical.ThorLightningSpell ) );

				// Death Knight Spells
				Register( 750, typeof( DeathKnight.BanishSpell ) );
				Register( 751, typeof( DeathKnight.DemonicTouchSpell ) );
				Register( 752, typeof( DeathKnight.DevilPactSpell ) );
				Register( 753, typeof( DeathKnight.GrimReaperSpell ) );
				Register( 754, typeof( DeathKnight.HagHandSpell ) );
				Register( 755, typeof( DeathKnight.HellfireSpell ) );
				Register( 756, typeof( DeathKnight.LucifersBoltSpell ) );
				Register( 757, typeof( DeathKnight.OrbOfOrcusSpell ) );
				Register( 758, typeof( DeathKnight.ShieldOfHateSpell ) );
				Register( 759, typeof( DeathKnight.SoulReaperSpell ) );
				Register( 760, typeof( DeathKnight.StrengthOfSteelSpell ) );
				Register( 761, typeof( DeathKnight.StrikeSpell ) );
				Register( 762, typeof( DeathKnight.SuccubusSkinSpell ) );
				Register( 763, typeof( DeathKnight.WrathSpell ) );

				// Holy Man Spells
				Register( 770, typeof( HolyMan.BanishEvilSpell ) );
				Register( 771, typeof( HolyMan.DampenSpiritSpell ) );
				Register( 772, typeof( HolyMan.EnchantSpell ) );
				Register( 773, typeof( HolyMan.HammerOfFaithSpell ) );
				Register( 774, typeof( HolyMan.HeavenlyLightSpell ) );
				Register( 775, typeof( HolyMan.NourishSpell ) );
				Register( 776, typeof( HolyMan.PurgeSpell ) );
				Register( 777, typeof( HolyMan.RebirthSpell ) );
				Register( 778, typeof( HolyMan.SacredBoonSpell ) );
				Register( 779, typeof( HolyMan.SanctifySpell ) );
				Register( 780, typeof( HolyMan.SeanceSpell ) );
				Register( 781, typeof( HolyMan.SmiteSpell ) );
				Register( 782, typeof( HolyMan.TouchOfLifeSpell ) );
				Register( 783, typeof( HolyMan.TrialByFireSpell ) );

				// Bard Songs
				Register( 351, typeof( Song.ArmysPaeonSong ) );
				Register( 352, typeof( Song.EnchantingEtudeSong ) );
				Register( 353, typeof( Song.EnergyCarolSong ) );
				Register( 354, typeof( Song.EnergyThrenodySong ) );
				Register( 355, typeof( Song.FireCarolSong ) );
				Register( 356, typeof( Song.FireThrenodySong ) );
				Register( 357, typeof( Song.FoeRequiemSong ) );
				Register( 358, typeof( Song.IceCarolSong ) );
				Register( 359, typeof( Song.IceThrenodySong ) );
				Register( 360, typeof( Song.KnightsMinneSong ) );
				Register( 361, typeof( Song.MagesBalladSong ) );
				Register( 362, typeof( Song.MagicFinaleSong ) );
				Register( 363, typeof( Song.PoisonCarolSong ) );
				Register( 364, typeof( Song.PoisonThrenodySong ) );
				Register( 365, typeof( Song.SheepfoeMamboSong ) );
				Register( 366, typeof( Song.SinewyEtudeSong ) );
			}
		}

		public static void Register( int spellID, Type type )
		{
			SpellRegistry.Register( spellID, type );
		}
	}
}