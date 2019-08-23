using System;
using System.Collections.Generic;
using System.Collections;
using Server.Engines.Apiculture;
using Server.Items;
using Server.Multis;
using Server.Guilds;
using Server.Engines.Mahjong;
using Server.Items.Crops;
using System.Collections;

namespace Server.Mobiles
{
	public abstract class SBInfo
	{
		public SBInfo()
		{
		}

		public abstract IShopSellInfo SellInfo { get; }

        public abstract List<GenericBuyInfo> BuyInfo { get; }
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBElfRares: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBElfRares()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( Futon ), Utility.Random( 1000,5000 ), 1, 0x295C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( ArtifactVase ), Utility.Random( 1000,5000 ), 1, 0x0B48, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( ArtifactLargeVase ), Utility.Random( 1000,5000 ), 1, 0x0B47, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BrokenBookcaseDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BrokenBedDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BrokenArmoireDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( StandingBrokenChairDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BrokenVanityDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BrokenFallenChairDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BrokenCoveredChairDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BrokenChestOfDrawersDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TapestryOfSosaria ), Utility.Random( 1000,5000 ), 1, 0x234E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( RoseOfTrinsic ), Utility.Random( 1000,5000 ), 1, 0x234C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( HearthOfHomeFireDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( VanityDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BlueDecorativeRugDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BlueFancyRugDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BluePlainRugDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BoilingCauldronDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( CinnamonFancyRugDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( CurtainsDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( FountainDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( GoldenDecorativeRugDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( HangingAxesDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( HangingSwordsDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( HouseLadderDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( LargeFishingNetDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( PinkFancyRugDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( RedPlainRugDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( ScarecrowDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( SmallFishingNetDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TableWithBlueClothDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TableWithOrangeClothDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TableWithPurpleClothDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TableWithRedClothDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( UnmadeBedDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( WallBannerDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TreeStumpDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( DecorativeShieldDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( MiningCartDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( PottedCactusDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( StoneAnkhDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BannerDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( Tub ), Utility.Random( 1000,5000 ), 1, 0xe83, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( WaterBarrel ), Utility.Random( 1000,5000 ), 1, 0xe77, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( ClosedBarrel ), Utility.Random( 1000,5000 ), 1, 0x0FAE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( Bucket ), Utility.Random( 1000,5000 ), 1, 0x14e0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( DecoTray ), Utility.Random( 1000,5000 ), 1, 0x992, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( DecoTray2 ), Utility.Random( 1000,5000 ), 1, 0x991, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( DecoBottlesOfLiquor ), Utility.Random( 1000,5000 ), 1, 0x99E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( Checkers ), Utility.Random( 1000,5000 ), 1, 0xE1A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( Chessmen3 ), Utility.Random( 1000,5000 ), 1, 0xE14, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( Chessmen2 ), Utility.Random( 1000,5000 ), 1, 0xE12, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( Chessmen ), Utility.Random( 1000,5000 ), 1, 0xE13, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( Checkers2 ), Utility.Random( 1000,5000 ), 1, 0xE1B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( DecoHay2 ), Utility.Random( 1000,5000 ), 1, 0xF34, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( DecoBridle2 ), Utility.Random( 1000,5000 ), 1, 0x1375, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( DecoBridle ), Utility.Random( 1000,5000 ), 1, 0x1374, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBChainmailArmor: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBChainmailArmor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ChainCoif ), 17, Utility.Random( 1,15 ), 0x13BB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ChainChest ), 143, Utility.Random( 1,15 ), 0x13BF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( ChainLegs ), 149, Utility.Random( 1,15 ), 0x13BE, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ChainCoif ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ChainChest ), 71 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ChainLegs ), 74 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ChainSkirt ), 74 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBHelmetArmor: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBHelmetArmor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateHelm ), 21, Utility.Random( 1,15 ), 0x1412, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CloseHelm ), 18, Utility.Random( 1,15 ), 0x1408, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CloseHelm ), 18, Utility.Random( 1,15 ), 0x1409, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Helmet ), 31, Utility.Random( 1,15 ), 0x140A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Helmet ), 18, Utility.Random( 1,15 ), 0x140B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( NorseHelm ), 18, Utility.Random( 1,15 ), 0x140E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( NorseHelm ), 18, Utility.Random( 1,15 ), 0x140F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bascinet ), 18, Utility.Random( 1,15 ), 0x140C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( PlateHelm ), 21, Utility.Random( 1,15 ), 0x1419, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DreadHelm ), 21, Utility.Random( 1,15 ), 0x2FBB, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bascinet ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CloseHelm ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Helmet ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NorseHelm ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlateHelm ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DreadHelm ), 10 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBLeatherArmor: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBLeatherArmor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherArms ), 80, Utility.Random( 1,15 ), 0x13CD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherChest ), 101, Utility.Random( 1,15 ), 0x13CC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherGloves ), 60, Utility.Random( 1,15 ), 0x13C6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherGorget ), 74, Utility.Random( 1,15 ), 0x13C7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherLegs ), 80, Utility.Random( 1,15 ), 0x13cb, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherCap ), 10, Utility.Random( 1,15 ), 0x1DB9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FemaleLeatherChest ), 116, Utility.Random( 1,15 ), 0x1C06, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherBustierArms ), 97, Utility.Random( 1,15 ), 0x1C0A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherShorts ), 86, Utility.Random( 1,15 ), 0x1C00, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LeatherSkirt ), 87, Utility.Random( 1,15 ), 0x1C08, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherCloak ), 120, Utility.Random( 1,15 ), 0x1515, 0x83F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherRobe ), 160, Utility.Random( 1,15 ), 0x1F03, 0x83F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PugilistMits ), 18, Utility.Random( 1,15 ), 0x13C6, 0x966 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ThrowingGloves ), 26, Utility.Random( 1,15 ), 0x13C6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinDragonArms ), 43200, 1, 0x13CD, Server.Misc.MaterialInfo.GetMaterialColor( "dragon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinDragonChest ), 44000, 1, 0x13CC, Server.Misc.MaterialInfo.GetMaterialColor( "dragon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinDragonGloves ), 42900, 1, 0x13C6, Server.Misc.MaterialInfo.GetMaterialColor( "dragon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinDragonGorget ), 42700, 1, 0x13C7, Server.Misc.MaterialInfo.GetMaterialColor( "dragon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinDragonLegs ), 43200, 1, 0x13cb, Server.Misc.MaterialInfo.GetMaterialColor( "dragon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinDragonHelm ), 42800, 1, 0x1DB9, Server.Misc.MaterialInfo.GetMaterialColor( "dragon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinNightmareArms ), 43200, 1, 0x13CD, Server.Misc.MaterialInfo.GetMaterialColor( "nightmare skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinNightmareChest ), 44000, 1, 0x13CC, Server.Misc.MaterialInfo.GetMaterialColor( "nightmare skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinNightmareGloves ), 42900, 1, 0x13C6, Server.Misc.MaterialInfo.GetMaterialColor( "nightmare skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinNightmareGorget ), 42700, 1, 0x13C7, Server.Misc.MaterialInfo.GetMaterialColor( "nightmare skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinNightmareLegs ), 43200, 1, 0x13cb, Server.Misc.MaterialInfo.GetMaterialColor( "nightmare skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinNightmareHelm ), 42800, 1, 0x1DB9, Server.Misc.MaterialInfo.GetMaterialColor( "nightmare skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinSerpentArms ), 43200, 1, 0x13CD, Server.Misc.MaterialInfo.GetMaterialColor( "serpent skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinSerpentChest ), 44000, 1, 0x13CC, Server.Misc.MaterialInfo.GetMaterialColor( "serpent skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinSerpentGloves ), 42900, 1, 0x13C6, Server.Misc.MaterialInfo.GetMaterialColor( "serpent skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinSerpentGorget ), 42700, 1, 0x13C7, Server.Misc.MaterialInfo.GetMaterialColor( "serpent skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinSerpentLegs ), 43200, 1, 0x13cb, Server.Misc.MaterialInfo.GetMaterialColor( "serpent skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinSerpentHelm ), 42800, 1, 0x1DB9, Server.Misc.MaterialInfo.GetMaterialColor( "serpent skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinTrollArms ), 43200, 1, 0x13CD, Server.Misc.MaterialInfo.GetMaterialColor( "troll skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinTrollChest ), 44000, 1, 0x13CC, Server.Misc.MaterialInfo.GetMaterialColor( "troll skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinTrollGloves ), 42900, 1, 0x13C6, Server.Misc.MaterialInfo.GetMaterialColor( "troll skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinTrollGorget ), 42700, 1, 0x13C7, Server.Misc.MaterialInfo.GetMaterialColor( "troll skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinTrollLegs ), 43200, 1, 0x13cb, Server.Misc.MaterialInfo.GetMaterialColor( "troll skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinTrollHelm ), 42800, 1, 0x1DB9, Server.Misc.MaterialInfo.GetMaterialColor( "troll skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinUnicornArms ), 43200, 1, 0x13CD, Server.Misc.MaterialInfo.GetMaterialColor( "unicorn skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinUnicornChest ), 44000, 1, 0x13CC, Server.Misc.MaterialInfo.GetMaterialColor( "unicorn skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinUnicornGloves ), 42900, 1, 0x13C6, Server.Misc.MaterialInfo.GetMaterialColor( "unicorn skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinUnicornGorget ), 42700, 1, 0x13C7, Server.Misc.MaterialInfo.GetMaterialColor( "unicorn skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinUnicornLegs ), 43200, 1, 0x13cb, Server.Misc.MaterialInfo.GetMaterialColor( "unicorn skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinUnicornHelm ), 42800, 1, 0x1DB9, Server.Misc.MaterialInfo.GetMaterialColor( "unicorn skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinDemonArms ), 43200, 1, 0x13CD, Server.Misc.MaterialInfo.GetMaterialColor( "demon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinDemonChest ), 44000, 1, 0x13CC, Server.Misc.MaterialInfo.GetMaterialColor( "demon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinDemonGloves ), 42900, 1, 0x13C6, Server.Misc.MaterialInfo.GetMaterialColor( "demon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinDemonGorget ), 42700, 1, 0x13C7, Server.Misc.MaterialInfo.GetMaterialColor( "demon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinDemonLegs ), 43200, 1, 0x13cb, Server.Misc.MaterialInfo.GetMaterialColor( "demon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SkinDemonHelm ), 42800, 1, 0x1DB9, Server.Misc.MaterialInfo.GetMaterialColor( "demon skin", "", 0 ) ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherArms ), 40 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherChest ), 52 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherGloves ), 30 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherGorget ), 37 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherLegs ), 40 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherCap ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FemaleLeatherChest ), 18 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FemaleStuddedChest ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherShorts ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherSkirt ), 11 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherBustierArms ), 11 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherCloak ), 60 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherRobe ), 80 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PugilistMits ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StuddedBustierArms ), 27 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinDragonArms ), 400 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinDragonChest ), 500 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinDragonGloves ), 300 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinDragonGorget ), 370 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinDragonLegs ), 400 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinDragonHelm ), 100 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinNightmareArms ), 400 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinNightmareChest ), 500 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinNightmareGloves ), 300 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinNightmareGorget ), 370 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinNightmareLegs ), 400 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinNightmareHelm ), 100 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinSerpentArms ), 400 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinSerpentChest ), 500 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinSerpentGloves ), 300 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinSerpentGorget ), 370 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinSerpentLegs ), 400 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinSerpentHelm ), 100 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinTrollArms ), 400 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinTrollChest ), 500 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinTrollGloves ), 300 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinTrollGorget ), 370 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinTrollLegs ), 400 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinTrollHelm ), 100 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinUnicornArms ), 400 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinUnicornChest ), 500 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinUnicornGloves ), 300 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinUnicornGorget ), 370 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinUnicornLegs ), 400 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinUnicornHelm ), 100 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinDemonArms ), 400 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinDemonChest ), 500 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinDemonGloves ), 300 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinDemonGorget ), 370 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinDemonLegs ), 400 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinDemonHelm ), 100 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBMetalShields : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBMetalShields()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BronzeShield ), 66, Utility.Random( 1,15 ), 0x1B72, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Buckler ), 50, Utility.Random( 1,15 ), 0x1B73, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MetalKiteShield ), 123, Utility.Random( 1,15 ), 0x1B74, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( HeaterShield ), 231, Utility.Random( 1,15 ), 0x1B76, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenKiteShield ), 70, Utility.Random( 1,15 ), 0x1B78, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( MetalShield ), 121, Utility.Random( 1,15 ), 0x1B7B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( GuardsmanShield ), 231, Utility.Random( 1,15 ), 0x2FCB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( ElvenShield ), 231, Utility.Random( 1,15 ), 0x2FCA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( DarkShield ), 231, Utility.Random( 1,15 ), 0x2FC8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( CrestedShield ), 231, Utility.Random( 1,15 ), 0x2FC9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( ChampionShield ), 231, Utility.Random( 1,15 ), 0x2B74, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( JeweledShield ), 231, Utility.Random( 1,15 ), 0x2B75, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Buckler ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BronzeShield ), 33 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MetalShield ), 60 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MetalKiteShield ), 62 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HeaterShield ), 115 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenKiteShield ), 35 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GuardsmanShield ), 115 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ElvenShield ), 115 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DarkShield ), 115 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CrestedShield ), 115 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ChampionShield ), 115 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JeweledShield ), 115 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBPlateArmor: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBPlateArmor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateGorget ), 104, Utility.Random( 1,15 ), 0x1413, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateChest ), 243, Utility.Random( 1,15 ), 0x1415, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateLegs ), 218, Utility.Random( 1,15 ), 0x1411, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateArms ), 188, Utility.Random( 1,15 ), 0x1410, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( PlateGloves ), 155, Utility.Random( 1,15 ), 0x1414, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FemalePlateChest ), 207, Utility.Random( 1,15 ), 0x1C04, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlateArms ), 94 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlateChest ), 121 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlateGloves ), 72 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlateGorget ), 52 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlateLegs ), 109 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlateSkirt ), 109 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FemalePlateChest ), 113 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBLotsOfArrows: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBLotsOfArrows()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( ManyArrows100 ), 200, 10, 0xF41, 0 ) );
				Add( new GenericBuyInfo( typeof( ManyBolts100 ), 200, 10, 0x1BFD, 0 ) );
				Add( new GenericBuyInfo( typeof( ManyArrows1000 ), 2000, 10, 0xF41, 0 ) );
				Add( new GenericBuyInfo( typeof( ManyBolts1000 ), 2000, 10, 0x1BFD, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBRingmailArmor: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBRingmailArmor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RingmailChest ), 121, Utility.Random( 1,15 ), 0x13ec, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RingmailLegs ), 90, Utility.Random( 1,15 ), 0x13F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RingmailArms ), 85, Utility.Random( 1,15 ), 0x13EE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( RingmailGloves ), 93, Utility.Random( 1,15 ), 0x13eb, 0 ) ); }

			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RingmailArms ), 42 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RingmailChest ), 60 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RingmailGloves ), 26 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RingmailLegs ), 45 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RingmailSkirt ), 45 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBStuddedArmor: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBStuddedArmor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedArms ), 87, Utility.Random( 1,15 ), 0x13DC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedChest ), 128, Utility.Random( 1,15 ), 0x13DB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedGloves ), 79, Utility.Random( 1,15 ), 0x13D5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedGorget ), 73, Utility.Random( 1,15 ), 0x13D6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedLegs ), 103, Utility.Random( 1,15 ), 0x13DA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FemaleStuddedChest ), 142, Utility.Random( 1,15 ), 0x1C02, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( StuddedBustierArms ), 120, Utility.Random( 1,15 ), 0x1c0c, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StuddedArms ), 43 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StuddedChest ), 64 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StuddedGloves ), 39 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StuddedGorget ), 36 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StuddedLegs ), 51 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StuddedSkirt ), 51 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FemaleStuddedChest ), 71 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StuddedBustierArms ), 60 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBWoodenShields: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBWoodenShields()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( WoodenShield ), 30, Utility.Random( 1,15 ), 0x1B7A, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenShield ), 15 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBSEArmor: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSEArmor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateHatsuburi ), 76, Utility.Random( 1,15 ), 0x2775, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( HeavyPlateJingasa ), 76, Utility.Random( 1,15 ), 0x2777, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DecorativePlateKabuto ), 95, Utility.Random( 1,15 ), 0x2778, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateDo ), 310, Utility.Random( 1,15 ), 0x277D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateHiroSode ), 222, Utility.Random( 1,15 ), 0x2780, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateSuneate ), 224, Utility.Random( 1,15 ), 0x2788, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateHaidate ), 235, Utility.Random( 1,15 ), 0x278D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( ChainHatsuburi ), 76, Utility.Random( 1,15 ), 0x2774, 0 ) ); }
				
				
				
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlateHatsuburi ), 38 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HeavyPlateJingasa ), 38 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DecorativePlateKabuto ), 47 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlateDo ), 155 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlateHiroSode ), 111 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlateSuneate ), 112 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlateHaidate), 117 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ChainHatsuburi ), 38 ); } // DO NOT WANT?

			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBSEBowyer: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSEBowyer()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Yumi ), 53, Utility.Random( 1,15 ), 0x27A5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Fukiya ), 20, Utility.Random( 1,15 ), 0x27AA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Nunchaku ), 35, Utility.Random( 1,15 ), 0x27AE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FukiyaDarts ), 3, Utility.Random( 1,15 ), 0x2806, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Bokuto ), 21, Utility.Random( 1,15 ), 0x27A8, 0 ) ); }
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Yumi ), 26 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Fukiya ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Nunchaku ), 17 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FukiyaDarts ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bokuto ), 10 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBSECarpenter: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSECarpenter()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bokuto ), 21, Utility.Random( 1,15 ), 0x27A8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Tetsubo ), 43, Utility.Random( 1,15 ), 0x27A6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Fukiya ), 20, Utility.Random( 1,15 ), 0x27AA, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Tetsubo ), 21 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Fukiya ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bokuto ), 10 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBSEFood: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSEFood()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Wasabi ), 2, Utility.Random( 1,15 ), 0x24E8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Wasabi ), 2, Utility.Random( 1,15 ), 0x24E9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BentoBox ), 6, Utility.Random( 1,15 ), 0x2836, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BentoBox ), 6, Utility.Random( 1,15 ), 0x2837, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( GreenTeaBasket ), 2, Utility.Random( 1,15 ), 0x284B, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Wasabi ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BentoBox ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreenTeaBasket ), 1 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBSELeatherArmor: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSELeatherArmor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherJingasa ), 11, Utility.Random( 1,15 ), 0x2776, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherDo ), 87, Utility.Random( 1,15 ), 0x277B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherHiroSode ), 49, Utility.Random( 1,15 ), 0x277E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherSuneate ), 55, Utility.Random( 1,15 ), 0x2786, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherHaidate), 54, Utility.Random( 1,15 ), 0x278A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherNinjaPants ), 49, Utility.Random( 1,15 ), 0x2791, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherNinjaJacket ), 51, Utility.Random( 1,15 ), 0x2793, 0 ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedMempo ), 61, Utility.Random( 1,15 ), 0x279D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedDo ), 130, Utility.Random( 1,15 ), 0x277C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedHiroSode ), 73, Utility.Random( 1,15 ), 0x277F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedSuneate ), 78, Utility.Random( 1,15 ), 0x2787, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( StuddedHaidate ), 76, Utility.Random( 1,15 ), 0x278B, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherJingasa ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherDo ), 42 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherHiroSode ), 23 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherSuneate ), 26 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherHaidate), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherNinjaPants ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherNinjaJacket ), 26 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StuddedMempo ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StuddedDo ), 66 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StuddedHiroSode ), 32 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StuddedSuneate ), 40 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StuddedHaidate ), 37 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBSEWeapons: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSEWeapons()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( NoDachi ), 82, Utility.Random( 1,15 ), 0x27A2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Tessen ), 83, Utility.Random( 1,15 ), 0x27A3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Wakizashi ), 38, Utility.Random( 1,15 ), 0x27A4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Tetsubo ), 43, Utility.Random( 1,15 ), 0x27A6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Lajatang ), 108, Utility.Random( 1,15 ), 0x27A7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Daisho ), 66, Utility.Random( 1,15 ), 0x27A9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Tekagi ), 55, Utility.Random( 1,15 ), 0x27AB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Shuriken ), 18, Utility.Random( 1,15 ), 0x27AC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Kama ), 61, Utility.Random( 1,15 ), 0x27AD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Sai ), 56, Utility.Random( 1,15 ), 0x27AF, 0 ) ); }		
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NoDachi ), 41 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Tessen ), 41 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Wakizashi ), 19 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Tetsubo ), 21 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Lajatang ), 54 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Daisho ), 33 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Tekagi ), 22 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Shuriken), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Kama ), 30 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Sai ), 28 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBAxeWeapon: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBAxeWeapon()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ExecutionersAxe ), 30, Utility.Random( 1,15 ), 0xF45, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BattleAxe ), 26, Utility.Random( 1,15 ), 0xF47, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( TwoHandedAxe ), 32, Utility.Random( 1,15 ), 0x1443, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Axe ), 40, Utility.Random( 1,15 ), 0xF49, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DoubleAxe ), 52, Utility.Random( 1,15 ), 0xF4B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Pickaxe ), 22, Utility.Random( 1,15 ), 0xE86, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LargeBattleAxe ), 33, Utility.Random( 1,15 ), 0x13FB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( WarAxe ), 29, Utility.Random( 1,15 ), 0x13B0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( OrnateAxe ), 42, Utility.Random( 1,15 ), 0x2D28, 0 ) ); }

			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OrnateAxe ),21 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BattleAxe ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DoubleAxe ), 26 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ExecutionersAxe ), 15 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LargeBattleAxe ),16 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pickaxe ), 11 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TwoHandedAxe ), 16 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WarAxe ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Axe ), 20 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBKnifeWeapon: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBKnifeWeapon()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ButcherKnife ), 14, Utility.Random( 1,15 ), 0x13F6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Dagger ), 21, Utility.Random( 1,15 ), 0xF52, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Cleaver ), 15, Utility.Random( 1,15 ), 0xEC3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( SkinningKnife ), 14, Utility.Random( 1,15 ), 0xEC4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AssassinSpike ), 21, Utility.Random( 1,15 ), 0x2D21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Leafblade ), 21, Utility.Random( 1,15 ), 0x2D22, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WarCleaver ), 25, Utility.Random( 1,15 ), 0x2D2F, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ButcherKnife ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Cleaver ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Dagger ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinningKnife ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AssassinSpike ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Leafblade ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WarCleaver ), 12 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBMaceWeapon: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBMaceWeapon()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DiamondMace ), 31, Utility.Random( 1,15 ), 0x2D24, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( HammerPick ), 26, Utility.Random( 1,15 ), 0x143D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Club ), 16, Utility.Random( 1,15 ), 0x13B4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Mace ), 28, Utility.Random( 1,15 ), 0xF5C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Maul ), 21, Utility.Random( 1,15 ), 0x143B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WarHammer ), 25, Utility.Random( 1,15 ), 0x1439, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( WarMace ), 31, Utility.Random( 1,15 ), 0x1407, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Club ), 8 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HammerPick ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Mace ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Maul ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WarHammer ), 12 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WarMace ), 15 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DiamondMace ), 15 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBPoleArmWeapon: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBPoleArmWeapon()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bardiche ), 60, Utility.Random( 1,15 ), 0xF4D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Halberd ), 42, Utility.Random( 1,15 ), 0x143E, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bardiche ), 30 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Halberd ), 21 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBRangedWeapon: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBRangedWeapon()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bow ), 40, Utility.Random( 1,15 ), 0x13B2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Crossbow ), 55, Utility.Random( 1,15 ), 0xF50, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( HeavyCrossbow ), 55, Utility.Random( 1,15 ), 0x13FD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RepeatingCrossbow ), 46, Utility.Random( 1,15 ), 0x26C3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CompositeBow ), 45, Utility.Random( 1,15 ), 0x26C2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MagicalShortbow ), 42, Utility.Random( 1,15 ), 0x2D2B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ElvenCompositeLongbow ), 42, Utility.Random( 1,15 ), 0x2D1E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bolt ), 2, Utility.Random( 1000,1100 ), 0x1BFB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Arrow ), 2, Utility.Random(1000,1100), 0xF3F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Feather ), 2, Utility.Random( 1000 ), 0x1BD1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Shaft ), 3, Utility.Random( 1000), 0x1BD4, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bolt ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Arrow ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Shaft ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Feather ), 1 ); } // DO NOT WANT?			
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HeavyCrossbow ), 27 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bow ), 17 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Crossbow ), 25 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CompositeBow ), 23 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RepeatingCrossbow ), 22 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicalShortbow ), 18 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ElvenCompositeLongbow ), 18 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBSpearForkWeapon: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSpearForkWeapon()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Pitchfork ), 19, Utility.Random( 1,15 ), 0xE87, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ShortSpear ), 23, Utility.Random( 1,15 ), 0x1403, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Spear ), 31, Utility.Random( 1,15 ), 0xF62, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Spear ), 15 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pitchfork ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ShortSpear ), 11 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBStavesWeapon: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBStavesWeapon()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BlackStaff ), 22, Utility.Random( 1,15 ), 0xDF1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WildStaff ), 20, Utility.Random( 1,15 ), 0x2D25, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GnarledStaff ), 16, Utility.Random( 1,15 ), 0x13F8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( QuarterStaff ), 19, Utility.Random( 1,15 ), 0xE89, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( ShepherdsCrook ), 20, Utility.Random( 1,15 ), 0xE81, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BlackStaff ), 11 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GnarledStaff ), 8 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuarterStaff ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ShepherdsCrook ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WildStaff ), 10 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBSwordWeapon: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSwordWeapon()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Cutlass ), 24, Utility.Random( 1,15 ), 0x1441, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Katana ), 33, Utility.Random( 1,15 ), 0x13FF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Kryss ), 32, Utility.Random( 1,15 ), 0x1401, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Broadsword ), 35, Utility.Random( 1,15 ), 0xF5E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Longsword ), 55, Utility.Random( 1,15 ), 0xF61, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ThinLongsword ), 27, Utility.Random( 1,15 ), 0x13B8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( VikingSword ), 55, Utility.Random( 1,15 ), 0x13B9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Scimitar ), 36, Utility.Random( 1,15 ), 0x13B6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BoneHarvester ), 35, Utility.Random( 1,15 ), 0x26BB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CrescentBlade ), 37, Utility.Random( 1,15 ), 0x26C1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DoubleBladedStaff ), 35, Utility.Random( 1,15 ), 0x26BF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Lance ), 34, Utility.Random( 1,15 ), 0x26C0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Pike ), 39, Utility.Random( 1,15 ), 0x26BE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Scythe ), 39, Utility.Random( 1,15 ), 0x26BA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RuneBlade ), 55, Utility.Random( 1,15 ), 0x2D32, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RadiantScimitar ), 35, Utility.Random( 1,15 ), 0x2D33, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ElvenSpellblade ), 33, Utility.Random( 1,15 ), 0x2D20, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ElvenMachete ), 35, Utility.Random( 1,15 ), 0x2D35, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Broadsword ), 17 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Cutlass ), 12 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Katana ), 16 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Kryss ), 16 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Longsword ), 27 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Scimitar ), 18 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ThinLongsword ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( VikingSword ), 27 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Scythe ), 19 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BoneHarvester ), 17 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Scepter ), 18 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BladedStaff ), 16 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pike ), 19 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DoubleBladedStaff ), 17 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Lance ), 17 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CrescentBlade ), 18 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RuneBlade ), 27 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RadiantScimitar ), 17 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ElvenSpellblade ), 16 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ElvenMachete ), 17 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBElfWizard : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBElfWizard()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{  
			Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 40){Add( new GenericBuyInfo( typeof( BagOfSending ), 4000, Utility.Random( 1,10 ), 0xE76, 0x8AD ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 40){Add( new GenericBuyInfo( typeof( BallOfSummoning ), 3000, Utility.Random( 1,10 ), 0xE2E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 40){Add( new GenericBuyInfo( typeof( BraceletOfBinding ), 3500, Utility.Random( 1,10 ), 0x1086, 0x489 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 40){Add( new GenericBuyInfo( typeof( PowderOfTranslocation ), 500, Utility.Random( 500 ), 0x26B8, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBElfHealer : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBElfHealer()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{  
				if (Utility.RandomMinMax( 1, 100 ) > 40){Add( new GenericBuyInfo( typeof( FountainOfLifeDeed ), 7400, 1, 0x14F0, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBUndertaker: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBUndertaker()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( PowerCoil ), Utility.Random( 10000,20000 ), Utility.Random( 1,5 ), 0x8A7, 0 ) );
				Add( new GenericBuyInfo( typeof( EmbalmingFluid ), Utility.Random( 100,200 ), Utility.Random( 15,55 ), 0xE0F, 0xBA1 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				
				Add( typeof( FrankenArmRight ), Utility.Random( 100,350 ) );
				Add( typeof( FrankenHead ), Utility.Random( 100,350 ) );
				Add( typeof( FrankenLegLeft ), Utility.Random( 100,350 ) );
				Add( typeof( FrankenLegRight ), Utility.Random( 100,350 ) );
				Add( typeof( FrankenTorso ), Utility.Random( 100,350 ) );
				Add( typeof( FrankenArmLeft ), Utility.Random( 100,350 ) );
				Add( typeof( FrankenBrain ), Utility.Random( 100,350 ) );
				Add( typeof( FrankenJournal ), Utility.Random( 300,750 ) );
				Add( typeof( PowerCoil ), Utility.Random( 3500,4500 ) );
				Add( typeof( CorpseSailor ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( CorpseChest ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( BuriedBody ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( BoneContainer ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( LeftLeg ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RightLeg ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( TastyHeart ), Utility.RandomMinMax( 10, 20 ) );
				Add( typeof( BodyPart ), Utility.RandomMinMax( 30, 90 ) );
				Add( typeof( Head ), Utility.RandomMinMax( 10, 20 ) );
				Add( typeof( LeftArm ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RightArm ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Torso ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Bone ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RibCage ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( BonePile ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Bones ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( GraveChest ), Utility.RandomMinMax( 100, 500 ) );
				Add( typeof( EmbalmingFluid ), Utility.RandomMinMax( 25, 45 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBAlchemist : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBAlchemist()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{  
			Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MortarPestle ), 8, Utility.Random( 1,15 ), 0xE9B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MixingCauldron ), 247, 1, 0x269C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MixingSpoon ), 34, Utility.Random( 1,15 ), 0x1E27, 0x979 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CBookNecroticAlchemy ), 50, Utility.Random( 1,15 ), 0x2253, 0x4AA ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AlchemicalElixirs ), 50, Utility.Random( 1,15 ), 0x2219, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AlchemicalMixtures ), 50, Utility.Random( 1,15 ), 0x2223, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BookOfPoisons ), 50, Utility.Random( 1,15 ), 0x2253, 0x4F8 ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Bottle ), 5, Utility.Random( 1000 ), 0xF0E, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Jar ), 5, Utility.Random( 100 ), 0x10B4, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( HeatingStand ), 2, Utility.Random( 1,15 ), 0x1849, 0 ) ); } 

				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BlackPearl ), 5, Utility.Random( 2000 ), 0x266F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bloodmoss ), 5, Utility.Random( 2000), 0xF7B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Garlic ), 3, Utility.Random( 2000), 0xF84, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ginseng ), 3, Utility.Random( 2000 ), 0xF85, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MandrakeRoot ), 3, Utility.Random( 2000 ), 0xF86, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Nightshade ), 3, Utility.Random( 2000 ), 0xF88, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SpidersSilk ), 3, Utility.Random( 2000 ), 0xF8D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SulfurousAsh ), 3, Utility.Random( 2000 ), 0xF8C, 0 ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Brimstone ), 6, Utility.Random( 1000 ), 0x2FD3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ButterflyWings ), 6, Utility.Random( 1000 ), 0x3002, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( EyeOfToad ), 6, Utility.Random( 1000), 0x2FDA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FairyEgg ), 6, Utility.Random( 1000 ), 0x2FDB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GargoyleEar ), 6, Utility.Random( 100 ), 0x2FD9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BeetleShell ), 6, Utility.Random( 100 ), 0x2FF8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MoonCrystal ), 6, Utility.Random( 100 ), 0x3003, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PixieSkull ), 6, Utility.Random( 100 ), 0x2FE1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RedLotus ), 6, Utility.Random( 100 ), 0x2FE8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SeaSalt ), 6, Utility.Random( 100 ), 0x2FE9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SilverWidow ), 6, Utility.Random( 100 ), 0x2FF7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SwampBerries ), 6, Utility.Random( 100 ), 0x2FE0, 0 ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BottleOfAcid ), 600, Utility.Random( 1,15 ), 0x180F, 1167 ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RefreshPotion ), 15, Utility.Random( 1,15 ), 0xF0B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AgilityPotion ), 15, Utility.Random( 1,15 ), 0xF08, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( NightSightPotion ), 15, Utility.Random( 1,15 ), 0xF06, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LesserHealPotion ), 15, Utility.Random( 1,15 ), 0x25FD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StrengthPotion ), 15, Utility.Random( 1,15 ), 0xF09, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LesserPoisonPotion ), 15, Utility.Random( 1,15 ), 0x2600, 0 ) ); }
 				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LesserCurePotion ), 15, Utility.Random( 1,15 ), 0x233B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LesserExplosionPotion ), 21, Utility.Random( 1,15 ), 0x2407, 0 ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( HealPotion ), 30, Utility.Random( 1,15 ), 0xF0C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( PoisonPotion ), 30, Utility.Random( 1,15 ), 0xF0A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( CurePotion ), 30, Utility.Random( 1,15 ), 0xF07, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( ExplosionPotion ), 42, Utility.Random( 1,15 ), 0xF0D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( ConflagrationPotion ), 30, Utility.Random( 1,15 ), 0x180F, 0x489 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( ConfusionBlastPotion ), 30, Utility.Random( 1,15 ), 0x180F, 0x48D ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( FrostbitePotion ), 30, Utility.Random( 1,15 ), 0x180F, 0xAF3 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( TotalRefreshPotion ), 30, Utility.Random( 1,15 ), 0x25FF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GreaterAgilityPotion ), 60, Utility.Random( 1,15 ), 0x256A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GreaterConflagrationPotion ), 60, Utility.Random( 1,15 ), 0x2406, 0x489 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GreaterConfusionBlastPotion ), 60, Utility.Random( 1,15 ), 0x2406, 0x48D ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GreaterCurePotion ), 60, Utility.Random( 1,15 ), 0x24EA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GreaterExplosionPotion ), 60, Utility.Random( 1,15 ), 0x2408, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GreaterFrostbitePotion ), 60, Utility.Random( 1,15 ), 0x2406, 0xAF3 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GreaterHealPotion ), 60, Utility.Random( 1,15 ), 0x25FE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GreaterPoisonPotion ), 60, Utility.Random( 1,15 ), 0x2601, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GreaterStrengthPotion ), 60, Utility.Random( 1,15 ), 0x25F7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( DeadlyPoisonPotion ), 60, Utility.Random( 1,15 ), 0x2669, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( LesserInvisibilityPotion ), 860, Utility.Random( 1,3 ), 0x23BD, 0x490 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( LesserManaPotion ), 860, Utility.Random( 1,3 ), 0x23BD, 0x48D ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( LesserRejuvenatePotion ), 860, Utility.Random( 1,3 ), 0x23BD, 0x48E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( InvisibilityPotion ), 890, Utility.Random( 1,3 ), 0x180F, 0x490 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( ManaPotion ), 890, Utility.Random( 1,3 ), 0x180F, 0x48D ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( RejuvenatePotion ), 890, Utility.Random( 1,3 ), 0x180F, 0x48E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( GreaterInvisibilityPotion ), 8120, 1, 0x2406, 0x490 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( GreaterManaPotion ), 8120, 1, 0x2406, 0x48D ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( GreaterRejuvenatePotion ), 8120, 1, 0x2406, 0x48E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( InvulnerabilityPotion ), 8300, 1, 0x180F, 0x48F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( AutoResPotion ), 8600, 1, 0xF04, 0 ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AlchemyTub ), 2400, Utility.Random( 1,5 ), 0x126A, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( AlchemyPouch ), Utility.Random( 2900,3500 ), Utility.Random( 1,2 ), 0x1C10, 0x89F ) ); }
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullMinotaur ), Utility.Random( 50,150 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullWyrm ), Utility.Random( 200,400 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullGreatDragon ), Utility.Random( 300,600 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullDragon ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullDemon ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullGiant ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CanopicJar ), Utility.Random( 50,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MixingCauldron ), 123 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MixingSpoon ), 17 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DragonTooth ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EnchantedSeaweed ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GhostlyDust ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldenSerpentVenom ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LichDust ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverSerpentVenom ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( UnicornHorn ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DemigodBlood ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DemonClaw ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DragonBlood ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BlackPearl ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bloodmoss ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MandrakeRoot ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Garlic ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ginseng ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Nightshade ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpidersSilk ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( typeof( SulfurousAsh ), 1 ); } // DO NOT WANT? 

				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Brimstone ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ButterflyWings ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EyeOfToad ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FairyEgg ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GargoyleEar ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BeetleShell ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MoonCrystal ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PixieSkull ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RedLotus ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SeaSalt ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverWidow ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SwampBerries ), 3 ); } // DO NOT WANT? 

				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bottle ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Jar ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MortarPestle ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AgilityPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AutoResPotion ), 94 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BottleOfAcid ), 32 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ConflagrationPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FrostbitePotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ConfusionBlastPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CurePotion ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DeadlyPoisonPotion ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ExplosionPotion ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreaterAgilityPotion ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreaterConflagrationPotion ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreaterFrostbitePotion ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreaterConfusionBlastPotion ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreaterCurePotion ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreaterExplosionPotion ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreaterHealPotion ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreaterInvisibilityPotion ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreaterManaPotion ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreaterPoisonPotion ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreaterRejuvenatePotion ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreaterStrengthPotion ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HealPotion ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( InvisibilityPotion ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( InvulnerabilityPotion ), 53 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LesserCurePotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LesserExplosionPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LesserHealPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LesserInvisibilityPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LesserManaPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LesserPoisonPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LesserRejuvenatePotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ManaPotion ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NightSightPotion ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PoisonPotion ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RefreshPotion ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RejuvenatePotion ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StrengthPotion ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TotalRefreshPotion ), 28 ); } // DO NOT WANT?

				Add( typeof( BottleOfParts ), Utility.Random( 10, 30 ) );
				Add( typeof( SpecialSeaweed ), Utility.Random( 15, 35 ) );
				Add( typeof( AlchemyTub ), Utility.Random( 200, 500 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBMixologist : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBMixologist()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( ElixirAlchemy ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirAnatomy ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirAnimalLore ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirAnimalTaming ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirArchery ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirArmsLore ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirBegging ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirBlacksmith ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirCamping ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirCarpentry ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirCartography ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirCooking ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirDetectHidden ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirDiscordance ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirEvalInt ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirFencing ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirFishing ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirFletching ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirFocus ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirForensics ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirHealing ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirHerding ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirHiding ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirInscribe ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirItemID ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirLockpicking ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirLumberjacking ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirMacing ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirMagicResist ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirMeditation ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirMining ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirMusicianship ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirParry ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirPeacemaking ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirPoisoning ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirProvocation ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirRemoveTrap ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirSnooping ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirSpiritSpeak ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirStealing ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirStealth ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirSwords ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirTactics ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirTailoring ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirTasteID ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirTinkering ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirTracking ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirVeterinary ), Utility.Random( 14, 35 ) );
				Add( typeof( ElixirWrestling ), Utility.Random( 14, 35 ) );
				Add( typeof( MixtureSlime ), Utility.Random( 14, 35 ) );
				Add( typeof( MixtureIceSlime ), Utility.Random( 14, 35 ) );
				Add( typeof( MixtureFireSlime ), Utility.Random( 14, 35 ) );
				Add( typeof( MixtureDiseasedSlime ), Utility.Random( 14, 35 ) );
				Add( typeof( MixtureRadiatedSlime ), Utility.Random( 14, 35 ) );
				Add( typeof( LiquidFire ), Utility.Random( 14, 35 ) );
				Add( typeof( LiquidGoo ), Utility.Random( 14, 35 ) );
				Add( typeof( LiquidIce ), Utility.Random( 14, 35 ) );
				Add( typeof( LiquidRot ), Utility.Random( 14, 35 ) );
				Add( typeof( LiquidPain ), Utility.Random( 14, 35 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBAnimalTrainer : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBAnimalTrainer()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 1){Add( new AnimalBuyInfo( 1, typeof( Brush ), 72, 10, 0x1373, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( Cat ), 132, 10, 201, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( Dog ), 170, 10, 217, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new AnimalBuyInfo( 1, typeof( Rabbit ), 106, 10, 205, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( Eagle ), 402, 10, 5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( BrownBear ), 855, 10, 167, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( GrizzlyBear ), 1767, 10, 212, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( Panther ), 1271, 10, 214, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( TimberWolf ), 768, 10, 225, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( Rat ), 107, 10, 238, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 10){Add( new GenericBuyInfo( typeof( StableStone ), 5000, Utility.Random( 1,3 ), 0x14E7, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( typeof( StableStone ), 2500 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( typeof( AlienEgg ), Utility.Random( 500,1000 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( typeof( DragonEgg ), Utility.Random( 500,1000 ) ); } // DO NOT WANT?
			}
		}
	}
	public class SBHumanAnimalTrainer : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBHumanAnimalTrainer()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new AnimalBuyInfo( 1, typeof( Horse ), 550, 10, 204, 0 ) );
				Add( new AnimalBuyInfo( 1, typeof( PackHorse ), 631, 10, 291, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new AnimalBuyInfo( 5, typeof( PackMule ), 10000, 1, 291, 0 ) ); }
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	public class SBGargoyleAnimalTrainer : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBGargoyleAnimalTrainer()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new AnimalBuyInfo( 1, typeof( SwampDragon ), 1700, 10, 0x31A, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new AnimalBuyInfo( 5, typeof( PackTurtle ), 14500, 1, 134, 0 ) ); }
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	public class SBElfAnimalTrainer : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBElfAnimalTrainer()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new AnimalBuyInfo( 1, typeof( ForestOstard ), 700, 10, 171, 0x89f ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( DesertOstard ), 700, 10, 171, 1701 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( SnowOstard ), 700, 10, 171, 0x481 ) ); }
				Add( new AnimalBuyInfo( 1, typeof( PackLlama ), 565, 10, 292, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new AnimalBuyInfo( 1, typeof( WhiteWolf ), 1000, 10, 277, 0x47E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new AnimalBuyInfo( 1, typeof( BlackWolf ), 1000, 10, 277, 0x76B ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new AnimalBuyInfo( 5, typeof( PackMule ), 10000, 1, 291, 0 ) ); }
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	public class SBBarbarianAnimalTrainer : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBBarbarianAnimalTrainer()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new AnimalBuyInfo( 1, typeof( Horse ), 550, 10, 204, 0 ) );
				Add( new AnimalBuyInfo( 1, typeof( PackHorse ), 631, 10, 291, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new AnimalBuyInfo( 5, typeof( PackMule ), 10000, 1, 291, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( GreatBear ), 1500, 10, 213, 0x908 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( KodiakBear ), 1500, 10, 213, 0x76B ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new AnimalBuyInfo( 5, typeof( PackBear ), 12500, 1, 213, 0x908 ) ); }
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	public class SBOrkAnimalTrainer : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBOrkAnimalTrainer()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new AnimalBuyInfo( 1, typeof( Ridgeback ), 1500, 10, 187, 0x7D1 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new AnimalBuyInfo( 5, typeof( PackStegosaurus ), 15500, 1, 134, 0 ) ); }
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBArchitect : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBArchitect()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( InteriorDecorator ), 100, Utility.Random( 1,15 ), 0x1EBA, 0 ) );
				Add( new GenericBuyInfo( typeof( HousePlacementTool ), 50, Utility.Random( 1,15 ), 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "house teleporter", typeof( PlayersHouseTeleporter ), 8000, Utility.Random( 1,10 ), 0x181D, 0 ) );
				Add( new GenericBuyInfo( "house high teleporter", typeof( PlayersZTeleporter ), 4000, Utility.Random( 1,10 ), 0x181D, 0 ) );
				if ( Server.Items.BasementDoor.IsEnabled() ){ Add( new GenericBuyInfo( typeof( BasementDoor ), 2500, Utility.Random( 1,15 ), 0x02C1, 0 ) ); }
				Add( new GenericBuyInfo( typeof( house_sign_sign_post_a ), 5, Utility.Random( 1,15 ), 2967, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_post_b ), 5, Utility.Random( 1,15 ), 2970, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_merc ), 10, Utility.Random( 1,15 ), 3082, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_armor ), 10, Utility.Random( 1,15 ), 3008, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_bake ), 10, Utility.Random( 1,15 ), 2980, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_bank ), 10, Utility.Random( 1,15 ), 3084, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_bard ), 10, Utility.Random( 1,15 ), 3004, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_smith ), 10, Utility.Random( 1,15 ), 3016, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_bow ), 10, Utility.Random( 1,15 ), 3022, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_ship ), 10, Utility.Random( 1,15 ), 2998, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_fletch ), 10, Utility.Random( 1,15 ), 3006, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_heal ), 10, Utility.Random( 1,15 ), 2988, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_inn ), 10, Utility.Random( 1,15 ), 2996, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_gem ), 10, Utility.Random( 1,15 ), 3010, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_book ), 10, Utility.Random( 1,15 ), 2966, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_mage ), 10, Utility.Random( 1,15 ), 2990, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_necro ), 10, Utility.Random( 1,15 ), 2811, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_supply ), 10, Utility.Random( 1,15 ), 3020, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_herb ), 10, Utility.Random( 1,15 ), 3014, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_pen ), 10, Utility.Random( 1,15 ), 3000, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_sew ), 10, Utility.Random( 1,15 ), 2982, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_tavern ), 10, Utility.Random( 1,15 ), 3012, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_tinker ), 10, Utility.Random( 1,15 ), 2984, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_wood ), 10, Utility.Random( 1,15 ), 2992, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StoneWellDeed ), 500, 1, 0xF3A, 0xB97 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RedWellDeed ), 500, 1, 0xF3A, 0xB97 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MarbleWellDeed ), 500, 1, 0xF3A, 0xB97 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BrownWellDeed ), 500, 1, 0xF3A, 0xB97 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BlackWellDeed ), 500, 1, 0xF3A, 0xB97 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodWellDeed ), 500, 1, 0xF3A, 0xB97 ) ); }
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( InteriorDecorator ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HousePlacementTool ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlayersHouseTeleporter ), 4000 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlayersZTeleporter ), 2000 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_post_a ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_post_b ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_merc ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_armor ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_bake ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_bank ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_bard ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_smith ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_bow ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_ship ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_fletch ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_heal ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_inn ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_gem ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_book ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_mage ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_necro ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_supply ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_herb ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_pen ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_sew ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_tavern ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_tinker ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( house_sign_sign_wood ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StoneWellDeed ), 250 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RedWellDeed ), 250 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MarbleWellDeed ), 250 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BrownWellDeed ), 250 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BlackWellDeed ), 250 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodWellDeed ), 250 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBBaker : SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBBaker() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{ 
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( BreadLoaf ), 6, Utility.Random( 1,15 ), 0x103B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BreadLoaf ), 5, Utility.Random( 1,15 ), 0x103C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ApplePie ), 7, Utility.Random( 1,15 ), 0x1041, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Cake ), 13, Utility.Random( 1,15 ), 0x9E9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Muffins ), 3, Utility.Random( 1,15 ), 0x9EA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SackFlour ), 3, Utility.Random( 1,15 ), 0x1039, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FrenchBread ), 5, Utility.Random( 1,15 ), 0x98C, 0 ) ); }
             	if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Cookies ), 3, Utility.Random( 1,15 ), 0x160b, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CheesePizza ), 8, 10, 0x1040, 0 ) ); } // OSI just has Pizza
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add (new GenericBuyInfo( typeof( BowlFlour ), 7, Utility.Random( 1,15 ), 0xA1E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( JarHoney ), 600, Utility.Random( 1,15 ), 0x9EC, 0 ) ); }
				Add( new GenericBuyInfo( typeof( Beeswax ), 1000, Utility.Random( 1,15 ), 0x1422, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiBeeHiveDeed ), 2000, Utility.Random( 1,10 ), 2330, 0 ) ); 
				Add( new GenericBuyInfo( typeof( HiveTool ), 100, Utility.Random( 1,15 ), 2549, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiSmallWaxPot ), 250, Utility.Random( 1,15 ), 2532, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiLargeWaxPot ), 400, Utility.Random( 1,15 ), 2541, 0 ) ); 
				Add( new GenericBuyInfo( typeof( WaxingPot ), 50, Utility.Random( 1,15 ), 0x142B, 0 ) ); 
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( JuicersTools ), 500, 20, 0xE4F, 0 ) );
				Add( new GenericBuyInfo( typeof( Keg ), 50, 20, 0xE7F, 0 ) );
				Add( new GenericBuyInfo( typeof( BrewersTools ), 500, 20, 0x1EBC, 0 ) );
				Add( new GenericBuyInfo( typeof( BreweryLabelMaker ), 500, 20, 0xFBF, 0 ) );
				Add( new GenericBuyInfo( typeof( Malt ), 10, 20, 0x103D, 0 ) );
				Add( new GenericBuyInfo( typeof( Barley ), 20, 20, 0x103F, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyAleBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyMeadBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyJug ), 10, 20, 0x9C8, 0 ) );
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( Apple ), 3, 20, 0x9D0, 0 ) );
				Add( new GenericBuyInfo( typeof( Grapes ), 3, 20, 0x9D1, 0 ) );
				Add( new GenericBuyInfo( typeof( Watermelon ), 7, 20, 0xC5C, 0 ) );
				Add( new GenericBuyInfo( typeof( YellowGourd ), 3, 20, 0xC64, 0 ) );
				Add( new GenericBuyInfo( typeof( Pumpkin ), 11, 20, 0xC6A, 0 ) );
				Add( new GenericBuyInfo( typeof( Onion ), 3, 20, 0xC6D, 0 ) );
				Add( new GenericBuyInfo( typeof( Lettuce ), 5, 20, 0xC70, 0 ) );
				Add( new GenericBuyInfo( typeof( Squash ), 3, 20, 0xC72, 0 ) );
				Add( new GenericBuyInfo( typeof( HoneydewMelon ), 7, 20, 0xC74, 0 ) );
				Add( new GenericBuyInfo( typeof( Carrot ), 3, 20, 0xC77, 0 ) );
				Add( new GenericBuyInfo( typeof( Cantaloupe ), 6, 20, 0xC79, 0 ) );
				Add( new GenericBuyInfo( typeof( Cabbage ), 5, 20, 0xC7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lemon ), 3, 20, 0x1728, 0 ) );
				Add( new GenericBuyInfo( typeof( Lime ), 3, 20, 0x172A, 0 ) );
				Add( new GenericBuyInfo( typeof( Peach ), 3, 20, 0x9D2, 0 ) );
				Add( new GenericBuyInfo( typeof( Pear ), 3, 20, 0x994, 0 ) );
				Add( new GenericBuyInfo( "1060834", typeof( Engines.Plants.PlantBowl ), 2, 20, 0x15FD, 0 ) );
				Add( new GenericBuyInfo( "Cotton Seed", typeof( CottonSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Flax Seed", typeof( FlaxSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Wheat Seed", typeof( WheatSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Planting Corn", typeof( CornSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Carrot Seed", typeof( CarrotSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Onion Seed", typeof( OnionSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Garlic Seed", typeof( GarlicSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Lettuce Seed", typeof( LettuceSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Cabbage Seed", typeof( CabbageSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{ 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BreadLoaf ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FrenchBread ), 1 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Cake ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Cookies ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Muffins ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CheesePizza ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ApplePie ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PeachCobbler ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Quiche ), 6 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Dough ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pitcher ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SackFlour ), 1 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Eggs ), 1 ); } // DO NOT WANT? 
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBBanker : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBBanker()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "1041243", typeof( ContractOfEmployment ), 1252, Utility.Random( 1,15 ), 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "1062332", typeof( VendorRentalContract ), 1252, Utility.Random( 1,15 ), 0x14F0, 0x672 ) );
				Add( new GenericBuyInfo( "1047016", typeof( CommodityDeed ), 5, Utility.Random( 1,15 ), 0x14F0, 0x47 ) );
				Add (new GenericBuyInfo( typeof( Safe ), 500000, Utility.Random( 1,5 ), 0x436, 0 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( TreasurePile05AddonDeed ), Utility.Random( 200,600 ) );
				Add( typeof( TreasurePile04AddonDeed ), Utility.Random( 200,600 ) );
				Add( typeof( TreasurePile3AddonDeed ), Utility.Random( 200,600 ) );
				Add( typeof( TreasurePile03AddonDeed ), Utility.Random( 200,600 ) );
				Add( typeof( TreasurePile2AddonDeed ), Utility.Random( 200,600 ) );
				Add( typeof( TreasurePile02AddonDeed ), Utility.Random( 200,600 ) );
				Add( typeof( TreasurePile01AddonDeed ), Utility.Random( 200,600 ) );
				Add( typeof( TreasurePileAddonDeed ), Utility.Random( 200,600 ) );
				Add( typeof( Safe ), Utility.Random( 100000,200000 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBBard: SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBBard() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Drums ), 21, Utility.Random( 1,15 ), 0x0E9C, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Tambourine ), 21, Utility.Random( 1,15 ), 0x0E9E, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LapHarp ), 21, Utility.Random( 1,15 ), 0x0EB2, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Lute ), 21, Utility.Random( 1,15 ), 0x0EB3, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BambooFlute ), 21, Utility.Random( 1,15 ), 0x2805, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 40){Add( new GenericBuyInfo( typeof( SongBook ), 24, Utility.Random( 1,5 ), 0x225A, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( EnergyCarolScroll ), 32, 1, 0x1F48, 0x96 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( FireCarolScroll ), 32, 1, 0x1F49, 0x96 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( IceCarolScroll ), 32, 1, 0x1F34, 0x96 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( KnightsMinneScroll ), 32, 1, 0x1F31, 0x96 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( PoisonCarolScroll ), 32, 1, 0x1F33, 0x96 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( JarsOfWaxInstrument ), 160, Utility.Random( 1,5 ), 0x1005, 0x845 ) ); }
Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );				
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JarsOfWaxInstrument ), 80 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LapHarp ), 10 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Lute ), 10 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Drums ), 10 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Harp ), 10 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Tambourine ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BambooFlute ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MySongbook ), Utility.Random( 50,200 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SongBook ), 12 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EnergyCarolScroll ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FireCarolScroll ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IceCarolScroll ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( KnightsMinneScroll ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PoisonCarolScroll ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ArmysPaeonScroll ), 6 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagesBalladScroll ), 6 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EnchantingEtudeScroll ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SheepfoeMamboScroll ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SinewyEtudeScroll ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EnergyThrenodyScroll ), 8 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FireThrenodyScroll ), 8 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IceThrenodyScroll ), 8 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PoisonThrenodyScroll ), 8 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FoeRequiemScroll ), 9 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicFinaleScroll ), 10 ); } // DO NOT WANT? 
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBBarkeeper : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBBarkeeper()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Ale, 7, Utility.Random( 1,15 ), 0x99F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Wine, 7, Utility.Random( 1,15 ), 0x9C7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Liquor, 7, Utility.Random( 1,15 ), 0x99B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Jug ), BeverageType.Cider, 13, Utility.Random( 1,15 ), 0x9C8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Milk, 7, Utility.Random( 1,15 ), 0x9F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Ale, 11, Utility.Random( 1,15 ), 0x1F95, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Cider, 11, Utility.Random( 1,15 ), 0x1F97, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Liquor, 11, Utility.Random( 1,15 ), 0x1F99, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Wine, 11, Utility.Random( 1,15 ), 0x1F9B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Water, 11, Utility.Random( 1,15 ), 0x1F9D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( BreadLoaf ), 6, Utility.Random( 1,15 ), 0x103B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CheeseWheel ), 21, Utility.Random( 1,15 ), 0x97E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CookedBird ), 17, Utility.Random( 1,15 ), 0x9B7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LambLeg ), 8, Utility.Random( 1,15 ), 0x160A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfCarrots ), 3, Utility.Random( 1,15 ), 0x15F9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfCorn ), 3, Utility.Random( 1,15 ), 0x15FA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfLettuce ), 3, Utility.Random( 1,15 ), 0x15FB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfPeas ), 3, Utility.Random( 1,15 ), 0x15FC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( EmptyPewterBowl ), 2, Utility.Random( 1,15 ), 0x15FD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfCorn ), 3, Utility.Random( 1,15 ), 0x15FE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfLettuce ), 3, Utility.Random( 1,15 ), 0x15FF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfPeas ), 3, Utility.Random( 1,15 ), 0x1600, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfFoodPotatos ), 3, Utility.Random( 1,15 ), 0x1601, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfStew ), 3, Utility.Random( 1,15 ), 0x1604, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfTomatoSoup ), 3, Utility.Random( 1,15 ), 0x1606, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ApplePie ), 7, Utility.Random( 1,15 ), 0x1041, 0 ) ); } //OSI just has Pie, not Apple/Fruit/Meat
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( tarotpoker ), 5, Utility.Random( 1,15 ), 0x12AB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1016450", typeof( Chessboard ), 2, Utility.Random( 1,15 ), 0xFA6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1016449", typeof( CheckerBoard ), 2, Utility.Random( 1,15 ), 0xFA6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Engines.Mahjong.MahjongGame ), 6, Utility.Random( 1,15 ), 0xFAA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Backgammon ), 2, Utility.Random( 1,15 ), 0xE1C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Dices ), 2, Utility.Random( 1,15 ), 0xFA7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Waterskin ), 5, Utility.Random( 1,15 ), 0xA21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( HenchmanFighterItem ), 5000, Utility.Random( 1,15 ), 0x1419, 0xB96 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( HenchmanArcherItem ), 6000, Utility.Random( 1,15 ), 0xF50, 0xB96 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( HenchmanWizardItem ), 7000, Utility.Random( 1,15 ), 0xE30, 0xB96 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1041243", typeof( ContractOfEmployment ), 1252, Utility.Random( 1,15 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( "a barkeep contract", typeof( BarkeepContract ), 1252, Utility.Random( 1,15 ), 0x14F0, 0 ) ); }
				if ( Multis.BaseHouse.NewVendorSystem )
					if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1062332", typeof( VendorRentalContract ), 1252, Utility.Random( 1,15 ), 0x14F0, 0x672 ) ); }
				Add( new GenericBuyInfo( typeof( Beeswax ), 1000, Utility.Random( 1,15 ), 0x1422, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiBeeHiveDeed ), 2000, Utility.Random( 1,10 ), 2330, 0 ) ); 
				Add( new GenericBuyInfo( typeof( HiveTool ), 100, Utility.Random( 1,15 ), 2549, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiSmallWaxPot ), 250, Utility.Random( 1,15 ), 2532, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiLargeWaxPot ), 400, Utility.Random( 1,15 ), 2541, 0 ) ); 
				Add( new GenericBuyInfo( typeof( WaxingPot ), 50, Utility.Random( 1,15 ), 0x142B, 0 ) ); 
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( JuicersTools ), 500, 20, 0xE4F, 0 ) );
				Add( new GenericBuyInfo( typeof( Keg ), 50, 20, 0xE7F, 0 ) );
				Add( new GenericBuyInfo( typeof( BrewersTools ), 500, 20, 0x1EBC, 0 ) );
				Add( new GenericBuyInfo( typeof( BreweryLabelMaker ), 500, 20, 0xFBF, 0 ) );
				Add( new GenericBuyInfo( typeof( Malt ), 10, 20, 0x103D, 0 ) );
				Add( new GenericBuyInfo( typeof( Barley ), 20, 20, 0x103F, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyAleBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyMeadBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyJug ), 10, 20, 0x9C8, 0 ) );
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( Apple ), 3, 20, 0x9D0, 0 ) );
				Add( new GenericBuyInfo( typeof( Grapes ), 3, 20, 0x9D1, 0 ) );
				Add( new GenericBuyInfo( typeof( Watermelon ), 7, 20, 0xC5C, 0 ) );
				Add( new GenericBuyInfo( typeof( YellowGourd ), 3, 20, 0xC64, 0 ) );
				Add( new GenericBuyInfo( typeof( Pumpkin ), 11, 20, 0xC6A, 0 ) );
				Add( new GenericBuyInfo( typeof( Onion ), 3, 20, 0xC6D, 0 ) );
				Add( new GenericBuyInfo( typeof( Lettuce ), 5, 20, 0xC70, 0 ) );
				Add( new GenericBuyInfo( typeof( Squash ), 3, 20, 0xC72, 0 ) );
				Add( new GenericBuyInfo( typeof( HoneydewMelon ), 7, 20, 0xC74, 0 ) );
				Add( new GenericBuyInfo( typeof( Carrot ), 3, 20, 0xC77, 0 ) );
				Add( new GenericBuyInfo( typeof( Cantaloupe ), 6, 20, 0xC79, 0 ) );
				Add( new GenericBuyInfo( typeof( Cabbage ), 5, 20, 0xC7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lemon ), 3, 20, 0x1728, 0 ) );
				Add( new GenericBuyInfo( typeof( Lime ), 3, 20, 0x172A, 0 ) );
				Add( new GenericBuyInfo( typeof( Peach ), 3, 20, 0x9D2, 0 ) );
				Add( new GenericBuyInfo( typeof( Pear ), 3, 20, 0x994, 0 ) );
				Add( new GenericBuyInfo( "1060834", typeof( Engines.Plants.PlantBowl ), 2, 20, 0x15FD, 0 ) );
				Add( new GenericBuyInfo( "Cotton Seed", typeof( CottonSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Flax Seed", typeof( FlaxSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Wheat Seed", typeof( WheatSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Planting Corn", typeof( CornSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Carrot Seed", typeof( CarrotSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Onion Seed", typeof( OnionSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Garlic Seed", typeof( GarlicSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Lettuce Seed", typeof( LettuceSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Cabbage Seed", typeof( CabbageSeed ), 50, 20, 0xF27, 0x5E2 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfCarrots ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfCorn ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfLettuce ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfPeas ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmptyPewterBowl ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfCorn ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfLettuce ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfPeas ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfFoodPotatos ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfStew ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfTomatoSoup ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BeverageBottle ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Jug ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pitcher ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GlassMug ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BreadLoaf ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CheeseWheel ), 12 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ribs ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Peach ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pear ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Grapes ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Apple ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Banana ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Candle ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Chessboard ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CheckerBoard ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( tarotpoker ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MahjongGame ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Backgammon ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Dices ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ContractOfEmployment ), 626 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Waterskin ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RomulanAle ), Utility.Random( 20,100 ) ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBBeekeeper : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBBeekeeper()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( JarHoney ), 600, Utility.Random( 1,15 ), 0x9EC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( Beeswax ), 1000, Utility.Random( 1,15 ), 0x1422, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( new GenericBuyInfo( typeof( apiBeeHiveDeed ), 2000, Utility.Random( 1,10 ), 2330, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( new GenericBuyInfo( typeof( HiveTool ), 100, Utility.Random( 1,15 ), 2549, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( new GenericBuyInfo( typeof( apiSmallWaxPot ), 250, Utility.Random( 1,15 ), 2532, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( new GenericBuyInfo( typeof( apiLargeWaxPot ), 400, Utility.Random( 1,15 ), 2541, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( new GenericBuyInfo( typeof( WaxingPot ), 50, Utility.Random( 1,15 ), 0x142B, 0 ) ); }
				Add( new GenericBuyInfo( typeof( Beeswax ), 1000, Utility.Random( 1,15 ), 0x1422, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiBeeHiveDeed ), 2000, Utility.Random( 1,10 ), 2330, 0 ) ); 
				Add( new GenericBuyInfo( typeof( HiveTool ), 100, Utility.Random( 1,15 ), 2549, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiSmallWaxPot ), 250, Utility.Random( 1,15 ), 2532, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiLargeWaxPot ), 400, Utility.Random( 1,15 ), 2541, 0 ) ); 
				Add( new GenericBuyInfo( typeof( WaxingPot ), 50, Utility.Random( 1,15 ), 0x142B, 0 ) ); 
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( JuicersTools ), 500, 20, 0xE4F, 0 ) );
				Add( new GenericBuyInfo( typeof( Keg ), 50, 20, 0xE7F, 0 ) );
				Add( new GenericBuyInfo( typeof( BrewersTools ), 500, 20, 0x1EBC, 0 ) );
				Add( new GenericBuyInfo( typeof( BreweryLabelMaker ), 500, 20, 0xFBF, 0 ) );
				Add( new GenericBuyInfo( typeof( Malt ), 10, 20, 0x103D, 0 ) );
				Add( new GenericBuyInfo( typeof( Barley ), 20, 20, 0x103F, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyAleBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyMeadBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyJug ), 10, 20, 0x9C8, 0 ) );
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( Apple ), 3, 20, 0x9D0, 0 ) );
				Add( new GenericBuyInfo( typeof( Grapes ), 3, 20, 0x9D1, 0 ) );
				Add( new GenericBuyInfo( typeof( Watermelon ), 7, 20, 0xC5C, 0 ) );
				Add( new GenericBuyInfo( typeof( YellowGourd ), 3, 20, 0xC64, 0 ) );
				Add( new GenericBuyInfo( typeof( Pumpkin ), 11, 20, 0xC6A, 0 ) );
				Add( new GenericBuyInfo( typeof( Onion ), 3, 20, 0xC6D, 0 ) );
				Add( new GenericBuyInfo( typeof( Lettuce ), 5, 20, 0xC70, 0 ) );
				Add( new GenericBuyInfo( typeof( Squash ), 3, 20, 0xC72, 0 ) );
				Add( new GenericBuyInfo( typeof( HoneydewMelon ), 7, 20, 0xC74, 0 ) );
				Add( new GenericBuyInfo( typeof( Carrot ), 3, 20, 0xC77, 0 ) );
				Add( new GenericBuyInfo( typeof( Cantaloupe ), 6, 20, 0xC79, 0 ) );
				Add( new GenericBuyInfo( typeof( Cabbage ), 5, 20, 0xC7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lemon ), 3, 20, 0x1728, 0 ) );
				Add( new GenericBuyInfo( typeof( Lime ), 3, 20, 0x172A, 0 ) );
				Add( new GenericBuyInfo( typeof( Peach ), 3, 20, 0x9D2, 0 ) );
				Add( new GenericBuyInfo( typeof( Pear ), 3, 20, 0x994, 0 ) );
				Add( new GenericBuyInfo( "1060834", typeof( Engines.Plants.PlantBowl ), 2, 20, 0x15FD, 0 ) );
				Add( new GenericBuyInfo( "Cotton Seed", typeof( CottonSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Flax Seed", typeof( FlaxSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Wheat Seed", typeof( WheatSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Planting Corn", typeof( CornSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Carrot Seed", typeof( CarrotSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Onion Seed", typeof( OnionSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Garlic Seed", typeof( GarlicSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Lettuce Seed", typeof( LettuceSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Cabbage Seed", typeof( CabbageSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JarHoney ), 300 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Beeswax ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( apiBeeHiveDeed ), 1000 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HiveTool ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( apiSmallWaxPot ), 125 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( apiLargeWaxPot ), 200 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WaxingPot ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( ColorCandleShort ), 85 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( ColorCandleLong ), 90 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( Candle ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( CandleLarge ), 70 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( Candelabra ), 140 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( CandelabraStand ), 210 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( CandleLong ), 80 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( CandleShort ), 75 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( CandleSkull ), 95 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( CandleReligious ), 120 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( WallSconce ), 60 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( JarsOfWaxMetal ), 80 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( JarsOfWaxLeather ), 80 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( JarsOfWaxInstrument ), 80 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBBlacksmith : SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBBlacksmith() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{ 	
			Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( IronIngot ), 5, Utility.Random( 1,15 ), 0x1BF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Tongs ), 13, Utility.Random( 1,15 ), 0xFBB, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( SmithHammer ), 21, Utility.Random( 1,15 ), 0x0FB4, 0 ) ); }
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TopazIngot ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ShinySilverIngot ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmethystIngot ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmeraldIngot ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GarnetIngot ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IceIngot ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JadeIngot ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MarbleIngot ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OnyxIngot ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuartzIngot ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RubyIngot ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SapphireIngot ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinelIngot ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarRubyIngot ), 120 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Tongs ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IronIngot ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SmithHammer ), 10 ); } // DO NOT WANT?
				Add( typeof( MagicHammer ), Utility.Random( 300,400 ) );
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBBowyer : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBBowyer()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( FletcherTools ), 2, Utility.Random( 1,15 ), 0x1F2C, 0 ) );
				Add( new GenericBuyInfo( typeof( ArcherQuiver ), 32, Utility.Random( 1,5 ), 0x2B02, 0 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FletcherTools ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ArcherQuiver ), 16 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBButcher : SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBButcher() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bacon ), 7, Utility.Random( 1,15 ), 0x979, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ham ), 26, Utility.Random( 1,15 ), 0x9C9, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Sausage ), 18, Utility.Random( 1,15 ), 0x9C0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RawChickenLeg ), 6, Utility.Random( 1,15 ), 0x1607, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RawBird ), 9, Utility.Random( 1,15 ), 0x9B9, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RawLambLeg ), 9, Utility.Random( 1,15 ), 0x1609, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( RawRibs ), 16, Utility.Random( 1,15 ), 0x9F1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ButcherKnife ), 13, Utility.Random( 1,15 ), 0x13F6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Cleaver ), 13, Utility.Random( 1,15 ), 0xEC3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SkinningKnife ), 13, Utility.Random( 1,15 ), 0xEC4, 0 ) ); } 
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{ 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RawRibs ), 8 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RawLambLeg ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RawChickenLeg ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RawBird ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bacon ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Sausage ), 9 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ham ), 13 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ButcherKnife ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Cleaver ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinningKnife ), 7 ); } // DO NOT WANT? 
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBCarpenter: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBCarpenter()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Hatchet ), 25, Utility.Random( 1,15 ), 0xF44, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LumberAxe ), 27, Utility.Random( 1,15 ), 0xF43, 0x96D ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Nails ), 3, Utility.Random( 1,15 ), 0x102E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Axle ), 2, Utility.Random( 1,15 ), 0x105B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Board ), 3, Utility.Random( 1,15 ), 0x1BD7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DrawKnife ), 10, Utility.Random( 1,15 ), 0x10E4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Froe ), 10, Utility.Random( 1,15 ), 0x10E5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Scorp ), 10, Utility.Random( 1,15 ), 0x10E7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Inshave ), 10, Utility.Random( 1,15 ), 0x10E6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DovetailSaw ), 12, Utility.Random( 1,15 ), 0x1028, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Saw ), 15, Utility.Random( 1,15 ), 0x1034, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Hammer ), 17, Utility.Random( 1,15 ), 0x102A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MouldingPlane ), 11, Utility.Random( 1,15 ), 0x102C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SmoothingPlane ), 10, Utility.Random( 1,15 ), 0x1032, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( JointingPlane ), 11, Utility.Random( 1,15 ), 0x1030, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C43, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C45, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C47, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C89, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x38B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x38D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireG ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CC9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireH ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CCB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireI ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CCD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireJ ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D26, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmorShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3BF1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmorShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C31, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmorShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C63, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmorShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CAD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmorShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CEF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBakerShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C3B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBakerShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C65, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBakerShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C67, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBakerShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CBF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBakerShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CC1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBakerShelfF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CF1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBakerShelfG ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBlacksmithShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C41, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBlacksmithShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C4B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBlacksmithShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C6B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBlacksmithShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CC5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBlacksmithShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CF7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C15, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C2B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C2D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C33, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C5F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C61, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfG ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C79, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfH ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CA5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfI ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CA7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfJ ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CAF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfK ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CEB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfL ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CED, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfM ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D05, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBowyerShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C29, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBowyerShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C5D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBowyerShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CA3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBowyerShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CE9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewCarpenterShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C6F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewCarpenterShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CD7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewCarpenterShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CFB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C51, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C53, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C75, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C77, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CDD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CDF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfG ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CFF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfH ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D01, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDarkBookShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3BF9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDarkBookShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3BFB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDarkShelf ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3BFD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C7F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C81, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C83, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C85, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C87, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CB5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersG ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CB7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersH ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CB9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersI ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CBB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersJ ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CBD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersK ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D0B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersL ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D20, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersM ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D22, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersN ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D24, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrinkShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C27, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrinkShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C5B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrinkShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CA1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrinkShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CE7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrinkShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C1B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewHelmShelf ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3BFF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewHunterShelf ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C4D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewKitchenShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C19, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewKitchenShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C39, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewOldBookShelf ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x19FF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewPotionShelf ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3BF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewRuinedBookShelf ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0xC14, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C35, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C3D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C69, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C7B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CB1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CC3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfG ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfH ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D07, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShoeShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C37, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShoeShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C7D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShoeShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CB3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShoeShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D09, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewSorcererShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C4F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewSorcererShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C73, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewSorcererShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CDB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewSorcererShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CFD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewSupplyShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C57, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewSupplyShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C9D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewSupplyShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CE3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTailorShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C3F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTailorShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C6D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTailorShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CC7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTailorShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CF9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTannerShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C23, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTannerShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C49, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTavernShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C25, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTavernShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C59, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTavernShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C9F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTavernShelfF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CE5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTinkerShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C71, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTinkerShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CD9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTinkerShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D03, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTortureShelf ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C2F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewWizardShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C17, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewWizardShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C1D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewWizardShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewWizardShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C55, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewWizardShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C9B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewWizardShelfF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CE1, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				//Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Hatchet ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LumberAxe ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBox ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SmallCrate ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MediumCrate ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LargeCrate ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenChest ), 15 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LargeTable ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Nightstand ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( YewWoodTable ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Throne ), 24 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenThrone ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Stool ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FootStool ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FancyWoodenChairCushion ), 12 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenChairCushion ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenChair ), 8 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BambooChair ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBench ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Saw ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Scorp ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SmoothingPlane ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DrawKnife ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Froe ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Hammer ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Inshave ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JointingPlane ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MouldingPlane ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DovetailSaw ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Axle ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Club ), 13 ); } // DO NOT WANT?

				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Log ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AshLog ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CherryLog ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EbonyLog ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldenOakLog ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HickoryLog ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MahoganyLog ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DriftwoodLog ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OakLog ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PineLog ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GhostLog ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RosewoodLog ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WalnutLog ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ElvenLog ), 12 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PetrifiedLog ), 7 ); } // DO NOT WANT?

				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Board ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AshBoard ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CherryBoard ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EbonyBoard ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldenOakBoard ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HickoryBoard ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MahoganyBoard ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DriftwoodBoard ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OakBoard ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PineBoard ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GhostBoard ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RosewoodBoard ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WalnutBoard ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ElvenBoard ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PetrifiedBoard ), 8 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBCobbler : SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBCobbler() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{ 	
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ThighBoots ), 15, Utility.Random( 1,15 ), 0x1711, Utility.RandomNeutralHue() ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Shoes ), 8, Utility.Random( 1,15 ), 0x170f, Utility.RandomNeutralHue() ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Boots ), 10, Utility.Random( 1,15 ), 0x170b, Utility.RandomNeutralHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Sandals ), 5, Utility.Random( 1,15 ), 0x170d, Utility.RandomNeutralHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherSandals ), 60, Utility.Random( 1,15 ), 0x170d, 0x83E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherShoes ), 75, Utility.Random( 1,15 ), 0x170f, 0x83E ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherBoots ), 90, Utility.Random( 1,15 ), 0x170b, 0x83E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherThighBoots ), 105, Utility.Random( 1,15 ), 0x1711, 0x83E ) ); }  
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{ 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicBoots ), 70 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Shoes ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Boots ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ThighBoots ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Sandals ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( MagicBoots ), 25 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherSandals ), 30 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherShoes ), 37 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherBoots ), 45 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherThighBoots ), 52 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( LeatherSoftBoots ), 60 ); } // DO NOT WANT? 
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBCook : SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBCook() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			
			{ 
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BreadLoaf ), 5, Utility.Random( 1,15 ), 0x103B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( BreadLoaf ), 5, Utility.Random( 1,15 ), 0x103C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ApplePie ), 7, Utility.Random( 1,15 ), 0x1041, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Cake ), 13, Utility.Random( 1,15 ), 0x9E9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Muffins ), 3, Utility.Random( 1,15 ), 0x9EA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CheeseWheel ), 21, Utility.Random( 1,15 ), 0x97E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CookedBird ), 17, Utility.Random( 1,15 ), 0x9B7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LambLeg ), 8, Utility.Random( 1,15 ), 0x160A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ChickenLeg ), 5, Utility.Random( 1,15 ), 0x1608, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfCarrots ), 3, Utility.Random( 1,15 ), 0x15F9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfCorn ), 3, Utility.Random( 1,15 ), 0x15FA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfLettuce ), 3, Utility.Random( 1,15 ), 0x15FB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfPeas ), 3, Utility.Random( 1,15 ), 0x15FC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( EmptyPewterBowl ), 2, Utility.Random( 1,15 ), 0x15FD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfCorn ), 3, Utility.Random( 1,15 ), 0x15FE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfLettuce ), 3, Utility.Random( 1,15 ), 0x15FF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfPeas ), 3, Utility.Random( 1,15 ), 0x1600, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfFoodPotatos ), 3, Utility.Random( 1,15 ), 0x1601, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfStew ), 3, Utility.Random( 1,15 ), 0x1604, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfTomatoSoup ), 3, Utility.Random( 1,15 ), 0x1606, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RoastPig ), 106, Utility.Random( 1,15 ), 0x9BB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SackFlour ), 3, Utility.Random( 1,15 ), 0x1039, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RollingPin ), 2, Utility.Random( 1,15 ), 0x1043, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FlourSifter ), 2, Utility.Random( 1,15 ), 0x103E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1044567", typeof( Skillet ), 3, Utility.Random( 1,15 ), 0x97F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GardenTool ), 12, Utility.Random( 1,15 ), 0xDFD, 0x84F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( HerbalistCauldron ), 247, 1, 0x2676, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MixingSpoon ), 34, Utility.Random( 1,15 ), 0x1E27, 0x979 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Jar ), 5, Utility.Random( 1,15 ), 0x10B4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( CBookDruidicHerbalism ), 50, Utility.Random( 1,15 ), 0x2D50, 0 ) ); }
				Add( new GenericBuyInfo( typeof( Beeswax ), 1000, Utility.Random( 1,15 ), 0x1422, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiBeeHiveDeed ), 2000, Utility.Random( 1,10 ), 2330, 0 ) ); 
				Add( new GenericBuyInfo( typeof( HiveTool ), 100, Utility.Random( 1,15 ), 2549, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiSmallWaxPot ), 250, Utility.Random( 1,15 ), 2532, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiLargeWaxPot ), 400, Utility.Random( 1,15 ), 2541, 0 ) ); 
				Add( new GenericBuyInfo( typeof( WaxingPot ), 50, Utility.Random( 1,15 ), 0x142B, 0 ) ); 
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( JuicersTools ), 500, 20, 0xE4F, 0 ) );
				Add( new GenericBuyInfo( typeof( Keg ), 50, 20, 0xE7F, 0 ) );
				Add( new GenericBuyInfo( typeof( BrewersTools ), 500, 20, 0x1EBC, 0 ) );
				Add( new GenericBuyInfo( typeof( BreweryLabelMaker ), 500, 20, 0xFBF, 0 ) );
				Add( new GenericBuyInfo( typeof( Malt ), 10, 20, 0x103D, 0 ) );
				Add( new GenericBuyInfo( typeof( Barley ), 20, 20, 0x103F, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyAleBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyMeadBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyJug ), 10, 20, 0x9C8, 0 ) );
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( Apple ), 3, 20, 0x9D0, 0 ) );
				Add( new GenericBuyInfo( typeof( Grapes ), 3, 20, 0x9D1, 0 ) );
				Add( new GenericBuyInfo( typeof( Watermelon ), 7, 20, 0xC5C, 0 ) );
				Add( new GenericBuyInfo( typeof( YellowGourd ), 3, 20, 0xC64, 0 ) );
				Add( new GenericBuyInfo( typeof( Pumpkin ), 11, 20, 0xC6A, 0 ) );
				Add( new GenericBuyInfo( typeof( Onion ), 3, 20, 0xC6D, 0 ) );
				Add( new GenericBuyInfo( typeof( Lettuce ), 5, 20, 0xC70, 0 ) );
				Add( new GenericBuyInfo( typeof( Squash ), 3, 20, 0xC72, 0 ) );
				Add( new GenericBuyInfo( typeof( HoneydewMelon ), 7, 20, 0xC74, 0 ) );
				Add( new GenericBuyInfo( typeof( Carrot ), 3, 20, 0xC77, 0 ) );
				Add( new GenericBuyInfo( typeof( Cantaloupe ), 6, 20, 0xC79, 0 ) );
				Add( new GenericBuyInfo( typeof( Cabbage ), 5, 20, 0xC7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lemon ), 3, 20, 0x1728, 0 ) );
				Add( new GenericBuyInfo( typeof( Lime ), 3, 20, 0x172A, 0 ) );
				Add( new GenericBuyInfo( typeof( Peach ), 3, 20, 0x9D2, 0 ) );
				Add( new GenericBuyInfo( typeof( Pear ), 3, 20, 0x994, 0 ) );
				Add( new GenericBuyInfo( "1060834", typeof( Engines.Plants.PlantBowl ), 2, 20, 0x15FD, 0 ) );
				Add( new GenericBuyInfo( "Cotton Seed", typeof( CottonSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Flax Seed", typeof( FlaxSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Wheat Seed", typeof( WheatSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Planting Corn", typeof( CornSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Carrot Seed", typeof( CarrotSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Onion Seed", typeof( OnionSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Garlic Seed", typeof( GarlicSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Lettuce Seed", typeof( LettuceSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Cabbage Seed", typeof( CabbageSeed ), 50, 20, 0xF27, 0x5E2 ) );
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{ 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CheeseWheel ), 12 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CookedBird ), 8 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RoastPig ), 53 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Cake ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SackFlour ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BreadLoaf ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ChickenLeg ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LambLeg ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Skillet ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FlourSifter ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RollingPin ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Muffins ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ApplePie ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfCarrots ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfCorn ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfLettuce ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfPeas ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmptyPewterBowl ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfCorn ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfLettuce ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfPeas ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfFoodPotatos ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfStew ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfTomatoSoup ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GardenTool ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HerbalistCauldron ), 123 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MixingSpoon ), 17 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlantHerbalism_Leaf ), Utility.Random( 3,7 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlantHerbalism_Flower ), Utility.Random( 3,7 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlantHerbalism_Mushroom ), Utility.Random( 3,7 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlantHerbalism_Lilly ), Utility.Random( 3,7 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlantHerbalism_Cactus ), Utility.Random( 3,7 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlantHerbalism_Grass ), Utility.Random( 3,7 ) ); } // DO NOT WANT?
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBFarmer : SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBFarmer() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{ 
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Cabbage ), 5, Utility.Random( 1,15 ), 0xC7B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Cantaloupe ), 6, Utility.Random( 1,15 ), 0xC79, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Carrot ), 3, Utility.Random( 1,15 ), 0xC78, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( HoneydewMelon ), 7, Utility.Random( 1,15 ), 0xC74, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Squash ), 3, Utility.Random( 1,15 ), 0xC72, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Lettuce ), 5, Utility.Random( 1,15 ), 0xC70, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Onion ), 3, Utility.Random( 1,15 ), 0xC6D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Pumpkin ), 11, Utility.Random( 1,15 ), 0xC6A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GreenGourd ), 3, Utility.Random( 1,15 ), 0xC66, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( YellowGourd ), 3, Utility.Random( 1,15 ), 0xC64, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Watermelon ), 7, Utility.Random( 1,15 ), 0xC5C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Eggs ), 3, Utility.Random( 1,15 ), 0x9B5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Milk, 7, Utility.Random( 1,15 ), 0x9AD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Peach ), 3, Utility.Random( 1,15 ), 0x9D2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Pear ), 3, Utility.Random( 1,15 ), 0x994, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Lemon ), 3, Utility.Random( 1,15 ), 0x1728, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Lime ), 3, Utility.Random( 1,15 ), 0x172A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Grapes ), 3, Utility.Random( 1,15 ), 0x9D1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Apple ), 3, Utility.Random( 1,15 ), 0x9D0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SheafOfHay ), 2, Utility.Random( 1,15 ), 0xF36, 0 ) ); }
				Add( new GenericBuyInfo( typeof( Beeswax ), 1000, Utility.Random( 1,15 ), 0x1422, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiBeeHiveDeed ), 2000, Utility.Random( 1,10 ), 2330, 0 ) ); 
				Add( new GenericBuyInfo( typeof( HiveTool ), 100, Utility.Random( 1,15 ), 2549, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiSmallWaxPot ), 250, Utility.Random( 1,15 ), 2532, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiLargeWaxPot ), 400, Utility.Random( 1,15 ), 2541, 0 ) ); 
				Add( new GenericBuyInfo( typeof( WaxingPot ), 50, Utility.Random( 1,15 ), 0x142B, 0 ) ); 
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( JuicersTools ), 500, 20, 0xE4F, 0 ) );
				Add( new GenericBuyInfo( typeof( Keg ), 50, 20, 0xE7F, 0 ) );
				Add( new GenericBuyInfo( typeof( BrewersTools ), 500, 20, 0x1EBC, 0 ) );
				Add( new GenericBuyInfo( typeof( BreweryLabelMaker ), 500, 20, 0xFBF, 0 ) );
				Add( new GenericBuyInfo( typeof( Malt ), 10, 20, 0x103D, 0 ) );
				Add( new GenericBuyInfo( typeof( Barley ), 20, 20, 0x103F, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyAleBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyMeadBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyJug ), 10, 20, 0x9C8, 0 ) );
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( Apple ), 3, 20, 0x9D0, 0 ) );
				Add( new GenericBuyInfo( typeof( Grapes ), 3, 20, 0x9D1, 0 ) );
				Add( new GenericBuyInfo( typeof( Watermelon ), 7, 20, 0xC5C, 0 ) );
				Add( new GenericBuyInfo( typeof( YellowGourd ), 3, 20, 0xC64, 0 ) );
				Add( new GenericBuyInfo( typeof( Pumpkin ), 11, 20, 0xC6A, 0 ) );
				Add( new GenericBuyInfo( typeof( Onion ), 3, 20, 0xC6D, 0 ) );
				Add( new GenericBuyInfo( typeof( Lettuce ), 5, 20, 0xC70, 0 ) );
				Add( new GenericBuyInfo( typeof( Squash ), 3, 20, 0xC72, 0 ) );
				Add( new GenericBuyInfo( typeof( HoneydewMelon ), 7, 20, 0xC74, 0 ) );
				Add( new GenericBuyInfo( typeof( Carrot ), 3, 20, 0xC77, 0 ) );
				Add( new GenericBuyInfo( typeof( Cantaloupe ), 6, 20, 0xC79, 0 ) );
				Add( new GenericBuyInfo( typeof( Cabbage ), 5, 20, 0xC7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lemon ), 3, 20, 0x1728, 0 ) );
				Add( new GenericBuyInfo( typeof( Lime ), 3, 20, 0x172A, 0 ) );
				Add( new GenericBuyInfo( typeof( Peach ), 3, 20, 0x9D2, 0 ) );
				Add( new GenericBuyInfo( typeof( Pear ), 3, 20, 0x994, 0 ) );
				Add( new GenericBuyInfo( "1060834", typeof( Engines.Plants.PlantBowl ), 2, 20, 0x15FD, 0 ) );
				Add( new GenericBuyInfo( "Cotton Seed", typeof( CottonSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Flax Seed", typeof( FlaxSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Wheat Seed", typeof( WheatSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Planting Corn", typeof( CornSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Carrot Seed", typeof( CarrotSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Onion Seed", typeof( OnionSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Garlic Seed", typeof( GarlicSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Lettuce Seed", typeof( LettuceSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Cabbage Seed", typeof( CabbageSeed ), 50, 20, 0xF27, 0x5E2 ) );
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{ 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pitcher ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Eggs ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Apple ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Grapes ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Watermelon ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( YellowGourd ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreenGourd ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pumpkin ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Onion ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Lettuce ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Squash ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Carrot ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HoneydewMelon ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Cantaloupe ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Cabbage ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Lemon ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Lime ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Peach ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pear ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SheafOfHay ), 1 ); } // DO NOT WANT?
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBFisherman : SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBFisherman() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{ 
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RawFishSteak ), 3, Utility.Random( 1,15 ), 0x97A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Fish ), 6, Utility.Random( 1,15 ), 0x9CC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Fish ), 6, Utility.Random( 1,15 ), 0x9CD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Fish ), 6, Utility.Random( 1,15 ), 0x9CE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Fish ), 6, Utility.Random( 1,15 ), 0x9CF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( FishingPole ), 15, Utility.Random( 1,15 ), 0xDC0, 0 ) ); }
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{ 
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( RawFishSteak ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( Fish ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FishingPole ), 7 ); } // DO NOT WANT?
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBFortuneTeller : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBFortuneTeller()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Bandage ), 5, Utility.Random( 300,500 ), 0xE21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LesserHealPotion ), 15, Utility.Random( 1,15 ), 0x25FD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ginseng ), 3, Utility.Random( 1,15 ), 0xF85, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Garlic ), 3, Utility.Random( 1,15 ), 0xF84, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RefreshPotion ), 15, Utility.Random( 1,15 ), 0xF0B, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LesserHealPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RefreshPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Garlic ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ginseng ), 2 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBFurtrader : SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBFurtrader() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{ 
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Hides ), 4, Utility.Random( 1,100 ), 0x1078, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Leather ), 4, Utility.Random( 1,100 ), 0x1081, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Furs ), 5, Utility.Random( 1,25 ), 0x11F4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FursWhite ), 8, Utility.Random( 1,25 ), 0x11F4, 0x481 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FurCape ), 16, Utility.Random( 1,5 ), 0x230A, 0x907 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FurRobe ), 20, Utility.Random( 1,5 ), 0x1F03, 0x907 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FurBoots ), 10, Utility.Random( 1,5 ), 0x2307, 0x907 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FurCap ), 8, Utility.Random( 1,5 ), 0x1DB9, 0x907 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FurSarong ), 14, Utility.Random( 1,5 ), 0x230C, 0x907 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FurArms ), 100, Utility.Random( 1,15 ), 0x2B77, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FurTunic ), 121, Utility.Random( 1,15 ), 0x2B79, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FurLegs ), 100, Utility.Random( 1,15 ), 0x2B78, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WhiteFurCape ), 18, Utility.Random( 1,5 ), 0x230A, 0x481 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WhiteFurRobe ), 24, Utility.Random( 1,5 ), 0x1F03, 0x481 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WhiteFurBoots ), 12, Utility.Random( 1,5 ), 0x2307, 0x481 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WhiteFurCap ), 16, Utility.Random( 1,5 ), 0x1DB9, 0x481 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WhiteFurSarong ), 16, Utility.Random( 1,5 ), 0x230C, 0x481 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WhiteFurArms ), 100, Utility.Random( 1,15 ), 0x2B77, 0x481 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WhiteFurTunic ), 121, Utility.Random( 1,15 ), 0x2B79, 0x481 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WhiteFurLegs ), 100, Utility.Random( 1,15 ), 0x2B78, 0x481 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BearMask ), Utility.Random( 28,50 ), Utility.Random( 1,5 ), 0x1545, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DeerMask ), Utility.Random( 28,50 ), Utility.Random( 1,5 ), 0x1547, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WolfMask ), Utility.Random( 28,50 ), Utility.Random( 1,5 ), 0x2B6D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( DemonSkin ), 1235, Utility.Random( 1,10 ), 0x1081, Server.Misc.MaterialInfo.GetMaterialColor( "demon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( DragonSkin ), 1235, Utility.Random( 1,10 ), 0x1081, Server.Misc.MaterialInfo.GetMaterialColor( "dragon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( NightmareSkin ), 1228, Utility.Random( 1,10 ), 0x1081, Server.Misc.MaterialInfo.GetMaterialColor( "nightmare skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SerpentSkin ), 1214, Utility.Random( 1,10 ), 0x1081, Server.Misc.MaterialInfo.GetMaterialColor( "serpent skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( TrollSkin ), 1221, Utility.Random( 1,10 ), 0x1081, Server.Misc.MaterialInfo.GetMaterialColor( "troll skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( UnicornSkin ), 1228, Utility.Random( 1,10 ), 0x1081, Server.Misc.MaterialInfo.GetMaterialColor( "unicorn skin", "", 0 ) ) ); }
				Add( new GenericBuyInfo( "Waever's Spool", typeof( WeaversSpool ), 50, 20, 0xF27, 0x5E2 ) );
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{ 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( UnicornSkin ), 30 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Furs ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FursWhite ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DemonSkin ), 40 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DragonSkin ), 50 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NightmareSkin ), 30 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SerpentSkin ), 10 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TrollSkin ), 20 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FurCape ), 8 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WhiteFurCape ), 9 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FurRobe ), 10 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WhiteFurRobe ), 12 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FurBoots ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WhiteFurBoots ), 6 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FurSarong ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WhiteFurSarong ), 8 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FurCap ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WhiteFurCap ), 8 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FurArms ), 50 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FurTunic ), 60 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FurLegs ), 50 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WhiteFurArms ), 50 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WhiteFurTunic ), 60 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WhiteFurLegs ), 50 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BearMask ), 14 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DeerMask ), 14 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WolfMask ), 14 ); } // DO NOT WANT? 

				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Hides ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinedHides ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HornedHides ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BarbedHides ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NecroticHides ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( VolcanicHides ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FrozenHides ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoliathHides ), 6 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DraconicHides ), 6 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HellishHides ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DinosaurHides ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AlienHides ), 7 ); } // DO NOT WANT? 

				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Leather ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinedLeather ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HornedLeather ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BarbedLeather ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NecroticLeather ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( VolcanicLeather ), 6 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FrozenLeather ), 6 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoliathLeather ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DraconicLeather ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HellishLeather ), 8 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DinosaurLeather ), 8 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AlienLeather ), 8 ); } // DO NOT WANT? 
			} 
		} 
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBGlassblower : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBGlassblower()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bottle ), 5, Utility.Random( 1,15 ), 0xF0E, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Jar ), 5, Utility.Random( 1,15 ), 0x10B4, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( "Crafting Glass With Glassblowing", typeof( GlassblowingBook ), 10637, Utility.Random( 1,15 ), 0xFF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( "Finding Glass-Quality Sand", typeof( SandMiningBook ), 10637, Utility.Random( 1,15 ), 0xFF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1044608", typeof( Blowpipe ), 21, Utility.Random( 1,15 ), 0xE8A, 0x3B9 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bottle ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Jar ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GlassblowingBook ), 5000 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SandMiningBook ), 5000 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Blowpipe ), 10 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBHairStylist : SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBHairStylist() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{ 
			Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				Add( new GenericBuyInfo( "special beard dye", typeof( SpecialBeardDye ), 500, Utility.Random( 1,15 ), 0xE26, 0 ) );
				Add( new GenericBuyInfo( "special hair dye", typeof( SpecialHairDye ), 500, Utility.Random( 1,15 ), 0xE26, 0 ) );
				Add( new GenericBuyInfo( "1041060", typeof( HairDye ), 100, Utility.Random( 1,15 ), 0xEFF, 0 ) );
				Add( new GenericBuyInfo( "hair dye bottle", typeof( HairDyeBottle ), 1000, Utility.Random( 1,15 ), 0xE0F, 0 ) );
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{ 
				Add( typeof( HairDye ), 50 );
				Add( typeof( SpecialBeardDye ), 250 );
				Add( typeof( SpecialHairDye ), 250 );
				Add( typeof( HairDyeBottle ), 300 );
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBHealer : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBHealer()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Bandage ), 5, Utility.Random( 1000 ), 0xE21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LesserHealPotion ), 15, Utility.Random( 1,15 ), 0x25FD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ginseng ), 3, Utility.Random( 1000 ), 0xF85, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Garlic ), 3, Utility.Random( 1000 ), 0xF84, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RefreshPotion ), 15, Utility.Random( 1,15 ), 0xF0B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( GraveShovel ), 12, Utility.Random( 1,15 ), 0xF39, 0x966 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( SurgeonsKnife ), 14, Utility.Random( 1,15 ), 0xEC4, 0x1B0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LesserHealPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RefreshPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Garlic ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ginseng ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SurgeonsKnife ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FirstAidKit ), Utility.Random( 100,250 ) ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBDruid : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBDruid()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Bandage ), 5, Utility.Random( 1,15 ), 0xE21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LesserHealPotion ), 15, Utility.Random( 1,15 ), 0x25FD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ginseng ), 3, Utility.Random( 1,15 ), 0xF85, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Garlic ), 3, Utility.Random( 1,15 ), 0xF84, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RefreshPotion ), 15, Utility.Random( 1,15 ), 0xF0B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GardenTool ), 12, Utility.Random( 1,15 ), 0xDFD, 0x84F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( HerbalistCauldron ), 247, 1, 0x2676, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MixingSpoon ), 34, Utility.Random( 1,15 ), 0x1E27, 0x979 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Jar ), 5, Utility.Random( 1,15 ), 0x10B4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( CBookDruidicHerbalism ), 50, Utility.Random( 1,15 ), 0x2D50, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AppleTreeDeed ), 640, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CherryBlossomTreeDeed ), 540, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DarkBrownTreeDeed ), 540, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GreyTreeDeed ), 540, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LightBrownTreeDeed ), 540, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PeachTreeDeed ), 640, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PearTreeDeed ), 640, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AlchemyTub ), 2400, Utility.Random( 1,5 ), 0x126A, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( AlchemyPouch ), Utility.Random( 2900,3500 ), Utility.Random( 1,2 ), 0x1C10, 0x89F ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LesserHealPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RefreshPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Garlic ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ginseng ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GardenTool ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HerbalistCauldron ), 123 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MixingSpoon ), 17 ); } // DO NOT WANT?
				Add( typeof( AlchemyTub ), Utility.Random( 200, 500 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBDruidTree : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBDruidTree()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Bandage ), 5, Utility.Random( 1,15 ), 0xE21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LesserHealPotion ), 15, Utility.Random( 1,15 ), 0x25FD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ginseng ), 3, Utility.Random( 1,15 ), 0xF85, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Garlic ), 3, Utility.Random( 1,15 ), 0xF84, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RefreshPotion ), 15, Utility.Random( 1,15 ), 0xF0B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GardenTool ), 12, Utility.Random( 1,15 ), 0xDFD, 0x84F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( HerbalistCauldron ), 247, 1, 0x2676, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MixingSpoon ), 34, Utility.Random( 1,15 ), 0x1E27, 0x979 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Jar ), 5, Utility.Random( 1,15 ), 0x10B4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( CBookDruidicHerbalism ), 50, Utility.Random( 1,15 ), 0x2D50, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AlchemyTub ), 2400, Utility.Random( 1,5 ), 0x126A, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( AlchemyPouch ), Utility.Random( 2900,3500 ), Utility.Random( 1,2 ), 0x1C10, 0x89F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AppleTreeDeed ), 640, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CherryBlossomTreeDeed ), 540, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DarkBrownTreeDeed ), 540, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GreyTreeDeed ), 540, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LightBrownTreeDeed ), 540, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PeachTreeDeed ), 640, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PearTreeDeed ), 640, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( ShieldOfEarthPotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x300 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( WoodlandProtectionPotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x7E2 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( ProtectiveFairyPotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x9FF ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( HerbalHealingPotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x279 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GraspingRootsPotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x83F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( BlendWithForestPotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x59C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( SwarmOfInsectsPotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0xA70 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( VolcanicEruptionPotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x54E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( TreefellowPotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x223 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( StoneCirclePotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x396 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( DruidicRunePotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x487 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( LureStonePotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x967 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( NaturesPassagePotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x48B ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( MushroomGatewayPotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x3B7 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( RestorativeSoilPotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x479 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( FireflyPotion ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x491 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LesserHealPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RefreshPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Garlic ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ginseng ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GardenTool ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HerbalistCauldron ), 123 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MixingSpoon ), 17 ); } // DO NOT WANT?
				Add( typeof( AlchemyTub ), Utility.Random( 200, 500 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBHerbalist : SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBHerbalist() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{ 
			Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ginseng ), 3, Utility.Random( 1000,2000 ), 0xF85, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Garlic ), 3, Utility.Random( 1000,2000 ), 0xF84, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MandrakeRoot ), 3, Utility.Random( 1000,2000 ), 0xF86, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Nightshade ), 3, Utility.Random( 1000,2000 ), 0xF88, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bloodmoss ), 5, Utility.Random( 1000,2000 ), 0xF7B, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MortarPestle ), 8, Utility.Random( 1000,2000 ), 0xE9B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Jar ), 5, Utility.Random( 1000,2000 ), 0x10B4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GardenTool ), 12, Utility.Random( 1,15 ), 0xDFD, 0x84F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( HerbalistCauldron ), 247, 1, 0x2676, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MixingSpoon ), 34, Utility.Random( 1,15 ), 0x1E27, 0x979 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( CBookDruidicHerbalism ), 50, Utility.Random( 1,15 ), 0x2D50, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AlchemyTub ), 2400, Utility.Random( 1,5 ), 0x126A, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( AlchemyPouch ), Utility.Random( 2900,3500 ), Utility.Random( 1,2 ), 0x1C10, 0x89F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 99){Add( new GenericBuyInfo( typeof( HangingPlantA ), Utility.Random( 5000,10000 ), 1, 0x113F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 99){Add( new GenericBuyInfo( typeof( HangingPlantB ), Utility.Random( 5000,10000 ), 1, 0x1151, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 99){Add( new GenericBuyInfo( typeof( HangingPlantC ), Utility.Random( 5000,10000 ), 1, 0x1164, 0 ) ); }
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{ 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bloodmoss ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MandrakeRoot ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Garlic ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ginseng ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Nightshade ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Jar ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MortarPestle ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GardenTool ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HerbalistCauldron ), 123 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MixingSpoon ), 17 ); } // DO NOT WANT?
				Add( typeof( PlantHerbalism_Flower ), Utility.Random( 2, 6 ) );
				Add( typeof( PlantHerbalism_Leaf ), Utility.Random( 2, 6 ) );
				Add( typeof( PlantHerbalism_Mushroom ), Utility.Random( 2, 6 ) );
				Add( typeof( PlantHerbalism_Lilly ), Utility.Random( 2, 6 ) );
				Add( typeof( PlantHerbalism_Cactus ), Utility.Random( 2, 6 ) );
				Add( typeof( HomePlants_Flower ), Utility.Random( 100, 300 ) );
				Add( typeof( HomePlants_Leaf ), Utility.Random( 100, 300 ) );
				Add( typeof( HomePlants_Mushroom ), Utility.Random( 100, 300 ) );
				Add( typeof( HomePlants_Cactus ), Utility.Random( 100, 300 ) );
				Add( typeof( HomePlants_Lilly ), Utility.Random( 100, 300 ) );
				Add( typeof( HomePlants_Grass ), Utility.Random( 100, 300 ) );
				Add( typeof( SpecialSeaweed ), Utility.Random( 15, 35 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( typeof( HangingPlantA ), Utility.Random( 10, 100 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( typeof( HangingPlantB ), Utility.Random( 10, 100 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( typeof( HangingPlantC ), Utility.Random( 10, 100 ) ); } // DO NOT WANT? 
				Add( typeof( AlchemyTub ), Utility.Random( 200, 500 ) );
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBHolyMage : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBHolyMage()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Spellbook ), 18, Utility.Random( 1,15 ), 0xEFA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ScribesPen ), 8, Utility.Random( 1,15 ), 0x2051, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BlankScroll ), 5, Utility.Random( 1500,2000 ), 0x0E34, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1041072", typeof( MagicWizardsHat ), 11, Utility.Random( 1,15 ), 0x1718, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WitchHat ), 11, Utility.Random( 1,15 ), 0x2FC3, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RecallRune ), 15, Utility.Random( 1,15 ), 0x1f14, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BlackPearl ), 5, Utility.Random( 1000,1500 ), 0x266F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bloodmoss ), 5, Utility.Random( 1000,1500 ), 0xF7B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Garlic ), 3, Utility.Random( 1000,1500 ), 0xF84, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ginseng ), 3, Utility.Random( 1000,1500 ), 0xF85, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MandrakeRoot ), 3, Utility.Random( 1000,1500 ), 0xF86, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Nightshade ), 3, Utility.Random( 1000,1500 ), 0xF88, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SpidersSilk ), 3, Utility.Random( 1000,1500 ), 0xF8D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SulfurousAsh ), 3, Utility.Random( 1000,1500 ), 0xF8C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( new GenericBuyInfo( typeof( reagents_magic_jar1 ), 2000, Utility.Random( 1,15 ), 0x1007, 0 ) ); }

				Type[] types = Loot.RegularScrollTypes;

				for ( int i = 0; i < types.Length && i < 8; ++i )
				{
					int itemID = 0x1F2E + i;

					if ( i == 6 )
						itemID = 0x1F2D;
					else if ( i > 6 )
						--itemID;

					if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( types[i], 12 + ((i / 8) * 10), Utility.Random( 1,15 ), itemID, 0 ) ); }
				}
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicTalisman ), Utility.Random( 50,100 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BlackPearl ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bloodmoss ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MandrakeRoot ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Garlic ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ginseng ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Nightshade ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpidersSilk ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( typeof( SulfurousAsh ), 1 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RecallRune ), 8 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Spellbook ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BlankScroll ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( MysticalPearl ), 250 ); } // DO NOT WANT?

				Type[] types = Loot.RegularScrollTypes;

				for ( int i = 0; i < types.Length; ++i )
					if (Utility.RandomMinMax( 1, 100 ) > 54){Add( types[i], ((i / 8) + 2) * 5 ); } // DO NOT WANT?

				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ClumsyMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( CreateFoodMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FeebleMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( HealMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicArrowMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( NightSightMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ReactiveArmorMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( WeaknessMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( AgilityMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( CunningMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( CureMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( HarmMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicTrapMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicUntrapMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ProtectionMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( StrengthMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( BlessMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FireballMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicLockMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicUnlockMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( PoisonMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( TelekinesisMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( TeleportMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( WallofStoneMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ArchCureMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ArchProtectionMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( CurseMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FireFieldMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( GreaterHealMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( LightningMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ManaDrainMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( RecallMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( BladeSpiritsMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( DispelFieldMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( IncognitoMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicReflectionMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MindBlastMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ParalyzeMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( PoisonFieldMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( SummonCreatureMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( DispelMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EnergyBoltMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ExplosionMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( InvisibilityMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MarkMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MassCurseMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ParalyzeFieldMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( RevealMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ChainLightningMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EnergyFieldMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FlameStrikeMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( GateTravelMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ManaVampireMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MassDispelMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MeteorSwarmMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( PolymorphMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( AirElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EarthElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EarthquakeMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EnergyVortexMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FireElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ResurrectionMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( SummonDaemonMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( WaterElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MySpellbook ), Utility.Random( 100,500 ) ); } // DO NOT WANT?
				Add( typeof( TomeOfWands ), Utility.Random( 100,400 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBRuneCasting: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBRuneCasting()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			//Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( RuneMagicBook ), 500 );
				Add( typeof( RuneBag ), 200 );
				Add( typeof( An ), 50 );
				Add( typeof( Bet ), 50 );
				Add( typeof( Corp ), 50 );
				Add( typeof( Des ), 50 );
				Add( typeof( Ex ), 50 );
				Add( typeof( Flam ), 50 );
				Add( typeof( Grav ), 50 );
				Add( typeof( Hur ), 50 );
				Add( typeof( In ), 50 );
				Add( typeof( Jux ), 50 );
				Add( typeof( Kal ), 50 );
				Add( typeof( Lor ), 50 );
				Add( typeof( Mani ), 50 );
				Add( typeof( Nox ), 50 );
				Add( typeof( Ort ), 50 );
				Add( typeof( Por ), 50 );
				Add( typeof( Quas ), 50 );
				Add( typeof( Rel ), 50 );
				Add( typeof( Sanct ), 50 );
				Add( typeof( Tym ), 50 );
				Add( typeof( Uus ), 50 );
				Add( typeof( Vas ), 50 );
				Add( typeof( Wis ), 50 );
				Add( typeof( Xen ), 50 );
				Add( typeof( Ylem ), 50 );
				Add( typeof( Zu ), 50 );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBEnchanter : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBEnchanter()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){ Add( new GenericBuyInfo( typeof( ClumsyMagicStaff ), Utility.Random( 100,200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){ Add( new GenericBuyInfo( typeof( CreateFoodMagicStaff ), Utility.Random( 100,200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){ Add( new GenericBuyInfo( typeof( FeebleMagicStaff ), Utility.Random( 100,200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){ Add( new GenericBuyInfo( typeof( HealMagicStaff ), Utility.Random( 100,200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){ Add( new GenericBuyInfo( typeof( MagicArrowMagicStaff ), Utility.Random( 100,200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){ Add( new GenericBuyInfo( typeof( NightSightMagicStaff ), Utility.Random( 100,200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){ Add( new GenericBuyInfo( typeof( ReactiveArmorMagicStaff ), Utility.Random( 100,200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){ Add( new GenericBuyInfo( typeof( WeaknessMagicStaff ), Utility.Random( 100,200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 55){ Add( new GenericBuyInfo( typeof( AgilityMagicStaff ), Utility.Random( 200,400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 55){ Add( new GenericBuyInfo( typeof( CunningMagicStaff ), Utility.Random( 200,400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 55){ Add( new GenericBuyInfo( typeof( CureMagicStaff ), Utility.Random( 200,400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 55){ Add( new GenericBuyInfo( typeof( HarmMagicStaff ), Utility.Random( 200,400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 55){ Add( new GenericBuyInfo( typeof( MagicTrapMagicStaff ), Utility.Random( 200,400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 55){ Add( new GenericBuyInfo( typeof( MagicUntrapMagicStaff ), Utility.Random( 200,400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 55){ Add( new GenericBuyInfo( typeof( ProtectionMagicStaff ), Utility.Random( 200,400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 55){ Add( new GenericBuyInfo( typeof( StrengthMagicStaff ), Utility.Random( 200,400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 60){ Add( new GenericBuyInfo( typeof( BlessMagicStaff ), Utility.Random( 300,600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 60){ Add( new GenericBuyInfo( typeof( FireballMagicStaff ), Utility.Random( 300,600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 60){ Add( new GenericBuyInfo( typeof( MagicLockMagicStaff ), Utility.Random( 300,600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 60){ Add( new GenericBuyInfo( typeof( MagicUnlockMagicStaff ), Utility.Random( 300,600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 60){ Add( new GenericBuyInfo( typeof( PoisonMagicStaff ), Utility.Random( 300,600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 60){ Add( new GenericBuyInfo( typeof( TelekinesisMagicStaff ), Utility.Random( 300,600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 60){ Add( new GenericBuyInfo( typeof( TeleportMagicStaff ), Utility.Random( 300,600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 60){ Add( new GenericBuyInfo( typeof( WallofStoneMagicStaff ), Utility.Random( 300,600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 65){ Add( new GenericBuyInfo( typeof( ArchCureMagicStaff ), Utility.Random( 400,800 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 65){ Add( new GenericBuyInfo( typeof( ArchProtectionMagicStaff ), Utility.Random( 400,800 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 65){ Add( new GenericBuyInfo( typeof( CurseMagicStaff ), Utility.Random( 400,800 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 65){ Add( new GenericBuyInfo( typeof( FireFieldMagicStaff ), Utility.Random( 400,800 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 65){ Add( new GenericBuyInfo( typeof( GreaterHealMagicStaff ), Utility.Random( 400,800 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 65){ Add( new GenericBuyInfo( typeof( LightningMagicStaff ), Utility.Random( 400,800 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 65){ Add( new GenericBuyInfo( typeof( ManaDrainMagicStaff ), Utility.Random( 400,800 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 65){ Add( new GenericBuyInfo( typeof( RecallMagicStaff ), Utility.Random( 400,800 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 70){ Add( new GenericBuyInfo( typeof( BladeSpiritsMagicStaff ), Utility.Random( 500,1000 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 70){ Add( new GenericBuyInfo( typeof( DispelFieldMagicStaff ), Utility.Random( 500,1000 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 70){ Add( new GenericBuyInfo( typeof( IncognitoMagicStaff ), Utility.Random( 500,1000 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 70){ Add( new GenericBuyInfo( typeof( MagicReflectionMagicStaff ), Utility.Random( 500,1000 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 70){ Add( new GenericBuyInfo( typeof( MindBlastMagicStaff ), Utility.Random( 500,1000 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 70){ Add( new GenericBuyInfo( typeof( ParalyzeMagicStaff ), Utility.Random( 500,1000 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 70){ Add( new GenericBuyInfo( typeof( PoisonFieldMagicStaff ), Utility.Random( 500,1000 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 70){ Add( new GenericBuyInfo( typeof( SummonCreatureMagicStaff ), Utility.Random( 500,1000 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( new GenericBuyInfo( typeof( DispelMagicStaff ), Utility.Random( 600,1200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( new GenericBuyInfo( typeof( EnergyBoltMagicStaff ), Utility.Random( 600,1200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( new GenericBuyInfo( typeof( ExplosionMagicStaff ), Utility.Random( 600,1200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( new GenericBuyInfo( typeof( InvisibilityMagicStaff ), Utility.Random( 600,1200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( new GenericBuyInfo( typeof( MarkMagicStaff ), Utility.Random( 600,1200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( new GenericBuyInfo( typeof( MassCurseMagicStaff ), Utility.Random( 600,1200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( new GenericBuyInfo( typeof( ParalyzeFieldMagicStaff ), Utility.Random( 600,1200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( new GenericBuyInfo( typeof( RevealMagicStaff ), Utility.Random( 600,1200 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 85){ Add( new GenericBuyInfo( typeof( ChainLightningMagicStaff ), Utility.Random( 700,1400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 85){ Add( new GenericBuyInfo( typeof( EnergyFieldMagicStaff ), Utility.Random( 700,1400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 85){ Add( new GenericBuyInfo( typeof( FlameStrikeMagicStaff ), Utility.Random( 700,1400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 85){ Add( new GenericBuyInfo( typeof( GateTravelMagicStaff ), Utility.Random( 700,1400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 85){ Add( new GenericBuyInfo( typeof( ManaVampireMagicStaff ), Utility.Random( 700,1400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 85){ Add( new GenericBuyInfo( typeof( MassDispelMagicStaff ), Utility.Random( 700,1400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 85){ Add( new GenericBuyInfo( typeof( MeteorSwarmMagicStaff ), Utility.Random( 700,1400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 85){ Add( new GenericBuyInfo( typeof( PolymorphMagicStaff ), Utility.Random( 700,1400 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 95){ Add( new GenericBuyInfo( typeof( AirElementalMagicStaff ), Utility.Random( 800,1600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){ Add( new GenericBuyInfo( typeof( EarthElementalMagicStaff ), Utility.Random( 800,1600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){ Add( new GenericBuyInfo( typeof( EarthquakeMagicStaff ), Utility.Random( 800,1600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){ Add( new GenericBuyInfo( typeof( EnergyVortexMagicStaff ), Utility.Random( 800,1600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){ Add( new GenericBuyInfo( typeof( FireElementalMagicStaff ), Utility.Random( 800,1600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){ Add( new GenericBuyInfo( typeof( ResurrectionMagicStaff ), Utility.Random( 800,1600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){ Add( new GenericBuyInfo( typeof( SummonDaemonMagicStaff ), Utility.Random( 800,1600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){ Add( new GenericBuyInfo( typeof( WaterElementalMagicStaff ), Utility.Random( 800,1600 ), 1, Utility.RandomList( 0xDF2, 0xDF3, 0xDF4, 0xDF5 ), 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBHouseDeed: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBHouseDeed()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBInnKeeper : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBInnKeeper()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Ale, 7, Utility.Random( 1,15 ), 0x99F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Wine, 7, Utility.Random( 1,15 ), 0x9C7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Liquor, 7, Utility.Random( 1,15 ), 0x99B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Jug ), BeverageType.Cider, 13, Utility.Random( 1,15 ), 0x9C8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Milk, 7, Utility.Random( 1,15 ), 0x9F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Ale, 11, Utility.Random( 1,15 ), 0x1F95, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Cider, 11, Utility.Random( 1,15 ), 0x1F97, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Liquor, 11, Utility.Random( 1,15 ), 0x1F99, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Wine, 11, Utility.Random( 1,15 ), 0x1F9B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Water, 11, Utility.Random( 1,15 ), 0x1F9D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( BreadLoaf ), 6, Utility.Random( 1,15 ), 0x103B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CheeseWheel ), 21, Utility.Random( 1,15 ), 0x97E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CookedBird ), 17, Utility.Random( 1,15 ), 0x9B7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LambLeg ), 8, Utility.Random( 1,15 ), 0x160A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ChickenLeg ), 5, Utility.Random( 1,15 ), 0x1608, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ribs ), 7, Utility.Random( 1,15 ), 0x9F2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfCarrots ), 3, Utility.Random( 1,15 ), 0x15F9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfCorn ), 3, Utility.Random( 1,15 ), 0x15FA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfLettuce ), 3, Utility.Random( 1,15 ), 0x15FB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfPeas ), 3, Utility.Random( 1,15 ), 0x15FC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( EmptyPewterBowl ), 2, Utility.Random( 1,15 ), 0x15FD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfCorn ), 3, Utility.Random( 1,15 ), 0x15FE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfLettuce ), 3, Utility.Random( 1,15 ), 0x15FF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfPeas ), 3, Utility.Random( 1,15 ), 0x1600, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfFoodPotatos ), 3, Utility.Random( 1,15 ), 0x1601, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfStew ), 3, Utility.Random( 1,15 ), 0x1604, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfTomatoSoup ), 3, Utility.Random( 1,15 ), 0x1606, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ApplePie ), 7, Utility.Random( 1,15 ), 0x1041, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Peach ), 3, Utility.Random( 1,15 ), 0x9D2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Pear ), 3, Utility.Random( 1,15 ), 0x994, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Grapes ), 3, Utility.Random( 1,15 ), 0x9D1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Apple ), 3, Utility.Random( 1,15 ), 0x9D0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Banana ), 2, Utility.Random( 1,15 ), 0x171F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Torch ), 7, Utility.Random( 1,15 ), 0xF6B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Candle ), 6, Utility.Random( 1,15 ), 0xA28, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Backpack ), 15, Utility.Random( 1,15 ), 0x9B2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( tarotpoker ), 5, Utility.Random( 1,15 ), 0x12AB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1016450", typeof( Chessboard ), 2, Utility.Random( 1,15 ), 0xFA6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1016449", typeof( CheckerBoard ), 2, Utility.Random( 1,15 ), 0xFA6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Backgammon ), 2, Utility.Random( 1,15 ), 0xE1C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Dices ), 2, Utility.Random( 1,15 ), 0xFA7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Engines.Mahjong.MahjongGame ), 6, Utility.Random( 1,15 ), 0xFAA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( HenchmanFighterItem ), 5000, Utility.Random( 1,15 ), 0x1419, 0xB96 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( HenchmanArcherItem ), 6000, Utility.Random( 1,15 ), 0xF50, 0xB96 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( HenchmanWizardItem ), 7000, Utility.Random( 1,15 ), 0xE30, 0xB96 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1041243", typeof( ContractOfEmployment ), 1252, Utility.Random( 1,15 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "a barkeep contract", typeof( BarkeepContract ), 1252, Utility.Random( 1,15 ), 0x14F0, 0 ) ); }
				if ( Multis.BaseHouse.NewVendorSystem )
					if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1062332", typeof( VendorRentalContract ), 1252, Utility.Random( 1,15 ), 0x14F0, 0x672 ) ); }
				Add( new GenericBuyInfo( typeof( Beeswax ), 1000, Utility.Random( 1,15 ), 0x1422, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiBeeHiveDeed ), 2000, Utility.Random( 1,10 ), 2330, 0 ) ); 
				Add( new GenericBuyInfo( typeof( HiveTool ), 100, Utility.Random( 1,15 ), 2549, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiSmallWaxPot ), 250, Utility.Random( 1,15 ), 2532, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiLargeWaxPot ), 400, Utility.Random( 1,15 ), 2541, 0 ) ); 
				Add( new GenericBuyInfo( typeof( WaxingPot ), 50, Utility.Random( 1,15 ), 0x142B, 0 ) ); 
				Add( new GenericBuyInfo( "Waever's Spool", typeof( WeaversSpool ), 50, 20, 0xF27, 0x5E2 ) );
			
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( JuicersTools ), 500, 20, 0xE4F, 0 ) );
				Add( new GenericBuyInfo( typeof( Keg ), 50, 20, 0xE7F, 0 ) );
				Add( new GenericBuyInfo( typeof( BrewersTools ), 500, 20, 0x1EBC, 0 ) );
				Add( new GenericBuyInfo( typeof( BreweryLabelMaker ), 500, 20, 0xFBF, 0 ) );
				Add( new GenericBuyInfo( typeof( Malt ), 10, 20, 0x103D, 0 ) );
				Add( new GenericBuyInfo( typeof( Barley ), 20, 20, 0x103F, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyAleBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyMeadBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyJug ), 10, 20, 0x9C8, 0 ) );
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( Apple ), 3, 20, 0x9D0, 0 ) );
				Add( new GenericBuyInfo( typeof( Grapes ), 3, 20, 0x9D1, 0 ) );
				Add( new GenericBuyInfo( typeof( Watermelon ), 7, 20, 0xC5C, 0 ) );
				Add( new GenericBuyInfo( typeof( YellowGourd ), 3, 20, 0xC64, 0 ) );
				Add( new GenericBuyInfo( typeof( Pumpkin ), 11, 20, 0xC6A, 0 ) );
				Add( new GenericBuyInfo( typeof( Onion ), 3, 20, 0xC6D, 0 ) );
				Add( new GenericBuyInfo( typeof( Lettuce ), 5, 20, 0xC70, 0 ) );
				Add( new GenericBuyInfo( typeof( Squash ), 3, 20, 0xC72, 0 ) );
				Add( new GenericBuyInfo( typeof( HoneydewMelon ), 7, 20, 0xC74, 0 ) );
				Add( new GenericBuyInfo( typeof( Carrot ), 3, 20, 0xC77, 0 ) );
				Add( new GenericBuyInfo( typeof( Cantaloupe ), 6, 20, 0xC79, 0 ) );
				Add( new GenericBuyInfo( typeof( Cabbage ), 5, 20, 0xC7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lemon ), 3, 20, 0x1728, 0 ) );
				Add( new GenericBuyInfo( typeof( Lime ), 3, 20, 0x172A, 0 ) );
				Add( new GenericBuyInfo( typeof( Peach ), 3, 20, 0x9D2, 0 ) );
				Add( new GenericBuyInfo( typeof( Pear ), 3, 20, 0x994, 0 ) );
				Add( new GenericBuyInfo( "1060834", typeof( Engines.Plants.PlantBowl ), 2, 20, 0x15FD, 0 ) );
				Add( new GenericBuyInfo( "Cotton Seed", typeof( CottonSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Flax Seed", typeof( FlaxSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Wheat Seed", typeof( WheatSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Planting Corn", typeof( CornSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Carrot Seed", typeof( CarrotSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Onion Seed", typeof( OnionSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Garlic Seed", typeof( GarlicSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Lettuce Seed", typeof( LettuceSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Cabbage Seed", typeof( CabbageSeed ), 50, 20, 0xF27, 0x5E2 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BeverageBottle ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Jug ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pitcher ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GlassMug ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BreadLoaf ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CheeseWheel ), 12 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ribs ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Peach ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pear ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Grapes ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Apple ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Banana ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Torch ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Candle ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( tarotpoker ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MahjongGame ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Chessboard ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CheckerBoard ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Backgammon ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Dices ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ContractOfEmployment ), 626 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfCarrots ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfCorn ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfLettuce ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfPeas ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmptyPewterBowl ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfCorn ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfLettuce ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfPeas ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfFoodPotatos ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfStew ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfTomatoSoup ), 1 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBJewel: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBJewel()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GoldRing ), 27, Utility.Random( 1,15 ), 0x108A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Necklace ), 26, Utility.Random( 1,15 ), 0x1085, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GoldNecklace ), 27, Utility.Random( 1,15 ), 0x1088, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GoldBeadNecklace ), 27, Utility.Random( 1,15 ), 0x1089, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Beads ), 27, Utility.Random( 1,15 ), 0x108B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GoldBracelet ), 27, Utility.Random( 1,15 ), 0x1086, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GoldEarrings ), 27, Utility.Random( 1,15 ), 0x1087, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1060740", typeof( BroadcastCrystal ),  68, Utility.Random( 1,15 ), 0x1ED0, 0, new object[] {  500 } ) ); } // 500 charges
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1060740", typeof( BroadcastCrystal ), 131, Utility.Random( 1,15 ), 0x1ED0, 0, new object[] { 1000 } ) ); } // 1000 charges
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1060740", typeof( BroadcastCrystal ), 256, Utility.Random( 1,15 ), 0x1ED0, 0, new object[] { 2000 } ) ); } // 2000 charges
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1060740", typeof( ReceiverCrystal ), 6, Utility.Random( 1,15 ), 0x1ED0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StarSapphire ), 125, Utility.Random( 1,15 ), 0xF21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Emerald ), 100, Utility.Random( 1,15 ), 0xF10, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Sapphire ), 100, Utility.Random( 1,15 ), 0xF19, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ruby ), 75, Utility.Random( 1,15 ), 0xF13, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Citrine ), 50, Utility.Random( 1,15 ), 0xF15, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Amethyst ), 100, Utility.Random( 1,15 ), 0xF16, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Tourmaline ), 75, Utility.Random( 1,15 ), 0xF2D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Amber ), 50, Utility.Random( 1,15 ), 0xF25, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Diamond ), 200, Utility.Random( 1,15 ), 0xF26, 0 ) ); }
				Add( new GenericBuyInfo( "Waever's Spool", typeof( WeaversSpool ), 50, 20, 0xF27, 0x5E2 ) );
			
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( Crystals ), 5 );
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Amber ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Amethyst ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Citrine ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Diamond ), 100 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Emerald ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ruby ), 37 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Sapphire ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarSapphire ), 62 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Tourmaline ), 47 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Krystal ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldRing ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverRing ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Necklace ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldNecklace ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldBeadNecklace ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverNecklace ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverBeadNecklace ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Beads ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldBracelet ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverBracelet ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldEarrings ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverEarrings ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 40){Add( typeof( MysticalPearl ), 500 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 40){Add( typeof( LargeCrystal ), Utility.Random( 500,1000 ) ); } // DO NOT WANT?
				Add( typeof( MagicJewelryRing ), Utility.Random( 50,300 ) );
				Add( typeof( MagicJewelryCirclet ), Utility.Random( 50,300 ) );
				Add( typeof( MagicJewelryNecklace ), Utility.Random( 50,300 ) );
				Add( typeof( MagicJewelryEarrings ), Utility.Random( 50,300 ) );
				Add( typeof( MagicJewelryBracelet ), Utility.Random( 50,300 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AgapiteAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AgapiteBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AgapiteRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AgapiteEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmberAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmberBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmberRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmberEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmethystAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmethystBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmethystRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmethystEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BrassAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BrassBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BrassRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BrassEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BronzeAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BronzeBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BronzeRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BronzeEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CaddelliteAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CaddelliteBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CaddelliteRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CaddelliteEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CopperAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CopperBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CopperRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CopperEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DiamondAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DiamondBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DiamondRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DiamondEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DullCopperAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DullCopperBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DullCopperRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DullCopperEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmeraldAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmeraldBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmeraldRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmeraldEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GarnetAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GarnetBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GarnetRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GarnetEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldenAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldenBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldenRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldenEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JadeAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JadeBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JadeRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JadeEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MithrilAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MithrilBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MithrilRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MithrilEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NepturiteAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NepturiteBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NepturiteRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NepturiteEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ObsidianAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ObsidianBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ObsidianRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ObsidianEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OnyxAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OnyxBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OnyxRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OnyxEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PearlAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PearlBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PearlRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PearlEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuartzAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuartzBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuartzRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuartzEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RubyAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RubyBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RubyRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RubyEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SapphireAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SapphireBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SapphireRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SapphireEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ShadowIronAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ShadowIronBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ShadowIronRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ShadowIronEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilveryAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilveryBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilveryRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilveryEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinelAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinelBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinelRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinelEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarRubyAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarRubyBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarRubyRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarRubyEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarSapphireAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarSapphireBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarSapphireRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarSapphireEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SteelAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SteelBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SteelRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SteelEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TopazAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TopazBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TopazRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TopazEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TourmalineAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TourmalineBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TourmalineRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TourmalineEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ValoriteAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ValoriteBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ValoriteRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ValoriteEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( VeriteAmulet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( VeriteBracelet ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( VeriteRing ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( VeriteEarrings ), Utility.Random( 11,16 ) ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBKeeperOfChivalry : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBKeeperOfChivalry()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				Add( new GenericBuyInfo( typeof( BookOfChivalry ), 140, Utility.Random( 1,15 ), 0x2252, 0 ) );
				Add( new GenericBuyInfo( "knight warhorse", typeof( PaladinWarhorse ), 10000, Utility.Random( 1,10 ), 0x2D9C, 0x47E ) );
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( GwennoGraveAddonDeed ), Utility.Random( 5000,10000 ), 1, 0x14F0, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MyPaladinbook ), Utility.Random( 50,200 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BookOfChivalry ), 70 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBLeatherWorker: SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBLeatherWorker() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{ 
			Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Hides ), 4, Utility.Random( 1,100 ), 0x1078, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Leather ), 4, Utility.Random( 1,100 ), 0x1081, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Waterskin ), 5, Utility.Random( 1,15 ), 0xA21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( DemonSkin ), 1235, Utility.Random( 1,10 ), 0x1081, Server.Misc.MaterialInfo.GetMaterialColor( "demon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( DragonSkin ), 1235, Utility.Random( 1,10 ), 0x1081, Server.Misc.MaterialInfo.GetMaterialColor( "dragon skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( NightmareSkin ), 1228, Utility.Random( 1,10 ), 0x1081, Server.Misc.MaterialInfo.GetMaterialColor( "nightmare skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SerpentSkin ), 1214, Utility.Random( 1,10 ), 0x1081, Server.Misc.MaterialInfo.GetMaterialColor( "serpent skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( TrollSkin ), 1221, Utility.Random( 1,10 ), 0x1081, Server.Misc.MaterialInfo.GetMaterialColor( "troll skin", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( UnicornSkin ), 1228, Utility.Random( 1,10 ), 0x1081, Server.Misc.MaterialInfo.GetMaterialColor( "unicorn skin", "", 0 ) ) ); }
				Add( new GenericBuyInfo( "Waever's Spool", typeof( WeaversSpool ), 50, 20, 0xF27, 0x5E2 ) );
			 
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ThighBoots ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( MagicBoots ), 25 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( MagicBelt ), 15 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( MagicSash ), 15 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( ThrowingGloves ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( PugilistGlove ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( PugilistGloves ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( UnicornSkin ), 30 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DemonSkin ), 40 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DragonSkin ), 50 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NightmareSkin ), 30 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SerpentSkin ), 10 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TrollSkin ), 20 ); } // DO NOT WANT? 

				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Hides ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinedHides ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HornedHides ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BarbedHides ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NecroticHides ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( VolcanicHides ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FrozenHides ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoliathHides ), 6 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DraconicHides ), 6 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HellishHides ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DinosaurHides ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AlienHides ), 7 ); } // DO NOT WANT? 

				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Leather ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinedLeather ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HornedLeather ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BarbedLeather ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NecroticLeather ), 5 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( VolcanicLeather ), 6 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FrozenLeather ), 6 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoliathLeather ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DraconicLeather ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HellishLeather ), 8 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DinosaurLeather ), 8 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AlienLeather ), 8 ); } // DO NOT WANT? 

				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Waterskin ), 2 ); } // DO NOT WANT?
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBMapmaker : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBMapmaker()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BlankMap ), 5, Utility.Random( 1,15 ), 0x14EC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( MapmakersPen ), 8, Utility.Random( 1,15 ), 0x2052, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( BlankScroll ), 12, Utility.Random( 1000,1500 ), 0xEF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( new GenericBuyInfo( typeof( MasterSkeletonsKey ), Utility.Random( 100,500 ), 1, 0x410B, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BlankScroll ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MapmakersPen ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BlankMap ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CityMap ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LocalMap ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WorldMap ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PresetMapEntry ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WorldMapLodor ), Utility.Random( 10,150 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WorldMapSosaria ), Utility.Random( 10,150 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WorldMapBottle ), Utility.Random( 10,150 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WorldMapSerpent ), Utility.Random( 10,150 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WorldMapUmber ), Utility.Random( 10,150 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WorldMapAmbrosia ), Utility.Random( 10,150 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WorldMapIslesOfDread ), Utility.Random( 10,150 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WorldMapSavage ), Utility.Random( 10,150 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WorldMapUnderworld ), Utility.Random( 20,300 ) ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBMiller : SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBMiller() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{ 
			Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				Add( new GenericBuyInfo( typeof( SackFlour ), 3, Utility.Random( 1,15 ), 0x1039, 0 ) );
				Add( new GenericBuyInfo( typeof( SheafOfHay ), 2, Utility.Random( 1,15 ), 0xF36, 0 ) );
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{ 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SackFlour ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SheafOfHay ), 1 ); } // DO NOT WANT?
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBMiner: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBMiner()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bag ), 6, Utility.Random( 1,15 ), 0xE76, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Candle ), 6, Utility.Random( 1,15 ), 0xA28, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Torch ), 8, Utility.Random( 1,15 ), 0xF6B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Lantern ), 2, Utility.Random( 1,15 ), 0xA25, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Pickaxe ), 25, Utility.Random( 1,15 ), 0xE86, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Shovel ), 12, Utility.Random( 1,15 ), 0xF39, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( OreShovel ), 10, Utility.Random( 1,15 ), 0xF39, 0x96D ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pickaxe ), 12 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Shovel ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OreShovel ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Lantern ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Torch ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bag ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Candle ), 3 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBMonk : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBMonk()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				Add( new GenericBuyInfo( typeof( MonkRobe ), 136, Utility.Random( 1,15 ), 0x204E, 0x21E ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBPlayerBarkeeper : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBPlayerBarkeeper()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Ale, 7, Utility.Random( 1,15 ), 0x99F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Wine, 7, Utility.Random( 1,15 ), 0x9C7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Liquor, 7, Utility.Random( 1,15 ), 0x99B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Jug ), BeverageType.Cider, 13, Utility.Random( 1,15 ), 0x9C8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Milk, 7, Utility.Random( 1,15 ), 0x9F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Ale, 11, Utility.Random( 1,15 ), 0x1F95, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Cider, 11, Utility.Random( 1,15 ), 0x1F97, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Liquor, 11, Utility.Random( 1,15 ), 0x1F99, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Wine, 11, Utility.Random( 1,15 ), 0x1F9B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Water, 11, Utility.Random( 1,15 ), 0x1F9D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( tarotpoker ), 5, Utility.Random( 1,15 ), 0x12AB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1016450", typeof( Chessboard ), 2, Utility.Random( 1,15 ), 0xFA6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1016449", typeof( CheckerBoard ), 2, Utility.Random( 1,15 ), 0xFA6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Backgammon ), 2, Utility.Random( 1,15 ), 0xE1C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Dices ), 2, Utility.Random( 1,15 ), 0xFA7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Engines.Mahjong.MahjongGame ), 6, Utility.Random( 1,15 ), 0xFAA, 0 ) ); }
				Add( new GenericBuyInfo( typeof( Beeswax ), 1000, Utility.Random( 1,15 ), 0x1422, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiBeeHiveDeed ), 2000, Utility.Random( 1,10 ), 2330, 0 ) ); 
				Add( new GenericBuyInfo( typeof( HiveTool ), 100, Utility.Random( 1,15 ), 2549, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiSmallWaxPot ), 250, Utility.Random( 1,15 ), 2532, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiLargeWaxPot ), 400, Utility.Random( 1,15 ), 2541, 0 ) ); 
				Add( new GenericBuyInfo( typeof( WaxingPot ), 50, Utility.Random( 1,15 ), 0x142B, 0 ) ); 
				Add( new GenericBuyInfo( "Waever's Spool", typeof( WeaversSpool ), 50, 20, 0xF27, 0x5E2 ) );
			 
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( JuicersTools ), 500, 20, 0xE4F, 0 ) );
				Add( new GenericBuyInfo( typeof( Keg ), 50, 20, 0xE7F, 0 ) );
				Add( new GenericBuyInfo( typeof( BrewersTools ), 500, 20, 0x1EBC, 0 ) );
				Add( new GenericBuyInfo( typeof( BreweryLabelMaker ), 500, 20, 0xFBF, 0 ) );
				Add( new GenericBuyInfo( typeof( Malt ), 10, 20, 0x103D, 0 ) );
				Add( new GenericBuyInfo( typeof( Barley ), 20, 20, 0x103F, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyAleBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyMeadBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyJug ), 10, 20, 0x9C8, 0 ) );
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( Apple ), 3, 20, 0x9D0, 0 ) );
				Add( new GenericBuyInfo( typeof( Grapes ), 3, 20, 0x9D1, 0 ) );
				Add( new GenericBuyInfo( typeof( Watermelon ), 7, 20, 0xC5C, 0 ) );
				Add( new GenericBuyInfo( typeof( YellowGourd ), 3, 20, 0xC64, 0 ) );
				Add( new GenericBuyInfo( typeof( Pumpkin ), 11, 20, 0xC6A, 0 ) );
				Add( new GenericBuyInfo( typeof( Onion ), 3, 20, 0xC6D, 0 ) );
				Add( new GenericBuyInfo( typeof( Lettuce ), 5, 20, 0xC70, 0 ) );
				Add( new GenericBuyInfo( typeof( Squash ), 3, 20, 0xC72, 0 ) );
				Add( new GenericBuyInfo( typeof( HoneydewMelon ), 7, 20, 0xC74, 0 ) );
				Add( new GenericBuyInfo( typeof( Carrot ), 3, 20, 0xC77, 0 ) );
				Add( new GenericBuyInfo( typeof( Cantaloupe ), 6, 20, 0xC79, 0 ) );
				Add( new GenericBuyInfo( typeof( Cabbage ), 5, 20, 0xC7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lemon ), 3, 20, 0x1728, 0 ) );
				Add( new GenericBuyInfo( typeof( Lime ), 3, 20, 0x172A, 0 ) );
				Add( new GenericBuyInfo( typeof( Peach ), 3, 20, 0x9D2, 0 ) );
				Add( new GenericBuyInfo( typeof( Pear ), 3, 20, 0x994, 0 ) );
				Add( new GenericBuyInfo( "1060834", typeof( Engines.Plants.PlantBowl ), 2, 20, 0x15FD, 0 ) );
				Add( new GenericBuyInfo( "Cotton Seed", typeof( CottonSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Flax Seed", typeof( FlaxSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Wheat Seed", typeof( WheatSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Planting Corn", typeof( CornSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Carrot Seed", typeof( CarrotSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Onion Seed", typeof( OnionSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Garlic Seed", typeof( GarlicSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Lettuce Seed", typeof( LettuceSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Cabbage Seed", typeof( CabbageSeed ), 50, 20, 0xF27, 0x5E2 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBProvisioner : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBProvisioner()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1060834", typeof( Engines.Plants.PlantBowl ), 2, Utility.Random( 1,15 ), 0x15FD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Arrow ), 2, Utility.Random( 1000,1100 ), 0xF3F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bolt ), 5, Utility.Random( 1000,1100 ), 0x1BFB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Backpack ), 15, Utility.Random( 1,15 ), 0x9B2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Pouch ), 6, Utility.Random( 1,15 ), 0xE79, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Bag ), 6, Utility.Random( 1,15 ), 0xE76, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Candle ), 6, Utility.Random( 1,15 ), 0xA28, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Torch ), 8, Utility.Random( 50 ), 0xF6B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( new GenericBuyInfo( typeof( TenFootPole ), Utility.Random( 500,1000 ), Utility.Random( 1,15 ), 0xE8A, 0x972 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Lantern ), 2, Utility.Random( 1,15 ), 0xA25, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Lockpick ), 12, Utility.Random( 300,400 ), 0x14FC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FloppyHat ), 7, Utility.Random( 1,15 ), 0x1713, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WideBrimHat ), 8, Utility.Random( 1,15 ), 0x1714, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Cap ), 10, Utility.Random( 1,15 ), 0x1715, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( TallStrawHat ), 8, Utility.Random( 1,15 ), 0x1716, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StrawHat ), 7, Utility.Random( 1,15 ), 0x1717, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WizardsHat ), 11, Utility.Random( 1,15 ), 0x1718, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WitchHat ), 11, Utility.Random( 1,15 ), 0x2FC3, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherCap ), 10, Utility.Random( 1,15 ), 0x1DB9, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FeatheredHat ), 10, Utility.Random( 1,15 ), 0x171A, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( TricorneHat ), 8, Utility.Random( 1,15 ), 0x171B, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PirateHat ), 8, Utility.Random( 1,15 ), 0x2FBC, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bandana ), 6, Utility.Random( 1,15 ), 0x1540, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SkullCap ), 7, Utility.Random( 1,15 ), 0x1544, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ThrowingWeapon ), 2, Utility.Random( 20, 90 ), 0xF8F, 0x83F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BreadLoaf ), 6, Utility.Random( 1,15 ), 0x103B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LambLeg ), 8, Utility.Random( 1,15 ), 0x160A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ChickenLeg ), 5, Utility.Random( 1,15 ), 0x1608, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CookedBird ), 17, Utility.Random( 1,15 ), 0x9B7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Ale, 7, Utility.Random( 1,15 ), 0x99F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Wine, 7, Utility.Random( 1,15 ), 0x9C7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Liquor, 7, Utility.Random( 1,15 ), 0x99B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Jug ), BeverageType.Cider, 13, Utility.Random( 1,15 ), 0x9C8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Pear ), 3, Utility.Random( 1,15 ), 0x994, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Apple ), 3, Utility.Random( 1,15 ), 0x9D0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Garlic ), 3, Utility.Random( 1000,1500), 0xF84, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ginseng ), 3, Utility.Random( 1000,2000 ), 0xF85, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bottle ), 5, Utility.Random( 1000,1001 ), 0xF0E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Jar ), 5, Utility.Random( 1,15 ), 0x10B4, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Waterskin ), 5, Utility.Random( 1,15 ), 0xA21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RedBook ), 15, Utility.Random( 1,15 ), 0xFF1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BlueBook ), 15, Utility.Random( 1,15 ), 0xFF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( TanBook ), 15, Utility.Random( 1,15 ), 0xFF0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBox ), 14, Utility.Random( 1,15 ), 0xE7D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Key ), 2, Utility.Random( 1,15 ), 0x100E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MerchantCrate ), 500, 1, 0xE3D, 0x83F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bedroll ), 5, Utility.Random( 1,15 ), 0xA59, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SmallTent ), 200, Utility.Random( 1,5 ), 0x1914, Utility.RandomList( 0x96D, 0x96E, 0x96F, 0x970, 0x971, 0x972, 0x973, 0x974, 0x975, 0x976, 0x977, 0x978, 0x979, 0x97A, 0x97B, 0x97C, 0x97D, 0x97E ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CampersTent ), 500, Utility.Random( 1,5 ), 0x0A59, Utility.RandomList( 0x96D, 0x96E, 0x96F, 0x970, 0x971, 0x972, 0x973, 0x974, 0x975, 0x976, 0x977, 0x978, 0x979, 0x97A, 0x97B, 0x97C, 0x97D, 0x97E ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Kindling ), 2, Utility.Random( 1,15 ), 0xDE1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( tarotpoker ), 5, Utility.Random( 1,15 ), 0x12AB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1016450", typeof( Chessboard ), 2, Utility.Random( 1,15 ), 0xFA6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1016449", typeof( CheckerBoard ), 2, Utility.Random( 1,15 ), 0xFA6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Backgammon ), 2, Utility.Random( 1,15 ), 0xE1C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Engines.Mahjong.MahjongGame ), 6, Utility.Random( 1,15 ), 0xFAA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Dices ), 2, Utility.Random( 1,15 ), 0xFA7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SmallBagBall ), 3, Utility.Random( 1,15 ), 0x2256, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LargeBagBall ), 3, Utility.Random( 1,15 ), 0x2257, 0 ) ); }

				if( !Guild.NewGuildSystem )
					if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1041055", typeof( GuildDeed ), 12450, Utility.Random( 1,15 ), 0x14F0, 0 ) ); }
				Add( new GenericBuyInfo( typeof( Beeswax ), 1000, Utility.Random( 1,15 ), 0x1422, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiBeeHiveDeed ), 2000, Utility.Random( 1,10 ), 2330, 0 ) ); 
				Add( new GenericBuyInfo( typeof( HiveTool ), 100, Utility.Random( 1,15 ), 2549, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiSmallWaxPot ), 250, Utility.Random( 1,15 ), 2532, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiLargeWaxPot ), 400, Utility.Random( 1,15 ), 2541, 0 ) ); 
				Add( new GenericBuyInfo( typeof( WaxingPot ), 50, Utility.Random( 1,15 ), 0x142B, 0 ) ); 
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( "Waever's Spool", typeof( WeaversSpool ), 50, 20, 0xF27, 0x5E2 ) );
			
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( JuicersTools ), 500, 20, 0xE4F, 0 ) );
				Add( new GenericBuyInfo( typeof( Keg ), 50, 20, 0xE7F, 0 ) );
				Add( new GenericBuyInfo( typeof( BrewersTools ), 500, 20, 0x1EBC, 0 ) );
				Add( new GenericBuyInfo( typeof( BreweryLabelMaker ), 500, 20, 0xFBF, 0 ) );
				Add( new GenericBuyInfo( typeof( Malt ), 10, 20, 0x103D, 0 ) );
				Add( new GenericBuyInfo( typeof( Barley ), 20, 20, 0x103F, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyAleBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyMeadBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyJug ), 10, 20, 0x9C8, 0 ) );
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( Apple ), 3, 20, 0x9D0, 0 ) );
				Add( new GenericBuyInfo( typeof( Grapes ), 3, 20, 0x9D1, 0 ) );
				Add( new GenericBuyInfo( typeof( Watermelon ), 7, 20, 0xC5C, 0 ) );
				Add( new GenericBuyInfo( typeof( YellowGourd ), 3, 20, 0xC64, 0 ) );
				Add( new GenericBuyInfo( typeof( Pumpkin ), 11, 20, 0xC6A, 0 ) );
				Add( new GenericBuyInfo( typeof( Onion ), 3, 20, 0xC6D, 0 ) );
				Add( new GenericBuyInfo( typeof( Lettuce ), 5, 20, 0xC70, 0 ) );
				Add( new GenericBuyInfo( typeof( Squash ), 3, 20, 0xC72, 0 ) );
				Add( new GenericBuyInfo( typeof( HoneydewMelon ), 7, 20, 0xC74, 0 ) );
				Add( new GenericBuyInfo( typeof( Carrot ), 3, 20, 0xC77, 0 ) );
				Add( new GenericBuyInfo( typeof( Cantaloupe ), 6, 20, 0xC79, 0 ) );
				Add( new GenericBuyInfo( typeof( Cabbage ), 5, 20, 0xC7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lemon ), 3, 20, 0x1728, 0 ) );
				Add( new GenericBuyInfo( typeof( Lime ), 3, 20, 0x172A, 0 ) );
				Add( new GenericBuyInfo( typeof( Peach ), 3, 20, 0x9D2, 0 ) );
				Add( new GenericBuyInfo( typeof( Pear ), 3, 20, 0x994, 0 ) );
				Add( new GenericBuyInfo( "1060834", typeof( Engines.Plants.PlantBowl ), 2, 20, 0x15FD, 0 ) );
				Add( new GenericBuyInfo( "Cotton Seed", typeof( CottonSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Flax Seed", typeof( FlaxSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Wheat Seed", typeof( WheatSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Planting Corn", typeof( CornSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Carrot Seed", typeof( CarrotSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Onion Seed", typeof( OnionSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Garlic Seed", typeof( GarlicSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Lettuce Seed", typeof( LettuceSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Cabbage Seed", typeof( CabbageSeed ), 50, 20, 0xF27, 0x5E2 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IvoryTusk ), Utility.Random( 50,250 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MerchantCrate ), 250 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SmallTent ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CampersTent ), 100 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Arrow ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bolt ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Backpack ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pouch ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bag ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Candle ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Torch ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Lantern ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Lockpick ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FloppyHat ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WideBrimHat ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Cap ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TallStrawHat ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StrawHat ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WizardsHat ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WitchHat ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherCap ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FeatheredHat ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TricorneHat ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PirateHat ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bandana ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullCap ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ThrowingWeapon ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Waterskin ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bottle ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Jar ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RedBook ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BlueBook ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TanBook ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBox ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Kindling ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( tarotpoker ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MahjongGame ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Chessboard ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CheckerBoard ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Backgammon ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Dices ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Amber ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Amethyst ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Citrine ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Diamond ), 100 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Emerald ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ruby ), 37 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Sapphire ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarSapphire ), 62 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Tourmaline ), 47 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldRing ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverRing ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Necklace ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldNecklace ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldBeadNecklace ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverNecklace ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverBeadNecklace ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Beads ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldBracelet ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverBracelet ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldEarrings ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverEarrings ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicJewelryRing ), Utility.Random( 50,300 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicJewelryCirclet ), Utility.Random( 50,300 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicJewelryNecklace ), Utility.Random( 50,300 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicJewelryEarrings ), Utility.Random( 50,300 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicJewelryBracelet ), Utility.Random( 50,300 ) ); } // DO NOT WANT?

				if( !Guild.NewGuildSystem )
					if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GuildDeed ), 6225 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBRancher : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBRancher()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				Add( new AnimalBuyInfo( 1, typeof( PackHorse ), 631, Utility.Random( 1,15 ), 291, 0 ) );
				Add( new GenericBuyInfo( typeof( Beeswax ), 1000, Utility.Random( 1,15 ), 0x1422, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiBeeHiveDeed ), 2000, Utility.Random( 1,10 ), 2330, 0 ) ); 
				Add( new GenericBuyInfo( typeof( HiveTool ), 100, Utility.Random( 1,15 ), 2549, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiSmallWaxPot ), 250, Utility.Random( 1,15 ), 2532, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiLargeWaxPot ), 400, Utility.Random( 1,15 ), 2541, 0 ) ); 
				Add( new GenericBuyInfo( typeof( WaxingPot ), 50, Utility.Random( 1,15 ), 0x142B, 0 ) ); 
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( JuicersTools ), 500, 20, 0xE4F, 0 ) );
				Add( new GenericBuyInfo( typeof( Keg ), 50, 20, 0xE7F, 0 ) );
				Add( new GenericBuyInfo( typeof( BrewersTools ), 500, 20, 0x1EBC, 0 ) );
				Add( new GenericBuyInfo( typeof( BreweryLabelMaker ), 500, 20, 0xFBF, 0 ) );
				Add( new GenericBuyInfo( typeof( Malt ), 10, 20, 0x103D, 0 ) );
				Add( new GenericBuyInfo( typeof( Barley ), 20, 20, 0x103F, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyAleBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyMeadBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyJug ), 10, 20, 0x9C8, 0 ) );
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( Apple ), 3, 20, 0x9D0, 0 ) );
				Add( new GenericBuyInfo( typeof( Grapes ), 3, 20, 0x9D1, 0 ) );
				Add( new GenericBuyInfo( typeof( Watermelon ), 7, 20, 0xC5C, 0 ) );
				Add( new GenericBuyInfo( typeof( YellowGourd ), 3, 20, 0xC64, 0 ) );
				Add( new GenericBuyInfo( typeof( Pumpkin ), 11, 20, 0xC6A, 0 ) );
				Add( new GenericBuyInfo( typeof( Onion ), 3, 20, 0xC6D, 0 ) );
				Add( new GenericBuyInfo( typeof( Lettuce ), 5, 20, 0xC70, 0 ) );
				Add( new GenericBuyInfo( typeof( Squash ), 3, 20, 0xC72, 0 ) );
				Add( new GenericBuyInfo( typeof( HoneydewMelon ), 7, 20, 0xC74, 0 ) );
				Add( new GenericBuyInfo( typeof( Carrot ), 3, 20, 0xC77, 0 ) );
				Add( new GenericBuyInfo( typeof( Cantaloupe ), 6, 20, 0xC79, 0 ) );
				Add( new GenericBuyInfo( typeof( Cabbage ), 5, 20, 0xC7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lemon ), 3, 20, 0x1728, 0 ) );
				Add( new GenericBuyInfo( typeof( Lime ), 3, 20, 0x172A, 0 ) );
				Add( new GenericBuyInfo( typeof( Peach ), 3, 20, 0x9D2, 0 ) );
				Add( new GenericBuyInfo( typeof( Pear ), 3, 20, 0x994, 0 ) );
				Add( new GenericBuyInfo( "Waever's Spool", typeof( WeaversSpool ), 50, 20, 0xF27, 0x5E2 ) );
			
				Add( new GenericBuyInfo( "1060834", typeof( Engines.Plants.PlantBowl ), 2, 20, 0x15FD, 0 ) );
				Add( new GenericBuyInfo( "Cotton Seed", typeof( CottonSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Flax Seed", typeof( FlaxSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Wheat Seed", typeof( WheatSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Planting Corn", typeof( CornSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Carrot Seed", typeof( CarrotSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Onion Seed", typeof( OnionSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Garlic Seed", typeof( GarlicSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Lettuce Seed", typeof( LettuceSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Cabbage Seed", typeof( CabbageSeed ), 50, 20, 0xF27, 0x5E2 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBRanger : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBRanger()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( Cat ), 138, Utility.Random( 1,15 ), 201, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new AnimalBuyInfo( 1, typeof( Dog ), 181, Utility.Random( 1,15 ), 217, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( PackLlama ), 491, Utility.Random( 1,15 ), 292, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new AnimalBuyInfo( 1, typeof( PackHorse ), 606, Utility.Random( 1,15 ), 291, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new AnimalBuyInfo( 5, typeof( PackMule ), 10000, 1, 291, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bandage ), 5, Utility.Random( 1,250 ), 0xE21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Crossbow ), 55, Utility.Random( 1,15 ), 0xF50, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( HeavyCrossbow ), 55, Utility.Random( 1,15 ), 0x13FD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RepeatingCrossbow ), 46, Utility.Random( 1,15 ), 0x26C3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CompositeBow ), 45, Utility.Random( 1,15 ), 0x26C2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bolt ), 2, Utility.Random( 1000,1100 ), 0x1BFB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bow ), 40, Utility.Random( 1,15 ), 0x13B2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Arrow ), 2, Utility.Random(1000,1100 ), 0xF3F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Feather ), 2, Utility.Random( 300, 600 ), 0x1BD1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Shaft ), 3, Utility.Random( 300, 600 ), 0x1BD4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ArcherQuiver ), 32, Utility.Random( 1,5 ), 0x2B02, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RangerArms ), 87, Utility.Random( 1,15 ), 0x13DC, 0x59C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RangerChest ), 128, Utility.Random( 1,15 ), 0x13DB, 0x59C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RangerGloves ), 79, Utility.Random( 1,15 ), 0x13D5, 0x59C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RangerGorget ), 73, Utility.Random( 1,15 ), 0x13D6, 0x59C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RangerLegs ), 103, Utility.Random( 1,15 ), 0x13DA, 0x59C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SmallTent ), 200, Utility.Random( 1,5 ), 0x1914, Utility.RandomList( 0x96D, 0x96E, 0x96F, 0x970, 0x971, 0x972, 0x973, 0x974, 0x975, 0x976, 0x977, 0x978, 0x979, 0x97A, 0x97B, 0x97C, 0x97D, 0x97E ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 10){Add( new GenericBuyInfo( typeof( CampersTent ), 500, Utility.Random( 1,5 ), 0x0A59, Utility.RandomList( 0x96D, 0x96E, 0x96F, 0x970, 0x971, 0x972, 0x973, 0x974, 0x975, 0x976, 0x977, 0x978, 0x979, 0x97A, 0x97B, 0x97C, 0x97D, 0x97E ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( MyTentEastAddonDeed ), 4000, 1, 0xA58, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( MyTentSouthAddonDeed ), 4000, 1, 0xA59, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( TrapKit ), 420, Utility.Random( 1,5 ), 0x1EBB, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MyTentEastAddonDeed ), 200 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MyTentSouthAddonDeed ), 200 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SmallTent ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CampersTent ), 100 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Crossbow ), 27 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HeavyCrossbow ), 28 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RepeatingCrossbow ), 23 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CompositeBow ), 22 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bolt ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Arrow ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bow ), 20 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Feather ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Shaft ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Arrow ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ArcherQuiver ), 16 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RangerArms ), 43 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RangerChest ), 64 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RangerGloves ), 40 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RangerLegs ), 51 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RangerGorget ), 36 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TrapKit ), 210 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBRealEstateBroker : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBRealEstateBroker()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				Add( new GenericBuyInfo( typeof( InteriorDecorator ), 100, Utility.Random( 1,15 ), 0x1EBA, 0 ) );
				Add( new GenericBuyInfo( typeof( HousePlacementTool ), 50, Utility.Random( 1,15 ), 0x14F0, 0 ) );
				Add( new GenericBuyInfo( "house teleporter", typeof( PlayersHouseTeleporter ), 8000, Utility.Random( 1,10 ), 0x181D, 0 ) );
				Add( new GenericBuyInfo( "house high teleporter", typeof( PlayersZTeleporter ), 4000, Utility.Random( 1,10 ), 0x181D, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BlankScroll ), 5, Utility.Random( 1,15 ), 0x0E34, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ScribesPen ), 8,  Utility.Random( 1,15 ), 0x2051, 0 ) ); }
				Add( new GenericBuyInfo( typeof( house_sign_sign_post_a ), 5, Utility.Random( 1,15 ), 2967, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_post_b ), 5, Utility.Random( 1,15 ), 2970, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_merc ), 10, Utility.Random( 1,15 ), 3082, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_armor ), 10, Utility.Random( 1,15 ), 3008, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_bake ), 10, Utility.Random( 1,15 ), 2980, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_bank ), 10, Utility.Random( 1,15 ), 3084, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_bard ), 10, Utility.Random( 1,15 ), 3004, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_smith ), 10, Utility.Random( 1,15 ), 3016, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_bow ), 10, Utility.Random( 1,15 ), 3022, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_ship ), 10, Utility.Random( 1,15 ), 2998, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_fletch ), 10, Utility.Random( 1,15 ), 3006, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_heal ), 10, Utility.Random( 1,15 ), 2988, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_inn ), 10, Utility.Random( 1,15 ), 2996, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_gem ), 10, Utility.Random( 1,15 ), 3010, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_book ), 10, Utility.Random( 1,15 ), 2966, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_mage ), 10, Utility.Random( 1,15 ), 2990, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_necro ), 10, Utility.Random( 1,15 ), 2811, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_supply ), 10, Utility.Random( 1,15 ), 3020, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_herb ), 10, Utility.Random( 1,15 ), 3014, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_pen ), 10, Utility.Random( 1,15 ), 3000, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_sew ), 10, Utility.Random( 1,15 ), 2982, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_tavern ), 10, Utility.Random( 1,15 ), 3012, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_tinker ), 10, Utility.Random( 1,15 ), 2984, 0 ) );
				Add( new GenericBuyInfo( typeof( house_sign_sign_wood ), 10, Utility.Random( 1,15 ), 2992, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ScribesPen ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BlankScroll ), 2 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBScribe: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBScribe()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ScribesPen ), 16, Utility.Random( 1,15 ), 0x2051, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BlankScroll ), 5, Utility.Random( 1,15 ), 0x0E34, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BrownBook ), 15, Utility.Random( 1,15 ), 0xFEF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( TanBook ), 15, Utility.Random( 1,15 ), 0xFF0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BlueBook ), 15, Utility.Random( 1,15 ), 0xFF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( "1041267", typeof( Runebook ), 3500, Utility.Random( 1,3 ), 0x0F3D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Mailbox ), 158, Utility.Random( 1,5 ), 0x4142, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ScribesPen ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BrownBook ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TanBook ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BlueBook ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BlankScroll ), 3 ); } // DO NOT WANT?
				Add( typeof( JokeBook ), Utility.Random( 750,1500 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DynamicBook ), Utility.Random( 10,150 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DataPad ), Utility.Random( 5, 150 ) ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBSage: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSage()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LoreGuidetoAdventure ), 5, Utility.Random( 5,15 ), 0x1C11, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( WeaponAbilityBook ), 5, Utility.Random( 1,15 ), 0x2254, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LearnLeatherBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LearnMiscBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LearnMetalBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LearnWoodBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LearnReagentsBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LearnGraniteBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LearnScalesBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LearnTailorBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LearnTraps ), 5, Utility.Random( 1,15 ), 0xFF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( CBookDruidicHerbalism ), 50, Utility.Random( 1,15 ), 0x2D50, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( CBookNecroticAlchemy ), 50, Utility.Random( 1,15 ), 0x2253, 0x4AA ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( AlchemicalElixirs ), 50, Utility.Random( 1,15 ), 0x2219, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( AlchemicalMixtures ), 50, Utility.Random( 1,15 ), 0x2223, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( BookOfPoisons ), 50, Utility.Random( 1,15 ), 0x2253, 0x4F8 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( WorkShoppes ), 50, Utility.Random( 1,15 ), 0x2259, 0xB50 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LearnTitles ), 5, Utility.Random( 1,15 ), 0xFF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ScribesPen ), 8, Utility.Random( 1,15 ), 0x2051, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BlankScroll ), 5, Utility.Random( 1,15 ), 0x0E34, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( "1041267", typeof( Runebook ), 3500, Utility.Random( 1,3 ), 0x0F3D, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ScribesPen ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BlankScroll ), 3 ); } // DO NOT WANT?
				Add( typeof( TomeOfWands ), Utility.Random( 100,400 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBSECook: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSECook()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Wasabi ), 2, Utility.Random( 1,15 ), 0x24E8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Wasabi ), 2, Utility.Random( 1,15 ), 0x24E9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SushiRolls ), 3, Utility.Random( 1,15 ), 0x283E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SushiPlatter ), 3, Utility.Random( 1,15 ), 0x2840, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GreenTea ), 3, Utility.Random( 1,15 ), 0x284C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MisoSoup ), 3, Utility.Random( 1,15 ), 0x284D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WhiteMisoSoup ), 3, Utility.Random( 1,15 ), 0x284E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RedMisoSoup ), 3, Utility.Random( 1,15 ), 0x284F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AwaseMisoSoup ), 3, Utility.Random( 1,15 ), 0x2850, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BentoBox ), 6, Utility.Random( 1,15 ), 0x2836, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( BentoBox ), 6, Utility.Random( 1,15 ), 0x2837, 0 ) ); }
				Add( new GenericBuyInfo( typeof( Beeswax ), 1000, Utility.Random( 1,15 ), 0x1422, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiBeeHiveDeed ), 2000, Utility.Random( 1,10 ), 2330, 0 ) ); 
				Add( new GenericBuyInfo( typeof( HiveTool ), 100, Utility.Random( 1,15 ), 2549, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiSmallWaxPot ), 250, Utility.Random( 1,15 ), 2532, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiLargeWaxPot ), 400, Utility.Random( 1,15 ), 2541, 0 ) ); 
				Add( new GenericBuyInfo( typeof( WaxingPot ), 50, Utility.Random( 1,15 ), 0x142B, 0 ) ); 
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( JuicersTools ), 500, 20, 0xE4F, 0 ) );
				Add( new GenericBuyInfo( "Waever's Spool", typeof( WeaversSpool ), 50, 20, 0xF27, 0x5E2 ) );
			
				Add( new GenericBuyInfo( typeof( Keg ), 50, 20, 0xE7F, 0 ) );
				Add( new GenericBuyInfo( typeof( BrewersTools ), 500, 20, 0x1EBC, 0 ) );
				Add( new GenericBuyInfo( typeof( BreweryLabelMaker ), 500, 20, 0xFBF, 0 ) );
				Add( new GenericBuyInfo( typeof( Malt ), 10, 20, 0x103D, 0 ) );
				Add( new GenericBuyInfo( typeof( Barley ), 20, 20, 0x103F, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyAleBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyMeadBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyJug ), 10, 20, 0x9C8, 0 ) );
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( Apple ), 3, 20, 0x9D0, 0 ) );
				Add( new GenericBuyInfo( typeof( Grapes ), 3, 20, 0x9D1, 0 ) );
				Add( new GenericBuyInfo( typeof( Watermelon ), 7, 20, 0xC5C, 0 ) );
				Add( new GenericBuyInfo( typeof( YellowGourd ), 3, 20, 0xC64, 0 ) );
				Add( new GenericBuyInfo( typeof( Pumpkin ), 11, 20, 0xC6A, 0 ) );
				Add( new GenericBuyInfo( typeof( Onion ), 3, 20, 0xC6D, 0 ) );
				Add( new GenericBuyInfo( typeof( Lettuce ), 5, 20, 0xC70, 0 ) );
				Add( new GenericBuyInfo( typeof( Squash ), 3, 20, 0xC72, 0 ) );
				Add( new GenericBuyInfo( typeof( HoneydewMelon ), 7, 20, 0xC74, 0 ) );
				Add( new GenericBuyInfo( typeof( Carrot ), 3, 20, 0xC77, 0 ) );
				Add( new GenericBuyInfo( typeof( Cantaloupe ), 6, 20, 0xC79, 0 ) );
				Add( new GenericBuyInfo( typeof( Cabbage ), 5, 20, 0xC7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lemon ), 3, 20, 0x1728, 0 ) );
				Add( new GenericBuyInfo( typeof( Lime ), 3, 20, 0x172A, 0 ) );
				Add( new GenericBuyInfo( typeof( Peach ), 3, 20, 0x9D2, 0 ) );
				Add( new GenericBuyInfo( typeof( Pear ), 3, 20, 0x994, 0 ) );
				Add( new GenericBuyInfo( "1060834", typeof( Engines.Plants.PlantBowl ), 2, 20, 0x15FD, 0 ) );
				Add( new GenericBuyInfo( "Cotton Seed", typeof( CottonSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Flax Seed", typeof( FlaxSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Wheat Seed", typeof( WheatSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Planting Corn", typeof( CornSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Carrot Seed", typeof( CarrotSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Onion Seed", typeof( OnionSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Garlic Seed", typeof( GarlicSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Lettuce Seed", typeof( LettuceSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Cabbage Seed", typeof( CabbageSeed ), 50, 20, 0xF27, 0x5E2 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Wasabi ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BentoBox ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GreenTea ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SushiRolls ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SushiPlatter ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MisoSoup ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RedMisoSoup ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WhiteMisoSoup ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AwaseMisoSoup ), 1 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBSEHats: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSEHats()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Kasa ), 31, Utility.Random( 1,15 ), 0x2798, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherJingasa ), 11, Utility.Random( 1,15 ), 0x2776, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ClothNinjaHood ), 33, Utility.Random( 1,15 ), 0x278F, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Kasa ), 15 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherJingasa ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ClothNinjaHood ), 16 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBShipwright : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBShipwright()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1041205", typeof( SmallBoatDeed ), 10000, Utility.Random( 1,15 ), 0x14F3, 0x5BE ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1041206", typeof( SmallDragonBoatDeed ), 11000, Utility.Random( 1,15 ), 0x14F3, 0x5BE ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1041207", typeof( MediumBoatDeed ), 12000, Utility.Random( 1,15 ), 0x14F3, 0x5BE ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1041208", typeof( MediumDragonBoatDeed ), 13000, Utility.Random( 1,15 ), 0x14F3, 0x5BE ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1041209", typeof( LargeBoatDeed ), 14000, Utility.Random( 1,15 ), 0x14F3, 0x5BE ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1041210", typeof( LargeDragonBoatDeed ), 15000, Utility.Random( 1,15 ), 0x14F3, 0x5BE ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( new GenericBuyInfo( typeof( DockingLantern ), 58, Utility.Random( 1,15 ), 0x40FF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Sextant ), 13, Utility.Random( 1,15 ), 0x1057, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BoatStain ), 26, Utility.Random( 1,15 ), 0x14E0, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SeaShell ), 58 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DockingLantern ), 29 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Sextant ), 6 ); } // DO NOT WANT?
				Add( typeof( PirateChest ), Utility.RandomMinMax( 100, 500 ) );
				Add( typeof( SunkenChest ), Utility.RandomMinMax( 100, 500 ) );
				Add( typeof( FishingNet ), Utility.RandomMinMax( 10, 20 ) );
				Add( typeof( SpecialFishingNet ), Utility.RandomMinMax( 30, 40 ) );
				Add( typeof( FabledFishingNet ), Utility.RandomMinMax( 50, 60 ) );
				Add( typeof( NeptunesFishingNet ), Utility.RandomMinMax( 70, 80 ) );
				Add( typeof( PrizedFish ), Utility.RandomMinMax( 30, 60 ) );
				Add( typeof( WondrousFish ), Utility.RandomMinMax( 30, 60 ) );
				Add( typeof( TrulyRareFish ), Utility.RandomMinMax( 30, 60 ) );
				Add( typeof( PeculiarFish ), Utility.RandomMinMax( 30, 60 ) );
				Add( typeof( SpecialSeaweed ), Utility.RandomMinMax( 20, 80 ) );
				Add( typeof( SunkenBag ), Utility.RandomMinMax( 50, 250 ) );
				Add( typeof( ShipwreckedItem ), Utility.RandomMinMax( 10, 50 ) );
				Add( typeof( HighSeasRelic ), Utility.RandomMinMax( 10, 50 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BoatStain ), 13 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBDevon : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBDevon()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( MagicSextant ), Utility.Random( 500,1000 ), Utility.Random( 5,15 ), 0x26A0, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBSmithTools: SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBSmithTools() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{ 
			Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( IronIngot ), 5, Utility.Random( 1,15 ), 0x1BF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Tongs ), 13, Utility.Random( 1,15 ), 0xFBB, 0 ) ); } 

			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{ 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Tongs ), 7 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IronIngot ), 4 ); } // DO NOT WANT? 
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBStoneCrafter : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBStoneCrafter()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Nails ), 3, Utility.Random( 1,15 ), 0x102E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Axle ), 2, Utility.Random( 1,15 ), 0x105B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Board ), 3, Utility.Random( 1,15 ), 0x1BD7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DrawKnife ), 10, Utility.Random( 1,15 ), 0x10E4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Froe ), 10, Utility.Random( 1,15 ), 0x10E5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Scorp ), 10, Utility.Random( 1,15 ), 0x10E7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Inshave ), 10, Utility.Random( 1,15 ), 0x10E6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DovetailSaw ), 12, Utility.Random( 1,15 ), 0x1028, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Saw ), 15, Utility.Random( 1,15 ), 0x1034, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Hammer ), 17, Utility.Random( 1,15 ), 0x102A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MouldingPlane ), 11, Utility.Random( 1,15 ), 0x102C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SmoothingPlane ), 10, Utility.Random( 1,15 ), 0x1032, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( JointingPlane ), 11, Utility.Random( 1,15 ), 0x1030, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( "Making Valuables With Stonecrafting", typeof( MasonryBook ), 10625, Utility.Random( 1,15 ), 0xFBE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( "Mining For Quality Stone", typeof( StoneMiningBook ), 10625, Utility.Random( 1,15 ), 0xFBE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1044515", typeof( MalletAndChisel ), 3, Utility.Random( 1,15 ), 0x12B3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "Jade Statue Maker", typeof( JadeStatueMaker ), 50000, 1, 0x32F2, 0xB93 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "Marble Statue Maker", typeof( MarbleStatueMaker ), 50000, 1, 0x32F2, 0xB8F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "Bronze Statue Maker", typeof( BronzeStatueMaker ), 50000, 1, 0x32F2, 0xB97 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MasonryBook ), 5000 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StoneMiningBook ), 5000 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MalletAndChisel ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBox ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SmallCrate ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MediumCrate ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LargeCrate ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenChest ), 15 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LargeTable ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Nightstand ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( YewWoodTable ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Throne ), 24 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenThrone ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Stool ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FootStool ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FancyWoodenChairCushion ), 12 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenChairCushion ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenChair ), 8 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BambooChair ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBench ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Saw ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Scorp ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SmoothingPlane ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DrawKnife ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Froe ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Hammer ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Inshave ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JointingPlane ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MouldingPlane ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DovetailSaw ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Board ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Axle ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenShield ), 31 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BlackStaff ), 24 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GnarledStaff ), 12 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuarterStaff ), 15 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ShepherdsCrook ), 12 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Club ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Log ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RockUrn ), 30 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RockVase ), 30 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBTailor: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBTailor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SewingKit ), 3, Utility.Random( 1,15 ), 0xF9D, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Scissors ), 11, Utility.Random( 1,15 ), 0xF9F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DyeTub ), 8, Utility.Random( 1,15 ), 0xFAB, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Dyes ), 8, Utility.Random( 1,15 ), 0xFA9, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Shirt ), 12, Utility.Random( 1,15 ), 0x1517, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ShortPants ), 7, Utility.Random( 1,15 ), 0x152E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FancyShirt ), 21, Utility.Random( 1,15 ), 0x1EFD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LongPants ), 10, Utility.Random( 1,15 ), 0x1539, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FancyDress ), 26, Utility.Random( 1,15 ), 0x1EFF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlainDress ), 13, Utility.Random( 1,15 ), 0x1F01, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Kilt ), 11, Utility.Random( 1,15 ), 0x1537, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Kilt ), 11, Utility.Random( 1,15 ), 0x1537, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( HalfApron ), 10, Utility.Random( 1,15 ), 0x153b, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LoinCloth ), 10, Utility.Random( 1,15 ), 0x2B68, 637 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Robe ), 18, Utility.Random( 1,15 ), 0x1F03, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Cloak ), 8, Utility.Random( 1,15 ), 0x1515, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Cloak ), 8, Utility.Random( 1,15 ), 0x1515, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Doublet ), 13, Utility.Random( 1,15 ), 0x1F7B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Tunic ), 18, Utility.Random( 1,15 ), 0x1FA1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( JesterSuit ), 26, Utility.Random( 1,15 ), 0x1F9F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( JesterHat ), 12, Utility.Random( 1,15 ), 0x171C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FloppyHat ), 7, Utility.Random( 1,15 ), 0x1713, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WideBrimHat ), 8, Utility.Random( 1,15 ), 0x1714, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Cap ), 10, Utility.Random( 1,15 ), 0x1715, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( TallStrawHat ), 8, Utility.Random( 1,15 ), 0x1716, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StrawHat ), 7, Utility.Random( 1,15 ), 0x1717, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WizardsHat ), 11, Utility.Random( 1,15 ), 0x1718, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WitchHat ), 11, Utility.Random( 1,15 ), 0x2FC3, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherCap ), 10, Utility.Random( 1,15 ), 0x1DB9, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FeatheredHat ), 10, Utility.Random( 1,15 ), 0x171A, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( TricorneHat ), 8, Utility.Random( 1,15 ), 0x171B, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PirateHat ), 8, Utility.Random( 1,15 ), 0x2FBC, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bandana ), 6, Utility.Random( 1,15 ), 0x1540, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SkullCap ), 7, Utility.Random( 1,15 ), 0x1544, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ClothHood ), 12, Utility.Random( 1,15 ), 0x2B71, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ClothCowl ), 12, Utility.Random( 1,15 ), 0x3176, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BoltOfCloth ), 100, Utility.Random( 1,15 ), 0xf95, Utility.RandomDyedHue() ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Cloth ), 2, Utility.Random( 1,15 ), 0x1766, Utility.RandomDyedHue() ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( UncutCloth ), 2, Utility.Random( 1,15 ), 0x1767, Utility.RandomDyedHue() ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Cotton ), 102, Utility.Random( 1,15 ), 0xDF9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Wool ), 62, Utility.Random( 1,15 ), 0xDF8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Flax ), 102, Utility.Random( 1,15 ), 0x1A9C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SpoolOfThread ), 18, Utility.Random( 1,15 ), 0xFA0, 0 ) ); }
				Add( new GenericBuyInfo( "Waever's Spool", typeof( WeaversSpool ), 50, 20, 0xF27, 0x5E2 ) );
			
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JokerRobe ), 19 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AssassinRobe ), 19 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FancyRobe ), 19 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GildedRobe ), 19 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OrnateRobe ), 19 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagistrateRobe ), 19 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RoyalRobe ), 19 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SorcererRobe ), 19 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AssassinShroud ), 29 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NecromancerRobe ), 19 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpiderRobe ), 19 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Scissors ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SewingKit ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Dyes ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DyeTub ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BoltOfCloth ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FancyShirt ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Shirt ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ShortPants ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LongPants ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Cloak ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FancyDress ), 12 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Robe ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlainDress ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Skirt ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Kilt ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Doublet ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Tunic ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JesterSuit ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FullApron ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HalfApron ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LoinCloth ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JesterHat ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FloppyHat ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WideBrimHat ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Cap ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullCap ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ClothCowl ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ClothHood ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bandana ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TallStrawHat ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StrawHat ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WizardsHat ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WitchHat ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bonnet ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FeatheredHat ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TricorneHat ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PirateHat ), 4 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpoolOfThread ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Flax ), 51 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Cotton ), 51 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Wool ), 31 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( MagicRobe ), 30 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( MagicHat ), 20 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( MagicCloak ), 30 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( MagicBelt ), 20 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( typeof( MagicSash ), 20 ); } // DO NOT WANT? 
				//Add( typeof( MagicScissors ), Utility.Random( 300,400 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBTanner : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBTanner()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FemaleStuddedChest ), 62, Utility.Random( 1,15 ), 0x1C02, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FemalePlateChest ), 207, Utility.Random( 1,15 ), 0x1C04, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FemaleLeatherChest ), 36, Utility.Random( 1,15 ), 0x1C06, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherShorts ), 28, Utility.Random( 1,15 ), 0x1C00, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherSkirt ), 25, Utility.Random( 1,15 ), 0x1C08, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherBustierArms ), 30, Utility.Random( 1,15 ), 0x1C0B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedBustierArms ), 50, Utility.Random( 1,15 ), 0x1C0C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bag ), 6, Utility.Random( 1,15 ), 0xE76, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Pouch ), 6, Utility.Random( 1,15 ), 0xE79, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Backpack ), 15, Utility.Random( 1,15 ), 0x9B2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SkinningKnife ), 15, Utility.Random( 1,15 ), 0xEC4, 0 ) ); }
				Add( new GenericBuyInfo( "Waever's Spool", typeof( WeaversSpool ), 50, 20, 0xF27, 0x5E2 ) );
			
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bag ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pouch ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Backpack ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkinningKnife ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FemaleStuddedChest ), 31 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StuddedBustierArms ), 23 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FemalePlateChest), 103 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FemaleLeatherChest ), 18 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherBustierArms ), 12 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherShorts ), 14 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LeatherSkirt ), 12 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBTavernKeeper : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBTavernKeeper()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Kill Book", typeof( KillBook ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Ale, 7, Utility.Random( 1,15 ), 0x99F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Wine, 7, Utility.Random( 1,15 ), 0x9C7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Liquor, 7, Utility.Random( 1,15 ), 0x99B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Jug ), BeverageType.Cider, 13, Utility.Random( 1,15 ), 0x9C8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Milk, 7, Utility.Random( 1,15 ), 0x9F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Ale, 11, Utility.Random( 1,15 ), 0x1F95, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Cider, 11, Utility.Random( 1,15 ), 0x1F97, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Liquor, 11, Utility.Random( 1,15 ), 0x1F99, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Wine, 11, Utility.Random( 1,15 ), 0x1F9B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Water, 11, Utility.Random( 1,15 ), 0x1F9D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BreadLoaf ), 6, Utility.Random( 1,15 ), 0x103B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( CheeseWheel ), 21, Utility.Random( 1,15 ), 0x97E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CookedBird ), 17, Utility.Random( 1,15 ), 0x9B7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LambLeg ), 8, Utility.Random( 1,15 ), 0x160A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ChickenLeg ), 5, Utility.Random( 1,15 ), 0x1608, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ribs ), 7, Utility.Random( 1,15 ), 0x9F2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfCarrots ), 3, Utility.Random( 1,15 ), 0x15F9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfCorn ), 3, Utility.Random( 1,15 ), 0x15FA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfLettuce ), 3, Utility.Random( 1,15 ), 0x15FB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfPeas ), 3, Utility.Random( 1,15 ), 0x15FC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( EmptyPewterBowl ), 2, Utility.Random( 1,15 ), 0x15FD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfCorn ), 3, Utility.Random( 1,15 ), 0x15FE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfLettuce ), 3, Utility.Random( 1,15 ), 0x15FF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfPeas ), 3, Utility.Random( 1,15 ), 0x1600, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfFoodPotatos ), 3, Utility.Random( 1,15 ), 0x1601, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfStew ), 3, Utility.Random( 1,15 ), 0x1604, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfTomatoSoup ), 3, Utility.Random( 1,15 ), 0x1606, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ApplePie ), 7, Utility.Random( 1,15 ), 0x1041, 0 ) ); } //OSI just has Pie, not Apple/Fruit/Meat
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( tarotpoker ), 5, Utility.Random( 1,15 ), 0x12AB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1016450", typeof( Chessboard ), 2, Utility.Random( 1,15 ), 0xFA6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1016449", typeof( CheckerBoard ), 2, Utility.Random( 1,15 ), 0xFA6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Backgammon ), 2, Utility.Random( 1,15 ), 0xE1C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Dices ), 2, Utility.Random( 1,15 ), 0xFA7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Engines.Mahjong.MahjongGame ), 6, Utility.Random( 1,15 ), 0xFAA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Waterskin ), 5, Utility.Random( 1,15 ), 0xA21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( HenchmanFighterItem ), 5000, Utility.Random( 1,15 ), 0x1419, 0xB96 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( HenchmanArcherItem ), 6000, Utility.Random( 1,15 ), 0xF50, 0xB96 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( HenchmanWizardItem ), 7000, Utility.Random( 1,15 ), 0xE30, 0xB96 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1041243", typeof( ContractOfEmployment ), 1252, Utility.Random( 1,15 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "a barkeep contract", typeof( BarkeepContract ), 1252, Utility.Random( 1,15 ), 0x14F0, 0 ) ); }

				if ( Multis.BaseHouse.NewVendorSystem )
					if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1062332", typeof( VendorRentalContract ), 1252, Utility.Random( 1,15 ), 0x14F0, 0x672 ) ); }
				Add( new GenericBuyInfo( typeof( Beeswax ), 1000, Utility.Random( 1,15 ), 0x1422, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiBeeHiveDeed ), 2000, Utility.Random( 1,10 ), 2330, 0 ) ); 
				Add( new GenericBuyInfo( typeof( HiveTool ), 100, Utility.Random( 1,15 ), 2549, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiSmallWaxPot ), 250, Utility.Random( 1,15 ), 2532, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiLargeWaxPot ), 400, Utility.Random( 1,15 ), 2541, 0 ) ); 
				Add( new GenericBuyInfo( typeof( WaxingPot ), 50, Utility.Random( 1,15 ), 0x142B, 0 ) ); 
				Add( new GenericBuyInfo( "Waever's Spool", typeof( WeaversSpool ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Toy Maker's Kit", typeof( ToyMakersKit ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( JuicersTools ), 500, 20, 0xE4F, 0 ) );
				Add( new GenericBuyInfo( typeof( Keg ), 50, 20, 0xE7F, 0 ) );
				Add( new GenericBuyInfo( typeof( BrewersTools ), 500, 20, 0x1EBC, 0 ) );
				Add( new GenericBuyInfo( typeof( BreweryLabelMaker ), 500, 20, 0xFBF, 0 ) );
				Add( new GenericBuyInfo( typeof( Malt ), 10, 20, 0x103D, 0 ) );
				Add( new GenericBuyInfo( typeof( Barley ), 20, 20, 0x103F, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyAleBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyMeadBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyJug ), 10, 20, 0x9C8, 0 ) );
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( Apple ), 3, 20, 0x9D0, 0 ) );
				Add( new GenericBuyInfo( typeof( Grapes ), 3, 20, 0x9D1, 0 ) );
				Add( new GenericBuyInfo( typeof( Watermelon ), 7, 20, 0xC5C, 0 ) );
				Add( new GenericBuyInfo( typeof( YellowGourd ), 3, 20, 0xC64, 0 ) );
				Add( new GenericBuyInfo( typeof( Pumpkin ), 11, 20, 0xC6A, 0 ) );
				Add( new GenericBuyInfo( typeof( Onion ), 3, 20, 0xC6D, 0 ) );
				Add( new GenericBuyInfo( typeof( Lettuce ), 5, 20, 0xC70, 0 ) );
				Add( new GenericBuyInfo( typeof( Squash ), 3, 20, 0xC72, 0 ) );
				Add( new GenericBuyInfo( typeof( HoneydewMelon ), 7, 20, 0xC74, 0 ) );
				Add( new GenericBuyInfo( typeof( Carrot ), 3, 20, 0xC77, 0 ) );
				Add( new GenericBuyInfo( typeof( Cantaloupe ), 6, 20, 0xC79, 0 ) );
				Add( new GenericBuyInfo( typeof( Cabbage ), 5, 20, 0xC7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lemon ), 3, 20, 0x1728, 0 ) );
				Add( new GenericBuyInfo( typeof( Lime ), 3, 20, 0x172A, 0 ) );
				Add( new GenericBuyInfo( typeof( Peach ), 3, 20, 0x9D2, 0 ) );
				Add( new GenericBuyInfo( typeof( Pear ), 3, 20, 0x994, 0 ) );
				Add( new GenericBuyInfo( "1060834", typeof( Engines.Plants.PlantBowl ), 2, 20, 0x15FD, 0 ) );
				Add( new GenericBuyInfo( "Cotton Seed", typeof( CottonSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Flax Seed", typeof( FlaxSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Wheat Seed", typeof( WheatSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Planting Corn", typeof( CornSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Carrot Seed", typeof( CarrotSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Onion Seed", typeof( OnionSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Garlic Seed", typeof( GarlicSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Lettuce Seed", typeof( LettuceSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Cabbage Seed", typeof( CabbageSeed ), 50, 20, 0xF27, 0x5E2 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfCarrots ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfCorn ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfLettuce ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfPeas ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmptyPewterBowl ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfCorn ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfLettuce ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfPeas ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PewterBowlOfFoodPotatos ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfStew ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBowlOfTomatoSoup ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BeverageBottle ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Waterskin ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Jug ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pitcher ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GlassMug ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BreadLoaf ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CheeseWheel ), 12 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ribs ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Peach ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pear ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Grapes ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Apple ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Banana ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Candle ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( tarotpoker ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MahjongGame ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Chessboard ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CheckerBoard ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Backgammon ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Dices ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ContractOfEmployment ), 626 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RomulanAle ), Utility.Random( 20,100 ) ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBThief : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBThief()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Backpack ), 15, Utility.Random( 1,15 ), 0x9B2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Pouch ), 6, Utility.Random( 1,15 ), 0xE79, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Torch ), 8, Utility.Random( 1,15 ), 0xF6B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Lantern ), 2, Utility.Random( 1,15 ), 0xA25, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LearnStealingBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LearnTraps ), 5, Utility.Random( 1,15 ), 0xFF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Lockpick ), 12, Utility.Random( 300,500 ), 0x14FC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SkeletonsKey ), Utility.Random( 25,100 ), 1, 0x410A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBox ), 14, Utility.Random( 1,15 ), 0x9AA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Key ), 2, Utility.Random( 1,15 ), 0x100E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1041060", typeof( HairDye ), 100, Utility.Random( 1,15 ), 0xEFF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "hair dye bottle", typeof( HairDyeBottle ), 1000, Utility.Random( 1,15 ), 0xE0F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DisguiseKit ), 700, Utility.Random( 1,5 ), 0xE05, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Backpack ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pouch ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Torch ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Lantern ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Lockpick ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenBox ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HairDye ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HairDyeBottle ), 300 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkeletonsKey ), 10 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBTinker: SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBTinker() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{
				Add( new GenericBuyInfo( "Toy Maker's Kit", typeof( ToyMakersKit ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Clock ), 22, Utility.Random( 1,15 ), 0x104B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Nails ), 3, Utility.Random( 1,15 ), 0x102E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ClockParts ), 3, Utility.Random( 1,15 ), 0x104F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AxleGears ), 3, Utility.Random( 1,15 ), 0x1051, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Gears ), 2, Utility.Random( 1,15 ), 0x1053, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Hinge ), 2, Utility.Random( 1,15 ), 0x1055, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Sextant ), 13, Utility.Random( 1,15 ), 0x1057, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SextantParts ), 5, Utility.Random( 1,15 ), 0x1059, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Axle ), 2, Utility.Random( 1,15 ), 0x105B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Springs ), 3, Utility.Random( 1,15 ), 0x105D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1024111", typeof( Key ), 8, Utility.Random( 1,15 ), 0x100F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1024112", typeof( Key ), 8, Utility.Random( 1,15 ), 0x1010, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( "1024115", typeof( Key ), 8, Utility.Random( 1,15 ), 0x1013, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( KeyRing ), 8, Utility.Random( 1,15 ), 0x1010, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Lockpick ), 12, Utility.Random( 1,15 ), 0x14FC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SkeletonsKey ), Utility.Random( 25,100 ), 1, 0x410A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( TinkersTools ), 7, Utility.Random( 1,15 ), 0x1EBC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Board ), 3, Utility.Random( 1,15 ), 0x1BD7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( IronIngot ), 5, Utility.Random( 1,15 ), 0x1BF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SewingKit ), 3, Utility.Random( 1,15 ), 0xF9D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DrawKnife ), 10, Utility.Random( 1,15 ), 0x10E4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Froe ), 10, Utility.Random( 1,15 ), 0x10E5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Scorp ), 10, Utility.Random( 1,15 ), 0x10E7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Inshave ), 10, Utility.Random( 1,15 ), 0x10E6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ButcherKnife ), 13, Utility.Random( 1,15 ), 0x13F6, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Scissors ), 11, Utility.Random( 1,15 ), 0xF9F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Tongs ), 13, Utility.Random( 1,15 ), 0xFBB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DovetailSaw ), 12, Utility.Random( 1,15 ), 0x1028, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Saw ), 15, Utility.Random( 1,15 ), 0x1034, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Hammer ), 17, Utility.Random( 1,15 ), 0x102A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SmithHammer ), 23, Utility.Random( 1,15 ), 0x0FB4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Shovel ), 12, Utility.Random( 1,15 ), 0xF39, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( OreShovel ), 10, Utility.Random( 1,15 ), 0xF39, 0x96D ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MouldingPlane ), 11, Utility.Random( 1,15 ), 0x102C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( JointingPlane ), 10, Utility.Random( 1,15 ), 0x1030, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SmoothingPlane ), 11, Utility.Random( 1,15 ), 0x1032, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Pickaxe ), 25, Utility.Random( 1,15 ), 0xE86, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ThrowingWeapon ), 2, Utility.Random( 20, 90 ), 0xF8F, 0x83F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WallTorch ), 50, Utility.Random( 5,20 ), 0xA07, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( ColoredWallTorch ), 100, Utility.Random( 5,20 ), 0x3D89, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( light_dragon_brazier ), 750, Utility.Random( 1,15 ), 0x194E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( TrapKit ), 420, Utility.Random( 1,5 ), 0x1EBB, 0 ) ); }
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( LootChest ), 600 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Shovel ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OreShovel ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SewingKit ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Scissors ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Tongs ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Key ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DovetailSaw ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MouldingPlane ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Nails ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JointingPlane ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SmoothingPlane ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Saw ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Clock ), 11 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ClockParts ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AxleGears ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Gears ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Hinge ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Sextant ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SextantParts ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Axle ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Springs ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DrawKnife ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Froe ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Inshave ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Scorp ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Lockpick ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkeletonsKey ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TinkerTools ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Board ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Log ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Pickaxe ), 16 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Hammer ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SmithHammer ), 11 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ButcherKnife ), 6 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CrystalScales ), Utility.Random( 250,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GolemManual ), Utility.Random( 500,750 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PowerCrystal ), 15 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ArcaneGem ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ClockworkAssembly ), 15 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BottleOil ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ThrowingWeapon ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TrapKit ), 210 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkA ), Utility.Random( 5, 10 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkB ), Utility.Random( 10, 20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkC ), Utility.Random( 15, 30 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkD ), Utility.Random( 20, 40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkE ), Utility.Random( 25, 50 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkF ), Utility.Random( 30, 60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkG ), Utility.Random( 35, 70 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkH ), Utility.Random( 40, 80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkI ), Utility.Random( 45, 90 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkJ ), Utility.Random( 50, 100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkK ), Utility.Random( 55, 110 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkL ), Utility.Random( 60, 120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkM ), Utility.Random( 65, 130 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkN ), Utility.Random( 70, 140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkO ), Utility.Random( 75, 150 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkP ), Utility.Random( 80, 160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkQ ), Utility.Random( 85, 170 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkR ), Utility.Random( 90, 180 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkS ), Utility.Random( 95, 190 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkT ), Utility.Random( 100, 200 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkU ), Utility.Random( 105, 210 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkV ), Utility.Random( 110, 220 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkW ), Utility.Random( 115, 230 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkX ), Utility.Random( 120, 240 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkY ), Utility.Random( 125, 250 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpaceJunkZ ), Utility.Random( 130, 260 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LandmineSetup ), Utility.Random( 100, 300 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlasmaGrenade ), Utility.Random( 28, 38 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ThermalDetonator ), Utility.Random( 28, 38 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PuzzleCube ), Utility.Random( 45, 90 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PlasmaTorch ), Utility.Random( 45, 90 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DuctTape ), Utility.Random( 45, 90 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RobotBatteries ), Utility.Random( 5, 100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RobotSheetMetal ), Utility.Random( 5, 100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RobotOil ), Utility.Random( 5, 100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RobotGears ), Utility.Random( 5, 100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RobotEngineParts ), Utility.Random( 5, 100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RobotCircuitBoard ), Utility.Random( 5, 100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RobotBolt ), Utility.Random( 5, 100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RobotTransistor ), Utility.Random( 5, 100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RobotSchematics ), Utility.Random( 500,750 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DataPad ), Utility.Random( 5, 150 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MaterialLiquifier ), Utility.Random( 100, 300 ) ); } // DO NOT WANT?
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////

	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBVagabond : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBVagabond()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Toy Maker's Kit", typeof( ToyMakersKit ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GoldRing ), 27, Utility.Random( 1,15 ), 0x108A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Necklace ), 26, Utility.Random( 1,15 ), 0x1085, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GoldNecklace ), 27, Utility.Random( 1,15 ), 0x1088, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GoldBeadNecklace ), 27, Utility.Random( 1,15 ), 0x1089, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Beads ), 27, Utility.Random( 1,15 ), 0x108B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GoldBracelet ), 27, Utility.Random( 1,15 ), 0x1086, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GoldEarrings ), 27, Utility.Random( 1,15 ), 0x1087, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Board ), 3, Utility.Random( 1,15 ), 0x1BD7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( IronIngot ), 6, Utility.Random( 1,15 ), 0x1BF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StarSapphire ), 125, Utility.Random( 1,15 ), 0xF21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Emerald ), 100, Utility.Random( 1,15 ), 0xF10, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Sapphire ), 100, Utility.Random( 1,15 ), 0xF19, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ruby ), 75, Utility.Random( 1,15 ), 0xF13, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Citrine ), 50, Utility.Random( 1,15 ), 0xF15, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Amethyst ), 100, Utility.Random( 1,15 ), 0xF16, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Tourmaline ), 75, Utility.Random( 1,15 ), 0xF2D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Amber ), 50, Utility.Random( 1,15 ), 0xF25, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Diamond ), 200, Utility.Random( 1,15 ), 0xF26, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Board ), 3, Utility.Random( 1,15 ), 0x1BD7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( IronIngot ), 6, Utility.Random( 1,15 ), 0x1BF2, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Board ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IronIngot ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Amber ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Amethyst ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Citrine ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Diamond ), 100 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Emerald ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ruby ), 37 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Sapphire ), 50 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarSapphire ), 62 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Tourmaline ), 47 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldRing ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverRing ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Necklace ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldNecklace ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldBeadNecklace ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverNecklace ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverBeadNecklace ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Beads ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldBracelet ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverBracelet ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GoldEarrings ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverEarrings ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicJewelryRing ), Utility.Random( 50,300 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicJewelryCirclet ), Utility.Random( 50,300 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicJewelryNecklace ), Utility.Random( 50,300 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicJewelryEarrings ), Utility.Random( 50,300 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicJewelryBracelet ), Utility.Random( 50,300 ) ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBVarietyDealer : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBVarietyDealer()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Toy Maker's Kit", typeof( ToyMakersKit ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( DocLootBag ), 200, Utility.Random( 3,31 ), 0xE76, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) >= 0){Add( new GenericBuyInfo( typeof( ArtifactVase ), Utility.Random( 1000,5000 ), 1, 0x0B48, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( ArtifactLargeVase ), Utility.Random( 1000,5000 ), 1, 0x0B47, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TapestryOfSosaria ), Utility.Random( 1000,5000 ), 1, 0x234E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BlueDecorativeRugDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BlueFancyRugDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BluePlainRugDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( CinnamonFancyRugDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( CurtainsDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( FountainDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( GoldenDecorativeRugDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( HangingAxesDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( HangingSwordsDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( PinkFancyRugDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 0){Add( new GenericBuyInfo( typeof( RedPlainRugDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( WallBannerDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( DecorativeShieldDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( StoneAnkhDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( BannerDeed ), Utility.Random( 1000,5000 ), 1, 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( DecoTray ), Utility.Random( 1000,5000 ), 1, 0x992, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( DecoTray2 ), Utility.Random( 1000,5000 ), 1, 0x991, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TreasurePile01AddonDeed ), Utility.Random( 8000,12000 ), 1, 0x0E41, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TreasurePile02AddonDeed ), Utility.Random( 8000,12000 ), 1, 0x0E41, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TreasurePile03AddonDeed ), Utility.Random( 8000,12000 ), 1, 0x0E41, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TreasurePile04AddonDeed ), Utility.Random( 8000,12000 ), 1, 0x0E41, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TreasurePile05AddonDeed ), Utility.Random( 8000,12000 ), 1, 0x0E41, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TreasurePileAddonDeed ), Utility.Random( 12000,20000 ), 1, 0x0E41, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TreasurePile2AddonDeed ), Utility.Random( 12000,20000 ), 1, 0x0E41, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 95){Add( new GenericBuyInfo( typeof( TreasurePile3AddonDeed ), Utility.Random( 12000,20000 ), 1, 0x0E41, 0 ) ); }
				Add( new GenericBuyInfo( typeof( Beeswax ), 1000, Utility.Random( 1,15 ), 0x1422, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiBeeHiveDeed ), 2000, Utility.Random( 1,10 ), 2330, 0 ) ); 
				Add( new GenericBuyInfo( typeof( HiveTool ), 100, Utility.Random( 1,15 ), 2549, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiSmallWaxPot ), 250, Utility.Random( 1,15 ), 2532, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiLargeWaxPot ), 400, Utility.Random( 1,15 ), 2541, 0 ) ); 
				Add( new GenericBuyInfo( typeof( WaxingPot ), 50, Utility.Random( 1,15 ), 0x142B, 0 ) ); 
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( JuicersTools ), 500, 20, 0xE4F, 0 ) );
				Add( new GenericBuyInfo( typeof( Keg ), 50, 20, 0xE7F, 0 ) );
				Add( new GenericBuyInfo( typeof( BrewersTools ), 500, 20, 0x1EBC, 0 ) );
				Add( new GenericBuyInfo( typeof( BreweryLabelMaker ), 500, 20, 0xFBF, 0 ) );
				Add( new GenericBuyInfo( typeof( Malt ), 10, 20, 0x103D, 0 ) );
				Add( new GenericBuyInfo( typeof( Barley ), 20, 20, 0x103F, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyAleBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyMeadBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyJug ), 10, 20, 0x9C8, 0 ) );
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( Apple ), 3, 20, 0x9D0, 0 ) );
				Add( new GenericBuyInfo( typeof( Grapes ), 3, 20, 0x9D1, 0 ) );
				Add( new GenericBuyInfo( typeof( Watermelon ), 7, 20, 0xC5C, 0 ) );
				Add( new GenericBuyInfo( typeof( YellowGourd ), 3, 20, 0xC64, 0 ) );
				Add( new GenericBuyInfo( typeof( Pumpkin ), 11, 20, 0xC6A, 0 ) );
				Add( new GenericBuyInfo( typeof( Onion ), 3, 20, 0xC6D, 0 ) );
				Add( new GenericBuyInfo( typeof( Lettuce ), 5, 20, 0xC70, 0 ) );
				Add( new GenericBuyInfo( typeof( Squash ), 3, 20, 0xC72, 0 ) );
				Add( new GenericBuyInfo( typeof( HoneydewMelon ), 7, 20, 0xC74, 0 ) );
				Add( new GenericBuyInfo( typeof( Carrot ), 3, 20, 0xC77, 0 ) );
				Add( new GenericBuyInfo( typeof( Cantaloupe ), 6, 20, 0xC79, 0 ) );
				Add( new GenericBuyInfo( typeof( Cabbage ), 5, 20, 0xC7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lemon ), 3, 20, 0x1728, 0 ) );
				Add( new GenericBuyInfo( typeof( Lime ), 3, 20, 0x172A, 0 ) );
				Add( new GenericBuyInfo( typeof( Peach ), 3, 20, 0x9D2, 0 ) );
				Add( new GenericBuyInfo( typeof( Pear ), 3, 20, 0x994, 0 ) );
				Add( new GenericBuyInfo( "1060834", typeof( Engines.Plants.PlantBowl ), 2, 20, 0x15FD, 0 ) );
				Add( new GenericBuyInfo( "Cotton Seed", typeof( CottonSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Flax Seed", typeof( FlaxSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Wheat Seed", typeof( WheatSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Planting Corn", typeof( CornSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Carrot Seed", typeof( CarrotSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Onion Seed", typeof( OnionSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Garlic Seed", typeof( GarlicSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Lettuce Seed", typeof( LettuceSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Cabbage Seed", typeof( CabbageSeed ), 50, 20, 0xF27, 0x5E2 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( LootChest ), 600 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( WaxPainting ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( WaxPaintingA ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( WaxPaintingB ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( WaxPaintingC ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( WaxPaintingD ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( WaxPaintingE ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( WaxPaintingF ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( WaxPaintingG ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( WaxSculptors ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( WaxSculptorsA ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( WaxSculptorsB ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( WaxSculptorsC ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( WaxSculptorsD ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( WaxSculptorsE ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 14){Add( typeof( DragonLamp ), Utility.Random( 50,500 ) ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBVeterinarian : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBVeterinarian()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Bandage ), 5, Utility.Random( 1,15 ), 0xE21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LesserHealPotion ), 15, Utility.Random( 1,15 ), 0x25FD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ginseng ), 3, Utility.Random( 1,15 ), 0xF85, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Garlic ), 3, Utility.Random( 1,15 ), 0xF84, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RefreshPotion ), 15, Utility.Random( 1,15 ), 0xF0B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 10){Add( new GenericBuyInfo( typeof( StableStone ), 5000, Utility.Random( 1,3 ), 0x14E7, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LesserHealPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RefreshPotion ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Garlic ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ginseng ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 10){Add( typeof( StableStone ), 2500 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( typeof( AlienEgg ), Utility.Random( 500,1000 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( typeof( DragonEgg ), Utility.Random( 500,1000 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( FirstAidKit ), Utility.Random( 100,250 ) ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBWaiter : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBWaiter()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Toy Maker's Kit", typeof( ToyMakersKit ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Ale, 7, Utility.Random( 1,15 ), 0x99F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Wine, 7, Utility.Random( 1,15 ), 0x9C7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( BeverageBottle ), BeverageType.Liquor, 7, Utility.Random( 1,15 ), 0x99B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Jug ), BeverageType.Cider, 13, Utility.Random( 1,15 ), 0x9C8, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Milk, 7, Utility.Random( 1,15 ), 0x9F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Ale, 11, Utility.Random( 1,15 ), 0x1F95, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Cider, 11, Utility.Random( 1,15 ), 0x1F97, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Liquor, 11, Utility.Random( 1,15 ), 0x1F99, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Wine, 11, Utility.Random( 1,15 ), 0x1F9B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new BeverageBuyInfo( typeof( Pitcher ), BeverageType.Water, 11, Utility.Random( 1,15 ), 0x1F9D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( BreadLoaf ), 6, Utility.Random( 1,15 ), 0x103B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CheeseWheel ), 21, Utility.Random( 1,15 ), 0x97E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CookedBird ), 17, Utility.Random( 1,15 ), 0x9B7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LambLeg ), 8, Utility.Random( 1,15 ), 0x160A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfCarrots ), 3, Utility.Random( 1,15 ), 0x15F9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfCorn ), 3, Utility.Random( 1,15 ), 0x15FA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfLettuce ), 3, Utility.Random( 1,15 ), 0x15FB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfPeas ), 3, Utility.Random( 1,15 ), 0x15FC, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( EmptyPewterBowl ), 2, Utility.Random( 1,15 ), 0x15FD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfCorn ), 3, Utility.Random( 1,15 ), 0x15FE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfLettuce ), 3, Utility.Random( 1,15 ), 0x15FF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfPeas ), 3, Utility.Random( 1,15 ), 0x1600, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PewterBowlOfFoodPotatos ), 3, Utility.Random( 1,15 ), 0x1601, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfStew ), 3, Utility.Random( 1,15 ), 0x1604, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WoodenBowlOfTomatoSoup ), 3, Utility.Random( 1,15 ), 0x1606, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ApplePie ), 7, Utility.Random( 1,15 ), 0x1041, 0 ) ); } //OSI just has Pie, not Apple/Fruit/Meat
				Add( new GenericBuyInfo( typeof( Beeswax ), 1000, Utility.Random( 1,15 ), 0x1422, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiBeeHiveDeed ), 2000, Utility.Random( 1,10 ), 2330, 0 ) ); 
				Add( new GenericBuyInfo( typeof( HiveTool ), 100, Utility.Random( 1,15 ), 2549, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiSmallWaxPot ), 250, Utility.Random( 1,15 ), 2532, 0 ) ); 
				Add( new GenericBuyInfo( typeof( apiLargeWaxPot ), 400, Utility.Random( 1,15 ), 2541, 0 ) ); 
				Add( new GenericBuyInfo( typeof( WaxingPot ), 50, Utility.Random( 1,15 ), 0x142B, 0 ) ); 
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( JuicersTools ), 500, 20, 0xE4F, 0 ) );
				Add( new GenericBuyInfo( typeof( Keg ), 50, 20, 0xE7F, 0 ) );
				Add( new GenericBuyInfo( typeof( BrewersTools ), 500, 20, 0x1EBC, 0 ) );
				Add( new GenericBuyInfo( typeof( BreweryLabelMaker ), 500, 20, 0xFBF, 0 ) );
				Add( new GenericBuyInfo( typeof( Malt ), 10, 20, 0x103D, 0 ) );
				Add( new GenericBuyInfo( typeof( Barley ), 20, 20, 0x103F, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyAleBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyMeadBottle ), 10, 20, 0x99B, 0 ) );
				Add( new GenericBuyInfo( typeof( EmptyJug ), 10, 20, 0x9C8, 0 ) );
				Add( new GenericBuyInfo( typeof( FoodPlate ), 5, 20, 0x9D7, 0 ) );
				Add( new GenericBuyInfo( typeof( BakersBoard ), 10, 20, 0x14EA, 0 ) );
				Add( new GenericBuyInfo( typeof( CooksCauldron ), 10, 20, 0x9ED, 0 ) );
				Add( new GenericBuyInfo( typeof( FryingPan ), 10, 20, 0x9E2, 0 ) );
				Add( new GenericBuyInfo( typeof( Apple ), 3, 20, 0x9D0, 0 ) );
				Add( new GenericBuyInfo( typeof( Grapes ), 3, 20, 0x9D1, 0 ) );
				Add( new GenericBuyInfo( typeof( Watermelon ), 7, 20, 0xC5C, 0 ) );
				Add( new GenericBuyInfo( typeof( YellowGourd ), 3, 20, 0xC64, 0 ) );
				Add( new GenericBuyInfo( typeof( Pumpkin ), 11, 20, 0xC6A, 0 ) );
				Add( new GenericBuyInfo( typeof( Onion ), 3, 20, 0xC6D, 0 ) );
				Add( new GenericBuyInfo( typeof( Lettuce ), 5, 20, 0xC70, 0 ) );
				Add( new GenericBuyInfo( typeof( Squash ), 3, 20, 0xC72, 0 ) );
				Add( new GenericBuyInfo( typeof( HoneydewMelon ), 7, 20, 0xC74, 0 ) );
				Add( new GenericBuyInfo( typeof( Carrot ), 3, 20, 0xC77, 0 ) );
				Add( new GenericBuyInfo( typeof( Cantaloupe ), 6, 20, 0xC79, 0 ) );
				Add( new GenericBuyInfo( typeof( Cabbage ), 5, 20, 0xC7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lemon ), 3, 20, 0x1728, 0 ) );
				Add( new GenericBuyInfo( typeof( Lime ), 3, 20, 0x172A, 0 ) );
				Add( new GenericBuyInfo( typeof( Peach ), 3, 20, 0x9D2, 0 ) );
				Add( new GenericBuyInfo( typeof( Pear ), 3, 20, 0x994, 0 ) );
				Add( new GenericBuyInfo( "1060834", typeof( Engines.Plants.PlantBowl ), 2, 20, 0x15FD, 0 ) );
				Add( new GenericBuyInfo( "Cotton Seed", typeof( CottonSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Flax Seed", typeof( FlaxSeed ), 250, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Wheat Seed", typeof( WheatSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Planting Corn", typeof( CornSeed ), 150, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Carrot Seed", typeof( CarrotSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Onion Seed", typeof( OnionSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Garlic Seed", typeof( GarlicSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Lettuce Seed", typeof( LettuceSeed ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( "Cabbage Seed", typeof( CabbageSeed ), 50, 20, 0xF27, 0x5E2 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBWeaponSmith: SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBWeaponSmith() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{
				Add( new GenericBuyInfo( "Toy Maker's Kit", typeof( ToyMakersKit ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WeaponAbilityBook ), 5, Utility.Random( 1,15 ), 0x2254, 0 ) ); }
			}
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RareAnvil ), Utility.Random( 200,1000 ) ); } // DO NOT WANT?
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBWeaver: SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBWeaver() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{ 
			Add( new GenericBuyInfo( "Toy Maker's Kit", typeof( ToyMakersKit ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Dyes ), 8, Utility.Random( 1,15 ), 0xFA9, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DyeTub ), 8, Utility.Random( 1,15 ), 0xFAB, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( UncutCloth ), 3, Utility.Random( 1,15 ), 0x1761, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( UncutCloth ), 3, Utility.Random( 1,15 ), 0x1762, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( UncutCloth ), 3, Utility.Random( 1,15 ), 0x1763, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( UncutCloth ), 3, Utility.Random( 1,15 ), 0x1764, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BoltOfCloth ), 100, Utility.Random( 1,15 ), 0xf9B, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BoltOfCloth ), 100, Utility.Random( 1,15 ), 0xf9C, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BoltOfCloth ), 100, Utility.Random( 1,15 ), 0xf96, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BoltOfCloth ), 100, Utility.Random( 1,15 ), 0xf97, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DarkYarn ), 18, Utility.Random( 1,15 ), 0xE1D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LightYarn ), 18, Utility.Random( 1,15 ), 0xE1E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LightYarnUnraveled ), 18, Utility.Random( 1,15 ), 0xE1F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( PaintCanvas ), 500, Utility.Random( 1,15 ), 0xA6C, 0x47E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( Scissors ), 11, Utility.Random( 1,15 ), 0xF9F, 0 ) ); }
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{ 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Scissors ), 6 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Dyes ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DyeTub ), 4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( UncutCloth ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BoltOfCloth ), 50 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LightYarnUnraveled ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LightYarn ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DarkYarn ), 9 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PaintCanvas ), 250 ); } // DO NOT WANT?
			} 
		} 
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBNecroMage : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBNecroMage()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( BatWing ), 3, 20, 0xF78, 0 ) );
				Add( new GenericBuyInfo( typeof( DaemonBlood ), 6, 20, 0xF7D, 0 ) );
				Add( new GenericBuyInfo( typeof( PigIron ), 5, 20, 0xF8A, 0 ) );
				Add( new GenericBuyInfo( typeof( NoxCrystal ), 6, 20, 0xF8E, 0 ) );
				Add( new GenericBuyInfo( typeof( GraveDust ), 3, 20, 0xF8F, 0 ) );
				Add( new GenericBuyInfo( typeof( BloodOathScroll ), 25, 5, 0x2263, 0 ) );
				Add( new GenericBuyInfo( typeof( CorpseSkinScroll ), 28, 5, 0x2263, 0 ) );
				Add( new GenericBuyInfo( typeof( CurseWeaponScroll ), 12, 5, 0x2263, 0 ) );
				Add( new GenericBuyInfo( typeof( PolishBoneBrush ), 12, 10, 0x1371, 0 ) );
				Add( new GenericBuyInfo( typeof( GraveShovel ), 12, Utility.Random( 1,15 ), 0xF39, 0x966 ) );
				Add( new GenericBuyInfo( typeof( SurgeonsKnife ), 14, Utility.Random( 1,15 ), 0xEC4, 0x1B0 ) );
				Add( new GenericBuyInfo( typeof( Jar ), 5, Utility.Random( 1,15 ), 0x10B4, 0 ) );
				Add( new GenericBuyInfo( typeof( MixingCauldron ), 247, 1, 0x269C, 0 ) );
				Add( new GenericBuyInfo( typeof( MixingSpoon ), 34, Utility.Random( 1,15 ), 0x1E27, 0x979 ) );
				Add( new GenericBuyInfo( typeof( CBookNecroticAlchemy ), 50, Utility.Random( 1,15 ), 0x2253, 0x4AA ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AlchemyTub ), 2400, Utility.Random( 1,5 ), 0x126A, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( AlchemyPouch ), Utility.Random( 2900,3500 ), Utility.Random( 1,2 ), 0x1C10, 0x89F ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( BatWing ), 1 );
				Add( typeof( DaemonBlood ), 3 );
				Add( typeof( PigIron ), 2 );
				Add( typeof( NoxCrystal ), 3 );
				Add( typeof( GraveDust ), 1 );
				Add( typeof( ExorcismScroll ), 1 );
				Add( typeof( AnimateDeadScroll ), 26 );
				Add( typeof( BloodOathScroll ), 26 );
				Add( typeof( CorpseSkinScroll ), 26 );
				Add( typeof( CurseWeaponScroll ), 26 );
				Add( typeof( EvilOmenScroll ), 26 );
				Add( typeof( PainSpikeScroll ), 26 );
				Add( typeof( SummonFamiliarScroll ), 26 );
				Add( typeof( HorrificBeastScroll ), 27 );
				Add( typeof( MindRotScroll ), 39 );
				Add( typeof( PoisonStrikeScroll ), 39 );
				Add( typeof( WraithFormScroll ), 51 );
				Add( typeof( LichFormScroll ), 64 );
				Add( typeof( StrangleScroll ), 64 );
				Add( typeof( WitherScroll ), 64 );
				Add( typeof( VampiricEmbraceScroll ), 101 );
				Add( typeof( VengefulSpiritScroll ), 114 );
				Add( typeof( PolishBoneBrush ), 6 );
				Add( typeof( PolishedSkull ), 3 );
				Add( typeof( PolishedBone ), 3 );
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MixingCauldron ), 123 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MixingSpoon ), 17 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SurgeonsKnife ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullMinotaur ), Utility.Random( 50,150 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullWyrm ), Utility.Random( 200,400 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullGreatDragon ), Utility.Random( 300,600 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullDragon ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullDemon ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullGiant ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				Add( typeof( CorpseSailor ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( CorpseChest ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( BuriedBody ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( BoneContainer ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( LeftLeg ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RightLeg ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( TastyHeart ), Utility.RandomMinMax( 10, 20 ) );
				Add( typeof( BodyPart ), Utility.RandomMinMax( 30, 90 ) );
				Add( typeof( Head ), Utility.RandomMinMax( 10, 20 ) );
				Add( typeof( LeftArm ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RightArm ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Torso ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Bone ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RibCage ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( BonePile ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Bones ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( GraveChest ), Utility.RandomMinMax( 100, 500 ) );
				Add( typeof( AlchemyTub ), Utility.Random( 200, 500 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenCoffin ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenCasket ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StoneCoffin ), 45 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StoneCasket ), 45 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBNecromancer : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBNecromancer()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( NecromancerSpellbook ), 115, 1, 0x2253, 0 ) );
				Add( new GenericBuyInfo( typeof( NecroSkinPotion ), 1000, 1, 0x1006, 0 ) );
				Add( new GenericBuyInfo( typeof( BookofDead ), 25000, 1,  0x1C11, 2500 ) );
				Add( new GenericBuyInfo( typeof( DarkHeart ), 500, 5, 0xF91, 0x386 ) );
				Add( new GenericBuyInfo( typeof( BatWing ), 3, 20, 0xF78, 0 ) );
				Add( new GenericBuyInfo( typeof( DaemonBlood ), 6, 20, 0xF7D, 0 ) );
				Add( new GenericBuyInfo( typeof( PigIron ), 5, 20, 0xF8A, 0 ) );
				Add( new GenericBuyInfo( typeof( NoxCrystal ), 6, 20, 0xF8E, 0 ) );
				Add( new GenericBuyInfo( typeof( GraveDust ), 3, 20, 0xF8F, 0 ) );
				Add( new GenericBuyInfo( typeof( BloodOathScroll ), 25, 5, 0x2263, 0 ) );
				Add( new GenericBuyInfo( typeof( CorpseSkinScroll ), 28, 5, 0x2263, 0 ) );
				Add( new GenericBuyInfo( typeof( CurseWeaponScroll ), 12, 5, 0x2263, 0 ) );
				Add( new GenericBuyInfo( typeof( PolishBoneBrush ), 12, 10, 0x1371, 0 ) );
				Add( new GenericBuyInfo( typeof( GraveShovel ), 12, Utility.Random( 1,15 ), 0xF39, 0x966 ) );
				Add( new GenericBuyInfo( typeof( SurgeonsKnife ), 14, Utility.Random( 1,15 ), 0xEC4, 0x1B0 ) );
				Add( new GenericBuyInfo( typeof( MixingCauldron ), 247, 1, 0x269C, 0 ) );
				Add( new GenericBuyInfo( typeof( MixingSpoon ), 34, Utility.Random( 1,15 ), 0x1E27, 0x979 ) );
				Add( new GenericBuyInfo( typeof( Jar ), 5, Utility.Random( 1,15 ), 0x10B4, 0 ) );
				Add( new GenericBuyInfo( typeof( CBookNecroticAlchemy ), 50, Utility.Random( 1,15 ), 0x2253, 0x4AA ) );
				Add( new GenericBuyInfo( "undead horse", typeof( NecroHorse ), 10000, 5, 0x2617, 0xB97 ) );
				Add( new GenericBuyInfo( "daemon servant", typeof( DaemonMount ), 15000, 5, 11669, 0x4AA ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AlchemyTub ), 2400, Utility.Random( 1,5 ), 0x126A, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( AlchemyPouch ), Utility.Random( 2900,3500 ), Utility.Random( 1,2 ), 0x1C10, 0x89F ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( BatWing ), 1 );
				Add( typeof( DaemonBlood ), 3 );
				Add( typeof( PigIron ), 2 );
				Add( typeof( NoxCrystal ), 3 );
				Add( typeof( GraveDust ), 1 );
				Add( typeof( ExorcismScroll ), 1 );
				Add( typeof( AnimateDeadScroll ), 26 );
				Add( typeof( BloodOathScroll ), 26 );
				Add( typeof( CorpseSkinScroll ), 26 );
				Add( typeof( CurseWeaponScroll ), 26 );
				Add( typeof( EvilOmenScroll ), 26 );
				Add( typeof( PainSpikeScroll ), 26 );
				Add( typeof( SummonFamiliarScroll ), 26 );
				Add( typeof( HorrificBeastScroll ), 27 );
				Add( typeof( MindRotScroll ), 39 );
				Add( typeof( PoisonStrikeScroll ), 39 );
				Add( typeof( WraithFormScroll ), 51 );
				Add( typeof( LichFormScroll ), 64 );
				Add( typeof( StrangleScroll ), 64 );
				Add( typeof( WitherScroll ), 64 );
				Add( typeof( VampiricEmbraceScroll ), 101 );
				Add( typeof( VengefulSpiritScroll ), 114 );
				Add( typeof( PolishBoneBrush ), 6 );
				Add( typeof( PolishedSkull ), 3 );
				Add( typeof( PolishedBone ), 3 );
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullDragon ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullDemon ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullGiant ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MixingCauldron ), 123 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MixingSpoon ), 17 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SurgeonsKnife ), 7 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){ Add( typeof( BoneContainer ), 250 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ClumsyMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( CreateFoodMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FeebleMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( HealMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicArrowMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( NightSightMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ReactiveArmorMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( WeaknessMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( AgilityMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( CunningMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( CureMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( HarmMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicTrapMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicUntrapMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ProtectionMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( StrengthMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( BlessMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FireballMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicLockMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicUnlockMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( PoisonMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( TelekinesisMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( TeleportMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( WallofStoneMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ArchCureMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ArchProtectionMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( CurseMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FireFieldMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( GreaterHealMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( LightningMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ManaDrainMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( RecallMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( BladeSpiritsMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( DispelFieldMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( IncognitoMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicReflectionMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MindBlastMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ParalyzeMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( PoisonFieldMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( SummonCreatureMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( DispelMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EnergyBoltMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ExplosionMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( InvisibilityMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MarkMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MassCurseMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ParalyzeFieldMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( RevealMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ChainLightningMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EnergyFieldMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FlameStrikeMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( GateTravelMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ManaVampireMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MassDispelMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MeteorSwarmMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( PolymorphMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( AirElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EarthElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EarthquakeMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EnergyVortexMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FireElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ResurrectionMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( SummonDaemonMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( WaterElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MyNecromancerSpellbook ), Utility.Random( 100,500 ) ); } // DO NOT WANT?
				Add( typeof( CorpseSailor ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( CorpseChest ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( BodyPart ), Utility.RandomMinMax( 30, 90 ) );
				Add( typeof( BuriedBody ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( BoneContainer ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( LeftLeg ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RightLeg ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( TastyHeart ), Utility.RandomMinMax( 10, 20 ) );
				Add( typeof( Head ), Utility.RandomMinMax( 10, 20 ) );
				Add( typeof( LeftArm ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RightArm ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Torso ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Bone ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RibCage ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( BonePile ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Bones ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( GraveChest ), Utility.RandomMinMax( 100, 500 ) );
				Add( typeof( AlchemyTub ), Utility.Random( 200, 500 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenCoffin ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenCasket ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StoneCoffin ), 45 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StoneCasket ), 45 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBWitches : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBWitches()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( NecromancerSpellbook ), 115, 1, 0x2253, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BatWing ), 3, Utility.Random( 10,100 ), 0xF78, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DaemonBlood ), 6, Utility.Random( 10,100 ), 0xF7D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PigIron ), 5, Utility.Random( 10,100 ), 0xF8A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( NoxCrystal ), 6, Utility.Random( 10,100 ), 0xF8E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GraveDust ), 3, Utility.Random( 10,100 ), 0xF8F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BloodOathScroll ), 25, 5, 0x2263, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CorpseSkinScroll ), 28, 5, 0x2263, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CurseWeaponScroll ), 12, 5, 0x2263, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( TarotDeck ), 5, Utility.Random( 1,15 ), 0x12AB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PolishBoneBrush ), 12, 10, 0x1371, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( GraveShovel ), 12, Utility.Random( 1,15 ), 0xF39, 0x966 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( SurgeonsKnife ), 14, Utility.Random( 1,15 ), 0xEC4, 0x1B0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MixingCauldron ), 247, 1, 0x269C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MixingSpoon ), 34, Utility.Random( 1,15 ), 0x1E27, 0x979 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Jar ), 5, Utility.Random( 1,15 ), 0x10B4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CBookNecroticAlchemy ), 50, Utility.Random( 1,15 ), 0x2253, 0x4AA ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( BlackDyeTub ), 5000, 1, 0xFAB, 0x1 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( new GenericBuyInfo( typeof( reagents_magic_jar2 ), 1500, Utility.Random( 1,15 ), 0x1007, 0xB97 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( HellsGateScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x54F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( ManaLeechScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0xB87 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( NecroCurePoisonScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x8A2 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( NecroPoisonScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x4F8 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( NecroUnlockScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x493 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( PhantasmScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x6DE ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( RetchedAirScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0xA97 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( SpectreShadowScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x17E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( UndeadEyesScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x491 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( VampireGiftScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0xB85 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( WallOfSpikesScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0xB8F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( BloodPactScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x5B5 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GhostlyImagesScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0xBF ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GhostPhaseScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x47E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GraveyardGatewayScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x2EA ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( HellsBrandScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x54C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AlchemyTub ), 2400, Utility.Random( 1,5 ), 0x126A, 0 ) ); } 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( AlchemyPouch ), Utility.Random( 2900,3500 ), Utility.Random( 1,2 ), 0x1C10, 0x89F ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( BatWing ), 1 );
				Add( typeof( DaemonBlood ), 3 );
				Add( typeof( PigIron ), 2 );
				Add( typeof( NoxCrystal ), 3 );
				Add( typeof( GraveDust ), 1 );
				Add( typeof( ExorcismScroll ), 1 );
				Add( typeof( AnimateDeadScroll ), 26 );
				Add( typeof( BloodOathScroll ), 26 );
				Add( typeof( CorpseSkinScroll ), 26 );
				Add( typeof( CurseWeaponScroll ), 26 );
				Add( typeof( EvilOmenScroll ), 26 );
				Add( typeof( PainSpikeScroll ), 26 );
				Add( typeof( SummonFamiliarScroll ), 26 );
				Add( typeof( HorrificBeastScroll ), 27 );
				Add( typeof( MindRotScroll ), 39 );
				Add( typeof( PoisonStrikeScroll ), 39 );
				Add( typeof( WraithFormScroll ), 51 );
				Add( typeof( LichFormScroll ), 64 );
				Add( typeof( StrangleScroll ), 64 );
				Add( typeof( WitherScroll ), 64 );
				Add( typeof( VampiricEmbraceScroll ), 101 );
				Add( typeof( VengefulSpiritScroll ), 114 );
				Add( typeof( PolishBoneBrush ), 6 );
				Add( typeof( PolishedSkull ), 3 );
				Add( typeof( PolishedBone ), 3 );
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullMinotaur ), Utility.Random( 50,150 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullWyrm ), Utility.Random( 200,400 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullGreatDragon ), Utility.Random( 300,600 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullDragon ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullDemon ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullGiant ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){ Add( typeof( MixingCauldron ), 123 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){ Add( typeof( MixingSpoon ), 17 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 30){ Add( typeof( MyNecromancerSpellbook ), Utility.Random( 100,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){ Add( typeof( BlackDyeTub ), 2500 ); } // DO NOT WANT? 
				Add( typeof( CorpseSailor ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( CorpseChest ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( BuriedBody ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( BodyPart ), Utility.RandomMinMax( 30, 90 ) );
				Add( typeof( BoneContainer ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( LeftLeg ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RightLeg ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( TastyHeart ), Utility.RandomMinMax( 10, 20 ) );
				Add( typeof( Head ), Utility.RandomMinMax( 10, 20 ) );
				Add( typeof( LeftArm ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RightArm ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Torso ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Bone ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RibCage ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( BonePile ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Bones ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( GraveChest ), Utility.RandomMinMax( 100, 500 ) );
				Add( typeof( AlchemyTub ), Utility.Random( 200, 500 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBMortician : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBMortician()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( GraveShovel ), 12, Utility.Random( 1,15 ), 0xF39, 0x966 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( SurgeonsKnife ), 14, Utility.Random( 1,15 ), 0xEC4, 0x1B0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MixingCauldron ), 247, 1, 0x269C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MixingSpoon ), 34, Utility.Random( 1,15 ), 0x1E27, 0x979 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Jar ), 5, Utility.Random( 1,15 ), 0x10B4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PolishBoneBrush ), 12, 10, 0x1371, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CBookNecroticAlchemy ), 50, Utility.Random( 1,15 ), 0x2253, 0x4AA ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( HellsGateScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x54F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( ManaLeechScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0xB87 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( NecroCurePoisonScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x8A2 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( NecroPoisonScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x4F8 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( NecroUnlockScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x493 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( PhantasmScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x6DE ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( RetchedAirScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0xA97 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( SpectreShadowScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x17E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( UndeadEyesScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x491 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( VampireGiftScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0xB85 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( WallOfSpikesScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0xB8F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( BloodPactScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x5B5 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GhostlyImagesScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0xBF ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GhostPhaseScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x47E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( GraveyardGatewayScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x2EA ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( HellsBrandScroll ), Utility.Random( 10,100 ), Utility.Random( 1,5 ), 0x1007, 0x54C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( AlchemyTub ), 2400, Utility.Random( 1,5 ), 0x126A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( AlchemyPouch ), Utility.Random( 2900,3500 ), Utility.Random( 1,2 ), 0x1C10, 0x89F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 85){Add( new GenericBuyInfo( typeof( WoodenCoffin ), 100, 1, 0x2800, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 85){Add( new GenericBuyInfo( typeof( WoodenCasket ), 100, 1, 0x27E9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 85){Add( new GenericBuyInfo( typeof( StoneCoffin ), 180, 1, 0x27E0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 85){Add( new GenericBuyInfo( typeof( StoneCasket ), 180, 1, 0x2802, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullMinotaur ), Utility.Random( 50,150 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullWyrm ), Utility.Random( 200,400 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullGreatDragon ), Utility.Random( 300,600 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullDragon ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullDemon ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SkullGiant ), Utility.Random( 100,300 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){ Add( typeof( MixingCauldron ), 123 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){ Add( typeof( MixingSpoon ), 17 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 30){ Add( typeof( MyNecromancerSpellbook ), Utility.Random( 100,500 ) ); } // DO NOT WANT?
				Add( typeof( CorpseSailor ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( CorpseChest ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( BuriedBody ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( BodyPart ), Utility.RandomMinMax( 30, 90 ) );
				Add( typeof( BoneContainer ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( LeftLeg ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RightLeg ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( TastyHeart ), Utility.RandomMinMax( 10, 20 ) );
				Add( typeof( Head ), Utility.RandomMinMax( 10, 20 ) );
				Add( typeof( LeftArm ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RightArm ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Torso ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Bone ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RibCage ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( BonePile ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Bones ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( GraveChest ), Utility.RandomMinMax( 100, 500 ) );
				Add( typeof( AlchemyTub ), Utility.Random( 200, 500 ) );
				Add( typeof( PolishBoneBrush ), 6 );
				Add( typeof( PolishedSkull ), 3 );
				Add( typeof( PolishedBone ), 3 );
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenCoffin ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WoodenCasket ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StoneCoffin ), 45 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StoneCasket ), 45 ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBMage : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBMage()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Toy Maker's Kit", typeof( ToyMakersKit ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Spellbook ), 18, Utility.Random( 1,15 ), 0xEFA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( NecromancerSpellbook ), 115, Utility.Random( 1,15 ), 0x2253, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ScribesPen ), 8, Utility.Random( 1,15 ), 0x2051, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BlankScroll ), 5, Utility.Random( 1,15 ), 0x0E34, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( "1041072", typeof( MagicWizardsHat ), 11, Utility.Random( 1,15 ), 0x1718, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( WitchHat ), 11, Utility.Random( 1,15 ), 0x2FC3, Utility.RandomDyedHue() ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( RecallRune ), 15, Utility.Random( 1,15 ), 0x1F14, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BlackPearl ), 5, Utility.Random( 1,15 ), 0x266F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bloodmoss ), 5, Utility.Random( 1,15 ), 0xF7B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Garlic ), 3, Utility.Random( 1,15 ), 0xF84, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Ginseng ), 3, Utility.Random( 1,15 ), 0xF85, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( MandrakeRoot ), 3, Utility.Random( 1,15 ), 0xF86, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Nightshade ), 3, Utility.Random( 1,15 ), 0xF88, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SpidersSilk ), 3, Utility.Random( 1,15 ), 0xF8D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( SulfurousAsh ), 3, Utility.Random( 1,15 ), 0xF8C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BatWing ), 3, Utility.Random( 1,15 ), 0xF78, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DaemonBlood ), 6, Utility.Random( 1,15 ), 0xF7D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PigIron ), 5, Utility.Random( 1,15 ), 0xF8A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( NoxCrystal ), 6, Utility.Random( 1,15 ), 0xF8E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( GraveDust ), 3, Utility.Random( 1,15 ), 0xF8F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BloodOathScroll ), 25, Utility.Random( 1,15 ), 0x2263, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CorpseSkinScroll ), 28, Utility.Random( 1,15 ), 0x2263, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( CurseWeaponScroll ), 12, Utility.Random( 1,15 ), 0x2263, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( IronFlask ), 500, Utility.Random( 1,15 ), 0x282E, 0 ) ); }

				Type[] types = Loot.RegularScrollTypes;

				int circles = 3;

				for ( int i = 0; i < circles*8 && i < types.Length; ++i )
				{
					int itemID = 0x1F2E + i;

					if ( i == 6 )
						itemID = 0x1F2D;
					else if ( i > 6 )
						--itemID;

					if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( types[i], 12 + ((i / 8) * 10), 20, itemID, 0 ) ); }
				}
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MagicTalisman ), Utility.Random( 50,100 ) ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WizardsHat ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WitchHat ), 5 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BlackPearl ), 3 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Bloodmoss ),4 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MandrakeRoot ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Garlic ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Ginseng ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Nightshade ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpidersSilk ), 2 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( typeof( SulfurousAsh ), 1 ); } // DO NOT WANT? 
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BatWing ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( DaemonBlood ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PigIron ), 2 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( NoxCrystal ), 3 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GraveDust ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RecallRune ), 13 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( Spellbook ), 25 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 20){Add( typeof( MysticalPearl ), 250 ); } // DO NOT WANT?

				Type[] types = Loot.RegularScrollTypes;

				for ( int i = 0; i < types.Length; ++i )
					if (Utility.RandomMinMax( 1, 100 ) > 54){Add(types[i], i + 3 + (i / 4)); } // DO NOT WANT?
			
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( ExorcismScroll ), 1 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AnimateDeadScroll ), 26 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( BloodOathScroll ), 26 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CorpseSkinScroll ), 26 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( CurseWeaponScroll ), 26 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EvilOmenScroll ), 26 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PainSpikeScroll ), 26 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SummonFamiliarScroll ), 26 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( HorrificBeastScroll ), 27 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MindRotScroll ), 39 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( PoisonStrikeScroll ), 39 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WraithFormScroll ), 51 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( LichFormScroll ), 64 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StrangleScroll ), 64 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( WitherScroll ), 64 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( VampiricEmbraceScroll ), 101 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( VengefulSpiritScroll ), 114 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ClumsyMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( CreateFoodMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FeebleMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( HealMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicArrowMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( NightSightMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ReactiveArmorMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( WeaknessMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( AgilityMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( CunningMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( CureMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( HarmMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicTrapMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicUntrapMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ProtectionMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( StrengthMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( BlessMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FireballMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicLockMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicUnlockMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( PoisonMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( TelekinesisMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( TeleportMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( WallofStoneMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ArchCureMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ArchProtectionMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( CurseMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FireFieldMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( GreaterHealMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( LightningMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ManaDrainMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( RecallMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( BladeSpiritsMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( DispelFieldMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( IncognitoMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MagicReflectionMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MindBlastMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ParalyzeMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( PoisonFieldMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( SummonCreatureMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( DispelMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EnergyBoltMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ExplosionMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( InvisibilityMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MarkMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MassCurseMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ParalyzeFieldMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( RevealMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ChainLightningMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EnergyFieldMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FlameStrikeMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( GateTravelMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ManaVampireMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MassDispelMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( MeteorSwarmMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( PolymorphMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( AirElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EarthElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EarthquakeMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( EnergyVortexMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( FireElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( ResurrectionMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( SummonDaemonMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 75){ Add( typeof( WaterElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MyNecromancerSpellbook ), Utility.Random( 100,500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MySpellbook ), Utility.Random( 100,500 ) ); } // DO NOT WANT?
				Add( typeof( TomeOfWands ), Utility.Random( 100,400 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBGodlySewing: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBGodlySewing()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( GodSewing ), 1000, 20, 0x0F9F, 0x501 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBGodlySmithing: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBGodlySmithing()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( GodSmithing ), 1000, 20, 0x0FB5, 0x501 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBGodlyBrewing: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBGodlyBrewing()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( GodBrewing ), 1000, 20, 0x0E28, 0x501 ) );
				Add( new GenericBuyInfo( typeof( reagents_magic_jar1 ), 2000, Utility.Random( 1,15 ), 0x1007, 0 ) );
				Add( new GenericBuyInfo( typeof( reagents_magic_jar2 ), 1500, Utility.Random( 1,15 ), 0x1007, 0xB97 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBMazeStore: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBMazeStore()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Toy Maker's Kit", typeof( ToyMakersKit ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( reagents_magic_jar1 ), 2000, 20, 0x1007, 0 ) );
				Add( new GenericBuyInfo( typeof( reagents_magic_jar2 ), 1500, 20, 0x1007, 0xB97 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBBuyArtifacts: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBBuyArtifacts()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( AbysmalGloves ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( AcidProofRobe ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( Aegis ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( AngelicEmbrace ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( AngeroftheGods ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( Annihilation ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArcaneArms ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArcaneCap ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArcaneGloves ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArcaneGorget ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArcaneLeggings ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArcaneShield ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArcaneTunic ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArcanicRobe ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArcticBeacon ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArcticDeathDealer ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArmorOfFortune ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArmorOfInsight ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArmorOfNobility ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArmsOfAegis ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArmsOfFortune ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArmsOfInsight ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArmsOfNobility ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArmsOfTheFallenKing ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArmsOfTheHarrower ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ArmsOfToxicity ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( AuraOfShadows ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( BalancingDeed ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( BlazeOfDeath ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( BookOfKnowledge ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( BowOfTheJukaKing ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( BraceletOfHealth ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( BraceletOfTheElements ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( BraceletOfTheVile ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( BreathOfTheDead ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( BurglarsBandana ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( Calm ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CandelabraOfSouls ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CapOfFortune ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CapOfTheFallenKing ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CavortingClub ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CircletOfTheSorceress ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CoifOfBane ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CoifOfFire ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ColdBlood ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CrimsonCincture ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CrownOfTalKeesh ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DarkGuardiansChest ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DarkLordsPitchfork ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DarkNeck ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DeathsMask ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DivineArms ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DivineCountenance ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DivineGloves ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DivineGorget ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DivineLeggings ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DivineTunic ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DjinnisRing ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DreadPirateHat ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DupresCollar ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DupresShield ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( EarringBoxSet ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( EarringsOfHealth ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( EarringsOfProtection ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( EarringsOfTheElements ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( EarringsOfTheMagician ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( EarringsOfTheVile ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ElvenQuiver ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( EmbroideredOakLeafCloak ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( EnchantedTitanLegBone ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( EternalFlame ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( EvilMageGloves ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( FalseGodsScepter ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( FangOfRactus ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( FesteringWound ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( Fortifiedarms ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( FortunateBlades ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( Frostbringer ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( FurCapeOfTheSorceress ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( Fury ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GauntletsOfNobility ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GeishasObi ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GladiatorsCollar ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GlassSword ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GlovesOfAegis ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GlovesOfCorruption ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GlovesOfFortune ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GlovesOfInsight ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GlovesOfRegeneration ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GlovesOfTheFallenKing ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GlovesOfTheHarrower ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GlovesOfThePugilist ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GorgetOfAegis ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GorgetOfFortune ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GorgetOfInsight ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GuantletsOfAnger ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GwennosHarp ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HatOfTheMagi ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HeartOfTheLion ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HellForgedArms ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HelmOfAegis ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HelmOfInsight ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HolyKnightsArmPlates ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HolyKnightsBreastplate ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HolyKnightsGloves ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HolyKnightsGorget ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HolyKnightsLegging ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HolyKnightsPlateHelm ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HolySword ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HuntersArms ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HuntersGloves ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HuntersGorget ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HuntersHeaddress ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HuntersLeggings ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HuntersTunic ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( Indecency ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( InquisitorsArms ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( InquisitorsGorget ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( InquisitorsHelm ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( InquisitorsLeggings ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( InquisitorsResolution ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( InquisitorsTunic ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( IolosLute ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( JackalsArms ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( JackalsCollar ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( JackalsGloves ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( JackalsHelm ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( JackalsLeggings ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( JackalsTunic ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( JadeScimitar ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( JesterHatofChuckles ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( JinBaoriOfGoodFortune ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( KamiNarisIndestructableDoubleAxe ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LegacyOfTheDreadLord ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LeggingsOfAegis ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LeggingsOfBane ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LeggingsOfDeceit ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LeggingsOfEnlightenment ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LeggingsOfFire ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LegsOfFortune ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LegsOfInsight ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LegsOfNobility ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LegsOfTheFallenKing ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LegsOfTheHarrower ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LieutenantOfTheBritannianRoyalGuard ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LongShot ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LuckyEarrings ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LuckyNecklace ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LunaLance ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MadmansHatchet ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MagesBand ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MagiciansIllusion ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MagiciansMempo ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MarbleShield ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MauloftheBeast ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( WizardsPants ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MidnightBracers ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MidnightGloves ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MidnightHelm ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MidnightLegs ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MidnightTunic ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MinersPickaxe ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( NightsKiss ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( NordicVikingSword ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( NoxBow ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( NoxNightlight ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( NoxRangersHeavyCrossbow ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( OblivionsNeedle ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( OrcChieftainHelm ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( OrcishVisage ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( OrnamentOfTheMagician ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( OrnateCrownOfTheHarrower ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( Pestilence ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( PixieSwatter ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( PolarBearMask ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( PowerSurge ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( Quell ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( QuiverOfBlight ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( QuiverOfElements ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( QuiverOfFire ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( QuiverOfIce ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( QuiverOfInfinity ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( QuiverOfLightning ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( QuiverOfRage ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RamusNecromanticScalpel ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( Retort ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RighteousAnger ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RingOfHealth ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RingOfTheElements ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RingOfTheMagician ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RingOfTheVile ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RobeOfTheEclipse ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RobeOfTheEquinox ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RobeOfTreason ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RoyalArchersBow ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RoyalGuardsChestplate ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RoyalGuardsGorget ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RoyalGuardSurvivalKnife ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( SamaritanRobe ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( SamuraiHelm ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( SerpentsFang ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ShadowBlade ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ShadowDancerArms ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ShadowDancerCap ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ShadowDancerGloves ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ShadowDancerGorget ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ShadowDancerLeggings ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ShadowDancerTunic ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ShaminoCrossbow ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ShieldOfInvulnerability ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ShimmeringTalisman ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ShroudOfDeciet ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( SoulSeeker ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( SpiritOfTheTotem ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( SprintersSandals ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( StaffOfPower ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( StaffOfTheMagi ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( Subdue ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( SwiftStrike ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TalonBite ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TheBeserkersMaul ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TheDryadBow ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TheDragonSlayer ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TheRobeOfBritanniaAri ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TheTaskmaster ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TitansHammer ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TotemArms ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TotemGloves ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TotemGorget ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TotemLeggings ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TotemOfVoid ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TotemTunic ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TownGuardsHalberd ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TunicOfAegis ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TunicOfBane ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TunicOfFire ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TunicOfTheFallenKing ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TunicOfTheHarrower ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( VampiricDaisho ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( VelocityTargetx ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( VioletCourage ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( VoiceOfTheFallenKing ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( WarriorsClasp ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( WeaponRenamingTool ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( WildfireBow ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( Windsong ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( WrathOfTheDryad ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( YashimotosHatsuburi ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ZyronicClaw ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( EverlastingLoaf ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( EverlastingBottle ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( PolarBearCape ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( PolarBearBoots ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( Excalibur ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( KodiakBearMask ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( Stormbringer ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( AchillesShield ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( AchillesSpear ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( StaffofSnakes ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( AilricsLongbow ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( LargeBagofHolding ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MediumBagofHolding ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( SmallBagofHolding ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( BagOfHolding ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( BootsofHermes ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( BeltofHercules ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RobinHoodsFeatheredHat ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RobinHoodsBow ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( AxeoftheMinotaur ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( BowofthePhoenix ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GandalfsRobe ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GandalfsHat ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GandalfsStaff ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HammerofThor ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ConansSword ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ConansHelm ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( SinbadsSword ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GiantBlackjack ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CandleCold ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CandleFire ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CandlePoison ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CandleEnergy ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CandleWizard ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( CandleNecromancer ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( TorchOfTrapFinding ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RodOfResurrection ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( RobeOfTeleportation ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( MaulOfTheTitans ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( HelmOfBrilliance ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GlovesOfDexterity ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( GemOfSeeing ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( DaggerOfVenom ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 30){Add( typeof( ColoringBook ), Utility.Random( 250,2500 ) ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBGemArmor: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBGemArmor()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( AmethystFemalePlateChest ), 5513, 1, 0x1C04, Server.Misc.MaterialInfo.GetMaterialColor( "amethyst", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( AmethystPlateArms ), 5494, 1, 0x1410, Server.Misc.MaterialInfo.GetMaterialColor( "amethyst", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( AmethystPlateChest ), 5521, 1, 0x1415, Server.Misc.MaterialInfo.GetMaterialColor( "amethyst", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( AmethystPlateGloves ), 5372, 1, 0x1414, Server.Misc.MaterialInfo.GetMaterialColor( "amethyst", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( AmethystPlateGorget ), 5352, 1, 0x1413, Server.Misc.MaterialInfo.GetMaterialColor( "amethyst", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( AmethystPlateHelm ), 5320, 1, 0x1419, Server.Misc.MaterialInfo.GetMaterialColor( "amethyst", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( AmethystPlateLegs ), 5509, 1, 0x1411, Server.Misc.MaterialInfo.GetMaterialColor( "amethyst", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( AmethystShield ), 5415, 1, 0x1B76, Server.Misc.MaterialInfo.GetMaterialColor( "amethyst", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( EmeraldFemalePlateChest ), 5513, 1, 0x1C04, Server.Misc.MaterialInfo.GetMaterialColor( "emerald", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( EmeraldPlateArms ), 5494, 1, 0x1410, Server.Misc.MaterialInfo.GetMaterialColor( "emerald", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( EmeraldPlateChest ), 5521, 1, 0x1415, Server.Misc.MaterialInfo.GetMaterialColor( "emerald", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( EmeraldPlateGloves ), 5372, 1, 0x1414, Server.Misc.MaterialInfo.GetMaterialColor( "emerald", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( EmeraldPlateGorget ), 5352, 1, 0x1413, Server.Misc.MaterialInfo.GetMaterialColor( "emerald", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( EmeraldPlateHelm ), 5320, 1, 0x1419, Server.Misc.MaterialInfo.GetMaterialColor( "emerald", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( EmeraldPlateLegs ), 5509, 1, 0x1411, Server.Misc.MaterialInfo.GetMaterialColor( "emerald", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( EmeraldShield ), 5415, 1, 0x1B76, Server.Misc.MaterialInfo.GetMaterialColor( "emerald", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( GarnetFemalePlateChest ), 5513, 1, 0x1C04, Server.Misc.MaterialInfo.GetMaterialColor( "garnet", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( GarnetPlateArms ), 5494, 1, 0x1410, Server.Misc.MaterialInfo.GetMaterialColor( "garnet", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( GarnetPlateChest ), 5521, 1, 0x1415, Server.Misc.MaterialInfo.GetMaterialColor( "garnet", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( GarnetPlateGloves ), 5372, 1, 0x1414, Server.Misc.MaterialInfo.GetMaterialColor( "garnet", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( GarnetPlateGorget ), 5352, 1, 0x1413, Server.Misc.MaterialInfo.GetMaterialColor( "garnet", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( GarnetPlateHelm ), 5320, 1, 0x1419, Server.Misc.MaterialInfo.GetMaterialColor( "garnet", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( GarnetPlateLegs ), 5509, 1, 0x1411, Server.Misc.MaterialInfo.GetMaterialColor( "garnet", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( GarnetShield ), 5415, 1, 0x1B76, Server.Misc.MaterialInfo.GetMaterialColor( "garnet", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( IceFemalePlateChest ), 5513, 1, 0x1C04, Server.Misc.MaterialInfo.GetMaterialColor( "ice", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( IcePlateArms ), 5494, 1, 0x1410, Server.Misc.MaterialInfo.GetMaterialColor( "ice", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( IcePlateChest ), 5521, 1, 0x1415, Server.Misc.MaterialInfo.GetMaterialColor( "ice", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( IcePlateGloves ), 5372, 1, 0x1414, Server.Misc.MaterialInfo.GetMaterialColor( "ice", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( IcePlateGorget ), 5352, 1, 0x1413, Server.Misc.MaterialInfo.GetMaterialColor( "ice", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( IcePlateHelm ), 5320, 1, 0x1419, Server.Misc.MaterialInfo.GetMaterialColor( "ice", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( IcePlateLegs ), 5509, 1, 0x1411, Server.Misc.MaterialInfo.GetMaterialColor( "ice", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( IceShield ), 5415, 1, 0x1B76, Server.Misc.MaterialInfo.GetMaterialColor( "ice", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( JadeFemalePlateChest ), 5513, 1, 0x1C04, Server.Misc.MaterialInfo.GetMaterialColor( "jade", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( JadePlateArms ), 5494, 1, 0x1410, Server.Misc.MaterialInfo.GetMaterialColor( "jade", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( JadePlateChest ), 5521, 1, 0x1415, Server.Misc.MaterialInfo.GetMaterialColor( "jade", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( JadePlateGloves ), 5372, 1, 0x1414, Server.Misc.MaterialInfo.GetMaterialColor( "jade", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( JadePlateGorget ), 5352, 1, 0x1413, Server.Misc.MaterialInfo.GetMaterialColor( "jade", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( JadePlateHelm ), 5320, 1, 0x1419, Server.Misc.MaterialInfo.GetMaterialColor( "jade", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( JadePlateLegs ), 5509, 1, 0x1411, Server.Misc.MaterialInfo.GetMaterialColor( "jade", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( JadeShield ), 5415, 1, 0x1B76, Server.Misc.MaterialInfo.GetMaterialColor( "jade", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( MarbleFemalePlateChest ), 5513, 1, 0x1C04, Server.Misc.MaterialInfo.GetMaterialColor( "marble", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( MarblePlateArms ), 5494, 1, 0x1410, Server.Misc.MaterialInfo.GetMaterialColor( "marble", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( MarblePlateChest ), 5521, 1, 0x1415, Server.Misc.MaterialInfo.GetMaterialColor( "marble", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( MarblePlateGloves ), 5372, 1, 0x1414, Server.Misc.MaterialInfo.GetMaterialColor( "marble", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( MarblePlateGorget ), 5352, 1, 0x1413, Server.Misc.MaterialInfo.GetMaterialColor( "marble", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( MarblePlateHelm ), 5320, 1, 0x1419, Server.Misc.MaterialInfo.GetMaterialColor( "marble", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( MarblePlateLegs ), 5509, 1, 0x1411, Server.Misc.MaterialInfo.GetMaterialColor( "marble", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( MarbleShields ), 5415, 1, 0x1B76, Server.Misc.MaterialInfo.GetMaterialColor( "marble", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( OnyxFemalePlateChest ), 5513, 1, 0x1C04, Server.Misc.MaterialInfo.GetMaterialColor( "onyx", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( OnyxPlateArms ), 5494, 1, 0x1410, Server.Misc.MaterialInfo.GetMaterialColor( "onyx", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( OnyxPlateChest ), 5521, 1, 0x1415, Server.Misc.MaterialInfo.GetMaterialColor( "onyx", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( OnyxPlateGloves ), 5372, 1, 0x1414, Server.Misc.MaterialInfo.GetMaterialColor( "onyx", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( OnyxPlateGorget ), 5352, 1, 0x1413, Server.Misc.MaterialInfo.GetMaterialColor( "onyx", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( OnyxPlateHelm ), 5320, 1, 0x1419, Server.Misc.MaterialInfo.GetMaterialColor( "onyx", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( OnyxPlateLegs ), 5509, 1, 0x1411, Server.Misc.MaterialInfo.GetMaterialColor( "onyx", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( OnyxShield ), 5415, 1, 0x1B76, Server.Misc.MaterialInfo.GetMaterialColor( "onyx", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( QuartzFemalePlateChest ), 5513, 1, 0x1C04, Server.Misc.MaterialInfo.GetMaterialColor( "quartz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( QuartzPlateArms ), 5494, 1, 0x1410, Server.Misc.MaterialInfo.GetMaterialColor( "quartz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( QuartzPlateChest ), 5521, 1, 0x1415, Server.Misc.MaterialInfo.GetMaterialColor( "quartz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( QuartzPlateGloves ), 5372, 1, 0x1414, Server.Misc.MaterialInfo.GetMaterialColor( "quartz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( QuartzPlateGorget ), 5352, 1, 0x1413, Server.Misc.MaterialInfo.GetMaterialColor( "quartz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( QuartzPlateHelm ), 5320, 1, 0x1419, Server.Misc.MaterialInfo.GetMaterialColor( "quartz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( QuartzPlateLegs ), 5509, 1, 0x1411, Server.Misc.MaterialInfo.GetMaterialColor( "quartz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( QuartzShield ), 5415, 1, 0x1B76, Server.Misc.MaterialInfo.GetMaterialColor( "quartz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( RubyFemalePlateChest ), 5513, 1, 0x1C04, Server.Misc.MaterialInfo.GetMaterialColor( "ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( RubyPlateArms ), 5494, 1, 0x1410, Server.Misc.MaterialInfo.GetMaterialColor( "ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( RubyPlateChest ), 5521, 1, 0x1415, Server.Misc.MaterialInfo.GetMaterialColor( "ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( RubyPlateGloves ), 5372, 1, 0x1414, Server.Misc.MaterialInfo.GetMaterialColor( "ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( RubyPlateGorget ), 5352, 1, 0x1413, Server.Misc.MaterialInfo.GetMaterialColor( "ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( RubyPlateHelm ), 5320, 1, 0x1419, Server.Misc.MaterialInfo.GetMaterialColor( "ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( RubyPlateLegs ), 5509, 1, 0x1411, Server.Misc.MaterialInfo.GetMaterialColor( "ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( RubyShield ), 5415, 1, 0x1B76, Server.Misc.MaterialInfo.GetMaterialColor( "ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SapphireFemalePlateChest ), 5513, 1, 0x1C04, Server.Misc.MaterialInfo.GetMaterialColor( "sapphire", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SapphirePlateArms ), 5494, 1, 0x1410, Server.Misc.MaterialInfo.GetMaterialColor( "sapphire", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SapphirePlateChest ), 5521, 1, 0x1415, Server.Misc.MaterialInfo.GetMaterialColor( "sapphire", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SapphirePlateGloves ), 5372, 1, 0x1414, Server.Misc.MaterialInfo.GetMaterialColor( "sapphire", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SapphirePlateGorget ), 5352, 1, 0x1413, Server.Misc.MaterialInfo.GetMaterialColor( "sapphire", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SapphirePlateHelm ), 5320, 1, 0x1419, Server.Misc.MaterialInfo.GetMaterialColor( "sapphire", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SapphirePlateLegs ), 5509, 1, 0x1411, Server.Misc.MaterialInfo.GetMaterialColor( "sapphire", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SapphireShield ), 5415, 1, 0x1B76, Server.Misc.MaterialInfo.GetMaterialColor( "sapphire", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SilverFemalePlateChest ), 5513, 1, 0x1C04, Server.Misc.MaterialInfo.GetMaterialColor( "silver", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SilverPlateArms ), 5494, 1, 0x1410, Server.Misc.MaterialInfo.GetMaterialColor( "silver", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SilverPlateChest ), 5521, 1, 0x1415, Server.Misc.MaterialInfo.GetMaterialColor( "silver", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SilverPlateGloves ), 5372, 1, 0x1414, Server.Misc.MaterialInfo.GetMaterialColor( "silver", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SilverPlateGorget ), 5352, 1, 0x1413, Server.Misc.MaterialInfo.GetMaterialColor( "silver", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SilverPlateHelm ), 5320, 1, 0x1419, Server.Misc.MaterialInfo.GetMaterialColor( "silver", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SilverPlateLegs ), 5509, 1, 0x1411, Server.Misc.MaterialInfo.GetMaterialColor( "silver", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SilverShield ), 5415, 1, 0x1B76, Server.Misc.MaterialInfo.GetMaterialColor( "silver", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SpinelFemalePlateChest ), 5513, 1, 0x1C04, Server.Misc.MaterialInfo.GetMaterialColor( "spinel", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SpinelPlateArms ), 5494, 1, 0x1410, Server.Misc.MaterialInfo.GetMaterialColor( "spinel", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SpinelPlateChest ), 5521, 1, 0x1415, Server.Misc.MaterialInfo.GetMaterialColor( "spinel", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SpinelPlateGloves ), 5372, 1, 0x1414, Server.Misc.MaterialInfo.GetMaterialColor( "spinel", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SpinelPlateGorget ), 5352, 1, 0x1413, Server.Misc.MaterialInfo.GetMaterialColor( "spinel", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SpinelPlateHelm ), 5320, 1, 0x1419, Server.Misc.MaterialInfo.GetMaterialColor( "spinel", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SpinelPlateLegs ), 5509, 1, 0x1411, Server.Misc.MaterialInfo.GetMaterialColor( "spinel", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( SpinelShield ), 5415, 1, 0x1B76, Server.Misc.MaterialInfo.GetMaterialColor( "spinel", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( StarRubyFemalePlateChest ), 5513, 1, 0x1C04, Server.Misc.MaterialInfo.GetMaterialColor( "star ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( StarRubyPlateArms ), 5494, 1, 0x1410, Server.Misc.MaterialInfo.GetMaterialColor( "star ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( StarRubyPlateChest ), 5521, 1, 0x1415, Server.Misc.MaterialInfo.GetMaterialColor( "star ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( StarRubyPlateGloves ), 5372, 1, 0x1414, Server.Misc.MaterialInfo.GetMaterialColor( "star ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( StarRubyPlateGorget ), 5352, 1, 0x1413, Server.Misc.MaterialInfo.GetMaterialColor( "star ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( StarRubyPlateHelm ), 5320, 1, 0x1419, Server.Misc.MaterialInfo.GetMaterialColor( "star ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( StarRubyPlateLegs ), 5509, 1, 0x1411, Server.Misc.MaterialInfo.GetMaterialColor( "star ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( StarRubyShield ), 5415, 1, 0x1B76, Server.Misc.MaterialInfo.GetMaterialColor( "star ruby", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( TopazFemalePlateChest ), 5513, 1, 0x1C04, Server.Misc.MaterialInfo.GetMaterialColor( "topaz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( TopazPlateArms ), 5494, 1, 0x1410, Server.Misc.MaterialInfo.GetMaterialColor( "topaz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( TopazPlateChest ), 5521, 1, 0x1415, Server.Misc.MaterialInfo.GetMaterialColor( "topaz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( TopazPlateGloves ), 5372, 1, 0x1414, Server.Misc.MaterialInfo.GetMaterialColor( "topaz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( TopazPlateGorget ), 5352, 1, 0x1413, Server.Misc.MaterialInfo.GetMaterialColor( "topaz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( TopazPlateHelm ), 5320, 1, 0x1419, Server.Misc.MaterialInfo.GetMaterialColor( "topaz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( TopazPlateLegs ), 5509, 1, 0x1411, Server.Misc.MaterialInfo.GetMaterialColor( "topaz", "", 0 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 95){Add( new GenericBuyInfo( typeof( TopazShield ), 5415, 1, 0x1B76, Server.Misc.MaterialInfo.GetMaterialColor( "topaz", "", 0 ) ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmethystFemalePlateChest ), 565 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmethystPlateArms ), 470 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmethystPlateChest ), 605 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmethystPlateGloves ), 360 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmethystPlateGorget ), 260 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmethystPlateHelm ), 330 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmethystPlateLegs ), 545 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( AmethystShield ), 575 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmeraldFemalePlateChest ), 565 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmeraldPlateArms ), 470 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmeraldPlateChest ), 605 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmeraldPlateGloves ), 360 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmeraldPlateGorget ), 260 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmeraldPlateHelm ), 330 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmeraldPlateLegs ), 545 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( EmeraldShield ), 575 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GarnetFemalePlateChest ), 565 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GarnetPlateArms ), 470 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GarnetPlateChest ), 605 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GarnetPlateGloves ), 360 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GarnetPlateGorget ), 260 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GarnetPlateHelm ), 330 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GarnetPlateLegs ), 545 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( GarnetShield ), 575 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IceFemalePlateChest ), 565 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IcePlateArms ), 470 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IcePlateChest ), 605 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IcePlateGloves ), 360 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IcePlateGorget ), 260 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IcePlateHelm ), 330 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IcePlateLegs ), 545 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( IceShield ), 575 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JadeFemalePlateChest ), 565 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JadePlateArms ), 470 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JadePlateChest ), 605 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JadePlateGloves ), 360 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JadePlateGorget ), 260 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JadePlateHelm ), 330 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JadePlateLegs ), 545 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( JadeShield ), 575 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MarbleFemalePlateChest ), 565 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MarblePlateArms ), 470 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MarblePlateChest ), 605 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MarblePlateGloves ), 360 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MarblePlateGorget ), 260 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MarblePlateHelm ), 330 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MarblePlateLegs ), 545 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MarbleShields ), 575 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OnyxFemalePlateChest ), 565 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OnyxPlateArms ), 470 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OnyxPlateChest ), 605 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OnyxPlateGloves ), 360 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OnyxPlateGorget ), 260 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OnyxPlateHelm ), 330 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OnyxPlateLegs ), 545 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( OnyxShield ), 575 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuartzPlateArms ), 470 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuartzPlateGloves  ), 360 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuartzPlateGorget ), 260 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuartzPlateLegs ), 545 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuartzPlateChest ), 605 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuartzFemalePlateChest ), 565 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuartzPlateHelm ), 330 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( QuartzShield ), 575 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RubyPlateArms ), 470 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RubyPlateGloves ), 360 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RubyPlateGorget ), 260 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RubyPlateLegs ), 545 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RubyPlateChest ), 605 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RubyFemalePlateChest ), 565 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RubyPlateHelm ), 330 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RubyShield ), 575 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SapphirePlateArms ), 470 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SapphirePlateGloves ), 360 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SapphirePlateGorget ), 260 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SapphirePlateLegs ), 545 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SapphirePlateChest ), 605 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SapphireFemalePlateChest ), 565 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SapphirePlateHelm ), 330 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SapphireShield ), 575 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverPlateArms ), 470 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverPlateGloves ), 360 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverPlateGorget ), 260 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverPlateLegs ), 545 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverPlateChest ), 605 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverFemalePlateChest ), 565 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverPlateHelm ), 330 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SilverShield ), 575 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinelPlateArms ), 470 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinelPlateGloves ), 360 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinelPlateGorget ), 260 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinelPlateLegs ), 545 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinelPlateChest ), 605 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinelFemalePlateChest ), 565 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinelPlateHelm ), 330 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( SpinelShield ), 575 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarRubyPlateArms ), 470 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarRubyPlateGloves ), 360 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarRubyPlateGorget ), 260 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarRubyPlateLegs ), 545 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarRubyPlateChest ), 605 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarRubyFemalePlateChest ), 565 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarRubyPlateHelm ), 330 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( StarRubyShield ), 575 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TopazPlateArms ), 470 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TopazPlateGloves ), 360 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TopazPlateGorget ), 260 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TopazPlateLegs ), 545 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TopazPlateChest ), 605 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TopazFemalePlateChest ), 565 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TopazPlateHelm ), 330 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( TopazShield ), 575 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RareAnvil ), Utility.Random( 200,1000 ) ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBRoscoe: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBRoscoe()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 0){Add( new GenericBuyInfo( typeof( LesserManaPotion ), 20, Utility.Random( 1,15 ), 0x23BD, 0x48D ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 33){Add( new GenericBuyInfo( typeof( ManaPotion ), 40, Utility.Random( 1,15 ), 0x180F, 0x48D ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 66){Add( new GenericBuyInfo( typeof( GreaterManaPotion ), 80, Utility.Random( 1,15 ), 0x2406, 0x48D ) ); }

				if (Utility.RandomMinMax( 1, 100 ) > 72){Add( new GenericBuyInfo( typeof( ClumsyMagicStaff ), 500, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 72){Add( new GenericBuyInfo( typeof( CreateFoodMagicStaff ), 500, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 72){Add( new GenericBuyInfo( typeof( FeebleMagicStaff ), 500, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 72){Add( new GenericBuyInfo( typeof( HealMagicStaff ), 500, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 72){Add( new GenericBuyInfo( typeof( MagicArrowMagicStaff ), 500, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 72){Add( new GenericBuyInfo( typeof( NightSightMagicStaff ), 500, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 72){Add( new GenericBuyInfo( typeof( ReactiveArmorMagicStaff ), 500, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 72){Add( new GenericBuyInfo( typeof( WeaknessMagicStaff ), 500, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 76){Add( new GenericBuyInfo( typeof( AgilityMagicStaff ), 1000, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 76){Add( new GenericBuyInfo( typeof( CunningMagicStaff ), 1000, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 76){Add( new GenericBuyInfo( typeof( CureMagicStaff ), 1000, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 76){Add( new GenericBuyInfo( typeof( HarmMagicStaff ), 1000, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 76){Add( new GenericBuyInfo( typeof( MagicTrapMagicStaff ), 1000, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 76){Add( new GenericBuyInfo( typeof( MagicUntrapMagicStaff ), 1000, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 76){Add( new GenericBuyInfo( typeof( ProtectionMagicStaff ), 1000, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 76){Add( new GenericBuyInfo( typeof( StrengthMagicStaff ), 1000, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( BlessMagicStaff ), 2000, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( FireballMagicStaff ), 2000, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( MagicLockMagicStaff ), 2000, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( MagicUnlockMagicStaff ), 2000, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( PoisonMagicStaff ), 2000, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( TelekinesisMagicStaff ), 2000, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( TeleportMagicStaff ), 2000, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 80){Add( new GenericBuyInfo( typeof( WallofStoneMagicStaff ), 2000, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 84){Add( new GenericBuyInfo( typeof( ArchCureMagicStaff ), 4000, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 84){Add( new GenericBuyInfo( typeof( ArchProtectionMagicStaff ), 4000, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 84){Add( new GenericBuyInfo( typeof( CurseMagicStaff ), 4000, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 84){Add( new GenericBuyInfo( typeof( FireFieldMagicStaff ), 4000, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 84){Add( new GenericBuyInfo( typeof( GreaterHealMagicStaff ), 4000, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 84){Add( new GenericBuyInfo( typeof( LightningMagicStaff ), 4000, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 84){Add( new GenericBuyInfo( typeof( ManaDrainMagicStaff ), 4000, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 84){Add( new GenericBuyInfo( typeof( RecallMagicStaff ), 4000, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 88){Add( new GenericBuyInfo( typeof( BladeSpiritsMagicStaff ), 8000, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 88){Add( new GenericBuyInfo( typeof( DispelFieldMagicStaff ), 8000, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 88){Add( new GenericBuyInfo( typeof( IncognitoMagicStaff ), 8000, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 88){Add( new GenericBuyInfo( typeof( MagicReflectionMagicStaff ), 8000, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 88){Add( new GenericBuyInfo( typeof( MindBlastMagicStaff ), 8000, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 88){Add( new GenericBuyInfo( typeof( ParalyzeMagicStaff ), 8000, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 88){Add( new GenericBuyInfo( typeof( PoisonFieldMagicStaff ), 8000, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 88){Add( new GenericBuyInfo( typeof( SummonCreatureMagicStaff ), 8000, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 92){Add( new GenericBuyInfo( typeof( DispelMagicStaff ), 16000, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 92){Add( new GenericBuyInfo( typeof( EnergyBoltMagicStaff ), 16000, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 92){Add( new GenericBuyInfo( typeof( ExplosionMagicStaff ), 16000, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 92){Add( new GenericBuyInfo( typeof( InvisibilityMagicStaff ), 16000, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 92){Add( new GenericBuyInfo( typeof( MarkMagicStaff ), 16000, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 92){Add( new GenericBuyInfo( typeof( MassCurseMagicStaff ), 16000, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 92){Add( new GenericBuyInfo( typeof( ParalyzeFieldMagicStaff ), 16000, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 92){Add( new GenericBuyInfo( typeof( RevealMagicStaff ), 16000, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 96){Add( new GenericBuyInfo( typeof( ChainLightningMagicStaff ), 24000, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 96){Add( new GenericBuyInfo( typeof( EnergyFieldMagicStaff ), 24000, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 96){Add( new GenericBuyInfo( typeof( FlameStrikeMagicStaff ), 24000, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 96){Add( new GenericBuyInfo( typeof( GateTravelMagicStaff ), 24000, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 96){Add( new GenericBuyInfo( typeof( ManaVampireMagicStaff ), 24000, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 96){Add( new GenericBuyInfo( typeof( MassDispelMagicStaff ), 24000, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 96){Add( new GenericBuyInfo( typeof( MeteorSwarmMagicStaff ), 24000, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 96){Add( new GenericBuyInfo( typeof( PolymorphMagicStaff ), 24000, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 99){Add( new GenericBuyInfo( typeof( AirElementalMagicStaff ), 32000, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 99){Add( new GenericBuyInfo( typeof( EarthElementalMagicStaff ), 32000, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 99){Add( new GenericBuyInfo( typeof( EarthquakeMagicStaff ), 32000, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 99){Add( new GenericBuyInfo( typeof( EnergyVortexMagicStaff ), 32000, 1, 0xDF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 99){Add( new GenericBuyInfo( typeof( FireElementalMagicStaff ), 32000, 1, 0xDF2, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 99){Add( new GenericBuyInfo( typeof( ResurrectionMagicStaff ), 32000, 1, 0xDF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 99){Add( new GenericBuyInfo( typeof( SummonDaemonMagicStaff ), 32000, 1, 0xDF4, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 99){Add( new GenericBuyInfo( typeof( WaterElementalMagicStaff ), 32000, 1, 0xDF5, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( LesserManaPotion ), 10 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( ManaPotion ), 20 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( GreaterManaPotion ), 40 ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( ClumsyMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( CreateFoodMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( FeebleMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( HealMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( MagicArrowMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( NightSightMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( ReactiveArmorMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( WeaknessMagicStaff ), Utility.Random( 10,20 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( AgilityMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( CunningMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( CureMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( HarmMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( MagicTrapMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( MagicUntrapMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( ProtectionMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( StrengthMagicStaff ), Utility.Random( 20,40 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( BlessMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( FireballMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( MagicLockMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( MagicUnlockMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( PoisonMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( TelekinesisMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( TeleportMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( WallofStoneMagicStaff ), Utility.Random( 30,60 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( ArchCureMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( ArchProtectionMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( CurseMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( FireFieldMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( GreaterHealMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( LightningMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( ManaDrainMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( RecallMagicStaff ), Utility.Random( 40,80 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( BladeSpiritsMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( DispelFieldMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( IncognitoMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( MagicReflectionMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( MindBlastMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( ParalyzeMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( PoisonFieldMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( SummonCreatureMagicStaff ), Utility.Random( 50,100 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( DispelMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( EnergyBoltMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( ExplosionMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( InvisibilityMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( MarkMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( MassCurseMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( ParalyzeFieldMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( RevealMagicStaff ), Utility.Random( 60,120 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( ChainLightningMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( EnergyFieldMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( FlameStrikeMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( GateTravelMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( ManaVampireMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( MassDispelMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( MeteorSwarmMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( PolymorphMagicStaff ), Utility.Random( 70,140 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( AirElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( EarthElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( EarthquakeMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( EnergyVortexMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( FireElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( ResurrectionMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( SummonDaemonMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
				if (Utility.RandomMinMax( 1, 100 ) > 25){ Add( typeof( WaterElementalMagicStaff ), Utility.Random( 80,160 ) ); } // DO NOT WANT?
			}
		}
	}

/////----------------------------------------------------------------------------------------------------------------------------------------------------/////

	public class SBTinkerGuild: SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBTinkerGuild() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{
				Add( new GenericBuyInfo( "Toy Maker's Kit", typeof( ToyMakersKit ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( GuildTinkering ), 500, Utility.Random( 1,5 ), 0x1EBB, 0x430 ) );
				Add( new GenericBuyInfo( typeof( Clock ), 22, Utility.Random( 3,31 ), 0x104B, 0 ) );
				Add( new GenericBuyInfo( typeof( Nails ), 3, Utility.Random( 3,31 ), 0x102E, 0 ) );
				Add( new GenericBuyInfo( typeof( ClockParts ), 3, Utility.Random( 3,31 ), 0x104F, 0 ) );
				Add( new GenericBuyInfo( typeof( AxleGears ), 3, Utility.Random( 3,31 ), 0x1051, 0 ) );
				Add( new GenericBuyInfo( typeof( Gears ), 2, Utility.Random( 3,31 ), 0x1053, 0 ) );
				Add( new GenericBuyInfo( typeof( Hinge ), 2, Utility.Random( 3,31 ), 0x1055, 0 ) );
				Add( new GenericBuyInfo( typeof( Sextant ), 13, Utility.Random( 3,31 ), 0x1057, 0 ) );
				Add( new GenericBuyInfo( typeof( SextantParts ), 5, Utility.Random( 3,31 ), 0x1059, 0 ) );
				Add( new GenericBuyInfo( typeof( Axle ), 2, Utility.Random( 3,31 ), 0x105B, 0 ) );
				Add( new GenericBuyInfo( typeof( Springs ), 3, Utility.Random( 3,31 ), 0x105D, 0 ) );
				Add( new GenericBuyInfo( "1024111", typeof( Key ), 8, Utility.Random( 3,31 ), 0x100F, 0 ) );
				Add( new GenericBuyInfo( "1024112", typeof( Key ), 8, Utility.Random( 3,31 ), 0x1010, 0 ) );
				Add( new GenericBuyInfo( "1024115", typeof( Key ), 8, Utility.Random( 3,31 ), 0x1013, 0 ) );
				Add( new GenericBuyInfo( typeof( KeyRing ), 8, Utility.Random( 3,31 ), 0x1010, 0 ) );
				Add( new GenericBuyInfo( typeof( Lockpick ), 12, Utility.Random( 300,400 ), 0x14FC, 0 ) );
				Add( new GenericBuyInfo( typeof( SkeletonsKey ), Utility.Random( 3,31 ), 1, 0x410A, 0 ) );
				Add( new GenericBuyInfo( typeof( TinkersTools ), 7, Utility.Random( 3,31 ), 0x1EBC, 0 ) );
				Add( new GenericBuyInfo( typeof( Board ), 3, Utility.Random( 3,31 ), 0x1BD7, 0 ) );
				Add( new GenericBuyInfo( typeof( IronIngot ), 5, Utility.Random( 3,31 ), 0x1BF2, 0 ) );
				Add( new GenericBuyInfo( typeof( SewingKit ), 3, Utility.Random( 3,31 ), 0xF9D, 0 ) );
				Add( new GenericBuyInfo( typeof( DrawKnife ), 10, Utility.Random( 3,31 ), 0x10E4, 0 ) );
				Add( new GenericBuyInfo( typeof( Froe ), 10, Utility.Random( 3,31 ), 0x10E5, 0 ) );
				Add( new GenericBuyInfo( typeof( Scorp ), 10, Utility.Random( 3,31 ), 0x10E7, 0 ) );
				Add( new GenericBuyInfo( typeof( Inshave ), 10, Utility.Random( 3,31 ), 0x10E6, 0 ) );
				Add( new GenericBuyInfo( typeof( ButcherKnife ), 13, Utility.Random( 3,31 ), 0x13F6, 0 ) );
				Add( new GenericBuyInfo( typeof( Scissors ), 11, Utility.Random( 3,31 ), 0xF9F, 0 ) );
				Add( new GenericBuyInfo( typeof( Tongs ), 13, Utility.Random( 3,31 ), 0xFBB, 0 ) );
				Add( new GenericBuyInfo( typeof( DovetailSaw ), 12, Utility.Random( 3,31 ), 0x1028, 0 ) );
				Add( new GenericBuyInfo( typeof( Saw ), 15, Utility.Random( 3,31 ), 0x1034, 0 ) );
				Add( new GenericBuyInfo( typeof( Hammer ), 17, Utility.Random( 3,31 ), 0x102A, 0 ) );
				Add( new GenericBuyInfo( typeof( SmithHammer ), 23, Utility.Random( 3,31 ), 0x0FB4, 0 ) );
				Add( new GenericBuyInfo( typeof( Shovel ), 12, Utility.Random( 3,31 ), 0xF39, 0 ) );
				Add( new GenericBuyInfo( typeof( OreShovel ), 10, Utility.Random( 3,31 ), 0xF39, 0x96D ) );
				Add( new GenericBuyInfo( typeof( MouldingPlane ), 11, Utility.Random( 3,31 ), 0x102C, 0 ) );
				Add( new GenericBuyInfo( typeof( JointingPlane ), 10, Utility.Random( 3,31 ), 0x1030, 0 ) );
				Add( new GenericBuyInfo( typeof( SmoothingPlane ), 11, Utility.Random( 3,31 ), 0x1032, 0 ) );
				Add( new GenericBuyInfo( typeof( Pickaxe ), 25, Utility.Random( 3,31 ), 0xE86, 0 ) );
				Add( new GenericBuyInfo( typeof( ThrowingWeapon ), 2, Utility.Random( 20, 90 ), 0xF8F, 0x83F ) );
				Add( new GenericBuyInfo( typeof( light_wall_torch ), 50, Utility.Random( 3,31 ), 0xA07, 0 ) );
				Add( new GenericBuyInfo( typeof( light_dragon_brazier ), 750, Utility.Random( 3,31 ), 0x194E, 0 ) );
				Add( new GenericBuyInfo( typeof( TrapKit ), 420, Utility.Random( 1,3 ), 0x1EBB, 0 ) );
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{
				Add( typeof( LootChest ), 600 );
				Add( typeof( Shovel ), 6 );
				Add( typeof( OreShovel ), 5 );
				Add( typeof( SewingKit ), 1 );
				Add( typeof( Scissors ), 6 );
				Add( typeof( Tongs ), 7 );
				Add( typeof( Key ), 1 );
				Add( typeof( DovetailSaw ), 6 );
				Add( typeof( MouldingPlane ), 6 );
				Add( typeof( Nails ), 1 );
				Add( typeof( JointingPlane ), 6 );
				Add( typeof( SmoothingPlane ), 6 );
				Add( typeof( Saw ), 7 );
				Add( typeof( Clock ), 11 );
				Add( typeof( ClockParts ), 1 );
				Add( typeof( AxleGears ), 1 );
				Add( typeof( Gears ), 1 );
				Add( typeof( Hinge ), 1 );
				Add( typeof( Sextant ), 6 );
				Add( typeof( SextantParts ), 2 );
				Add( typeof( Axle ), 1 );
				Add( typeof( Springs ), 1 );
				Add( typeof( DrawKnife ), 5 );
				Add( typeof( Froe ), 5 );
				Add( typeof( Inshave ), 5 );
				Add( typeof( Scorp ), 5 );
				Add( typeof( Lockpick ), 6 );
				Add( typeof( SkeletonsKey ), 10 );
				Add( typeof( TinkerTools ), 3 );
				Add( typeof( Board ), 1 );
				Add( typeof( Log ), 1 );
				Add( typeof( Pickaxe ), 16 );
				Add( typeof( Hammer ), 3 );
				Add( typeof( SmithHammer ), 11 );
				Add( typeof( ButcherKnife ), 6 );
				Add( typeof( CrystalScales ), Utility.Random( 300,600 ) );
				Add( typeof( GolemManual ), Utility.Random( 500,750 ) );
				Add( typeof( PowerCrystal ), 15 );
				Add( typeof( ArcaneGem ), 10 );
				Add( typeof( ClockworkAssembly ), 15 );
				Add( typeof( BottleOil ), 5 );
				Add( typeof( ThrowingWeapon ), 1 );
				Add( typeof( TrapKit ), 210 );
				Add( typeof( SpaceJunkA ), Utility.Random( 5, 10 ) );
				Add( typeof( SpaceJunkB ), Utility.Random( 10, 20 ) );
				Add( typeof( SpaceJunkC ), Utility.Random( 15, 30 ) );
				Add( typeof( SpaceJunkD ), Utility.Random( 20, 40 ) );
				Add( typeof( SpaceJunkE ), Utility.Random( 25, 50 ) );
				Add( typeof( SpaceJunkF ), Utility.Random( 30, 60 ) );
				Add( typeof( SpaceJunkG ), Utility.Random( 35, 70 ) );
				Add( typeof( SpaceJunkH ), Utility.Random( 40, 80 ) );
				Add( typeof( SpaceJunkI ), Utility.Random( 45, 90 ) );
				Add( typeof( SpaceJunkJ ), Utility.Random( 50, 100 ) );
				Add( typeof( SpaceJunkK ), Utility.Random( 55, 110 ) );
				Add( typeof( SpaceJunkL ), Utility.Random( 60, 120 ) );
				Add( typeof( SpaceJunkM ), Utility.Random( 65, 130 ) );
				Add( typeof( SpaceJunkN ), Utility.Random( 70, 140 ) );
				Add( typeof( SpaceJunkO ), Utility.Random( 75, 150 ) );
				Add( typeof( SpaceJunkP ), Utility.Random( 80, 160 ) );
				Add( typeof( SpaceJunkQ ), Utility.Random( 85, 170 ) );
				Add( typeof( SpaceJunkR ), Utility.Random( 90, 180 ) );
				Add( typeof( SpaceJunkS ), Utility.Random( 95, 190 ) );
				Add( typeof( SpaceJunkT ), Utility.Random( 100, 200 ) );
				Add( typeof( SpaceJunkU ), Utility.Random( 105, 210 ) );
				Add( typeof( SpaceJunkV ), Utility.Random( 110, 220 ) );
				Add( typeof( SpaceJunkW ), Utility.Random( 115, 230 ) );
				Add( typeof( SpaceJunkX ), Utility.Random( 120, 240 ) );
				Add( typeof( SpaceJunkY ), Utility.Random( 125, 250 ) );
				Add( typeof( SpaceJunkZ ), Utility.Random( 130, 260 ) );
				Add( typeof( LandmineSetup ), Utility.Random( 100, 300 ) );
				Add( typeof( PlasmaGrenade ), Utility.Random( 28, 38 ) );
				Add( typeof( ThermalDetonator ), Utility.Random( 28, 38 ) );
				Add( typeof( PuzzleCube ), Utility.Random( 45, 90 ) );
				Add( typeof( PlasmaTorch ), Utility.Random( 45, 90 ) );
				Add( typeof( DuctTape ), Utility.Random( 45, 90 ) );
				Add( typeof( RobotBatteries ), Utility.Random( 5, 100 ) );
				Add( typeof( RobotSheetMetal ), Utility.Random( 5, 100 ) );
				Add( typeof( RobotOil ), Utility.Random( 5, 100 ) );
				Add( typeof( RobotGears ), Utility.Random( 5, 100 ) );
				Add( typeof( RobotEngineParts ), Utility.Random( 5, 100 ) );
				Add( typeof( RobotCircuitBoard ), Utility.Random( 5, 100 ) );
				Add( typeof( RobotBolt ), Utility.Random( 5, 100 ) );
				Add( typeof( RobotTransistor ), Utility.Random( 5, 100 ) );
				Add( typeof( RobotSchematics ), Utility.Random( 500,750 ) );
				Add( typeof( DataPad ), Utility.Random( 5, 150 ) );
				Add( typeof( MaterialLiquifier ), Utility.Random( 100, 300 ) );
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBThiefGuild : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBThiefGuild()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "Toy Maker's Kit", typeof( ToyMakersKit ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( Backpack ), 15, Utility.Random( 3,31 ), 0x9B2, 0 ) );
				Add( new GenericBuyInfo( typeof( Pouch ), 6, Utility.Random( 3,31 ), 0xE79, 0 ) );
				Add( new GenericBuyInfo( typeof( Torch ), 8, Utility.Random( 3,31 ), 0xF6B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lantern ), 2, Utility.Random( 3,31 ), 0xA25, 0 ) );
				Add( new GenericBuyInfo( typeof( LearnStealingBook ), 5, Utility.Random( 3,31 ), 0x2D9F, 0 ) );
				Add( new GenericBuyInfo( typeof( Lockpick ), 12, Utility.Random( 3,31 ), 0x14FC, 0 ) );
				Add( new GenericBuyInfo( typeof( SkeletonsKey ), Utility.Random( 3,31 ), 1, 0x410A, 0 ) );
				Add( new GenericBuyInfo( typeof( WoodenBox ), 14, Utility.Random( 3,31 ), 0x9AA, 0 ) );
				Add( new GenericBuyInfo( typeof( Key ), 2, Utility.Random( 3,31 ), 0x100E, 0 ) );
				Add( new GenericBuyInfo( "1041060", typeof( HairDye ), 100, Utility.Random( 1,15 ), 0xEFF, 0 ) );
				Add( new GenericBuyInfo( "hair dye bottle", typeof( HairDyeBottle ), 1000, Utility.Random( 1,15 ), 0xE0F, 0 ) );
				Add( new GenericBuyInfo( typeof( DisguiseKit ), 700, Utility.Random( 1,5 ), 0xE05, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( Backpack ), 7 );
				Add( typeof( Pouch ), 3 );
				Add( typeof( Torch ), 3 );
				Add( typeof( Lantern ), 1 );
				Add( typeof( Lockpick ), 6 );
				Add( typeof( WoodenBox ), 7 );
				Add( typeof( HairDye ), 50 );
				Add( typeof( HairDyeBottle ), 300 );
				Add( typeof( SkeletonsKey ), 10 );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBTailorGuild: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBTailorGuild()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( GuildSewing ), 500, Utility.Random( 1,5 ), 0xF9D, 0x430 ) );
				Add( new GenericBuyInfo( typeof( SewingKit ), 3, Utility.Random( 3,31 ), 0xF9D, 0 ) ); 
				Add( new GenericBuyInfo( typeof( Scissors ), 11, Utility.Random( 3,31 ), 0xF9F, 0 ) );
				Add( new GenericBuyInfo( typeof( DyeTub ), 8, Utility.Random( 3,31 ), 0xFAB, 0 ) ); 
				Add( new GenericBuyInfo( typeof( Dyes ), 8, Utility.Random( 3,31 ), 0xFA9, 0 ) ); 
				Add( new GenericBuyInfo( typeof( Shirt ), 12, Utility.Random( 3,31 ), 0x1517, 0 ) );
				Add( new GenericBuyInfo( typeof( ShortPants ), 7, Utility.Random( 3,31 ), 0x152E, 0 ) );
				Add( new GenericBuyInfo( typeof( FancyShirt ), 21, Utility.Random( 3,31 ), 0x1EFD, 0 ) );
				Add( new GenericBuyInfo( typeof( LongPants ), 10, Utility.Random( 3,31 ), 0x1539, 0 ) );
				Add( new GenericBuyInfo( typeof( FancyDress ), 26, Utility.Random( 3,31 ), 0x1EFF, 0 ) );
				Add( new GenericBuyInfo( typeof( PlainDress ), 13, Utility.Random( 3,31 ), 0x1F01, 0 ) );
				Add( new GenericBuyInfo( typeof( Kilt ), 11, Utility.Random( 3,31 ), 0x1537, 0 ) );
				Add( new GenericBuyInfo( typeof( Kilt ), 11, Utility.Random( 3,31 ), 0x1537, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( HalfApron ), 10, Utility.Random( 3,31 ), 0x153b, 0 ) );
				Add( new GenericBuyInfo( typeof( LoinCloth ), 10, Utility.Random( 3,31 ), 0x2B68, 637 ) );
				Add( new GenericBuyInfo( typeof( Robe ), 18, Utility.Random( 3,31 ), 0x1F03, 0 ) );
				Add( new GenericBuyInfo( typeof( Cloak ), 8, Utility.Random( 3,31 ), 0x1515, 0 ) );
				Add( new GenericBuyInfo( typeof( Cloak ), 8, Utility.Random( 3,31 ), 0x1515, 0 ) );
				Add( new GenericBuyInfo( typeof( Doublet ), 13, Utility.Random( 3,31 ), 0x1F7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Tunic ), 18, Utility.Random( 3,31 ), 0x1FA1, 0 ) );
				Add( new GenericBuyInfo( typeof( JesterSuit ), 26, Utility.Random( 3,31 ), 0x1F9F, 0 ) );
				Add( new GenericBuyInfo( typeof( JesterHat ), 12, Utility.Random( 3,31 ), 0x171C, 0 ) );
				Add( new GenericBuyInfo( typeof( FloppyHat ), 7, Utility.Random( 3,31 ), 0x1713, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( WideBrimHat ), 8, Utility.Random( 3,31 ), 0x1714, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( Cap ), 10, Utility.Random( 3,31 ), 0x1715, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( TallStrawHat ), 8, Utility.Random( 3,31 ), 0x1716, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( StrawHat ), 7, Utility.Random( 3,31 ), 0x1717, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( WizardsHat ), 11, Utility.Random( 3,31 ), 0x1718, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( WitchHat ), 11, Utility.Random( 1,15 ), 0x2FC3, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( LeatherCap ), 10, Utility.Random( 3,31 ), 0x1DB9, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( FeatheredHat ), 10, Utility.Random( 3,31 ), 0x171A, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( TricorneHat ), 8, Utility.Random( 3,31 ), 0x171B, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( PirateHat ), 8, Utility.Random( 3,31 ), 0x2FBC, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( Bandana ), 6, Utility.Random( 3,31 ), 0x1540, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( SkullCap ), 7, Utility.Random( 3,31 ), 0x1544, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( ClothHood ), 12, Utility.Random( 1,15 ), 0x2B71, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( ClothCowl ), 12, Utility.Random( 1,15 ), 0x3176, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( BoltOfCloth ), 100, Utility.Random( 3,31 ), 0xf95, Utility.RandomDyedHue() ) ); 
				Add( new GenericBuyInfo( typeof( Cloth ), 2, Utility.Random( 3,31 ), 0x1766, Utility.RandomDyedHue() ) ); 
				Add( new GenericBuyInfo( typeof( UncutCloth ), 2, Utility.Random( 3,31 ), 0x1767, Utility.RandomDyedHue() ) ); 
				Add( new GenericBuyInfo( typeof( Cotton ), 102, Utility.Random( 3,31 ), 0xDF9, 0 ) );
				Add( new GenericBuyInfo( typeof( Wool ), 62, Utility.Random( 3,31 ), 0xDF8, 0 ) );
				Add( new GenericBuyInfo( typeof( Flax ), 102, Utility.Random( 3,31 ), 0x1A9C, 0 ) );
				Add( new GenericBuyInfo( typeof( SpoolOfThread ), 18, Utility.Random( 3,31 ), 0xFA0, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( Scissors ), 6 );
				Add( typeof( SewingKit ), 1 );
				Add( typeof( Dyes ), 4 );
				Add( typeof( DyeTub ), 4 );
				Add( typeof( BoltOfCloth ), 50 );
				Add( typeof( FancyShirt ), 10 );
				Add( typeof( Shirt ), 6 );
				Add( typeof( ShortPants ), 3 );
				Add( typeof( LongPants ), 5 );
				Add( typeof( Cloak ), 4 );
				Add( typeof( FancyDress ), 12 );
				Add( typeof( Robe ), 9 );
				Add( typeof( PlainDress ), 7 );
				Add( typeof( Skirt ), 5 );
				Add( typeof( Kilt ), 5 );
				Add( typeof( Doublet ), 7 );
				Add( typeof( Tunic ), 9 );
				Add( typeof( JesterSuit ), 13 );
				Add( typeof( FullApron ), 5 );
				Add( typeof( HalfApron ), 5 );
				Add( typeof( LoinCloth ), 5 );
				Add( typeof( JesterHat ), 6 );
				Add( typeof( FloppyHat ), 3 );
				Add( typeof( WideBrimHat ), 4 );
				Add( typeof( Cap ), 5 );
				Add( typeof( SkullCap ), 3 );
				Add( typeof( ClothCowl ), 6 );
				Add( typeof( ClothHood ), 6 );
				Add( typeof( Bandana ), 3 );
				Add( typeof( TallStrawHat ), 4 );
				Add( typeof( StrawHat ), 4 );
				Add( typeof( WizardsHat ), 5 );
				Add( typeof( WitchHat ), 5 );
				Add( typeof( Bonnet ), 4 );
				Add( typeof( FeatheredHat ), 5 );
				Add( typeof( TricorneHat ), 4 );
				Add( typeof( PirateHat ), 4 );
				Add( typeof( SpoolOfThread ), 9 );
				Add( typeof( Flax ), 51 );
				Add( typeof( Cotton ), 51 );
				Add( typeof( Wool ), 31 );
				Add( typeof( MagicRobe ), 30 ); 
				Add( typeof( MagicHat ), 20 ); 
				Add( typeof( MagicCloak ), 30 ); 
				Add( typeof( MagicBelt ), 20 ); 
				Add( typeof( MagicSash ), 20 ); 
				Add( typeof( JokerRobe ), 19 );
				Add( typeof( AssassinRobe ), 19 );
				Add( typeof( FancyRobe ), 19 );
				Add( typeof( GildedRobe ), 19 );
				Add( typeof( OrnateRobe ), 19 );
				Add( typeof( MagistrateRobe ), 19 );
				Add( typeof( RoyalRobe ), 19 );
				Add( typeof( SorcererRobe ), 19 );
				Add( typeof( AssassinShroud ), 29 );
				Add( typeof( NecromancerRobe ), 19 );
				Add( typeof( SpiderRobe ), 19 );
				//Add( typeof( MagicScissors ), Utility.Random( 300,400 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBMinerGuild: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBMinerGuild()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( Bag ), 6, Utility.Random( 3,31 ), 0xE76, 0 ) );
				Add( new GenericBuyInfo( typeof( Candle ), 6, Utility.Random( 3,31 ), 0xA28, 0 ) );
				Add( new GenericBuyInfo( typeof( Torch ), 8, Utility.Random( 3,31 ), 0xF6B, 0 ) );
				Add( new GenericBuyInfo( typeof( Lantern ), 2, Utility.Random( 3,31 ), 0xA25, 0 ) );
				Add( new GenericBuyInfo( typeof( Pickaxe ), 25, Utility.Random( 3,31 ), 0xE86, 0 ) );
				Add( new GenericBuyInfo( typeof( Shovel ), 12, Utility.Random( 3,31 ), 0xF39, 0 ) );
				Add( new GenericBuyInfo( typeof( OreShovel ), 10, Utility.Random( 3,31 ), 0xF39, 0x96D ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( Pickaxe ), 12 );
				Add( typeof( Shovel ), 6 );
				Add( typeof( OreShovel ), 5 );
				Add( typeof( Lantern ), 1 );
				Add( typeof( Torch ), 3 );
				Add( typeof( Bag ), 3 );
				Add( typeof( Candle ), 3 );
				Add( typeof( IronIngot ), 4 ); 
				Add( typeof( DullCopperIngot ), 8 ); 
				Add( typeof( ShadowIronIngot ), 12 ); 
				Add( typeof( CopperIngot ), 16 ); 
				Add( typeof( BronzeIngot ), 20 ); 
				Add( typeof( GoldIngot ), 24 ); 
				Add( typeof( AgapiteIngot ), 28 ); 
				Add( typeof( VeriteIngot ), 32 ); 
				Add( typeof( ValoriteIngot ), 36 ); 
				Add( typeof( NepturiteIngot ), 36 ); 
				Add( typeof( ObsidianIngot ), 36 ); 
				Add( typeof( SteelIngot ), 40 ); 
				Add( typeof( BrassIngot ), 44 ); 
				Add( typeof( MithrilIngot ), 48 ); 
				Add( typeof( XormiteIngot ), 48 ); 
				Add( typeof( DwarvenIngot ), 96 ); 
				Add( typeof( Amber ), 25 );
				Add( typeof( Amethyst ), 50 );
				Add( typeof( Citrine ), 25 );
				Add( typeof( Diamond ), 100 );
				Add( typeof( Emerald ), 50 );
				Add( typeof( Ruby ), 37 );
				Add( typeof( Sapphire ), 50 );
				Add( typeof( StarSapphire ), 62 );
				Add( typeof( Tourmaline ), 47 );
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( RareAnvil ), Utility.Random( 200,1000 ) ); } // DO NOT WANT?
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBMageGuild : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBMageGuild()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( Spellbook ), 18, Utility.Random( 3,31 ), 0xEFA, 0 ) );
				Add( new GenericBuyInfo( typeof( ScribesPen ), 8, Utility.Random( 3,31 ), 0x2051, 0 ) );
				Add( new GenericBuyInfo( typeof( BlankScroll ), 5, Utility.Random( 3,31 ), 0x0E34, 0 ) );
				Add( new GenericBuyInfo( "1041072", typeof( MagicWizardsHat ), 11, Utility.Random( 3,31 ), 0x1718, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( WitchHat ), 11, Utility.Random( 1,15 ), 0x2FC3, Utility.RandomDyedHue() ) );
				Add( new GenericBuyInfo( typeof( RecallRune ), 15, Utility.Random( 3,31 ), 0x1F14, 0 ) );
				Add( new GenericBuyInfo( typeof( BlackPearl ), 5, Utility.Random( 30,310 ), 0x266F, 0 ) );
				Add( new GenericBuyInfo( typeof( Bloodmoss ), 5, Utility.Random( 30,310 ), 0xF7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Garlic ), 3, Utility.Random( 30,310 ), 0xF84, 0 ) );
				Add( new GenericBuyInfo( typeof( Ginseng ), 3, Utility.Random( 30,310 ), 0xF85, 0 ) );
				Add( new GenericBuyInfo( typeof( MandrakeRoot ), 3, Utility.Random( 30,310 ), 0xF86, 0 ) );
				Add( new GenericBuyInfo( typeof( Nightshade ), 3, Utility.Random( 30,310 ), 0xF88, 0 ) );
				Add( new GenericBuyInfo( typeof( SpidersSilk ), 3, Utility.Random( 30,310 ), 0xF8D, 0 ) );
				Add( new GenericBuyInfo( typeof( SulfurousAsh ), 3, Utility.Random( 30,310 ), 0xF8C, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( reagents_magic_jar1 ), 2000, Utility.Random( 3,31 ), 0x1007, 0 ) ); }

				Type[] types = Loot.RegularScrollTypes;

				int circles = 4;

				for ( int i = 0; i < circles*8 && i < types.Length; ++i )
				{
					int itemID = 0x1F2E + i;

					if ( i == 6 )
						itemID = 0x1F2D;
					else if ( i > 6 )
						--itemID;

					Add( new GenericBuyInfo( types[i], 12 + ((i / 8) * 10), 20, itemID, 0 ) );
				}
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( MagicTalisman ), Utility.Random( 50,100 ) ); 
				Add( typeof( WizardsHat ), 15 );
				Add( typeof( WitchHat ), 5 );
				Add( typeof( BlackPearl ), 3 ); 
				Add( typeof( Bloodmoss ),4 ); 
				Add( typeof( MandrakeRoot ), 2 ); 
				Add( typeof( Garlic ), 2 ); 
				Add( typeof( Ginseng ), 2 ); 
				Add( typeof( Nightshade ), 2 ); 
				Add( typeof( SpidersSilk ), 2 ); 
				Add( typeof( SulfurousAsh ), 1 ); 
				Add( typeof( RecallRune ), 13 );
				Add( typeof( Spellbook ), 25 );
				Add( typeof( MysticalPearl ), 250 );

				Type[] types = Loot.RegularScrollTypes;

				for ( int i = 0; i < types.Length; ++i )
					Add(types[i], i + 3 + (i / 4));
			
				Add( typeof( ClumsyMagicStaff ), Utility.Random( 10,20 ) );
				Add( typeof( CreateFoodMagicStaff ), Utility.Random( 10,20 ) );
				Add( typeof( FeebleMagicStaff ), Utility.Random( 10,20 ) );
				Add( typeof( HealMagicStaff ), Utility.Random( 10,20 ) );
				Add( typeof( MagicArrowMagicStaff ), Utility.Random( 10,20 ) );
				Add( typeof( NightSightMagicStaff ), Utility.Random( 10,20 ) );
				Add( typeof( ReactiveArmorMagicStaff ), Utility.Random( 10,20 ) );
				Add( typeof( WeaknessMagicStaff ), Utility.Random( 10,20 ) );
				Add( typeof( AgilityMagicStaff ), Utility.Random( 20,40 ) );
				Add( typeof( CunningMagicStaff ), Utility.Random( 20,40 ) );
				Add( typeof( CureMagicStaff ), Utility.Random( 20,40 ) );
				Add( typeof( HarmMagicStaff ), Utility.Random( 20,40 ) );
				Add( typeof( MagicTrapMagicStaff ), Utility.Random( 20,40 ) );
				Add( typeof( MagicUntrapMagicStaff ), Utility.Random( 20,40 ) );
				Add( typeof( ProtectionMagicStaff ), Utility.Random( 20,40 ) );
				Add( typeof( StrengthMagicStaff ), Utility.Random( 20,40 ) );
				Add( typeof( BlessMagicStaff ), Utility.Random( 30,60 ) );
				Add( typeof( FireballMagicStaff ), Utility.Random( 30,60 ) );
				Add( typeof( MagicLockMagicStaff ), Utility.Random( 30,60 ) );
				Add( typeof( MagicUnlockMagicStaff ), Utility.Random( 30,60 ) );
				Add( typeof( PoisonMagicStaff ), Utility.Random( 30,60 ) );
				Add( typeof( TelekinesisMagicStaff ), Utility.Random( 30,60 ) );
				Add( typeof( TeleportMagicStaff ), Utility.Random( 30,60 ) );
				Add( typeof( WallofStoneMagicStaff ), Utility.Random( 30,60 ) );
				Add( typeof( ArchCureMagicStaff ), Utility.Random( 40,80 ) );
				Add( typeof( ArchProtectionMagicStaff ), Utility.Random( 40,80 ) );
				Add( typeof( CurseMagicStaff ), Utility.Random( 40,80 ) );
				Add( typeof( FireFieldMagicStaff ), Utility.Random( 40,80 ) );
				Add( typeof( GreaterHealMagicStaff ), Utility.Random( 40,80 ) );
				Add( typeof( LightningMagicStaff ), Utility.Random( 40,80 ) );
				Add( typeof( ManaDrainMagicStaff ), Utility.Random( 40,80 ) );
				Add( typeof( RecallMagicStaff ), Utility.Random( 40,80 ) );
				Add( typeof( BladeSpiritsMagicStaff ), Utility.Random( 50,100 ) );
				Add( typeof( DispelFieldMagicStaff ), Utility.Random( 50,100 ) );
				Add( typeof( IncognitoMagicStaff ), Utility.Random( 50,100 ) );
				Add( typeof( MagicReflectionMagicStaff ), Utility.Random( 50,100 ) );
				Add( typeof( MindBlastMagicStaff ), Utility.Random( 50,100 ) );
				Add( typeof( ParalyzeMagicStaff ), Utility.Random( 50,100 ) );
				Add( typeof( PoisonFieldMagicStaff ), Utility.Random( 50,100 ) );
				Add( typeof( SummonCreatureMagicStaff ), Utility.Random( 50,100 ) );
				Add( typeof( DispelMagicStaff ), Utility.Random( 60,120 ) );
				Add( typeof( EnergyBoltMagicStaff ), Utility.Random( 60,120 ) );
				Add( typeof( ExplosionMagicStaff ), Utility.Random( 60,120 ) );
				Add( typeof( InvisibilityMagicStaff ), Utility.Random( 60,120 ) );
				Add( typeof( MarkMagicStaff ), Utility.Random( 60,120 ) );
				Add( typeof( MassCurseMagicStaff ), Utility.Random( 60,120 ) );
				Add( typeof( ParalyzeFieldMagicStaff ), Utility.Random( 60,120 ) );
				Add( typeof( RevealMagicStaff ), Utility.Random( 60,120 ) );
				Add( typeof( ChainLightningMagicStaff ), Utility.Random( 70,140 ) );
				Add( typeof( EnergyFieldMagicStaff ), Utility.Random( 70,140 ) );
				Add( typeof( FlameStrikeMagicStaff ), Utility.Random( 70,140 ) );
				Add( typeof( GateTravelMagicStaff ), Utility.Random( 70,140 ) );
				Add( typeof( ManaVampireMagicStaff ), Utility.Random( 70,140 ) );
				Add( typeof( MassDispelMagicStaff ), Utility.Random( 70,140 ) );
				Add( typeof( MeteorSwarmMagicStaff ), Utility.Random( 70,140 ) );
				Add( typeof( PolymorphMagicStaff ), Utility.Random( 70,140 ) );
				Add( typeof( AirElementalMagicStaff ), Utility.Random( 80,160 ) );
				Add( typeof( EarthElementalMagicStaff ), Utility.Random( 80,160 ) );
				Add( typeof( EarthquakeMagicStaff ), Utility.Random( 80,160 ) );
				Add( typeof( EnergyVortexMagicStaff ), Utility.Random( 80,160 ) );
				Add( typeof( FireElementalMagicStaff ), Utility.Random( 80,160 ) );
				Add( typeof( ResurrectionMagicStaff ), Utility.Random( 80,160 ) );
				Add( typeof( SummonDaemonMagicStaff ), Utility.Random( 80,160 ) );
				Add( typeof( WaterElementalMagicStaff ), Utility.Random( 80,160 ) );
				Add( typeof( MySpellbook ), 500 );
				Add( typeof( TomeOfWands ), Utility.Random( 100,400 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBHealerGuild : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBHealerGuild()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( Bandage ), 5, Utility.Random( 300,310 ), 0xE21, 0 ) );
				Add( new GenericBuyInfo( typeof( LesserHealPotion ), 15, Utility.Random( 3,31 ), 0x25FD, 0 ) );
				Add( new GenericBuyInfo( typeof( HealPotion ), 30, Utility.Random( 3,31 ), 0xF0C, 0 ) );
				Add( new GenericBuyInfo( typeof( GreaterHealPotion ), 60, Utility.Random( 3,31 ), 0x25FE, 0 ) );
				Add( new GenericBuyInfo( typeof( Ginseng ), 3, Utility.Random( 3,31 ), 0xF85, 0 ) );
				Add( new GenericBuyInfo( typeof( Garlic ), 3, Utility.Random( 3,31 ), 0xF84, 0 ) );
				Add( new GenericBuyInfo( typeof( RefreshPotion ), 15, Utility.Random( 3,31 ), 0xF0B, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( LesserHealPotion ), 7 );
				Add( typeof( HealPotion ), 14 );
				Add( typeof( GreaterHealPotion ), 28 );
				Add( typeof( RefreshPotion ), 7 );
				Add( typeof( Garlic ), 2 );
				Add( typeof( Ginseng ), 2 );
				Add( typeof( FirstAidKit ), Utility.Random( 100,250 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBSailorGuild : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBSailorGuild()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( "1041205", typeof( SmallBoatDeed ), 9500, Utility.Random( 1,15 ), 0x14F3, 0x5BE ) );
				Add( new GenericBuyInfo( "1041206", typeof( SmallDragonBoatDeed ), 10500, Utility.Random( 1,15 ), 0x14F3, 0x5BE ) );
				Add( new GenericBuyInfo( "1041207", typeof( MediumBoatDeed ), 11500, Utility.Random( 1,15 ), 0x14F3, 0x5BE ) );
				Add( new GenericBuyInfo( "1041208", typeof( MediumDragonBoatDeed ), 12500, Utility.Random( 1,15 ), 0x14F3, 0x5BE ) );
				Add( new GenericBuyInfo( "1041209", typeof( LargeBoatDeed ), 13500, Utility.Random( 1,15 ), 0x14F3, 0x5BE ) );
				Add( new GenericBuyInfo( "1041210", typeof( LargeDragonBoatDeed ), 14500, Utility.Random( 1,15 ), 0x14F3, 0x5BE ) );
				Add( new GenericBuyInfo( typeof( DockingLantern ), 58, Utility.Random( 3,31 ), 0x40FF, 0 ) );
				Add( new GenericBuyInfo( typeof( RawFishSteak ), 3, Utility.Random( 3,31 ), 0x97A, 0 ) );
				Add( new GenericBuyInfo( typeof( Fish ), 6, Utility.Random( 3,31 ), 0x9CC, 0 ) );
				Add( new GenericBuyInfo( typeof( Fish ), 6, Utility.Random( 3,31 ), 0x9CD, 0 ) );
				Add( new GenericBuyInfo( typeof( Fish ), 6, Utility.Random( 3,31 ), 0x9CE, 0 ) );
				Add( new GenericBuyInfo( typeof( Fish ), 6, Utility.Random( 3,31 ), 0x9CF, 0 ) );
				Add( new GenericBuyInfo( typeof( FishingPole ), 15, Utility.Random( 3,31 ), 0xDC0, 0 ) );
				Add( new GenericBuyInfo( typeof( Sextant ), 13, Utility.Random( 1,15 ), 0x1057, 0 ) );
				Add( new GenericBuyInfo( typeof( BoatStain ), 26, Utility.Random( 1,15 ), 0x14E0, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( SeaShell ), 58 );
				Add( typeof( DockingLantern ), 29 );
				Add( typeof( RawFishSteak ), 1 );
				Add( typeof( Fish ), 1 );
				Add( typeof( FishingPole ), 7 );
				Add( typeof( Sextant ), 6 );
				Add( typeof( PirateChest ), Utility.RandomMinMax( 200, 800 ) );
				Add( typeof( SunkenChest ), Utility.RandomMinMax( 200, 800 ) );
				Add( typeof( FishingNet ), Utility.RandomMinMax( 20, 40 ) );
				Add( typeof( SpecialFishingNet ), Utility.RandomMinMax( 60, 80 ) );
				Add( typeof( FabledFishingNet ), Utility.RandomMinMax( 100, 120 ) );
				Add( typeof( NeptunesFishingNet ), Utility.RandomMinMax( 140, 160 ) );
				Add( typeof( PrizedFish ), Utility.RandomMinMax( 60, 120 ) );
				Add( typeof( WondrousFish ), Utility.RandomMinMax( 60, 120 ) );
				Add( typeof( TrulyRareFish ), Utility.RandomMinMax( 60, 120 ) );
				Add( typeof( PeculiarFish ), Utility.RandomMinMax( 60, 120 ) );
				Add( typeof( SpecialSeaweed ), Utility.RandomMinMax( 40, 160 ) );
				Add( typeof( SunkenBag ), Utility.RandomMinMax( 100, 500 ) );
				Add( typeof( ShipwreckedItem ), Utility.RandomMinMax( 20, 60 ) );
				Add( typeof( HighSeasRelic ), Utility.RandomMinMax( 20, 60 ) );
				Add( typeof( BoatStain ), 13 );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBBlacksmithGuild : SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBBlacksmithGuild() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{
				Add( new GenericBuyInfo( "Toy Maker's Kit", typeof( ToyMakersKit ), 50, 20, 0xF27, 0x5E2 ) );
				Add( new GenericBuyInfo( typeof( GuildHammer ), 500, Utility.Random( 1,5 ), 0xFB5, 0x430 ) );
				Add( new GenericBuyInfo( typeof( IronIngot ), 5, Utility.Random( 300,310 ), 0x1BF2, 0 ) );
				Add( new GenericBuyInfo( typeof( Tongs ), 13, Utility.Random( 3,31 ), 0xFBB, 0 ) ); 
				Add( new GenericBuyInfo( typeof( BronzeShield ), 66, Utility.Random( 3,31 ), 0x1B72, 0 ) );
				Add( new GenericBuyInfo( typeof( Buckler ), 50, Utility.Random( 3,31 ), 0x1B73, 0 ) );
				Add( new GenericBuyInfo( typeof( MetalKiteShield ), 123, Utility.Random( 3,31 ), 0x1B74, 0 ) );
				Add( new GenericBuyInfo( typeof( HeaterShield ), 231, Utility.Random( 3,31 ), 0x1B76, 0 ) );
				Add( new GenericBuyInfo( typeof( MetalShield ), 121, Utility.Random( 3,31 ), 0x1B7B, 0 ) );
				Add( new GenericBuyInfo( typeof( PlateGorget ), 104, Utility.Random( 3,31 ), 0x1413, 0 ) );
				Add( new GenericBuyInfo( typeof( PlateChest ), 243, Utility.Random( 3,31 ), 0x1415, 0 ) );
				Add( new GenericBuyInfo( typeof( PlateLegs ), 218, Utility.Random( 3,31 ), 0x1411, 0 ) );
				Add( new GenericBuyInfo( typeof( PlateArms ), 188, Utility.Random( 3,31 ), 0x1410, 0 ) );
				Add( new GenericBuyInfo( typeof( PlateGloves ), 155, Utility.Random( 3,31 ), 0x1414, 0 ) );
				Add( new GenericBuyInfo( typeof( PlateHelm ), 21, Utility.Random( 3,31 ), 0x1412, 0 ) );
				Add( new GenericBuyInfo( typeof( CloseHelm ), 18, Utility.Random( 3,31 ), 0x1408, 0 ) );
				Add( new GenericBuyInfo( typeof( CloseHelm ), 18, Utility.Random( 3,31 ), 0x1409, 0 ) );
				Add( new GenericBuyInfo( typeof( Helmet ), 31, Utility.Random( 3,31 ), 0x140A, 0 ) );
				Add( new GenericBuyInfo( typeof( Helmet ), 18, Utility.Random( 3,31 ), 0x140B, 0 ) );
				Add( new GenericBuyInfo( typeof( NorseHelm ), 18, Utility.Random( 3,31 ), 0x140E, 0 ) );
				Add( new GenericBuyInfo( typeof( NorseHelm ), 18, Utility.Random( 3,31 ), 0x140F, 0 ) );
				Add( new GenericBuyInfo( typeof( Bascinet ), 18, Utility.Random( 3,31 ), 0x140C, 0 ) );
				Add( new GenericBuyInfo( typeof( PlateHelm ), 21, Utility.Random( 3,31 ), 0x1419, 0 ) );
				Add( new GenericBuyInfo( typeof( DreadHelm ), 21, Utility.Random( 3,31 ), 0x2FBB, 0 ) );
				Add( new GenericBuyInfo( typeof( ChainCoif ), 17, Utility.Random( 3,31 ), 0x13BB, 0 ) );
				Add( new GenericBuyInfo( typeof( ChainChest ), 143, Utility.Random( 3,31 ), 0x13BF, 0 ) );
				Add( new GenericBuyInfo( typeof( ChainLegs ), 149, Utility.Random( 3,31 ), 0x13BE, 0 ) );
				Add( new GenericBuyInfo( typeof( RingmailChest ), 121, Utility.Random( 3,31 ), 0x13ec, 0 ) );
				Add( new GenericBuyInfo( typeof( RingmailLegs ), 90, Utility.Random( 3,31 ), 0x13F0, 0 ) );
				Add( new GenericBuyInfo( typeof( RingmailArms ), 85, Utility.Random( 3,31 ), 0x13EE, 0 ) );
				Add( new GenericBuyInfo( typeof( RingmailGloves ), 93, Utility.Random( 3,31 ), 0x13eb, 0 ) );
				Add( new GenericBuyInfo( typeof( ExecutionersAxe ), 30, Utility.Random( 3,31 ), 0xF45, 0 ) );
				Add( new GenericBuyInfo( typeof( Bardiche ), 60, Utility.Random( 3,31 ), 0xF4D, 0 ) );
				Add( new GenericBuyInfo( typeof( BattleAxe ), 26, Utility.Random( 3,31 ), 0xF47, 0 ) );
				Add( new GenericBuyInfo( typeof( TwoHandedAxe ), 32, Utility.Random( 3,31 ), 0x1443, 0 ) );
				Add( new GenericBuyInfo( typeof( ButcherKnife ), 14, Utility.Random( 3,31 ), 0x13F6, 0 ) );
				Add( new GenericBuyInfo( typeof( Cutlass ), 24, Utility.Random( 3,31 ), 0x1441, 0 ) );
				Add( new GenericBuyInfo( typeof( Dagger ), 21, Utility.Random( 3,31 ), 0xF52, 0 ) );
				Add( new GenericBuyInfo( typeof( Halberd ), 42, Utility.Random( 3,31 ), 0x143E, 0 ) );
				Add( new GenericBuyInfo( typeof( HammerPick ), 26, Utility.Random( 3,31 ), 0x143D, 0 ) );
				Add( new GenericBuyInfo( typeof( Katana ), 33, Utility.Random( 3,31 ), 0x13FF, 0 ) );
				Add( new GenericBuyInfo( typeof( Kryss ), 32, Utility.Random( 3,31 ), 0x1401, 0 ) );
				Add( new GenericBuyInfo( typeof( Broadsword ), 35, Utility.Random( 3,31 ), 0xF5E, 0 ) );
				Add( new GenericBuyInfo( typeof( Longsword ), 55, Utility.Random( 3,31 ), 0xF61, 0 ) );
				Add( new GenericBuyInfo( typeof( ThinLongsword ), 27, Utility.Random( 3,31 ), 0x13B8, 0 ) );
				Add( new GenericBuyInfo( typeof( VikingSword ), 55, Utility.Random( 3,31 ), 0x13B9, 0 ) );
				Add( new GenericBuyInfo( typeof( Cleaver ), 15, Utility.Random( 3,31 ), 0xEC3, 0 ) );
				Add( new GenericBuyInfo( typeof( Axe ), 40, Utility.Random( 3,31 ), 0xF49, 0 ) );
				Add( new GenericBuyInfo( typeof( DoubleAxe ), 52, Utility.Random( 3,31 ), 0xF4B, 0 ) );
				Add( new GenericBuyInfo( typeof( Pickaxe ), 22, Utility.Random( 3,31 ), 0xE86, 0 ) );
				Add( new GenericBuyInfo( typeof( Pitchfork ), 19, Utility.Random( 3,31 ), 0xE87, 0 ) );
				Add( new GenericBuyInfo( typeof( Scimitar ), 36, Utility.Random( 3,31 ), 0x13B6, 0 ) );
				Add( new GenericBuyInfo( typeof( SkinningKnife ), 14, Utility.Random( 3,31 ), 0xEC4, 0 ) );
				Add( new GenericBuyInfo( typeof( LargeBattleAxe ), 33, Utility.Random( 3,31 ), 0x13FB, 0 ) );
				Add( new GenericBuyInfo( typeof( WarAxe ), 29, Utility.Random( 3,31 ), 0x13B0, 0 ) );
				Add( new GenericBuyInfo( typeof( BoneHarvester ), 35, Utility.Random( 3,31 ), 0x26BB, 0 ) );
				Add( new GenericBuyInfo( typeof( CrescentBlade ), 37, Utility.Random( 3,31 ), 0x26C1, 0 ) );
				Add( new GenericBuyInfo( typeof( DoubleBladedStaff ), 35, Utility.Random( 3,31 ), 0x26BF, 0 ) );
				Add( new GenericBuyInfo( typeof( Lance ), 34, Utility.Random( 3,31 ), 0x26C0, 0 ) );
				Add( new GenericBuyInfo( typeof( Pike ), 39, Utility.Random( 3,31 ), 0x26BE, 0 ) );
				Add( new GenericBuyInfo( typeof( Scythe ), 39, Utility.Random( 3,31 ), 0x26BA, 0 ) );
				Add( new GenericBuyInfo( typeof( Mace ), 28, Utility.Random( 3,31 ), 0xF5C, 0 ) );
				Add( new GenericBuyInfo( typeof( Maul ), 21, Utility.Random( 3,31 ), 0x143B, 0 ) );
				Add( new GenericBuyInfo( typeof( SmithHammer ), 21, Utility.Random( 3,31 ), 0x0FB4, 0 ) );
				Add( new GenericBuyInfo( typeof( ShortSpear ), 23, Utility.Random( 3,31 ), 0x1403, 0 ) );
				Add( new GenericBuyInfo( typeof( Spear ), 31, Utility.Random( 3,31 ), 0xF62, 0 ) );
				Add( new GenericBuyInfo( typeof( WarHammer ), 25, Utility.Random( 3,31 ), 0x1439, 0 ) );
				Add( new GenericBuyInfo( typeof( WarMace ), 31, Utility.Random( 3,31 ), 0x1407, 0 ) );
				Add( new GenericBuyInfo( typeof( Scepter ), 39, Utility.Random( 3,31 ), 0x26BC, 0 ) );
				Add( new GenericBuyInfo( typeof( BladedStaff ), 40, Utility.Random( 3,31 ), 0x26BD, 0 ) );
				Add( new GenericBuyInfo( typeof( GuardsmanShield ), 231, Utility.Random( 1,15 ), 0x2FCB, 0 ) );
				Add( new GenericBuyInfo( typeof( ElvenShield ), 231, Utility.Random( 1,15 ), 0x2FCA, 0 ) );
				Add( new GenericBuyInfo( typeof( DarkShield ), 231, Utility.Random( 1,15 ), 0x2FC8, 0 ) );
				Add( new GenericBuyInfo( typeof( CrestedShield ), 231, Utility.Random( 1,15 ), 0x2FC9, 0 ) );
				Add( new GenericBuyInfo( typeof( ChampionShield ), 231, Utility.Random( 1,15 ), 0x2B74, 0 ) );
				Add( new GenericBuyInfo( typeof( JeweledShield ), 231, Utility.Random( 1,15 ), 0x2B75, 0 ) );
				Add( new GenericBuyInfo( typeof( AssassinSpike ), 21, Utility.Random( 1,15 ), 0x2D21, 0 ) );
				Add( new GenericBuyInfo( typeof( Leafblade ), 21, Utility.Random( 1,15 ), 0x2D22, 0 ) );
				Add( new GenericBuyInfo( typeof( WarCleaver ), 25, Utility.Random( 1,15 ), 0x2D2F, 0 ) );
				Add( new GenericBuyInfo( typeof( DiamondMace ), 31, Utility.Random( 1,15 ), 0x2D24, 0 ) );
				Add( new GenericBuyInfo( typeof( OrnateAxe ), 42, Utility.Random( 1,15 ), 0x2D28, 0 ) );
				Add( new GenericBuyInfo( typeof( RuneBlade ), 55, Utility.Random( 1,15 ), 0x2D32, 0 ) );
				Add( new GenericBuyInfo( typeof( RadiantScimitar ), 35, Utility.Random( 1,15 ), 0x2D33, 0 ) );
				Add( new GenericBuyInfo( typeof( ElvenSpellblade ), 33, Utility.Random( 1,15 ), 0x2D20, 0 ) );
				Add( new GenericBuyInfo( typeof( ElvenMachete ), 35, Utility.Random( 1,15 ), 0x2D35, 0 ) );
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{
				Add( typeof( GuardsmanShield ), 115 );
				Add( typeof( ElvenShield ), 115 );
				Add( typeof( DarkShield ), 115 );
				Add( typeof( CrestedShield ), 115 );
				Add( typeof( ChampionShield ), 115 );
				Add( typeof( JeweledShield ), 115 );
				Add( typeof( TopazIngot ), 120 ); 
				Add( typeof( ShinySilverIngot ), 120 ); 
				Add( typeof( AmethystIngot ), 120 ); 
				Add( typeof( EmeraldIngot ), 120 ); 
				Add( typeof( GarnetIngot ), 120 ); 
				Add( typeof( IceIngot ), 120 ); 
				Add( typeof( JadeIngot ), 120 ); 
				Add( typeof( MarbleIngot ), 120 ); 
				Add( typeof( OnyxIngot ), 120 ); 
				Add( typeof( QuartzIngot ), 120 ); 
				Add( typeof( RubyIngot ), 120 ); 
				Add( typeof( SapphireIngot ), 120 ); 
				Add( typeof( SpinelIngot ), 120 ); 
				Add( typeof( StarRubyIngot ), 120 ); 
				Add( typeof( Tongs ), 7 ); 
				Add( typeof( IronIngot ), 4 ); 
				Add( typeof( DullCopperIngot ), 8 ); 
				Add( typeof( ShadowIronIngot ), 12 ); 
				Add( typeof( CopperIngot ), 16 ); 
				Add( typeof( BronzeIngot ), 20 ); 
				Add( typeof( GoldIngot ), 24 ); 
				Add( typeof( AgapiteIngot ), 28 ); 
				Add( typeof( VeriteIngot ), 32 ); 
				Add( typeof( ValoriteIngot ), 36 ); 
				Add( typeof( NepturiteIngot ), 36 ); 
				Add( typeof( SteelIngot ), 40 ); 
				Add( typeof( BrassIngot ), 44 ); 
				Add( typeof( MithrilIngot ), 48 ); 
				Add( typeof( XormiteIngot ), 48 ); 
				Add( typeof( DwarvenIngot ), 96 ); 
				Add( typeof( ObsidianIngot ), 36 ); 
				Add( typeof( Buckler ), 25 );
				Add( typeof( BronzeShield ), 33 );
				Add( typeof( MetalShield ), 60 );
				Add( typeof( MetalKiteShield ), 62 );
				Add( typeof( HeaterShield ), 115 );
				Add( typeof( PlateArms ), 94 );
				Add( typeof( PlateChest ), 121 );
				Add( typeof( PlateGloves ), 72 );
				Add( typeof( PlateGorget ), 52 );
				Add( typeof( PlateLegs ), 109 );
				Add( typeof( PlateSkirt ), 109 );
				Add( typeof( FemalePlateChest ), 113 );
				Add( typeof( Bascinet ), 9 );
				Add( typeof( CloseHelm ), 9 );
				Add( typeof( Helmet ), 9 );
				Add( typeof( NorseHelm ), 9 );
				Add( typeof( PlateHelm ), 10 );
				Add( typeof( DreadHelm ), 10 );
				Add( typeof( ChainCoif ), 6 );
				Add( typeof( ChainChest ), 71 );
				Add( typeof( ChainLegs ), 74 );
				Add( typeof( ChainSkirt ), 74 );
				Add( typeof( RingmailArms ), 42 );
				Add( typeof( RingmailChest ), 60 );
				Add( typeof( RingmailGloves ), 26 );
				Add( typeof( RingmailLegs ), 45 );
				Add( typeof( RingmailSkirt ), 45 );
				Add( typeof( BattleAxe ), 13 );
				Add( typeof( DoubleAxe ), 26 );
				Add( typeof( ExecutionersAxe ), 15 );
				Add( typeof( LargeBattleAxe ),16 );
				Add( typeof( Pickaxe ), 11 );
				Add( typeof( TwoHandedAxe ), 16 );
				Add( typeof( WarAxe ), 14 );
				Add( typeof( Axe ), 20 );
				Add( typeof( Bardiche ), 30 );
				Add( typeof( Halberd ), 21 );
				Add( typeof( ButcherKnife ), 7 );
				Add( typeof( Cleaver ), 7 );
				Add( typeof( Dagger ), 10 );
				Add( typeof( SkinningKnife ), 7 );
				Add( typeof( HammerPick ), 13 );
				Add( typeof( Mace ), 14 );
				Add( typeof( Maul ), 10 );
				Add( typeof( WarHammer ), 12 );
				Add( typeof( WarMace ), 15 );
				Add( typeof( Scepter ), 20 );
				Add( typeof( BladedStaff ), 20 );
				Add( typeof( Scythe ), 19 );
				Add( typeof( BoneHarvester ), 17 );
				Add( typeof( Scepter ), 18 );
				Add( typeof( BladedStaff ), 16 );
				Add( typeof( Pike ), 19 );
				Add( typeof( DoubleBladedStaff ), 17 );
				Add( typeof( Lance ), 17 );
				Add( typeof( CrescentBlade ), 18 );
				Add( typeof( Spear ), 15 );
				Add( typeof( Pitchfork ), 9 );
				Add( typeof( ShortSpear ), 11 );
				Add( typeof( SmithHammer ), 10 );
				Add( typeof( Broadsword ), 17 );
				Add( typeof( Cutlass ), 12 );
				Add( typeof( Katana ), 16 );
				Add( typeof( Kryss ), 16 );
				Add( typeof( Longsword ), 27 );
				Add( typeof( Scimitar ), 18 );
				Add( typeof( ThinLongsword ), 13 );
				Add( typeof( VikingSword ), 27 );
				Add( typeof( AssassinSpike ), 10 );
				Add( typeof( Leafblade ), 10 );
				Add( typeof( WarCleaver ), 12 );
				Add( typeof( DiamondMace ), 15 );
				Add( typeof( OrnateAxe ),21 );
				Add( typeof( RuneBlade ), 27 );
				Add( typeof( RadiantScimitar ), 17 );
				Add( typeof( ElvenSpellblade ), 16 );
				Add( typeof( ElvenMachete ), 17 );
				Add( typeof( RareAnvil ), Utility.Random( 400,1500 ) );
				Add( typeof( MagicHammer ), Utility.Random( 300,400 ) );
			} 
		} 
	} 
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBBardGuild: SBInfo 
	{ 
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo(); 
		private IShopSellInfo m_SellInfo = new InternalSellInfo(); 

		public SBBardGuild() 
		{ 
		} 

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } } 
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } } 

		public class InternalBuyInfo : List<GenericBuyInfo> 
		{ 
			public InternalBuyInfo() 
			{
				Add( new GenericBuyInfo( typeof( Drums ), 21, Utility.Random( 3,31 ), 0x0E9C, 0 ) ); 
				Add( new GenericBuyInfo( typeof( Tambourine ), 21, Utility.Random( 3,31 ), 0x0E9E, 0 ) ); 
				Add( new GenericBuyInfo( typeof( LapHarp ), 21, Utility.Random( 3,31 ), 0x0EB2, 0 ) ); 
				Add( new GenericBuyInfo( typeof( Lute ), 21, Utility.Random( 3,31 ), 0x0EB3, 0 ) ); 
				Add( new GenericBuyInfo( typeof( BambooFlute ), 21, Utility.Random( 1,15 ), 0x2805, 0 ) );
				Add( new GenericBuyInfo( typeof( SongBook ), 24, Utility.Random( 1,5 ), 0x225A, 0 ) ); 
				Add( new GenericBuyInfo( typeof( EnergyCarolScroll ), 32, Utility.Random( 1,5 ), 0x1F48, 0x96 ) ); 
				Add( new GenericBuyInfo( typeof( FireCarolScroll ), 32, Utility.Random( 1,5 ), 0x1F49, 0x96 ) ); 
				Add( new GenericBuyInfo( typeof( IceCarolScroll ), 32, Utility.Random( 1,5 ), 0x1F34, 0x96 ) ); 
				Add( new GenericBuyInfo( typeof( KnightsMinneScroll ), 32, Utility.Random( 1,5 ), 0x1F31, 0x96 ) ); 
				Add( new GenericBuyInfo( typeof( PoisonCarolScroll ), 32, Utility.Random( 1,5 ), 0x1F33, 0x96 ) ); 
				Add( new GenericBuyInfo( typeof( JarsOfWaxInstrument ), 160, Utility.Random( 1,5 ), 0x1005, 0x845 ) );
				Add( new GenericBuyInfo( "Toy Maker's Kit", typeof( ToyMakersKit ), 50, 20, 0xF27, 0x5E2 ) );
			} 
		} 

		public class InternalSellInfo : GenericSellInfo 
		{ 
			public InternalSellInfo() 
			{
				Add( typeof( JarsOfWaxInstrument ), 80 );
				Add( typeof( BambooFlute ), 10 );
				Add( typeof( LapHarp ), 10 ); 
				Add( typeof( Lute ), 10 ); 
				Add( typeof( Drums ), 10 ); 
				Add( typeof( Harp ), 10 ); 
				Add( typeof( Tambourine ), 10 );
				Add( typeof( MySongbook ), 200 );
				Add( typeof( SongBook ), 12 ); 
				Add( typeof( EnergyCarolScroll ), 5 ); 
				Add( typeof( FireCarolScroll ), 5 ); 
				Add( typeof( IceCarolScroll ), 5 ); 
				Add( typeof( KnightsMinneScroll ), 5 ); 
				Add( typeof( PoisonCarolScroll ), 5 ); 
				Add( typeof( ArmysPaeonScroll ), 6 ); 
				Add( typeof( MagesBalladScroll ), 6 ); 
				Add( typeof( EnchantingEtudeScroll ), 7 ); 
				Add( typeof( SheepfoeMamboScroll ), 7 ); 
				Add( typeof( SinewyEtudeScroll ), 7 ); 
				Add( typeof( EnergyThrenodyScroll ), 8 ); 
				Add( typeof( FireThrenodyScroll ), 8 ); 
				Add( typeof( IceThrenodyScroll ), 8 ); 
				Add( typeof( PoisonThrenodyScroll ), 8 ); 
				Add( typeof( FoeRequiemScroll ), 9 ); 
				Add( typeof( MagicFinaleScroll ), 10 ); 
			} 
		} 
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBHolidayXmas : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBHolidayXmas()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( WreathDeed ), 300, Utility.Random( 1,3 ), 0x14EF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GreenStocking ), 110, Utility.Random( 1,3 ), 0x2bd9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( RedStocking ), 110, Utility.Random( 1,3 ), 0x2bdb, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( SnowPileDeco ), 80, Utility.Random( 1,3 ), 0x8E2, 0x481 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( Snowman ), 230, Utility.Random( 1,3 ), 0x2328, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( BlueSnowflake ), 100, Utility.Random( 1,3 ), 0x232E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( WhiteSnowflake ), 100, Utility.Random( 1,3 ), 0x232F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( RedPoinsettia ), 120, Utility.Random( 1,3 ), 0x2330, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( WhitePoinsettia ), 120, Utility.Random( 1,3 ), 0x2331, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( IcyPatch ), 60, Utility.Random( 1,3 ), 0x122F, 0x481 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( IcicleLargeSouth ), 80, Utility.Random( 1,3 ), 0x4572, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( IcicleMedSouth ), 70, Utility.Random( 1,3 ), 0x4573, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( IcicleSmallSouth ), 60, Utility.Random( 1,3 ), 0x4574, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( IcicleLargeEast ), 80, Utility.Random( 1,3 ), 0x4575, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( IcicleMedEast ), 70, Utility.Random( 1,3 ), 0x4576, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( IcicleSmallEast ), 60, Utility.Random( 1,3 ), 0x4577, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GingerBreadHouseDeed ), 450, Utility.Random( 1,3 ), 0x14EF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( CandyCane ), 20, Utility.Random( 1,3 ), 0x2bdd, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GingerBreadCookie ), 20, Utility.Random( 1,3 ), 0x2be1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HolidayBell ), 280, Utility.Random( 1,3 ), 0x1C12, 0xA ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GiftBoxRectangle ), 140, Utility.Random( 1,3 ), 0x46A6, Utility.RandomList( 0x672, 0x454, 0x507, 0x4ac, 0x504, 0x84b, 0x495, 0x97c, 0x493, 0x4a8, 0x494, 0x4aa, 0xb8b, 0x84f, 0x491, 0x851, 0x503, 0xb8c, 0x4ab, 0x84B ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GiftBoxCube ), 140, Utility.Random( 1,3 ), 0x46A2, Utility.RandomList( 0x672, 0x454, 0x507, 0x4ac, 0x504, 0x84b, 0x495, 0x97c, 0x493, 0x4a8, 0x494, 0x4aa, 0xb8b, 0x84f, 0x491, 0x851, 0x503, 0xb8c, 0x4ab, 0x84B ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GiftBoxCylinder ), 140, Utility.Random( 1,3 ), 0x46A3, Utility.RandomList( 0x672, 0x454, 0x507, 0x4ac, 0x504, 0x84b, 0x495, 0x97c, 0x493, 0x4a8, 0x494, 0x4aa, 0xb8b, 0x84f, 0x491, 0x851, 0x503, 0xb8c, 0x4ab, 0x84B ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GiftBoxOctogon ), 140, Utility.Random( 1,3 ), 0x46A4, Utility.RandomList( 0x672, 0x454, 0x507, 0x4ac, 0x504, 0x84b, 0x495, 0x97c, 0x493, 0x4a8, 0x494, 0x4aa, 0xb8b, 0x84f, 0x491, 0x851, 0x503, 0xb8c, 0x4ab, 0x84B ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GiftBoxAngel ), 140, Utility.Random( 1,3 ), 0x46A7, Utility.RandomList( 0x672, 0x454, 0x507, 0x4ac, 0x504, 0x84b, 0x495, 0x97c, 0x493, 0x4a8, 0x494, 0x4aa, 0xb8b, 0x84f, 0x491, 0x851, 0x503, 0xb8c, 0x4ab, 0x84B ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GiftBoxNeon ), 140, Utility.Random( 1,3 ), 0x232A, Utility.RandomList( 0x438, 0x424, 0x433, 0x445, 0x42b, 0x448 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GiftBox ), 140, Utility.Random( 1,3 ), 0x232A, Utility.RandomDyedHue() ) ); }
				Add( new GenericBuyInfo( typeof( HolidayTreeDeed ), 860, Utility.Random( 1,3 ), 0x0CC8, 0 ) );
				Add( new GenericBuyInfo( typeof( HolidayTreeFlatDeed ), 860, Utility.Random( 1,3 ), 0x0CC8, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( ChristmasRobe ), 50, Utility.Random( 1,3 ), 0x2684, 1153 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBHolidayHalloween : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBHolidayHalloween()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( BloodyTableAddonDeed ), 1500, Utility.Random( 1,3 ), 0x14EF, 0x96C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( BloodPentagramDeed ), 3800, Utility.Random( 1,3 ), 0x14EF, 0x96C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( MongbatDartBoardEastDeed ), 1200, Utility.Random( 1,3 ), 0x14EF, 0x96C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( MongbatDartBoardSouthDeed ), 1200, Utility.Random( 1,3 ), 0x14EF, 0x96C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenTree6 ), 800, Utility.Random( 1,3 ), 0xCCD, 0x2C1 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenTree5 ), 800, Utility.Random( 1,3 ), 0x224D, 0x2C1 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenTree4 ), 800, Utility.Random( 1,3 ), 0xCD3, 0x2C1 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenTree3 ), 800, Utility.Random( 1,3 ), 0x224A, 0x2C5 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenTree2 ), 800, Utility.Random( 1,3 ), 0xD94, 0x2C5 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenTree1 ), 800, Utility.Random( 1,3 ), 0xCE3, 0x2C5 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenTortSkel ), 450, Utility.Random( 1,3 ), 0x1A03, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenStoneSpike2 ), 600, Utility.Random( 1,3 ), 0x2202, 0x322 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenStoneSpike ), 600, Utility.Random( 1,3 ), 0x2201, 0x322 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenStoneColumn ), 500, Utility.Random( 1,3 ), 0x77, 0x322 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenSkullPole ), 540, Utility.Random( 1,3 ), 0x2204, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenShrineChaosDeed ), 1380, Utility.Random( 1,3 ), 0x14EF, 0x96C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenPylonFire ), 2100, Utility.Random( 1,3 ), 0x19AF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenPylon ), 1800, Utility.Random( 1,3 ), 0x1ECB, 0x322 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenMaiden ), 2780, Utility.Random( 1,3 ), 0x124B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenGrave3 ), 350, Utility.Random( 1,3 ), 0xEDE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenGrave2 ), 350, Utility.Random( 1,3 ), 0x116E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenGrave1 ), 350, Utility.Random( 1,3 ), 0x1168, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenColumn ), 1100, Utility.Random( 1,3 ), 0x196, 0x322 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenChopper ), 1760, Utility.Random( 1,3 ), 0x1245, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenBonePileDeed ), 680, Utility.Random( 1,3 ), 0x14EF, 0x96C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenBlood ), 90, Utility.Random( 1,3 ), 0x122A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( AppleBobbingBarrel ), 170, Utility.Random( 1,3 ), 0x0F33, 0 ) ); }
				Add( new GenericBuyInfo( typeof( CarvedPumpkin ), 80, Utility.Random( 1,3 ), 0x4694, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( CarvedPumpkin2 ), 80, Utility.Random( 1,3 ), 0x4698, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( DeadBodyEWDeed ), 345, Utility.Random( 1,3 ), 0x14EF, 0x96C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( DeadBodyNSDeed ), 345, Utility.Random( 1,3 ), 0x14EF, 0x96C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( EvilFireplaceSouthFaceAddonDeed ), 6800, Utility.Random( 1,3 ), 0x14EF, 1175 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( EvilFireplaceEastFaceAddonDeed ), 6800, Utility.Random( 1,3 ), 0x14EF, 1175 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( halloween_coffin_eastAddonDeed ), 470, Utility.Random( 1,3 ), 0x14EF, 0x96C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( halloween_coffin_southAddonDeed ), 470, Utility.Random( 1,3 ), 0x14EF, 0x96C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( halloween_block_southAddonDeed ), 430, Utility.Random( 1,3 ), 0x14EF, 0x96C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( halloween_block_eastAddonDeed ), 430, Utility.Random( 1,3 ), 0x14EF, 0x96C ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( LargeDyingPlant ), 225, Utility.Random( 1,3 ), 0x42B9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( DyingPlant ), 175, Utility.Random( 1,3 ), 0x42BA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( PumpkinScarecrow ), 240, Utility.Random( 1,3 ), 0x469B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GrimWarning ), 120, Utility.Random( 1,3 ), 0x42BD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( SkullsOnPike ), 120, Utility.Random( 1,3 ), 0x42B5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( BlackCatStatue ), 100, Utility.Random( 1,3 ), 0x4688, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( RuinedTapestry ), 135, Utility.Random( 1,3 ), 0x4699, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HalloweenWeb ), 185, Utility.Random( 1,3 ), 0xEE3, Utility.RandomList( 43, 1175, 1151 ) ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( halloween_shackles ), 125, Utility.Random( 1,3 ), 5696, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( halloween_ruined_bookcase ), 340, Utility.Random( 1,3 ), 0x0C14, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( halloween_covered_chair ), 220, Utility.Random( 1,3 ), 3095, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( halloween_HauntedMirror1 ), 270, Utility.Random( 1,3 ), 10875, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( halloween_HauntedMirror2 ), 270, Utility.Random( 1,3 ), 10876, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( halloween_devil_face ), 150, Utility.Random( 1,3 ), 4348, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 5){ Add( new GenericBuyInfo( typeof( PackedCostume ), 230, Utility.Random( 1,3 ), 0x46A3, 0x5E0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 5){ Add( new GenericBuyInfo( typeof( WrappedCandy ), 20, Utility.Random( 1,3 ), 0x469E, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 5){ Add( new GenericBuyInfo( typeof( HalloweenPack ), 130, Utility.Random( 1,3 ), 0x46A3, 0x5E0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( NecromancerTable ), 520, Utility.Random( 1,3 ), 0x149D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( NecromancerBanner ), 350, Utility.Random( 1,3 ), 0x149B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( BurningScarecrowA ), 290, Utility.Random( 1,3 ), 0x23A9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GothicCandelabraA ), 280, Utility.Random( 1,3 ), 0x052D, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBNecroGuild : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBNecroGuild()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( BatWing ), 3, Utility.Random( 30,310 ), 0xF78, 0 ) );
				Add( new GenericBuyInfo( typeof( DaemonBlood ), 6, Utility.Random( 30,310 ), 0xF7D, 0 ) );
				Add( new GenericBuyInfo( typeof( PigIron ), 5, Utility.Random( 30,310 ), 0xF8A, 0 ) );
				Add( new GenericBuyInfo( typeof( NoxCrystal ), 6, Utility.Random( 30,310 ), 0xF8E, 0 ) );
				Add( new GenericBuyInfo( typeof( GraveDust ), 3, Utility.Random( 30,310 ), 0xF8F, 0 ) );
				Add( new GenericBuyInfo( typeof( BloodOathScroll ), 25, Utility.Random( 3,31 ), 0x2263, 0 ) );
				Add( new GenericBuyInfo( typeof( CorpseSkinScroll ), 28, Utility.Random( 3,31 ), 0x2263, 0 ) );
				Add( new GenericBuyInfo( typeof( CurseWeaponScroll ), 12, Utility.Random( 3,31 ), 0x2263, 0 ) );
				Add( new GenericBuyInfo( typeof( PolishBoneBrush ), 12, 10, 0x1371, 0 ) );
				Add( new GenericBuyInfo( typeof( GraveShovel ), 12, Utility.Random( 3,31 ), 0xF39, 0x966 ) );
				Add( new GenericBuyInfo( typeof( SurgeonsKnife ), 14, Utility.Random( 3,31 ), 0xEC4, 0x1B0 ) );
				Add( new GenericBuyInfo( typeof( MixingCauldron ), 247, Utility.Random( 3,31 ), 0x269C, 0 ) );
				Add( new GenericBuyInfo( typeof( MixingSpoon ), 34, Utility.Random( 3,31 ), 0x1E27, 0x979 ) );
				Add( new GenericBuyInfo( typeof( Jar ), 5, Utility.Random( 15,30 ), 0x10B4, 0 ) );
				Add( new GenericBuyInfo( typeof( CBookNecroticAlchemy ), 50, Utility.Random( 3,31 ), 0x2253, 0x4AA ) );
				Add( new GenericBuyInfo( typeof( NecromancerSpellbook ), 115, Utility.Random( 3,31 ), 0x2253, 0 ) );
				Add( new GenericBuyInfo( typeof( TarotDeck ), 5, Utility.Random( 3,31 ), 0x12AB, 0 ) ); 
				Add( new GenericBuyInfo( typeof( AlchemyTub ), 2400, Utility.Random( 1,5 ), 0x126A, 0 ) );
				Add( new GenericBuyInfo( typeof( AlchemyPouch ), Utility.Random( 2900,3500 ), Utility.Random( 1,2 ), 0x1C10, 0x89F ) );
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( BlackDyeTub ), 5000, Utility.Random( 1,1 ), 0xFAB, 0x1 ) ); }
				Add( new GenericBuyInfo( typeof( reagents_magic_jar2 ), 1500, Utility.Random( 30,310 ), 0x1007, 0xB97 ) );
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HellsGateScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0x54F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( ManaLeechScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0xB87 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( NecroCurePoisonScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0x8A2 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( NecroPoisonScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0x4F8 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( NecroUnlockScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0x493 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( PhantasmScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0x6DE ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( RetchedAirScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0xA97 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( SpectreShadowScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0x17E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( UndeadEyesScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0x491 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( VampireGiftScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0xB85 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( WallOfSpikesScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0xB8F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( BloodPactScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0x5B5 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GhostlyImagesScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0xBF ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GhostPhaseScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0x47E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GraveyardGatewayScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0x2EA ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HellsBrandScroll ), Utility.Random( 10,100 ), Utility.Random( 1,3 ), 0x1007, 0x54C ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( BatWing ), 1 );
				Add( typeof( DaemonBlood ), 3 );
				Add( typeof( PigIron ), 2 );
				Add( typeof( NoxCrystal ), 3 );
				Add( typeof( GraveDust ), 1 );
				Add( typeof( ExorcismScroll ), 1 );
				Add( typeof( AnimateDeadScroll ), 26 );
				Add( typeof( BloodOathScroll ), 26 );
				Add( typeof( CorpseSkinScroll ), 26 );
				Add( typeof( CurseWeaponScroll ), 26 );
				Add( typeof( EvilOmenScroll ), 26 );
				Add( typeof( PainSpikeScroll ), 26 );
				Add( typeof( SummonFamiliarScroll ), 26 );
				Add( typeof( HorrificBeastScroll ), 27 );
				Add( typeof( MindRotScroll ), 39 );
				Add( typeof( PoisonStrikeScroll ), 39 );
				Add( typeof( WraithFormScroll ), 51 );
				Add( typeof( LichFormScroll ), 64 );
				Add( typeof( StrangleScroll ), 64 );
				Add( typeof( WitherScroll ), 64 );
				Add( typeof( VampiricEmbraceScroll ), 101 );
				Add( typeof( VengefulSpiritScroll ), 114 );
				Add( typeof( MixingCauldron ), 123 ); 
				Add( typeof( MixingSpoon ), 17 ); 
				Add( typeof( MyNecromancerSpellbook ), 500 );
				Add( typeof( BlackDyeTub ), 2500 ); 
				Add( typeof( PolishBoneBrush ), 6 );
				Add( typeof( PolishedSkull ), 3 );
				Add( typeof( PolishedBone ), 3 );
				Add( typeof( BoneContainer ), Utility.RandomMinMax( 100, 400 ) );
				Add( typeof( CorpseSailor ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( BodyPart ), Utility.RandomMinMax( 30, 90 ) );
				Add( typeof( CorpseChest ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( BuriedBody ), Utility.RandomMinMax( 50, 300 ) );
				Add( typeof( LeftLeg ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RightLeg ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( TastyHeart ), Utility.RandomMinMax( 10, 20 ) );
				Add( typeof( Head ), Utility.RandomMinMax( 10, 20 ) );
				Add( typeof( LeftArm ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RightArm ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Torso ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Bone ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( RibCage ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( BonePile ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( Bones ), Utility.RandomMinMax( 5, 10 ) );
				Add( typeof( GraveChest ), Utility.RandomMinMax( 100, 500 ) );
				Add( typeof( SkullMinotaur ), Utility.Random( 50,150 ) );
				Add( typeof( SkullWyrm ), Utility.Random( 200,400 ) );
				Add( typeof( SkullGreatDragon ), Utility.Random( 300,600 ) );
				Add( typeof( SkullDragon ), Utility.Random( 100,300 ) );
				Add( typeof( SkullDemon ), Utility.Random( 100,300 ) );
				Add( typeof( SkullGiant ), Utility.Random( 100,300 ) );
				Add( typeof( AlchemyTub ), Utility.Random( 200, 500 ) );
				Add( typeof( WoodenCoffin ), 25 );
				Add( typeof( WoodenCasket ), 25 );
				Add( typeof( StoneCoffin ), 45 );
				Add( typeof( StoneCasket ), 45 );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBArcherGuild: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBArcherGuild()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( GuildFletching ), 500, Utility.Random( 1,5 ), 0x1EB8, 0x430 ) );
				Add( new GenericBuyInfo( typeof( ArcherQuiver ), 32, Utility.Random( 1,5 ), 0x2B02, 0 ) );
				Add( new GenericBuyInfo( typeof( ManyArrows100 ), 200, Utility.Random( 1,10 ), 0xF41, 0 ) );
				Add( new GenericBuyInfo( typeof( ManyBolts100 ), 200, Utility.Random( 1,10 ), 0x1BFD, 0 ) );
				Add( new GenericBuyInfo( typeof( ManyArrows1000 ), 2000, Utility.Random( 1,10 ), 0xF41, 0 ) );
				Add( new GenericBuyInfo( typeof( ManyBolts1000 ), 2000, Utility.Random( 1,10 ), 0x1BFD, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( ArcherQuiver ), 16 );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBAlchemistGuild : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBAlchemistGuild()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{  
				Add( new GenericBuyInfo( typeof( MortarPestle ), 8, Utility.Random( 3,31 ), 0xE9B, 0 ) );
				Add( new GenericBuyInfo( typeof( MixingCauldron ), 247, Utility.Random( 3,31 ), 0x269C, 0 ) );
				Add( new GenericBuyInfo( typeof( MixingSpoon ), 34, Utility.Random( 3,31 ), 0x1E27, 0x979 ) );
				Add( new GenericBuyInfo( typeof( CBookNecroticAlchemy ), 50, Utility.Random( 3,31 ), 0x2253, 0x4AA ) );
				Add( new GenericBuyInfo( typeof( AlchemicalElixirs ), 50, Utility.Random( 1,15 ), 0x2219, 0 ) );
				Add( new GenericBuyInfo( typeof( AlchemicalMixtures ), 50, Utility.Random( 1,15 ), 0x2223, 0 ) );
				Add( new GenericBuyInfo( typeof( BookOfPoisons ), 50, Utility.Random( 1,15 ), 0x2253, 0x4F8 ) );

				Add( new GenericBuyInfo( typeof( Bottle ), 5, Utility.Random( 3,31 ), 0xF0E, 0 ) ); 
				Add( new GenericBuyInfo( typeof( Jar ), 5, Utility.Random( 15,30 ), 0x10B4, 0 ) );
				Add( new GenericBuyInfo( typeof( HeatingStand ), 2, Utility.Random( 1,15 ), 0x1849, 0 ) ); 

				Add( new GenericBuyInfo( typeof( BlackPearl ), 5, Utility.Random( 30,310 ), 0x266F, 0 ) );
				Add( new GenericBuyInfo( typeof( Bloodmoss ), 5, Utility.Random( 30,310 ), 0xF7B, 0 ) );
				Add( new GenericBuyInfo( typeof( Garlic ), 3, Utility.Random( 30,310 ), 0xF84, 0 ) );
				Add( new GenericBuyInfo( typeof( Ginseng ), 3, Utility.Random( 30,310 ), 0xF85, 0 ) );
				Add( new GenericBuyInfo( typeof( MandrakeRoot ), 3, Utility.Random( 30,310 ), 0xF86, 0 ) );
				Add( new GenericBuyInfo( typeof( Nightshade ), 3, Utility.Random( 30,310 ), 0xF88, 0 ) );
				Add( new GenericBuyInfo( typeof( SpidersSilk ), 3, Utility.Random( 30,310 ), 0xF8D, 0 ) );
				Add( new GenericBuyInfo( typeof( SulfurousAsh ), 3, Utility.Random( 30,310 ), 0xF8C, 0 ) );

				Add( new GenericBuyInfo( typeof( Brimstone ), 6, Utility.Random( 30,310 ), 0x2FD3, 0 ) );
				Add( new GenericBuyInfo( typeof( ButterflyWings ), 6, Utility.Random( 30,310 ), 0x3002, 0 ) );
				Add( new GenericBuyInfo( typeof( EyeOfToad ), 6, Utility.Random( 30,310 ), 0x2FDA, 0 ) );
				Add( new GenericBuyInfo( typeof( FairyEgg ), 6, Utility.Random( 30,310 ), 0x2FDB, 0 ) );
				Add( new GenericBuyInfo( typeof( GargoyleEar ), 6, Utility.Random( 30,310 ), 0x2FD9, 0 ) );
				Add( new GenericBuyInfo( typeof( BeetleShell ), 6, Utility.Random( 30,310 ), 0x2FF8, 0 ) );
				Add( new GenericBuyInfo( typeof( MoonCrystal ), 6, Utility.Random( 30,310 ), 0x3003, 0 ) );
				Add( new GenericBuyInfo( typeof( PixieSkull ), 6, Utility.Random( 30,310 ), 0x2FE1, 0 ) );
				Add( new GenericBuyInfo( typeof( RedLotus ), 6, Utility.Random( 30,310 ), 0x2FE8, 0 ) );
				Add( new GenericBuyInfo( typeof( SeaSalt ), 6, Utility.Random( 30,310 ), 0x2FE9, 0 ) );
				Add( new GenericBuyInfo( typeof( SilverWidow ), 6, Utility.Random( 30,310 ), 0x2FF7, 0 ) );
				Add( new GenericBuyInfo( typeof( SwampBerries ), 6, Utility.Random( 30,310 ), 0x2FE0, 0 ) );

				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( reagents_magic_jar1 ), 2000, Utility.Random( 3,31 ), 0x1007, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( reagents_magic_jar3 ), 5000, Utility.Random( 30,310 ), 0x1007, 0x488 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( BottleOfAcid ), 600, Utility.Random( 3,21 ), 0x180F, 1167 ) ); }

				Add( new GenericBuyInfo( typeof( RefreshPotion ), 15, Utility.Random( 10,25 ), 0xF0B, 0 ) );
				Add( new GenericBuyInfo( typeof( AgilityPotion ), 15, Utility.Random( 10,25 ), 0xF08, 0 ) );
				Add( new GenericBuyInfo( typeof( NightSightPotion ), 15, Utility.Random( 10,25 ), 0xF06, 0 ) );
				Add( new GenericBuyInfo( typeof( LesserHealPotion ), 15, Utility.Random( 10,25 ), 0x25FD, 0 ) );
				Add( new GenericBuyInfo( typeof( StrengthPotion ), 15, Utility.Random( 10,25 ), 0xF09, 0 ) );
				Add( new GenericBuyInfo( typeof( LesserPoisonPotion ), 15, Utility.Random( 10,25 ), 0x2600, 0 ) );
 				Add( new GenericBuyInfo( typeof( LesserCurePotion ), 15, Utility.Random( 10,25 ), 0x233B, 0 ) );
				Add( new GenericBuyInfo( typeof( LesserExplosionPotion ), 21, Utility.Random( 10,25 ), 0x2407, 0 ) );

				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( HealPotion ), 30, Utility.Random( 1,15 ), 0xF0C, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( PoisonPotion ), 30, Utility.Random( 1,15 ), 0xF0A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( CurePotion ), 30, Utility.Random( 1,15 ), 0xF07, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( ExplosionPotion ), 42, Utility.Random( 1,15 ), 0xF0D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( ConflagrationPotion ), 30, Utility.Random( 1,15 ), 0x180F, 0x489 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( ConfusionBlastPotion ), 30, Utility.Random( 1,15 ), 0x180F, 0x48D ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( FrostbitePotion ), 30, Utility.Random( 1,15 ), 0x180F, 0xAF3 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( TotalRefreshPotion ), 30, Utility.Random( 1,15 ), 0x25FF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GreaterAgilityPotion ), 60, Utility.Random( 1,15 ), 0x256A, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GreaterConflagrationPotion ), 60, Utility.Random( 1,15 ), 0x2406, 0x489 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GreaterConfusionBlastPotion ), 60, Utility.Random( 1,15 ), 0x2406, 0x48D ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GreaterCurePotion ), 60, Utility.Random( 1,15 ), 0x24EA, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GreaterExplosionPotion ), 60, Utility.Random( 1,15 ), 0x2408, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GreaterFrostbitePotion ), 60, Utility.Random( 1,15 ), 0x2406, 0xAF3 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GreaterHealPotion ), 60, Utility.Random( 1,15 ), 0x25FE, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GreaterPoisonPotion ), 60, Utility.Random( 1,15 ), 0x2601, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GreaterStrengthPotion ), 60, Utility.Random( 1,15 ), 0x25F7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( DeadlyPoisonPotion ), 60, Utility.Random( 1,15 ), 0x2669, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( LesserInvisibilityPotion ), 860, Utility.Random( 1,3 ), 0x23BD, 0x490 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( LesserManaPotion ), 860, Utility.Random( 1,3 ), 0x23BD, 0x48D ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( LesserRejuvenatePotion ), 860, Utility.Random( 1,3 ), 0x23BD, 0x48E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( InvisibilityPotion ), 890, Utility.Random( 1,3 ), 0x180F, 0x490 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( ManaPotion ), 890, Utility.Random( 1,3 ), 0x180F, 0x48D ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( RejuvenatePotion ), 890, Utility.Random( 1,3 ), 0x180F, 0x48E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GreaterInvisibilityPotion ), 8120, 1, 0x2406, 0x490 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GreaterManaPotion ), 8120, 1, 0x2406, 0x48D ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GreaterRejuvenatePotion ), 8120, 1, 0x2406, 0x48E ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( InvulnerabilityPotion ), 8300, 1, 0x180F, 0x48F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( AutoResPotion ), 8600, 1, 0xF04, 0 ) ); }
				Add( new GenericBuyInfo( typeof( AlchemyTub ), 2400, Utility.Random( 1,5 ), 0x126A, 0 ) );
				Add( new GenericBuyInfo( typeof( AlchemyPouch ), Utility.Random( 2900,3500 ), Utility.Random( 1,2 ), 0x1C10, 0x89F ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( SkullMinotaur ), Utility.Random( 50,150 ) );
				Add( typeof( SkullWyrm ), Utility.Random( 200,400 ) );
				Add( typeof( SkullGreatDragon ), Utility.Random( 300,600 ) );
				Add( typeof( SkullDragon ), Utility.Random( 100,300 ) );
				Add( typeof( SkullDemon ), Utility.Random( 100,300 ) );
				Add( typeof( SkullGiant ), Utility.Random( 100,300 ) );
				Add( typeof( CanopicJar ), Utility.Random( 50,300 ) );
				Add( typeof( MixingCauldron ), 123 );
				Add( typeof( MixingSpoon ), 17 );
				Add( typeof( DragonTooth ), 120 );
				Add( typeof( EnchantedSeaweed ), 120 );
				Add( typeof( GhostlyDust ), 120 );
				Add( typeof( GoldenSerpentVenom ), 120 );
				Add( typeof( LichDust ), 120 );
				Add( typeof( SilverSerpentVenom ), 120 );
				Add( typeof( UnicornHorn ), 120 );
				Add( typeof( DemigodBlood ), 120 );
				Add( typeof( DemonClaw ), 120 );
				Add( typeof( DragonBlood ), 120 );
				Add( typeof( BlackPearl ), 3 );
				Add( typeof( Bloodmoss ), 3 );
				Add( typeof( MandrakeRoot ), 2 );
				Add( typeof( Garlic ), 2 );
				Add( typeof( Ginseng ), 2 );
				Add( typeof( Nightshade ), 2 );
				Add( typeof( SpidersSilk ), 2 );
				Add( typeof( SulfurousAsh ), 1 );
				Add( typeof( Brimstone ), 3 );
				Add( typeof( ButterflyWings ), 3 );
				Add( typeof( EyeOfToad ), 3 );
				Add( typeof( FairyEgg ), 3 );
				Add( typeof( GargoyleEar ), 3 );
				Add( typeof( BeetleShell ), 3 );
				Add( typeof( MoonCrystal ), 3 );
				Add( typeof( PixieSkull ), 3 );
				Add( typeof( RedLotus ), 3 );
				Add( typeof( SeaSalt ), 3 );
				Add( typeof( SilverWidow ), 3 );
				Add( typeof( SwampBerries ), 3 );
				Add( typeof( Bottle ), 3 );
				Add( typeof( Jar ), 3 );
				Add( typeof( MortarPestle ), 4 );
				Add( typeof( AgilityPotion ), 7 );
				Add( typeof( AutoResPotion ), 94 );
				Add( typeof( BottleOfAcid ), 32 );
				Add( typeof( ConflagrationPotion ), 7 );
				Add( typeof( FrostbitePotion ), 7 );
				Add( typeof( ConfusionBlastPotion ), 7 );
				Add( typeof( CurePotion ), 14 );
				Add( typeof( DeadlyPoisonPotion ), 28 );
				Add( typeof( ExplosionPotion ), 14 );
				Add( typeof( GreaterAgilityPotion ), 28 );
				Add( typeof( GreaterConflagrationPotion ), 28 );
				Add( typeof( GreaterFrostbitePotion ), 28 );
				Add( typeof( GreaterConfusionBlastPotion ), 28 );
				Add( typeof( GreaterCurePotion ), 28 );
				Add( typeof( GreaterExplosionPotion ), 28 );
				Add( typeof( GreaterHealPotion ), 28 );
				Add( typeof( GreaterInvisibilityPotion ), 28 );
				Add( typeof( GreaterManaPotion ), 28 );
				Add( typeof( GreaterPoisonPotion ), 28 );
				Add( typeof( GreaterRejuvenatePotion ), 28 );
				Add( typeof( GreaterStrengthPotion ), 28 );
				Add( typeof( HealPotion ), 14 );
				Add( typeof( InvisibilityPotion ), 14 );
				Add( typeof( InvulnerabilityPotion ), 53 );
				Add( typeof( LesserCurePotion ), 7 );
				Add( typeof( LesserExplosionPotion ), 7 );
				Add( typeof( LesserHealPotion ), 7 );
				Add( typeof( LesserInvisibilityPotion ), 7 );
				Add( typeof( LesserManaPotion ), 7 );
				Add( typeof( LesserPoisonPotion ), 7 );
				Add( typeof( LesserRejuvenatePotion ), 7 );
				Add( typeof( ManaPotion ), 14 );
				Add( typeof( NightSightPotion ), 14 );
				Add( typeof( PoisonPotion ), 14 );
				Add( typeof( RefreshPotion ), 14 );
				Add( typeof( RejuvenatePotion ), 28 );
				Add( typeof( StrengthPotion ), 14 );
				Add( typeof( TotalRefreshPotion ), 28 );
				Add( typeof( BottleOfParts ), Utility.Random( 10, 30 ) );
				Add( typeof( SpecialSeaweed ), Utility.Random( 20, 40 ) );
				Add( typeof( AlchemyTub ), Utility.Random( 200, 500 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBLibraryGuild: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBLibraryGuild()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( LoreGuidetoAdventure ), 5, Utility.Random( 5,15 ), 0x1C11, 0 ) );
				Add( new GenericBuyInfo( typeof( WeaponAbilityBook ), 5, Utility.Random( 1,15 ), 0x2254, 0 ) );
				Add( new GenericBuyInfo( typeof( LearnLeatherBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) );
				Add( new GenericBuyInfo( typeof( LearnMiscBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) );
				Add( new GenericBuyInfo( typeof( LearnMetalBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) );
				Add( new GenericBuyInfo( typeof( LearnWoodBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) );
				Add( new GenericBuyInfo( typeof( LearnReagentsBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) );
				Add( new GenericBuyInfo( typeof( LearnTailorBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) );
				Add( new GenericBuyInfo( typeof( LearnGraniteBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) );
				Add( new GenericBuyInfo( typeof( LearnScalesBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) );
				Add( new GenericBuyInfo( typeof( LearnTailorBook ), 5, Utility.Random( 1,15 ), 0x2D9F, 0 ) );
				Add( new GenericBuyInfo( typeof( CBookDruidicHerbalism ), 50, Utility.Random( 1,15 ), 0x2D50, 0 ) );
				Add( new GenericBuyInfo( typeof( CBookNecroticAlchemy ), 50, Utility.Random( 1,15 ), 0x2253, 0x4AA ) );
				Add( new GenericBuyInfo( typeof( AlchemicalElixirs ), 50, Utility.Random( 1,15 ), 0x2219, 0 ) );
				Add( new GenericBuyInfo( typeof( AlchemicalMixtures ), 50, Utility.Random( 1,15 ), 0x2223, 0 ) );
				Add( new GenericBuyInfo( typeof( BookOfPoisons ), 50, Utility.Random( 1,15 ), 0x2253, 0x4F8 ) );
				Add( new GenericBuyInfo( typeof( WorkShoppes ), 50, Utility.Random( 1,15 ), 0x2259, 0xB50 ) );
				Add( new GenericBuyInfo( typeof( LearnTitles ), 5, Utility.Random( 1,15 ), 0xFF2, 0 ) );
				Add( new GenericBuyInfo( typeof( ScribesPen ), 8, Utility.Random( 3,31 ), 0x2051, 0 ) );
				Add( new GenericBuyInfo( typeof( BlankScroll ), 5, Utility.Random( 30,310 ), 0x0E34, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) >= 90){ Add( new GenericBuyInfo( "1041267", typeof( Runebook ), 3500, Utility.Random( 1,3 ), 0x0F3D, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( ScribesPen ), 4 );
				Add( typeof( BlankScroll ), 3 );
				Add( typeof( DynamicBook ), Utility.Random( 10,150 ) );
				Add( typeof( TomeOfWands ), Utility.Random( 100,400 ) );
				Add( typeof( JokeBook ), Utility.Random( 750,1500 ) );
				Add( typeof( DataPad ), Utility.Random( 5, 150 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBDruidGuild : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBDruidGuild()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( Bandage ), 5, Utility.Random( 300,310 ), 0xE21, 0 ) );
				Add( new GenericBuyInfo( typeof( LesserHealPotion ), 15, Utility.Random( 3,31 ), 0x25FD, 0 ) );
				Add( new GenericBuyInfo( typeof( Ginseng ), 3, Utility.Random( 3,31 ), 0xF85, 0 ) );
				Add( new GenericBuyInfo( typeof( Garlic ), 3, Utility.Random( 3,31 ), 0xF84, 0 ) );
				Add( new GenericBuyInfo( typeof( RefreshPotion ), 15, Utility.Random( 3,31 ), 0xF0B, 0 ) );
				Add( new GenericBuyInfo( typeof( GardenTool ), 12, Utility.Random( 3,31 ), 0xDFD, 0x84F ) );
				Add( new GenericBuyInfo( typeof( HerbalistCauldron ), 247, Utility.Random( 3,31 ), 0x2676, 0 ) );
				Add( new GenericBuyInfo( typeof( MixingSpoon ), 34, Utility.Random( 3,31 ), 0x1E27, 0x979 ) );
				Add( new GenericBuyInfo( typeof( CBookDruidicHerbalism ), 50, Utility.Random( 1,15 ), 0x2D50, 0 ) );
				Add( new GenericBuyInfo( typeof( AlchemyTub ), 2400, Utility.Random( 1,5 ), 0x126A, 0 ) );
				Add( new GenericBuyInfo( typeof( AlchemyPouch ), Utility.Random( 2900,3500 ), Utility.Random( 1,2 ), 0x1C10, 0x89F ) );
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( AppleTreeDeed ), 640, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( CherryBlossomTreeDeed ), 540, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( DarkBrownTreeDeed ), 540, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( GreyTreeDeed ), 540, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( LightBrownTreeDeed ), 540, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( PeachTreeDeed ), 640, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) >= 50){ Add( new GenericBuyInfo( typeof( PearTreeDeed ), 640, Utility.Random( 1,2 ), 0x14F0, 0 ) ); }
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( LesserHealPotion ), 7 );
				Add( typeof( RefreshPotion ), 7 );
				Add( typeof( Garlic ), 2 );
				Add( typeof( Ginseng ), 2 );
				Add( typeof( GardenTool ), 6 );
				Add( typeof( HerbalistCauldron ), 123 );
				Add( typeof( MixingSpoon ), 17 );
				Add( typeof( AlchemyTub ), Utility.Random( 200, 500 ) );
				Add( typeof( FirstAidKit ), Utility.Random( 100,250 ) );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBCarpenterGuild: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBCarpenterGuild()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( Hatchet ), 20, Utility.Random( 1,15 ), 0xF44, 0 ) );
				Add( new GenericBuyInfo( typeof( LumberAxe ), 22, Utility.Random( 1,15 ), 0xF43, 0x96D ) );
				Add( new GenericBuyInfo( typeof( GuildCarpentry ), 500, Utility.Random( 1,5 ), 0x1EBA, 0x430 ) );
				Add( new GenericBuyInfo( typeof( Nails ), 3, Utility.Random( 3,31 ), 0x102E, 0 ) );
				Add( new GenericBuyInfo( typeof( Axle ), 2, Utility.Random( 3,31 ), 0x105B, 0 ) );
				Add( new GenericBuyInfo( typeof( Board ), 3, Utility.Random( 3,31 ), 0x1BD7, 0 ) );
				Add( new GenericBuyInfo( typeof( DrawKnife ), 10, Utility.Random( 3,31 ), 0x10E4, 0 ) );
				Add( new GenericBuyInfo( typeof( Froe ), 10, Utility.Random( 3,31 ), 0x10E5, 0 ) );
				Add( new GenericBuyInfo( typeof( Scorp ), 10, Utility.Random( 3,31 ), 0x10E7, 0 ) );
				Add( new GenericBuyInfo( typeof( Inshave ), 10, Utility.Random( 3,31 ), 0x10E6, 0 ) );
				Add( new GenericBuyInfo( typeof( DovetailSaw ), 12, Utility.Random( 3,31 ), 0x1028, 0 ) );
				Add( new GenericBuyInfo( typeof( Saw ), 15, Utility.Random( 3,31 ), 0x1034, 0 ) );
				Add( new GenericBuyInfo( typeof( Hammer ), 17, Utility.Random( 3,31 ), 0x102A, 0 ) );
				Add( new GenericBuyInfo( typeof( MouldingPlane ), 11, Utility.Random( 3,31 ), 0x102C, 0 ) );
				Add( new GenericBuyInfo( typeof( SmoothingPlane ), 10, Utility.Random( 3,31 ), 0x1032, 0 ) );
				Add( new GenericBuyInfo( typeof( JointingPlane ), 11, Utility.Random( 3,31 ), 0x1030, 0 ) );
				Add( new GenericBuyInfo( "Toy Maker's Kit", typeof( ToyMakersKit ), 50, 20, 0xF27, 0x5E2 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C43, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C45, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C47, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C89, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x38B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x38D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireG ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CC9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireH ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CCB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireI ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CCD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmoireJ ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D26, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmorShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3BF1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmorShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C31, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmorShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C63, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmorShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CAD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewArmorShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CEF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBakerShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C3B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBakerShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C65, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBakerShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C67, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBakerShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CBF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBakerShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CC1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBakerShelfF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CF1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBakerShelfG ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBlacksmithShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C41, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBlacksmithShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C4B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBlacksmithShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C6B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBlacksmithShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CC5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBlacksmithShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CF7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C15, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C2B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C2D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C33, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C5F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C61, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfG ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C79, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfH ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CA5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfI ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CA7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfJ ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CAF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfK ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CEB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfL ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CED, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBookShelfM ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D05, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBowyerShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C29, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBowyerShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C5D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBowyerShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CA3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewBowyerShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CE9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewCarpenterShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C6F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewCarpenterShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CD7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewCarpenterShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CFB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C51, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C53, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C75, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C77, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CDD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CDF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfG ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CFF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewClothShelfH ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D01, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDarkBookShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3BF9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDarkBookShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3BFB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDarkShelf ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3BFD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C7F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C81, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C83, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C85, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C87, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CB5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersG ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CB7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersH ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CB9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersI ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CBB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersJ ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CBD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersK ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D0B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersL ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D20, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersM ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D22, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrawersN ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D24, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrinkShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C27, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrinkShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C5B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrinkShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CA1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrinkShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CE7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewDrinkShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C1B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewHelmShelf ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3BFF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewHunterShelf ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C4D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewKitchenShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C19, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewKitchenShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C39, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewOldBookShelf ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x19FF, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewPotionShelf ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3BF3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewRuinedBookShelf ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0xC14, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C35, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C3D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C69, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C7B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CB1, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CC3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfG ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CF5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShelfH ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D07, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShoeShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C37, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShoeShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C7D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShoeShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CB3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewShoeShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D09, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewSorcererShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C4F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewSorcererShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C73, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewSorcererShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CDB, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewSorcererShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CFD, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewSupplyShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C57, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewSupplyShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C9D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewSupplyShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CE3, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTailorShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C3F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTailorShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C6D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTailorShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CC7, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTailorShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CF9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTannerShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C23, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTannerShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C49, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTavernShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C25, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTavernShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C59, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTavernShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C9F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTavernShelfF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CE5, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTinkerShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C71, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTinkerShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CD9, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTinkerShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3D03, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewTortureShelf ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C2F, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewWizardShelfA ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C17, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewWizardShelfB ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C1D, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewWizardShelfC ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C21, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewWizardShelfD ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C55, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewWizardShelfE ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3C9B, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 90){Add( new GenericBuyInfo( typeof( NewWizardShelfF ), Utility.Random( 200,400 ), Utility.Random( 1,5 ), 0x3CE1, 0 ) ); }
				
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( Hatchet ), 15 );
				Add( typeof( LumberAxe ), 16 );
				Add( typeof( WoodenBox ), 7 );
				Add( typeof( SmallCrate ), 5 );
				Add( typeof( MediumCrate ), 6 );
				Add( typeof( LargeCrate ), 7 );
				Add( typeof( WoodenChest ), 15 );
				Add( typeof( LargeTable ), 10 );
				Add( typeof( Nightstand ), 7 );
				Add( typeof( YewWoodTable ), 10 );
				Add( typeof( Throne ), 24 );
				Add( typeof( WoodenThrone ), 6 );
				Add( typeof( Stool ), 6 );
				Add( typeof( FootStool ), 6 );
				Add( typeof( FancyWoodenChairCushion ), 12 );
				Add( typeof( WoodenChairCushion ), 10 );
				Add( typeof( WoodenChair ), 8 );
				Add( typeof( BambooChair ), 6 );
				Add( typeof( WoodenBench ), 6 );
				Add( typeof( Saw ), 9 );
				Add( typeof( Scorp ), 6 );
				Add( typeof( SmoothingPlane ), 6 );
				Add( typeof( DrawKnife ), 6 );
				Add( typeof( Froe ), 6 );
				Add( typeof( Hammer ), 14 );
				Add( typeof( Inshave ), 6 );
				Add( typeof( JointingPlane ), 6 );
				Add( typeof( MouldingPlane ), 6 );
				Add( typeof( DovetailSaw ), 7 );
				Add( typeof( Axle ), 1 );
				Add( typeof( Club ), 13 );

				Add( typeof( Log ), 1 );
				Add( typeof( AshLog ), 2 );
				Add( typeof( CherryLog ), 2 );
				Add( typeof( EbonyLog ), 3 );
				Add( typeof( GoldenOakLog ), 3 );
				Add( typeof( HickoryLog ), 4 );
				Add( typeof( MahoganyLog ), 4 );
				Add( typeof( DriftwoodLog ), 4 );
				Add( typeof( OakLog ), 5 );
				Add( typeof( PineLog ), 5 );
				Add( typeof( GhostLog ), 5 );
				Add( typeof( RosewoodLog ), 6 );
				Add( typeof( WalnutLog ), 6 );
				Add( typeof( ElvenLog ), 12 );
				Add( typeof( PetrifiedLog ), 7 );

				Add( typeof( Board ), 2 );
				Add( typeof( AshBoard ), 3 );
				Add( typeof( CherryBoard ), 3 );
				Add( typeof( EbonyBoard ), 4 );
				Add( typeof( GoldenOakBoard ), 4 );
				Add( typeof( HickoryBoard ), 5 );
				Add( typeof( MahoganyBoard ), 5 );
				Add( typeof( DriftwoodBoard ), 5 );
				Add( typeof( OakBoard ), 6 );
				Add( typeof( PineBoard ), 6 );
				Add( typeof( GhostBoard ), 6 );
				Add( typeof( RosewoodBoard ), 7 );
				Add( typeof( WalnutBoard ), 7 );
				Add( typeof( ElvenBoard ), 14 );
				Add( typeof( PetrifiedBoard ), 8 );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBAssassin : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBAssassin()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( LesserPoisonPotion ), 15, Utility.Random( 10,50 ), 0x2600, 0 ) );
				Add( new GenericBuyInfo( typeof( PoisonPotion ), 30, Utility.Random( 10,50 ), 0xF0A, 0 ) );
				Add( new GenericBuyInfo( typeof( GreaterPoisonPotion ), 60, Utility.Random( 10,50 ), 0x2601, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DeadlyPoisonPotion ), 120, Utility.Random( 1,15 ), 0x2669, 0 ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 75){Add( new GenericBuyInfo( typeof( LethalPoisonPotion ), 320, Utility.Random( 1,15 ), 0x266A, 0 ) ); }
				Add( new GenericBuyInfo( typeof( Nightshade ), 4, Utility.Random( 30,310 ), 0xF88, 0 ) );
				Add( new GenericBuyInfo( typeof( Dagger ), 21, Utility.Random( 10,50 ), 0xF52, 0 ) );
				Add( new GenericBuyInfo( "1041060", typeof( HairDye ), 100, Utility.Random( 1,15 ), 0xEFF, 0 ) );
				Add( new GenericBuyInfo( "hair dye bottle", typeof( HairDyeBottle ), 1000, Utility.Random( 1,15 ), 0xE0F, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 25){Add( new GenericBuyInfo( typeof( DisguiseKit ), 700, Utility.Random( 1,5 ), 0xE05, 0 ) ); }
				Add( new GenericBuyInfo( typeof( AssassinRobe ), 38, Utility.Random( 1,10 ), 0x2B69, 0 ) );
				Add( new GenericBuyInfo( typeof( BookOfPoisons ), 50, Utility.Random( 1,15 ), 0x2253, 0x4F8 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( LesserPoisonPotion ), 7 );
				Add( typeof( PoisonPotion ), 14 );
				Add( typeof( GreaterPoisonPotion ), 28 );
				Add( typeof( DeadlyPoisonPotion ), 56 );
				Add( typeof( LethalPoisonPotion ), 128 );
				Add( typeof( Nightshade ), 2 );
				Add( typeof( Dagger ), 10 );
				Add( typeof( HairDye ), 50 );
				Add( typeof( HairDyeBottle ), 300 );
				Add( typeof( SilverSerpentVenom ), 140 );
				Add( typeof( GoldenSerpentVenom ), 210 );
				Add( typeof( AssassinRobe ), 19 );
			}
		}
	}
	///////////////////////////////////////////////////////////////////////////////////////////////////////////
	public class SBCartographer : SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBCartographer()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( BlankMap ), 5, Utility.Random( 3,31 ), 0x14EC, 0 ) );
				Add( new GenericBuyInfo( typeof( MapmakersPen ), 8, Utility.Random( 3,31 ), 0x2052, 0 ) );
				Add( new GenericBuyInfo( typeof( BlankScroll ), 12, Utility.Random( 30,310 ), 0xEF3, 0 ) );
				Add( new GenericBuyInfo( typeof( MasterSkeletonsKey ), Utility.Random( 100,500 ), Utility.Random( 3,5 ), 0x410B, 0 ) );
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				Add( typeof( BlankScroll ), 6 );
				Add( typeof( MapmakersPen ), 4 );
				Add( typeof( BlankMap ), 2 );
				Add( typeof( CityMap ), 3 );
				Add( typeof( LocalMap ), 3 );
				Add( typeof( WorldMap ), 3 );
				Add( typeof( PresetMapEntry ), 3 );
				Add( typeof( WorldMapLodor ), Utility.Random( 10,150 ) );
				Add( typeof( WorldMapSosaria ), Utility.Random( 10,150 ) );
				Add( typeof( WorldMapBottle ), Utility.Random( 10,150 ) );
				Add( typeof( WorldMapSerpent ), Utility.Random( 10,150 ) );
				Add( typeof( WorldMapUmber ), Utility.Random( 10,150 ) );
				Add( typeof( WorldMapAmbrosia ), Utility.Random( 10,150 ) );
				Add( typeof( WorldMapIslesOfDread ), Utility.Random( 10,150 ) );
				Add( typeof( WorldMapSavage ), Utility.Random( 10,150 ) );
				Add( typeof( WorldMapUnderworld ), Utility.Random( 20,300 ) );
			}
		}
	}
}
