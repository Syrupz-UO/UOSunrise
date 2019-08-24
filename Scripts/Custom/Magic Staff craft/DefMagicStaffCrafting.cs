using System;
using Server;
using Server.Items;

namespace Server.Engines.Craft
{
	public class DefMagicStaffCrafting : CraftSystem
	{
		public override SkillName MainSkill
		{
			get	{ return SkillName.Magery; }
		}

		public override int GumpTitleNumber
		{
			get { return 0; } // Use String
		}

		public override string GumpTitleString
		{
			get { return "<basefont color=#FFFFFF><CENTER>MAGIC STAFF CRAFTING MENU</CENTER></basefont>"; } 
		}

		public override double GetChanceAtMin( CraftItem item )
		{
			return 0.0; // 0%
		}

		private static CraftSystem m_CraftSystem;

		public static CraftSystem CraftSystem
		{
			get
			{
				if ( m_CraftSystem == null )
					m_CraftSystem = new DefMagicStaffCrafting();

				return m_CraftSystem;
			}
		}

//		public override double GetChanceAtMin( CraftItem item )
//		{
//			return 0.5; // 50%
//		}

		private DefMagicStaffCrafting() : base( 1, 1, 1.25 )// base( 1, 1, 3.0 )
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
			from.PlaySound( 0x249 );
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

//FIRST CIRCLE
			index = AddCraft( typeof( ClumsyMagicStaff ), "FIRST CIRCLE", "Staff of Clumsiness", 5.0, 10.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( ClumsyScroll ), "Scroll of Clumsiness", 1, "You need a scroll of Clumsiness to assemble your Magic Staff." );
			AddRes( index, typeof( Amber ), "Gem of Amber", 1, "You need some Amber to assemble your Magic Staff." );

			index = AddCraft( typeof( CreateFoodMagicStaff ), "FIRST CIRCLE", "Staff of Create Food", 5.0, 10.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( CreateFoodScroll ), "Scroll of Create Food", 1, "You need a scroll of Create Food to assemble your Magic Staff." );
			AddRes( index, typeof( Amber ), "Gem of Amber", 1, "You need some Amber to assemble your Magic Staff." );

			index = AddCraft( typeof( FeebleMagicStaff ), "FIRST CIRCLE", "Staff of Feeble Mind", 5.0, 10.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( FeeblemindScroll ), "Scroll of Feeble mind", 1, "You need a scroll of Feeble mind to assemble your Magic Staff." );
			AddRes( index, typeof( Amber ), "Gem of Amber", 1, "You need some Amber to assemble your Magic Staff." );

			index = AddCraft( typeof( HealMagicStaff ), "FIRST CIRCLE", "Staff of Healing", 5.0, 10.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( HealScroll ), "Scroll of Healing", 1, "You need a scroll of Healing to assemble your Magic Staff." );
			AddRes( index, typeof( Amber ), "Gem of Amber", 1, "You need some Amber to assemble your Magic Staff." );

			index = AddCraft( typeof( MagicArrowMagicStaff ), "FIRST CIRCLE", "Staff of Magic Arrow", 5.0, 10.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( MagicArrowScroll ), "Scroll of Magic Arrow", 1, "You need a scroll of Magic Arrow to assemble your Magic Staff." );
			AddRes( index, typeof( Amber ), "Gem of Amber", 1, "You need some Amber to assemble your Magic Staff." );

			index = AddCraft( typeof( NightSightMagicStaff ), "FIRST CIRCLE", "Staff of Night Sight", 5.0, 10.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( NightSightScroll ), "Scroll of Night Sight", 1, "You need a scroll of Night Sight to assemble your Magic Staff." );
			AddRes( index, typeof( Amber ), "Gem of Amber", 1, "You need some Amber to assemble your Magic Staff." );

			index = AddCraft( typeof( ReactiveArmorMagicStaff ), "FIRST CIRCLE", "Staff of Reactive Armor", 5.0, 10.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( ReactiveArmorScroll ), "Scroll of Reactive Armor", 1, "You need a scroll of Reactive Armor to assemble your Magic Staff." );
			AddRes( index, typeof( Amber ), "Gem of Amber", 1, "You need some Amber to assemble your Magic Staff." );

