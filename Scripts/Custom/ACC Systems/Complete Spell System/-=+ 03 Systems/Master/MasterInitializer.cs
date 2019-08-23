using System;
using Server;
using Server.Spells;
using Server.ACC.CSS.Systems.Avatar;
using Server.ACC.CSS.Systems.Cleric;
using Server.ACC.CSS.Systems.Druid;
using Server.ACC.CSS.Systems.Ranger;
using Server.ACC.CSS.Systems.Rogue;
using Server.ACC.CSS.Systems.Bard;

namespace Server.ACC.CSS.Systems.Master
{
    public class MasterInitializer : BaseInitializer
    {
        public static void Configure()
        {
            Register(typeof(Spells.First.ClumsySpell), "Clumsy", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.First.CreateFoodSpell), "Create Food", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.First.FeeblemindSpell), "Feeblemind", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.First.HealSpell), "Heal", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.First.MagicArrowSpell), "Magic Arrow", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.First.NightSightSpell), "Night Sight", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.First.ReactiveArmorSpell), "Reactive Armor", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.First.WeakenSpell), "Weaken", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Second.AgilitySpell), "Agility", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Second.CunningSpell), "Cunning", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Second.CureSpell), "Cure", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Second.HarmSpell), "Harm", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Second.MagicTrapSpell), "Magic Trap", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Second.RemoveTrapSpell), "Remove Trap", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Second.ProtectionSpell), "Protection", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Second.StrengthSpell), "Strength", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Third.BlessSpell), "Bless", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Third.FireballSpell), "Fireball", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Third.MagicLockSpell), "Magic Lock", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Third.PoisonSpell), "Poison", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Third.TelekinesisSpell), "Telekenisis", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Third.TeleportSpell), "Teleport", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Third.UnlockSpell), "Unlock", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Third.WallOfStoneSpell), "Wall of Stone", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);

            Register(typeof(Spells.Fourth.ArchCureSpell), "Arch Cure", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Fourth.ArchProtectionSpell), "Arch Protection", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Fourth.CurseSpell), "Curse", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Fourth.FireFieldSpell), "Fire Field", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Fourth.GreaterHealSpell), "Greater Heal", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Fourth.LightningSpell), "Lightning", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Fourth.ManaDrainSpell), "Mana Drain", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Fourth.RecallSpell), "Recall", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);

            Register(typeof(Spells.Fifth.BladeSpiritsSpell), "Blade Spirits", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Fifth.DispelFieldSpell), "Dispel Field", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Fifth.IncognitoSpell), "Incognito", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Fifth.MagicReflectSpell), "Magic Reflect", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Fifth.MindBlastSpell), "Mind Blast", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Fifth.ParalyzeSpell), "Paralyze", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Fifth.PoisonFieldSpell), "Poison Field", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Fifth.SummonCreatureSpell), "Summon Creature", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);

            Register(typeof(Spells.Sixth.DispelSpell), "Dispel Field", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Sixth.EnergyBoltSpell), "Energy Bolt", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Sixth.ExplosionSpell), "Explosion", "sfdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Sixth.InvisibilitySpell), "Invisibility", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Sixth.MarkSpell), "Mark", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Sixth.MassCurseSpell), "Mass Curse", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Sixth.ParalyzeFieldSpell), "Paralyze Field", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Sixth.RevealSpell), "Reveal", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);

            Register(typeof(Spells.Seventh.ChainLightningSpell), "Chain Lightning", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Seventh.EnergyFieldSpell), "Energy Field", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Seventh.FlameStrikeSpell), "Flamestrike", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Seventh.GateTravelSpell), "Gate Travel", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Seventh.ManaVampireSpell), "Mana Vampire", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Seventh.MassDispelSpell), "Mass Dispel", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Seventh.MeteorSwarmSpell), "Meteor Swarm", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Seventh.PolymorphSpell), "Polymorph", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);

            Register(typeof(Spells.Eighth.EarthquakeSpell), "Earthquake", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Eighth.EnergyVortexSpell), "Energy Vortex", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Eighth.ResurrectionSpell), "Resurrection", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Eighth.AirElementalSpell), "Air Elemental", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Eighth.SummonDaemonSpell), "Summon Daemon", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Eighth.EarthElementalSpell), "Earth Elemental", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Eighth.FireElementalSpell), "Fire Elemental", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
            Register(typeof(Spells.Eighth.WaterElementalSpell), "Water Elemental", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);


            if (Core.AOS)
            {
                // Necromancy spells
                Register(typeof(Spells.Necromancy.AnimateDeadSpell), "Animate Dead", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                Register(typeof(Spells.Necromancy.BloodOathSpell), "Blood Oath", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                Register(typeof(Spells.Necromancy.CorpseSkinSpell), "Corpse Skin", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                Register(typeof(Spells.Necromancy.CurseWeaponSpell), "Curse Weapon", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                Register(typeof(Spells.Necromancy.EvilOmenSpell), "Evil Omen", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                Register(typeof(Spells.Necromancy.HorrificBeastSpell), "Horrific Beast", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                Register(typeof(Spells.Necromancy.LichFormSpell), "Lich Form", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                Register(typeof(Spells.Necromancy.MindRotSpell), "Mind Rot", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);

                Register(typeof(Spells.Necromancy.PainSpikeSpell), "Pain Spike", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                Register(typeof(Spells.Necromancy.PoisonStrikeSpell), "Posion Strike", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                Register(typeof(Spells.Necromancy.StrangleSpell), "Strangle", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                Register(typeof(Spells.Necromancy.SummonFamiliarSpell), "Summon Familiar", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                Register(typeof(Spells.Necromancy.VampiricEmbraceSpell), "Vampiric Embrace", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                Register(typeof(Spells.Necromancy.VengefulSpiritSpell), "Vengeful Spirit", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                Register(typeof(Spells.Necromancy.WitherSpell), "Wither", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                Register(typeof(Spells.Necromancy.WraithFormSpell), "Wraith Form", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);

                if (Core.SE)
                {
                    Register(typeof(Spells.Necromancy.ExorcismSpell), "Exorcism", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                    // Paladin abilities
                    Register(typeof(Spells.Chivalry.CleanseByFireSpell), "Cleanse by Fire", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                    Register(typeof(Spells.Chivalry.CloseWoundsSpell), "Close Wounds", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                    Register(typeof(Spells.Chivalry.ConsecrateWeaponSpell), "Consecrate Weapon", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                    Register(typeof(Spells.Chivalry.DispelEvilSpell), "Dispel Evil", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                    Register(typeof(Spells.Chivalry.DivineFurySpell), "Divine Fury", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                    Register(typeof(Spells.Chivalry.EnemyOfOneSpell), "Enemy of One", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                    Register(typeof(Spells.Chivalry.HolyLightSpell), "Holy Light", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                    Register(typeof(Spells.Chivalry.NobleSacrificeSpell), "Noble Sacrifice", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                    Register(typeof(Spells.Chivalry.RemoveCurseSpell), "Remove Curse", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                    Register(typeof(Spells.Chivalry.SacredJourneySpell), "Sacred Journey", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);



                    if (Core.SE)
                    {
                        // Samurai abilities
                        Register(typeof(Spells.Bushido.HonorableExecution), "Honorable Execution", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Bushido.Confidence), "Confidence", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Bushido.Evasion), "Evasion", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Bushido.CounterAttack), "Counter Attack", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Bushido.LightningStrike), "Lightning Strike", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Bushido.MomentumStrike), "Momentum Strike", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);

                        // Ninja abilities
                        Register(typeof(Spells.Ninjitsu.FocusAttack), "Focus Attack", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Ninjitsu.DeathStrike), "Death Strike", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Ninjitsu.AnimalForm), "Animal Form", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Ninjitsu.KiAttack), "Ki Attack", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Ninjitsu.SurpriseAttack), "Surprise Attack", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Ninjitsu.Backstab), "Backstab", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Ninjitsu.Shadowjump), "Shadow Jump", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Ninjitsu.MirrorImage), "Mirror Image", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);


                    }

                    if (Core.ML)
                    {
                        Register(typeof(Spells.Spellweaving.ArcaneCircleSpell), "Arcane Circle", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                //        Register(typeof(Spells.Spellweaving.ImmolatingWeaponSpell), "Immolating Weapon", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Spellweaving.AttuneWeaponSpell), "Attune Weapon", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Spellweaving.ThunderstormSpell), "Thunderstorm", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Spellweaving.NatureFurySpell), "Nature's Fury", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Spellweaving.SummonFeySpell), "Summon Fey", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Spellweaving.SummonFiendSpell), "Summon Fiend", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Spellweaving.ReaperFormSpell), "Reaper Form", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                      //  Register(typeof(Spells.Spellweaving.WildfireSpell), "Wildfire", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Spellweaving.EssenceOfWindSpell), "Essence of Wind", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                    //    Register(typeof(Spells.Spellweaving.DryadAllureSpell), "Dryad Allure", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Spellweaving.WordOfDeathSpell), "Word of Death", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Spellweaving.EtherealVoyageSpell), "Ethereal Voyage", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        Register(typeof(Spells.Spellweaving.GiftOfLifeSpell), "Gift of Life", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                    //    Register(typeof(Spells.Spellweaving.ArcaneEmpowermentSpell), "Arcane Empowerment", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);


                    }

                    if (Core.SA)
                    {

                     //   Register(typeof(Spells.Mysticism.NetherBoltSpell), "Netherbolt", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                       // Register(typeof(Spells.Mysticism.HealingStoneSpell), "Healing Stone", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        //Register(typeof(Spells.Mysticism.PurgeMagicSpell), "Purge Magic", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        //Register(typeof(Spells.Mysticism.EnchantSpell), "Enchant", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        //Register(typeof(Spells.Mysticism.SleepSpell), "Sleep", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        //Register(typeof(Spells.Mysticism.EagleStrikeSpell), "Eagle Strike", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        //Register(typeof(Spells.Mysticism.AnimatedWeaponSpell), "Animated Weapon", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        //Register(typeof(Spells.Mysticism.StoneFormSpell), "Stone Form", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        //Register(typeof(Spells.Mysticism.SpellTriggerSpell), "Spell Trigger", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        //Register(typeof(Spells.Mysticism.MassSleepSpell), "Mass Sleep", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        //Register(typeof(Spells.Mysticism.CleansingWindsSpell), "Cleansing Winds", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        //Register(typeof(Spells.Mysticism.BombardSpell), "Bombard", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        //Register(typeof(Spells.Mysticism.SpellPlagueSpell), "Spell Plague", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        //Register(typeof(Spells.Mysticism.HailStormSpell), "Hail Storm", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        //Register(typeof(Spells.Mysticism.NetherCycloneSpell), "Nether Cyclone", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);
                        //Register(typeof(Spells.Mysticism.RisingColossusSpell), "Rising Colossus", "sfsdfds", "sdfdsf", null, 2282, 9270, School.Master);

                        Register(typeof(AvatarHeavensGateSpell), "Heaven's Gate", "Allows the Paladin to open a heavenly portal to another location.", null, "Tithe: 30; Skill: 80; Mana: 40", 2258, 9300, School.Avatar);
                        Register(typeof(AvatarMarkOfGodsSpell), "Mark Of Gods", "Casts down a powerful bolt of lightning to mark a rune for the Palaidn", null, "Tithe: 10; Skill: 20; Mana: 10", 2269, 9300, School.Avatar);
                        Register(typeof(AvatarHeavenlyLightSpell), "Heavenly Light", "Heaven lights the Paladin's way.", null, "Tithe: 10; Skill: 20; Mana: 10", 2245, 9300, School.Avatar);

                        Register(typeof(BardArmysPaeonSpell), "Army's Paeon", "Regenerates your partys health slowly. [Area Effect]", null, "Mana: 15; Skill: 60", 2243, 3000, School.Bard);
                        Register(typeof(BardEnchantingEtudeSpell), "Enchanting Etude", "Raises the intelligence of your party. [Area Effect]", null, "Mana: 12; Skill: 70", 2242, 3000, School.Bard);
                        Register(typeof(BardEnergyCarolSpell), "Energy Carol", "Raises the energy resistance of your party. [Area Effect]", null, "Mana: 12; Skill: 30", 2289, 3000, School.Bard);
                        Register(typeof(BardEnergyThrenodySpell), "Energy Threnody", "Lowers the energy resistance of your target.", null, "Mana: 7;  Skill: 35", 2281, 3000, School.Bard);
                        Register(typeof(BardFireCarolSpell), "Fire Carol", "Raises the fire resistance of your party. [Area Effect]", null, "Mana: 12; Skill: 30", 2267, 3000, School.Bard);
                        Register(typeof(BardFireThrenodySpell), "Fire Threnody", "Lowers the fire resistance of your target.", null, "Mana: 7;  Skill: 35", 2257, 3000, School.Bard);
                        Register(typeof(BardFoeRequiemSpell), "Foe Requiem", "Damages your target with a burst of sonic energy.", null, "Mana: 18; Skill: 55", 2270, 3000, School.Bard);
                        Register(typeof(BardIceCarolSpell), "Ice Carol", "Raises the cold resistance of your party. [Area Effect]", null, "Mana: 12; Skill: 30", 2286, 3000, School.Bard);
                        Register(typeof(BardIceThrenodySpell), "Ice Threnody", "Lowers the ice resistance of your target.", null, "Mana: 7;  Skill: 35", 2269, 3000, School.Bard);
                        Register(typeof(BardKnightsMinneSpell), "Knight's Minne", "Raises the physical resist of your party. [Area Effect]", null, "Mana: 12; Skill: 45", 2273, 3000, School.Bard);
                        Register(typeof(BardMagesBalladSpell), "Mage's Ballad", "Regenerates your party's mana slowly. [Area Effect]", null, "Mana: 15; Skill: 65", 2292, 3000, School.Bard);
                        Register(typeof(BardMagicFinaleSpell), "Magic Finale", "Dispels all summoned creatures around you. [Area Effect]", null, "Mana: 15; Skill: 80", 2280, 3000, School.Bard);
                        Register(typeof(BardPoisonCarolSpell), "Poison Carol", "Raises the poison resistance of your party.  [Area Effect]", null, "Mana: 12; Skill: 30", 2285, 3000, School.Bard);
                        Register(typeof(BardPoisonThrenodySpell), "Poison Threnody", "Lowers the poison resistance of your target.", null, "Mana: 7;  Skill: 35", 20488, 3000, School.Bard);
                        Register(typeof(BardSheepfoeMamboSpell), "Sheepfoe Mambo", "Raises the dexterity of your party. [Area Effect]", null, "Mana: 12; Skill: 70", 2248, 3000, School.Bard);
                        Register(typeof(BardSinewyEtudeSpell), "Sinewy Etude", "Raises the strength of your party. [Area Effect]", null, "Mana: 12; Skill: 70", 20741, 3000, School.Bard);

                        Register(typeof(ClericAngelicFaithSpell), "Angelic Faith", "The caster calls upon the divine powers of the heavens to transform himself into a holy angel.  The caster gains better regeneration rates and increased stats and skills.", null, "Mana: 50; Skill: 80; Tithing: 100", 2295, 3500, School.Cleric);
                        Register(typeof(ClericBanishEvilSpell), "Banish Evil", "The caster calls forth a divine fire to banish his undead or demonic foe from the earth.", null, "Mana: 40; Skill: 60; Tithing: 30", 20739, 3500, School.Cleric);
                        Register(typeof(ClericDampenSpiritSpell), "Dampen Spirit", "The caster's enemy is slowly drained of his stamina, greatly hindering their ability to fight in combat or flee.", null, "Mana: 11; Skill: 35; Tithing: 15", 2270, 3500, School.Cleric);
                        Register(typeof(ClericDivineFocusSpell), "Divine Focus", "The caster's mind focuses on his divine faith increasing the effect of his prayers.  However, the caster becomes mentally fatigued much faster.", null, "Mana: 4;  Skill: 35; Tithing: 15", 2276, 3500, School.Cleric);
                        Register(typeof(ClericHammerOfFaithSpell), "Hammer Of Faith", "Summons forth a divine hammer of pure energy blessed with the ability to vanquish undead foes with greater efficiency.", null, "Mana: 14; Skill: 40; Tithing: 20", 20741, 3500, School.Cleric);
                        Register(typeof(ClericPurgeSpell), "Purge", "The target is cured of all poisons and has all negative stat curses removed.", null, "Mana: 6;  Skill: 10; Tithing: 5", 20744, 3500, School.Cleric);
                        Register(typeof(ClericRestorationSpell), "Restoration", "The caster's target is resurrected and fully healed and refreshed.", null, "Mana: 50; Skill: 50; Tithing: 40", 2298, 3500, School.Cleric);
                        Register(typeof(ClericSacredBoonSpell), "Sacred Boon", "The caster's target is surrounded by a divine wind that heals small amounts of lost life over time.", null, "Mana: 11; Skill: 25; Tithing: 15", 20742, 3500, School.Cleric);
                        Register(typeof(ClericSacrificeSpell), "Sacrifice", "The caster sacrifices himself for his allies. Whenever damaged, all party members are healed a small percent of the damage dealt. The caster still takes damage.", null, "Mana: 4;  Skill: 5;  Tithing: 5", 20743, 3500, School.Cleric);
                        Register(typeof(ClericSmiteSpell), "Smite", "The caster calls to the heavens to send a deadly bolt of lightning to strike down his opponent.", null, "Mana: 50; Skill: 80; Tithing: 60", 2269, 3500, School.Cleric);
                        Register(typeof(ClericTouchOfLifeSpell), "Touch Of Life", "The caster's target is healed by the heavens for a significant amount.", null, "Mana: 9;  Skill: 30; Tithing: 10", 2243, 3500, School.Cleric);
                        Register(typeof(ClericTrialByFireSpell), "Trial By Fire", "The caster is surrounded by a divine flame that damages the caster's enemy when hit by a weapon.", null, "Mana: 9;  Skill: 45; Tithing: 25", 20736, 3500, School.Cleric);

                        Register(typeof(DruidLeafWhirlwindSpell), "Leaf Whirlwind", "A gust of wind blows picking up magic leaves that memorize where they have come from, marking a rune for the caster.", "Spring Water; Petrafied Wood; Destroying Angel", "Mana: 25; Skill: 50", 2271, 5120, School.Druid);
                        Register(typeof(DruidHollowReedSpell), "Hollow Reed", "Increases both the Strength and the Intelligence of the Druid.", "Bloodmoss; Mandrake Root; Nightshade", "Mana: 30; Skill: 30", 2255, 5120, School.Druid);
                        Register(typeof(DruidPackOfBeastSpell), "Pack of Beasts", "Summons a pack of beasts to fight for the Druid.  Spell length increases with skill.", "Bloodmoss; Black Pearl; Petrafied Wood", "Mana: 45; Skill: 40", 20491, 5120, School.Druid);
                        Register(typeof(DruidSpringOfLifeSpell), "Spring of Life", "Creates a magical spring that heals the Druid and their party.", "Spring Water", "Mana: 40; Skill: 40", 2268, 5120, School.Druid);
                        Register(typeof(DruidGraspingRootsSpell), "Grasping Roots", "Summons roots from the ground to entangle a single target.", "Spring Water; Bloodmoss; Spider's Silk", "Mana: 40; Skill: 40", 2293, 5120, School.Druid);
                        Register(typeof(DruidBlendWithForestSpell), "Blend With Forest", "The Druid blends seamlessly with the background, becoming invisible to their foes.", "Bloodmoss; Nightshade", "Mana: 60; Skill: 75", 2249, 5120, School.Druid);
                        Register(typeof(DruidSwarmOfInsectsSpell), "Swarm of Instects", "Summons a swarm of insects that bite and sting the Druid's enemies.", "Garlic; Nightshade; DestroyingAngel", "Mana: 70; Skill: 85", 2272, 5120, School.Druid);
                        Register(typeof(DruidVolcanicEruptionSpell), "Volcanic Eruption", "A blast of molten lava bursts from the ground, hitting every enemy nearby.", "Sulfurous Ash; Destroying Angel", "Mana: 85; Skill: 98", 2296, 5120, School.Druid);
                        Register(typeof(DruidFamiliarSpell), "Summon Familiar", "Summons a choice of diffrent familiars that can aid the druid.", "Mandrake Root; Spring Water; Petrafied Wood", "Mana: 17; Skill: 30", 2295, 5120, School.Druid);
                        Register(typeof(DruidStoneCircleSpell), "Stone Circle", "Forms an impassable circle of stones, ideal for trapping enemies.", "Black Pearl; Ginseng; Spring Water", "Mana: 45; Skill: 60", 2263, 5120, School.Druid);
                        Register(typeof(DruidEnchantedGroveSpell), "Enchanted Grove", "Creates a grove of trees to grow around the Druid, restoring vitality.", "Mandrake Root; Petrafied Wood; Spring Water", "Mana: 60; Skill: 95", 2280, 5120, School.Druid);
                        Register(typeof(DruidLureStoneSpell), "Lure Stone", "Creates a magical stone that calls all nearby animals to it.", "Black Pearl; Spring Water", "Mana: 30; Skill: 15", 2294, 5120, School.Druid);
                        Register(typeof(DruidNaturesPassageSpell), "Nature's Passage", "The Druid is turned into flower petals and carried on the wind to their destination.", "Black Pearl; Bloodmoss; Mandrake Root", "Mana: 10; Skill: 15", 2297, 5120, School.Druid);
                        Register(typeof(DruidMushroomGatewaySpell), "Mushroom Gateway", "A magical circle of mushrooms opens, allowing the Druid to step through it to another location.", "Black Pearl; Spring Water; Mandrake Root", "Mana: 40; Skill: 70", 2291, 5120, School.Druid);
                        Register(typeof(DruidRestorativeSoilSpell), "Restorative Soil", "Saturates a patch of land with power, causing life giving mud to seep through.", "Garlic; Ginseng; Spring Water", "Mana: 55; Skill: 89", 2298, 5120, School.Druid);
                        Register(typeof(DruidShieldOfEarthSpell), "Shield of Earth", "A quick-growning wall of foliage springs up at the bidding of the Druid.", "Ginseng; Spring Water", "Mana: 15; Skill: 20", 2254, 5120, School.Druid);

                        Register(typeof(RangerHuntersAimSpell), "Hunter's Aim", "Increases the Rangers archery, and tactics for a short period of time.", "Nightshade; Spring Water; Bloodmoss", "Mana: 25; Skill: 50", 2244, 5054, School.Ranger);
                        Register(typeof(RangerPhoenixFlightSpell), "Phoenix Flight", "Calls Forth a Phoenix who will carry you to the location of your choice.", "Sulfurous Ash; Petrafied Wood", "Mana: 10; Skill: 15", 20736, 5054, School.Ranger);
                        Register(typeof(RangerFamiliarSpell), "Animal Companion", "The Ranger summons an animal companion (baised on skill level) to aid him in his quests.", "Destroying Angel; Spring Water; Petrafied Wood", "Mana: 17; Skill: 30", 20491, 5054, School.Ranger);
                        Register(typeof(RangerFireBowSpell), "Fire Bow", "The Ranger uses his knowlage of archery and hunting, to craft a temparary fire elemental bow, that last for a short duration.", "Kindling; Sulfurous Ash", "Mana: 30; Skill: 85", 2257, 5054, School.Ranger);
                        Register(typeof(RangerIceBowSpell), "Ice Bow", "The Ranger uses his knowlage of archery and hunting, to craft a temparary ice elemental bow, that last for a short duration.", "Kindling; Spring Water", "Mana: 30; Skill: 85", 21001, 5054, School.Ranger);
                        Register(typeof(RangerLightningBowSpell), "Lightning Bow", "The Ranger uses his knowlage of archery and hunting, to craft a temparary lightning elemental bow, that last for a short duration.", "Kindling; Black Pearl", "Mana: 30; Skill: 90", 2281, 5054, School.Ranger);
                        Register(typeof(RangerNoxBowSpell), "Nox Bow", "The Ranger uses his knowlage of archery and hunting, to craft a temparary poison elemental bow, that last for a short duration.", "Kindling; Nightshade", "Mana: 30; Skill: 95", 20488, 5054, School.Ranger);
                        Register(typeof(RangerSummonMountSpell), "Call Mount", "The Ranger calls to the Wilds, summoning a speedy mount to his side.", "Spring Water; Black Pearl; Sulfurous Ash", "Mana: 15; Skill: 30", 20745, 5054, School.Ranger);

                        Register(typeof(RogueFalseCoinSpell), "False Coin", "The Rogue produces false gold with the trick of the hand.", "Sulfurous Ash; Nightshade", null, 20481, 5100, School.Rogue);
                        Register(typeof(RogueCharmSpell), "Charm", "The Rogue mesmerize's a target with his evil eyes.", "Black Pearl; Nightshade; Spider's Silk", null, 21282, 5100, School.Rogue);
                        Register(typeof(RogueSlyFoxSpell), "Sly Fox", "The Rogue changes shape into a stealthly Sly Fox.", "Petrafied Wood; Nox Crystal; Nightshade", null, 20491, 5100, School.Rogue);
                        Register(typeof(RogueShadowSpell), "Shadow", "The Rogue slips into the shadows.", "Spider's Silk; Daemon Blood; Black Pearl", null, 21003, 5100, School.Rogue);
                        Register(typeof(RogueIntimidationSpell), "Intimidation", "The Rogue begins to look angry and mean at the loss of his skills.", null, null, 20485, 5100, School.Rogue);
                    }
                }

            }
        }
    }
}
