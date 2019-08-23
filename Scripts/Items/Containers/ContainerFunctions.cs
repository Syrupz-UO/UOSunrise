using System;
using Server;
using System.Collections;
using Server.Items;
using Server.Multis;
using Server.Mobiles;
using Server.Network;
using System.Reflection;
using System.Text;
using Server.Regions;

namespace Server.Misc
{
    class ContainerFunctions
    {
		public static int LockTheContainer( int level, LockableContainer box, int nContainerLockable )
		{
			if ( level > 0 )
			{
				switch ( Utility.Random( 9 ) )
				{
					case 0: box.TrapType = TrapType.DartTrap; break;
					case 1: box.TrapType = TrapType.None; break;
					case 2: box.TrapType = TrapType.ExplosionTrap; break;
					case 3: box.TrapType = TrapType.MagicTrap; break;
					case 4: box.TrapType = TrapType.PoisonTrap; break;
					case 5: box.TrapType = TrapType.None; break;
					case 6: box.TrapType = TrapType.None; break;
					case 7: box.TrapType = TrapType.None; break;
					case 8: box.TrapType = TrapType.None; break;
				}

				if ( box is TreasureMapChest ){ box.TrapType = TrapType.ExplosionTrap; }

				if ( IsSpaceCrate( box.ItemID ) && box.TrapType != TrapType.None ){ box.TrapType = TrapType.ExplosionTrap; }

				if ( box is ParagonChest )
				{
					switch ( Utility.Random( 4 ) )
					{
						case 0: box.TrapType = TrapType.DartTrap; break;
						case 1: box.TrapType = TrapType.ExplosionTrap; break;
						case 2: box.TrapType = TrapType.MagicTrap; break;
						case 3: box.TrapType = TrapType.PoisonTrap; break;
					}
				}

				box.TrapPower = (level * Utility.RandomMinMax( 20, 30 )) + Utility.RandomMinMax( 1, 10 );
				box.TrapLevel = level;
					if ( box.TrapLevel > 90 ){ box.TrapLevel = 90; }
					if ( box.TrapLevel < 0 ){ box.TrapLevel = 0; }
			}

			int LockWatch = 0;
				if ( nContainerLockable < 7 || nContainerLockable == 16 || nContainerLockable == 18 ){ LockWatch = 1; }
				else { box.Locked = false; box.LockLevel = 0; box.MaxLockLevel = 0; box.RequiredSkill = 0; }

			if ( LockWatch > 0 )
			{
				box.Locked = false;
				switch( Utility.Random( 3 ) )
				{
					case 0: box.Locked = true; break;
				}
				if ( box is TreasureMapChest || box is ParagonChest ){ box.Locked = true; }

				box.LockLevel = 1+(level * 10);
					if ( box.LockLevel > 90 ){ box.LockLevel = 90; }
					if ( box.LockLevel < 0 ){ box.LockLevel = 0; }
				box.MaxLockLevel = box.LockLevel + 20;
				box.RequiredSkill = box.LockLevel;
			}
			else { box.Locked = false; box.LockLevel = 0; box.MaxLockLevel = 0; box.RequiredSkill = 0; }

			return LockWatch;
		}
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		public static void FillTheContainer( int level, LockableContainer box, Mobile opener )
		{
			if ( level > 12 ){ level = 12; } // LIMIT TO LEVEL 12 CHESTS

			int filler = (int)(level/2)+1; if (filler < 1){ filler = 1; }
			int fillup = filler + 2;
			int filled = 0;
			int rich = level * 7;
			int iRich = rich + 7;
			int money = (level+1) * Utility.RandomMinMax( 40, 160 );

			double w = money * (DifficultyLevel.GetGoldCutRate() * .01);
			money = (int)w;

			// WIZARD IS DOING MULTIPLE CURRENCIES //////////////////////////////////////
			int nCoins = money * 10;

			if ( Server.Misc.Worlds.IsOnSpaceship( opener.Location, opener.Map ) || IsSpaceCrate( box.ItemID ) )
			{
				int xormite = (int)(money/3);
				box.DropItem( new DDXormite( xormite ) );
			}
			else if ( (Region.Find( box.Location, box.Map )).IsPartOf( "the Mines of Morinia" ) && Utility.RandomMinMax( 1, 5 ) == 1 )
			{
				int crystals = (int)(money/5);
				box.DropItem( new Crystals( crystals ) );
			}
			else if ( Worlds.GetMyWorld( box.Map, box.Location, box.X, box.Y ) == "the Underworld" )
			{
				int jewels = (int)(money/2);
				box.DropItem( new DDJewels( jewels ) );
			}
			else
			{
				
				///////////todo random amounts////////////////////
						int nGold;	
						nGold = Utility.RandomMinMax( 1000, 2500 ); 
						box.DropItem( new Gold( nGold ) );
						
				//////////////////////////////////////////////	
				


			// I WANT SOME CHESTS TO IGNORE CERTAIN TYPES OF LOOT
			int IgnoreThisFiller = 0;
			if ( box is TreasureMapChest || box is ParagonChest || box is SunkenChest || box is GraveChest ){ IgnoreThisFiller = 1; }
			else if ( Server.Misc.Worlds.IsOnSpaceship( box.Location, box.Map ) || IsSpaceCrate( box.ItemID ) ){ IgnoreThisFiller = 2; }

			int CorpseNoFiller = 0;
			if ( box is CorpseChest ){ CorpseNoFiller = 1; }
			else if ( box is CorpseSailor ){ CorpseNoFiller = 1; }
			
			
//////////////////////////////////////////////////START THE LOOT//////////////////////////////////////////////////////////////////////////////////////////////			
				
				
				Item secretReg = Loot.RandomSecretReagent();
				UnknownReagent myreg = (UnknownReagent)secretReg;
			    if ( IgnoreThisFiller == 2 ){ Server.Misc.MorphingTime.MakeSpaceAceItem( secretReg, opener ); }
				myreg.RegAmount = Utility.RandomMinMax( (level * 5), (level * 10) ) + 1; box.DropItem( myreg );
						
				Item idropped1 = DungeonLoot.RandomTools();
				box.DropItem( idropped1 );
				
				Item idropped2 = DungeonLoot.RandomWares();
				box.DropItem( idropped2 );
				
				Item idropped3 = DungeonLoot.RandomJunk();
				box.DropItem( idropped3 );
				
				Item idropped4 = Loot.RandomGem();
				box.DropItem( idropped4 );
				
				
				Item loot = null;
				if ( Utility.Random( 2 ) == 1 ) { loot = Loot.RandomScroll( 0, ((7*Utility.RandomMinMax( 1, 6 ))+3), SpellbookType.Regular ); }
					else { loot = Loot.RandomScroll( 0, (((7*Utility.RandomMinMax( 1, 6 ))*2)+3), SpellbookType.Necromancer ); }
				
				
				Item idropped6 = Loot.RandomPotion();
				if (idropped6.Stackable == true){ idropped6.Amount = Utility.RandomMinMax( 1, 5 ); }
				box.DropItem( idropped6 );
				
				
				
				Item idropped7 = Loot.RandomPossibleReagent();
				if (idropped7.Stackable == true){ idropped7.Amount = Utility.RandomMinMax( 1, 5 ); }
				box.DropItem( idropped7 );
				
				
				
				Item idropped8 = Loot.RandomMixerReagent();
				if (idropped8.Stackable == true){ idropped8.Amount = Utility.RandomMinMax( 1, 5 ); }
				box.DropItem( idropped8 );
				
				
				
				Item idropped9 = Loot.RandomNecromancyReagent();
				if (idropped9.Stackable == true){ idropped9.Amount = Utility.RandomMinMax( 1, 5 ); }
				box.DropItem( idropped9 );
				
				Item idropped10 = Loot.RandomNecromancyReagent();
				if (idropped10.Stackable == true){ idropped10.Amount = Utility.RandomMinMax( 1, 5 ); }
				box.DropItem( idropped10 );
				
				Item idropped12 = Loot.RandomReagent();
				if (idropped12.Stackable == true){ idropped12.Amount = Utility.RandomMinMax( 1, 5 ); }
				box.DropItem( idropped12 );
				
				Item idropped11 = Loot.RandomHerbReagent();
				if (idropped11.Stackable == true){ idropped11.Amount = Utility.RandomMinMax( 1, 5 ); }
				box.DropItem( idropped11 );
				
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	
////////////////////////////////////////////////////RARES AND ARTI//////////////////////////////////////////////////////////////////////////	
					if ( iRich > Utility.Random( 1000 ) && IgnoreThisFiller != 2 )
				{
					Item idropped = DungeonLoot.RandomRare();
					if ( idropped.Stackable == true ){ idropped.Amount = Utility.RandomMinMax( 2, 10 ); }
					else if ( idropped is Runebook ){ idropped.ItemID = Utility.RandomList( 0x22C5, 0x0F3D ); } 
					else if ( idropped is CandleLarge || idropped is Candelabra || idropped is CandelabraStand ){ Server.Misc.MaterialInfo.ColorMetal( idropped, 0 ); }
					box.DropItem( idropped );		
				}
				
				if ( iRich > Utility.Random( 5000 ) && IgnoreThisFiller != 2 ){ 
				Item item = Loot.RandomQuiver();
						ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, null, Utility.RandomMinMax( 15, 20 ) );
						box.DropItem(item );
				}
			//	if ( iRich > Utility.Random( 15000 ) && IgnoreThisFiller != 2 ){ box.DropItem( DungeonLoot.RandomSlayer() ); }
				
				if ( iRich > Utility.Random( 1000 ) && IgnoreThisFiller != 2 ){ box.DropItem( DungeonLoot.RandomRuneMagic() ); }
				if(Utility.RandomDouble() < 0.03){ box.DropItem( DungeonLoot.RandomSlayer() ); }
				if(Utility.RandomDouble() < 0.03){ box.DropItem( Loot.RandomSArty() ); }
				
			if ( iRich > Utility.Random( 7500 ) && IgnoreThisFiller != 2 )
			{
				Item golem = new GolemManual();
				box.DropItem( golem );
			}
			else if ( iRich > Utility.Random( 7500 ) && IgnoreThisFiller == 2 )
			{
				Item robot = new RobotSchematics();
				box.DropItem( robot );
			}

			if ( iRich > Utility.Random( 10000 ) && IgnoreThisFiller != 2 )
			{
				Item prison = new SummonPrison();
				box.DropItem( prison );
			}
			if ( iRich > Utility.Random( 2500 ) )
			{
				Item lute = Loot.RandomInstrument();
				LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), lute, box, level );
			}

			
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////			
			
				
				
//////////////////////////////////////////////////////////////OTHER CRAP////////////////////////////////////////////////////////////////////				
				for ( int i = 0; i < 15; i++ )
				{
				Item item = null;

				switch ( Utility.Random( 20 ) )
				{
					case 0:
					 
						item = ScrollofTranscendence.CreateRandom(level, level * 5);
						//ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, null, Utility.RandomMinMax( 15, 20 ) );
						box.DropItem(item ); 
						break;
					case 1:
						 item = Loot.RandomWeapon( Server.LootPackEntry.IsInTokuno( opener ) );
						//SlayerName slayer = BaseRunicTool.GetRandomSlayer();
						ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, null, Utility.RandomMinMax( 10, 15 ) );
						break;
					case 2:
						item = Loot.RandomRangedWeapon( Server.LootPackEntry.IsInTokuno( opener ) );
						ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, null, Utility.RandomMinMax( 20, 25 ) );
						break;
					case 3:
						if ( Server.Misc.GetPlayerInfo.EvilPlay( opener ) == true && Utility.RandomMinMax( 0, 10 ) == 10 )
						{
							item = DungeonLoot.RandomEvil();
						}
						else
						{
							item = Loot.RandomRelic();
							if ( item is DDRelicWeapon && Server.Misc.GetPlayerInfo.OrientalPlay( opener ) == true ){ Server.Items.DDRelicWeapon.MakeOriental( item ); }
							else if ( item is DDRelicStatue && Server.Misc.GetPlayerInfo.OrientalPlay( opener ) == true ){ Server.Items.DDRelicStatue.MakeOriental( item ); }
							else if ( item is DDRelicBanner && item.ItemID != 0x2886 && item.ItemID != 0x2887 && Server.Misc.GetPlayerInfo.OrientalPlay( opener ) == true ){ Server.Items.DDRelicBanner.MakeOriental( item ); }
						}
						break;
					case 4:
						item = DungeonLoot.RandomRare();
						if ( item.Stackable == true ){ item.Amount = Utility.RandomMinMax( 5, 20 ); }
						break;
					case 5:
						item = DungeonLoot.RandomLoreBooks();
						break;
					case 6:
						if ( Utility.Random( 4 ) != 1 ) { item = Loot.RandomScroll( 0, 7, SpellbookType.Regular ); } 
						else { item = Loot.RandomScroll( 0, 17, SpellbookType.Necromancer ); }
						break;
					case 7:
						int luckMod = opener.Luck; if ( luckMod > 2000 ){ luckMod = 2000; }

						if (	(Region.Find( opener.Location, opener.Map )).IsPartOf( "the Ancient Crash Site" ) || 
								(Region.Find( opener.Location, opener.Map )).IsPartOf( "the Ancient Sky Ship" ) )
						{
							item = new DDXormite( ( luckMod + Utility.RandomMinMax( 333, 666 ) ) );
						}
						else if ( Worlds.GetMyWorld( opener.Map, opener.Location, opener.X, opener.Y ) == "the Mines of Morinia" )
						{
							item = new Crystals( ( luckMod + Utility.RandomMinMax( 200, 400 ) ) );
						}
						else if ( Worlds.GetMyWorld( opener.Map, opener.Location, opener.X, opener.Y ) == "the Underworld" )
						{
							item = new DDJewels( ( luckMod + Utility.RandomMinMax( 500, 1000 ) ) );
						}
						else
						{
							item = DungeonLoot.RandomLoreBooks();
						//ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, null, Utility.RandomMinMax( 10, 15 ) );
						
						}
						break;
					case 8: 
					