			index = AddCraft( typeof( WeaknessMagicStaff ), "FIRST CIRCLE", "Staff of Weakeness", 5.0, 10.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( WeakenScroll ), "Scroll of Weakeness", 1, "You need a scroll of Weakeness to assemble your Magic Staff." );
			AddRes( index, typeof( Amber ), "Gem of Amber", 1, "You need some Amber to assemble your Magic Staff." );

//SECOND CIRCLE
			index = AddCraft( typeof( AgilityMagicStaff ), "SECOND CIRCLE", "Staff of Agility", 10.0, 20.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( AgilityScroll ), "Scroll of Agility", 1, "You need a Scroll of Agility to assemble your Magic Staff." );
			AddRes( index, typeof( Tourmaline ), "Gem of Tourmaline", 2, "You need some Tourmaline to assemble your Magic Staff." );

			index = AddCraft( typeof( CunningMagicStaff ), "SECOND CIRCLE", "Staff of Cunning", 10.0, 20.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( CunningScroll ), "Scroll of Cunning", 1, "You need a Scroll of Cunning to assemble your Magic Staff." );
			AddRes( index, typeof( Tourmaline ), "Gem of Tourmaline", 2, "You need some Tourmaline to assemble your Magic Staff." );

			index = AddCraft( typeof( CureMagicStaff ), "SECOND CIRCLE", "Staff of Cureing", 10.0, 20.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( CureScroll ), "Scroll of Cureing", 1, "You need a scroll of Cureing to assemble your Magic Staff." );
			AddRes( index, typeof( Tourmaline ), "Gem of Tourmaline", 2, "You need some Tourmaline to assemble your Magic Staff." );

			index = AddCraft( typeof( HarmMagicStaff ), "SECOND CIRCLE", "Staff of Harming", 10.0, 20.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( HarmScroll ), "Scroll of Harm", 1, "You need a scroll of Harm to assemble your Magic Staff." );
			AddRes( index, typeof( Tourmaline ), "Gem of Tourmaline", 2, "You need some Tourmaline to assemble your Magic Staff." );

			index = AddCraft( typeof( MagicTrapMagicStaff ), "SECOND CIRCLE", "Staff of Magic Trap", 10.0, 20.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( MagicTrapScroll ), "Scroll of Magic Trap", 1, "You need a scroll of Magic Trap to assemble your Magic Staff." );
			AddRes( index, typeof( Tourmaline ), "Gem of Tourmaline", 2, "You need some Tourmaline to assemble your Magic Staff." );

			index = AddCraft( typeof( MagicUntrapMagicStaff ), "SECOND CIRCLE", "Staff of Magic UnTrap", 10.0, 20.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( MagicUnTrapScroll ), "Scroll of Magic UnTrap", 1, "You need a scroll of Magic UnTrap to assemble your Magic Staff." );
			AddRes( index, typeof( Tourmaline ), "Gem of Tourmaline", 2, "You need some Tourmaline to assemble your Magic Staff." );

			index = AddCraft( typeof( ProtectionMagicStaff ), "SECOND CIRCLE", "Staff of Protection", 10.0, 20.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( ProtectionScroll ), "Scroll of Protection", 1, "You need a scroll of Protection to assemble your Magic Staff." );
			AddRes( index, typeof( Tourmaline ), "Gem of Tourmaline", 2, "You need some Tourmaline to assemble your Magic Staff." );

			index = AddCraft( typeof( StrengthMagicStaff ), "SECOND CIRCLE", "Staff of Strength", 10.0, 20.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( StrengthScroll ), "Scroll of Strength", 1, "You need a scroll of Strength to assemble your Magic Staff." );
			AddRes( index, typeof( Tourmaline ), "Gem of Tourmaline", 2, "You need some Tourmaline to assemble your Magic Staff." );

//THIRD CIRCLE
			index = AddCraft( typeof( BlessMagicStaff ), "THIRD CIRCLE", "Staff of Blessing", 20.0, 30.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( BlessScroll ), "Scroll of Blessing", 1, "You need a scroll of Blessing to assemble your Magic Staff." );
			AddRes( index, typeof( Sapphire ), "Gem of Sapphire", 3, "You need some Sapphire to assemble your Magic Staff." );

