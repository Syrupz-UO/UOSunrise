using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Targeting;

namespace Server.Engines.Harvest
{
	public class CrystalMining : HarvestSystem
	{
		private static CrystalMining m_System;

		public static CrystalMining System
		{
			get
			{
				if ( m_System == null )
					m_System = new CrystalMining();

				return m_System;
			}
		}

		private HarvestDefinition m_Crystals;

		public HarvestDefinition Crystals
		{
			get{ return m_Crystals; }
		}

		private CrystalMining()
		{
			HarvestResource[] res;
			HarvestVein[] veins;

			HarvestDefinition Crystals = m_Crystals = new HarvestDefinition();

			// Resource banks are every 8x8 tiles
			Crystals.BankWidth = 8;
			Crystals.BankHeight = 8;

			// Every bank holds from 10 to 34 ore
			Crystals.MinTotal = 2;
			Crystals.MaxTotal = 5;

			// A resource bank will respawn its content every 10 to 20 minutes
			Crystals.MinRespawn = TimeSpan.FromMinutes( 15.0 );
			Crystals.MaxRespawn = TimeSpan.FromMinutes( 30.0 );

			// Skill checking is done on the Mining skill
			Crystals.Skill = SkillName.Mining;

			// Set the list of harvestable tiles
			Crystals.Tiles = m_CrystalTiles;

			// Players must be within 2 tiles to harvest
			Crystals.MaxRange = 2;

			// One ore per harvest action
			Crystals.ConsumedPerHarvest = 1;
			Crystals.ConsumedPerFeluccaHarvest = 2;

			// The digging effect
			Crystals.EffectActions = new int[]{ 11 };
			Crystals.EffectSounds = new int[]{ 0x125, 0x126 };
			Crystals.EffectCounts = new int[]{ 1 };
			Crystals.EffectDelay = TimeSpan.FromSeconds( 1.6 );
			Crystals.EffectSoundDelay = TimeSpan.FromSeconds( 0.9 );

			Crystals.NoResourcesMessage = "There are no Crystals here to mine."; // There is no Crystals here to mine.
			Crystals.DoubleHarvestMessage = "Someone mined to the Crystals before you."; // Someone has gotten to the Crystals before you.
			Crystals.TimedOutOfRangeMessage = "You have moved too far away to continue Crystal Mining."; // You have moved too far away to continue Gem Mining.
			Crystals.OutOfRangeMessage = "That Crystal is too far away."; // That is too far away.
			Crystals.FailMessage = "You loosen some Crystals but fail to find any useable gems."; // You loosen some rocks but fail to find any useable Crystals.
			Crystals.PackFullMessage = "Your backpack is full, so the gems you Crystal Mined are lost."; // Your backpack is full, so the Crystals you mined is lost.
			Crystals.ToolBrokeMessage = "You have worn out your Crystal Mining tool!"; // You have worn out your tool!

			res = new HarvestResource[]
				{
					new HarvestResource( 00.0, 00.0, 100.0, "You pick at the Crystal and find a Amber gem, and you put it into your backpack.", typeof( Amber )  ),
					new HarvestResource( 65.0, 25.0, 105.0, "You pick at the Crystal and find a Amethyst gem, and you put it into your backpack.", typeof( Amethyst )  ),
					new HarvestResource( 70.0, 30.0, 110.0, "You pick at the Crystal and find a Citrine gem, and you put it into your backpack.", typeof( Citrine )  ),
					new HarvestResource( 75.0, 35.0, 115.0, "You pick at the Crystal and find a Diamond gem, and you put it into your backpack.", typeof( Diamond )  ),
					new HarvestResource( 80.0, 40.0, 120.0, "You pick at the Crystal and find a Emerald gem, and you put it into your backpack.", typeof( Emerald )  ),
					new HarvestResource( 85.0, 45.0, 125.0, "You pick at the Crystal and find a Ruby gem, and you put it into your backpack.", typeof( Ruby )  ),
					new HarvestResource( 90.0, 50.0, 130.0, "You pick at the Crystal and find a Sapphire gem, and you put it into your backpack.", typeof( Sapphire ) ),
					new HarvestResource( 95.0, 55.0, 135.0, "You pick at the Crystal and find a Star Sapphire gem, and you put it into your backpack.", typeof( StarSapphire )  ),
					new HarvestResource( 99.0, 59.0, 139.0, "You pick at the Crystal and find a Tourmaline gem, and you put it into your backpack.", typeof( Tourmaline )  )
				};

			veins = new HarvestVein[]
				{
					new HarvestVein( 49.6, 0.0, res[0], null   ), // Amber
					new HarvestVein( 11.2, 0.5, res[1], res[0] ), // Amethyst
					new HarvestVein( 09.8, 0.5, res[2], res[0] ), // Citrine
					new HarvestVein( 08.4, 0.5, res[3], res[0] ), // Diamond
					new HarvestVein( 07.0, 0.5, res[4], res[0] ), // Emerald
					new HarvestVein( 05.6, 0.5, res[5], res[0] ), // Ruby
					new HarvestVein( 04.2, 0.5, res[6], res[0] ), // Sapphire
					new HarvestVein( 02.8, 0.5, res[7], res[0] ), // StarSapphire
					new HarvestVein( 01.4, 0.5, res[8], res[0] )  // Tourmaline
				};

			Crystals.Resources = res;
			Crystals.Veins = veins;

			if ( Core.ML )
			{
				Crystals.BonusResources = new BonusHarvestResource[]
				{
					new BonusHarvestResource(   0,65.0, null, null ),	//Nothing
					new BonusHarvestResource( 100, 5.0, "You pick at the Crystal and a rare Chipped Amethyst falls from a fragment, and you put it into your backpack", typeof( ChippedAmethyst ) ),
					new BonusHarvestResource( 100, 5.0, "You pick at the Crystal and a rare Chipped Diamond falls from a fragment, and you put it into your backpack.", typeof( ChippedDiamond  ) ),
					new BonusHarvestResource( 100, 5.0, "You pick at the Crystal and a rare Chipped Emerald falls from a fragment, and you put it into your backpack.", typeof( ChippedEmerald  ) ),
					new BonusHarvestResource( 100, 5.0, "You pick at the Crystal and a rare Chipped Ruby falls from a fragment, and you put it into your backpack.", typeof( ChippedRuby     ) ),
					new BonusHarvestResource( 100, 5.0, "You pick at the Crystal and a rare Chipped Sapphire falls from a fragment, and you put it into your backpack.", typeof( ChippedSapphire ) ),
					new BonusHarvestResource( 100, 5.0, "You pick at the Crystal and a rare Chipped Topaz falls from a fragment, and you put it into your backpack.", typeof( ChippedTopaz    ) ),
					new BonusHarvestResource( 100, 5.0, "You pick at the Crystal and a rare Chipped Skull falls from a fragment, and you put it into your backpack.", typeof( ChippedSkull    ) )
				};
			}

			//oreAndStone.RaceBonus = Core.ML;
			//oreAndStone.RandomizeVeins = Core.ML;

			Definitions.Add( Crystals );
			}
			