						 item = Loot.RandomWeapon( Server.LootPackEntry.IsInTokuno( opener ) );
						//SlayerName slayer = BaseRunicTool.GetRandomSlayer();
						ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, null, Utility.RandomMinMax( 10, 15 ) );
						break;
					
					case 9: 
					item = Loot.RandomArmor( Server.LootPackEntry.IsInTokuno( opener ) );
						ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, null, Utility.RandomMinMax( 10, 15 ) );
						break;
					case 10:
						item = Loot.RandomArmorOrShieldOrWeaponOrJewelry( Server.LootPackEntry.IsInTokuno( opener ) );
						ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, null, Utility.RandomMinMax( 15, 25 ) );
						break;
					case 11:
					    item = Loot.RandomRangedWeapon( Server.LootPackEntry.IsInTokuno( opener ) );
						ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, null, Utility.RandomMinMax( 10, 15 ) );
						break;
					case 12:
						item = Loot.RandomInstrument();

						int attributeCount;
						int min, max;
						Server.Misc.ContainerFunctions.GetRandomAOSStats( out attributeCount, out min, out max, 10 );

						BaseInstrument instr = (BaseInstrument)item;

						int cHue = 0;
						int cUse = 0;

						switch ( instr.Resource )
						{
							case CraftResource.AshTree: cHue = MaterialInfo.GetMaterialColor( "ash", "", 0 ); cUse = 20; break;
							case CraftResource.CherryTree: cHue = MaterialInfo.GetMaterialColor( "cherry", "", 0 ); cUse = 40; break;
							case CraftResource.EbonyTree: cHue = MaterialInfo.GetMaterialColor( "ebony", "", 0 ); cUse = 60; break;
							case CraftResource.GoldenOakTree: cHue = MaterialInfo.GetMaterialColor( "gold", "", 0 ); cUse = 80; break;
							case CraftResource.HickoryTree: cHue = MaterialInfo.GetMaterialColor( "hickory", "", 0 ); cUse = 100; break;
							case CraftResource.MahoganyTree: cHue = MaterialInfo.GetMaterialColor( "mahogany", "", 0 ); cUse = 120; break;
							case CraftResource.DriftwoodTree: cHue = MaterialInfo.GetMaterialColor( "driftwood", "", 0 ); cUse = 120; break;
							case CraftResource.OakTree: cHue = MaterialInfo.GetMaterialColor( "oak", "", 0 ); cUse = 140; break;
							case CraftResource.PineTree: cHue = MaterialInfo.GetMaterialColor( "pine", "", 0 ); cUse = 160; break;
							case CraftResource.RosewoodTree: cHue = MaterialInfo.GetMaterialColor( "rosewood", "", 0 ); cUse = 180; break;
							case CraftResource.WalnutTree: cHue = MaterialInfo.GetMaterialColor( "walnute", "", 0 ); cUse = 200; break;
						}

						if ( !( Server.Misc.Worlds.IsOnSpaceship( opener.Location, opener.Map ) ) )
						{
							if ( cHue > 0 ){ item.Hue = cHue; }
							else if ( Utility.RandomMinMax( 1, 4 ) == 1 ){ item.Hue = RandomThings.GetRandomColor(0); }
							Server.Misc.MorphingTime.MakeOrientalItem( item, opener );
							item.Name = LootPackEntry.MagicItemName( item, opener, Region.Find( opener.Location, opener.Map ) );
						}
						else 
						{
							string newName = "odd alien";
							switch( Utility.RandomMinMax( 0, 6 ) )
							{
								case 0: newName = "odd"; break;
								case 1: newName = "unusual"; break;
								case 2: newName = "bizarre"; break;
								case 3: newName = "curious"; break;
								case 4: newName = "peculiar"; break;
								case 5: newName = "strange"; break;
								case 6: newName = "weird"; break;
							}

							switch( Utility.RandomMinMax( 1, 4 ) )
							{
								case 1: item = new Pipes();		item.Name = newName + " " + Server.Misc.RandomThings.GetRandomAlienRace() + " pipes";		break;
								case 2: item = new Pipes();		item.Name = newName + " " + Server.Misc.RandomThings.GetRandomAlienRace() + " pan flute";	break;
								case 3: item = new Fiddle();	item.Name = newName + " " + Server.Misc.RandomThings.GetRandomAlienRace() + " violin";		break;
								case 4: item = new Fiddle();	item.Name = newName + " " + Server.Misc.RandomThings.GetRandomAlienRace() + " fiddle";		break;
							}

							BaseInstrument lute = (BaseInstrument)item;
								lute.Resource = CraftResource.None;

							item.Hue = Server.Misc.RandomThings.GetRandomColor(0);
						}

						instr.UsesRemaining = instr.UsesRemaining + cUse;

						BaseRunicTool.ApplyAttributesTo( (BaseInstrument)item, attributeCount, min, max );

						SlayerName slayer = BaseRunicTool.GetRandomSlayer();

						instr.Quality = InstrumentQuality.Regular;
						if ( Utility.RandomMinMax( 1, 4 ) == 1 ){ instr.Quality = InstrumentQuality.Exceptional; }

						if ( Utility.RandomMinMax( 1, 4 ) == 1 ){ instr.Slayer = slayer; }

						break;
					case 13:
						//item = DungeonLoot.RandomSlayer();
						//ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, null, Utility.RandomMinMax( 15, 25 ) );
						break;
						
					case 14:
						item = Loot.RandomJewelry();
						ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, null, Utility.RandomMinMax( 15, 25 ) );
						break;
						
					case 15:
						item = Loot.RandomWand(); Server.Misc.MaterialInfo.ColorMetal( item, 0 ); string wandOwner = ""; if ( Utility.RandomMinMax( 1, 3 ) == 1 ){ wandOwner = Server.LootPackEntry.MagicWandOwner() + " "; } item.Name = wandOwner + item.Name;
						break;
					case 16:
						item = Loot.RandomPotion();
						break;
						
					case 17:
						item = Loot.RandomJewelry();
						ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, null, Utility.RandomMinMax( 15, 25 ) );
						break;

					case 18:
						item = Loot.RandomJewelry();
						ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, null, Utility.RandomMinMax( 15, 25 ) );
						break;	
						
					case 19:
						item = Loot.RandomClothing();
						ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, null, Utility.RandomMinMax( 15, 25 ) );
						break;	
					
				}
				

				if ( item != null )
				{ 
					if ( Worlds.IsOnSpaceship( opener.Location, opener.Map ) ){ Server.Misc.MorphingTime.MakeSpaceAceItem( item, opener ); }

					if ( item is Container ){ item.MoveToWorld( opener.Location, opener.Map ); }
					else { box.DropItem(item ); }
				}
				else
				{
					if ( Worlds.IsOnSpaceship( opener.Location, opener.Map ) )
					{
						item = new DDXormite( ( opener.Luck + Utility.RandomMinMax( 333, 666 ) ) );
					}
					else if ( Worlds.GetMyWorld( opener.Map, opener.Location, opener.X, opener.Y ) == "the Underworld" )
					{
						item = new DDJewels( ( opener.Luck + Utility.RandomMinMax( 500, 1000 ) ) );
					}
					else
					{
						//item = new Gold( ( opener.Luck + Utility.RandomMinMax( 1000, 2000 ) ) );
					}
					if ( item != null ){ box.DropItem(item ); }
				}
			}
	}
		}
		
		
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		public static void FillTheContainerByWorld( int level, LockableContainer box, string world, Mobile opener )
		{
			int filler = (int)(level/2)+1; if (filler < 1){ filler = 1; }
			int fillup = filler + 2;
			int filled = 0;
			int rich = level * 7;
			int iRich = rich + 7;

			filled = Utility.RandomMinMax( filler,fillup );
			for ( int i = 0; i < ( filled ); ++i )
			{
				if ( world == "the Town of Skara Brae" )
				{
					if ( iRich > Utility.Random( 100 ) )
					{
						box.DropItem( new BardsTaleNote() );
					}
				}
				else if ( Server.Misc.Worlds.IsOnSpaceship( box.Location, box.Map ) )
				{
					Item item = DungeonLoot.RandomSpaceJunk();
					Server.Misc.MorphingTime.MakeSpaceAceItem( item, opener );

					if ( item is KilrathiHeavyGun || item is KilrathiGun || item is LightSword || item is DoubleLaserSword )
					{
						if ( Utility.RandomMinMax( 1, 10 ) == 1 ){ LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), item, box, level ); }
					}

					box.DropItem( item );
				}
			}
		}

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		public static void GetRandomAOSStats( out int attributeCount, out int min, out int max, int level )
		{
			int rnd = Utility.Random( 15 );
			attributeCount = Utility.RandomMinMax( 1, level );
			min = level*3; max = level*7;
		}

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		public static int BuildContainer( LockableContainer box, int thisHue, int thisItem, int thisGump, int thisDesign )
		{
			///// DECIDE ON THE APPEARANCE OF THE CONTAINERS /////
			int myBox = Utility.RandomMinMax( 1, 11 );
				if ( thisItem > 0 ){ myBox = thisItem; }
			if ( box.Locked == true ){ myBox = Utility.RandomMinMax( 1, 6 ); }

			if ( thisDesign == 2 ){ myBox = Utility.RandomList( 9, 10, 11, 12 ); }
			else if ( thisDesign == 4 ){ myBox = 12; }
			else if ( thisDesign == 5 ){ myBox = Utility.RandomList( 9, 10, 11 ); }
			else if ( thisDesign == 6 ){ myBox = Utility.RandomList( 2, 2, 6 ); }
			else if ( thisDesign == 7 ){ myBox = Utility.RandomList( 2, 6, 12, 13 ); }
			else if ( thisDesign == 8 ){ myBox = Utility.RandomList( 2, 6, 13, 14 ); }
			else if ( thisDesign == 9 ){ myBox = 14; }
			else if ( thisDesign == 10 ){ myBox = 15; } // LOST BOATS
			else if ( thisDesign == 11 ){ myBox = Utility.RandomList( 1, 2, 13, 16 ); } // SEA DUNGEONS
			else if ( thisDesign == 12 ){ myBox = Utility.RandomList( 1, 2, 7, 8, 12 ); } // HALL OF THE MOUNTAIN KING
			else if ( thisDesign == 13 ){ myBox = Utility.RandomList( 17, 18, 18, 18 ); } // ALIEN SPACE SHIP
			else if ( thisDesign == 14 ){ myBox = 18; } // ALIEN SPACE SHIP - CRATES ONLY

			int nContainerLockable = 0;

			string hue = "";

			if ( myBox == 1 )
			{
				nContainerLockable = 1;
				box.Weight = 10.0;
				box.ItemID = Utility.RandomList( 0xe42, 0xe43 );	box.GumpID = 0x49;		box.Name = "Wooden Chest";		box.Hue = 0x724;
				switch( Utility.Random( 20 ) )
				{
					case 0:		box.ItemID = Utility.RandomList( 0xe42, 0xe43 );	box.GumpID = 0x49;		box.Name = "Oak Wood Chest";			hue = "oak";									break;
					case 1:		box.ItemID = Utility.RandomList( 0xe42, 0xe43 );	box.GumpID = 0x49;		box.Name = "Ash Wood Chest";			hue = "ash";									break;
					case 2:		box.ItemID = Utility.RandomList( 0xe42, 0xe43 );	box.GumpID = 0x49;		box.Name = "Cherry Wood Chest";			hue = "cherry";									break;
					case 3:		box.ItemID = Utility.RandomList( 0xe42, 0xe43 );	box.GumpID = 0x49;		box.Name = "Walnut Wood Chest";			hue = "walnut";									break;
					case 4:		box.ItemID = Utility.RandomList( 0xe42, 0xe43 );	box.GumpID = 0x49;		box.Name = "Golden Oak Wood Chest";		hue = "golden oak";								break;
					case 5:		box.ItemID = Utility.RandomList( 0xe42, 0xe43 );	box.GumpID = 0x49;		box.Name = "Ebony Wood Chest";			hue = "ebony";									break;
					case 6:		box.ItemID = Utility.RandomList( 0xe42, 0xe43 );	box.GumpID = 0x49;		box.Name = "Hickory Wood Chest";		hue = "hickory";								break;
					case 7:		box.ItemID = Utility.RandomList( 0xe42, 0xe43 );	box.GumpID = 0x49;		box.Name = "Pine Wood Chest";			hue = "pine";									break;
					case 8:		box.ItemID = Utility.RandomList( 0xe42, 0xe43 );	box.GumpID = 0x49;		box.Name = "Rosewood Chest";			hue = "rosewood";								break;
					case 9:		box.ItemID = Utility.RandomList( 0xe42, 0xe43 );	box.GumpID = 0x49;		box.Name = "Mahogany Wood Chest";		hue = "mahogany";								break;
					case 10:	box.ItemID = Utility.RandomList( 0xe42, 0xe43 );	box.GumpID = 0x49;		box.Name = "Drift Wood Chest";			hue = "driftwood";								break;
					case 11:	box.ItemID = Utility.RandomList( 0xe42, 0xe43 );	box.GumpID = 0x49;		box.Name = "Worn Wooden Chest";			box.Hue = Utility.RandomMinMax( 2413, 2430 );	break;
				}
				box.Hue = MaterialInfo.GetMaterialColor( hue, "", box.Hue );
				if ( thisDesign == 3 ){ box.ItemID = Utility.RandomList( 0x10EC, 0x10ED );	box.GumpID = 0x976;		box.Name = "Rusty Metal Crate";		box.Hue = 0; }
			}
			else if ( myBox == 2 )
			{
				nContainerLockable = 2;
				box.Weight = 20.0;
				box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x4A;		box.Name = "Iron Chest";
				switch( Utility.Random( 30 ) )
				{
					case 0:		box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Metal Chest";																break;
					case 1:		box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x4A;		box.Name = "Rusty Iron Chest";		box.Hue = Utility.RandomMinMax( 2413, 2430 );		break;
					case 2:		box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Rusty Metal Chest";		box.Hue = Utility.RandomMinMax( 2413, 2430 );		break;
					case 3:		box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Dull Copper Chest";		hue = "dull copper";								break;
					case 4:		box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Shadow Iron Chest";		hue = "shadow iron";								break;
					case 5:		box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Copper Chest";			hue = "copper";										break;
					case 6:		box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Bronze Chest";			hue = "bronze";										break;
					case 7:		box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Golden Chest";			hue = "gold";										break;
					case 8:		box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Agapite Chest";			hue = "agapite";									break;
					case 9:		box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Verite Chest";			hue = "verite";										break;
					case 10:	box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Valorite Chest";		hue = "valorite";									break;
					case 11:	box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Silver Chest";			hue = "silver";										break;
					case 12:	box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Emerald Chest";			hue = "emerald";									break;
					case 13:	box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Jade Chest";			hue = "jade";										break;
					case 14:	box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Onyx Chest";			hue = "onyx";										break;
					case 15:	box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Ruby Chest";			hue = "ruby";										break;
					case 16:	box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Sapphire Chest";		hue = "sapphire";									break;
					case 17:	box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Obsidian Chest";		hue = "obsidian";									break;
					case 18:	box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Nepturite Chest";		hue = "nepturite";									break;
					case 19:	box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Steel Chest";			hue = "steel";										break;
					case 20:	box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Brass Chest";			hue = "brass";										break;
					case 21:	box.ItemID = Utility.RandomList( 0xe40, 0xe41 );	box.GumpID = 0x42;		box.Name = "Mithril Chest";			hue = "mithril";									break;
				}
				box.Hue = MaterialInfo.GetMaterialColor( hue, "classic", box.Hue );
				if ( thisDesign == 3 ){ box.ItemID = Utility.RandomList( 0x10EA, 0x10EB );	box.GumpID = 0x976;		box.Name = "Metal Crate";		box.Hue = 0; }
			}
			else if ( myBox == 3 )
			{
				nContainerLockable = 3;
				box.Weight = 12.0;
				box.ItemID = Utility.RandomList( 0x2811, 0x2812 );	box.GumpID = 0x10B;	box.Name = "Wooden Footlocker";
				switch( Utility.Random( 20 ) )
				{
					case 0:		box.ItemID = Utility.RandomList( 0x2811, 0x2812 );	box.GumpID = 0x10B;	box.Name = "Worn Wooden Footlocker";		box.Hue = Utility.RandomMinMax( 2413, 2430 );	break;
					case 1:		box.ItemID = Utility.RandomList( 0x2811, 0x2812 );	box.GumpID = 0x10B;	box.Name = "Oak Wood Footlocker";			hue = "oak";									break;
					case 2:		box.ItemID = Utility.RandomList( 0x2811, 0x2812 );	box.GumpID = 0x10B;	box.Name = "Ash Wood Footlocker";			hue = "ash";									break;
					case 3:		box.ItemID = Utility.RandomList( 0x2811, 0x2812 );	box.GumpID = 0x10B;	box.Name = "Cherry Wood Footlocker";		hue = "cherry";									break;
					case 4:		box.ItemID = Utility.RandomList( 0x2811, 0x2812 );	box.GumpID = 0x10B;	box.Name = "Walnut Wood Footlocker";		hue = "walnut";									break;
					case 5:		box.ItemID = Utility.RandomList( 0x2811, 0x2812 );	box.GumpID = 0x10B;	box.Name = "Golden Oak Wood Footlocker";	hue = "golden oak";								break;
					case 6:		box.ItemID = Utility.RandomList( 0x2811, 0x2812 );	box.GumpID = 0x10B;	box.Name = "Ebony Wood Footlocker";			hue = "ebony";									break;
					case 7:		box.ItemID = Utility.RandomList( 0x2811, 0x2812 );	box.GumpID = 0x10B;	box.Name = "Hickory Wood Footlocker";		hue = "hickory";								break;
					case 8:		box.ItemID = Utility.RandomList( 0x2811, 0x2812 );	box.GumpID = 0x10B;	box.Name = "Pine Wood Footlocker";			hue = "pine";									break;
					case 9:		box.ItemID = Utility.RandomList( 0x2811, 0x2812 );	box.GumpID = 0x10B;	box.Name = "Rosewood Footlocker";			hue = "rosewood";								break;
					case 10:	box.ItemID = Utility.RandomList( 0x2811, 0x2812 );	box.GumpID = 0x10B;	box.Name = "Mahogany Wood Footlocker";		hue = "mahogany";								break;
					case 11:	box.ItemID = Utility.RandomList( 0x2811, 0x2812 );	box.GumpID = 0x10B;	box.Name = "Drift Wood Footlocker";			hue = "driftwood";								break;
				}
				box.Hue = MaterialInfo.GetMaterialColor( hue, "", box.Hue );
			}
			else if ( myBox == 4 )
			{
				nContainerLockable = 4;
				box.Weight = 15.0;
				box.ItemID = Utility.RandomList( 0x2813, 0x2814 );	box.GumpID = 0x10D;	box.Name = "Wooden Trunk";
				switch( Utility.Random( 20 ) )
				{
					case 0:		box.ItemID = Utility.RandomList( 0x2813, 0x2814 );	box.GumpID = 0x10D;	box.Name = "Worn Wooden Trunk";			box.Hue = Utility.RandomMinMax( 2413, 2430 );	break;
					case 1:		box.ItemID = Utility.RandomList( 0x2813, 0x2814 );	box.GumpID = 0x10D;	box.Name = "Oak Wood Trunk";			hue = "oak";									break;
					case 2:		box.ItemID = Utility.RandomList( 0x2813, 0x2814 );	box.GumpID = 0x10D;	box.Name = "Ash Wood Trunk";			hue = "ash";									break;
					case 3:		box.ItemID = Utility.RandomList( 0x2813, 0x2814 );	box.GumpID = 0x10D;	box.Name = "Cherry Wood Trunk";			hue = "cherry";									break;
					case 4:		box.ItemID = Utility.RandomList( 0x2813, 0x2814 );	box.GumpID = 0x10D;	box.Name = "Walnut Wood Trunk";			hue = "walnut";									break;
					case 5:		box.ItemID = Utility.RandomList( 0x2813, 0x2814 );	box.GumpID = 0x10D;	box.Name = "Golden Oak Wood Trunk";		hue = "golden oak";								break;
					case 6:		box.ItemID = Utility.RandomList( 0x2813, 0x2814 );	box.GumpID = 0x10D;	box.Name = "Ebony Wood Trunk";			hue = "ebony";									break;
					case 7:		box.ItemID = Utility.RandomList( 0x2813, 0x2814 );	box.GumpID = 0x10D;	box.Name = "Hickory Wood Trunk";		hue = "hickory";								break;
					case 8:		box.ItemID = Utility.RandomList( 0x2813, 0x2814 );	box.GumpID = 0x10D;	box.Name = "Pine Wood Trunk";			hue = "pine";									break;
					case 9:		box.ItemID = Utility.RandomList( 0x2813, 0x2814 );	box.GumpID = 0x10D;	box.Name = "Rosewood Trunk";			hue = "rosewood";								break;
					case 10:	box.ItemID = Utility.RandomList( 0x2813, 0x2814 );	box.GumpID = 0x10D;	box.Name = "Mahogany Wood Trunk";		hue = "mahogany";								break;
					case 11:	box.ItemID = Utility.RandomList( 0x2813, 0x2814 );	box.GumpID = 0x10D;	box.Name = "Drift Wood Trunk";			hue = "driftwood";								break;
				}
				box.Hue = MaterialInfo.GetMaterialColor( hue, "", box.Hue );
			}
			else if ( myBox == 5 )
			{
				nContainerLockable = 5;
				box.Locked = false;
				box.ItemID = Utility.RandomList( 0x9AA, 0xE7D );	box.GumpID = 0x43;		box.Name = "Wooden Box";			box.Hue = 0x83E;
				switch( Utility.Random( 20 ) )
				{
					case 0:		box.ItemID = Utility.RandomList( 0x9AA, 0xE7D );	box.GumpID = 0x43;	box.Name = "Worn Wooden Box";		box.Hue = Utility.RandomMinMax( 2413, 2430 );	break;
					case 1:		box.ItemID = Utility.RandomList( 0x9AA, 0xE7D );	box.GumpID = 0x43;	box.Name = "Oak Wood Box";			hue = "oak";									break;
					case 2:		box.ItemID = Utility.RandomList( 0x9AA, 0xE7D );	box.GumpID = 0x43;	box.Name = "Ash Wood Box";			hue = "ash";									break;
					case 3:		box.ItemID = Utility.RandomList( 0x9AA, 0xE7D );	box.GumpID = 0x43;	box.Name = "Cherry Wood Box";		hue = "cherry";									break;
					case 4:		box.ItemID = Utility.RandomList( 0x9AA, 0xE7D );	box.GumpID = 0x43;	box.Name = "Walnut Wood Box";		hue = "walnut";									break;
					case 5:		box.ItemID = Utility.RandomList( 0x9AA, 0xE7D );	box.GumpID = 0x43;	box.Name = "Golden Oak Wood Box";	hue = "golden oak";								break;
					case 6:		box.ItemID = Utility.RandomList( 0x9AA, 0xE7D );	box.GumpID = 0x43;	box.Name = "Ebony Wood Box";		hue = "ebony";									break;
					case 7:		box.ItemID = Utility.RandomList( 0x9AA, 0xE7D );	box.GumpID = 0x43;	box.Name = "Hickory Wood Box";		hue = "hickory";								break;
					case 8:		box.ItemID = Utility.RandomList( 0x9AA, 0xE7D );	box.GumpID = 0x43;	box.Name = "Pine Wood Box";			hue = "pine";									break;
					case 9:		box.ItemID = Utility.RandomList( 0x9AA, 0xE7D );	box.GumpID = 0x43;	box.Name = "Rosewood Box";			hue = "rosewood";								break;
					case 10:	box.ItemID = Utility.RandomList( 0x9AA, 0xE7D );	box.GumpID = 0x43;	box.Name = "Mahogany Wood Box";		hue = "mahogany";								break;
					case 11:	box.ItemID = Utility.RandomList( 0x9AA, 0xE7D );	box.GumpID = 0x43;	box.Name = "Drift Wood Box";		hue = "driftwood";								break;
				}
				box.Hue = MaterialInfo.GetMaterialColor( hue, "", box.Hue );
			}
			else if ( myBox == 6 )
			{
				nContainerLockable = 6;
				box.Weight = 10.0;
				box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Metal Box";			box.Hue = 0x835;
				switch( Utility.Random( 30 ) )
				{
					case 0:		box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Rusty Metal Box";		box.Hue = Utility.RandomMinMax( 2413, 2430 );	break;
					case 1:		box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Dull Copper Box";		hue = "dull copper";							break;
					case 2:		box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Shadow Iron Box";		hue = "shadow iron";							break;
					case 3:		box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Copper Box";			hue = "copper";									break;
					case 4:		box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Bronze Box";			hue = "bronze";									break;
					case 5:		box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Golden Box";			hue = "gold";									break;
					case 6:		box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Agapite Box";			hue = "agapite";								break;
					case 7:		box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Verite Box";			hue = "verite";									break;
					case 8:		box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Valorite Box";			hue = "valorite";								break;
					case 9:		box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Emerald Box";			hue = "emerald";								break;
					case 10:	box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Jade Box";				hue = "jade";									break;
					case 11:	box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Onyx Box";				hue = "onyx";									break;
					case 12:	box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Ruby Box";				hue = "ruby";									break;
					case 13:	box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Sapphire Box";			hue = "sapphire";								break;
					case 14:	box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Obsidian Box";			hue = "obsidian";								break;
					case 15:	box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Nepturite Box";			hue = "nepturite";								break;
					case 16:	box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Steel Box";				hue = "steel";									break;
					case 17:	box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Brass Box";				hue = "brass";									break;
					case 18:	box.ItemID = Utility.RandomList( 0x9A8, 0xE80 );	box.GumpID = 0x4B;		box.Name = "Mithril Box";			hue = "mithril";								break;
				}
				box.Hue = MaterialInfo.GetMaterialColor( hue, "classic", box.Hue );
			}
			else if ( myBox == 7 )
			{
				nContainerLockable = 7;
				box.Weight = 2.0;
				box.Locked = false;
				box.ItemID = 0xE76;								box.GumpID = 0x3D;		box.Name = "Leather Bag";			box.Hue = Utility.RandomMinMax( 2401, 2430 );
				switch( Utility.Random( 20 ) )
				{
					case 0:		box.ItemID = 0xE76;								box.GumpID = 0x3D;		box.Name = "Deep Sea Leather Bag";	hue = "deep sea";									break;
					case 1:		box.ItemID = 0xE76;								box.GumpID = 0x3D;		box.Name = "Lizard Leather Bag";	hue = "lizard";										break;
					case 2:		box.ItemID = 0xE76;								box.GumpID = 0x3D;		box.Name = "Serpent Leather Bag";	hue = "serpent";									break;
					case 3:		box.ItemID = 0xE76;								box.GumpID = 0x3D;		box.Name = "Unicorn Skin Bag";		hue = "deep";										break;
					case 4:		box.ItemID = 0xE76;								box.GumpID = 0x3D;		box.Name = "Demon Skin Bag";		hue = "hellish";									break;
					case 5:		box.ItemID = 0xE76;								box.GumpID = 0x3D;		box.Name = "Dragon Skin Bag";		hue = "draconic";									break;
					case 6:		box.ItemID = 0xE76;								box.GumpID = 0x3D;		box.Name = "Serpent Skin Bag";		hue = "serpent";									break;
					case 7:		box.ItemID = 0xE76;								box.GumpID = 0x3D;		box.Name = "Necrotic Skin Bag";		hue = "necrotic";									break;
					case 8:		box.ItemID = 0xE76;								box.GumpID = 0x3D;		box.Name = "Volcanic Skin Bag";		hue = "volcanic";									break;
					case 9:		box.ItemID = 0xE76;								box.GumpID = 0x3D;		box.Name = "Frozen Skin Bag";		hue = "frozen";										break;
					case 10:	box.ItemID = 0xE76;								box.GumpID = 0x3D;		box.Name = "Goliath Skin Bag";		hue = "goliath";									break;
					case 11:	box.ItemID = 0xE76;								box.GumpID = 0x3D;		box.Name = "Dinosaur Skin Bag";		hue = "dinosaur";									break;
				}
				box.Hue = MaterialInfo.GetMaterialColor( hue, "", box.Hue );
			}
			else if ( myBox == 8 )
			{
				nContainerLockable = 8;
				box.Weight = 3.0;
				box.Locked = false;
				box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x3C;		box.Name = "Leather Backpack";			box.Hue = Utility.RandomMinMax( 2401, 2430 );
				switch( Utility.Random( 26 ) )
				{
					case 0:		box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x415;	box.Name = "Deep Sea Leather Backpack";	hue = "deep sea";								break;
					case 1:		box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x415;	box.Name = "Lizard Leather Backpack";	hue = "lizard";									break;
					case 2:		box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x415;	box.Name = "Serpent Leather Backpack";	hue = "serpent";								break;
					case 3:		box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x416;	box.Name = "Unicorn Fur Backpack";		hue = "unicorn skin";							break;
					case 4:		box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x417;	box.Name = "Hellish Skin Backpack";		hue = "hellish";								break;
					case 5:		box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x415;	box.Name = "Dragon Skin Backpack";		hue = "draconic";								break;
					case 6:		box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x41B;	box.Name = "Nightmare Skin Backpack";	hue = "nightmare skin";							break;
					case 7:		box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x415;	box.Name = "Troll Skin Backpack";		hue = "troll skin";								break;
					case 8:		box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x417;	box.Name = "Human Flesh Backpack";		hue = "dead skin";								break;
					case 9:		box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x418;	box.Name = "Bloody Backpack";			box.Hue = 0x4AA;								break;
					case 10:	box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x41B;	box.Name = "Thieves Backpack";			box.Hue = 0x497;								break;
					case 11:	box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x416;	box.Name = "Polar Bear Fur Backpack";	box.Hue = 0x47E;								break;
					case 12:	box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x416;	box.Name = "Yeti Fur Backpack";			box.Hue = 0x47E;								break;
					case 13:	box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x41C;	box.Name = "Wizard Backpack";			box.Hue = 0x6E4;								break;
					case 14:	box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x41A;	box.Name = "Druid Backpack";			box.Hue = 0x58B;								break;
					case 15:	box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x419;	box.Name = "Necromancer Backpack";		box.Hue = 0x497;								break;
					case 16:	box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x415;	box.Name = "Necrotic Leather Backpack";	hue = "necrotic";								break;
					case 17:	box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x415;	box.Name = "Volcanic Leather Backpack";	hue = "volcanic";								break;
					case 18:	box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x415;	box.Name = "Frozen Leather Backpack";	hue = "frozen";									break;
					case 19:	box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x415;	box.Name = "Goliath Leather Backpack";	hue = "goliath";								break;
					case 20:	box.ItemID = Utility.RandomList( 0xE75, 0x9B2 );	box.GumpID = 0x415;	box.Name = "Dinosaur Leather Backpack";	hue = "dinosaur";								break;
				}
				box.Hue = MaterialInfo.GetMaterialColor( hue, "", box.Hue );
			}
			else if ( myBox == 9 )
			{
				nContainerLockable = 9;
				box.Weight = 10.0;
				box.Locked = false;
				box.ItemID = Utility.RandomList( 0xE3D, 0xE3C );	box.GumpID = 0x44;		box.Name = "Wooden Crate";			box.Hue = Utility.RandomMinMax( 2413, 2430 );
				switch( Utility.Random( 20 ) )
				{
					case 0:		box.ItemID = Utility.RandomList( 0xE3D, 0xE3C );	box.GumpID = 0x44;		box.Name = "Worn Wooden Crate";			box.Hue = Utility.RandomMinMax( 2413, 2430 );	break;
					case 1:		box.ItemID = Utility.RandomList( 0xE3D, 0xE3C );	box.GumpID = 0x44;		box.Name = "Oak Wood Crate";			hue = "oak";									break;
					case 2:		box.ItemID = Utility.RandomList( 0xE3D, 0xE3C );	box.GumpID = 0x44;		box.Name = "Ash Wood Crate";			hue = "ash";									break;
					case 3:		box.ItemID = Utility.RandomList( 0xE3D, 0xE3C );	box.GumpID = 0x44;		box.Name = "Cherry Wood Crate";			hue = "cherry";									break;
					case 4:		box.ItemID = Utility.RandomList( 0xE3D, 0xE3C );	box.GumpID = 0x44;		box.Name = "Walnut Wood Crate";			hue = "walnut";									break;
					case 5:		box.ItemID = Utility.RandomList( 0xE3D, 0xE3C );	box.GumpID = 0x44;		box.Name = "Golden Oak Wood Crate";		hue = "golden oak";								break;
					case 6:		box.ItemID = Utility.RandomList( 0xE3D, 0xE3C );	box.GumpID = 0x44;		box.Name = "Ebony Wood Crate";			hue = "ebony";									break;
					case 7:		box.ItemID = Utility.RandomList( 0xE3D, 0xE3C );	box.GumpID = 0x44;		box.Name = "Hickory Wood Crate";		hue = "hickory";								break;
					case 8:		box.ItemID = Utility.RandomList( 0xE3D, 0xE3C );	box.GumpID = 0x44;		box.Name = "Pine Wood Crate";			hue = "pine";									break;
					case 9:		box.ItemID = Utility.RandomList( 0xE3D, 0xE3C );	box.GumpID = 0x44;		box.Name = "Rosewood Crate";			hue = "rosewood";								break;
					case 10:	box.ItemID = Utility.RandomList( 0xE3D, 0xE3C );	box.GumpID = 0x44;		box.Name = "Mahogany Wood Crate";		hue = "mahogany";								break;
					case 11:	box.ItemID = Utility.RandomList( 0xE3D, 0xE3C );	box.GumpID = 0x44;		box.Name = "Drift Wood Crate";			hue = "driftwood";								break;
				}
				box.Hue = MaterialInfo.GetMaterialColor( hue, "", box.Hue );
			}
			else if ( myBox == 10 )
			{
				nContainerLockable = 10;
				box.Weight = 8.0;
				box.Locked = false;
				box.ItemID = Utility.RandomList( 0xE3F, 0xE3E );	box.GumpID = 0x44;		box.Name = "Wooden Crate";			box.Hue = Utility.RandomMinMax( 2413, 2430 );
				switch( Utility.Random( 13 ) )
				{
					case 0:		box.ItemID = Utility.RandomList( 0xE3F, 0xE3E );	box.GumpID = 0x44;		box.Name = "Worn Wooden Crate";			box.Hue = Utility.RandomMinMax( 2413, 2430 );	break;
					case 1:		box.ItemID = Utility.RandomList( 0xE3F, 0xE3E );	box.GumpID = 0x44;		box.Name = "Oak Wood Crate";			hue = "oak";									break;
					case 2:		box.ItemID = Utility.RandomList( 0xE3F, 0xE3E );	box.GumpID = 0x44;		box.Name = "Ash Wood Crate";			hue = "ash";									break;
					case 3:		box.ItemID = Utility.RandomList( 0xE3F, 0xE3E );	box.GumpID = 0x44;		box.Name = "Cherry Wood Crate";			hue = "cherry";									break;
					case 4:		box.ItemID = Utility.RandomList( 0xE3F, 0xE3E );	box.GumpID = 0x44;		box.Name = "Walnut Wood Crate";			hue = "walnut";									break;
					case 5:		box.ItemID = Utility.RandomList( 0xE3F, 0xE3E );	box.GumpID = 0x44;		box.Name = "Golden Oak Wood Crate";		hue = "golden oak";								break;
					case 6:		box.ItemID = Utility.RandomList( 0xE3F, 0xE3E );	box.GumpID = 0x44;		box.Name = "Ebony Wood Crate";			hue = "ebony";									break;
					case 7:		box.ItemID = Utility.RandomList( 0xE3F, 0xE3E );	box.GumpID = 0x44;		box.Name = "Hickory Wood Crate";		hue = "hickory";								break;
					case 8:		box.ItemID = Utility.RandomList( 0xE3F, 0xE3E );	box.GumpID = 0x44;		box.Name = "Pine Wood Crate";			hue = "pine";									break;
					case 9:		box.ItemID = Utility.RandomList( 0xE3F, 0xE3E );	box.GumpID = 0x44;		box.Name = "Rosewood Crate";			hue = "rosewood";								break;
					case 10:	box.ItemID = Utility.RandomList( 0xE3F, 0xE3E );	box.GumpID = 0x44;		box.Name = "Mahogany Wood Crate";		hue = "mahogany";								break;
					case 11:	box.ItemID = Utility.RandomList( 0xE3F, 0xE3E );	box.GumpID = 0x44;		box.Name = "Drift Wood Crate";			hue = "driftwood";								break;
				}
				box.Hue = MaterialInfo.GetMaterialColor( hue, "", box.Hue );
            }
			else if ( myBox == 11 )
			{
				nContainerLockable = 11;
				box.Weight = 25.0;
				box.Locked = false;
				box.ItemID = 0xFAE;	box.GumpID = 0x3E;		box.Name = "Barrel";
				switch( Utility.Random( 13 ) )
				{
					case 0:		box.Name = "Worn Wooden Barrel";		box.Hue = Utility.RandomMinMax( 2413, 2430 );	break;
					case 1:		box.Name = "Oak Wood Barrel";			hue = "oak";									break;
					case 2:		box.Name = "Ash Wood Barrel";			hue = "ash";									break;
					case 3:		box.Name = "Cherry Wood Barrel";		hue = "cherry";									break;
					case 4:		box.Name = "Walnut Wood Barrel";		hue = "walnut";									break;
					case 5:		box.Name = "Golden Oak Wood Barrel";	hue = "golden oak";								break;
					case 6:		box.Name = "Ebony Wood Barrel";			hue = "ebony";									break;
					case 7:		box.Name = "Hickory Wood Barrel";		hue = "hickory";								break;
					case 8:		box.Name = "Pine Wood Barrel";			hue = "pine";									break;
					case 9:		box.Name = "Rosewood Barrel";			hue = "rosewood";								break;
					case 10:	box.Name = "Mahogany Wood Barrel";		hue = "mahogany";								break;
					case 11:	box.Name = "Drift Wood Barrel";			hue = "driftwood";								break;
				}
				box.Hue = MaterialInfo.GetMaterialColor( hue, "", box.Hue );
            }
			else if ( myBox == 12 )
			{
				nContainerLockable = 12;
				thisHue = 0;
				box.Weight = 25.0;
				box.Locked = false;
				box.ItemID = Utility.RandomMinMax( 19290, 19371 );
					if ( box.ItemID > 19357 ){ box.Hue = Server.Misc.RandomThings.GetRandomColor( 0 ); }
				box.GumpID = 0x3C;
				box.Name = GetOwner( "Corpse" );
            }
			else if ( myBox == 13 )
			{
				nContainerLockable = 13;
				box.Weight = 20.0;
				box.Locked = false;
				box.ItemID = Utility.RandomList( 0x1AFC, 0x1AFD, 0x1AFE, 0x1AFF, 0x398B, 0x39A2 );
				box.GumpID = 0x13B1;

				switch( Utility.Random( 2 ) )
				{
					case 0:		box.Name = "Urn";	break;
					case 1:		box.Name = "Vase";	break;
				}

				switch( Utility.Random( 12 ) )
				{
					case 0:		/* Plain */		break;
					case 1:		box.Name = "Dull Copper Stone " + box.Name;		hue = "dull copper";	break;
					case 2:		box.Name = "Shadow Iron Stone " + box.Name;		hue = "shadow iron";	break;
					case 3:		box.Name = "Copper Stone " + box.Name;			hue = "copper";			break;
					case 4:		box.Name = "Bronze Stone " + box.Name;			hue = "bronze";			break;
					case 5:		box.Name = "Gold Stone " + box.Name;			hue = "gold";			break;
					case 6:		box.Name = "Agapite Stone " + box.Name;			hue = "agapite";		break;
					case 7:		box.Name = "Verite Stone " + box.Name;			hue = "verite";			break;
					case 8:		box.Name = "Valorite Stone " + box.Name;		hue = "valorite";		break;
					case 9:		box.Name = "Nepturite Stone " + box.Name;		hue = "nepturite";		break;
					case 10:	box.Name = "Obsidian Stone " + box.Name;		hue = "obsidian";		break;
					case 11:	box.Name = "Mithril Stone " + box.Name;			hue = "mithril";		break;
				}
				box.Hue = MaterialInfo.GetMaterialColor( hue, "classic", box.Hue );
            }
			else if ( myBox == 14 )
			{
				nContainerLockable = 14;
				box.Locked = false;

				if ( Utility.Random( 4 ) == 1 )
				{
					box.Weight = 100.0;
					box.ItemID = Utility.RandomList( 0x27E0, 0x280A, 0x2802, 0x2803 );
					box.GumpID = 0x1D;
					box.Name = "Sarcophagus";

					switch( Utility.Random( 12 ) )
					{
						case 0:		/* Plain */		break;
						case 1:		box.Name = "Dull Copper Stone Sarcophagus";		hue = "dull copper";	break;
						case 2:		box.Name = "Shadow Iron Stone Sarcophagus";		hue = "shadow iron";	break;
						case 3:		box.Name = "Copper Stone Sarcophagus";			hue = "copper";			break;
						case 4:		box.Name = "Bronze Stone Sarcophagus";			hue = "bronze";			break;
						case 5:		box.Name = "Gold Stone Sarcophagus";			hue = "gold";			break;
						case 6:		box.Name = "Agapite Stone Sarcophagus";			hue = "agapite";		break;
						case 7:		box.Name = "Verite Stone Sarcophagus";			hue = "verite";			break;
						case 8:		box.Name = "Valorite Stone Sarcophagus";		hue = "valorite";		break;
						case 9:		box.Name = "Nepturite Stone Sarcophagus";		hue = "nepturite";		break;
						case 10:	box.Name = "Obsidian Stone Sarcophagus";		hue = "obsidian";		break;
						case 11:	box.Name = "Mithril Stone Sarcophagus";			hue = "mithril";		break;
					}
					box.Hue = MaterialInfo.GetMaterialColor( hue, "classic", box.Hue );
				}
				else
				{
					box.Weight = 25.0;
					box.ItemID = Utility.RandomList( 0x2800, 0x2801, 0x27E9, 0x27EA );
					box.GumpID = 0x41D;

					string coffin = "Coffin";
						if ( box.ItemID == 0x27E9 || box.ItemID == 0x27EA ){ coffin = "Casket"; }

					box.Name = coffin;

					switch( Utility.Random( 13 ) )
					{
						case 0:		box.Name = "Worn " + coffin;			box.Hue = Utility.RandomMinMax( 2413, 2430 );	break;
						case 1:		box.Name = "Oak " + coffin;				hue = "oak";									break;
						case 2:		box.Name = "Ash " + coffin;				hue = "ash";									break;
						case 3:		box.Name = "Cherry " + coffin;			hue = "cherry";									break;
						case 4:		box.Name = "Walnut " + coffin;			hue = "walnut";									break;
						case 5:		box.Name = "Golden Oak " + coffin;		hue = "golden oak";								break;
						case 6:		box.Name = "Ebony " + coffin;			hue = "ebony";									break;
						case 7:		box.Name = "Hickory " + coffin;			hue = "hickory";								break;
						case 8:		box.Name = "Pine " + coffin;			hue = "pine";									break;
						case 9:		box.Name = "Rosewood " + coffin;		hue = "rosewood";								break;
						case 10:	box.Name = "Mahogany " + coffin;		hue = "mahogany";								break;
						case 11:	box.Name = "Driftwood " + coffin;		hue = "driftwood";								break;
					}
					box.Hue = MaterialInfo.GetMaterialColor( hue, "", box.Hue );
				}
            }
			else if ( myBox == 15 )
			{
				nContainerLockable = 15;
				box.Weight = 100.0;
				box.Locked = false;
				box.Movable = false;
				box.ItemID = Utility.RandomList( 0x2299, 0x229A, 0x229B, 0x229C, 0x229D, 0x229E, 0x229F, 0x22A0 );
				box.GumpID = 0x21;

				box.Name = "Boat";

				switch( Utility.Random( 6 ) )
				{
					case 0:		/* Plain */		break;
					case 1:		box.Name = "Abandoned " + box.Name;		break;
					case 2:		box.Name = "Deserted " + box.Name;		break;
					case 3:		box.Name = "Discarded " + box.Name;		break;
					case 4:		box.Name = "Lost " + box.Name;			break;
					case 5:		box.Name = "Adrift " + box.Name;		break;
				}
            }
			else if ( myBox == 16 )
			{
				nContainerLockable = 16;
				box.Weight = 10.0;
				box.Locked = false;
				box.ItemID = Utility.RandomList( 0x281D, 0x281E );	box.GumpID = 0x2810;		box.Name = "Stone Coffer";			box.Hue = 0;
				switch( Utility.Random( 5 ) )
				{
					case 0:		box.ItemID = Utility.RandomList( 0x281D, 0x281E );	box.Name = "Stone Coffer";				break;
					case 1:		box.ItemID = Utility.RandomList( 0x281F, 0x2820 );	box.Name = "Stone Chest";				break;
					case 2:		box.ItemID = Utility.RandomList( 0x2821, 0x2822 );	box.Name = "Stone Chest";				break;
					case 3:		box.ItemID = Utility.RandomList( 0x2825, 0x2826 );	box.Name = "Stone Strongbox";			break;
					case 4:		box.ItemID = Utility.RandomList( 0x2823, 0x2824 );	box.Name = "Stone Chest";				break;
				}
				switch( Utility.Random( 12 ) )
				{
					case 1:		box.Name = "Dull Copper " + box.Name;	hue = "dull copper";	break;
					case 2:		box.Name = "Shadow Iron " + box.Name;	hue = "shadow iron";	break;
					case 3:		box.Name = "Copper " + box.Name;		hue = "copper";			break;
					case 4:		box.Name = "Bronze " + box.Name;		hue = "bronze";			break;
					case 5:		box.Name = "Gold " + box.Name;			hue = "gold";			break;
					case 6:		box.Name = "Agapite " + box.Name;		hue = "agapite";		break;
					case 7:		box.Name = "Verite " + box.Name;		hue = "verite";			break;
					case 8:		box.Name = "Valorite " + box.Name;		hue = "valorite";		break;
					case 9:		box.Name = "Nepturite " + box.Name;		hue = "nepturite";		break;
					case 10:	box.Name = "Obsidian " + box.Name;		hue = "obsidian";		break;
					case 11:	box.Name = "Mithril " + box.Name;		hue = "mithril";		break;
				}
				box.Hue = MaterialInfo.GetMaterialColor( hue, "classic", box.Hue );
			}
			else if ( myBox == 17 )
			{
				nContainerLockable = 17;
				thisHue = 0;
				box.Weight = 25.0;
				box.Locked = false;
				box.ItemID = Utility.RandomList( 0x3564, 0x3565, 0x3582, 0x3583, 0x35AD, 0x3868 );
				box.GumpID = 0x3C;
				box.Name = GetOwner( "Corpse" );

				string body = "corpse";
				switch( Utility.Random( 7 ) )
				{
					case 1: body = "remains"; break;
					case 2: body = "body"; break;
					case 3: body = "carcass"; break;
					case 4: body = "cadaver"; break;
					case 5: body = "corpse"; break;
					case 6: body = "body"; break;
				}

				if ( box.ItemID == 0x3564 || box.ItemID == 0x3565 )
				{ 

					string broke = "broken";
					switch( Utility.Random( 10 ) )
					{
						case 1: broke = "busted"; break;
						case 2: broke = "crippled"; break;
						case 3: broke = "crumbled"; break;
						case 4: broke = "crushed"; break;
						case 5: broke = "damaged"; break;
						case 6: broke = "defective"; break;
						case 7: broke = "demolished"; break;
						case 8: broke = "mangled"; break;
						case 9: broke = "smashed"; break;
					}

					box.Name = broke + " " + Server.Misc.RandomThings.GetRandomRobot(0);
				}
				else if ( box.ItemID == 0x3582 || box.ItemID == 0x3583 )
				{
					box.Name = body + " of an alien";
				}
				else
				{
					box.Name = body + " of a mutant";
				}
            }
			else
			{
				nContainerLockable = 18;
				box.Weight = 10.0;
				box.ItemID = Utility.RandomList( 0x10EA, 0x10EB, 0x10EC, 0x10ED );

				string sMetal = Server.Misc.MorphingTime.GetSpaceAceMetalName();
				box.Hue = Server.Misc.MaterialInfo.GetSpaceAceColors( sMetal );

				box.GumpID = 0x976;
				box.Name = sMetal + " Cargo Container";
			}

			if ( thisHue > 0 ){ box.Hue = thisHue; }
			if ( thisGump > 0 ){ box.GumpID = thisGump; }

			if ( thisDesign == 1 )
			{
				switch( Utility.Random( 7 ) )
				{
					case 0:		box.Name = "Frosted";	break;
					case 1:		box.Name = "Cold";		break;
					case 2:		box.Name = "Frozen";	break;
					case 3:		box.Name = "Iced";		break;
					case 4:		box.Name = "Chilled";	break;
					case 5:		box.Name = "Icy";		break;
					case 6:		box.Name = "Iced";		break;
				}
				box.Hue = Utility.RandomList( 0x47E, 0x47F, 0x481, 0x482, 0x48D, 0x9C2 );
				if ( myBox == 1 ){ box.Name = box.Name + " Wooden Chest"; }
				else if ( myBox == 2 ){ box.Name = box.Name + " Metal Chest"; }
				else if ( myBox == 3 ){ box.Name = box.Name + " Wooden Footlocker"; }
				else if ( myBox == 4 ){ box.Name = box.Name + " Wooden Trunk"; }
				else if ( myBox == 5 ){ box.Name = box.Name + " Wooden Box"; }
				else if ( myBox == 6 ){ box.Name = box.Name + " Metal Box"; }
				else if ( myBox == 7 ){ box.Name = box.Name + " Leather Bag"; }
				else if ( myBox == 8 ){ box.Name = box.Name + " Leather Backpack"; }
				else if ( myBox == 9 ){ box.Name = box.Name + " Wooden Crate"; }
				else if ( myBox == 10 ){ box.Name = box.Name + " Wooden Crate"; }
				else if ( myBox == 11 ){ box.Name = box.Name + " Wooden Barrel"; }
				else if ( myBox == 13 ){ box.Name = box.Name + " Urn"; if ( Utility.RandomBool() ){ box.Name = box.Name + " Vase"; } }
				else if ( myBox == 14 )
				{
					box.Name = box.Name + " Coffin";
					if ( box.ItemID == 0x27E0 || box.ItemID == 0x280A || box.ItemID == 0x2802 || box.ItemID == 0x2803 ){ box.Name = box.Name + " Sarcophagus"; }
					if ( box.ItemID == 0x27E9 || box.ItemID == 0x27EA ){ box.Name = box.Name + " Casket"; }
				}
			}
			else if ( thisDesign == 6 )
			{
				switch( Utility.Random( 6 ) )
				{
					case 0:		box.Name = "Hellish";	break;
					case 1:		box.Name = "Hot";		break;
					case 2:		box.Name = "Searing";	break;
					case 3:		box.Name = "Scalding";	break;
					case 4:		box.Name = "Blazing";	break;
					case 5:		box.Name = "Burning";	break;
				}
				box.Hue = Utility.RandomOrangeHue();
				if ( myBox == 2 ){ box.Name = box.Name + " Metal Chest"; }
				else if ( myBox == 6 ){ box.Name = box.Name + " Metal Box"; }
			}

			return nContainerLockable;
		}

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		public static string GetOwner( string box )
		{
			string sName0 = "";
			string sName1 = "";
			string sName2 = "";
			string sName3 = "";
			string pName3 = "";

			int nGender = Utility.RandomMinMax( 1, 2 );
			int nNameSection = 0;

			if ( nGender == 1 )
			{
				// MALE TITLES
				string[] vName0 = new string[] {"Templar", "Thief", "Illusionist", "Prince", "Invoker", "Priest", "Conjurer", "Bandit", "Baron", "Wizard", "Cleric", "Monk", "Minstrel", "Defender", "Cavalier", "Magician", "Warlock", "Fighter", "Seeker", "Slayer", "Ranger", "Barbarian", "Explorer", "Heretic", "Gladiator", "Sage", "Rogue", "Paladin", "Bard", "Diviner", "Lord", "Outlaw", "Prophet", "Mercenary", "Adventurer", "Enchanter", "King", "Scout", "Mystic", "Mage", "Traveler", "Summoner", "Warrior", "Sorcerer", "Seer", "Hunter", "Knight", "Necromancer", "Shaman"};
					sName0 = vName0[Utility.RandomMinMax( 0, (vName0.Length-1) )];

				// MALE NAMES
				if (Utility.RandomMinMax( 1, 3 ) == 1)
				{
					nNameSection = 1;
					string[] vName1 = new string[] {"Ache", "Bower", "Dwarf", "Fowl", "Groan", "Kin", "Moat", "Pori", "Rush", "Tort", "Aim", "Churl", "Dwar", "Card", "Haft", "Kit", "Mould", "Quid", "Scoff", "Twig", "Bald", "Com", "Ebb", "Gay", "Hale", "Lank", "Muff", "Rau", "Skew", "Twit", "Bear", "Cuff", "El", "Gilt", "Hawk", "Leaf", "Muse", "Red", "Sky", "Vain", "Blush", "Dark", "Elf", "Girth", "Haught", "Lewd", "Not", "Rich", "Sly", "Vent", "Boar", "Dire", "Fag", "Glut", "Hiss", "Louse", "Numb", "Rob", "Sow", "Vile", "Boast", "Dour", "Fale", "Goad", "Hock", "Lure", "Odd", "Rod", "Stave", "Wail", "Boil", "Dross", "Fay", "Gold", "Hoof", "Man", "Ooze", "Rud", "Steed", "War", "Boni", "Dupe", "Fell", "Gorge", "Hook", "Mars", "Ox", "Ruff", "Swat", "Whip", "Boy", "Dusk", "Fly", "Grey", "Hom", "Meed", "Pale", "Run", "Thor", "Wise", "Wonn", "Yip"};
						sName1 = vName1[Utility.RandomMinMax( 0, (vName1.Length-1) )];

					string[] vName2 = new string[] {"ander", "vid", "thur", "sard", "red", "mund", "lard", "gurd", "fird", "cester", "ard", "vred", "ton", "shan", "rence", "nald", "ley", "gus", "ford", "colt", "bald", "wald", "tor", "shaw", "reth", "nard", "lisle", "ham", "fram", "dane", "ban", "wallader", "tran", "son", "rick", "nath", "loch", "hard", "fred", "dard", "baugh", "ward", "ius", "steen", "ridge", "ney", "man", "hart", "frid", "doch", "bert", "werth", "ulf", "stone", "riel", "olas", "mar", "helm", "fried", "dolph", "brand", "wig", "vald", "ter", "ron", "pold", "mas", "home", "gal", "don", "cas", "win", "van", "than", "rone", "rad", "mon", "isler", "gard", "doric", "cent", "wood", "vard", "ther", "roth", "ram", "mond", "kild", "gemon", "dower", "cent", "yard", "ven", "thon", "sander", "rard", "mour", "ian", "gill", "dred"};
						sName2 = vName2[Utility.RandomMinMax( 0, (vName2.Length-1) )];

					sName3 = sName1 + sName2 + " the " + sName0;
				}
				else
				{
					string[] vName3 = new string[] {"Aaby", "Arkwright", "Blasco", "Dagmar", "Elsdon", "Gladstone", "Hultz", "March", "Prichard", "Theodric", 
					"Aage", "Arlo", "Bledsoe", "Damian", "Elswyth", "Glassford", "Humbert", "Markahm", "Proctor", "Thorburn", 
					"Aanon", "Armand", "Blount", "Damon", "Elton", "Glendower", "Hunter", "Marques", "Pue", "Thordarson", 
					"Aarlen", "Armar", "Bo", "Dana", "Elvin", "Glover", "Hurd", "Marsden", "Pulteney", "Thorkild", 
					"Aart", "Armin", "Bodil", "Danforth", "Elwell", "Glyn", "Hyder", "Marshman", "Purdon", "Thormodr", 
					"Achim", "Armistead", "Boner", "Darrell", "Emory", "Godfrey", "Hynman", "Maxfield", "Pyke", "Thorndike", 
					"Adair", "Armitage", "Booker", "Damn", "Endicott", "Godwin", "Ilo", "Mayhew", "Quan", "Thomwell", 
					"Adalbert", "Acmo", "Booth", "Darvin", "Endrede", "Golding", "Ingholm", "Medart", "Quarles", "Thorold", 
					"Adelsteen", "Arndt", "Boott", "Dashiell", "Endsor", "Goldwin", "Ingram", "Megan", "Quixano", "Thorsager", 
					"Adger", "Arnesen", "Borlace", "Dashwood", "Engelhard", "Goodhue", "Inigo", "Meghnad", "Raban", "Thorvald", 
					"Adin", "Amfinn", "Botho", "Dayyan", "Erard", "Gotthard", "Irial", "Meredith", "Rabindranath", "Thorvaldur", 
					"Adolf", "Arni", "Bourke", "Delevan", "Ercan", "Govier", "Irvin", "Mervyn", "Ragnal", "Throck", 
					"Adoniram", "Arno", "Bowie", "Demarest", "Erdmann", "Govind", "Lsak", "Methuen", "Ragnar", "Tilford", 
					"Adriaan", "Arnold", "Boyd", "Denham", "Eric", "Gowen", "Lsambard", "Midhat", "Raikes", "Tillinghast", 
					"Agathon", "Arnot", "Brace", "Denton", "Erland", "Graham", "Ivor", "Milo", "Ralls", "Tilloch", 
					"Agenor", "Arnulf", "Bracken", "Denzil", "Erie", "Greenleaf", "Izard", "Miner", "Ranald", "Todhunter", 
					"Agidius", "Arnvid", "Branwell", "Derval", "Emald", "Gridley", "Jacoby", "Moffett", "Ranfurly", "Tolbert", 
					"Aidan", "Aron", "Brent", "Dextar", "Eman", "Griffith", "Jagadis", "Monarch", "Ranjan", "Topham", 
					"Aiker", "Apad", "Brion", "Diderik", "Elvin", "Griggs", "Jahverbhai", "Montfort", "Rankin", "Trafford", 
					"Aikman", "Arthol", "Brockden", "Diehl", "Esmond", "Grinling", "Janvel", "Morgan", "Rannulf", "Trelawyn", 
					"Aimo", "Arthur", "Brodhead", "Dighton", "Ethelbert", "Griswold", "Jawaharial", "Morley", "Rattray", "Trick", 
					"Aino", "Artur", "Brodribb", "Dillon", "Ethelred", "Grover", "Jayaprakash", "Mungo", "Redcliffe", "Trigg", 
					"Aitken", "Arvid", "Bronwyn", "Dinham", "Eudo", "Gudmundur", "Jenkin", "Murdo", "Rendel", "Trost", 
					"Aksel", "Arving", "Bror", "Dirk", "Evald", "Guibert", "Jephson", "Murdoch", "Rhys", "Trotwood", 
					"Aladar", "Arvo", "Broun", "Doak", "Evan", "Guido", "Jevan", "Murrough", "Rickard", "Trowbridge", 
					"Alain", "Asaf", "Bruno", "Domhnall", "Evarts", "Gulian", "Jolan", "Mustafa", "Ringgold", "Truesdell", 
					"Alan", "Asgard", "Burkard", "Donagh", "Everard", "Gunnar", "Jotham", "Myrick", "Roach", "Tufnell", 
					"Alanson", "Asget", "Byam", "Donal", "Evert", "Gunning", "Karel", "Nagel", "Roark", "Tunstall", 
					"Alaric", "Ashburton", "Byrne", "Dongal", "Evind", "Gunther", "Kuker", "Natty", "Rockhill", "Turhan", 
					"Alastair", "Ashdown", "Byre", "Doniol", "Ewald", "Gumey", "Kaspar", "Negley", "Rodefer", "Turpin", 
					"Alberich", "Ashur", "Bysshe", "Doral", "Ewen", "Gustav", "Kavalam", "Nesbit", "Roderic", "Tuttle", 
					"Albert", "Askew", "Cabell", "Dom", "Eyulf", "Guthrie", "Kegan", "Nevile", "Roland", "Tylden", 
					"Albin", "Astolphe", "Cadmar", "Dorr", "Eyvind", "Gutzon", "Kelvin", "Newall", "Romer", "Tyrwhitt", 
					"Albion", "Athol", "Cadwallader", "Doud", "Faber", "Gwyn", "Kemble", "Newbold", "Romney", "Uhler", 
					"Albrecht", "Atul", "Cairn", "Dougal", "Fahs", "Gylian", "Kendall", "Newman", "Ronan", "Ulric", 
					"Akan", "Aubrey", "Calbraith", "Doust", "Fairfax", "Haakon", "Kendrick", "Nibbidard", "Root", "Ulrich", 
					"Aldegond", "Aulius", "Calder", "Dragan", "Fairman", "Hablot", "Kenesaw", "Nichol", "Roscoe", "Unwin", 
					"Alden", "August", "Cale", "Dragutin", "Falcon", "Hack", "Kenrick", "Ninian", "Rosskeen", "Upton", 
					"Aldert", "Axel", "Callcott", "Dred", "Falkiner", "Haddon", "Kermit", "Norval", "Roundell", "Usher", 
					"Aldis", "Aylmer", "Calvert", "Drexel", "Fanshaw", "Hagar", "Kevan", "Norvin", "Rucker", "Valdemar", 
					"Aldhelm", "Baget", "Carey", "Duald", "Faraday", "Haigh", "Kian", "Norwood", "Rudyard", "Valerand", 
					"Aldred", "Baird", "Carless", "Duer", "Farquhar", "Halbert", "Kieran", "Oakes", "Rufus", "Vannevar", 
					"Aldrich", "Bal", "Carlyle", "Dugal", "Farwell", "Halcyon", "Kilian", "Obed", "Ruggles", "Vardis", 
					"Aldridge", "Baldor", "Caron", "Dugald", "Feargus", "Haldane", "Kinloch", "Odd", "Rutland", "Varnum", 
					"Aldro", "Balduin", "Carsten", "Dugdale", "Fedor", "Hale", "Kirk", "Odo", "Sacheverall", "Venable", 
					"Aldwerth", "Baldur", "Carvell", "Dunbar", "Feike", "Halfdan", "Kirsopp", "Ogden", "Sackville", "Vicat", 
					"Aldwin", "Balfour", "Caryl", "Dundas", "Felam", "Hallock", "Knud", "Oldham", "Sadler", "Vidkun", 
					"Alec", "Baldwin", "Cashin", "Dunglas", "Fellow", "Hallowell", "Knut", "Olof", "Salmon", "Vilhelm", 
					"Alers", "Dalial", "Cathal", "Dunstan", "Fenwick", "Halvord", "Konrad", "Onslow", "Salter", "Vincas", 
					"Ales", "Ballard", "Chalfant", "Dunwody", "Ferdinand", "Hamlin", "Krishnalai", "Onufrio", "Salwyn", "Vlasta", 
					"Alf", "Balthasard", "Chard", "Dunward", "Fergus", "Hamnel", "Kroh", "Ordway", "Sanfrid", "Vokos", 
					"Alfons", "Bardach", "Chauncey", "Dwarkanath", "Femand", "Hanford", "Krom", "Ormsby", "Sardul", "Volrath", 
					"Alford", "Bardwell", "Chichester", "Dwyer", "Feustmann", "Harald", "Kuno", "Orren", "Sawdon", "Vyner", 
					"Alfred", "Barend", "Chittenden", "Dyce", "Fielding", "Harbaugh", "Kurd", "Orridge", "Scudamore", "Wadleigh", 
					"Algernon", "Barent", "Chlodwig", "Dyer", "Finbar", "Harcourt", "Kurt", "Oswin", "Sechler", "Wager", 
					"Alister", "Baring", "Chrowder", "Dyke", "Findley", "Hardeman", "Kyle", "Otho", "Selig", "Wakeman", 
					"Allard", "Barlow", "Clafin", "Dylan", "Finegan", "Hardwicke", "Lachlan", "Overton", "Selwyn", "Waldegrave", 
					"Allart", "Barnas", "Cleghorn", "Dyneley", "Fingal", "Harkness", "Lamar", "Owain", "Shackerley", "Waldemar", 
					"Alisbone", "Barret", "Clerihew", "Eadweard", "Firozhan", "Harlan", "Langhorne", "Owen", "Shadrach", "Waleran", 
					"Alliston", "Barron", "Clinch", "Eager", "Fitzedward", "Hartpole", "Langston", "Padraic", "Shadworth", "Walford", 
					"Alison", "Barry", "Clipster", "Eamon", "Fitzroy", "Hartwig", "Lanthom", "Paget", "Sibert", "Walsham", 
					"Allvar", "Barstow", "Clopton", "Eanger", "Flinders", "Harwood", "Lardner", "Parr", "Siegfried", "Waring", 
					"Allyn", "Barthel", "Clovis", "Eardley", "Florimund", "Hasket", "Larkin", "Paschal", "Sigfrid", "Wark", 
					"Almer", "Bartle", "Cnud", "Earle", "Flygare", "Hatcher", "Law", "Passmore", "Silvan", "Warrender", 
					"Almeric", "Barton", "Cnul", "Earnest", "Forester", "Havelock", "Ledyard", "Pattabhai", "Slater", "Warwick", 
					"Almroth", "Bayard", "Coolter", "Eastman", "Fothergill", "Hazard", "Legnnd", "Pearsall", "Sligh", "Watt", 
					"Almu", "Beams", "Cael", "Eberhard", "Frederic", "Healdon", "Lenox", "Peffer", "Slingsby", "Wedlake", 
					"Aloysius", "Beck", "Colden", "Eckert", "Fredrik", "Heaslip", "Leofric", "Pejeg", "Smedley", "Wellborn", 
					"Alpheus", "Bede", "Colgan", "Eckhard", "Freeborn", "Hedwig", "Lewellyn", "Pelham", "Southall", "Westcott", 
					"Alphons", "&Om", "Colin", "Ector", "Freeman", "Helm", "Lightfoot", "Penfield", "Sprigg", "Whitwell", 
					"Alsop", "Bengl", "Colon", "Edgar", "Frey", "Helmer", "Lippard", "Penhallow", "Stanwood", "Wideman", 
					"Alton", "Benoist", "Cotton", "Edmond", "Fryniwyd", "Heman", "Liptrot", "Penniman", "Starke", "Wightman", 
					"Alured", "Berean", "Colwyn", "Edmondstone", "Fumifold", "Hendrick", "Littleton", "Penrhyn", "Stedman", "Wildhair", 
					"Alvan", "Bergen", "Conall", "Edric", "Gadsby", "Henrick", "Livermore", "Pepperell", "Stehman", "Wilfrid", 
					"Alvey", "Bern", "Conan", "Edson", "Gaillard", "Hereward", "Llangewellen", "Peregrine", "Stenger", "Wilibald", 
					"Alvord", "Bernhart", "Congal", "Eduard", "Gairdner", "Heron", "Lewellyn", "Perrin", "Steponas", "Willock", 
					"Alvred", "Bernt", "Conlan", "Edwyn", "Galdar", "Heward", "Lockwood", "Persifor", "Sterndale", "Windham", 
					"Alwyn", "Bertil", "Connop", "Efrem", "Gale", "Hickling", "Lorin", "Phanuel", "Stetson", "Winton", 
					"Amadis", "Bertram", "Conor", "Egan", "Garet", "Hildebrand", "Lothrop", "Pharamond", "Stetter", "Woart", 
					"Ames", "Bertran", "Conrad", "Egbert", "Gareth", "Hildreth", "Loudon", "Phallius", "Stilingfleet", "Wolmar", 
					"Amschel", "Bevil", "Conwy", "Egerton", "Garrick", "Hildric", "Lovegood", "Phelim", "Stillman", "Woodfin", 
					"Anatol", "Beylard", "Cormac", "Egon", "Garrott", "Hislop", "Lufkin", "Philo", "Siopford", "Woodruff", 
					"Andrus", "Bhimrao", "Corrowr", "Eglon", "Garth", "Hjalmar", "Lyndon", "Philpot", "Strachan", "Woollgar", 
					"Aneurin", "Bhoskar", "Corry", "Ehrman", "Garvin", "Hjorth", "Lysander", "Phimister", "Stroud", "Worley", 
					"Angus", "Bhupindar", "Corwin", "Eilhard", "Garwood", "Hoadley", "Lytler", "Pickman", "Strudwick", "Wortley", 
					"Ansel", "Bidwell", "Cowan", "Eilif", "Gassaway", "Hobart", "Macallan", "Pigot", "Surridge", "Wycliffe", 
					"Anselm", "Bindon", "Cowden", "Einar", "Gaston", "Hodgdon", "Macaulay", "Pike", "Sulan", "Wyly", 
					"Anson", "Bion", "Cowper", "Eivind", "Gavin", "Hogg", "Macer", "Pinkham", "Svante", "Wynkyn", 
					"Antal", "Bipin", "Craigh", "Elbert", "Gebhard", "Holbrook", "Macklin", "Pinkney", "Svatopluk", "Xanthus", 
					"Anthelme", "Birath", "Cronyn", "Eldon", "Geoffrey", "Holger", "Macvey", "Pinkstone", "Sveinbjom", "Xaver", 
					"Anton", "Birbeck", "Croyble", "Eldred", "Gerard", "Hollister", "Maddem", "Plaisted", "Swain", "Xystus", 
					"Antony", "Birchard", "Crundall", "Eldric", "Cerd", "Hookham", "Maddock", "Plummer", "Swartwout", "Yandell", 
					"Antrim", "Birger", "Culkin", "Eleazar", "Gerhard", "Horton", "Madhao", "Plunkett", "Sydnor", "Yardley", 
					"Anthorp", "Birket", "Cullen", "Elford", "Gerhart", "Howarth", "Magill", "Pollard", "Radeus", "York", 
					"Archibald", "Bjami", "Cullross", "Elhanan", "Gerrard", "Howland", "Mahlon", "Pollock", "Taggart", "Zabdiel", 
					"Ardal", "Bjorn", "Cuthbert", "Eliakim", "Gerrish", "Hrothgar", "Makdougall", "Polycarp", "Tasker", "Zachris", 
					"Arder", "Bjornstem", "Cylarus", "Elinor", "Ghislain", "Hrodnovar", "Malhar", "Pomeroy", "Taurus", "Zadock", 
					"Aretas", "Blackwood", "Eyriel", "Ellingwood", "Gholson", "Hudleston", "Malvin", "Prafulla", "Tell", "Zebulon", 
					"Ariad", "Blaine", "Cyrillus", "Ellwood", "Gibbon", "Huffam", "Manfred", "Pendergast", "Tench", "Zenon", 
					"Arian", "Blair", "Cyryl", "Elrad", "Gildersleeve", "Hulbeart", "Mankey", "Preston", "Thacker", "Zoltan"};
						sName3 = vName3[Utility.RandomMinMax( 0, (vName3.Length-1) )];
						pName3 = sName3;
						sName3 = sName3 + " the " + sName0;

				}
			}
			else
			{
				// FEMALE TITLES
				string[] vName0 = new string[] {"Templar", "Thief", "Illusionist", "Princess", "Invoker", "Priestess", "Conjurer", "Bandit", "Baroness", "Wizard", "Cleric", "Monk", "Minstrel", "Defender", "Cavalier", "Magician", "Witch", "Fighter", "Seeker", "Slayer", "Ranger", "Barbarian", "Explorer", "Heretic", "Gladiator", "Sage", "Rogue", "Paladin", "Bard", "Diviner", "Lady", "Outlaw", "Prophet", "Mercenary", "Adventurer", "Enchantress", "Queen", "Scout", "Mystic", "Mage", "Traveler", "Summoner", "Warrior", "Sorcereress", "Seer", "Hunter", "Knight", "Necromancer", "Shaman"};
					sName0 = vName0[Utility.RandomMinMax( 0, (vName0.Length-1) )];

				// FEMALE NAMES
				if (Utility.RandomMinMax( 1, 3 ) == 1)
				{
					nNameSection = 1;
					string[] vName1 = new string[] {"Angel", "Tru", "Snow", "Rich", "Nag", "Life", "Jade", "Glow", "Foal", "Ewe", "Dale", "Anim", "Tyr", "Soft", "Rose", "Noble", "Love", "Joy", "Gob", "Fond", "Fairy", "Dark", "Bear", "Ven", "Solar", "Rud", "Nob", "Lune", "Just", "Gold", "Free", "Fair", "Dawn", "Bless", "Venus", "Sol", "Sacre", "Pale", "Lynx", "Kind", "Grey", "Fur", "Fate", "Doe", "Blush", "Vile", "Spear", "Seaborn", "Palm", "Mare", "Knife", "Hiss", "Cay", "Fawn", "Doll", "Boni", "Wand", "Star", "Sea", "Peace", "Mead", "Lamb", "Honey", "Gem", "Fay", "Dour", "Bounty", "War", "Sun", "Sil", "Peach", "Mew", "Lass", "Hon", "Gift", "Fau", "Dove", "Boun", "Wave", "Sweet", "Silven", "Pearl", "Mild", "Law", "Honor", "Glad", "Fiend", "Dusk", "Claw", "Wite", "Sword", "Sky", "Queen", "Milk", "Leaf", "Hope", "Glen", "Flaxen", "Eagle", "Cloud", "Wild", "Thor", "Snowy", "Red", "Moon", "Lewd", "Horse", "Glor", "Flax", "Elf", "El"};
						sName1 = vName1[Utility.RandomMinMax( 0, (vName1.Length-1) )];

					string[] vName2 = new string[] {"a", "ula", "sey", "onia", "line", "len", "ethe", "drede", "ata", "anca", "acey", "usia", "silla", "ora", "ly", "ienna", "etta", "een", "berla", "anda", "ache", "va", "sola", "phne", "lyn", "ika", "elle", "elan", "beth", "ance", "ada", "vere", "strella", "reda", "ma", "inda", "farah", "elia", "bia", "anche", "adne", "vette", "sula", "rey", "maid", "is", "garde", "ella", "ca", "andra", "aelia", "vilia", "tho", "rie", "mela", "isa", "genia", "elle", "cella", "ara", "al", "vina", "thia", "rifa", "mina", "itta", "herita", "elot", "cia", "aria", "alia", "vita", "thora", "rina", "mira", "la", "ia", "enlia", "da", "asia", "alie", "wig", "titia", "rine", "nah", "laide", "icenl", "esa", "dicla", "asla", "alia", "wina", "tola", "rota", "natta", "lene", "ie", "esca", "dida", "asta"};
						sName2 = vName2[Utility.RandomMinMax( 0, (vName2.Length-1) )];

					sName3 = sName1 + sName2 + " the " + sName0;
				}
				else
				{
					string[] vName3 = new string[] {"Aasta", "Almira", "Ellin", "Fenella", "Grazia", "Hrefna", "Nada", "Olga", "Sceanb", "Ulrica", 
					"Acadia", "Alvina", "Elmira", "Fial", "Grian", "Hulda", "Nadia", "Oona", "Scena", "Una", 
					"Ada", "Amalina", "Eloisa", "Findbec", "Grima", "Lana", "Natalia", "Orah", "Seang", "Undine", 
					"Adelaide", "Amelia", "Elsa", "Fingalla", "Guida", "Ida", "Nathalia", "Oriana", "Selema", "Unelma", 
					"Adelat", "Amina", "Elsbeth", "Fingel", "Gunila", "Iduna", "Nathalie", "Orlata", "Selena", "Vote", 
					"Adeva", "Anatolia", "Elspeth", "Fiona", "Gwen", "Igraine", "Nedda", "Orsola", "Selene", "Urania", 
					"Adina", "Andri", "Elva", "Francisco", "Gwenda", "Ingeborg", "Nemain", "Osa", "Selina", "Uta", 
					"Afra", "Anika", "Elvina", "Freda", "Gwendolyn", "Ingrid", "Nerbha", "Osk", "Shamira", "Valborg", 
					"Aibell", "Annora", "Emer", "Frederica", "Gwyneth", "Ingunn", "Nessa", "Othilia", "Sharada", "Valda", 
					"Aidin", "Anu", "Emma", "Freya", "Gwynfryd", "Lola", "Nesta", "Ottilia", "Sharman", "Valentia", 
					"Aige", "Ebhla", "Endrede", "Bruna", "Halima", "Milada", "Neva", "Loren", "Sibyl", "Valeria", 
					"Ailbe", "Ebliu", "Eri", "Brunhild", "Halina", "Mina", "Neysa", "Lotta", "Sieglind", "Valeska", 
					"Aileen", "Edda", "Erika", "Byma", "Halla", "Minella", "Neza", "Louisa", "Sigfrid", "Yalisa", 
					"Aille", "Edeva", "Ema", "Carelia", "Halley", "Minna", "Niamh", "Lucia", "Signe", "Varda", 
					"Aimee", "Edina", "Emata", "Carina", "Haninah", "Mira", "Nila", "Lucinda", "Sigrid", "Varina", 
					"Aina", "Edla", "Eslin", "Cathlin", "Hansine", "Miryam", "Nita", "Ludmila", "Silma", "Veda", 
					"Aine", "Edrie", "Estrella", "Cebha", "Heather", "Moina", "Noela", "Luella", "Silvia", "Vema", 
					"Aithne", "Edwina", "Etelka", "Celestine", "Hedda", "Moira", "Nona", "Luna", "Sianan", "Vesta", 
					"Alaine", "Eevin", "Ethelburga", "Cerband", "Hedwig", "Mona", "Nordri", "Lydia", "Siranush", "Veva", 
					"Alastrina", "Eibhir", "Ethelreda", "Cesair", "Helche", "Mora", "Noreen", "Lynn", "Slania", "Vevina", 
					"Creidne", "Eirinn", "Banba", "Charlene", "Maira", "Morgana", "Katrina", "Lyones", "Smirgat", "Vicentia", 
					"Cyrilla", "Eithne", "Beara", "Chloe", "Malvina", "Moriath", "Keavy", "Lyris", "Solevig", "Vida", 
					"Dagmar", "Elaine", "Bebhiolul", "Clarinda", "Mana", "Morna", "Keirn", "Macha", "Stasha", "Vieno", 
					"Dagni", "Electa", "Becuma", "Cliodhna", "Manon", "Morrigan", "Kenin", "Madelon", "Svea", "Viera", 
					"Dagny", "Elfrida", "Belila", "Clothra", "Margery", "Murna", "Keven", "Maeve", "Tacey", "Vigdis", 
					"Daireann", "Elfride", "Belle", "Coela", "Marta", "Myna", "Kristen", "Mafka", "Tadia", "Vilma", 
					"Davnet", "Elfrieda", "Belva", "Cora", "Mathilda", "Myra", "Kristina", "Maga", "Tailtu", "Vinatta", 
					"Dawn", "Elinor", "Serita", "Coral", "Mathilde", "Myrna", "Leila", "Magda", "Tamara", "Viveka", 
					"Dectera", "Elizabetta", "Bema", "Corra", "Maura", "Myrrha", "Leonarda", "Magna", "Latina", "Walda", 
					"Deirdre", "Ella", "Berta", "Credhe", "Mavis", "Naas", "Leta", "Maia", "Tea", "Wertha", 
					"Dervilia", "Arabella", "Beryl", "Frida", "Maya", "Lana", "Liadin", "Palma", "Tekla", "Wilhelmina", 
					"Devra", "Arax", "Birgit", "Gabriela", "Melba", "Lone", "Liana", "Pasca", "Teruah", "Willa", 
					"Dindrane", "Arbha", "Blenda", "Gael", "Melkorka", "Irina", "Liena", "Petra", "Tessa", "Winfrey", 
					"Dionetla", "Areta", "Boann", "Gale", "Melva", "Iman", "Lilly", "Petrea", "Thalia", "Wynne", 
					"Domnu", "Anna", "Breg", "Garmuin", "Mennefer", "Isidora", "Lina", "Petronella", "Thalna", "Xenia", 
					"Dorea", "Anta", "Bri", "Genevieve", "Meredith", "Isolde", "Linnea", "Provida", "Thecla", "Yana", 
					"Drusilla", "Aria", "Bridget", "Gertrude", "Meri", "Isolt", "Livia", "Rae", "Theda", "Yerusha", 
					"Duana", "Arlean", "Brinna", "Gilberta", "Meta", "Ivy", "Llyn", "Ragna", "Theodosia", "Ysolde", 
					"Durfulla", "Ambella", "Brita", "Gilda", "Mignon", "Janna", "Loella", "Ramona", "Thora", "Yvette", 
					"Ebba", "Amthora", "Britannia", "Gilian", "Mila", "Jennifer", "Lola", "Reina", "Thorfinna", "Yvonne", 
					"Alberta", "Arvida", "Eulala", "Ginerva", "Helga", "Jensine", "Norine", "Renata", "Thorunn", "Zahra", 
					"Aida", "Astra", "Evadne", "Giolla", "Helma", "Jillian", "Noma", "Reva", "Thylda", "Zandra", 
					"Alena", "Astrid", "Evaine", "Gladiola", "Helmi", "Jocelyn", "Nova", "Rhona", "Thyra", "Zara", 
					"Alfdis", "Astrild", "Evelina", "Gladys", "Herdis", "Jorunn", "Novita", "Rhonda", "Thyrza", "Zarifa", 
					"Alfreda", "Aud", "Evelyn", "Gleda", "Herma", "Jovena", "Novomira", "Roshena", "Titania", "Zenda", 
					"Alfrida", "Audrey", "Evolyn", "Glida", "Herrat", "Juno", "Nuala", "Rowena", "Trio", "Ziona", 
					"Aline", "Aurora", "Fanchon", "Gotelind", "Hertha", "Karelia", "Nunila", "Rufina", "Triana", "Zita", 
					"Alison", "Avon", "Fand", "Graine", "Hilda", "Karine", "Oda", "Runa", "Tuage", "Zoe", 
					"Allene", "Avril", "Fawn", "Grainne", "Hildegarde", "Karitsa", "Odile", "Sadb", "Uathach", "Zona", 
					"Almas", "Ayame", "Fea", "Crania", "Hortensia", "Katerina", "Odilia", "Samhair", "Ula", "Zora"};
						sName3 = vName3[Utility.RandomMinMax( 0, (vName3.Length-1) )];
						pName3 = sName3;
						sName3 = sName3 + " the " + sName0;
				}
			}

			string[] vAdj = new string[] {"Exotic", "Mysterious", "Marvelous", "Amazing", "Astonishing", "Mystical", "Astounding", "Magnificent", "Phenomenal", "Fantastic", "Incredible", "Extraordinary", "Fabulous", "Wondrous", "Glorious", "Lost", "Fabled", "Legendary", "Mythical", "Missing", "Ancestral", "Ornate", "Wonderful", "Sacred", "Unspeakable", "Unknown", "Forgotten"};
				string sAdj = vAdj[Utility.RandomMinMax( 0, (vAdj.Length-1) )] + " ";

			if ( box == "Pilfer" )
			{
				return sName3;
			}
			else if ( box == "cargo" )
			{
				if ( Utility.RandomBool() )
				{
					sName3 = NameList.RandomName( "female" );
				}
				else
				{
					sName3 = NameList.RandomName( "male" );
				}

				string[] spaceTitles = new string[] {"Mechanic", "Scientist", "Doctor", "Soldier", "Mercenary", "Engineer", "Chief Medical Officer", "Science Officer", "Counselor", "Marine", "Soldier", "Trooper", "Navigator", "Medical Officer", "Officer", "Helmsman", "Gunner", "Pilot", "Weapons Officer", "Tactical Officer", "Biologist", "Chemist", "Security Officer", "Robotics Engineer", "Avionics Engineer", "Chief Engineering", "Chief of Security", "Linguist", "Botanist", "Pathologist", "Anthropologist", "Sociologist", "First Officer", "Logistics Officer", "Nurse"};
					string spaceTitle = spaceTitles[Utility.RandomMinMax( 0, (spaceTitles.Length-1) )];

				return sName3 + " the " + spaceTitle;
			}
			else if ( box == "Sunken" )
			{
				string[] sPirate = new string[] {"Captain", "First Mate", "Quartermaster", "Boatswain", "Sailing Master", "Sea Artist", "Navigator", "Master Gunner", "Gunner", "Sail Maker", "Cabin Boy", "Sailor", "Powder Monkey", "Buccaneer", "Privateer", "Rigger", "Swab"};
				string xPirate = sPirate[Utility.RandomMinMax( 0, (sPirate.Length-1) )];
				if ( nNameSection == 1 ){ sName3 = sName1 + sName2 + " the " + xPirate; } else { sName3 = pName3 + " the " + xPirate; }
				return "The " + sAdj + "Chest of " + sName3;
			}
			else if ( box == "SunkenBag" )
			{
				string[] sPirate = new string[] {"Captain", "First Mate", "Quartermaster", "Boatswain", "Sailing Master", "Sea Artist", "Navigator", "Master Gunner", "Gunner", "Sail Maker", "Cabin Boy", "Sailor", "Powder Monkey", "Buccaneer", "Privateer", "Rigger", "Swab"};
				string xPirate = sPirate[Utility.RandomMinMax( 0, (sPirate.Length-1) )];
				
				if ( Utility.RandomMinMax( 1, 3 ) == 3 ) 
				{
					pName3 = NameList.RandomName( "female" );
				}
				else 
				{ 
					pName3 = NameList.RandomName( "male" ); 
				}

				if ( Utility.RandomMinMax( 1, 3 ) == 3 ) 
				{
					sName3 = pName3 + " the " + sName0;
				}
				else 
				{ 
					sName3 = pName3 + " the " + xPirate;
				}

				return sName3;
			}
			else if ( box == "cargo" )
			{
				string sCorpse = "body";
				switch ( Utility.RandomMinMax( 0, 2 ) ) 
				{
					case 0: sCorpse = "body"; break;
					case 1: sCorpse = "corpse"; break;
					case 2: sCorpse = "remains"; break;
				}
				return "The " + sCorpse + " of " + sName3;
			}
			else if ( box == "Body" )
			{
				sAdj = "";
				string sCorpse = "bones";
				switch ( Utility.RandomMinMax( 0, 3 ) ) 
				{
					case 0: sCorpse = "bones"; break;
					case 1: sCorpse = "body"; break;
					case 2: sCorpse = "skeletal remains"; break;
					case 3: sCorpse = "skeletal bones"; break;
				}
				return "The " + sCorpse + " of " + sName3;
			}
			else if ( box == "BodySailor" )
			{
				sAdj = "";
				string sCorpse = "bones";
				switch ( Utility.RandomMinMax( 0, 3 ) ) 
				{
					case 0: sCorpse = "bones"; break;
					case 1: sCorpse = "body"; break;
					case 2: sCorpse = "skeletal remains"; break;
					case 3: sCorpse = "skeletal bones"; break;
				}
				
				string[] sPirate = new string[] {"Captain", "First Mate", "Quartermaster", "Boatswain", "Sailing Master", "Sea Artist", "Navigator", "Master Gunner", "Gunner", "Sail Maker", "Cabin Boy", "Sailor", "Powder Monkey", "Buccaneer", "Privateer", "Rigger", "Swab"};
				string xPirate = sPirate[Utility.RandomMinMax( 0, (sPirate.Length-1) )];
				
				if ( Utility.RandomMinMax( 1, 3 ) == 3 ) 
				{
					pName3 = NameList.RandomName( "female" );
				}
				else 
				{ 
					pName3 = NameList.RandomName( "male" ); 
				}

				if ( Utility.RandomMinMax( 1, 3 ) == 3 ) 
				{
					sName3 = pName3 + " the " + sName0;
				}
				else 
				{ 
					sName3 = pName3 + " the " + xPirate;
				}

				return "The " + sCorpse + " of " + sName3;
			}
			else if ( box == "Treasure Chest" || box == "property" )
			{
				return sName3;
			}
			else if ( box == "Corpse" )
			{
				sAdj = "";
			}

			return "The " + sAdj + box + " of " + sName3;
		}

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		public static void RelicValueIncrease( int level, Item item )
		{
			double IncreaseValue = 0.2 * level;

			if ( item is DDRelicAlchemy){ DDRelicAlchemy relic = (DDRelicAlchemy)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicArmor){ DDRelicArmor relic = (DDRelicArmor)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicArts){ DDRelicArts relic = (DDRelicArts)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicBearRugsAddon){ DDRelicBearRugsAddon relic = (DDRelicBearRugsAddon)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicBook){ DDRelicBook relic = (DDRelicBook)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicTablet){ DDRelicTablet relic = (DDRelicTablet)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicClock1){ DDRelicClock1 relic = (DDRelicClock1)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicClock2){ DDRelicClock2 relic = (DDRelicClock2)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicClock3){ DDRelicClock3 relic = (DDRelicClock3)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicCloth){ DDRelicCloth relic = (DDRelicCloth)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicDrink){ DDRelicDrink relic = (DDRelicDrink)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicFur){ DDRelicFur relic = (DDRelicFur)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicInstrument){ DDRelicInstrument relic = (DDRelicInstrument)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicJewels){ DDRelicJewels relic = (DDRelicJewels)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicLeather){ DDRelicLeather relic = (DDRelicLeather)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicLight1){ DDRelicLight1 relic = (DDRelicLight1)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicLight2){ DDRelicLight2 relic = (DDRelicLight2)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicLight3){ DDRelicLight3 relic = (DDRelicLight3)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicOrbs){ DDRelicOrbs relic = (DDRelicOrbs)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicPainting){ DDRelicPainting relic = (DDRelicPainting)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicReagent){ DDRelicReagent relic = (DDRelicReagent)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicRugAddonDeed){ DDRelicRugAddonDeed relic = (DDRelicRugAddonDeed)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicScrolls){ DDRelicScrolls relic = (DDRelicScrolls)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicStatue){ DDRelicStatue relic = (DDRelicStatue)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicVase){ DDRelicVase relic = (DDRelicVase)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicWeapon){ DDRelicWeapon relic = (DDRelicWeapon)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicGem){ DDRelicGem relic = (DDRelicGem)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
			else if ( item is DDRelicGrave){ DDRelicGrave relic = (DDRelicGrave)item; relic.RelicGoldValue = (int)(relic.RelicGoldValue * IncreaseValue) + relic.RelicGoldValue; }
		}

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		public static void AddGoldToContainer( int gold, Container box, int zone )
		{
			if ( zone == 1 )
			{
				box.DropItem( new DDXormite( ((int)(gold/3)) ) );
			}
			else if ( zone == 2 )
			{
				box.DropItem( new DDJewels( ((int)(gold/2)) ) );
			}
			else
			{
				int nCoins = gold * 10;
				if (Utility.RandomMinMax( 1, 100 ) > 66)
				{
					int nGp = 10;
					int nGpp = (int)Math.Floor((decimal)(nCoins/nGp));
					if (nGpp > 0)
					{
						int nGold = Utility.RandomMinMax( 1, nGpp );
						box.DropItem( new Gold( nGold ) );
						nCoins = nCoins - (nGold * nGp);
					}
				}
				if (Utility.RandomMinMax( 1, 100 ) > 33)
				{
					int nSp = 5;
					int nSpp = (int)Math.Floor((decimal)(nCoins/nSp));
					if (nSpp > 0)
					{
						int nSilver = Utility.RandomMinMax( 1, nSpp );
						box.DropItem( new DDSilver( nSilver ) );
						nCoins = nCoins - (nSilver * nSp);
					}
				}
				if (nCoins > 0){ box.DropItem( new DDCopper( nCoins ) ); }
			}
		}

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		public static void LootMutate( Mobile opener, int luckChance, Item item, Container box, int level )
		{
			int boxID = 0;
				if ( box != null ){ boxID = box.ItemID; }

			if ( item != null )
			{
				int attributeCount;
				int min, max;
				GetRandomAOSStats( out attributeCount, out min, out max, level );

				if ( item is BaseWeapon || item is BaseArmor || item is BaseJewel || item is BaseHat || item is BaseQuiver )
				{
					if ( item is BaseWeapon )
					{
						Server.Misc.MorphingTime.MakeOrientalItem( item, opener );
						Server.Misc.MorphingTime.ChangeMaterialType( item, opener );
						BaseRunicTool.ApplyAttributesTo( (BaseWeapon)item, attributeCount, min, max );
						if ( !IsSpaceCrate( boxID ) ){ item.Name = LootPackEntry.MagicItemName( item, opener, Region.Find( opener.Location, opener.Map ) ); }
						Server.Misc.MorphingTime.MakeSpaceAceItem( item, opener );
					}
					else if ( item is BaseArmor )
					{
						Server.Misc.MorphingTime.MakeOrientalItem( item, opener );
						Server.Misc.MorphingTime.ChangeMaterialType( item, opener );
						BaseRunicTool.ApplyAttributesTo( (BaseArmor)item, attributeCount, min, max );
						if ( !IsSpaceCrate( boxID ) ){ item.Name = LootPackEntry.MagicItemName( item, opener, Region.Find( opener.Location, opener.Map ) ); }
						Server.Misc.MorphingTime.MakeSpaceAceItem( item, opener );
					}
					else if ( item is BaseJewel )
					{
						Server.Misc.MorphingTime.MakeOrientalItem( item, opener );
						BaseRunicTool.ApplyAttributesTo( (BaseJewel)item, attributeCount, min, max );
						if ( !IsSpaceCrate( boxID ) ){ item.Name = LootPackEntry.MagicItemName( item, opener, Region.Find( opener.Location, opener.Map ) ); }
						Server.Misc.MorphingTime.MakeSpaceAceItem( item, opener );
					}
					else if ( item is BaseQuiver )
					{
						BaseRunicTool.ApplyAttributesTo( (BaseQuiver)item, attributeCount, min, max );
						item.Name = LootPackEntry.MagicItemName( item, opener, Region.Find( opener.Location, opener.Map ) );
					}
					else if ( item is BaseHat )
					{
						Server.Misc.MorphingTime.MakeOrientalItem( item, opener );
						BaseRunicTool.ApplyAttributesTo( (BaseHat)item, attributeCount, min, max );
						if ( !IsSpaceCrate( boxID ) ){ item.Name = LootPackEntry.MagicItemName( item, opener, Region.Find( opener.Location, opener.Map ) ); }
						Server.Misc.MorphingTime.MakeSpaceAceItem( item, opener );
					}
				}
				else if ( item is BaseInstrument )
				{
					if ( Server.Misc.Worlds.IsOnSpaceship( opener.Location, opener.Map ) )
					{
						string newName = "odd alien";
						switch( Utility.RandomMinMax( 0, 6 ) )
						{
							case 0: newName = "odd"; break;
							case 1: newName = "unusual"; break;
							case 2: newName = "bizarre"; break;
							case 3: newName = "curious"; break;
							case 4: newName = "peculiar"; break;
							case 5: newName = "strange"; break;
							case 6: newName = "weird"; break;
						}

						switch( Utility.RandomMinMax( 1, 4 ) )
						{
							case 1: item = new Pipes();		item.Name = newName + " " + Server.Misc.RandomThings.GetRandomAlienRace() + " pipes";		break;
							case 2: item = new Pipes();		item.Name = newName + " " + Server.Misc.RandomThings.GetRandomAlienRace() + " pan flute";	break;
							case 3: item = new Fiddle();	item.Name = newName + " " + Server.Misc.RandomThings.GetRandomAlienRace() + " violin";		break;
							case 4: item = new Fiddle();	item.Name = newName + " " + Server.Misc.RandomThings.GetRandomAlienRace() + " fiddle";		break;
						}

						BaseInstrument lute = (BaseInstrument)item;
							lute.Resource = CraftResource.None;

						item.Hue = Server.Misc.RandomThings.GetRandomColor(0);
					}
					else 
					{
						Server.Misc.MorphingTime.ChangeMaterialType( item, opener );
						Server.Misc.MorphingTime.MakeOrientalItem( item, opener );
						item.Name = LootPackEntry.MagicItemName( item, opener, Region.Find( opener.Location, opener.Map ) );
					}

					BaseRunicTool.ApplyAttributesTo( (BaseInstrument)item, attributeCount, min, max );

					SlayerName slayer = BaseRunicTool.GetRandomSlayer();

					BaseInstrument instr = (BaseInstrument)item;

					int cHue = 0;
					int cUse = 0;

					switch ( instr.Resource )
					{
						case CraftResource.AshTree: cHue = MaterialInfo.GetMaterialColor( "ash", "", 0 ); cUse = 20; break;
						case CraftResource.CherryTree: cHue = MaterialInfo.GetMaterialColor( "cherry", "", 0 ); cUse = 40; break;
						case CraftResource.EbonyTree: cHue = MaterialInfo.GetMaterialColor( "ebony", "", 0 ); cUse = 60; break;
						case CraftResource.GoldenOakTree: cHue = MaterialInfo.GetMaterialColor( "gold", "", 0 ); cUse = 80; break;
						case CraftResource.HickoryTree: cHue = MaterialInfo.GetMaterialColor( "hickory", "", 0 ); cUse = 100; break;
						case CraftResource.MahoganyTree: cHue = MaterialInfo.GetMaterialColor( "mahogany", "", 0 ); cUse = 120; break;
						case CraftResource.DriftwoodTree: cHue = MaterialInfo.GetMaterialColor( "driftwood", "", 0 ); cUse = 120; break;
						case CraftResource.OakTree: cHue = MaterialInfo.GetMaterialColor( "oak", "", 0 ); cUse = 140; break;
						case CraftResource.PineTree: cHue = MaterialInfo.GetMaterialColor( "pine", "", 0 ); cUse = 160; break;
						case CraftResource.RosewoodTree: cHue = MaterialInfo.GetMaterialColor( "rosewood", "", 0 ); cUse = 180; break;
						case CraftResource.WalnutTree: cHue = MaterialInfo.GetMaterialColor( "walnute", "", 0 ); cUse = 200; break;
					}

					instr.UsesRemaining = instr.UsesRemaining + cUse;

					if ( !( Server.Misc.Worlds.IsOnSpaceship( opener.Location, opener.Map ) ) )
					{
						if ( cHue > 0 ){ item.Hue = cHue; }
						else if ( Utility.RandomMinMax( 1, 4 ) == 1 ){ item.Hue = RandomThings.GetRandomColor(0); }
					}

					instr.Quality = InstrumentQuality.Regular;
					if ( Utility.RandomMinMax( 1, 4 ) == 1 ){ instr.Quality = InstrumentQuality.Exceptional; }

					if ( Utility.RandomMinMax( 1, 4 ) == 1 ){ instr.Slayer = slayer; }
				}

				if ( DifficultyLevel.GetUnidentifiedChance() >= Utility.RandomMinMax( 1, 100 ) )
				{
					UnidentifiedItem itemID = new UnidentifiedItem();
					itemID.DropItem(item);
					itemID.ItemID = item.ItemID;
					itemID.Hue = item.Hue;
					itemID.Name = DifficultyLevel.GetOddityAdjective() + " item";
					if ( item is BaseJewel )
					{
						itemID.SkillRequired = "ItemID"; 
						itemID.VendorCanID = "Jeweler";
						if ( item is MagicBelt || item is MagicRobe || item is MagicHat || item is MagicCloak || item is MagicBoots || item is MagicSash ){ itemID.VendorCanID = "Tailor"; }
						else if ( item is MagicTalisman || item is MagicCandle ){ itemID.VendorCanID = "Sage"; }
					}
					else if ( item is BaseHat ){ itemID.SkillRequired = "ItemID"; itemID.VendorCanID = "Tailor"; }
					else if ( item is BaseQuiver ){ itemID.SkillRequired = "ItemID"; itemID.VendorCanID = "Bowyer"; }
					else if ( item is BaseInstrument ){ itemID.SkillRequired = "ItemID"; itemID.VendorCanID = "Bard"; }
					else
					{
						itemID.SkillRequired = "ArmsLore";
						itemID.VendorCanID = "Blacksmith";
						if ( item is BaseArmor )
						{
							if ( Server.Misc.MaterialInfo.IsAnyKindOfClothItem( item ) )
							{
								itemID.VendorCanID = "Leatherworker";
							}
							else if ( Server.Misc.MaterialInfo.IsAnyKindOfWoodItem( item ) )
							{
								itemID.VendorCanID = "Carpenter";
							}
						}
						else if ( item is ThrowingGloves || item is PugilistGloves || item is PugilistGlove ){ itemID.VendorCanID = "Leatherworker"; }
						else if ( item is BaseRanged )
						{
							itemID.VendorCanID = "Bowyer";
						}
						else if ( item is BaseWeapon )
						{
							if ( Server.Misc.MaterialInfo.IsAnyKindOfWoodItem( item ) )
							{
								itemID.VendorCanID = "Carpenter";
							}
						}
					}

					if ( box != null && ( itemID.VendorCanID == "" || itemID.VendorCanID == null ) )
					{
						box.DropItem( item );
						itemID.Delete(); 
					}
					else if ( box != null )
					{
						box.DropItem( itemID );
					}

					if ( itemID.TotalItems < 1 ){ itemID.Delete(); }
				}
				else if ( box != null )
				{
					box.DropItem( item );
				}
			}
		}

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		public static void MakeTomb( LockableContainer box, Mobile m, int tomb )
		{
			box.Locked = false;

			string owner = m.Name;
				if ( m.Title != null && m.Title != "" ){ owner = m.Name + " " + m.Title; }

			if ( ( Utility.Random( 4 ) == 1 || tomb == 1 ) && tomb != 2 )
			{
				box.ItemID = Utility.RandomList( 0x27E0, 0x280A, 0x2802, 0x2803 );
				box.Name = "Sarcophagus of " + owner;
				box.Hue = RandomThings.GetRandomMetalColor();
				box.GumpID = 0x1D;
			}
			else
			{
				box.ItemID = Utility.RandomList( 0x2800, 0x2801, 0x27E9, 0x27EA );
				box.GumpID = 0x41D;

				string coffin = "Coffin";
					if ( box.ItemID == 0x27E9 || box.ItemID == 0x27EA ){ coffin = "Casket"; }

				box.Name = coffin + " of " + owner;
				box.Hue = RandomThings.GetRandomWoodColor();
			}

		}

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		public static void MakeSpaceCrate( LockableContainer box )
		{
			box.ItemID = Utility.RandomList( 0x10EA, 0x10EB, 0x10EC, 0x10ED );

			string sMetal = Server.Misc.MorphingTime.GetSpaceAceMetalName();
			box.Hue = Server.Misc.MaterialInfo.GetSpaceAceColors( sMetal );

			box.GumpID = 0x976;
			box.Name = sMetal + " Cargo Container";
		}

		//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

		public static void GiveRandomItem( Mobile opener )
		{
			Region reg = Region.Find( opener.Location, opener.Map );
			Item loot = null;
			int found = Utility.RandomMinMax( 1, 14 );

			if ( found == 1 )
			{
				loot = DungeonLoot.RandomItem();
				if (loot.Stackable == true){ loot.Amount = Utility.RandomMinMax( 1, 10 ); }
				if ((loot is Arrow) || (loot is Bolt)){ loot.Amount = Utility.RandomMinMax( 5, 20 ); }
			}
			else if ( found == 2 )
			{
				loot = DungeonLoot.RandomWares();

				if ( loot is BaseWoodBoard && Utility.RandomMinMax( 1, 3 ) > 1 && Worlds.IsExploringSeaAreas( opener ) == true ){ loot = new DriftwoodBoard(); }
				else if ( loot is BaseIngot && Utility.RandomMinMax( 1, 3 ) > 1 && Worlds.IsExploringSeaAreas( opener ) == true ){ loot = new NepturiteIngot(); }
				else if ( loot is BaseIngot && Utility.RandomMinMax( 1, 3 ) > 1 && Worlds.GetMyWorld( opener.Map, opener.Location, opener.X, opener.Y ) == "the Serpent Island" ){ loot = new ObsidianIngot(); }
				else if ( loot is BaseLeather && Utility.RandomMinMax( 1, 3 ) > 1 && Worlds.IsExploringSeaAreas( opener ) == true ){ loot = new SpinedLeather(); }
				else if ( loot is BaseIngot && Utility.RandomMinMax( 1, 10 ) == 1 && Worlds.GetMyWorld( opener.Map, opener.Location, opener.X, opener.Y ) == "the Savaged Empire" ){ loot = new SteelIngot(); }
				else if ( loot is BaseLeather && Utility.RandomMinMax( 1, 10 ) == 1 && Worlds.GetMyWorld( opener.Map, opener.Location, opener.X, opener.Y ) == "the Savaged Empire" ){ loot = new DinosaurLeather(); }
				else if ( loot is BaseIngot && Utility.RandomMinMax( 1, 8 ) == 1 && Worlds.GetMyWorld( opener.Map, opener.Location, opener.X, opener.Y ) == "the Island of Umber Veil" ){ loot = new BrassIngot(); }
				else if ( loot is BaseIngot && Utility.RandomMinMax( 1, 8 ) == 1 && Worlds.GetMyWorld( opener.Map, opener.Location, opener.X, opener.Y ) == "the Underworld" && opener.Map == Map.TerMur ){ loot = new XormiteIngot(); }
				else if ( loot is BaseLeather && Utility.RandomMinMax( 1, 8 ) == 1 && Worlds.GetMyWorld( opener.Map, opener.Location, opener.X, opener.Y ) == "the Underworld" && opener.Map == Map.TerMur ){ loot = new AlienLeather(); }
				else if ( loot is BaseIngot && Utility.RandomMinMax( 1, 8 ) == 1 && Worlds.GetMyWorld( opener.Map, opener.Location, opener.X, opener.Y ) == "the Underworld" ){ loot = new MithrilIngot(); }
				else if ((loot is Cloth) || (loot is UncutCloth) || (loot is BoltOfCloth))
				{
					loot.Hue = RandomThings.GetRandomColor(0);

					if ( Utility.RandomBool() )
						loot.Hue = RandomThings.GetRandomSpecialColor();
				}
				else if ( loot is BaseWoodBoard && Utility.RandomMinMax( 1, 10 ) == 1 && Worlds.GetMyWorld( opener.Map, opener.Location, opener.X, opener.Y ) == "the Underworld" ){ loot = new PetrifiedBoard(); }
				else if ( loot is BaseWoodBoard && Utility.RandomMinMax( 1, 3 ) > 1 && ( reg.IsPartOf( typeof( NecromancerRegion ) ) || reg.IsPartOf( "the Crypts of Dracula" ) || reg.IsPartOf( "the Castle of Dracula" ) ) ){ loot = new GhostBoard(); }

				if (loot.Stackable == true){ loot.Amount = Utility.RandomMinMax( 5, 50 ); }
			}
			else if ( found == 3 )
			{
				if ( 1 == Utility.Random( 4 ) ){ loot = new ScrollClue(); }
				else { loot = DungeonLoot.RandomLoreBooks(); }
			}
			else if ( found == 4 )
			{
				loot = DungeonLoot.RandomJunk();
				if ((loot is BaseClothing) && !(loot is BaseShoes))
				{
					loot.Hue = RandomThings.GetRandomColor(0);

					if ( Utility.RandomBool() )
						loot.Hue = RandomThings.GetRandomSpecialColor();
				}
				if (loot is BlueBook){ loot.Name = "Book"; loot.Hue = RandomThings.GetRandomColor(0); loot.ItemID = RandomThings.GetRandomBookItemID(); }
				if ( (loot is MetalBox) )
				{
					loot.ItemID = Utility.RandomList( 0xE80, 0x9A8 );
					switch ( Utility.RandomMinMax( 0, 18 ) ) 
					{
						case 0: loot.Hue = MaterialInfo.GetMaterialColor( "dull copper", "classic", 0 ); loot.Name = "Dull Copper Box";	break;
						case 1: loot.Hue = MaterialInfo.GetMaterialColor( "shadow iron", "classic", 0 ); loot.Name = "Shadow Iron Box";	break;
						case 2: loot.Hue = MaterialInfo.GetMaterialColor( "copper", "classic", 0 ); loot.Name = "Copper Box";			break;
						case 3: loot.Hue = MaterialInfo.GetMaterialColor( "bronze", "classic", 0 ); loot.Name = "Bronze Box";			break;
						case 4: loot.Hue = MaterialInfo.GetMaterialColor( "gold", "classic", 0 ); loot.Name = "Golden Box";				break;
						case 5: loot.Hue = MaterialInfo.GetMaterialColor( "agapite", "classic", 0 ); loot.Name = "Agapite Box";			break;
						case 6: loot.Hue = MaterialInfo.GetMaterialColor( "verite", "classic", 0 ); loot.Name = "Verite Box";			break;
						case 7: loot.Hue = MaterialInfo.GetMaterialColor( "valorite", "classic", 0 ); loot.Name = "Valorite Box";		break;
						case 8: loot.Hue = MaterialInfo.GetMaterialColor( "silver", "classic", 0 ); loot.Name = "Silver Box";			break;
						case 9: loot.Hue = MaterialInfo.GetMaterialColor( "emerald", "classic", 0 ); loot.Name = "Emerald Box";			break;
						case 10: loot.Hue = MaterialInfo.GetMaterialColor( "jade", "classic", 0 ); loot.Name = "Jade Box";				break;
						case 11: loot.Hue = MaterialInfo.GetMaterialColor( "onyx", "classic", 0 ); loot.Name = "Onyx Box";				break;
						case 12: loot.Hue = MaterialInfo.GetMaterialColor( "ruby", "classic", 0 ); loot.Name = "Ruby Box";				break;
						case 13: loot.Hue = MaterialInfo.GetMaterialColor( "sapphire", "classic", 0 ); loot.Name = "Sapphire Box";		break;
						case 14: loot.Hue = MaterialInfo.GetMaterialColor( "obsidian", "classic", 0 ); loot.Name = "Obsidian Box";		break;
						case 15: loot.Hue = MaterialInfo.GetMaterialColor( "nepturite", "classic", 0 ); loot.Name = "Nepturite Box";	break;
						case 16: loot.Hue = MaterialInfo.GetMaterialColor( "steel", "classic", 0 ); loot.Name = "Steel Box";			break;
						case 17: loot.Hue = MaterialInfo.GetMaterialColor( "brass", "classic", 0 ); loot.Name = "Brass Box";			break;
						case 18: loot.Hue = MaterialInfo.GetMaterialColor( "mithril", "classic", 0 ); loot.Name = "Mithril Box";		break;
					}
				}
				if ( ((loot is Backpack) || (loot is Bag)) )
				{
					if (loot is Backpack)
					{
						loot.ItemID = Utility.RandomList( 0xE75, 0x9B2 );
						Backpack ipack = (Backpack)loot;
						switch ( Utility.RandomMinMax( 0, 23 ) ) 
						{
							case 0: ipack.GumpID = 0x415;	loot.Name = "Deep Sea Leather Backpack";	loot.Hue = MaterialInfo.GetMaterialColor( "deep sea", "", 0 );			break;
							case 1: ipack.GumpID = 0x415;	loot.Name = "Lizard Leather Backpack";		loot.Hue = MaterialInfo.GetMaterialColor( "lizard", "", 0 );			break;
							case 2: ipack.GumpID = 0x415;	loot.Name = "Serpent Leather Backpack";		loot.Hue = MaterialInfo.GetMaterialColor( "serpent", "", 0 );			break;
							case 3: ipack.GumpID = 0x416;	loot.Name = "Unicorn Fur Backpack";			loot.Hue = MaterialInfo.GetMaterialColor( "unicorn skin", "", 0 );		break;
							case 4: ipack.GumpID = 0x41B;	loot.Name = "Nightmare Skin Backpack";		loot.Hue = MaterialInfo.GetMaterialColor( "nightmare skin", "", 0 );	break;
							case 5: ipack.GumpID = 0x415;	loot.Name = "Troll Skin Backpack";			loot.Hue = MaterialInfo.GetMaterialColor( "troll skin", "", 0 );		break;
							case 6: ipack.GumpID = 0x417;	loot.Name = "Human Flesh Backpack";			loot.Hue = MaterialInfo.GetMaterialColor( "dead skin", "", 0 );			break;
							case 7: ipack.GumpID = 0x418;	loot.Name = "Bloody Backpack";				loot.Hue = 0x4AA;	break;
							case 8: ipack.GumpID = 0x41B;	loot.Name = "Thieves Backpack";				loot.Hue = 0x497;	break;
							case 9: ipack.GumpID = 0x416;	loot.Name = "Polar Bear Fur Backpack";		loot.Hue = 0x47E;	break;
							case 10: ipack.GumpID = 0x416;	loot.Name = "Yeti Fur Backpack";			loot.Hue = 0x47E;	break;
							case 11: ipack.GumpID = 0x41C;	loot.Name = "Wizard Backpack";				loot.Hue = 0x6E4;	break;
							case 12: ipack.GumpID = 0x41A;	loot.Name = "Druid Backpack";				loot.Hue = 0x58B;	break;
							case 13: ipack.GumpID = 0x419;	loot.Name = "Necromancer Backpack";			loot.Hue = 0x497;	break;
							case 14: ipack.GumpID = 0x415;	loot.Name = "Necrotic Leather Backpack";	loot.Hue = MaterialInfo.GetMaterialColor( "necrotic", "", 0 );	break;
							case 15: ipack.GumpID = 0x415;	loot.Name = "Volcanic Leather Backpack";	loot.Hue = MaterialInfo.GetMaterialColor( "volcanic", "", 0 );	break;
							case 16: ipack.GumpID = 0x415;	loot.Name = "Frozen Leather Backpack";		loot.Hue = MaterialInfo.GetMaterialColor( "frozen", "", 0 );	break;
							case 17: ipack.GumpID = 0x415;	loot.Name = "Goliath Leather Backpack";		loot.Hue = MaterialInfo.GetMaterialColor( "goliath", "", 0 );	break;
							case 18: ipack.GumpID = 0x415;	loot.Name = "Draconic Leather Backpack";	loot.Hue = MaterialInfo.GetMaterialColor( "draconic", "", 0 );	break;
							case 19: ipack.GumpID = 0x415;	loot.Name = "Hellish Leather Backpack";		loot.Hue = MaterialInfo.GetMaterialColor( "hellish", "", 0 );	break;
							case 20: ipack.GumpID = 0x415;	loot.Name = "Dinosaur Leather Backpack";	loot.Hue = MaterialInfo.GetMaterialColor( "dinosaur", "", 0 );	break;
						}
					}
					else
					{
						switch ( Utility.RandomMinMax( 0, 13 ) ) 
						{
							case 0: 	loot.Hue = MaterialInfo.GetMaterialColor( "deep sea", "", 0 );			loot.Name = "Deep Sea Leather Bag";	break;
							case 1:		loot.Hue = MaterialInfo.GetMaterialColor( "lizard", "", 0 );			loot.Name = "Lizard Leather Bag";	break;
							case 2: 	loot.Hue = MaterialInfo.GetMaterialColor( "serpent", "", 0 );			loot.Name = "Serpent Leather Bag";	break;
							case 3: 	loot.Hue = MaterialInfo.GetMaterialColor( "unicorn skin", "", 0 );		loot.Name = "Unicorn Skin Bag";		break;
							case 4: 	loot.Hue = MaterialInfo.GetMaterialColor( "nightmare skin", "", 0 );	loot.Name = "Nightmare Skin Bag";	break;
							case 5: 	loot.Hue = MaterialInfo.GetMaterialColor( "serpent skin", "", 0 );		loot.Name = "Serpent Skin Bag";		break;
							case 6: 	loot.Hue = MaterialInfo.GetMaterialColor( "troll skin", "", 0 );		loot.Name = "Troll Skin Bag";		break;
							case 7: 	loot.Hue = MaterialInfo.GetMaterialColor( "necrotic", "", 0 );			loot.Name = "Necrotic Leather Bag";	break;
							case 8: 	loot.Hue = MaterialInfo.GetMaterialColor( "volcanic", "", 0 );			loot.Name = "Volcanic Leather Bag";	break;
							case 9: 	loot.Hue = MaterialInfo.GetMaterialColor( "frozen", "", 0 );			loot.Name = "Frozen Leather Bag";	break;
							case 10: 	loot.Hue = MaterialInfo.GetMaterialColor( "goliath", "", 0 );			loot.Name = "Goliath Leather Bag";	break;
							case 11: 	loot.Hue = MaterialInfo.GetMaterialColor( "draconic", "", 0 );			loot.Name = "Draconic Leather Bag";	break;
							case 12: 	loot.Hue = MaterialInfo.GetMaterialColor( "hellish", "", 0 );			loot.Name = "Hellish Leather Bag";	break;
							case 13: 	loot.Hue = MaterialInfo.GetMaterialColor( "dinosaur", "", 0 );			loot.Name = "Dinosaur Leather Bag";	break;
						}
					}
				}
			}
			else if ( found == 5 )
			{
				loot = DungeonLoot.RandomTools();
				if ( loot is BaseTool )
				{
					BaseTool toolD = (BaseTool)loot;
					if (toolD.UsesRemaining > 0){ toolD.UsesRemaining = Utility.RandomMinMax( 3, 20 ); }
				}
				else if ( loot is BaseHarvestTool )
				{
					BaseHarvestTool toolD = (BaseHarvestTool)loot;
					if (toolD.UsesRemaining > 0){ toolD.UsesRemaining = Utility.RandomMinMax( 3, 20 ); }
				}
				else
				{
					if (loot.Stackable == true){ loot.Amount = Utility.RandomMinMax( 1, 10 ); }
				}
			}
			else if ( found == 6 )
			{
				int odd = Utility.RandomMinMax( 1, 5 );
				if ( odd == 1 )
				{
					loot = new GolemManual();
				}
				else if ( odd == 2 )
				{
					loot = new SummonPrison();
				}
				else if ( odd == 3 )
				{
					loot = Loot.RandomQuiver();
					Server.Misc.ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), loot, null, 1 );
					
				}
				else if ( odd == 4 )
				{
					loot = Loot.RandomInstrument();
					Server.Misc.ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), loot, null, 1 );
				}
				else if ( odd == 5 )
				{
					loot = ArtifactBuilder.CreateArtifact( "random" );
				}
			}
			else if ( found == 7 )
			{
				int odd = Utility.RandomMinMax( 1, 4 );
				if ( odd == 1 )
				{
					loot = Loot.RandomRelic();
					if ( loot is DDRelicWeapon && Server.Misc.GetPlayerInfo.OrientalPlay( opener ) == true ){ Server.Items.DDRelicWeapon.MakeOriental( loot ); }
					else if ( loot is DDRelicStatue && Server.Misc.GetPlayerInfo.OrientalPlay( opener ) == true ){ Server.Items.DDRelicStatue.MakeOriental( loot ); }
					else if ( loot is DDRelicBanner && loot.ItemID != 0x2886 && loot.ItemID != 0x2887 && Server.Misc.GetPlayerInfo.OrientalPlay( opener ) == true ){ Server.Items.DDRelicBanner.MakeOriental( loot ); }
				}
				else if ( odd == 2 )
				{
					loot = Loot.RandomArmorOrShieldOrWeaponOrJewelry( Server.Misc.GetPlayerInfo.OrientalPlay( opener ) );
					Server.Misc.ContainerFunctions.LootMutate( opener, Server.LootPack.GetRegularLuckChance( opener ), loot, null, 1 );
				}
				else if ( odd == 3 )
				{
					loot = Loot.RandomWand();

					Server.Misc.MaterialInfo.ColorMetal( loot, 0 );

					string wandOwner = "";
						if ( Utility.RandomMinMax( 1, 3 ) == 1 ){ wandOwner = Server.LootPackEntry.MagicWandOwner() + " "; }

					loot.Name = wandOwner + loot.Name;

					if ( Server.Misc.GetPlayerInfo.EvilPlay( opener ) == true && Utility.RandomMinMax( 1, 4 ) != 1 )
					{
						loot.ItemID = Utility.RandomList( 0x269D, 0x269E );
					}
				}
				else if ( odd == 4 )
				{
					if ( Utility.Random( 2 ) == 1 ) { loot = Loot.RandomScroll( 0, ((7*Utility.RandomMinMax( 1, 6 ))+3), SpellbookType.Regular ); }
					else { loot = Loot.RandomScroll( 0, (((7*Utility.RandomMinMax( 1, 6 ))*2)+3), SpellbookType.Necromancer ); }
				}
			}
			else if ( found == 8 )
			{
				if ( Utility.RandomMinMax( 0, 4 ) == 1 )
				{
					loot = Loot.RandomPossibleReagent();

					if ( Server.Misc.IntelligentAction.TestForReagent( opener, "herbalist" ) && Utility.RandomMinMax( 1, 2 ) == 1 )
						{ loot.Delete(); loot = Loot.RandomHerbReagent(); }

					if ( Server.Misc.IntelligentAction.TestForReagent( opener, "mixologist" ) && Utility.RandomMinMax( 1, 2 ) == 1 )
						{ loot.Delete(); loot = Loot.RandomMixerReagent(); }

					if ( Server.Misc.IntelligentAction.TestForReagent( opener, "necromancer" ) && Utility.RandomMinMax( 1, 4 ) > 1 )
						{ loot.Delete(); loot = Loot.RandomNecromancyReagent(); }

					if ( Server.Misc.IntelligentAction.TestForReagent( opener, "wizard" ) && Utility.RandomMinMax( 1, 4 ) > 1 )
						{ loot.Delete(); loot = Loot.RandomReagent(); }

					loot.Amount = Utility.RandomMinMax( (1 * 5), (2 * 10) );
				}
				else { loot = Loot.RandomSecretReagent(); UnknownReagent myreg = (UnknownReagent)loot; myreg.RegAmount = Utility.RandomMinMax( (1 * 5), (2 * 10) ) + 1; }
			}
			else if ( found == 9 )
			{
				loot = Loot.RandomPotion();
			}
			else if ( found == 10 )
			{
				loot = new Crystals( Utility.RandomMinMax( 5, 20 ) );
			}
			else if ( found == 11 )
			{
				loot = new Gold( Utility.RandomMinMax( 10, 100 ) );
			}
			else if ( found == 12 )
			{
				loot = new DDSilver( Utility.RandomMinMax( 10, 500 ) );
			}
			else if ( found == 13 )
			{
				loot = new DDCopper( Utility.RandomMinMax( 10, 1000 ) );
			}
			else
			{
				loot = new DDJewels( Utility.RandomMinMax( 5, 50 ) );
			}

			if ( loot != null ){ loot.MoveToWorld( opener.Location, opener.Map ); }
		}

		public static bool IsSpaceCrate( int id )
		{
			if ( id == 0x10EA || id == 0x10ED || id == 0x10EC || id == 0x10EB )
				return true;

			if ( id == 0x35AD || id == 0x3868 )
				return true;

			if ( id == 0x3582 || id == 0x3583 )
				return true;

			if ( id == 0x3564 || id == 0x3565 )
				return true;

			return false;
		}
	}
}