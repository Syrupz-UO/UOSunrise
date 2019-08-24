using System;
using Server.Items;

namespace Server.Engines.Craft
{
	public class DefBowFletching : CraftSystem
	{
		public override SkillName MainSkill
		{
			get	{ return SkillName.Fletching; }
		}

		public override int GumpTitleNumber
		{
			get { return 1044006; } // <CENTER>BOWCRAFT AND FLETCHING MENU</CENTER>
		}

		private static CraftSystem m_CraftSystem;

		public static CraftSystem CraftSystem
		{
			get
			{
				if ( m_CraftSystem == null )
					m_CraftSystem = new DefBowFletching();

				return m_CraftSystem;
			}
		}

		public override double GetChanceAtMin( CraftItem item )
		{
			return 0.5; // 50%
		}

		private DefBowFletching() : base( 1, 1, 1.25 )// base( 1, 2, 1.7 )
		{
		}

		public override object CanCraft( Mobile from, BaseTool tool, Type itemType )
		{
			if( tool == null || tool.Deleted || tool.UsesRemaining < 0 )
				return 1044038; // You have worn out your tool!
			else if ( !BaseTool.CheckAccessible( tool, from ) )
				return 1044263; // The tool must be on your person to use.

			return 0;
		}

		public override void PlayCraftEffect( Mobile from )
		{
			from.PlaySound( 0x55 );
		}

		public override int PlayEndingEffect( Mobile from, bool failed, bool lostMaterial, bool toolBroken, int quality, bool makersMark, CraftItem item )
		{
			if ( toolBroken )
				from.SendLocalizedMessage( 1044038 ); // You have worn out your tool

			if ( failed )
			{
				if ( lostMaterial )
					return 1044043; // You failed to create the item, and some of your materials are lost.
				else
					return 1044157; // You failed to create the item, but no materials were lost.
			}
			else
			{
				if ( quality == 0 )
					return 502785; // You were barely able to make this item.  It's quality is below average.
				else if ( makersMark && quality == 2 )
					return 1044156; // You create an exceptional quality item and affix your maker's mark.
				else if ( quality == 2 )
					return 1044155; // You create an exceptional quality item.
				else				
					return 1044154; // You create the item.
			}
		}

		public override CraftECA ECA{ get{ return CraftECA.FiftyPercentChanceMinusTenPercent; } }

		public override void InitCraftList()
		{
			int index = -1;

			// Materials
			AddCraft( typeof( Kindling ), 1044457, 1023553, 0.0, 00.0, typeof( Board ), 1015101, 1, 1044351 );

			index = AddCraft( typeof( Kindling ), 1044457, "batch of kindling", 0.0, 00.0, typeof( Board ), 1015101, 1, 1044351 );
			SetUseAllRes( index, true );

			index = AddCraft( typeof( Shaft ), 1044457, 1027124, 0.0, 40.0, typeof( Board ), 1015101, 1, 1044351 );
			SetUseAllRes( index, true );

			// Ammunition
			index = AddCraft( typeof( Arrow ), 1044565, 1023903, 0.0, 40.0, typeof( Shaft ), 1044560, 1, 1044561 );
			AddRes( index, typeof( Feather ), 1044562, 1, 1044563 );
			SetUseAllRes( index, true );

			index = AddCraft( typeof( Bolt ), 1044565, 1027163, 0.0, 40.0, typeof( Shaft ), 1044560, 1, 1044561 );
			AddRes( index, typeof( Feather ), 1044562, 1, 1044563 );
			SetUseAllRes( index, true );
			
			index = AddCraft( typeof( PoisonArrow ), "Ammunition", "Poison Arrow", 100.0, 135.0, typeof( PineBoard ), "Pine Board", 1, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( FreezeArrow ), "Ammunition", "Freeze Arrow", 100.0, 135.0, typeof( GhostBoard ), "Ghostwood Board", 1, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( ExplosiveArrow ), "Ammunition", "Explosive Arrow", 100.0, 135.0, typeof( CherryBoard ), "Cherry Board", 1, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( ALightningArrow ), "Ammunition", "Lightning Arrow", 100.0, 135.0, typeof( OakBoard ), "Oak Board", 1, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( PoisonBolt ), "Ammunition", "Poison Bolt", 100.0, 135.0, typeof( PineBoard ), "Pine Board", 1, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( FreezeBolt ), "Ammunition", "Freeze Bolt", 100.0, 135.0, typeof( GhostBoard ), "Ghostwood Board", 1, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( ExplosiveBolt ), "Ammunition", "Explosive Bolt", 100.0, 135.0, typeof( CherryBoard ), "Cherry Board", 1, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LightningBolt2 ), "Ammunition", "Lightning Bolt", 100.0, 135.0, typeof( OakBoard ), "Oak Board", 1, 1042081 );
			SetUseSubRes2( index, true );

			if( Core.SE )
			{
				index = AddCraft( typeof( FukiyaDarts ), 1044565, 1030246, 50.0, 90.0, typeof( Board ), 1015101, 1, 1044351 );
				SetUseAllRes( index, true );
				SetNeededExpansion( index, Expansion.SE );
			}

			// Weapons
			AddCraft( typeof( Bow ), 1044566, 1025042, 30.0, 70.0, typeof( Board ), 1015101, 7, 1044351 );
			AddCraft( typeof( Crossbow ), 1044566, 1023919, 60.0, 100.0, typeof( Board ), 1015101, 7, 1044351 );
			AddCraft( typeof( HeavyCrossbow ), 1044566, 1025117, 80.0, 120.0, typeof( Board ), 1015101, 10, 1044351 );