		public override bool CheckHarvest( Mobile from, Item tool )
		{
			if ( !base.CheckHarvest( from, tool ) )
				return false;

			if ( from.Mounted )
			{
				from.SendMessage( 55,"You can't Crystal Mine while riding." ); // You can't mine while riding.
				return false;
			}
			else if ( from.IsBodyMod && !from.Body.IsHuman )
			{
				from.SendMessage( 55,"You can't Crystal Mine while polymorphed." );	 // You can't mine while polymorphed.
				return false;
			}

			return true;
		}

		public override HarvestVein MutateVein( Mobile from, Item tool, HarvestDefinition def, HarvestBank bank, object toHarvest, HarvestVein vein )
		{
			if ( tool is CrystalMiningPickaxe && def == m_Crystals )
			{
				int veinIndex = Array.IndexOf( def.Veins, vein );

				if ( veinIndex >= 0 && veinIndex < (def.Veins.Length - 1) )
					return def.Veins[veinIndex + 1];
			}

			return base.MutateVein( from, tool, def, bank, toHarvest, vein );
		}

		private static int[] m_Offsets = new int[]
			{
				-1, -1,
				-1,  0,
				-1,  1,
				 0, -1,
				 0,  1,
				 1, -1,
				 1,  0,
				 1,  1
			};

