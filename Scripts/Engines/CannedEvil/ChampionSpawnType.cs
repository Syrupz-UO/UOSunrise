using System;
using Server;
using Server.Mobiles;

namespace Server.Engines.CannedEvil
{
	public enum ChampionSpawnType
	{
		Abyss,
		Arachnid,
		ColdBlood,
		ForestLord,
		VerminHorde,
		UnholyTerror,
		SleepingDragon,
		Glade,
		Pestilence,
		Crafter,
		WinterSolstice,
		Brimstone
	}

	public class ChampionSpawnInfo
	{
		private string m_Name;
		private Type m_Champion;
		private Type[][] m_SpawnTypes;
		private string[] m_LevelNames;

		public string Name { get { return m_Name; } }
		public Type Champion { get { return m_Champion; } }
		public Type[][] SpawnTypes { get { return m_SpawnTypes; } }
		public string[] LevelNames { get { return m_LevelNames; } }

		public ChampionSpawnInfo( string name, Type champion, string[] levelNames, Type[][] spawnTypes )
		{
			m_Name = name;
			m_Champion = champion;
			m_LevelNames = levelNames;
			m_SpawnTypes = spawnTypes;
		}

		public static ChampionSpawnInfo[] Table{ get { return m_Table; } }

		private static readonly ChampionSpawnInfo[] m_Table = new ChampionSpawnInfo[]
			{
				new ChampionSpawnInfo( "Abyss", typeof( Semidar ), new string[]{ "Foe", "Assassin", "Conqueror" }, new Type[][]	// Abyss
				{																											// Abyss
					new Type[]{ typeof( AGreaterMongbat ), typeof( AImp ) },													// Level 1
					new Type[]{ typeof( AGargoyle ), typeof( AHarpy ) },														// Level 2
					new Type[]{ typeof( AFireGargoyle ), typeof( AStoneGargoyle ) },											// Level 3
					new Type[]{ typeof( ADaemon ), typeof( ASuccubus ) }														// Level 4
				} ),
				new ChampionSpawnInfo( "Arachnid", typeof( Mephitis ), new string[]{ "Bane", "Killer", "Vanquisher" }, new Type[][]	// Arachnid
				{																											// Arachnid
					new Type[]{ typeof( AScorpion ), typeof( AGiantSpider ) },												// Level 1
					new Type[]{ typeof( ATerathanDrone ), typeof( ATerathanWarrior ) },										// Level 2
					new Type[]{ typeof( ADreadSpider ), typeof( ATerathanMatriarch ) },										// Level 3
					new Type[]{ typeof( APoisonElemental ), typeof( ATerathanAvenger ) }										// Level 4
				} ),
				new ChampionSpawnInfo( "Cold Blood", typeof( Rikktor ), new string[]{ "Blight", "Slayer", "Destroyer" }, new Type[][]	// Cold Blood
				{																											// Cold Blood
					new Type[]{ typeof( ALizardman ), typeof( ASnake ) },														// Level 1
					new Type[]{ typeof( ALavaLizard ), typeof( AOphidianWarrior ) },											// Level 2
					new Type[]{ typeof( ADrake ), typeof( AOphidianArchmage ) },												// Level 3
					new Type[]{ typeof( ADragon ), typeof( AOphidianKnight ) }												// Level 4
				} ),
				new ChampionSpawnInfo( "Forest Lord", typeof( LordOaks ), new string[]{ "Enemy", "Curse", "Slaughterer" }, new Type[][]	// Forest Lord
				{																											// Forest Lord
					new Type[]{ typeof( APixie ), typeof( ShadowWisp ) },													// Level 1
					new Type[]{ typeof( AKirin ), typeof( AWisp ) },															// Level 2
					new Type[]{ typeof( ACentaur ), typeof( AUnicorn ) },														// Level 3
					new Type[]{ typeof( AEtherealWarrior ), typeof( ASerpentineDragon ) }										// Level 4
				} ),
				new ChampionSpawnInfo( "Vermin Horde", typeof( Barracoon ), new string[]{ "Adversary", "Subjugator", "Eradicator" }, new Type[][]	// Vermin Horde
				{																											// Vermin Horde
					new Type[]{ typeof( AGiantRat ), typeof( ASlime ) },														// Level 1
					new Type[]{ typeof( ADireWolf ), typeof( ARatman ) },														// Level 2
					new Type[]{ typeof( HellHound ), typeof( ARatmanMage ) },												// Level 3
					new Type[]{ typeof( ARatmanArcher ), typeof( ASilverSerpent ) }											// Level 4
				} ),
				new ChampionSpawnInfo( "Unholy Terror", typeof( Neira ), new string[]{ "Scourge", "Punisher", "Nemesis" }, new Type[][]	// Unholy Terror
				{																											// Unholy Terror
					(Core.AOS ? 
					new Type[]{ typeof( ABogle ), typeof( AGhoul ), typeof( AShade ), typeof( ASpectre ), typeof( AWraith ) }	// Level 1 (Pre-AoS)
					: new Type[]{ typeof( AGhoul ), typeof( AShade ), typeof( ASpectre ), typeof( AWraith ) } ),				// Level 1

					new Type[]{ typeof( ABoneMagi ), typeof( AMummy ), typeof( ASkeletalMage ) },								// Level 2
					new Type[]{ typeof( ABoneKnight ), typeof( ALich ), typeof( ASkeletalKnight ) },							// Level 3
					new Type[]{ typeof( ALichLord ), typeof( ARottingCorpse ) }												// Level 4
				} ),
				new ChampionSpawnInfo( "Sleeping Dragon", typeof( Serado ), new string[]{ "Rival", "Challenger", "Antagonist" } , new Type[][]
				{																											// Unholy Terror
					new Type[]{ typeof( ADeathwatchBeetleHatchling ), typeof( ALizardman ) },
					new Type[]{ typeof( ADeathwatchBeetle ), typeof( AKappa ) },
					new Type[]{ typeof( ALesserHiryu ), typeof( ARevenantLion ) },
					new Type[]{ typeof( AHiryu ), typeof( AOni ) }
				} ),
				new ChampionSpawnInfo( "Glade", typeof( Twaulo ), new string[]{ "Banisher", "Enforcer", "Eradicator" } , new Type[][]
				{																											// Glade
					new Type[]{ typeof( APixie ), typeof( ShadowWisp ) },
					new Type[]{ typeof( ACentaur ), typeof( AMLDryad ) },
					new Type[]{ typeof( ASatyr ), typeof( ACuSidhe ) },
					new Type[]{ typeof( FerelTreefellow ), typeof( ARagingGrizzlyBear ) }
				} ),
				new ChampionSpawnInfo( "The Corrupt", typeof( Ilhenir ), new string[]{ "Cleanser", "Expunger", "Depurator" } , new Type[][]
				{																											// Unholy Terror
					new Type[]{ typeof( APlagueSpawn ), typeof( ABogling ) },
					new Type[]{ typeof( APlagueBeast ), typeof( ABogThing ) },
					new Type[]{ typeof( APlagueBeastLord ), typeof( AInterredGrizzle ) },
					new Type[]{ typeof( AFetidEssence ), typeof( APestilentBandage ) },
					} )	,	
				new ChampionSpawnInfo( "Crafter", typeof( MasterOfTheArts), new string[]{ "Eraser", "Destructor", "Exploder"}, new Type[][]	// Crafter
				{																											// Crafter
					new Type[]{ typeof( CarpenterAutomaton ), typeof( BabyBellhop ) },										// Level 1
					new Type[]{ typeof( TailorAutomaton ), typeof( Bellhop ) },												// Level 2
					new Type[]{ typeof( BlacksmithAutomaton ), typeof( StrongBellhop ) },									// Level 3
					new Type[]{ typeof( FletcherAutomaton ), typeof( BurntOne ) }											// Level 4
			
				} ),
				
					new ChampionSpawnInfo("WinterSolstice", typeof(Hodur), new string[] { "Cleanser", "Expunger", "Depurator" }, new Type[][]
            { // WinterSolstice
                new Type[] { typeof(AGiantIceWorm), typeof(AIcyMyrmidex) },
                new Type[] { typeof(AIceStorm), typeof(AIceGuardians) },
                new Type[] { typeof(AIceStorm), typeof(ASnowDrake) },
                new Type[] { typeof(AIceDaemon), typeof(AIceGiant) }
            }),
			new ChampionSpawnInfo("BrimStone", typeof(FireSpirit), new string[] { "Cleanser", "Expunger", "Depurator" }, new Type[][]
            { // WinterSolstice
                new Type[] { typeof(AFireStorm), typeof(ASalamanderOfFire) },
                new Type[] { typeof(AFuerety), typeof(AFireDemon) },
                new Type[] { typeof(ABurningEmberSpider), typeof(AFieryDragon) },
                new Type[] { typeof(ABalroq), typeof(AFireSpiritMinion) }
            })
			};

		public static ChampionSpawnInfo GetInfo( ChampionSpawnType type )
		{
			int v = (int)type;

			if( v < 0 || v >= m_Table.Length )
				v = 0;

			return m_Table[v];
		}
	}
}