			index = AddCraft( typeof( FireballMagicStaff ), "THIRD CIRCLE", "Staff of FireBall", 20.0, 30.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( FireballScroll ), "Scroll of FireBall", 1, "You need a scroll of Fire Ball to assemble your Magic Staff." );
			AddRes( index, typeof( Sapphire ), "Gem of Sapphire", 3, "You need some Sapphire to assemble your Magic Staff." );

			index = AddCraft( typeof( MagicLockMagicStaff ), "THIRD CIRCLE", "Staff of Magic Lock", 20.0, 30.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( MagicLockScroll ), "Scroll of Magic Lock", 1, "You need a scroll of Magic Lock to assemble your Magic Staff." );
			AddRes( index, typeof( Sapphire ), "Gem of Sapphire", 3, "You need some Sapphire to assemble your Magic Staff." );

			index = AddCraft( typeof( PoisonMagicStaff ), "THIRD CIRCLE", "Staff of Poisoning", 20.0, 30.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( PoisonScroll ), "Scroll of Poisoning", 1, "You need a scroll of Poisoning to assemble your Magic Staff." );
			AddRes( index, typeof( Sapphire ), "Gem of Sapphire", 3, "You need some Sapphire to assemble your Magic Staff." );

			index = AddCraft( typeof( TelekinesisMagicStaff ), "THIRD CIRCLE", "Staff of Telekinisis", 20.0, 30.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( TelekinisisScroll ), "Scroll of Telekinisis", 1, "You need a scroll of Telekinisis to assemble your Magic Staff." );
			AddRes( index, typeof( Sapphire ), "Gem of Sapphire", 3, "You need some Sapphire to assemble your Magic Staff." );

			index = AddCraft( typeof( TeleportMagicStaff ), "THIRD CIRCLE", "Staff of Teleportation", 20.0, 30.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( TeleportScroll ), "Scroll of Teleportation", 1, "You need a scroll of Teleportation to assemble your Magic Staff." );
			AddRes( index, typeof( Sapphire ), "Gem of Sapphire", 3, "You need some Sapphire to assemble your Magic Staff." );

			index = AddCraft( typeof( MagicUnlockMagicStaff ), "THIRD CIRCLE", "Staff of Magic UnLocking", 20.0, 30.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( UnlockScroll ), "Scroll of UnLocking", 1, "You need a scroll of UnLocking to assemble your Magic Staff." );
			AddRes( index, typeof( Sapphire ), "Gem of Sapphire", 3, "You need some Sapphire to assemble your Magic Staff." );

			index = AddCraft( typeof( WallofStoneMagicStaff ), "THIRD CIRCLE", "Staff of Wall of Stone", 20.0, 30.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( WallOfStoneScroll ), "Scroll of Wall of Stone", 1, "You need a scroll of Wall of Stone to assemble your Magic Staff." );
			AddRes( index, typeof( Sapphire ), "Gem of Sapphire", 3, "You need some Sapphire to assemble your Magic Staff." );

//FOURTH CIRCLE
			index = AddCraft( typeof( ArchCureMagicStaff ), "FOURTH CIRCLE", "Staff of ArchCure", 30.0, 40.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( ArchCureScroll ), "Scroll of ArchCure", 1, "You need a scroll of ArchCure to assemble your Magic Staff." );
			AddRes( index, typeof( Emerald ), "Gem of Emerald", 4, "You need some Emerald to assemble your Magic Staff." );

			index = AddCraft( typeof( ArchProtectionMagicStaff ), "FOURTH CIRCLE", "Staff of ArchProtection", 30.0, 40.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( ArchProtectionScroll ), "Scroll of ArchProtection", 1, "You need a scroll of ArchProtection to assemble your Magic Staff." );
			AddRes( index, typeof( Emerald ), "Gem of Emerald", 4, "You need some Emerald to assemble your Magic Staff." );

			index = AddCraft( typeof( CurseMagicStaff ), "FOURTH CIRCLE", "Staff of Curse", 30.0, 40.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( CurseScroll ), "Scroll of Curse", 1, "You need a scroll of Curse to assemble your Magic Staff." );
			AddRes( index, typeof( Emerald ), "Gem of Emerald", 4, "You need some Emerald to assemble your Magic Staff." );

