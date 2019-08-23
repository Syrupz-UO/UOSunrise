using System;
using System.Collections.Generic;
using Server;
using Server.Items;
using System.Collections;
using Server.Multis;
using Server.Guilds;

namespace Server.Mobiles
{
	public class KungFu : BaseVendor
	{
		private List<SBInfo> m_SBInfos = new List<SBInfo>();
		protected override List<SBInfo> SBInfos{ get { return m_SBInfos; } }
		
		[Constructable]
		public KungFu() : base( "the Monk" )
		{
			SetSkill( SkillName.Bushido, 64.0, 85.0 );
			SetSkill( SkillName.Fencing, 64.0, 80.0 );
			SetSkill( SkillName.Macing, 64.0, 80.0 );
			SetSkill( SkillName.Ninjitsu, 60.0, 80.0 );
			SetSkill( SkillName.Parry, 64.0, 80.0 );
			SetSkill( SkillName.Tactics, 64.0, 85.0 );
			SetSkill( SkillName.Swords, 64.0, 85.0 );
		}
		
		public override void InitSBInfo()
		{
			m_SBInfos.Add( new SBKungFu() ); 
			m_SBInfos.Add( new SBBuyArtifacts() );
		}
		public override void InitOutfit()
		{
			AddItem( new Sandals() );
			AddItem( new Robe(Utility.RandomYellowHue()) );
		}

		public KungFu( Serial serial ) : base( serial )
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
	public class SBKungFu: SBInfo
	{
		private List<GenericBuyInfo> m_BuyInfo = new InternalBuyInfo();
		private IShopSellInfo m_SellInfo = new InternalSellInfo();

		public SBKungFu()
		{
		}

		public override IShopSellInfo SellInfo { get { return m_SellInfo; } }
		public override List<GenericBuyInfo> BuyInfo { get { return m_BuyInfo; } }

		public class InternalBuyInfo : List<GenericBuyInfo>
		{
			public InternalBuyInfo()
			{
				Add( new GenericBuyInfo( typeof( BookOfBushido), 140, 20, 0x238C, 0 ) );
				Add( new GenericBuyInfo( typeof( BookOfNinjitsu ), 140, 20, 0x23A0, 0 ) );
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateHatsuburi ), 76, 20, 0x2775, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( HeavyPlateJingasa ), 76, 20, 0x2777, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( DecorativePlateKabuto ), 95, 20, 0x2778, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateDo ), 310, 20, 0x277D, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateHiroSode ), 222, 20, 0x2780, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateSuneate ), 224, 20, 0x2788, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( PlateHaidate ), 235, 20, 0x278D, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ChainHatsuburi ), 76, 20, 0x2774, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Yumi ), 53, 20, 0x27A5, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Fukiya ), 20, 20, 0x27AA, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Nunchaku ), 35, 20, 0x27AE, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( FukiyaDarts ), 3, 20, 0x2806, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bokuto ), 21, 20, 0x27A8, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Bokuto ), 21, 20, 0x27A8, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Tetsubo ), 43, 20, 0x27A6, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BambooFlute ), 21, 20, 0x2805, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( BambooFlute ), 21, 20, 0x2805, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherJingasa ), 11, 20, 0x2776, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherDo ), 87, 20, 0x277B, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherHiroSode ), 49, 20, 0x277E, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherSuneate ), 55, 20, 0x2786, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherHaidate), 54, 20, 0x278A, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherNinjaPants ), 49, 20, 0x2791, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherNinjaJacket ), 51, 20, 0x2793, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedMempo ), 61, 20, 0x279D, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedDo ), 130, 20, 0x277C, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedHiroSode ), 73, 20, 0x277F, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedSuneate ), 78, 20, 0x2787, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( StuddedHaidate ), 76, 20, 0x278B, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( NoDachi ), 82, 20, 0x27A2, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Tessen ), 83, 20, 0x27A3, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Wakizashi ), 38, 20, 0x27A4, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Lajatang ), 108, 20, 0x27A7, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Daisho ), 66, 20, 0x27A9, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Tekagi ), 55, 20, 0x27AB, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Shuriken ), 18, 20, 0x27AC, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Kama ), 61, 20, 0x27AD, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Sai ), 56, 20, 0x27AF, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( Kasa ), 31, 20, 0x2798, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ThrowingWeapon ), 2, Utility.Random( 20, 90 ), 0xF8F, 0x83F ) ); }
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( LeatherJingasa ), 11, 20, 0x2776, 0 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 50){Add( new GenericBuyInfo( typeof( ClothNinjaHood ), 33, 20, 0x278F, 0 ) );}
			}
		}

		public class InternalSellInfo : GenericSellInfo
		{
			public InternalSellInfo()
			{
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MySamuraibook ), Utility.Random( 50, 200 ) );}
				if (Utility.RandomMinMax( 1, 100 ) > 54){Add( typeof( MyNinjabook ), Utility.Random( 50, 200 ) );}
				Add( typeof( PlateHatsuburi ), 38 );
				Add( typeof( HeavyPlateJingasa ), 38 );
				Add( typeof( DecorativePlateKabuto ), 47 );
				Add( typeof( PlateDo ), 155 );
				Add( typeof( PlateHiroSode ), 111 );
				Add( typeof( PlateSuneate ), 112 );
				Add( typeof( PlateHaidate), 117 );
				Add( typeof( ChainHatsuburi ), 38 );
				Add( typeof( Yumi ), 26 );
				Add( typeof( Fukiya ), 10 );
				Add( typeof( Nunchaku ), 17 );
				Add( typeof( FukiyaDarts ), 1 );
				Add( typeof( Bokuto ), 10 );
				Add( typeof( Tetsubo ), 21 );
				Add( typeof( Fukiya ), 10 );
				Add( typeof( BambooFlute ), 10 );
				Add( typeof( Bokuto ), 10 );
				Add( typeof( LeatherJingasa ), 5 );
				Add( typeof( LeatherDo ), 42 );
				Add( typeof( LeatherHiroSode ), 23 );
				Add( typeof( LeatherSuneate ), 26 );
				Add( typeof( LeatherHaidate), 28 );
				Add( typeof( LeatherNinjaPants ), 25 );
				Add( typeof( LeatherNinjaJacket ), 26 );
				Add( typeof( StuddedMempo ), 28 );
				Add( typeof( StuddedDo ), 66 );
				Add( typeof( StuddedHiroSode ), 32 );
				Add( typeof( StuddedSuneate ), 40 );
				Add( typeof( StuddedHaidate ), 37 );
				Add( typeof( NoDachi ), 41 );
				Add( typeof( Tessen ), 41 );
				Add( typeof( Wakizashi ), 19 );
				Add( typeof( Tetsubo ), 21 );
				Add( typeof( Lajatang ), 54 );
				Add( typeof( Daisho ), 33 );
				Add( typeof( Tekagi ), 22 );
				Add( typeof( Shuriken), 9 );
				Add( typeof( Kama ), 30 );
				Add( typeof( Sai ), 28 );
				Add( typeof( Kasa ), 15 );
				Add( typeof( ThrowingWeapon ), 1 );
				Add( typeof( LeatherJingasa ), 5 );
				Add( typeof( ClothNinjaHood ), 16 );
			}
		}
	}
}