		public override void OnHarvestFinished( Mobile from, Item tool, HarvestDefinition def, HarvestVein vein, HarvestBank bank, HarvestResource resource, object harvested )
		{
			if ( tool is CrystalMiningPickaxe && def == m_Crystals && 0.1 > Utility.RandomDouble() )
			{
				HarvestResource res = vein.PrimaryResource;

				if ( res == resource && res.Types.Length >= 3 )
				{
					try
					{
						Map map = from.Map;

						if ( map == null )
							return;

						BaseCreature spawned = Activator.CreateInstance( res.Types[2], new object[]{ 25 } ) as BaseCreature;

						if ( spawned != null )
						{
							int offset = Utility.Random( 8 ) * 2;

							for ( int i = 0; i < m_Offsets.Length; i += 2 )
							{
								int x = from.X + m_Offsets[(offset + i) % m_Offsets.Length];
								int y = from.Y + m_Offsets[(offset + i + 1) % m_Offsets.Length];

								if ( map.CanSpawnMobile( x, y, from.Z ) )
								{
									spawned.OnBeforeSpawn( new Point3D( x, y, from.Z ), map );
									spawned.MoveToWorld( new Point3D( x, y, from.Z ), map );
									spawned.Combatant = from;
									return;
								}
								else
								{
									int z = map.GetAverageZ( x, y );

									if ( map.CanSpawnMobile( x, y, z ) )
									{
										spawned.OnBeforeSpawn( new Point3D( x, y, z ), map );
										spawned.MoveToWorld( new Point3D( x, y, z ), map );
										spawned.Combatant = from;
										return;
									}
								}
							}

							spawned.OnBeforeSpawn( from.Location, from.Map );
							spawned.MoveToWorld( from.Location, from.Map );
							spawned.Combatant = from;
						}
					}
					catch
					{
					}
				}
			}
		}

		public override bool BeginHarvesting( Mobile from, Item tool )
		{
			if ( !base.BeginHarvesting( from, tool ) )
				return false;
				
			from.SendMessage( 55,"What Crystal do you wish to pick at?" ); // Where do you wish to dig?
			return true;
		}

		public override void OnHarvestStarted( Mobile from, Item tool, HarvestDefinition def, object toHarvest )
		{
			base.OnHarvestStarted( from, tool, def, toHarvest );

			if ( Core.ML )
				from.RevealingAction();
		}

		public override void OnBadHarvestTarget( Mobile from, Item tool, object toHarvest )
		{
			if ( toHarvest is LandTarget )
				from.SendMessage( 55,"You can't Crystal Mine that." );// You can't mine there.			
			else
				from.SendMessage( 55,"You can't Crystal Mine that." );// You can't mine there.			
		}

		#region Tile lists
        private static int[] m_CrystalTiles = new int[]
		{
			0x6206, 0x6207, 0x6208, 0x6209, 0x620A, 0x620B, 0x620C, 0x620D,
			0x620E, 0x6210, 0x6211, 0x6212, 0x6213, 0x6214, 0x6215, 0x6216,
			0x6217, 0x6218, 0x621A, 0x621B, 0x621C, 0x621D, 0x621E, 0x621F,
			0x6220, 0x6221, 0x6222, 0x6224, 0x6225, 0x6226, 0x6227, 0x6228,
			0x6229, 0x622A, 0x622B, 0x622C,

			0x623A, 0x623B, 0x623C, 0x623D, 0x623E, 0x623F,
			0x6240, 0x6241, 0x6242, 0x6243, 0x6244, 0x6245, 0x6246, 0x6247, 0x6248, 0x6249,

			0x2206, 0x2207,0x2208,0x2209,0x220A,0x220B,0x220C,0x220D,
			0x220E, 0x2210, 0x2211, 0x2212, 0x2213, 0x2214, 0x2215, 0x2216,
			0x2217, 0x2218, 0x221A, 0x221B, 0x221C, 0x221D, 0x221E, 0x221F,
			0x2220, 0x2221, 0x2222, 0x2224, 0x2225, 0x2226, 0x2227, 0x2228,
			0x2229, 0x222A, 0x222B, 0x222C,
			0x223A, 0x223B, 0x223C, 0x223D, 0x223E, 0x223F,
			0x2240, 0x2241, 0x2242, 0x2243, 0x2244, 0x2245, 0x2246, 0x2247, 0x2248, 0x2249
		};
		#endregion
	}
}