			index = AddCraft( typeof( FireFieldMagicStaff ), "FOURTH CIRCLE", "Staff of Fire Field", 30.0, 40.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( FireFieldScroll ), "Scroll of Fire Field", 1, "You need a scroll of Fire Field to assemble your Magic Staff." );
			AddRes( index, typeof( Emerald ), "Gem of Emerald", 4, "You need some Emerald to assemble your Magic Staff." );

			index = AddCraft( typeof( GreaterHealMagicStaff ), "FOURTH CIRCLE", "Staff of Greater Healing", 30.0, 40.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( GreaterHealScroll ), "Scroll of Greater Healing", 1, "You need a scroll of Greater Healing to assemble your Magic Staff." );
			AddRes( index, typeof( Emerald ), "Gem of Emerald", 4, "You need some Emerald to assemble your Magic Staff." );

			index = AddCraft( typeof( LightningMagicStaff ), "FOURTH CIRCLE", "Staff of Lightning", 30.0, 40.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( LightningScroll ), "Scroll of Lightning", 1, "You need a scroll of Lightning to assemble your Magic Staff." );
			AddRes( index, typeof( Emerald ), "Gem of Emerald", 4, "You need some Emerald to assemble your Magic Staff." );

			index = AddCraft( typeof( ManaDrainMagicStaff ), "FOURTH CIRCLE", "Staff of Mana Drain", 30.0, 40.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( ManaDrainScroll ), "Scroll of Mana Drain", 1, "You need a scroll of Mana Drain to assemble your Magic Staff." );
			AddRes( index, typeof( Emerald ), "Gem of Emerald", 4, "You need some Emerald to assemble your Magic Staff." );

			index = AddCraft( typeof( RecallMagicStaff ), "FOURTH CIRCLE", "Staff of Recall", 30.0, 40.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( RecallScroll ), "Scroll of Recall", 1, "You need a scroll of Recall to assemble your Magic Staff." );
			AddRes( index, typeof( Emerald ), "Gem of Emerald", 4, "You need some Emerald to assemble your Magic Staff." );

//FIFTH CIRCLE
			index = AddCraft( typeof( BladeSpiritsMagicStaff ), "FIFTH CIRCLE", "Staff of Blade Spirits", 40.0, 50.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( BladeSpiritsScroll ), "Scroll of Blade Spirits", 1, "You need a scroll of Blade Spirits to assemble your Magic Staff." );
			AddRes( index, typeof( Ruby ), "Gem of Ruby", 5, "You need some Ruby to assemble your Magic Staff." );

			index = AddCraft( typeof( DispelFieldMagicStaff ), "FIFTH CIRCLE", "Staff of Dispel Field", 40.0, 50.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( DispelFieldScroll ), "Scroll of Dispel Field", 1, "You need a scroll of Dispel Field to assemble your Magic Staff." );
			AddRes( index, typeof( Ruby ), "Gem of Ruby", 5, "You need some Ruby to assemble your Magic Staff." );

			index = AddCraft( typeof( IncognitoMagicStaff ), "FIFTH CIRCLE", "Staff of Incognito", 40.0, 50.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( IncognitoScroll ), "Scroll of Incognito", 1, "You need a scroll of Incognito to assemble your Magic Staff." );
			AddRes( index, typeof( Ruby ), "Gem of Ruby", 5, "You need some Ruby to assemble your Magic Staff." );

			index = AddCraft( typeof( MagicReflectionMagicStaff ), "FIFTH CIRCLE", "Staff of Magic Reflect", 40.0, 50.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( MagicReflectScroll ), "Scroll of Magic Reflect", 1, "You need a scroll of Magic Reflect to assemble your Magic Staff." );
			AddRes( index, typeof( Ruby ), "Gem of Ruby", 5, "You need some Ruby to assemble your Magic Staff." );

			index = AddCraft( typeof( MindBlastMagicStaff ), "FIFTH CIRCLE", "Staff of Mind Blast", 40.0, 50.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( MindBlastScroll ), "Scroll of Mind Blast", 1, "You need a scroll of Mind Blast to assemble your Magic Staff." );
			AddRes( index, typeof( Ruby ), "Gem of Ruby", 5, "You need some Ruby to assemble your Magic Staff." );

