///////////////////////////////////////////
/////      SockeetGemsKey V 2.0       /////
/////      Created by ManofWar        /////
///// 	www.bluedragonsociety.com     /////
/////	        Thanks To:            /////
/////      Modified by Tylius         /////
/////   Modified/Created by Ashlar    /////
/////      Special Thanks to:         /////
///// Ingot Key script by GoldDraco13  /////
///////////////////////////////////////////
///////////////////////////////////
///Sources:
///
///Ingot Key script by GoldDraco13
///Granite Box script by (unknown)
///BankCrystal script by (unknown)
///////////////////////////////////
///////////////////////////////////////////
///Modified/Created by Ashlar, beloved of Morrigan.  
///Modified by Tylius.
//////////////////////////////////////////////

using System;
using System.Collections;
using Server;
using Server.Prompts;
using Server.Mobiles;
using Server.ContextMenus;
using Server.Gumps;
using Server.Items;
using Server.Misc; 
using Server.Network;
using Server.Targeting;
using Server.Multis;
using Server.Regions;


namespace Server.Items
{
	[FlipableAttribute(0xFEF, 0xFF0, 0xFF1, 0xFF2, 0xFF3, 0xFF4, 0xFBD, 0xFBE)]

	public class SocketGemKey : Item
	{
		private int m_ChippedAmethystGem;
		private int m_FlawedAmethystGem;
		private int m_PlainAmethystGem;
		private int m_FlawlessAmethystGem;
		private int m_PerfectAmethystGem;
		private int m_ChippedDiamondGem;
		private int m_FlawedDiamondGem;
		private int m_PlainDiamondGem;
		private int m_FlawlessDiamondGem;
		private int m_PerfectDiamondGem;
		private int m_ChippedEmeraldGem;
		private int m_FlawedEmeraldGem;
		private int m_PlainEmeraldGem;
		private int m_FlawlessEmeraldGem;
		private int m_PerfectEmeraldGem;
		private int m_ChippedRubyGem;
		private int m_FlawedRubyGem;
		private int m_PlainRubyGem;
		private int m_FlawlessRubyGem;
		private int m_PerfectRubyGem;
		private int m_ChippedSapphireGem;
		private int m_FlawedSapphireGem;
		private int m_PlainSapphireGem;
		private int m_FlawlessSapphireGem;
		private int m_PerfectSapphireGem;
		private int m_ChippedSkullGem;
		private int m_FlawedSkullGem;
		private int m_PlainSkullGem;
		private int m_FlawlessSkullGem;
		private int m_PerfectSkullGem;
		private int m_ChippedTopazGem;
		private int m_FlawedTopazGem;
		private int m_PlainTopazGem;
		private int m_FlawlessTopazGem;
		private int m_PerfectTopazGem;
		
		private int m_StorageLimit;

