using System;
using Server.Items;

namespace Server.Engines.Craft
{
	public class DefCooking : CraftSystem
	{
		public override SkillName MainSkill
		{
			get	{ return SkillName.Cooking;	}
		}

		public override int GumpTitleNumber
		{
			get { return 1044003; } // <CENTER>COOKING MENU</CENTER>
		}

		private static CraftSystem m_CraftSystem;

		public static CraftSystem CraftSystem
		{
			get
			{
				if ( m_CraftSystem == null )
					m_CraftSystem = new DefCooking();

				return m_CraftSystem;
			}
		}

		public override CraftECA ECA{ get{ return CraftECA.ChanceMinusSixtyToFourtyFive; } }

		public override double GetChanceAtMin( CraftItem item )
		{
			return 0.0; // 0%
		}

		private DefCooking() : base( 1, 1, 1.25 )// base( 1, 1, 1.5 )
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

		public override void InitCraftList()
		{
			int index = -1;

			/* Begin Ingredients */
			index = AddCraft( typeof( SackFlour ), 1044495, 1024153, 0.0, 100.0, typeof( WheatSheaf ), 1044489, 2, 1044490 );
			SetNeedMill( index, true );

			index = AddCraft( typeof( Dough ), 1044495, 1024157, 0.0, 100.0, typeof( SackFlour ), 1044468, 1, 1044253 );
			AddRes( index, typeof( BaseBeverage ), 1046458, 1, 1044253 );

			index = AddCraft( typeof( SweetDough ), 1044495, 1041340, 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( JarHoney ), "Jar of Honey", 1, "You need a Jar of Honey" );
			index = AddCraft( typeof( Batter ), 1044495, "Batter", 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( Eggs ), "Eggs", 1, 1044253 );
			AddRes( index, typeof( JarHoney ), 1044472, 1, 1044253 );
			index = AddCraft( typeof( Butter ), 1044495, "Butter", 0.0, 100.0, typeof( Cream ), "Cream", 1, 1044253 );
			index = AddCraft( typeof( Cream ), 1044495, "Cream", 0.0, 100.0, typeof( BaseBeverage ), "Milk", 1, 1044253 );
			index = AddCraft( typeof( CookingOil ), 1044495, "Cooking Oil", 0.0, 100.0, typeof( Peanut ), "Peanut", 10, 1044253 );
			index = AddCraft( typeof( Vinegar ), 1044495, "Vinegar", 0.0, 100.0, typeof( Apple ), "apples", 5, 1044253 );
			AddRes( index, typeof( BottleOfWine ), "Wine", 1, 1044253 );
			index = AddCraft( typeof( CakeMix ), 1044495, 1041002, 0.0, 100.0, typeof( SackFlour ), 1044468, 1, 1044253 );
			AddRes( index, typeof( SweetDough ), 1044475, 1, 1044253 );

			index = AddCraft( typeof( CookieMix ), 1044495, 1024159, 0.0, 100.0, typeof( JarHoney ), 1044472, 1, 1044253 );
			AddRes( index, typeof( SweetDough ), 1044475, 1, 1044253 );

			index = AddCraft( typeof( GroundBeef ), 1044496, "Ground Beef", 0.0, 100.0, typeof( BeefHock ), "Beef Hock", 1, 1044253 );
			index = AddCraft( typeof( GroundPork ), 1044496, "Ground Pork", 0.0, 100.0, typeof( PorkHock ), "Pork Hock", 1, 1044253 );
			index = AddCraft( typeof( SlicedTurkey ), 1044496, "Sliced Turkey", 0.0, 100.0, typeof( TurkeyHock ), "Turkey Hock", 1, 1044253 );
			index = AddCraft( typeof( PastaNoodles ), 1044496, "Pasta Noodles", 0.0, 100.0, typeof( SackFlour ), "Sack of Flour", 1, 1044253 );
			AddRes( index, typeof( Eggs ), "eggs", 5, 1044253 );
			index = AddCraft( typeof( PeanutButter ), 1044496, "Peanut Butter", 0.0, 100.0, typeof( Peanut ), "Peanuts", 30, 1044253 );
			index = AddCraft( typeof( Tortilla ), 1044496, "Tortilla", 0.0, 100.0, typeof( BagOfCornmeal ), "Bag of Cornmeal", 1, 1044253 );
			AddRes( index, typeof( BaseBeverage ), 1046458, 1, 1044253 );
			SetNeedOven( index, true );
			index = AddCraft( typeof( UnbakedQuiche ), 1044496, 1041339, 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( Eggs ), 1044477, 1, 1044253 );

			// TODO: This must also support chicken and lamb legs
			index = AddCraft( typeof( UnbakedMeatPie ), 1044496, 1041338, 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( RawRibs ), 1044482, 1, 1044253 );

			index = AddCraft( typeof( UncookedSausagePizza ), 1044496, 1041337, 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( Sausage ), 1044483, 1, 1044253 );

			index = AddCraft( typeof( UncookedCheesePizza ), 1044496, 1041341, 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( CheeseWheel ), 1044486, 1, 1044253 );

			index = AddCraft( typeof( UnbakedFruitPie ), 1044496, 1041334, 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( Pear ), 1044481, 1, 1044253 );

			index = AddCraft( typeof( UnbakedPeachCobbler ), 1044496, 1041335, 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( Peach ), 1044480, 1, 1044253 );

			index = AddCraft( typeof( UnbakedApplePie ), 1044496, 1041336, 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( Apple ), 1044479, 1, 1044253 );

			index = AddCraft( typeof( UnbakedPumpkinPie ), 1044496, 1041342, 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( Pumpkin ), 1044484, 1, 1044253 );
			index = AddCraft( typeof( GreenTea ), 1044496, 1030315, 80.0, 130.0, typeof( GreenTeaBasket ), 1030316, 1, 1044253 );
			AddRes( index, typeof( BaseBeverage ), 1046458, 1, 1044253 );
			SetNeededExpansion( index, Expansion.SE );
			SetNeedOven( index, true );
			index = AddCraft( typeof( WasabiClumps ), 1044496, 1029451, 70.0, 120.0, typeof( BaseBeverage ), 1046458, 1, 1044253 );
			AddRes( index, typeof( WoodenBowlPea ), 1025633, 3, 1044253 );
			SetNeededExpansion( index, Expansion.SE );
			index = AddCraft( typeof( SushiRolls ), 1044496, 1030303, 90.0, 120.0, typeof( BaseBeverage ), 1046458, 1, 1044253 );
			AddRes( index, typeof( RawFishSteak ), 1044476, 5, 1044253 );
			AddRes( index, typeof( RawShrimp ), "Raw Shrimp", 5, "You need more Raw Shrimp" );
			SetNeededExpansion( index, Expansion.SE );
			index = AddCraft( typeof( SushiPlatter ), 1044496, 1030305, 90.0, 120.0, typeof( BaseBeverage ), 1046458, 1, 1044253 );
			AddRes( index, typeof( RawFishSteak ), 1044476, 5, 1044253 );
			AddRes( index, typeof( RawShrimp ), "Raw Shrimp", 5, "You need more Raw Shrimp" );
			SetNeededExpansion( index, Expansion.SE );
			index = AddCraft( typeof( TribalPaint ), 1044496, 1040000, 80.0, 80.0, typeof( SackFlour ), 1044468, 1, 1044253 );
			AddRes( index, typeof( TribalBerry ), 1046460, 1, 1044253 );
			index = AddCraft( typeof( EggBomb ), 1044496, 1030249, 90.0, 120.0, typeof( Eggs ), 1044477, 1, 1044253 );
			AddRes( index, typeof( SackFlour ), 1044468, 3, 1044253 );
			SetNeededExpansion( index, Expansion.SE );
			index = AddCraft( typeof( DriedOnions ), 1044496, "Dried Onions", 0.0, 100.0, typeof( Onion ), "Onions", 5, 1044253 );
			index = AddCraft( typeof( DriedHerbs ), 1044496, "Dried Herbs", 0.0, 100.0, typeof( Garlic ), "Garlic", 2, 1044253 );
			AddRes( index, typeof( Ginseng ), "Ginseng", 2, 1044253 );
			AddRes( index, typeof( TanGinger ), "Tan Ginger", 2, "You need more tan ginger" );
			index = AddCraft( typeof( BasketOfHerbs ), 1044496, "Basket of Herbs", 0.0, 100.0, typeof( DriedHerbs ), "Dried Herbs", 1, 1044253 );
			AddRes( index, typeof( DriedOnions ), "Dried Onions", 1, 1044253 );

			index = AddCraft( typeof( BarbecueSauce ), "Sauces", "Barbecue Sauce", 0.0, 100.0, typeof( Tomato ), "Tomato", 1, 1044253 );
			AddRes( index, typeof( JarHoney ), "Honey", 1, 1044253 );
			AddRes( index, typeof( BasketOfHerbs ), "Herbs", 1, 1044253 );
			index = AddCraft( typeof( CheeseSauce ), "Sauces", "Cheese Sauce", 0.0, 100.0, typeof( Butter ), "Butter", 1, 1044253 );
			AddRes( index, typeof( BaseBeverage ), "Milk", 1, 1044253 );
			AddRes( index, typeof( CheeseWheel ), "Cheese Wheel", 1, 1044253 );
			index = AddCraft( typeof( EnchiladaSauce ), "Sauces", "Enchilada Sauce", 0.0, 100.0, typeof( Tomato ), "Tomato", 1, 1044253 );
			AddRes( index, typeof( ChiliPepper ), "Chili Pepper", 1, 1044253 );
			AddRes( index, typeof( BasketOfHerbs ), "Herbs", 1, 1044253 );
			index = AddCraft( typeof( Gravy ), "Sauces", "Gravy", 0.0, 100.0, typeof( Dough ), 1044469, 2, 1044253 );
			AddRes( index, typeof( BaseBeverage ), 1046458, 1, 1044253 );
			AddRes( index, typeof( BasketOfHerbs ), "Herbs", 1, 1044253 );
			index = AddCraft( typeof( HotSauce ), "Sauces", "Hot Sauce", 0.0, 100.0, typeof( Tomato ), "Tomato", 2, 1044253 );
			AddRes( index, typeof( ChiliPepper ), "Chili Pepper", 3, 1044253 );
			AddRes( index, typeof( BasketOfHerbs ), "Herbs", 1, 1044253 );
			index = AddCraft( typeof( SoySauce ), "Sauces", "Soy Sauce", 0.0, 100.0, typeof( BagOfSoy ), "Bag of Soy", 1, 1044253 );
			AddRes( index, typeof( BagOfSugar ), "Bag of Sugar", 1, 1044253 );
			AddRes( index, typeof( BaseBeverage ), 1046458, 1, 1044253 );
			index = AddCraft( typeof( Teriyaki ), "Sauces", "Teriyaki", 0.0, 100.0, typeof( SoySauce ), "Soy Sauce", 1, 1044253 );
			AddRes( index, typeof( BottleOfWine ), "Bottle of Wine", 1, 1044253 );
			AddRes( index, typeof( JarHoney ), "Honey", 1, 1044253 );
			index = AddCraft( typeof( TomatoSauce ), "Sauces", "Tomato Sauce", 0.0, 100.0, typeof( Tomato ), "Tomato", 3, 1044253 );
			AddRes( index, typeof( BasketOfHerbs ), "Herbs", 1, 1044253 );

			index = AddCraft( typeof( CakeMix ), "Mixes", "Cake Mix", 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( CookingOil ), "Cooking Oil", 1, 1044253 );
			AddRes( index, typeof( BagOfSugar ), "Bag of Sugar", 1, 1044253 );
			index = AddCraft( typeof( CookieMix ), "Mixes", "Cookie Mix", 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( Butter ), "Butter", 1, 1044253 );
			AddRes( index, typeof( JarHoney ), "Honey", 1, 1044253 );
			index = AddCraft( typeof( AsianVegMix ), "Mixes", "Asian Vegetable Mix", 0.0, 100.0, typeof( Cabbage ), "Cabbage", 1, 1044253 );
			AddRes( index, typeof( Onion ), "Onion", 1, 1044253 );
			AddRes( index, typeof( RedMushroom ), "Red Mushroom", 1, "You need a Red Mushroom" );
			AddRes( index, typeof( Carrot ), "Carrot", 1, 1044253 );
			index = AddCraft( typeof( ChocolateMix ), "Mixes", "Chocolate Mix", 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( BagOfCocoa ), "Bag of Cocoa", 1, 1044253 );
			AddRes( index, typeof( BagOfSugar ), "Bag of Sugar", 1, 1044253 );
			index = AddCraft( typeof( MixedVegetables ), "Mixes", "Mixed Vegetables", 0.0, 100.0, typeof( Potato ), "Potato", 2, 1044253 );
			AddRes( index, typeof( Carrot ), "Carrot", 1, 1044253 );
			AddRes( index, typeof( Celery ), "Celery", 1, 1044253 );
			AddRes( index, typeof( Onion ), "Onion", 1, 1044253 );
			index = AddCraft( typeof( PieMix ), "Mixes", "Pie Mix", 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( Butter ), "Butter", 1, 1044253 );
			index = AddCraft( typeof( PizzaCrust ), "Mixes", "Pizza Crust", 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			index = AddCraft( typeof( WaffleMix ), "Mixes", "Waffle Mix", 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			AddRes( index, typeof( Eggs ), "Eggs", 2, 1044253 );
			AddRes( index, typeof( CookingOil ), "cooking oil", 1, 1044253 );

			index = AddCraft( typeof( BowlCornFlakes ), 1044497, "Bowl of Corn Flakes", 0.0, 100.0, typeof( BagOfCornmeal ), "Bag of Cornmeal", 1, 1044253 );
			AddRes( index, typeof( BaseBeverage ), 1046458, 1, 1044253 );
			index = AddCraft( typeof( BowlRiceKrisps ), 1044497, "Bowl of Rice Krisps", 0.0, 100.0, typeof( BagOfRicemeal ), "Bag of Ricemeal", 1, 1044253 );
			AddRes( index, typeof( BaseBeverage ), 1046458, 1, 1044253 );
			index = AddCraft( typeof( FruitBasket ), 1044497, "Fruit Basket", 0.0, 100.0, typeof( Apple ), "Apple", 5, 1044253 );
			AddRes( index, typeof( Peach ), "Peach", 5, 1044253 );
			AddRes( index, typeof( Pear ), "Pear", 5, 1044253 );
			AddRes( index, typeof( Cherry ), "Cherries", 5, 1044253 );
			index = AddCraft( typeof( Tofu ), 1044497, "Tofu", 0.0, 100.0, typeof( BagOfSoy ), "Bag of Soy", 1, 1044253 );

			index = AddCraft( typeof( BreadLoaf ), 1044497, 1024156, 0.0, 100.0, typeof( Dough ), 1044469, 1, 1044253 );
			SetNeedOven( index, true );

			index = AddCraft( typeof( Cookies ), 1044497, 1025643, 0.0, 100.0, typeof( CookieMix ), 1044474, 1, 1044253 );
			SetNeedOven( index, true );

			index = AddCraft( typeof( Cake ), 1044497, 1022537, 0.0, 100.0, typeof( CakeMix ), 1044471, 1, 1044253 );
			SetNeedOven( index, true );

			index = AddCraft( typeof( Muffins ), 1044497, 1022539, 0.0, 100.0, typeof( SweetDough ), 1044475, 1, 1044253 );
			SetNeedOven( index, true );

			index = AddCraft( typeof( Quiche ), 1044497, 1041345, 0.0, 100.0, typeof( UnbakedQuiche ), 1044518, 1, 1044253 );
			SetNeedOven( index, true );

			index = AddCraft( typeof( MeatPie ), 1044497, 1041347, 0.0, 100.0, typeof( UnbakedMeatPie ), 1044519, 1, 1044253 );
			SetNeedOven( index, true );

			index = AddCraft( typeof( SausagePizza ), 1044497, 1044517, 0.0, 100.0, typeof( UncookedSausagePizza ), 1044520, 1, 1044253 );
			SetNeedOven( index, true );

			index = AddCraft( typeof( CheesePizza ), 1044497, 1044516, 0.0, 100.0, typeof( UncookedCheesePizza ), 1044521, 1, 1044253 );
			SetNeedOven( index, true );

			index = AddCraft( typeof( FruitPie ), 1044497, 1041346, 0.0, 100.0, typeof( UnbakedFruitPie ), 1044522, 1, 1044253 );
			SetNeedOven( index, true );

			index = AddCraft( typeof( PeachCobbler ), 1044497, 1041344, 0.0, 100.0, typeof( UnbakedPeachCobbler ), 1044523, 1, 1044253 );
			SetNeedOven( index, true );

			index = AddCraft( typeof( ApplePie ), 1044497, 1041343, 0.0, 100.0, typeof( UnbakedApplePie ), 1044524, 1, 1044253 );
			SetNeedOven( index, true );

			index = AddCraft( typeof( PumpkinPie ), 1044497, 1041348, 0.0, 100.0, typeof( UnbakedPumpkinPie ), 1046461, 1, 1044253 );
			SetNeedOven( index, true );

			if ( Core.SE )
			{
				index = AddCraft( typeof( MisoSoup ), 1044497, 1030317, 60.0, 110.0, typeof( RawFishSteak ), 1044476, 1, 1044253 );
				AddRes( index, typeof( BaseBeverage ), 1046458, 1, 1044253 );
				SetNeededExpansion( index, Expansion.SE );
				SetNeedOven( index, true );

				index = AddCraft( typeof( WhiteMisoSoup ), 1044497, 1030318, 60.0, 110.0, typeof( RawFishSteak ), 1044476, 1, 1044253 );
				AddRes( index, typeof( BaseBeverage ), 1046458, 1, 1044253 );
				SetNeededExpansion( index, Expansion.SE );
				SetNeedOven( index, true );

				index = AddCraft( typeof( RedMisoSoup ), 1044497, 1030319, 60.0, 110.0, typeof( RawFishSteak ), 1044476, 1, 1044253 );
				AddRes( index, typeof( BaseBeverage ), 1046458, 1, 1044253 );
				SetNeededExpansion( index, Expansion.SE );
				SetNeedOven( index, true );

				index = AddCraft( typeof( AwaseMisoSoup ), 1044497, 1030320, 60.0, 110.0, typeof( RawFishSteak ), 1044476, 1, 1044253 );
				AddRes( index, typeof( BaseBeverage ), 1046458, 1, 1044253 );
				SetNeededExpansion( index, Expansion.SE );
				SetNeedOven( index, true );
			}
			/* End Baking */

			/* Begin Barbecue */
			index = AddCraft( typeof( CookedBird ), 1044498, 1022487, 0.0, 100.0, typeof( RawBird ), 1044470, 1, 1044253 );
			SetNeedHeat( index, true );
			SetUseAllRes( index, true );

			index = AddCraft( typeof( ChickenLeg ), 1044498, 1025640, 0.0, 100.0, typeof( RawChickenLeg ), 1044473, 1, 1044253 );
			SetNeedHeat( index, true );
			SetUseAllRes( index, true );

			index = AddCraft( typeof( FishSteak ), 1044498, 1022427, 0.0, 100.0, typeof( RawFishSteak ), 1044476, 1, 1044253 );
			SetNeedHeat( index, true );
			SetUseAllRes( index, true );

			index = AddCraft( typeof( FriedEggs ), 1044498, 1022486, 0.0, 100.0, typeof( Eggs ), 1044477, 1, 1044253 );
			SetNeedHeat( index, true );
			SetUseAllRes( index, true );

			index = AddCraft( typeof( LambLeg ), 1044498, 1025642, 0.0, 100.0, typeof( RawLambLeg ), 1044478, 1, 1044253 );
			SetNeedHeat( index, true );
			SetUseAllRes( index, true );

			index = AddCraft( typeof( Ribs ), 1044498, 1022546, 0.0, 100.0, typeof( RawRibs ), 1044485, 1, 1044253 );
			SetNeedHeat( index, true );
			
			index = AddCraft( typeof( CookedSteak ), 1044498, "Steak", 50.0, 100.0, typeof( RawSteak ), "Raw Steak", 1, "You need more Raw Steak" );
			SetNeedHeat( index, true );
			index = AddCraft( typeof( HamSlices ), 1044498, "Ham Slices", 20.0, 100.0, typeof( RawHamSlices ), "Raw Ham Slice", 1, "You need more Raw Ham Slice" );
			SetNeedHeat( index, true );
			index = AddCraft( typeof( RoastHam ), 1044498, "Roast Ham", 50.0, 100.0, typeof( RawHam ), "Raw Ham", 1, "You need more Raw Ham" );
			SetNeedHeat( index, true );
			index = AddCraft( typeof( FishSteak ), 1044498, 1022427, 30.0, 100.0, typeof( RawFishSteak ), 1044476, 1, 1044253 );
			SetNeedHeat( index, true );
			index = AddCraft( typeof( HalibutFishSteak ), 1044498, "Halibut Fish Steak", 50.0, 120.0, typeof( RawHalibutSteak ), "Raw Halibut Fish Steak", 1, "you need more Raw Halibut Fish Steaks" );
			SetNeedHeat( index, true );
			index = AddCraft( typeof( FlukeFishSteak ), 1044498, "Fluke Fish Steak", 50.0, 120.0, typeof( RawFlukeSteak ), "Raw Fluke Fish Steak", 1, "you need more Raw Fluke Fish Steaks" );
			SetNeedHeat( index, true );
			index = AddCraft( typeof( MahiFishSteak ), 1044498, "Mahi Fish Steak", 50.0, 120.0, typeof( RawMahiSteak ), "Raw Mahi Fish Steak", 1, "you need more Raw Mahi Fish Steaks" );
			SetNeedHeat( index, true );
			index = AddCraft( typeof( SalmonFishSteak ), 1044498, "Salmon Fish Steak", 50.0, 120.0, typeof( RawSalmonSteak ), "Raw Salmon Fish Steak", 1, "you need more Raw Salmon Fish Steaks" );
			SetNeedHeat( index, true );
			index = AddCraft( typeof( RedSnapperFishSteak ), 1044498, "Red Snapper Fish Steak", 50.0, 120.0, typeof( RawRedSnapperSteak ), "Raw Red Snapper Fish Steak", 1, "you need more Raw Red Snapper Fish Steaks" );
			SetNeedHeat( index, true );
			index = AddCraft( typeof( ParrotFishSteak ), 1044498, "Parrot Fish Steak", 50.0, 120.0, typeof( RawParrotFishSteak ), "Raw Parrot Fish Steak", 1, "you need more Raw Parrot Fish Steaks" );
			SetNeedHeat( index, true );
			index = AddCraft( typeof( TroutFishSteak ), 1044498, "Trout Fish Steak", 50.0, 120.0, typeof( RawTroutSteak ), "Raw Trout Fish Steak", 1, "you need more Raw Trout Fish Steaks" );
			SetNeedHeat( index, true );
			index = AddCraft( typeof( CookedShrimp ), 1044498, "Cooked Shrimp", 50.0, 120.0, typeof( RawShrimp ), "Raw Shrimp", 1, "you need more Raw Shrimp" );
			SetNeedHeat( index, true );

		//	index = AddCraft( typeof( Pulp ), "Other", "100 Pulp", 50.0, 100.0, typeof( Log ), "Log", 200, 1044253 );
		//	AddRes( index, typeof( BaseBeverage ), 1046458, 1, 1044253 );
		//	SetNeedOven( index, true );
			
		//	SetUseAllRes( index, true );
			/* End Barbecue */

			AddCraft( typeof( CarvedPumpkin ), "Halloween", "jack-o-lantern", 90.0, 120.0, typeof( Pumpkin ), "Pumpkin", 1, 1042081 );
			AddCraft( typeof( CarvedPumpkin2 ), "Halloween", "jack-o-lantern", 90.0, 120.0, typeof( Pumpkin ), "Pumpkin", 1, 1042081 );
		}
	}
}