			index = AddCraft( typeof( ParalyzeMagicStaff ), "FIFTH CIRCLE", "Staff of Paralyze", 40.0, 50.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( ParalyzeScroll ), "Scroll of Paralyze", 1, "You need a scroll of Paralyze to assemble your Magic Staff." );
			AddRes( index, typeof( Ruby ), "Gem of Ruby", 5, "You need some Ruby to assemble your Magic Staff." );

			index = AddCraft( typeof( PoisonFieldMagicStaff ), "FIFTH CIRCLE", "Staff of Poison Field", 40.0, 50.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( PoisonFieldScroll ), "Scroll of Poison Field", 1, "You need a scroll of Poison Field to assemble your Magic Staff." );
			AddRes( index, typeof( Ruby ), "Gem of Ruby", 5, "You need some Ruby to assemble your Magic Staff." );

			index = AddCraft( typeof( SummonCreatureMagicStaff ), "FIFTH CIRCLE", "Staff of Summon Creature", 40.0, 50.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( SummonCreatureScroll ), "Scroll of Summon Creature", 1, "You need a scroll of Summon Creature to assemble your Magic Staff." );
			AddRes( index, typeof( Ruby ), "Gem of Ruby", 5, "You need some Ruby to assemble your Magic Staff." );

//SIXTH CIRCLE
			index = AddCraft( typeof( DispelMagicStaff ), "SIXTH CIRCLE", "Staff of Dispel", 50.0, 60.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( DispelScroll ), "Scroll of Dispel", 1, "You need a scroll of Dispel to assemble your Magic Staff." );
			AddRes( index, typeof( StarSapphire ), "Gem of StarSapphire", 6, "You need some StarSapphire to assemble your Magic Staff." );

			index = AddCraft( typeof( EnergyBoltMagicStaff ), "SIXTH CIRCLE", "Staff of Energy Bolt", 50.0, 60.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( EnergyBoltScroll ), "Scroll of Energy Bolt", 1, "You need a scroll of Energy Bolt to assemble your Magic Staff." );
			AddRes( index, typeof( StarSapphire ), "Gem of StarSapphire", 6, "You need some StarSapphire to assemble your Magic Staff." );

			index = AddCraft( typeof( ExplosionMagicStaff ), "SIXTH CIRCLE", "Staff of Explosion", 50.0, 60.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( ExplosionScroll ), "Scroll of Explosion", 1, "You need a scroll of Explosionto assemble your Magic Staff." );
			AddRes( index, typeof( StarSapphire ), "Gem of StarSapphire", 6, "You need some StarSapphire to assemble your Magic Staff." );

			index = AddCraft( typeof( InvisibilityMagicStaff ), "SIXTH CIRCLE", "Staff of Invisibility", 50.0, 60.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( InvisibilityScroll ), "Scroll of Invisibility", 1, "You need a scroll of Invisibility to assemble your Magic Staff." );
			AddRes( index, typeof( StarSapphire ), "Gem of StarSapphire", 6, "You need some StarSapphire to assemble your Magic Staff." );

			index = AddCraft( typeof( MarkMagicStaff ), "SIXTH CIRCLE", "Staff of Mark", 50.0, 60.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( MarkScroll ), "Scroll of Mark", 1, "You need a scroll of Mark to assemble your Magic Staff." );
			AddRes( index, typeof( StarSapphire ), "Gem of StarSapphire", 6, "You need some StarSapphire to assemble your Magic Staff." );

			index = AddCraft( typeof( MassCurseMagicStaff ), "SIXTH CIRCLE", "Staff of Mass Curse", 50.0, 60.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( MassCurseScroll ), "Scroll of Mass Curse", 1, "You need a scroll of Mass Curse to assemble your Magic Staff." );
			AddRes( index, typeof( StarSapphire ), "Gem of StarSapphire", 6, "You need some StarSapphire to assemble your Magic Staff." );

			index = AddCraft( typeof( ParalyzeFieldMagicStaff ), "SIXTH CIRCLE", "Staff of Paralyze Field", 50.0, 60.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( ParalyzeFieldScroll ), "Scroll of Paralyze Field", 1, "You need a scroll of Paralyze Field to assemble your Magic Staff." );
			AddRes( index, typeof( StarSapphire ), "Gem of StarSapphire", 6, "You need some StarSapphire to assemble your Magic Staff." );

