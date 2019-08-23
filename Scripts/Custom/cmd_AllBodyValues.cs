/*Scripted by  _____         
*	  		   \_   \___ ___ 
*			    / /\/ __/ _ \
*		     /\/ /_| (_|  __/
*			 \____/ \___\___|
*               12/30/18   
*               [AllBodyValues   in a large clear flat area
*/
using Server.Mobiles;
namespace Server.Commands
{
    public class AllBodyValues
    {
        public static void Initialize()
        {
            CommandSystem.Register("AllBodyValues", AccessLevel.Counselor, new CommandEventHandler(AllBodyValues_OnCommand));
        }
        [Usage("AllBodyValues")]
        [Description("Adds a mobile for every bodyvalue in the game")]
        public static void AllBodyValues_OnCommand(CommandEventArgs e)
        {
            #region info
            int[] m_BodyValues = 
            {
                1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,
                51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,
                98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,116,117,118,119,120,121,122,123,124,125,126,127,128,129,130,131,132,133,
                134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162,163,164,165,166,167,169,
                172,173,174,175,176,177,178,179,180,181,182,183,184,185,186,187,188,189,190,191,192,193,194,195,196,197,198,199,200,201,202,203,204,205,206,
                207,208,209,210,211,212,213,214,215,216,217,218,219,220,221,223,225,226,228,231,232,233,234,237,238,240,241,242,243,244,245,246,247,248,249,
                250,251,252,253,254,255,256,257,258,259,260,261,262,263,264,265,266,267,270,271,272,273,275,276,277,279,280,281,282,283,284,285,287,290,291,
                292,293,300,301,302,303,304,305,306,307,308,309,310,311,312,313,314,315,316,317,318,319,334,400,401,402,403,432,573,574,605,606,607,608,666,
                667,668,669,689,694,695,704,705,713,714,715,716,717,718,719,720,721,722,723,724,725,726,727,728,729,730,732,733,734,735,736,737,738,739,740,
                741,742,743,744,745,746,747,748,749,750,751,752,753,754,755,756,757,758,763,764,765,766,767,767,770,771,772,773,774,775,776,777,778,779,780,
                781,782,783,784,785,787,788,789,790,791,792,793,794,796,797,798,799,804,805,806,807,808,829,830,831,832,970,987,990,991,994,999,1026,1068,
                1069,1070,1071,1244,1245,1246,1247,1248,1249,1250,1251,1252,1253,1254,1255,1285,1286,1287,1288,1289,1290,1291,1292,1293,1294,1308,1309,1400,
                1401,1402,1403,1404,1405,1406,1407,1408,1409,1410,1415,1416,1417,1418,1419,1420,1421,1422,1423,1424,1425,1426,1427,1428,1431,1432,1433
            };
            string[] m_Names =
            {
                "Ogre","Ettin","Zombie","Gargoyle","Eagle","Bird","OrcCaptain","WhippingVine","Demon","DemonNew","DreadSpider","DragonBrown","AirElemental","EarthElemental",
                "FireElemental","WaterElemental","Orc","Ettinw/Club","DreadSpider","FrostSpider","GiantSnake","Gazer","WolfGrey","Lich","WolfLightGrey","Wraith","WolfDarkGrey",
                "GiantSpider","Gorilla","Harpy","Headless","Lizardman","WolfGrey","LizardmanW/Spear","Lizardmanw/mace","WolfArtic","BlackgateDemon","Mongbat","Balron","orcw/club",
                "Ratman","IceFiend","Ratmanw/mace","Ratmanw/sword","AncientWyrm","Reaper","Scorpoion","WhiteWyrm","Skeleton","Slime","Snake","TrollW/axe","Troll","Trollarticw/axe",
                "Skeletonw/axe","SkeletalKnight","Wisp","DragonRed","DrakeBrown","DrakeRed","Wyvern","PantherLight","PantherDark","PantherDark","WhippingVineHuedLime","StoneGargoyle",
                "Gazer","Gazer","TerathanWarrior","TerathanDrone","TerathanMatriarch","HarpyStoneHued","Imp","Cyclops","Titan","Kraken&Leviathin","LichHuedGrey","Lich","GiantToad",
                "GiantFrog","Lich","Ogre","Ogre","OphidianJusticar","Ophidianavenger","OphidianMatriarch","Goat","IceSerpent","LavaSerpent","GiantSerpentGrey","GiantSerpentGrey",
                "GiantSerpentLightGrey","Frostooze","Turkey","Frostooze","HellHound","HellHoundLight","WolfGreyDark","WolfArtic","Centaur","DemonUnknownArmored","SerpentineDragon",
                "SkeletalDragon","DragonDarkBluishGrey","EarthElementalHued","EarthElementalHued","EarthElementalHued","EarthElementalHued","EarthElementalHued","EarthElementalHued",
                "EarthElementalHued","EarthElementalHued","Nightmare1","Nightmare2","HolySteed","FactionHorsePurple","FactionHorseLightBlue","FactionHorseRed","FactionHorseLightGreen",
                "Unicorn","LatticeSeeker","Soulbinder1","Soulbinder2","Soulbinder3","Hellcat","Pixie","WhippingVineHuedRed","BlazingGargoyle","Efreet","kririn","Aligator","LavaLizard",
                "ArticOgre","OphidianZealot","OphidianAvenger","OrcCaptain","OrcCaptain","Orc","HumanmaleFlesh","RatmanBlueVestw/sword","RatmanRedVestw/sword","Seahorse","SeaSerpentDarkWaterline",
                "Harrower&Shadowlords","SkeletalKnight","SkeletalMage","Succubus","SeaSerpentBrightWaterline","Dolphin","TerathanAvenger","Wraith","Mummy","RottingZombie","Turkey",
                "GiantBlackWidow","AcidElemental","BloodElementalDark","BloodElementalLight","IceElemental","PoisonElemental","SnowElemental","EnergyVortex","ShadowWisp","EarthElementalHued",
                "BrownBear","BlueBeetle","Richtor","Mephitis","Semidar","LordOaks","Silvani","Nightmare3","Nightmare4Longhair","Nightmare5Longhair","WhiteWyrm","OrcScout","OrcBomber",
                "HumanMale","HumanFemale","HumanMale","HumanFemale","Ridgeback","TribalRidgeback","OrcBrute","FireSteed","Kirin","Unicorn","Ridgeback","SwampDragon","BlueBeetle",
                "KazeKomono","ChaosVariantDragon","OrderVariantDragon","Rai-Ju","HorseTan","Cat","Aligator","Pig","HorseBrown","Rabbit","lavaLizard","Sheep","Chicken","Goat","DesertOstard",
                "BrownBear","GrizzlyBear","PolarBear","PantherLight","GiantRat","CowBlack&White","Dog","FrenziedOstardArmored","FreenziedOstardNoArmor","Llama","Walrus","SheepShorn",
                "WolfBrown","HorseWhite","HorseTan","CowBrown&White","BullLightBrown","BullDarkBrown&White","Stag","Deer","rat","Kappa","Oni","DeathwatchBeetle","Hiryu","RuneBeetle",
                "YomotsuWarrior","BakeKitsune","FanDancer","Gamman","SeradotheAwakened","TsukiWOlf","RevenantLion","LadyoftheSnow","YomotsuPriest","Crane","YomotsuElder","ChiefParoxysmus",
                "DreadHorn","LadyMelisande","MonstrousInterredGrizzle","ShimmeringEffusion","ShimmeringEffusion2","MinatuarFemale","MinatuarMale","Changeling","Hydra","Dryad","Troglodyte",
                "UnknownCreatureNew","Satyr","FetidEssence","FetidEssence","Reptalon","CuSidhe","Squirrel","Ferret","MinatuarArmored","MinatuardW/Hammer","ParrotPerched","UnknownPerchedBird",
                "ChargeoftheFallen","ReaperFormSpellweaving","Bloodworm","Pig","PackHorse","packLlama","Vollum","CrystalElemental","TreeFellow","SkitteringHopper","DevourerofSouls",
                "FleshGolem","GoreFiend","Impaler","Gibberling","DoneDemon","PatchworkSkeleton","WailingBanshee","ShadowKnight","AbyssmalHorror","DarknightCreeper","Ravager","FleshRenderer",
                "WandereroftheVoid","VampireBat","DarkFather","moundofMaggots","GrayGoblin","HumanMale","HumanFemale","GM","GM","RidableBoura","DeathVortex","BladeSpirits","ElfMale",
                "ElfFemale","GM","GM","GargoyleMale","GargoyleFemale","GM","GM","Timelord","GargoyleMaleDeath","GargoyleFemaleDeath","ShadowlordsNew","StoneFormMysticism","AbyssalInfernal",
                "IronBeetle","LowlandBoura","ChickenLizard","ClockworkScorpion","FairyDragon","UnkownWolfCreatureNew","LavaElemental","MaddeningHorror","PutridUndeadGargoyle","GreenGoblin",
                "Gremlin","Homunculus","Kepetch","KepetchAmbusher","Medusa","paralithode","Raptor","Rotworm","Skree","ToxicSlith","NavreyNight-Eyes","WolfSpider","TrapdoorSpider",
                "FireAnt","LeatherWolf","DreamWraith","SlasherofViels","Charybdis","TentaclesofOsiredontheScalisEnforcer","BrightWhiteHumanMale","BirghtWhiteHumanFemale","HorrificBeastNecromancyForm1",
                "WailingBansheeNecroFemaleForm","WraithNecroMaleForm","LichformNecro","HumanMale","HumanFemale","Golem","EnslavedGargoyle","GargoyleEnforcer","gargoyleDestroyer",
                "ExodusOverseer","ExodusMinion","GargoleColorGlitchedInDirections","ExodusMinionHuge","JukaWarrior","JukaMage","JukaLord","Betrayer","BlackthornJuggernaut","MeerMage",
                "MeerWarrior","MeerEternal","MeerCaptain","Dawn","PlagueBeast","HordeMinionSmall","Doppleganger","GazerLarva","Bogling","BogThing","RedSolenWorker","RedSolenWarrior",
                "RedSolenQUeen","ArcaneDemon","HorrificBeastMoloch","AntLion","Sphinx","Quagmire","kazekomono","BlueBeetle","ChaosDemon","SkeletalSteed","SwampDragonBarded","HordeMinionLarge",
                "Richtor","AncientWyrm","SwampDragonBarded","RedSolenQueen","RedSolenWorker","RedSolenWarrior","RedSolenQueen","redSolenQueen","RisingColossus","Prime-EvilLich",
                "Parrot(Tropical)","PheonixNew","Deathshroud","GM","LordBritish","LordBlackthorn","Dupri","MulticoloredHordeDemon","UberTurkey","OseridanTheScalisEnforcer","AncientHellhound",
                "Werewolf","unknownDemonLord","CharbydisNew?","GlitchyScalisTentacles","KillerPumpkinDemonVariant","KillerPumpkinJapeneseDemonMaskVariant","Exodus","RewardRobeMale",
                "RewardRobeFemale","GargoyleRewardRobeMale","GargoyleRewardRobeFemale","KingBlackthorn(SeemsunfinishedalignmentsareoffforUpanddownwalking)","TigerLight","TigerDark","GargoylePet-Dimetrosaur",
                "ReptileBird-Gallusaurus","FairyDragon-Archaeosaurus","DragonTurtleBoss","Najasaurus","Allosaurus","Saurosaurus","Anchisaur","Myrmidex","BabyDragonTurtle","Gorilla_Giant",
                "Baby_Tiger","Dino_Trex","Turanchula_Mount","Myrmidex_Drone","Myrmidex_Warrior","Myrmidex_Queen","DrSpector","Golem_Aztec","Horse_Unicorn_RB","Horse_Palomino","Dragon_Hildebrandt(MISSINGANIMATION)",
                "Canine_Windrunner","Dino_Triceratops","Tiger_Sabertooth","Dragon_Small_Platinum","Dragon_Ele_Platinum","Dragon_Small_Crimson","Dragon_Ele_Crimson","Dragon_Small_Stygian","Dragon_Ele_Stygian",
                "Fox_Small","Beetle_Rhino","Goat_Necromancer","Lion","Titan_Water_Tentacle","JackintheBox","Titan_Earth_Head","Titan_Air_Whirlwind","Titan_Fire_Demon"
            };
            
            #endregion
            Mobile from = e.Mobile;
            Point3D loc = from.Location;
            int startY = loc.Y;
            int startX = loc.X;
            int curX = startX, curY = startY;
            int curTickY = 0;
            int spacing = 3;

            for (int i = 0; i < m_BodyValues.Length; i++)
            {
                BodyValue mob = new BodyValue();
                mob.BodyValue = m_BodyValues[i];
                mob.Name = m_Names[i];
                Point3D tempP = new Point3D(curX, curY, from.Z);
                mob.MoveToWorld(tempP, from.Map);
                curY += spacing; curTickY += 1;
                if (curTickY > m_BodyValues.Length / 25) { curTickY = 0; curY = startY; curX += spacing; }
            }
        }
    }
    [CorpseName("corpse")]
    public class BodyValue : BaseCreature
    {
        [Constructable]
        public BodyValue()
            : base(AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4)
        {
            Body = 0xD9;
            Hue = 0;
            BaseSoundID = 0;
            Blessed = true;
            CantWalk = true;
        }
        public BodyValue(Serial serial)
            : base(serial)
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
}
