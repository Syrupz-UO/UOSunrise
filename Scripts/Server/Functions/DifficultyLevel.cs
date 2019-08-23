using System;
using Server;
using System.Collections;
using Server.Misc;
using Server.Network;
using Server.Commands;
using Server.Commands.Generic;
using Server.Mobiles;
using Server.Accounting;
using Server.Regions;
using Server.Targeting;
using System.Collections.Generic;
using Server.Items;
using Server.Spells.Fifth;

namespace Server.Misc
{
    class DifficultyLevel
    {
		public static int GetDifficultyLevel( Point3D loc, Map map )
		{
			int Heat = -5;

			Region reg = Region.Find( loc, map );

			if ( map == Map.Felucca )
			{
				if ( reg.IsPartOf( "the Lodoria Sewers" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Lizardman Cave" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "the Ratmen Lair" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "the Crypt" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "Dungeon Wrong" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "the Volcanic Cave" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "Terathan Keep" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "Dungeon Shame" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "the Ice Fiend Lair" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "the Frozen Hells" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "Dungeon Hythloth" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Mind Flayer City" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "the City of Embers" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "Dungeon Destard" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "Dungeon Despise" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "Dungeon Deceit" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "Dungeon Covetous" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "the Lodoria Catacombs" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "the Halls of Undermountain" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "the Vault of the Black Knight" ) ){ Heat = 3; } // -- IN SERPENT ISLAND
				else if ( reg.IsPartOf( "the Crypts of Dracula" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "the Castle of Dracula" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "Stonegate Castle" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "the Ancient Elven Mine" ) ){ Heat = 3; }

				else if ( reg.IsPartOf( "Morgaelin's Inferno" ) ){ Heat = 4; }
				else if ( reg.IsPartOf( "the Zealan Tombs" ) ){ Heat = 4; }
				else if ( reg.IsPartOf( "the Temple of Osirus" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "Argentrock Castle" ) ){ Heat = 4; }
				else if ( reg.IsPartOf( "the Daemon's Crag" ) ){ Heat = 4; }
				else if ( reg.IsPartOf( "the Hall of the Mountain King" ) ){ Heat = 4; }
				else if ( reg.IsPartOf( "the Depths of Carthax Lake" ) ){ Heat = 4; }

				else if ( reg.IsPartOf( "the Montor Sewers" ) ){ Heat = 0; }

				else if ( reg.IsPartOf( "Mangar's Tower" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "Mangar's Chamber" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "Kylearan's Tower" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "Harkyn's Castle" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "the Catacombs" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "the Lower Catacombs" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "the Sewers" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Cellar" ) ){ Heat = 0; }

				else if ( reg.IsPartOf( "the Sanctum of Saltmarsh" ) ){ Heat = 3; }
			}
			else if ( map == Map.Trammel )
			{
				if ( reg.IsPartOf( "the Ancient Pyramid" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Mausoleum" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "Dungeon Clues" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "Dardin's Pit" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "Frostwall Caverns" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "Dungeon Doom" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "Dungeon Exodus" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Fires of Hell" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Frozen Dungeon" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Mines of Morinia" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Perinian Depths" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Ratmen Lair" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Dungeon of Time Awaits" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "Castle Exodus" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Cave of Banished Mages" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the City of the Dead" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "the Dragon's Maw" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Cave of the Zuluu" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Tower of Brass" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "the Caverns of Poseidon" ) ){ Heat = 1; }

				else if ( reg.IsPartOf( "the Accursed Maze" ) ){ Heat = -1; }
				else if ( reg.IsPartOf( "the Chamber of Bane" ) ){ Heat = -1; }
				else if ( reg.IsPartOf( "Coldhall Depths" ) ){ Heat = -1; }
				else if ( reg.IsPartOf( "the Dark Sanctum" ) ){ Heat = -1; }
				else if ( reg.IsPartOf( "the Forgotten Tombs" ) ){ Heat = -1; }
				else if ( reg.IsPartOf( "the Magma Vaults" ) ){ Heat = -1; }
				else if ( reg.IsPartOf( "the Shrouded Grave" ) ){ Heat = -1; }

				else if ( reg.IsPartOf( "the Ruins of the Black Blade" ) ){ Heat = 2; }

				else if ( reg.IsPartOf( "Steamfire Cave" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "the Kuldara Sewers" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "the Crypts of Kuldar" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "Vordo's Castle" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "Vordo's Dungeon" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "Vordo's Castle Grounds" ) ){ Heat = 3; }
			}
			else if ( map == Map.Malas )
			{
				if ( reg.IsPartOf( "the Ancient Prison" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Cave of Fire" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "the Cave of Souls" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "Dungeon Ankh" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "Dungeon Bane" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "Dungeon Hate" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "Dungeon Scorn" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "Dungeon Torment" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "Dungeon Vile" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "Dungeon Wicked" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "Dungeon Wrath" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "the Flooded Temple" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "the Gargoyle Crypts" ) ){ Heat = 0; }
				else if ( reg.IsPartOf( "the Serpent Sanctum" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "the Tomb of the Fallen Wizard" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "the Castle of the Black Knight" ) ){ Heat = 3; }
			}
			else if ( map == Map.Tokuno )
			{
				if ( reg.IsPartOf( "the Altar of the Blood God" ) ){ Heat = 2; }
			}
			else if ( map == Map.Ilshenar )
			{
				if ( loc.X > 1655 && loc.Y < 1065 )
				{
					// THIS IS THE DUNGEON HOME REGION
				}
				else
				{
					if ( reg.IsPartOf( "the Glacial Scar" ) ){ Heat = 2; }
					else if ( Server.Misc.Worlds.GetRegionName( map, loc ) == "the Underworld" ){ Heat = 3; }
					else if ( reg.IsPartOf( typeof( DungeonRegion ) ) ){ Heat = 4; }
				}
			}
			else if ( map == Map.TerMur )
			{
				if ( reg.IsPartOf( "the Blood Temple" ) ){ Heat = 2; } // -- IN ISLES OF DREAD
				else if ( reg.IsPartOf( "the Tombs" ) ){ Heat = 4; }
				else if ( reg.IsPartOf( "the Corrupt Pass" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "the Crypt" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "the Great Pyramid" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "the Altar of the Dragon King" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "the Ice Queen Fortress" ) ){ Heat = 2; } // -- IN ISLES OF DREAD
				else if ( reg.IsPartOf( "Dungeon of the Lich King" ) ){ Heat = 4; }
				else if ( reg.IsPartOf( "Dungeon of the Mad Archmage" ) ){ Heat = 4; }
				else if ( reg.IsPartOf( "the Halls of Ogrimar" ) ){ Heat = 4; }
				else if ( reg.IsPartOf( "the Ratmen Mines" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "Dungeon Rock" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "the Sakkhra Tunnel" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "the Spider Cave" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "the Storm Giant Lair" ) ){ Heat = 4; }
				else if ( reg.IsPartOf( "the Cave of the Ancient Wyrm" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "the Isle of the Lich" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "the Castle of the Mad Archmage" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "the Mage Mansion" ) ){ Heat = 4; }
				else if ( reg.IsPartOf( "the Island of the Storm Giant" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "the Orc Fort" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "the Hedge Maze" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "the Pixie Cave" ) ){ Heat = 1; }
				else if ( reg.IsPartOf( "the Forgotten Halls" ) ){ Heat = 2; }
				else if ( reg.IsPartOf( "the Undersea Castle" ) ){ Heat = 4; }
				else if ( reg.IsPartOf( "the Tomb of Kazibal" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "the Catacombs of Azerok" ) ){ Heat = 4; }
				else if ( reg.IsPartOf( "the Azure Castle" ) ){ Heat = 3; }
				else if ( reg.IsPartOf( "the Scurvy Reef" ) ){ Heat = 2; }

				else if ( reg.IsPartOf( "the Ancient Crash Site" ) ){ Heat = 4; }
				else if ( reg.IsPartOf( "the Ancient Sky Ship" ) ){ Heat = 4; }
			}

			return Heat;
		}

		public static string GetOddityAdjective()
		{
			string sAdjective = "an odd";

			switch( Utility.RandomMinMax( 0, 6 ) )
			{
				case 0: sAdjective = "an odd"; break;
				case 1: sAdjective = "an unusual"; break;
				case 2: sAdjective = "a bizarre"; break;
				case 3: sAdjective = "a curious"; break;
				case 4: sAdjective = "a peculiar"; break;
				case 5: sAdjective = "a strange"; break;
				case 6: sAdjective = "a weird"; break;
			}
			return sAdjective;
		}

		public static bool GetMyEnemies( Mobile m, Mobile me, bool checkDisguise )
		{
			bool enemy = true;

			Region reg = Region.Find( me.Location, me.Map );

			if ( m is PlayerMobile )
			{
				if ( ((PlayerMobile)m).Profession == 1 )
				{
					m.Criminal = true;
					if ( m.Kills < 1 ){ m.Kills = 1; }
				}
			}

			if ( reg.IsPartOf( typeof( NecromancerRegion ) ) && GetPlayerInfo.EvilPlayer( m ) )
				return false;

			if ( !(me.CanSee( m )) || !(me.InLOS( m )) )
				return false;

			if ( m.AccessLevel > AccessLevel.Player )
				return false;

			if ( m is BasePerson || m is BaseVendor || m is PlayerVendor || m is Citizen )
				enemy = false;

			if ( m.Region.IsPartOf( typeof( PublicRegion ) ) )
				enemy = false;

			if ( m.Region.IsPartOf( typeof( StartRegion ) ) )
				enemy = false;

			if ( m is PlayerMobile && !m.Criminal && m.Kills<1 )
				enemy = false;

			if ( DisguiseTimers.IsDisguised( m ) && checkDisguise )
				enemy = false;

			if ( m is PlayerMobile && m.Karma <= -5000 && m.Skills[SkillName.Chivalry].Base >= 50 && !m.Region.IsPartOf(typeof(UmbraRegion)) )
				enemy = true; // DEATH KNIGHTS ARE NOT WELCOME AFTER THIS POINT...EXCEPT IN UMBRA OR RAVENDARK

			if (m is BaseCreature)
			{
				BaseCreature c = (BaseCreature)m;
				if ( c.Controlled || c.FightMode == FightMode.Aggressor || c.FightMode == FightMode.None )
					enemy = false;
			}	

			return enemy;
		}

		public static int GetCreatureLevel( Mobile m )
		{
			int fame = m.Fame;
				if ( fame > 15000){ fame = 15000; }

			int karma = m.Karma;
				if ( karma < 0 ){ karma = m.Karma * -1; }
				if ( karma > 15000){ karma = 15000; }

			int skills = m.Skills.Total;
				if ( skills > 1000000){ skills = 1000000; }
				skills = (int)( 1.5 * skills );			// UP TO 15,000

			int stats = m.RawStr + m.RawDex + m.RawInt;
				if ( stats > 300){ stats = 300; }
				stats = 60 * stats;						// UP TO 15,000

			int level = (int)( ( fame + karma + skills + stats ) / 600 );
				level = (int)( ( level - 10 ) * 1.12 );

			if ( level < 1 ){ level = 1; }
			if ( level > 125 ){ level = 125; }

			return level;
		}

		public static int GetUnidentifiedChance()
		{
			return 0;
		}

		public static int GetTimeBetweenQuests()
		{
			return 0;
		}

		public static int GetTimeBetweenArtifactQuests()
		{
			return 20160;
		}

		public static int GetGoldCutRate()
		{
			return 25;
		}

		public static bool AllowMacroResources()
		{
			return true;
		}

		public static bool SaveOnCharacterLogout()
		{
			return false;
		}

		public static bool CreaturesDetectHidden()
		{
			// IF TRUE, ALL CREATURES WILL HAVE SOME FORM OF DETECT HIDDEN SKILL
			// THAT IS BASED ON THEIR CREATURE LEVEL. THIS MAKES THE STEALTHY
			// THIEVES HAVE MORE OF A CHALLENGE WHEN THEY ARE TOMB RAIDING
			return true;
		}

		public static bool NoMountsInCertainRegions()
		{
			return false;
		}

		public static int SpellDamageIncreaseVsMonsters()
		{
			return 200;
		}

		public static int SpellDamageIncreaseVsPlayers()
		{
			return 100;
		}

		public static bool RunRoutinesAtStartup()
		{
			// THE SERVER HAS SOME SELF-CLEANING AND SELF-SUSTAINING SCRIPTS IT RUNS EVERY HOUR, 3 HOURS, & 24 HOURS
			// IF YOU RUN A 24x7 SERVER, YOU CAN SET THE BELOW TO false SINCE YOUR SERVER WILL RUN THESE AT THOSE TIMES
			// IF YOU PLAY SINGLE PLAYER, AND YOU TURN THE SERVER ON/OFF AS REQUIRED, THEN SET THIS TO true SO THESE ROUTINES AT LEAST RUN FOR YOU
			return false;
		}

		public static int QuestRewardModifier()
		{
			// FOR ASSSASSIN, THIEF, FISHING, & STANDARD QUESTS
			// 100 PERCENT IS STANDARD

			int mod = 150; // PERCENT

			if ( mod < 0 )
				mod = 0;

			return mod;
		}

		public static int StatsPerAbility( int statValue )
		{
			// THIS MULTIPLIES AGAINST THE RAW STAT TO GIVE THE RETURNING HIT POINTS, MANA, OR STAMINA
			// SO SETTING THIS TO 2.0 WOULD GIVE THE CHARACTER HITS POINTS EQUAL TO THEIR STRENGTH x 2

			double mod = 2.0; 

			statValue = (int)( statValue * mod );
				if ( statValue < 0 ){ statValue = 1; }

			return statValue;
		}
	}
}