			index = AddCraft( typeof( RevealMagicStaff ), "SIXTH CIRCLE", "Staff of Reveal", 50.0, 60.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( RevealScroll ), "Scroll of Reveal", 1, "You need a scroll of Reveal to assemble your Magic Staff." );
			AddRes( index, typeof( StarSapphire ), "Gem of StarSapphire", 6, "You need some StarSapphire to assemble your Magic Staff." );

//SEVENTH CIRCLE
			index = AddCraft( typeof( ChainLightningMagicStaff ), "SEVENTH CIRCLE", "Staff of Chain Lightning", 60.0, 70.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( ChainLightningScroll ), "Scroll of Chain Lightning", 1, "You need a scroll of Chain Lightning to assemble your Magic Staff." );
			AddRes( index, typeof( Amethyst ), "Gem of Amethyst", 7, "You need some Amethyst to assemble your Magic Staff." );

			index = AddCraft( typeof( EnergyFieldMagicStaff ), "SEVENTH CIRCLE", "Staff of Energy Field", 60.0, 70.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( EnergyFieldScroll ), "Scroll of Energy Field", 1, "You need a scroll of EnergyField to assemble your Magic Staff." );
			AddRes( index, typeof( Amethyst ), "Gem of Amethyst", 7, "You need some Amethyst to assemble your Magic Staff." );

			index = AddCraft( typeof( FlameStrikeMagicStaff ), "SEVENTH CIRCLE", "Staff of Flame strike", 60.0, 70.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( FlamestrikeScroll ), "Scroll of Flame strike", 1, "You need a scroll of Flame striketo assemble your Magic Staff." );
			AddRes( index, typeof( Amethyst ), "Gem of Amethyst", 7, "You need some Amethyst to assemble your Magic Staff." );

			index = AddCraft( typeof( GateTravelMagicStaff ), "SEVENTH CIRCLE", "Staff of Gate Travel", 60.0, 70.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( GateTravelScroll ), "Scroll of Gate Travel", 1, "You need a scroll of Gate Travelto assemble your Magic Staff." );
			AddRes( index, typeof( Amethyst ), "Gem of Amethyst", 7, "You need some Amethyst to assemble your Magic Staff." );

			index = AddCraft( typeof( ManaVampireMagicStaff ), "SEVENTH CIRCLE", "Staff of Mana Vampire", 60.0, 70.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( ManaVampireScroll ), "Scroll of Mana Vampire", 1, "You need a scroll of Mana Vampire to assemble your Magic Staff." );
			AddRes( index, typeof( Amethyst ), "Gem of Amethyst", 7, "You need some Amethyst to assemble your Magic Staff." );

			index = AddCraft( typeof( MassDispelMagicStaff ), "SEVENTH CIRCLE", "Staff of Mass Dispel", 60.0, 70.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( MassDispelScroll ), "Scroll of Mass Dispel", 1, "You need a scroll of Mass Dispelto assemble your Magic Staff." );
			AddRes( index, typeof( Amethyst ), "Gem of Amethyst", 7, "You need some Amethyst to assemble your Magic Staff." );

			index = AddCraft( typeof( MeteorSwarmMagicStaff ), "SEVENTH CIRCLE", "Staff of Meteor Swarm", 60.0, 70.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( MeteorSwarmScroll ), "Scroll of Meteor Swarm", 1, "You need a scroll of Meteor Swarm to assemble your Magic Staff." );
			AddRes( index, typeof( Amethyst ), "Gem of Amethyst", 7, "You need some Amethyst to assemble your Magic Staff." );

			index = AddCraft( typeof( PolymorphMagicStaff ), "SEVENTH CIRCLE", "Staff of Polymorph", 60.0, 70.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( PolymorphScroll ), "Scroll of Polymorph", 1, "You need a scroll of Polymorph to assemble your Magic Staff." );
			AddRes( index, typeof( Amethyst ), "Gem of Amethyst", 7, "You need some Amethyst to assemble your Magic Staff." );

//EIGHTH CIRCLE
			index = AddCraft( typeof( AirElementalMagicStaff ), "EIGHTH CIRCLE", "Staff of Summon Air Elemental", 70.0, 80.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( SummonAirElementalScroll ), "Scroll of Summon Air Elemental", 1, "You need a scroll of Summon Air Elemental to assemble your Magic Staff." );
			AddRes( index, typeof( Diamond ), "Gem of Diamond", 8, "You need some Diamond to assemble your Magic Staff." );