			if ( Core.AOS )
			{
				AddCraft( typeof( CompositeBow ), 1044566, 1029922, 70.0, 110.0, typeof( Board ), 1015101, 7, 1044351 );
				AddCraft( typeof( RepeatingCrossbow ), 1044566, 1029923, 90.0, 130.0, typeof( Board ), 1015101, 10, 1044351 );
			}

			if( Core.SE )
			{
				index = AddCraft( typeof( Yumi ), 1044566, 1030224, 90.0, 130.0, typeof( Board ), 1015101, 10, 1044351 );
				SetNeededExpansion( index, Expansion.SE );
			}

			AddCraft( typeof( MagicalShortbow ), 1044566, "woodland shortbow", 50.0, 80.0, typeof( Board ), 1015101, 7, 1044351 );
			AddCraft( typeof( ElvenCompositeLongbow ), 1044566, "woodland longbow", 50.0, 80.0, typeof( Board ), 1015101, 7, 1044351 );

/////////////////DOC/////////////////////////
			index = AddCraft( typeof( LevelBow ), "Level Weapons", "Bow", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelCompositeBow ), "Level Weapons", "Composite Bow", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelCrossbow ), "Level Weapons", "Crossbow", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelHeavyCrossbow ), "Level Weapons", "Heavy Crossbow", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LevelRepeatingCrossbow ), "Level Weapons", "Repeating Crossbow", 100.0, 135.0, typeof( CaddelliteIngot ), "Caddelite Ingots", 100, 1042081 );
			SetUseSubRes2( index, true );
			
			
			index = AddCraft( typeof( PoisonDipTub ), "Dip Tubs", "Poison Dip Tub", 100.0, 135.0, typeof( PineBoard ), "Pine Board", 50, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( FreezeDipTub ), "Dip Tubs", "Freeze Dip Tub", 100.0, 135.0, typeof( GhostBoard ), "Ghostwood Board", 50, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( ExplosiveDipTub ), "Dip Tubs", "Explosive Dip Tub", 100.0, 135.0, typeof( CherryBoard ), "Cherry Board", 50, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( LightningDipTub ), "Dip Tubs", "Lightning Dip Tub", 100.0, 135.0, typeof( OakBoard ), "Oak Board", 50, 1042081 );
			SetUseSubRes2( index, true );
			
			
			index = AddCraft( typeof( AdvancedBow ), "Advanced Bows", "Advanced Bow", 100.0, 135.0, typeof( PineBoard ), "Pine Board", 50, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( AdvancedCompositeBow ), "Advanced Bows", "Advanced Composite Bow", 100.0, 135.0, typeof( RosewoodBoard ), "Rosewood Board", 50, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( AdvancedCrossbow ), "Advanced Bows", "Advanced Crossbow", 100.0, 135.0, typeof( MahoganyBoard ), "Mahogany Board", 50, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( AdvancedElvenCompositeLongbow ), "Advanced Bows", "Advanced Elven Composite Longbow", 100.0, 135.0, typeof( WalnutBoard ), "Walnut Board", 50, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( AdvancedHeavyCrossbow ), "Advanced Bows", "Advanced Heavy Crossbow", 100.0, 135.0, typeof( HickoryBoard ), "Hickroy Board", 50, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( AdvancedMagicalShortbow ), "Advanced Bows", "Advanced Magical ShortBow", 100.0, 135.0, typeof( DriftwoodBoard ), "Driftwood Board", 50, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( AdvancedRepeatingCrossbow ), "Advanced Bows", "Advanced Repeating Crossbow", 100.0, 135.0, typeof( AshBoard ), "Ash Board", 50, 1042081 );
			SetUseSubRes2( index, true );
			
			index = AddCraft( typeof( AdvancedYumi ), "Advanced Bows", "Advanced Yumi", 100.0, 135.0, typeof( OakBoard ), "Oak Board", 50, 1042081 );
			SetUseSubRes2( index, true );
			
			
			
////////////////////////////	

		
			Repair = true;
			MarkOption = true;
			CanEnhance = Core.AOS;

			SetSubRes( typeof( Board ), 1072643 );

			// Add every material you want the player to be able to choose from
			// This will override the overridable material	TODO: Verify the required skill amount
			AddSubRes( typeof( Board ), 1072643, 00.0, 1015101, 1072652 );
			AddSubRes( typeof( AshBoard ), 1095379, 65.0, 1015101, 1072652 );
			AddSubRes( typeof( CherryBoard ), 1095380, 70.0, 1015101, 1072652 );
			AddSubRes( typeof( EbonyBoard ), 1095381, 75.0, 1015101, 1072652 );
			AddSubRes( typeof( GoldenOakBoard ), 1095382, 80.0, 1015101, 1072652 );
			AddSubRes( typeof( HickoryBoard ), 1095383, 85.0, 1015101, 1072652 );
			AddSubRes( typeof( MahoganyBoard ), 1095384, 90.0, 1015101, 1072652 );
			AddSubRes( typeof( DriftwoodBoard ), 1095409, 90.0, 1015101, 1072652 );
			AddSubRes( typeof( OakBoard ), 1095385, 95.0, 1015101, 1072652 );
			AddSubRes( typeof( PineBoard ), 1095386, 100.0, 1015101, 1072652 );
			AddSubRes( typeof( GhostBoard ), 1095511, 100.0, 1015101, 1072652 );
			AddSubRes( typeof( RosewoodBoard ), 1095387, 100.0, 1015101, 1072652 );
			AddSubRes( typeof( WalnutBoard ), 1095388, 100.0, 1015101, 1072652 );
			AddSubRes( typeof( PetrifiedBoard ), 1095532, 100.0, 1015101, 1072652 );
			AddSubRes( typeof( ElvenBoard ), 1095535, 100.1, 1015101, 1072652 );
		}
	}
}