		//This section allows GM's and above to change the amounts of the various properties of the key.
		[CommandProperty(AccessLevel.GameMaster)]
		public int ChippedAmethystGem { get { return m_ChippedAmethystGem; } set { m_ChippedAmethystGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int FlawedAmethystGem { get { return m_FlawedAmethystGem; } set { m_FlawedAmethystGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int PlainAmethystGem { get { return m_PlainAmethystGem; } set { m_PlainAmethystGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int FlawlessAmethystGem { get { return m_FlawlessAmethystGem; } set { m_FlawlessAmethystGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int PerfectAmethystGem { get { return m_PerfectAmethystGem; } set { m_PerfectAmethystGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int ChippedDiamondGem { get { return m_ChippedDiamondGem; } set { m_ChippedDiamondGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int FlawedDiamondGem { get { return m_FlawedDiamondGem; } set { m_FlawedDiamondGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int PlainDiamondGem { get { return m_PlainDiamondGem; } set { m_PlainDiamondGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int FlawlessDiamondGem { get { return m_FlawlessDiamondGem; } set { m_FlawlessDiamondGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int PerfectDiamondGem { get { return m_PerfectDiamondGem; } set { m_PerfectDiamondGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int ChippedEmeraldGem { get { return m_ChippedEmeraldGem; } set { m_ChippedEmeraldGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int FlawedEmeraldGem { get { return m_FlawedEmeraldGem; } set { m_FlawedEmeraldGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int PlainEmeraldGem { get { return m_PlainEmeraldGem; } set { m_PlainEmeraldGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int FlawlessEmeraldGem { get { return m_FlawlessEmeraldGem; } set { m_FlawlessEmeraldGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int PerfectEmeraldGem { get { return m_PerfectEmeraldGem; } set { m_PerfectEmeraldGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int ChippedRubyGem { get { return m_ChippedRubyGem; } set { m_ChippedRubyGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int FlawedRubyGem { get { return m_FlawedRubyGem; } set { m_FlawedRubyGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int PlainRubyGem { get { return m_PlainRubyGem; } set { m_PlainRubyGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int FlawlessRubyGem { get { return m_FlawlessRubyGem; } set { m_FlawlessRubyGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int PerfectRubyGem { get { return m_PerfectRubyGem; } set { m_PerfectRubyGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int ChippedSapphireGem { get { return m_ChippedSapphireGem; } set { m_ChippedSapphireGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int FlawedSapphireGem { get { return m_FlawedSapphireGem; } set { m_FlawedSapphireGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int PlainSapphireGem { get { return m_PlainSapphireGem; } set { m_PlainSapphireGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int FlawlessSapphireGem { get { return m_FlawlessSapphireGem; } set { m_FlawlessSapphireGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int PerfectSapphireGem { get { return m_PerfectSapphireGem; } set { m_PerfectSapphireGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int ChippedSkullGem { get { return m_ChippedSkullGem; } set { m_ChippedSkullGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int FlawedSkullGem { get { return m_FlawedSkullGem; } set { m_FlawedSkullGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int PlainSkullGem { get { return m_PlainSkullGem; } set { m_PlainSkullGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int FlawlessSkullGem { get { return m_FlawlessSkullGem; } set { m_FlawlessSkullGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int PerfectSkullGem { get { return m_PerfectSkullGem; } set { m_PerfectSkullGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int ChippedTopazGem { get { return m_ChippedTopazGem; } set { m_ChippedTopazGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int FlawedTopazGem { get { return m_FlawedTopazGem; } set { m_FlawedTopazGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int PlainTopazGem { get { return m_PlainTopazGem; } set { m_PlainTopazGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int FlawlessTopazGem { get { return m_FlawlessTopazGem; } set { m_FlawlessTopazGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int PerfectTopazGem { get { return m_PerfectTopazGem; } set { m_PerfectTopazGem = value; InvalidateProperties(); } }

		[CommandProperty(AccessLevel.GameMaster)]
		public int StorageLimit { get { return m_StorageLimit; } set { m_StorageLimit = value; InvalidateProperties(); } }


		[Constructable]								//This is the default item you get when you [add SocketGemKey
		public SocketGemKey() : base( 0x176B )
		{
			Movable = true;
			Weight = 1.0;
			Hue = 88;
			Name = "Socket Gem Keys";
			//LootType = LootType.Blessed;
			StorageLimit = 100;

		}

		[Constructable]
		public SocketGemKey(int storageLimit ) : base( 0x176B )
		{
			Movable = true;
			Weight = 10.0;
			Hue = 88;
			Name = "Socket Gem Keys";
			//LootType = LootType.Blessed;
			StorageLimit = storageLimit;

		}
		public override void OnDoubleClick(Mobile from)
		{
			if (!(from is PlayerMobile))
				return;
			if (IsChildOf(from.Backpack))
				from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
			else
				from.SendMessage("This must be in your backpack.");
			/*if (from is PlayerMobile)
			{
				from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
			}*/
		}
		public void BeginCombine(Mobile from)
		{
			from.Target = new SocketGemKeyTarget(this);
		}
		public void EndCombine(Mobile from, object o)
		{
			if (o is Item && ((Item)o).IsChildOf(from.Backpack))
			{
				Item curItem = o as Item;
					if (curItem is ChippedAmethyst)
					{
						if (ChippedAmethystGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (ChippedAmethystGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							ChippedAmethystGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is FlawedAmethyst)
					{
						if (FlawedAmethystGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (FlawedAmethystGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							FlawedAmethystGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is PlainAmethyst)
					{
						if (PlainAmethystGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (PlainAmethystGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							PlainAmethystGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is FlawlessAmethyst)
					{
						if (FlawlessAmethystGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (FlawlessAmethystGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							FlawlessAmethystGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is PerfectAmethyst)
					{
						if (PerfectAmethystGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (PerfectAmethystGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							PerfectAmethystGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					if (curItem is ChippedDiamond)
					{
						if (ChippedDiamondGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (ChippedDiamondGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							ChippedDiamondGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is FlawedDiamond)
					{
						if (FlawedDiamondGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (FlawedDiamondGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							FlawedDiamondGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is PlainDiamond)
					{
						if (PlainDiamondGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (PlainDiamondGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							PlainDiamondGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is FlawlessDiamond)
					{
						if (FlawlessDiamondGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (FlawlessDiamondGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							FlawlessDiamondGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is PerfectDiamond)
					{
						if (PerfectDiamondGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (PerfectDiamondGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							PerfectDiamondGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					if (curItem is ChippedEmerald)
					{
						if (ChippedEmeraldGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (ChippedEmeraldGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							ChippedEmeraldGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is FlawedEmerald)
					{
						if (FlawedEmeraldGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (FlawedEmeraldGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							FlawedEmeraldGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is PlainEmerald)
					{
						if (PlainEmeraldGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (PlainEmeraldGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							PlainEmeraldGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is FlawlessEmerald)
					{
						if (FlawlessEmeraldGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (FlawlessEmeraldGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							FlawlessEmeraldGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is PerfectDiabloEmerald)
					{
						if (PerfectEmeraldGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (PerfectEmeraldGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							PerfectEmeraldGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					if (curItem is ChippedRuby)
					{
						if (ChippedRubyGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (ChippedRubyGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							ChippedRubyGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is FlawedRuby)
					{
						if (FlawedRubyGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (FlawedRubyGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							FlawedRubyGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is PlainRuby)
					{
						if (PlainRubyGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (PlainRubyGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							PlainRubyGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is FlawlessRuby)
					{
						if (FlawlessRubyGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (FlawlessRubyGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							FlawlessRubyGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is PerfectRuby)
					{
						if (PerfectRubyGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (PerfectRubyGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							PerfectRubyGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					if (curItem is ChippedSapphire)
					{
						if (ChippedSapphireGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (ChippedSapphireGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							ChippedSapphireGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is FlawedSapphire)
					{
						if (FlawedSapphireGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (FlawedSapphireGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							FlawedSapphireGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is PlainSapphire)
					{
						if (PlainSapphireGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (PlainSapphireGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							PlainSapphireGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is FlawlessSapphire)
					{
						if (FlawlessSapphireGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (FlawlessSapphireGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							FlawlessSapphireGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is PerfectSapphire)
					{
						if (PerfectSapphireGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (PerfectSapphireGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							PerfectSapphireGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					if (curItem is ChippedSkull)
					{
						if (ChippedSkullGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (ChippedSkullGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							ChippedSkullGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is FlawedSkull)
					{
						if (FlawedSkullGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (FlawedSkullGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							FlawedSkullGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is PlainSkull)
					{
						if (PlainSkullGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (PlainSkullGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							PlainSkullGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is FlawlessSkull)
					{
						if (FlawlessSkullGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (FlawlessSkullGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							FlawlessSkullGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is PerfectSkull)
					{
						if (PerfectSkullGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (PerfectSkullGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							PerfectSkullGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					if (curItem is ChippedTopaz)
					{
						if (ChippedTopazGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (ChippedTopazGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							ChippedTopazGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is FlawedTopaz)
					{
						if (FlawedTopazGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (FlawedTopazGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							FlawedTopazGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is PlainTopaz)
					{
						if (PlainTopazGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (PlainTopazGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							PlainTopazGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is FlawlessTopaz)
					{
						if (FlawlessTopazGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (FlawlessTopazGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							FlawlessTopazGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
					else if (curItem is PerfectTopaz)
					{
						if (PerfectTopazGem + curItem.Amount > StorageLimit)
							from.SendMessage("You are trying to add "+ ( (PerfectTopazGem + curItem.Amount) - m_StorageLimit ) +"  too many! The warehouse can store only "+ m_StorageLimit +" of these.");
						else
						{
							PerfectTopazGem += curItem.Amount;
							curItem.Delete();
							from.SendGump(new SocketGemKeyGump((PlayerMobile)from, this));
							BeginCombine(from);
						}
					}
			}
			else
			{
				from.SendLocalizedMessage(1045158); // You must have the item in your backpack to target it.
			}
		}
		public SocketGemKey(Serial serial) : base( serial )
		{
		}
		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);
			writer.Write( (int) 0 ); // version

			writer.Write((int)m_ChippedAmethystGem);
			writer.Write((int)m_FlawedAmethystGem);
			writer.Write((int)m_PlainAmethystGem);
			writer.Write((int)m_FlawlessAmethystGem);
			writer.Write((int)m_PerfectAmethystGem);
			writer.Write((int)m_ChippedDiamondGem);
			writer.Write((int)m_FlawedDiamondGem);
			writer.Write((int)m_PlainDiamondGem);
			writer.Write((int)m_FlawlessDiamondGem);
			writer.Write((int)m_PerfectDiamondGem);
			writer.Write((int)m_ChippedEmeraldGem);
			writer.Write((int)m_FlawedEmeraldGem);
			writer.Write((int)m_PlainEmeraldGem);
			writer.Write((int)m_FlawlessEmeraldGem);
			writer.Write((int)m_PerfectEmeraldGem);
			writer.Write((int)m_ChippedRubyGem);
			writer.Write((int)m_FlawedRubyGem);
			writer.Write((int)m_PlainRubyGem);
			writer.Write((int)m_FlawlessRubyGem);
			writer.Write((int)m_PerfectRubyGem);
			writer.Write((int)m_ChippedSapphireGem);
			writer.Write((int)m_FlawedSapphireGem);
			writer.Write((int)m_PlainSapphireGem);
			writer.Write((int)m_FlawlessSapphireGem);
			writer.Write((int)m_PerfectSapphireGem);
			writer.Write((int)m_ChippedSkullGem);
			writer.Write((int)m_FlawedSkullGem);
			writer.Write((int)m_PlainSkullGem);
			writer.Write((int)m_FlawlessSkullGem);
			writer.Write((int)m_PerfectSkullGem);
			writer.Write((int)m_ChippedTopazGem);
			writer.Write((int)m_FlawedTopazGem);
			writer.Write((int)m_PlainTopazGem);
			writer.Write((int)m_FlawlessTopazGem);
			writer.Write((int)m_PerfectTopazGem);
			writer.Write((int)m_StorageLimit);
		}
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);
			int version = reader.ReadInt();

			switch ( version )
			{
				case 1:
					goto case 0;
				case 0:
				{
				
					m_ChippedAmethystGem = reader.ReadInt();
					m_FlawedAmethystGem = reader.ReadInt();
					m_PlainAmethystGem = reader.ReadInt(); 
					m_FlawlessAmethystGem = reader.ReadInt();
					m_PerfectAmethystGem = reader.ReadInt();
					m_ChippedDiamondGem = reader.ReadInt();
					m_FlawedDiamondGem = reader.ReadInt();
					m_PlainDiamondGem = reader.ReadInt();
					m_FlawlessDiamondGem = reader.ReadInt();
					m_PerfectDiamondGem = reader.ReadInt();
					m_ChippedEmeraldGem = reader.ReadInt();
					m_FlawedEmeraldGem = reader.ReadInt();
					m_PlainEmeraldGem = reader.ReadInt();
					m_FlawlessEmeraldGem = reader.ReadInt();
					m_PerfectEmeraldGem = reader.ReadInt();
					m_ChippedRubyGem = reader.ReadInt();
					m_FlawedRubyGem = reader.ReadInt();
					m_PlainRubyGem = reader.ReadInt();
					m_FlawlessRubyGem = reader.ReadInt();
					m_PerfectRubyGem = reader.ReadInt();
					m_ChippedSapphireGem = reader.ReadInt();
					m_FlawedSapphireGem = reader.ReadInt();
					m_PlainSapphireGem = reader.ReadInt();
					m_FlawlessSapphireGem = reader.ReadInt();
					m_PerfectSapphireGem = reader.ReadInt();
					m_ChippedSkullGem = reader.ReadInt();
					m_FlawedSkullGem = reader.ReadInt();
					m_PlainSkullGem = reader.ReadInt();
					m_FlawlessSkullGem = reader.ReadInt();
					m_PerfectSkullGem = reader.ReadInt();
					m_ChippedTopazGem = reader.ReadInt();
					m_FlawedTopazGem = reader.ReadInt();
					m_PlainTopazGem = reader.ReadInt();
					m_FlawlessTopazGem = reader.ReadInt();
					m_PerfectTopazGem = reader.ReadInt();
					m_StorageLimit = reader.ReadInt();
					break;
				}
			}
		}
	}
}

namespace Server.Items
{
    public class SocketGemKeyGump : Gump
    {
        private PlayerMobile m_From;
        private SocketGemKey m_Key;

        public SocketGemKeyGump(PlayerMobile from, SocketGemKey key) : base( 25, 25 )
        {
            m_From = from;
            m_Key = key;

            m_From.CloseGump(typeof(SocketGemKeyGump));

            AddPage(0);

            AddBackground(50, 10, 855, 340, 5054);
            AddImageTiled(58, 20, 838, 321, 2624);
            AddAlphaRegion(58, 20, 838, 321);
            
            AddLabel(390, 25, 88, "Socket Gem Warehouse");

            AddLabel(115, 50, 0x486, "Chipped Amethyst");
            AddLabel(225, 50, 0x480, key.ChippedAmethystGem.ToString());
            AddButton(75, 50, 4005, 4007, 1, GumpButtonType.Reply, 0);

            AddLabel(115, 75, 0x486, "Flawed Amethyst");
            AddLabel(225, 75, 0x480, key.FlawedAmethystGem.ToString());
            AddButton(75, 75, 4005, 4007, 2, GumpButtonType.Reply, 0);

            AddLabel(115, 100, 0x486, "Plain Amethyst");
            AddLabel(225, 100, 0x480, key.PlainAmethystGem.ToString());
            AddButton(75, 100, 4005, 4007, 3, GumpButtonType.Reply, 0);

            AddLabel(115, 125, 0x486, "Flawless Amethyst");
            AddLabel(225, 125, 0x480, key.FlawlessAmethystGem.ToString());
            AddButton(75, 125, 4005, 4007, 4, GumpButtonType.Reply, 0);

            AddLabel(115, 150, 0x486, "Perfect Amethyst");
            AddLabel(225, 150, 0x480, key.PerfectAmethystGem.ToString());
            AddButton(75, 150, 4005, 4007, 5, GumpButtonType.Reply, 0);

            AddLabel(115, 200, 0x486, "Chipped Diamond");
            AddLabel(225, 200, 0x480, key.ChippedDiamondGem.ToString());
            AddButton(75, 200, 4005, 4007, 6, GumpButtonType.Reply, 0);

            AddLabel(115, 225, 0x486, "Flawed Diamond");
            AddLabel(225, 225, 0x480, key.FlawedDiamondGem.ToString());
            AddButton(75, 225, 4005, 4007, 7, GumpButtonType.Reply, 0);

            AddLabel(115, 250, 0x486, "Plain Diamond");
            AddLabel(225, 250, 0x480, key.PlainDiamondGem.ToString());
            AddButton(75, 250, 4005, 4007, 8, GumpButtonType.Reply, 0);

            AddLabel(115, 275, 0x486, "Flawless Diamond");
            AddLabel(225, 275, 0x480, key.FlawlessDiamondGem.ToString());
            AddButton(75, 275, 4005, 4007, 9, GumpButtonType.Reply, 0);

		AddLabel(115, 300, 0x486, "Perfect Diamond");
		AddLabel(225, 300, 0x480, key.PerfectDiamondGem.ToString());
		AddButton(75, 300, 4005, 4007, 10, GumpButtonType.Reply, 0);	

		AddLabel(315, 50, 0x486, "Chipped Emerald");
		AddLabel(425, 50, 0x480, key.ChippedEmeraldGem.ToString());
		AddButton(275, 50, 4005, 4007, 11, GumpButtonType.Reply, 0);	

		AddLabel(315, 75, 0x486, "Flawed Emerald");
		AddLabel(425, 75, 0x480, key.FlawedEmeraldGem.ToString());
		AddButton(275, 75, 4005, 4007, 12, GumpButtonType.Reply, 0);	

		AddLabel(315, 100, 0x486, "Plain Emerald");
		AddLabel(425, 100, 0x480, key.PlainEmeraldGem.ToString());
		AddButton(275, 100, 4005, 4007, 13, GumpButtonType.Reply, 0);

		AddLabel(315, 125, 0x486, "Flawless Emerald");
		AddLabel(425, 125, 0x480, key.FlawlessEmeraldGem.ToString());
		AddButton(275, 125, 4005, 4007, 14, GumpButtonType.Reply, 0);

		AddLabel(315, 150, 0x486, "Perfect Emerald");
		AddLabel(425, 150, 0x480, key.PerfectEmeraldGem.ToString());
		AddButton(275, 150, 4005, 4007, 15, GumpButtonType.Reply, 0);	

		AddLabel(315, 200, 0x486, "Chipped Ruby");
		AddLabel(425, 200, 0x480, key.ChippedRubyGem.ToString());
		AddButton(275, 200, 4005, 4007, 16, GumpButtonType.Reply, 0);	

		AddLabel(315, 225, 0x486, "Flawed Ruby");
		AddLabel(425, 225, 0x480, key.FlawedRubyGem.ToString());
		AddButton(275, 225, 4005, 4007, 17, GumpButtonType.Reply, 0);	

		AddLabel(315, 250, 0x486, "Plain Ruby");
		AddLabel(425, 250, 0x480, key.PlainRubyGem.ToString());
		AddButton(275, 250, 4005, 4007, 18, GumpButtonType.Reply, 0);

		AddLabel(315, 275, 0x486, "Flawless Ruby");
		AddLabel(425, 275, 0x480, key.FlawlessRubyGem.ToString());
		AddButton(275, 275, 4005, 4007, 19, GumpButtonType.Reply, 0);

		AddLabel(315, 300, 0x486, "Perfect Ruby");
		AddLabel(425, 300, 0x480, key.PerfectRubyGem.ToString());
		AddButton(275, 300, 4005, 4007, 20, GumpButtonType.Reply, 0);	

		AddLabel(515, 50, 0x486, "Chipped Sapphire");
		AddLabel(625, 50, 0x480, key.ChippedSapphireGem.ToString());
		AddButton(475, 50, 4005, 4007, 21, GumpButtonType.Reply, 0);	

		AddLabel(515, 75, 0x486, "Flawed Sapphire");
		AddLabel(625, 75, 0x480, key.FlawedSapphireGem.ToString());
		AddButton(475, 75, 4005, 4007, 22, GumpButtonType.Reply, 0);	

		AddLabel(515, 100, 0x486, "Plain Sapphire");
		AddLabel(625, 100, 0x480, key.PlainSapphireGem.ToString());
		AddButton(475, 100, 4005, 4007, 23, GumpButtonType.Reply, 0);

		AddLabel(515, 125, 0x486, "Flawless Sapphire");
		AddLabel(625, 125, 0x480, key.FlawlessSapphireGem.ToString());
		AddButton(475, 125, 4005, 4007, 24, GumpButtonType.Reply, 0);

		AddLabel(515, 150, 0x486, "Perfect Sapphire");
		AddLabel(625, 150, 0x480, key.PerfectSapphireGem.ToString());
		AddButton(475, 150, 4005, 4007, 25, GumpButtonType.Reply, 0);	

		AddLabel(515, 200, 0x486, "Chipped Skull");
		AddLabel(625, 200, 0x480, key.ChippedSkullGem.ToString());
		AddButton(475, 200, 4005, 4007, 26, GumpButtonType.Reply, 0);	

		AddLabel(515, 225, 0x486, "Flawed Skull");
		AddLabel(625, 225, 0x480, key.FlawedSkullGem.ToString());
		AddButton(475, 225, 4005, 4007, 27, GumpButtonType.Reply, 0);	

		AddLabel(515, 250, 0x486, "Plain Skull");
		AddLabel(625, 250, 0x480, key.PlainSkullGem.ToString());
		AddButton(475, 250, 4005, 4007, 28, GumpButtonType.Reply, 0);

		AddLabel(515, 275, 0x486, "Flawless Skull");
		AddLabel(625, 275, 0x480, key.FlawlessSkullGem.ToString());
		AddButton(475, 275, 4005, 4007, 29, GumpButtonType.Reply, 0);

		AddLabel(515, 300, 0x486, "Perfect Skull");
		AddLabel(625, 300, 0x480, key.PerfectSkullGem.ToString());
		AddButton(475, 300, 4005, 4007, 30, GumpButtonType.Reply, 0);	

		AddLabel(715, 50, 0x486, "Chipped Topaz");
		AddLabel(825, 50, 0x480, key.ChippedTopazGem.ToString());
		AddButton(675, 50, 4005, 4007, 31, GumpButtonType.Reply, 0);	

		AddLabel(715, 75, 0x486, "Flawed Topaz");
		AddLabel(825, 75, 0x480, key.FlawedTopazGem.ToString());
		AddButton(675, 75, 4005, 4007, 32, GumpButtonType.Reply, 0);	

		AddLabel(715, 100, 0x486, "Plain Topaz");
		AddLabel(825, 100, 0x480, key.PlainTopazGem.ToString());
		AddButton(675, 100, 4005, 4007, 33, GumpButtonType.Reply, 0);

		AddLabel(715, 125, 0x486, "Flawless Topaz");
		AddLabel(825, 125, 0x480, key.FlawlessTopazGem.ToString());
		AddButton(675, 125, 4005, 4007, 34, GumpButtonType.Reply, 0);

		AddLabel(715, 150, 0x486, "Perfect Topaz");
		AddLabel(825, 150, 0x480, key.PerfectTopazGem.ToString());
		AddButton(675, 150, 4005, 4007, 35, GumpButtonType.Reply, 0);

		AddLabel(715, 275, 88, "Each Max:" );
		AddLabel(810, 275, 0x480, key.StorageLimit.ToString() );	

		AddLabel(715, 300, 88, "Add Gem");
		AddButton(810, 300, 4005, 4007, 36, GumpButtonType.Reply, 0);
        }

        public override void OnResponse(NetState sender, RelayInfo info)
        {
            if (m_Key.Deleted)
                return;

            else if (info.ButtonID == 1)
            {
		if (m_Key.ChippedAmethystGem > 0)
                {
                    m_From.AddToBackpack(new ChippedAmethyst());  		//Sends all stored ingots of whichever type to players backpack
                    m_Key.ChippedAmethystGem += -1;				//Sets the count in the key back to 0
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));	//Resets the gump with the new info
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");	//Tell the player he is barking up the wrong tree
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));  	//Resets the gump 
                    m_Key.BeginCombine(m_From);					//Send the player a new in-game target in case more resources are to be added
                }
            }
            else if (info.ButtonID == 2)
            {
		if (m_Key.FlawedAmethystGem > 0)
                {
                    m_From.AddToBackpack(new FlawedAmethyst());  	 
                    m_Key.FlawedAmethystGem += -1;						     	 
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 3)
            {
		if (m_Key.PlainAmethystGem > 0)
                {
                    m_From.AddToBackpack(new PlainAmethyst());  	 
                    m_Key.PlainAmethystGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 4)
            {
		if (m_Key.FlawlessAmethystGem > 0)
                {
                    m_From.AddToBackpack(new FlawlessAmethyst());  	  
                    m_Key.FlawlessAmethystGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 5)
            {
		if (m_Key.PerfectAmethystGem > 0)
                {
                    m_From.AddToBackpack(new PerfectAmethyst());  	  
                    m_Key.PerfectAmethystGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 6)
            {
		if (m_Key.ChippedDiamondGem > 0)
                {
                    m_From.AddToBackpack(new ChippedDiamond());  	  
                    m_Key.ChippedDiamondGem += -1;						     	 
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 7)
            {
		if (m_Key.FlawedDiamondGem > 0)
                {
                    m_From.AddToBackpack(new FlawedDiamond());  
                    m_Key.FlawedDiamondGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 8)
            {
		if (m_Key.PlainDiamondGem > 0)
                {
                    m_From.AddToBackpack(new PlainDiamond());  	
                    m_Key.PlainDiamondGem += -1;						     	 
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 9)
            {
		if (m_Key.FlawlessDiamondGem > 0)
                {
                    m_From.AddToBackpack(new FlawlessDiamond());  	
                    m_Key.FlawlessDiamondGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
		else if (info.ButtonID == 10)
		{
			if (m_Key.PerfectDiamondGem > 0)
			{
				m_From.AddToBackpack(new PerfectDiamond());  	
				m_Key.PerfectDiamondGem += -1;						     	  
				m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
			}
			else
			{
				m_From.SendMessage("You do not have any of that Gem!");
				m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
				m_Key.BeginCombine(m_From);
			}
		}
            else if (info.ButtonID == 11)
            {
		if (m_Key.ChippedEmeraldGem > 0)
                {
                    m_From.AddToBackpack(new ChippedEmerald());  	  
                    m_Key.ChippedEmeraldGem += -1;						     	 
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 12)
            {
		if (m_Key.FlawedEmeraldGem > 0)
                {
                    m_From.AddToBackpack(new FlawedEmerald());  
                    m_Key.FlawedEmeraldGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 13)
            {
		if (m_Key.PlainEmeraldGem > 0)
                {
                    m_From.AddToBackpack(new PlainEmerald());  	
                    m_Key.PlainEmeraldGem += -1;						     	 
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 14)
            {
		if (m_Key.FlawlessEmeraldGem > 0)
                {
                    m_From.AddToBackpack(new FlawlessEmerald());  	
                    m_Key.FlawlessEmeraldGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
		else if (info.ButtonID == 15)
		{
			if (m_Key.PerfectEmeraldGem > 0)
			{
				m_From.AddToBackpack(new PerfectDiabloEmerald());  	
				m_Key.PerfectEmeraldGem += -1;						     	  
				m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
			}
			else
			{
				m_From.SendMessage("You do not have any of that Gem!");
				m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
				m_Key.BeginCombine(m_From);
			}
		}
            else if (info.ButtonID == 16)
            {
		if (m_Key.ChippedRubyGem > 0)
                {
                    m_From.AddToBackpack(new ChippedRuby());  	  
                    m_Key.ChippedRubyGem += -1;						     	 
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 17)
            {
		if (m_Key.FlawedRubyGem > 0)
                {
                    m_From.AddToBackpack(new FlawedRuby());  
                    m_Key.FlawedRubyGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 18)
            {
		if (m_Key.PlainRubyGem > 0)
                {
                    m_From.AddToBackpack(new PlainRuby());  	
                    m_Key.PlainRubyGem += -1;						     	 
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 19)
            {
		if (m_Key.FlawlessRubyGem > 0)
                {
                    m_From.AddToBackpack(new FlawlessRuby());  	
                    m_Key.FlawlessRubyGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
		else if (info.ButtonID == 20)
		{
			if (m_Key.PerfectRubyGem > 0)
			{
				m_From.AddToBackpack(new PerfectRuby());  	
				m_Key.PerfectRubyGem += -1;						     	  
				m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
			}
			else
			{
				m_From.SendMessage("You do not have any of that Gem!");
				m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
				m_Key.BeginCombine(m_From);
			}
		}
            else if (info.ButtonID == 21)
            {
		if (m_Key.ChippedSapphireGem > 0)
                {
                    m_From.AddToBackpack(new ChippedSapphire());  	  
                    m_Key.ChippedSapphireGem += -1;						     	 
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 22)
            {
		if (m_Key.FlawedSapphireGem > 0)
                {
                    m_From.AddToBackpack(new FlawedSapphire());  
                    m_Key.FlawedSapphireGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 23)
            {
		if (m_Key.PlainSapphireGem > 0)
                {
                    m_From.AddToBackpack(new PlainSapphire());  	
                    m_Key.PlainSapphireGem += -1;						     	 
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 24)
            {
		if (m_Key.FlawlessSapphireGem > 0)
                {
                    m_From.AddToBackpack(new FlawlessSapphire());  	
                    m_Key.FlawlessSapphireGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
		else if (info.ButtonID == 25)
		{
			if (m_Key.PerfectSapphireGem > 0)
			{
				m_From.AddToBackpack(new PerfectSapphire());  	
				m_Key.PerfectSapphireGem += -1;						     	  
				m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
			}
			else
			{
				m_From.SendMessage("You do not have any of that Gem!");
				m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
				m_Key.BeginCombine(m_From);
			}
		}
            else if (info.ButtonID == 26)
            {
		if (m_Key.ChippedSkullGem > 0)
                {
                    m_From.AddToBackpack(new ChippedSkull());  	  
                    m_Key.ChippedSkullGem += -1;						     	 
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 27)
            {
		if (m_Key.FlawedSkullGem > 0)
                {
                    m_From.AddToBackpack(new FlawedSkull());  
                    m_Key.FlawedSkullGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 28)
            {
		if (m_Key.PlainSkullGem > 0)
                {
                    m_From.AddToBackpack(new PlainSkull());  	
                    m_Key.PlainSkullGem += -1;						     	 
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 29)
            {
		if (m_Key.FlawlessSkullGem > 0)
                {
                    m_From.AddToBackpack(new FlawlessSkull());  	
                    m_Key.FlawlessSkullGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
		else if (info.ButtonID == 30)
		{
			if (m_Key.PerfectSkullGem > 0)
			{
				m_From.AddToBackpack(new PerfectSkull());  	
				m_Key.PerfectSkullGem += -1;						     	  
				m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
			}
			else
			{
				m_From.SendMessage("You do not have any of that Gem!");
				m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
				m_Key.BeginCombine(m_From);
			}
		}
            else if (info.ButtonID == 31)
            {
		if (m_Key.ChippedTopazGem > 0)
                {
                    m_From.AddToBackpack(new ChippedTopaz());  	  
                    m_Key.ChippedTopazGem += -1;						     	 
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 32)
            {
		if (m_Key.FlawedTopazGem > 0)
                {
                    m_From.AddToBackpack(new FlawedTopaz());  
                    m_Key.FlawedTopazGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 33)
            {
		if (m_Key.PlainTopazGem > 0)
                {
                    m_From.AddToBackpack(new PlainTopaz());  	
                    m_Key.PlainTopazGem += -1;						     	 
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
            else if (info.ButtonID == 34)
            {
		if (m_Key.FlawlessTopazGem > 0)
                {
                    m_From.AddToBackpack(new FlawlessTopaz());  	
                    m_Key.FlawlessTopazGem += -1;						     	  
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
                }
                else
                {
                    m_From.SendMessage("You do not have any of that Gem!");
                    m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                    m_Key.BeginCombine(m_From);
                }
            }
		else if (info.ButtonID == 35)
		{
			if (m_Key.PerfectTopazGem > 0)
			{
				m_From.AddToBackpack(new PerfectTopaz());  	
				m_Key.PerfectTopazGem += -1;						     	  
				m_From.SendGump(new SocketGemKeyGump(m_From, m_Key)); 
			}
			else
			{
				m_From.SendMessage("You do not have any of that Gem!");
				m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
				m_Key.BeginCombine(m_From);
			}
		}
		else if (info.ButtonID == 36)
            {
                m_From.SendGump(new SocketGemKeyGump(m_From, m_Key));
                m_Key.BeginCombine(m_From);
            }
        }
    }
}

namespace Server.Items
{
    public class SocketGemKeyTarget : Target
    {
        private SocketGemKey m_Key;

        public SocketGemKeyTarget(SocketGemKey key) : base( 18, false, TargetFlags.None )
        {
            m_Key = key;
        }

        protected override void OnTarget(Mobile from, object targeted)
        {
            if (m_Key.Deleted)
                return;

            m_Key.EndCombine(from, targeted);
        }
    }
}