			index = AddCraft( typeof( EarthElementalMagicStaff ), "EIGHTH CIRCLE", "Staff of Summon Earth Elemental", 70.0, 80.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( SummonEarthElementalScroll ), "Scroll of Summon Earth Elemental", 1, "You need a scroll of Summon Earth Elemental to assemble your Magic Staff." );
			AddRes( index, typeof( Diamond ), "Gem of Diamond", 8, "You need some Diamond to assemble your Magic Staff." );

			index = AddCraft( typeof( FireElementalMagicStaff ), "EIGHTH CIRCLE", "Staff of Summon Fire Elemental", 70.0, 80.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( SummonFireElementalScroll ), "Scroll of Summon Fire Elemental", 1, "You need a scroll of Summon Fire Elemental to assemble your Magic Staff." );
			AddRes( index, typeof( Diamond ), "Gem of Diamond", 8, "You need some Diamond to assemble your Magic Staff." );

			index = AddCraft( typeof( WaterElementalMagicStaff ), "EIGHTH CIRCLE", "Staff of Summon Water Elemental", 70.0, 80.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( SummonWaterElementalScroll ), "Scroll of Summon Water Elemental", 1, "You need a scroll of Summon Water Elemental to assemble your Magic Staff." );
			AddRes( index, typeof( Diamond ), "Gem of Diamond", 8, "You need some Diamond to assemble your Magic Staff." );

			index = AddCraft( typeof( EarthquakeMagicStaff ), "EIGHTH CIRCLE", "Staff of Earthquake", 70.0, 80.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( EarthquakeScroll ), "Scroll of Earthquake", 1, "You need a scroll of Earthquake to assemble your Magic Staff." );
			AddRes( index, typeof( Diamond ), "Gem of Diamond", 8, "You need some Diamond to assemble your Magic Staff." );

			index = AddCraft( typeof( EnergyVortexMagicStaff ), "EIGHTH CIRCLE", "Staff of Energy Vortex", 70.0, 80.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( EnergyVortexScroll ), "Scroll of Energy Vortex", 1, "You need a scroll of Energy Vortex to assemble your Magic Staff." );
			AddRes( index, typeof( Diamond ), "Gem of Diamond", 8, "You need some Diamond to assemble your Magic Staff." );

			index = AddCraft( typeof( ResurrectionMagicStaff ), "EIGHTH CIRCLE", "Staff of Resurrection", 70.0, 80.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( ResurrectionScroll ), "Scroll of Resurrection", 1, "You need a scroll of Resurrection to assemble your Magic Staff." );
			AddRes( index, typeof( Diamond ), "Gem of Diamond", 8, "You need some Diamond to assemble your Magic Staff." );

			index = AddCraft( typeof( SummonDaemonMagicStaff ), "EIGHTH CIRCLE", "Staff of Summon Daemon", 70.0, 80.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( SummonDaemonScroll ), "Scroll of Summon Daemon", 1, "You need a scroll of Summon Daemon to assemble your Magic Staff." );
			AddRes( index, typeof( Diamond ), "Gem of Diamond", 8, "You need some Diamond to assemble your Magic Staff." );

//MISC
			index = AddCraft( typeof( GnarledStaff ), "MISC", "Staff of Item ID", 10.0, 20.0, typeof( GnarledStaff ), "Gnarled Staff", 1, "You need a Gnarled Staff to assemble your Magic Staff." );
			AddSkill( index, SkillName.Tinkering, 5.0, 10.0 );
			AddRes( index, typeof( SummonWaterElementalScroll ), "Scroll of NOT SURE YET", 1, "You need a scroll of NOT SURE YET to assemble your Magic Staff." );
			AddRes( index, typeof( Citrine ), "Gem of Citrine", 9, "You need some Citrine to assemble your Magic Staff." );

			MarkOption = true;
			Repair = Core.AOS;

//			SetSubRes( typeof( GnarledStaff ), 1011413 );

		}
	}
}
