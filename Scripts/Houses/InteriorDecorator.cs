using System;
using Server;
using Server.Network;
using Server.Multis;
using Server.Regions;
using Server.Spells;
using Server.Gumps;
using Server.Targeting;

namespace Server.Items
{
	public enum DecorateCommand
	{
		None,
		Turn,
		Up,
		Down,
		North,
		East,
		South,
		West,
		Lock,
		Secure,
		Release,
		Deed,
		Trash,
		Close
	}

	public class InteriorDecorator : Item
	{
		private DecorateCommand m_Command;

		[CommandProperty( AccessLevel.GameMaster )]
		public DecorateCommand Command{ get{ return m_Command; } set{ m_Command = value; InvalidateProperties(); } }

		[Constructable]
		public InteriorDecorator() : base( 0x1EBA )
		{
			Name = "Homeowner Tools";
			Weight = 1.0;
		}

		public InteriorDecorator( Serial serial ) : base( serial )
		{
		}

		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties( list );
			list.Add( "For Easier Home Management" );
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

		public override void OnDoubleClick( Mobile from )
		{
			if ( !CheckUse( this, from ) )
				return;

			from.CloseGump( typeof( InternalGump ) );
			from.SendGump( new InternalGump( this ) );
		}

		public static bool InHouse( Mobile from )
		{
			BaseHouse house = BaseHouse.FindHouseAt( from );
			return ( house != null && house.IsCoOwner( from ) );
		}

		public static bool CheckUse( InteriorDecorator tool, Mobile from )
		{
			if ( !InHouse( from ) )
				from.SendLocalizedMessage( 502092 ); // You must be in your house to do this.
			else
				return true;

			return false;
		}

		private class InternalGump : Gump
		{
			private InteriorDecorator m_Decorator;

			public InternalGump( InteriorDecorator decorator ) : base( 25, 25 )
			{
				m_Decorator = decorator;

				this.Closable=true;
				this.Disposable=true;
				this.Dragable=true;
				this.Resizable=false;

				AddPage(0);
				AddImage(0, 0, 164);
				AddImage(0, 150, 164);
				AddImage(0, 300, 164);
				AddImage(0, 438, 164);
				AddImage(2, 2, 165);
				AddImage(2, 148, 165);
				AddImage(2, 294, 165);
				AddImage(2, 440, 165);
				AddImage(90, 8, 131);
				AddItem(6, 6, 8960);

				AddButton(7, 82, 4005, 4005, 1, GumpButtonType.Reply, 0);
				AddHtml( 42, 82, 90, 21, @"<BODY><BASEFONT Color=#FCFF00><BIG>Turn</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddButton(7, 115, 4005, 4005, 2, GumpButtonType.Reply, 0);
				AddHtml( 42, 115, 90, 21, @"<BODY><BASEFONT Color=#FCFF00><BIG>Up</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddButton(7, 148, 4005, 4005, 3, GumpButtonType.Reply, 0);
				AddHtml( 42, 148, 90, 21, @"<BODY><BASEFONT Color=#FCFF00><BIG>Down</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddButton(7, 181, 4005, 4005, 4, GumpButtonType.Reply, 0);
				AddHtml( 42, 181, 90, 21, @"<BODY><BASEFONT Color=#FCFF00><BIG>North</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddButton(7, 214, 4005, 4005, 5, GumpButtonType.Reply, 0);
				AddHtml( 42, 214, 90, 21, @"<BODY><BASEFONT Color=#FCFF00><BIG>East</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddButton(7, 247, 4005, 4005, 6, GumpButtonType.Reply, 0);
				AddHtml( 42, 247, 90, 21, @"<BODY><BASEFONT Color=#FCFF00><BIG>South</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddButton(7, 280, 4005, 4005, 7, GumpButtonType.Reply, 0);
				AddHtml( 42, 280, 90, 21, @"<BODY><BASEFONT Color=#FCFF00><BIG>West</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddButton(7, 313, 4005, 4005, 8, GumpButtonType.Reply, 0);
				AddHtml( 42, 313, 90, 21, @"<BODY><BASEFONT Color=#FCFF00><BIG>Lock</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddButton(7, 346, 4005, 4005, 9, GumpButtonType.Reply, 0);
				AddHtml( 42, 346, 90, 21, @"<BODY><BASEFONT Color=#FCFF00><BIG>Secure</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddButton(7, 379, 4005, 4005, 10, GumpButtonType.Reply, 0);
				AddHtml( 42, 379, 90, 21, @"<BODY><BASEFONT Color=#FCFF00><BIG>Release</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddButton(7, 412, 4005, 4005, 11, GumpButtonType.Reply, 0);
				AddHtml( 42, 412, 90, 21, @"<BODY><BASEFONT Color=#FCFF00><BIG>Flip Deed</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddButton(7, 445, 4005, 4005, 12, GumpButtonType.Reply, 0);
				AddHtml( 42, 445, 90, 21, @"<BODY><BASEFONT Color=#FCFF00><BIG>Trash</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddButton(7, 478, 4017, 4017, 13, GumpButtonType.Reply, 0);
				AddHtml( 42, 478, 90, 21, @"<BODY><BASEFONT Color=#FCFF00><BIG>Close</BIG></BASEFONT></BODY>", (bool)false, (bool)false);

				AddItem(63, 540, 8928);
				AddItem(8, 514, 8955);
				AddItem(110, 509, 8949);
			}

			public override void OnResponse( NetState sender, RelayInfo info )
			{
				Mobile from = sender.Mobile; 

				DecorateCommand command = DecorateCommand.None;

				switch ( info.ButtonID )
				{
					case 1: command = DecorateCommand.Turn; break;
					case 2: command = DecorateCommand.Up; break;
					case 3: command = DecorateCommand.Down; break;
					case 4: command = DecorateCommand.North; break;
					case 5: command = DecorateCommand.East; break;
					case 6: command = DecorateCommand.South; break;
					case 7: command = DecorateCommand.West; break;
					case 8: command = DecorateCommand.Lock; break;
					case 9: command = DecorateCommand.Secure; break;
					case 10: command = DecorateCommand.Release; break;
					case 11: command = DecorateCommand.Deed; break;
					case 12: command = DecorateCommand.Trash; break;
					case 13: command = DecorateCommand.Close; break;
				}

				if ( command == DecorateCommand.Lock )
				{
					int[] commandi = new int[] { 0x0023 };
					from.DoSpeech( "", commandi, 0, 52 );
				}
				else if ( command == DecorateCommand.Secure )
				{
					int[] commandi = new int[] { 0x0025 };
					from.DoSpeech( "", commandi, 0, 52 );
				}
				else if ( command == DecorateCommand.Release )
				{
					int[] commandi = new int[] { 0x0024 };
					from.DoSpeech( "", commandi, 0, 52 );
				}
				else if ( command == DecorateCommand.Trash )
				{
					int[] commandi = new int[] { 0x0028 };
					from.DoSpeech( "", commandi, 0, 52 );
				}
				else if ( command == DecorateCommand.Close )
				{
					from.CloseGump( typeof( InternalGump ) );
				}
				else if ( command != DecorateCommand.None )
				{
					m_Decorator.Command = command;
					sender.Mobile.Target = new InternalTarget( m_Decorator );
				}

				if ( command != DecorateCommand.Close ) { from.CloseGump( typeof( InternalGump ) ); from.SendGump( new InternalGump( m_Decorator ) ); }
			}
		}

		private class InternalTarget : Target
		{
			private InteriorDecorator m_Decorator;

			public InternalTarget( InteriorDecorator decorator ) : base( -1, false, TargetFlags.None )
			{
				CheckLOS = false;
				m_Decorator = decorator;
			}

			protected override void OnTargetNotAccessible( Mobile from, object targeted )
			{
				OnTarget( from, targeted );
			}

			protected override void OnTarget( Mobile from, object targeted )
			{
				if ( targeted is Item && InteriorDecorator.CheckUse( m_Decorator, from ) )
				{
					BaseHouse house = BaseHouse.FindHouseAt( from );
					Item item = (Item)targeted;

					if ( house == null || !house.IsCoOwner( from ) )
					{
						from.SendLocalizedMessage( 502092 ); // You must be in your house to do this.
					}
					else if ( item.Parent != null || !house.IsInside( item ) )
					{
						from.SendLocalizedMessage( 1042270 ); // That is not in your house.
					}
					else if ( item is VendorRentalContract )
					{
						from.SendLocalizedMessage( 1062491 ); // You cannot use the house decorator on that object.
					}
					else
					{
						switch ( m_Decorator.Command )
						{
							case DecorateCommand.Up:		Up( item, from );			break;
							case DecorateCommand.Down:		Down( item, from );			break;
							case DecorateCommand.Turn:		Turn( item, from );			break;
							case DecorateCommand.North:		North( item, from, house );	break;
							case DecorateCommand.East:		East( item, from, house );	break;
							case DecorateCommand.South:		South( item, from, house );	break;
							case DecorateCommand.West:		West( item, from, house );	break;
							case DecorateCommand.Deed:		Deed( item, from );			break;
						}
					}
				}

				from.Target = new InternalTarget( m_Decorator );
			}

			private static void Turn( Item item, Mobile from )
			{
				FlipableAttribute[] attributes = (FlipableAttribute[])item.GetType().GetCustomAttributes( typeof( FlipableAttribute ), false );

				if( item is BaseDoor )
				{
					from.SendMessage("You cannot move doors around with this.");
				}
				else if( item is WaxPainting )
				{
					WaxPainting sPainting = (WaxPainting)item;
					if ( item.ItemID == sPainting.PaintingFlipID1 ){ item.ItemID = sPainting.PaintingFlipID2; } else { item.ItemID = sPainting.PaintingFlipID1; }
				}
				else if( attributes.Length > 0 )
				{
					attributes[0].Flip( item );
				}
				else if( item is Container ) // FORCE FLIP SOME CONTAINERS THAT DON'T HAVE FLIP ATTRIBUTES
				{
					bool FlipMe = true;

					if( item is StolenChest )
					{
						StolenChest sBox = (StolenChest)item;
						if ( item.ItemID == sBox.ContainerFlip ){ item.ItemID = sBox.ContainerID; } else { item.ItemID = sBox.ContainerFlip; FlipMe = false; }

						if ( sBox.ContainerFlip > 0 && sBox.ContainerID > 0 && sBox.ContainerID != sBox.ContainerFlip ){ FlipMe = false; }
					}
					else if( item is HiddenBox )
					{
						HiddenBox sBox = (HiddenBox)item;
						if ( item.ItemID == sBox.ContainerFlip ){ item.ItemID = sBox.ContainerID; } else { item.ItemID = sBox.ContainerFlip; FlipMe = false; }

						if ( sBox.ContainerFlip > 0 && sBox.ContainerID > 0 && sBox.ContainerID != sBox.ContainerFlip ){ FlipMe = false; }
					}

					if ( FlipMe )
					{
						if ( item.ItemID == 0xE42 ){ item.ItemID = 0xE43; }
						else if ( item.ItemID == 0xE40 ){ item.ItemID = 0xE41; }
						else if ( item.ItemID == 0x2811 ){ item.ItemID = 0x2812; }
						else if ( item.ItemID == 0x2813 ){ item.ItemID = 0x2814; }
						else if ( item.ItemID == 0x9AA ){ item.ItemID = 0xE7D; }
						else if ( item.ItemID == 0x9A8 ){ item.ItemID = 0xE80; }
						else if ( item.ItemID == 0xE75 ){ item.ItemID = 0x9B2; }
						else if ( item.ItemID == 0xE3D ){ item.ItemID = 0xE3C; }
						else if ( item.ItemID == 0xE3F ){ item.ItemID = 0xE3E; }
						else if ( item.ItemID == 0x1AFC ){ item.ItemID = 0x1AFD; }
						else if ( item.ItemID == 0x1AFE ){ item.ItemID = 0x1AFF; }
						else if ( item.ItemID == 0x27E0 ){ item.ItemID = 0x280A; }
						else if ( item.ItemID == 0x2802 ){ item.ItemID = 0x2803; }
						else if ( item.ItemID == 0x1AFE ){ item.ItemID = 0x1AFF; }
						else if ( item.ItemID == 0x27E0 ){ item.ItemID = 0x280A; }
						else if ( item.ItemID == 0x2802 ){ item.ItemID = 0x2803; }
						else if ( item.ItemID == 0x39A0 ){ item.ItemID = 0x39A1; }
						else if ( item.ItemID == 0x39A1 ){ item.ItemID = 0x39A0; }
						else if ( item.ItemID == 0x39BD ){ item.ItemID = 0x39BE; }
						else if ( item.ItemID == 0x39BE ){ item.ItemID = 0x39BD; }
						else if ( item.ItemID == 0x3A07 ){ item.ItemID = 0x3A08; }
						else if ( item.ItemID == 0x3A08 ){ item.ItemID = 0x3A07; }
						else if ( item.ItemID == 0x2800 ){ item.ItemID = 0x2801; }
						else if ( item.ItemID == 0x27E9 ){ item.ItemID = 0x27EA; }
						else if ( item.ItemID == 0xE43 ){ item.ItemID = 0xE42; }
						else if ( item.ItemID == 0xE41 ){ item.ItemID = 0xE40; }
						else if ( item.ItemID == 0x2812 ){ item.ItemID = 0x2811; }
						else if ( item.ItemID == 0x2814 ){ item.ItemID = 0x2813; }
						else if ( item.ItemID == 0xE7D ){ item.ItemID = 0x9AA; }
						else if ( item.ItemID == 0xE80 ){ item.ItemID = 0x9A8; }
						else if ( item.ItemID == 0x9B2 ){ item.ItemID = 0xE75; }
						else if ( item.ItemID == 0xE3C ){ item.ItemID = 0xE3D; }
						else if ( item.ItemID == 0xE3E ){ item.ItemID = 0xE3F; }
						else if ( item.ItemID == 0x1AFD ){ item.ItemID = 0x1AFC; }
						else if ( item.ItemID == 0x1AFF ){ item.ItemID = 0x1AFE; }
						else if ( item.ItemID == 0x280A ){ item.ItemID = 0x27E0; }
						else if ( item.ItemID == 0x2803 ){ item.ItemID = 0x2802; }
						else if ( item.ItemID == 0x2801 ){ item.ItemID = 0x2800; }
						else if ( item.ItemID == 0x27EA ){ item.ItemID = 0x27E9; }
						else if ( item.ItemID == 0x280B ){ item.ItemID = 0x280C; }
						else if ( item.ItemID == 0x280D ){ item.ItemID = 0x280E; }
						else if ( item.ItemID == 0x280F ){ item.ItemID = 0x2810; }
						else if ( item.ItemID == 0x281D ){ item.ItemID = 0x281E; }
						else if ( item.ItemID == 0x281F ){ item.ItemID = 0x2820; }
						else if ( item.ItemID == 0x2821 ){ item.ItemID = 0x2822; }
						else if ( item.ItemID == 0x2823 ){ item.ItemID = 0x2824; }
						else if ( item.ItemID == 0x2825 ){ item.ItemID = 0x2826; }
						else if ( item.ItemID == 0x2DF1 ){ item.ItemID = 0x2DF2; }
						else if ( item.ItemID == 0x2DF3 ){ item.ItemID = 0x2DF4; }
						else if ( item.ItemID == 0x3330 ){ item.ItemID = 0x3331; }
						else if ( item.ItemID == 0x3332 ){ item.ItemID = 0x3333; }
						else if ( item.ItemID == 0x3334 ){ item.ItemID = 0x3335; }
						else if ( item.ItemID == 0x3336 ){ item.ItemID = 0x3337; }
						else if ( item.ItemID == 0x4025 ){ item.ItemID = 0x4026; }
						else if ( item.ItemID == 0x4102 ){ item.ItemID = 0x4106; }
						else if ( item.ItemID == 0x4910 ){ item.ItemID = 0x4911; }
						else if ( item.ItemID == 0x280C ){ item.ItemID = 0x280B; }
						else if ( item.ItemID == 0x280E ){ item.ItemID = 0x280D; }
						else if ( item.ItemID == 0x2810 ){ item.ItemID = 0x280F; }
						else if ( item.ItemID == 0x281E ){ item.ItemID = 0x281D; }
						else if ( item.ItemID == 0x2820 ){ item.ItemID = 0x281F; }
						else if ( item.ItemID == 0x2822 ){ item.ItemID = 0x2821; }
						else if ( item.ItemID == 0x2824 ){ item.ItemID = 0x2823; }
						else if ( item.ItemID == 0x2826 ){ item.ItemID = 0x2825; }
						else if ( item.ItemID == 0x2DF2 ){ item.ItemID = 0x2DF1; }
						else if ( item.ItemID == 0x2DF4 ){ item.ItemID = 0x2DF3; }
						else if ( item.ItemID == 0x3331 ){ item.ItemID = 0x3330; }
						else if ( item.ItemID == 0x3333 ){ item.ItemID = 0x3332; }
						else if ( item.ItemID == 0x3335 ){ item.ItemID = 0x3334; }
						else if ( item.ItemID == 0x3337 ){ item.ItemID = 0x3336; }
						else if ( item.ItemID == 0x4026 ){ item.ItemID = 0x4025; }
						else if ( item.ItemID == 0x4106 ){ item.ItemID = 0x4102; }
						else if ( item.ItemID == 0x4911 ){ item.ItemID = 0x4910; }
					}
				}
				else
				{
					if ( item.ItemID == 8784 ){ item.ItemID = 8785; }
					else if ( item.ItemID == 8782 ){ item.ItemID = 8783; }
					else if ( item.ItemID == 0x1AEE ){ item.ItemID = 0x1AEF; }
					else if ( item.ItemID == 0x3DCC ){ item.ItemID = 0x3DCD; }
					else if ( item.ItemID == 0x3DE0 ){ item.ItemID = 0x3DE1; }
					else if ( item.ItemID == 0x224 ){ item.ItemID = 0x225; }
					else if ( item.ItemID == 8785 ){ item.ItemID = 8784; }
					else if ( item.ItemID == 8783 ){ item.ItemID = 8782; }
					else if ( item.ItemID == 0x1AEF ){ item.ItemID = 0x1AEE; }
					else if ( item.ItemID == 0x3DCD ){ item.ItemID = 0x3DCC; }
					else if ( item.ItemID == 0x3DE1 ){ item.ItemID = 0x3DE0; }
					else if ( item.ItemID == 0x225 ){ item.ItemID = 0x224; }
					else if ( item.ItemID == 0x3158 ){ item.ItemID = 0x3159; }
					else if ( item.ItemID == 0x3159 ){ item.ItemID = 0x3158; }
					else if ( item.ItemID == 0x3912 ){ item.ItemID = 0x3913; }
					else if ( item.ItemID == 0x3913 ){ item.ItemID = 0x3912; }
					else if ( item.ItemID == 0x3944 ){ item.ItemID = 0x3945; }
					else if ( item.ItemID == 0x3945 ){ item.ItemID = 0x3944; }
					else if ( item.ItemID == 0x2A79 ){ item.ItemID = 0x2A7A; }
					else if ( item.ItemID == 0x2A7A ){ item.ItemID = 0x2A79; }
					else if ( item.ItemID == 0x2A75 ){ item.ItemID = 0x2A76; }
					else if ( item.ItemID == 0x2A76 ){ item.ItemID = 0x2A75; }
					else if ( item.ItemID == 0x2A71 ){ item.ItemID = 0x2A72; }
					else if ( item.ItemID == 0x2A72 ){ item.ItemID = 0x2A71; }
					else if ( item.ItemID == 0x2A77 ){ item.ItemID = 0x2A78; }
					else if ( item.ItemID == 0x2A78 ){ item.ItemID = 0x2A77; }
					else if ( item.ItemID == 0x2A73 ){ item.ItemID = 0x2A74; }
					else if ( item.ItemID == 0x2A74 ){ item.ItemID = 0x2A73; }
					else if ( item.ItemID == 0x1E6A ){ item.ItemID = 0x1E63; }
					else if ( item.ItemID == 0x1E63 ){ item.ItemID = 0x1E6A; }
					else if ( item.ItemID == 0x1E68 ){ item.ItemID = 0x1E61; }
					else if ( item.ItemID == 0x1E61 ){ item.ItemID = 0x1E68; }
					else if ( item.ItemID == 0x1E6B ){ item.ItemID = 0x1E64; }
					else if ( item.ItemID == 0x1E64 ){ item.ItemID = 0x1E6B; }
					else if ( item.ItemID == 0x1E6D ){ item.ItemID = 0x1E66; }
					else if ( item.ItemID == 0x1E66 ){ item.ItemID = 0x1E6D; }
					else if ( item.ItemID == 0x1E6C ){ item.ItemID = 0x1E65; }
					else if ( item.ItemID == 0x1E65 ){ item.ItemID = 0x1E6C; }
					else if ( item.ItemID == 0x1E67 ){ item.ItemID = 0x1E60; }
					else if ( item.ItemID == 0x1E60 ){ item.ItemID = 0x1E67; }
					else if ( item.ItemID == 0x392D ){ item.ItemID = 0x392C; } // black daemon
					else if ( item.ItemID == 0x392C ){ item.ItemID = 0x392D; } // black daemon
					else if ( item.ItemID == 0x3933 ){ item.ItemID = 0x3932; }
					else if ( item.ItemID == 0x3932 ){ item.ItemID = 0x3933; }
					else if ( item.ItemID == 0x393D ){ item.ItemID = 0x393C; }
					else if ( item.ItemID == 0x393C ){ item.ItemID = 0x393D; }
					else if ( item.ItemID == 0x3931 ){ item.ItemID = 0x3930; }
					else if ( item.ItemID == 0x3930 ){ item.ItemID = 0x3931; }
					else if ( item.ItemID == 0x3935 ){ item.ItemID = 0x3934; }
					else if ( item.ItemID == 0x3934 ){ item.ItemID = 0x3935; }
					else if ( item.ItemID == 0x392B ){ item.ItemID = 0x392A; }
					else if ( item.ItemID == 0x392A ){ item.ItemID = 0x392B; }
					else if ( item.ItemID == 0x3937 ){ item.ItemID = 0x3936; }
					else if ( item.ItemID == 0x3936 ){ item.ItemID = 0x3937; }
					else if ( item.ItemID == 0x393F ){ item.ItemID = 0x393E; }
					else if ( item.ItemID == 0x393E ){ item.ItemID = 0x393F; }
					else if ( item.ItemID == 0x392F ){ item.ItemID = 0x392E; }
					else if ( item.ItemID == 0x392E ){ item.ItemID = 0x392F; }
					else if ( item.ItemID == 0x393B ){ item.ItemID = 0x393A; }
					else if ( item.ItemID == 0x393A ){ item.ItemID = 0x393B; }
					else if ( item.ItemID == 0x2235 ){ item.ItemID = 0x2234; }
					else if ( item.ItemID == 0x2234 ){ item.ItemID = 0x2235; }
					else if ( item.ItemID == 0x21FB ){ item.ItemID = 0x21FA; }
					else if ( item.ItemID == 0x21FA ){ item.ItemID = 0x21FB; }
					else if ( item.ItemID == 0x270D ){ item.ItemID = 0x270E; }
					else if ( item.ItemID == 0x270E ){ item.ItemID = 0x270D; }
					else if ( item.ItemID == 0x21F9 ){ item.ItemID = 0x21F8; }
					else if ( item.ItemID == 0x21F8 ){ item.ItemID = 0x21F9; }
					else if ( item.ItemID == 0x21F7 ){ item.ItemID = 0x21F6; }
					else if ( item.ItemID == 0x21F6 ){ item.ItemID = 0x21F7; }
					else if ( item.ItemID == 0x44E8 ){ item.ItemID = 0x44E7; }
					else if ( item.ItemID == 0x44E7 ){ item.ItemID = 0x44E8; }
					else if ( item.ItemID == 0x1E69 ){ item.ItemID = 0x1E62; }
					else if ( item.ItemID == 0x1E62 ){ item.ItemID = 0x1E69; }
					else if ( item.ItemID == 0x3352 ){ item.ItemID = 0x3353; } //mounted abyss giant
					else if ( item.ItemID == 0x3353 ){ item.ItemID = 0x3352; } //mounted abyss giant
					else if ( item.ItemID == 0x3354 ){ item.ItemID = 0x3355; } //mounted abyss ogre
					else if ( item.ItemID == 0x3355 ){ item.ItemID = 0x3354; } //mounted abyss ogre
					else if ( item.ItemID == 0x3356 ){ item.ItemID = 0x3357; } //mounted ancient cyclops
					else if ( item.ItemID == 0x3357 ){ item.ItemID = 0x3356; } //mounted ancient cyclops
					else if ( item.ItemID == 0x3358 ){ item.ItemID = 0x3359; } //mounted ancient drake
					else if ( item.ItemID == 0x3359 ){ item.ItemID = 0x3358; } //mounted ancient drake
					else if ( item.ItemID == 0x335A ){ item.ItemID = 0x335B; } //mounted cerberus
					else if ( item.ItemID == 0x335B ){ item.ItemID = 0x335A; } //mounted cerberus
					else if ( item.ItemID == 0x335C ){ item.ItemID = 0x335D; } //mounted storm giant
					else if ( item.ItemID == 0x335D ){ item.ItemID = 0x335C; } //mounted storm giant
					else if ( item.ItemID == 0x335E ){ item.ItemID = 0x335F; } //mounted dark unicorn
					else if ( item.ItemID == 0x335F ){ item.ItemID = 0x335E; } //mounted dark unicorn
					else if ( item.ItemID == 0x3360 ){ item.ItemID = 0x3361; } //mounted deep sea giant
					else if ( item.ItemID == 0x3361 ){ item.ItemID = 0x3360; } //mounted deep sea giant
					else if ( item.ItemID == 0x3362 ){ item.ItemID = 0x3363; } //mounted dinosaur
					else if ( item.ItemID == 0x3363 ){ item.ItemID = 0x3362; } //mounted dinosaur
					else if ( item.ItemID == 0x3364 ){ item.ItemID = 0x3365; } //mounted dracolich
					else if ( item.ItemID == 0x3365 ){ item.ItemID = 0x3364; } //mounted dracolich
					else if ( item.ItemID == 0x3366 ){ item.ItemID = 0x3367; } //mounted dragon turtle
					else if ( item.ItemID == 0x3367 ){ item.ItemID = 0x3366; } //mounted dragon turtle
					else if ( item.ItemID == 0x33FD ){ item.ItemID = 0x33FE; } //mounted wyrm
					else if ( item.ItemID == 0x33FE ){ item.ItemID = 0x33FD; } //mounted wyrm
					else if ( item.ItemID == 0x3368 ){ item.ItemID = 0x3369; } //mounted drake
					else if ( item.ItemID == 0x3369 ){ item.ItemID = 0x3368; } //mounted drake
					else if ( item.ItemID == 0x336A ){ item.ItemID = 0x336B; } //mounted flesh golem
					else if ( item.ItemID == 0x336B ){ item.ItemID = 0x336A; } //mounted flesh golem
					else if ( item.ItemID == 0x336C ){ item.ItemID = 0x336D; } //mounted forest giant
					else if ( item.ItemID == 0x336D ){ item.ItemID = 0x336C; } //mounted forest giant
					else if ( item.ItemID == 0x336E ){ item.ItemID = 0x336F; } //mounted frost giant
					else if ( item.ItemID == 0x336F ){ item.ItemID = 0x336E; } //mounted frost giant
					else if ( item.ItemID == 0x3370 ){ item.ItemID = 0x3371; } //mounted griffon
					else if ( item.ItemID == 0x3371 ){ item.ItemID = 0x3370; } //mounted griffon
					else if ( item.ItemID == 0x3372 ){ item.ItemID = 0x3373; } //mounted hydra
					else if ( item.ItemID == 0x3373 ){ item.ItemID = 0x3372; } //mounted hydra
					else if ( item.ItemID == 0x3374 ){ item.ItemID = 0x3375; } //mounted jungle giant
					else if ( item.ItemID == 0x3375 ){ item.ItemID = 0x3374; } //mounted jungle giant
					else if ( item.ItemID == 0x3376 ){ item.ItemID = 0x3377; } //mounted lion
					else if ( item.ItemID == 0x3377 ){ item.ItemID = 0x3376; } //mounted lion
					else if ( item.ItemID == 0x3378 ){ item.ItemID = 0x3379; } //mounted ogre lord
					else if ( item.ItemID == 0x3379 ){ item.ItemID = 0x3378; } //mounted ogre lord
					else if ( item.ItemID == 0x337B ){ item.ItemID = 0x337C; } //mounted owlbear
					else if ( item.ItemID == 0x337C ){ item.ItemID = 0x337B; } //mounted owlbear
					else if ( item.ItemID == 0x337D ){ item.ItemID = 0x337E; } //mounted sea daemon
					else if ( item.ItemID == 0x337E ){ item.ItemID = 0x337D; } //mounted sea daemon
					else if ( item.ItemID == 0x337F ){ item.ItemID = 0x3380; } //mounted sea dragon
					else if ( item.ItemID == 0x3380 ){ item.ItemID = 0x337F; } //mounted sea dragon
					else if ( item.ItemID == 0x3381 ){ item.ItemID = 0x3382; } //mounted sea drake
					else if ( item.ItemID == 0x3382 ){ item.ItemID = 0x3381; } //mounted sea drake
					else if ( item.ItemID == 0x3383 ){ item.ItemID = 0x3384; } //mounted sea giant
					else if ( item.ItemID == 0x3384 ){ item.ItemID = 0x3383; } //mounted sea giant
					else if ( item.ItemID == 0x3385 ){ item.ItemID = 0x3386; } //mounted swamp drake
					else if ( item.ItemID == 0x3386 ){ item.ItemID = 0x3385; } //mounted swamp drake
					else if ( item.ItemID == 0x3387 ){ item.ItemID = 0x3388; } //mounted swamp thing
					else if ( item.ItemID == 0x3388 ){ item.ItemID = 0x3387; } //mounted swamp thing
					else if ( item.ItemID == 0x3389 ){ item.ItemID = 0x338A; } //mounted tiger
					else if ( item.ItemID == 0x338A ){ item.ItemID = 0x3389; } //mounted tiger
					else if ( item.ItemID == 0x338B ){ item.ItemID = 0x338C; } //mounted earth titan
					else if ( item.ItemID == 0x338C ){ item.ItemID = 0x338B; } //mounted earth titan
					else if ( item.ItemID == 0x338D ){ item.ItemID = 0x338E; } //mounted fire titan
					else if ( item.ItemID == 0x338E ){ item.ItemID = 0x338D; } //mounted fire titan
					else if ( item.ItemID == 0x338F ){ item.ItemID = 0x3390; } //mounted water titan
					else if ( item.ItemID == 0x3390 ){ item.ItemID = 0x338F; } //mounted water titan
					else if ( item.ItemID == 0x3391 ){ item.ItemID = 0x3392; } //mounted tyranasaur
					else if ( item.ItemID == 0x3392 ){ item.ItemID = 0x3391; } //mounted tyranasaur
					else if ( item.ItemID == 0x3393 ){ item.ItemID = 0x3394; } //mounted stegosaurus
					else if ( item.ItemID == 0x3394 ){ item.ItemID = 0x3393; } //mounted stegosaurus
					else if ( item.ItemID == 0x3395 ){ item.ItemID = 0x3396; } //mounted alien
					else if ( item.ItemID == 0x3396 ){ item.ItemID = 0x3395; } //mounted alien
					else if ( item.ItemID == 0x3397 ){ item.ItemID = 0x3398; } //mounted wyvern
					else if ( item.ItemID == 0x3398 ){ item.ItemID = 0x3397; } //mounted wyvern
					else if ( item.ItemID == 0x3399 ){ item.ItemID = 0x339A; } //mounted black bear
					else if ( item.ItemID == 0x339A ){ item.ItemID = 0x3399; } //mounted black bear
					else if ( item.ItemID == 0x339B ){ item.ItemID = 0x339C; } //mounted brown bear
					else if ( item.ItemID == 0x339C ){ item.ItemID = 0x339B; } //mounted brown bear
					else if ( item.ItemID == 0x339D ){ item.ItemID = 0x339E; } //mounted cave bear
					else if ( item.ItemID == 0x339E ){ item.ItemID = 0x339D; } //mounted cave bear
					else if ( item.ItemID == 0x339F ){ item.ItemID = 0x33A0; } //mounted polar bear
					else if ( item.ItemID == 0x33A0 ){ item.ItemID = 0x339F; } //mounted polar bear
					else if ( item.ItemID == 0x33A1 ){ item.ItemID = 0x33A2; } //mounted daemon
					else if ( item.ItemID == 0x33A2 ){ item.ItemID = 0x33A1; } //mounted daemon
					else if ( item.ItemID == 0x33A3 ){ item.ItemID = 0x33A4; } //mounted dragon
					else if ( item.ItemID == 0x33A4 ){ item.ItemID = 0x33A3; } //mounted dragon
					else if ( item.ItemID == 0x33A5 ){ item.ItemID = 0x33A6; } //mounted dragon
					else if ( item.ItemID == 0x33A6 ){ item.ItemID = 0x33A5; } //mounted dragon
					else if ( item.ItemID == 0x33A7 ){ item.ItemID = 0x33A8; } //mounted ettin mage
					else if ( item.ItemID == 0x33A8 ){ item.ItemID = 0x33A7; } //mounted ettin mage
					else if ( item.ItemID == 0x33A9 ){ item.ItemID = 0x33AA; } //mounted hill giant
					else if ( item.ItemID == 0x33AA ){ item.ItemID = 0x33A9; } //mounted hill giant
					else if ( item.ItemID == 0x33AB ){ item.ItemID = 0x33AC; } //mounted lizardman
					else if ( item.ItemID == 0x33AC ){ item.ItemID = 0x33AB; } //mounted lizardman
					else if ( item.ItemID == 0x33AD ){ item.ItemID = 0x33AE; } //mounted nightmare
					else if ( item.ItemID == 0x33AE ){ item.ItemID = 0x33AD; } //mounted nightmare
					else if ( item.ItemID == 0x33AF ){ item.ItemID = 0x33B0; } //mounted satan
					else if ( item.ItemID == 0x33B0 ){ item.ItemID = 0x33AF; } //mounted satan
					else if ( item.ItemID == 0x33B1 ){ item.ItemID = 0x33B2; } //mounted unicorn
					else if ( item.ItemID == 0x33B2 ){ item.ItemID = 0x33B1; } //mounted unicorn
					else if ( item.ItemID == 0x33B3 ){ item.ItemID = 0x33B4; } //mounted skeletal dragon
					else if ( item.ItemID == 0x33B4 ){ item.ItemID = 0x33B3; } //mounted skeletal dragon
					else if ( item.ItemID == 0x33B5 ){ item.ItemID = 0x33B6; } //mounted wyvern
					else if ( item.ItemID == 0x33B6 ){ item.ItemID = 0x33B5; } //mounted wyvern
					else if ( item.ItemID == 0x33B9 ){ item.ItemID = 0x33BA; } //mounted alien 
					else if ( item.ItemID == 0x33BA ){ item.ItemID = 0x33B9; } //mounted alien 
					else if ( item.ItemID == 0x33CB ){ item.ItemID = 0x33CC; } //mounted dragon abysmal
					else if ( item.ItemID == 0x33CC ){ item.ItemID = 0x33CB; } //mounted dragon abysmal
					else if ( item.ItemID == 0x33D1 ){ item.ItemID = 0x33D2; } //mounted dragon amber
					else if ( item.ItemID == 0x33D2 ){ item.ItemID = 0x33D1; } //mounted dragon amber
					else if ( item.ItemID == 0x33CF ){ item.ItemID = 0x33D0; } //mounted dragon cinder
					else if ( item.ItemID == 0x33D0 ){ item.ItemID = 0x33CF; } //mounted dragon cinder
					else if ( item.ItemID == 0x33D7 ){ item.ItemID = 0x33D8; } //mounted dragon fire, primeval
					else if ( item.ItemID == 0x33D8 ){ item.ItemID = 0x33D7; } //mounted dragon fire, primeval
					else if ( item.ItemID == 0x33C1 ){ item.ItemID = 0x33C2; } //mounted dragon green, primeval
					else if ( item.ItemID == 0x33C2 ){ item.ItemID = 0x33C1; } //mounted dragon green, primeval
					else if ( item.ItemID == 0x33D3 ){ item.ItemID = 0x33D4; } //mounted dragon night
					else if ( item.ItemID == 0x33D4 ){ item.ItemID = 0x33D3; } //mounted dragon night
					else if ( item.ItemID == 0x33D9 ){ item.ItemID = 0x33DA; } //mounted dragon primeval
					else if ( item.ItemID == 0x33DA ){ item.ItemID = 0x33D9; } //mounted dragon primeval
					else if ( item.ItemID == 0x33D5 ){ item.ItemID = 0x33D6; } //mounted dragon reanimated
					else if ( item.ItemID == 0x33D6 ){ item.ItemID = 0x33D5; } //mounted dragon reanimated
					else if ( item.ItemID == 0x33C5 ){ item.ItemID = 0x33C6; } //mounted dragon red, primeval
					else if ( item.ItemID == 0x33C6 ){ item.ItemID = 0x33C5; } //mounted dragon red, primeval
					else if ( item.ItemID == 0x33C3 ){ item.ItemID = 0x33C4; } //mounted dragon royal
					else if ( item.ItemID == 0x33C4 ){ item.ItemID = 0x33C3; } //mounted dragon royal
					else if ( item.ItemID == 0x33BF ){ item.ItemID = 0x33C0; } //mounted dragon rune
					else if ( item.ItemID == 0x33C0 ){ item.ItemID = 0x33BF; } //mounted dragon rune
					else if ( item.ItemID == 0x33C7 ){ item.ItemID = 0x33C8; } //mounted dragon sea, primeval
					else if ( item.ItemID == 0x33C8 ){ item.ItemID = 0x33C7; } //mounted dragon sea, primeval
					else if ( item.ItemID == 0x33C9 ){ item.ItemID = 0x33CA; } //mounted dragon stygian
					else if ( item.ItemID == 0x33CA ){ item.ItemID = 0x33C9; } //mounted dragon stygian
					else if ( item.ItemID == 0x33CD ){ item.ItemID = 0x33CE; } //mounted dragon vampiric
					else if ( item.ItemID == 0x33CE ){ item.ItemID = 0x33CD; } //mounted dragon vampiric
					else if ( item.ItemID == 0x33DB ){ item.ItemID = 0x33DC; } //mounted hell beast 
					else if ( item.ItemID == 0x33DC ){ item.ItemID = 0x33DB; } //mounted hell beast 
					else if ( item.ItemID == 0x33DD ){ item.ItemID = 0x33DE; } //mounted hippogriff 
					else if ( item.ItemID == 0x33DE ){ item.ItemID = 0x33DD; } //mounted hippogriff 
					else if ( item.ItemID == 0x33BD ){ item.ItemID = 0x33BE; } //mounted lion 
					else if ( item.ItemID == 0x33BE ){ item.ItemID = 0x33BD; } //mounted lion 
					else if ( item.ItemID == 0x33B7 ){ item.ItemID = 0x33B8; } //mounted styguana 
					else if ( item.ItemID == 0x33B8 ){ item.ItemID = 0x33B7; } //mounted styguana 
					else if ( item.ItemID == 0x33BB ){ item.ItemID = 0x33BC; } //mounted watcher 
					else if ( item.ItemID == 0x33BC ){ item.ItemID = 0x33BB; } //mounted watcher 
					else if ( item.ItemID == 0x33DF ){ item.ItemID = 0x33E0; } //mounted walrus 
					else if ( item.ItemID == 0x33E0 ){ item.ItemID = 0x33DF; } //mounted walrus 
					else if ( item.ItemID == 0x33E1 ){ item.ItemID = 0x33E2; } //mounted ogre 
					else if ( item.ItemID == 0x33E2 ){ item.ItemID = 0x33E1; } //mounted ogre 
					else if ( item.ItemID == 0x33E3 ){ item.ItemID = 0x33E4; } //mounted trollbear 
					else if ( item.ItemID == 0x33E4 ){ item.ItemID = 0x33E3; } //mounted trollbear 
					else if ( item.ItemID == 0x3E20 ){ item.ItemID = 0x3E21; }
					else if ( item.ItemID == 0x3E7 ){ item.ItemID = 0xC2C; }
					else if ( item.ItemID == 0x3E8 ){ item.ItemID = 0xEA0; }
					else if ( item.ItemID == 0x2A5D ){ item.ItemID = 0x2A61; }
					else if ( item.ItemID == 0x3EA ){ item.ItemID = 0xEA7; }
					else if ( item.ItemID == 0x3EB ){ item.ItemID = 0xEA6; }
					else if ( item.ItemID == 0x3EC ){ item.ItemID = 0xEA5; }
					else if ( item.ItemID == 0x3ED ){ item.ItemID = 0xE55; }
					else if ( item.ItemID == 0xDDF ){ item.ItemID = 0xE9F; }
					else if ( item.ItemID == 0xEA3 ){ item.ItemID = 0xEA4; }
					else if ( item.ItemID == 0xEA1 ){ item.ItemID = 0xEA2; }
					else if ( item.ItemID == 0x2A65 ){ item.ItemID = 0x2A68; }
					else if ( item.ItemID == 0x3308 ){ item.ItemID = 0x3E0C; }
					else if ( item.ItemID == 0x3309 ){ item.ItemID = 0x3E0D; }
					else if ( item.ItemID == 0x330A ){ item.ItemID = 0x3E0E; }
					else if ( item.ItemID == 0x330B ){ item.ItemID = 0x3E0F; }
					else if ( item.ItemID == 0x330C ){ item.ItemID = 0x3E10; }
					else if ( item.ItemID == 0x330D ){ item.ItemID = 0x3E11; }
					else if ( item.ItemID == 0x330E ){ item.ItemID = 0x3E12; }
					else if ( item.ItemID == 0x330F ){ item.ItemID = 0x3E13; }
					else if ( item.ItemID == 0x3310 ){ item.ItemID = 0x3E14; }
					else if ( item.ItemID == 0x3311 ){ item.ItemID = 0x3E15; }
					else if ( item.ItemID == 0x3312 ){ item.ItemID = 0x3E16; }
					else if ( item.ItemID == 0x3313 ){ item.ItemID = 0x3E17; }
					else if ( item.ItemID == 0x3314 ){ item.ItemID = 0x3E18; }
					else if ( item.ItemID == 0x3315 ){ item.ItemID = 0x3E19; }
					else if ( item.ItemID == 0x3316 ){ item.ItemID = 0x3E1A; }
					else if ( item.ItemID == 0x3317 ){ item.ItemID = 0x3E1B; }
					else if ( item.ItemID == 0x3318 ){ item.ItemID = 0x3E1C; }
					else if ( item.ItemID == 0x3319 ){ item.ItemID = 0x3E1D; }
					else if ( item.ItemID == 0x331A ){ item.ItemID = 0x3E1E; }
					else if ( item.ItemID == 0x331B ){ item.ItemID = 0x3E1F; }
					else if ( item.ItemID == 0x331C ){ item.ItemID = 0x3E22; }
					else if ( item.ItemID == 0x331D ){ item.ItemID = 0x3E23; }
					else if ( item.ItemID == 0x331E ){ item.ItemID = 0x3E24; }
					else if ( item.ItemID == 0x331F ){ item.ItemID = 0x3E25; }
					else if ( item.ItemID == 0x3320 ){ item.ItemID = 0x3E26; }
					else if ( item.ItemID == 0x3321 ){ item.ItemID = 0x3DEC; }
					else if ( item.ItemID == 0x3322 ){ item.ItemID = 0x3DED; }
					else if ( item.ItemID == 0x3323 ){ item.ItemID = 0x3DEE; }
					else if ( item.ItemID == 0x3324 ){ item.ItemID = 0x3DEF; }
					else if ( item.ItemID == 0x3325 ){ item.ItemID = 0x3DF0; }
					else if ( item.ItemID == 0x3326 ){ item.ItemID = 0x3DF1; }
					else if ( item.ItemID == 0x3327 ){ item.ItemID = 0x3DF2; }
					else if ( item.ItemID == 0x3328 ){ item.ItemID = 0x3DF3; }
					else if ( item.ItemID == 0x3329 ){ item.ItemID = 0x3DF4; }
					else if ( item.ItemID == 0x332A ){ item.ItemID = 0x3DF5; }
					else if ( item.ItemID == 0x332B ){ item.ItemID = 0x3DF6; }
					else if ( item.ItemID == 0x332C ){ item.ItemID = 0x3DF7; }
					else if ( item.ItemID == 0x332D ){ item.ItemID = 0x3DF8; }
					else if ( item.ItemID == 0x332E ){ item.ItemID = 0x3DF9; }
					else if ( item.ItemID == 0x332F ){ item.ItemID = 0x3DFA; }
					else if ( item.ItemID == 0x3E21 ){ item.ItemID = 0x3E20; }
					else if ( item.ItemID == 0xC2C ){ item.ItemID = 0x3E7; }
					else if ( item.ItemID == 0xEA0 ){ item.ItemID = 0x3E8; }
					else if ( item.ItemID == 0x2A61 ){ item.ItemID = 0x2A5D; }
					else if ( item.ItemID == 0xEA7 ){ item.ItemID = 0x3EA; }
					else if ( item.ItemID == 0xEA6 ){ item.ItemID = 0x3EB; }
					else if ( item.ItemID == 0xEA5 ){ item.ItemID = 0x3EC; }
					else if ( item.ItemID == 0xE55 ){ item.ItemID = 0x3ED; }
					else if ( item.ItemID == 0xE9F ){ item.ItemID = 0xDDF; }
					else if ( item.ItemID == 0xEA4 ){ item.ItemID = 0xEA3; }
					else if ( item.ItemID == 0xEA2 ){ item.ItemID = 0xEA1; }
					else if ( item.ItemID == 0x2A68 ){ item.ItemID = 0x2A65; }
					else if ( item.ItemID == 0x3E0C ){ item.ItemID = 0x3308; }
					else if ( item.ItemID == 0x3E0D ){ item.ItemID = 0x3309; }
					else if ( item.ItemID == 0x3E0E ){ item.ItemID = 0x330A; }
					else if ( item.ItemID == 0x3E0F ){ item.ItemID = 0x330B; }
					else if ( item.ItemID == 0x3E10 ){ item.ItemID = 0x330C; }
					else if ( item.ItemID == 0x3E11 ){ item.ItemID = 0x330D; }
					else if ( item.ItemID == 0x3E12 ){ item.ItemID = 0x330E; }
					else if ( item.ItemID == 0x3E13 ){ item.ItemID = 0x330F; }
					else if ( item.ItemID == 0x3E14 ){ item.ItemID = 0x3310; }
					else if ( item.ItemID == 0x3E15 ){ item.ItemID = 0x3311; }
					else if ( item.ItemID == 0x3E16 ){ item.ItemID = 0x3312; }
					else if ( item.ItemID == 0x3E17 ){ item.ItemID = 0x3313; }
					else if ( item.ItemID == 0x3E18 ){ item.ItemID = 0x3314; }
					else if ( item.ItemID == 0x3E19 ){ item.ItemID = 0x3315; }
					else if ( item.ItemID == 0x3E1A ){ item.ItemID = 0x3316; }
					else if ( item.ItemID == 0x3E1B ){ item.ItemID = 0x3317; }
					else if ( item.ItemID == 0x3E1C ){ item.ItemID = 0x3318; }
					else if ( item.ItemID == 0x3E1D ){ item.ItemID = 0x3319; }
					else if ( item.ItemID == 0x3E1E ){ item.ItemID = 0x331A; }
					else if ( item.ItemID == 0x3E1F ){ item.ItemID = 0x331B; }
					else if ( item.ItemID == 0x3E22 ){ item.ItemID = 0x331C; }
					else if ( item.ItemID == 0x3E23 ){ item.ItemID = 0x331D; }
					else if ( item.ItemID == 0x3E24 ){ item.ItemID = 0x331E; }
					else if ( item.ItemID == 0x3E25 ){ item.ItemID = 0x331F; }
					else if ( item.ItemID == 0x3E26 ){ item.ItemID = 0x3320; }
					else if ( item.ItemID == 0x3DEC ){ item.ItemID = 0x3321; }
					else if ( item.ItemID == 0x3DED ){ item.ItemID = 0x3322; }
					else if ( item.ItemID == 0x3DEE ){ item.ItemID = 0x3323; }
					else if ( item.ItemID == 0x3DEF ){ item.ItemID = 0x3324; }
					else if ( item.ItemID == 0x3DF0 ){ item.ItemID = 0x3325; }
					else if ( item.ItemID == 0x3DF1 ){ item.ItemID = 0x3326; }
					else if ( item.ItemID == 0x3DF2 ){ item.ItemID = 0x3327; }
					else if ( item.ItemID == 0x3DF3 ){ item.ItemID = 0x3328; }
					else if ( item.ItemID == 0x3DF4 ){ item.ItemID = 0x3329; }
					else if ( item.ItemID == 0x3DF5 ){ item.ItemID = 0x332A; }
					else if ( item.ItemID == 0x3DF6 ){ item.ItemID = 0x332B; }
					else if ( item.ItemID == 0x3DF7 ){ item.ItemID = 0x332C; }
					else if ( item.ItemID == 0x3DF8 ){ item.ItemID = 0x332D; }
					else if ( item.ItemID == 0x3DF9 ){ item.ItemID = 0x332E; }
					else if ( item.ItemID == 0x3DFA ){ item.ItemID = 0x332F; }
					else if ( item.ItemID == 0x499 ){ item.ItemID = 0x49A; }
					else if ( item.ItemID == 0x121C ){ item.ItemID = 0x1229; }
					else if ( item.ItemID == 0x1224 ){ item.ItemID = 0x139A; }
					else if ( item.ItemID == 0x1226 ){ item.ItemID = 0x139B; }
					else if ( item.ItemID == 0x1227 ){ item.ItemID = 0x139C; }
					else if ( item.ItemID == 0x1228 ){ item.ItemID = 0x139D; }
					else if ( item.ItemID == 0x12D8 ){ item.ItemID = 0x12D9; }
					else if ( item.ItemID == 0x1A7F ){ item.ItemID = 0x1A80; }
					else if ( item.ItemID == 0x2D0E ){ item.ItemID = 0x2D0F; }
					else if ( item.ItemID == 0x2D10 ){ item.ItemID = 0x2D11; }
					else if ( item.ItemID == 0x2D12 ){ item.ItemID = 0x2D13; }
					else if ( item.ItemID == 0x313D ){ item.ItemID = 0x3140; }
					else if ( item.ItemID == 0x313E ){ item.ItemID = 0x313F; }
					else if ( item.ItemID == 0x3141 ){ item.ItemID = 0x3142; }
					else if ( item.ItemID == 0x3143 ){ item.ItemID = 0x3144; }
					else if ( item.ItemID == 0x3149 ){ item.ItemID = 0x314A; }
					else if ( item.ItemID == 0x314B ){ item.ItemID = 0x3182; }
					else if ( item.ItemID == 0x31C1 ){ item.ItemID = 0x31C2; }
					else if ( item.ItemID == 0x31C7 ){ item.ItemID = 0x31C8; }
					else if ( item.ItemID == 0x31C9 ){ item.ItemID = 0x31CA; }
					else if ( item.ItemID == 0x31CB ){ item.ItemID = 0x31CC; }
					else if ( item.ItemID == 0x31CD ){ item.ItemID = 0x31CE; }
					else if ( item.ItemID == 0x31CF ){ item.ItemID = 0x31D0; }
					else if ( item.ItemID == 0x31D1 ){ item.ItemID = 0x31D2; }
					else if ( item.ItemID == 0x31D3 ){ item.ItemID = 0x31D4; }
					else if ( item.ItemID == 0x31F3 ){ item.ItemID = 0x3200; }
					else if ( item.ItemID == 0x31FC ){ item.ItemID = 0x31FD; }
					else if ( item.ItemID == 0x31FE ){ item.ItemID = 0x31FF; }
					else if ( item.ItemID == 0x3201 ){ item.ItemID = 0x3202; }
					else if ( item.ItemID == 0x3203 ){ item.ItemID = 0x3204; }
					else if ( item.ItemID == 0x320B ){ item.ItemID = 0x3219; }
					else if ( item.ItemID == 0x320C ){ item.ItemID = 0x3212; }
					else if ( item.ItemID == 0x321F ){ item.ItemID = 0x3225; }
					else if ( item.ItemID == 0x322B ){ item.ItemID = 0x3235; }
					else if ( item.ItemID == 0x3A98 ){ item.ItemID = 0x3A9A; }
					else if ( item.ItemID == 0x3F19 ){ item.ItemID = 0x3F1A; }
					else if ( item.ItemID == 0x3F3D ){ item.ItemID = 0x40BC; }
					else if ( item.ItemID == 0x456E ){ item.ItemID = 0x456F; }
					else if ( item.ItemID == 0x4AA6 ){ item.ItemID = 0x4AA7; }
					else if ( item.ItemID == 0x4AA8 ){ item.ItemID = 0x4AA9; }
					else if ( item.ItemID == 0x4AAA ){ item.ItemID = 0x4AAB; }
					else if ( item.ItemID == 0x4AAC ){ item.ItemID = 0x4AAD; }
					else if ( item.ItemID == 0x4AAE ){ item.ItemID = 0x4AAF; }
					else if ( item.ItemID == 0x4AB0 ){ item.ItemID = 0x4AB1; }
					else if ( item.ItemID == 0x4AB2 ){ item.ItemID = 0x4AB3; }
					else if ( item.ItemID == 0x4AB4 ){ item.ItemID = 0x4AB5; }
					else if ( item.ItemID == 0x4AB6 ){ item.ItemID = 0x4AB7; }
					else if ( item.ItemID == 0x4B44 ){ item.ItemID = 0x4B45; }
					else if ( item.ItemID == 0x4B46 ){ item.ItemID = 0x4B47; }
					else if ( item.ItemID == 0x4B48 ){ item.ItemID = 0x4B49; }
					else if ( item.ItemID == 0x4B4A ){ item.ItemID = 0x4B4B; }
					else if ( item.ItemID == 0x4B4C ){ item.ItemID = 0x4B4D; }
					else if ( item.ItemID == 0x49A ){ item.ItemID = 0x499; }
					else if ( item.ItemID == 0x1229 ){ item.ItemID = 0x121C; }
					else if ( item.ItemID == 0x139A ){ item.ItemID = 0x1224; }
					else if ( item.ItemID == 0x139B ){ item.ItemID = 0x1226; }
					else if ( item.ItemID == 0x139C ){ item.ItemID = 0x1227; }
					else if ( item.ItemID == 0x139D ){ item.ItemID = 0x1228; }
					else if ( item.ItemID == 0x12D9 ){ item.ItemID = 0x12D8; }
					else if ( item.ItemID == 0x1A80 ){ item.ItemID = 0x1A7F; }
					else if ( item.ItemID == 0x2D0F ){ item.ItemID = 0x2D0E; }
					else if ( item.ItemID == 0x2D11 ){ item.ItemID = 0x2D10; }
					else if ( item.ItemID == 0x2D13 ){ item.ItemID = 0x2D12; }
					else if ( item.ItemID == 0x3140 ){ item.ItemID = 0x313D; }
					else if ( item.ItemID == 0x313F ){ item.ItemID = 0x313E; }
					else if ( item.ItemID == 0x3142 ){ item.ItemID = 0x3141; }
					else if ( item.ItemID == 0x3144 ){ item.ItemID = 0x3143; }
					else if ( item.ItemID == 0x314A ){ item.ItemID = 0x3149; }
					else if ( item.ItemID == 0x3182 ){ item.ItemID = 0x314B; }
					else if ( item.ItemID == 0x31C2 ){ item.ItemID = 0x31C1; }
					else if ( item.ItemID == 0x31C8 ){ item.ItemID = 0x31C7; }
					else if ( item.ItemID == 0x31CA ){ item.ItemID = 0x31C9; }
					else if ( item.ItemID == 0x31CC ){ item.ItemID = 0x31CB; }
					else if ( item.ItemID == 0x31CE ){ item.ItemID = 0x31CD; }
					else if ( item.ItemID == 0x31D0 ){ item.ItemID = 0x31CF; }
					else if ( item.ItemID == 0x31D2 ){ item.ItemID = 0x31D1; }
					else if ( item.ItemID == 0x31D4 ){ item.ItemID = 0x31D3; }
					else if ( item.ItemID == 0x3200 ){ item.ItemID = 0x31F3; }
					else if ( item.ItemID == 0x31FD ){ item.ItemID = 0x31FC; }
					else if ( item.ItemID == 0x31FF ){ item.ItemID = 0x31FE; }
					else if ( item.ItemID == 0x3202 ){ item.ItemID = 0x3201; }
					else if ( item.ItemID == 0x3204 ){ item.ItemID = 0x3203; }
					else if ( item.ItemID == 0x3219 ){ item.ItemID = 0x320B; }
					else if ( item.ItemID == 0x3212 ){ item.ItemID = 0x320C; }
					else if ( item.ItemID == 0x3225 ){ item.ItemID = 0x321F; }
					else if ( item.ItemID == 0x3235 ){ item.ItemID = 0x322B; }
					else if ( item.ItemID == 0x3A9A ){ item.ItemID = 0x3A98; }
					else if ( item.ItemID == 0x3F1A ){ item.ItemID = 0x3F19; }
					else if ( item.ItemID == 0x40BC ){ item.ItemID = 0x3F3D; }
					else if ( item.ItemID == 0x456F ){ item.ItemID = 0x456E; }
					else if ( item.ItemID == 0x4AA7 ){ item.ItemID = 0x4AA6; }
					else if ( item.ItemID == 0x4AA9 ){ item.ItemID = 0x4AA8; }
					else if ( item.ItemID == 0x4AAB ){ item.ItemID = 0x4AAA; }
					else if ( item.ItemID == 0x4AAD ){ item.ItemID = 0x4AAC; }
					else if ( item.ItemID == 0x4AAF ){ item.ItemID = 0x4AAE; }
					else if ( item.ItemID == 0x4AB1 ){ item.ItemID = 0x4AB0; }
					else if ( item.ItemID == 0x4AB3 ){ item.ItemID = 0x4AB2; }
					else if ( item.ItemID == 0x4AB5 ){ item.ItemID = 0x4AB4; }
					else if ( item.ItemID == 0x4AB7 ){ item.ItemID = 0x4AB6; }
					else if ( item.ItemID == 0x4B45 ){ item.ItemID = 0x4B44; }
					else if ( item.ItemID == 0x4B47 ){ item.ItemID = 0x4B46; }
					else if ( item.ItemID == 0x4B49 ){ item.ItemID = 0x4B48; }
					else if ( item.ItemID == 0x4B4B ){ item.ItemID = 0x4B4A; }
					else if ( item.ItemID == 0x4B4D ){ item.ItemID = 0x4B4C; }
					else if ( item.ItemID == 0x3866 ){ item.ItemID = 0x3867; }
					else if ( item.ItemID == 0x3867 ){ item.ItemID = 0x3866; }

					else { from.SendLocalizedMessage( 1042273 ); } // You cannot turn that.
				}
			}

			private static void Deed( Item item, Mobile from )
			{
				if ( item is AlchemistTableEastDeed ) { from.AddToBackpack( new AlchemistTableSouthDeed() ); item.Delete(); }
				else if ( item is AlchemistTableSouthDeed ) { from.AddToBackpack( new AlchemistTableEastDeed() ); item.Delete(); }
				else if ( item is AnvilEastDeed ) { from.AddToBackpack( new AnvilSouthDeed() ); item.Delete(); }
				else if ( item is AnvilSouthDeed ) { from.AddToBackpack( new AnvilEastDeed() ); item.Delete(); }
				else if ( item is ArcaneBookshelfEastDeed ) { from.AddToBackpack( new ArcaneBookshelfSouthDeed() ); item.Delete(); }
				else if ( item is ArcaneBookshelfSouthDeed ) { from.AddToBackpack( new ArcaneBookshelfEastDeed() ); item.Delete(); }
				else if ( item is ArcanistStatueEastDeed ) { from.AddToBackpack( new ArcanistStatueSouthDeed() ); item.Delete(); }
				else if ( item is ArcanistStatueSouthDeed ) { from.AddToBackpack( new ArcanistStatueEastDeed() ); item.Delete(); }
				else if ( item is BrocadeGozaMatEastDeed ) { from.AddToBackpack( new BrocadeGozaMatSouthDeed() ); item.Delete(); }
				else if ( item is BrocadeGozaMatSouthDeed ) { from.AddToBackpack( new BrocadeGozaMatEastDeed() ); item.Delete(); }
				else if ( item is BrocadeSquareGozaMatEastDeed ) { from.AddToBackpack( new BrocadeSquareGozaMatSouthDeed() ); item.Delete(); }
				else if ( item is BrocadeSquareGozaMatSouthDeed ) { from.AddToBackpack( new BrocadeSquareGozaMatEastDeed() ); item.Delete(); }
				else if ( item is BrownBearRugEastDeed ) { from.AddToBackpack( new BrownBearRugSouthDeed() ); item.Delete(); }
				else if ( item is BrownBearRugSouthDeed ) { from.AddToBackpack( new BrownBearRugEastDeed() ); item.Delete(); }
				else if ( item is DarkFlowerTapestryEastDeed ) { from.AddToBackpack( new DarkFlowerTapestrySouthDeed() ); item.Delete(); }
				else if ( item is DarkFlowerTapestrySouthDeed ) { from.AddToBackpack( new DarkFlowerTapestryEastDeed() ); item.Delete(); }
				else if ( item is DartBoardEastDeed ) { from.AddToBackpack( new DartBoardSouthDeed() ); item.Delete(); }
				else if ( item is DartBoardSouthDeed ) { from.AddToBackpack( new DartBoardEastDeed() ); item.Delete(); }
				else if ( item is DeadBodyEWDeed ) { from.AddToBackpack( new DeadBodyNSDeed() ); item.Delete(); }
				else if ( item is DeadBodyNSDeed ) { from.AddToBackpack( new DeadBodyEWDeed() ); item.Delete(); }
				else if ( item is ElvenBedEastDeed ) { from.AddToBackpack( new ElvenBedSouthDeed() ); item.Delete(); }
				else if ( item is ElvenBedSouthDeed ) { from.AddToBackpack( new ElvenBedEastDeed() ); item.Delete(); }
				else if ( item is ElvenDresserEastDeed ) { from.AddToBackpack( new ElvenDresserSouthDeed() ); item.Delete(); }
				else if ( item is ElvenDresserSouthDeed ) { from.AddToBackpack( new ElvenDresserEastDeed() ); item.Delete(); }
				else if ( item is ElvenLoveseatEastDeed ) { from.AddToBackpack( new ElvenLoveseatSouthDeed() ); item.Delete(); }
				else if ( item is ElvenLoveseatSouthDeed ) { from.AddToBackpack( new ElvenLoveseatEastDeed() ); item.Delete(); }
				else if ( item is ElvenSpinningwheelEastDeed ) { from.AddToBackpack( new ElvenSpinningwheelSouthDeed() ); item.Delete(); }
				else if ( item is ElvenSpinningwheelSouthDeed ) { from.AddToBackpack( new ElvenSpinningwheelEastDeed() ); item.Delete(); }
				else if ( item is ElvenStoveEastDeed ) { from.AddToBackpack( new ElvenStoveSouthDeed() ); item.Delete(); }
				else if ( item is ElvenStoveSouthDeed ) { from.AddToBackpack( new ElvenStoveEastDeed() ); item.Delete(); }
				else if ( item is ElvenWashBasinEastDeed ) { from.AddToBackpack( new ElvenWashBasinSouthDeed() ); item.Delete(); }
				else if ( item is ElvenWashBasinSouthDeed ) { from.AddToBackpack( new ElvenWashBasinEastDeed() ); item.Delete(); }
				else if ( item is ESpikePostEastDeed ) { from.AddToBackpack( new ESpikePostSouthDeed() ); item.Delete(); }
				else if ( item is ESpikePostSouthDeed ) { from.AddToBackpack( new ESpikePostEastDeed() ); item.Delete(); }
				else if ( item is EvilFireplaceEastFaceAddonDeed ) { from.AddToBackpack( new EvilFireplaceSouthFaceAddonDeed() ); item.Delete(); }
				else if ( item is EvilFireplaceSouthFaceAddonDeed ) { from.AddToBackpack( new EvilFireplaceEastFaceAddonDeed() ); item.Delete(); }
				else if ( item is FancyElvenTableEastDeed ) { from.AddToBackpack( new FancyElvenTableSouthDeed() ); item.Delete(); }
				else if ( item is FancyElvenTableSouthDeed ) { from.AddToBackpack( new FancyElvenTableEastDeed() ); item.Delete(); }
				else if ( item is FlourMillEastDeed ) { from.AddToBackpack( new FlourMillSouthDeed() ); item.Delete(); }
				else if ( item is FlourMillSouthDeed ) { from.AddToBackpack( new FlourMillEastDeed() ); item.Delete(); }
				else if ( item is GozaMatEastDeed ) { from.AddToBackpack( new GozaMatSouthDeed() ); item.Delete(); }
				else if ( item is GozaMatSouthDeed ) { from.AddToBackpack( new GozaMatEastDeed() ); item.Delete(); }
				else if ( item is GrayBrickFireplaceEastDeed ) { from.AddToBackpack( new GrayBrickFireplaceSouthDeed() ); item.Delete(); }
				else if ( item is GrayBrickFireplaceSouthDeed ) { from.AddToBackpack( new GrayBrickFireplaceEastDeed() ); item.Delete(); }
				else if ( item is halloween_block_eastAddonDeed ) { from.AddToBackpack( new halloween_block_southAddonDeed() ); item.Delete(); }
				else if ( item is halloween_block_southAddonDeed ) { from.AddToBackpack( new halloween_block_eastAddonDeed() ); item.Delete(); }
				else if ( item is halloween_coffin_eastAddonDeed ) { from.AddToBackpack( new halloween_coffin_southAddonDeed() ); item.Delete(); }
				else if ( item is halloween_coffin_southAddonDeed ) { from.AddToBackpack( new halloween_coffin_eastAddonDeed() ); item.Delete(); }
				else if ( item is LargeBedEastDeed ) { from.AddToBackpack( new LargeBedSouthDeed() ); item.Delete(); }
				else if ( item is LargeBedSouthDeed ) { from.AddToBackpack( new LargeBedEastDeed() ); item.Delete(); }
				else if ( item is LargeForgeEastDeed ) { from.AddToBackpack( new LargeForgeSouthDeed() ); item.Delete(); }
				else if ( item is LargeForgeSouthDeed ) { from.AddToBackpack( new LargeForgeEastDeed() ); item.Delete(); }
				else if ( item is LargeStoneTableEastDeed ) { from.AddToBackpack( new LargeStoneTableSouthDeed() ); item.Delete(); }
				else if ( item is LargeStoneTableSouthDeed ) { from.AddToBackpack( new LargeStoneTableEastDeed() ); item.Delete(); }
				else if ( item is LightFlowerTapestryEastDeed ) { from.AddToBackpack( new LightFlowerTapestrySouthDeed() ); item.Delete(); }
				else if ( item is LightFlowerTapestrySouthDeed ) { from.AddToBackpack( new LightFlowerTapestryEastDeed() ); item.Delete(); }
				else if ( item is LoomEastDeed ) { from.AddToBackpack( new LoomSouthDeed() ); item.Delete(); }
				else if ( item is LoomSouthDeed ) { from.AddToBackpack( new LoomEastDeed() ); item.Delete(); }
				else if ( item is MarlinSouthAddonDeed ) { from.AddToBackpack( new MarlinEastAddonDeed() ); item.Delete(); }
				else if ( item is MarlinEastAddonDeed ) { from.AddToBackpack( new MarlinSouthAddonDeed() ); item.Delete(); }
				else if ( item is SawMillSouthAddonDeed ) { from.AddToBackpack( new SawMillEastAddonDeed() ); item.Delete(); }
				else if ( item is SawMillEastAddonDeed ) { from.AddToBackpack( new SawMillSouthAddonDeed() ); item.Delete(); }
				else if ( item is MediumStoneTableEastDeed ) { from.AddToBackpack( new MediumStoneTableSouthDeed() ); item.Delete(); }
				else if ( item is MediumStoneTableSouthDeed ) { from.AddToBackpack( new MediumStoneTableEastDeed() ); item.Delete(); }
				else if ( item is MediumStretchedHideEastDeed ) { from.AddToBackpack( new MediumStretchedHideSouthDeed() ); item.Delete(); }
				else if ( item is MediumStretchedHideSouthDeed ) { from.AddToBackpack( new MediumStretchedHideEastDeed() ); item.Delete(); }
				else if ( item is MongbatDartBoardEastDeed ) { from.AddToBackpack( new MongbatDartBoardSouthDeed() ); item.Delete(); }
				else if ( item is MongbatDartBoardSouthDeed ) { from.AddToBackpack( new MongbatDartBoardEastDeed() ); item.Delete(); }
				else if ( item is OrnateElvenTableEastDeed ) { from.AddToBackpack( new OrnateElvenTableSouthDeed() ); item.Delete(); }
				else if ( item is OrnateElvenTableSouthDeed ) { from.AddToBackpack( new OrnateElvenTableEastDeed() ); item.Delete(); }
				else if ( item is PickpocketDipEastDeed ) { from.AddToBackpack( new PickpocketDipSouthDeed() ); item.Delete(); }
				else if ( item is PickpocketDipSouthDeed ) { from.AddToBackpack( new PickpocketDipEastDeed() ); item.Delete(); }
				else if ( item is PolarBearRugEastDeed ) { from.AddToBackpack( new PolarBearRugSouthDeed() ); item.Delete(); }
				else if ( item is PolarBearRugSouthDeed ) { from.AddToBackpack( new PolarBearRugEastDeed() ); item.Delete(); }
				else if ( item is SandstoneFireplaceEastDeed ) { from.AddToBackpack( new SandstoneFireplaceSouthDeed() ); item.Delete(); }
				else if ( item is SandstoneFireplaceSouthDeed ) { from.AddToBackpack( new SandstoneFireplaceEastDeed() ); item.Delete(); }
				else if ( item is SmallBedEastDeed ) { from.AddToBackpack( new SmallBedSouthDeed() ); item.Delete(); }
				else if ( item is SmallBedSouthDeed ) { from.AddToBackpack( new SmallBedEastDeed() ); item.Delete(); }
				else if ( item is SmallStretchedHideEastDeed ) { from.AddToBackpack( new SmallStretchedHideSouthDeed() ); item.Delete(); }
				else if ( item is SmallStretchedHideSouthDeed ) { from.AddToBackpack( new SmallStretchedHideEastDeed() ); item.Delete(); }
				else if ( item is SpinningwheelEastDeed ) { from.AddToBackpack( new SpinningwheelSouthDeed() ); item.Delete(); }
				else if ( item is SpinningwheelSouthDeed ) { from.AddToBackpack( new SpinningwheelEastDeed() ); item.Delete(); }
				else if ( item is SquareGozaMatEastDeed ) { from.AddToBackpack( new SquareGozaMatSouthDeed() ); item.Delete(); }
				else if ( item is SquareGozaMatSouthDeed ) { from.AddToBackpack( new SquareGozaMatEastDeed() ); item.Delete(); }
				else if ( item is SquirrelStatueEastDeed ) { from.AddToBackpack( new SquirrelStatueSouthDeed() ); item.Delete(); }
				else if ( item is SquirrelStatueSouthDeed ) { from.AddToBackpack( new SquirrelStatueEastDeed() ); item.Delete(); }
				else if ( item is StoneFireplaceEastDeed ) { from.AddToBackpack( new StoneFireplaceSouthDeed() ); item.Delete(); }
				else if ( item is StoneFireplaceSouthDeed ) { from.AddToBackpack( new StoneFireplaceEastDeed() ); item.Delete(); }
				else if ( item is StoneOvenEastDeed ) { from.AddToBackpack( new StoneOvenSouthDeed() ); item.Delete(); }
				else if ( item is StoneOvenSouthDeed ) { from.AddToBackpack( new StoneOvenEastDeed() ); item.Delete(); }
				else if ( item is TallElvenBedEastDeed ) { from.AddToBackpack( new TallElvenBedSouthDeed() ); item.Delete(); }
				else if ( item is TallElvenBedSouthDeed ) { from.AddToBackpack( new TallElvenBedEastDeed() ); item.Delete(); }
				else if ( item is TrainingDummyEastDeed ) { from.AddToBackpack( new TrainingDummySouthDeed() ); item.Delete(); }
				else if ( item is TrainingDummySouthDeed ) { from.AddToBackpack( new TrainingDummyEastDeed() ); item.Delete(); }
				else if ( item is WarriorStatueEastDeed ) { from.AddToBackpack( new WarriorStatueSouthDeed() ); item.Delete(); }
				else if ( item is WarriorStatueSouthDeed ) { from.AddToBackpack( new WarriorStatueEastDeed() ); item.Delete(); }
				else if ( item is WaterTroughEastDeed ) { from.AddToBackpack( new WaterTroughSouthDeed() ); item.Delete(); }
				else if ( item is WaterTroughSouthDeed ) { from.AddToBackpack( new WaterTroughEastDeed() ); item.Delete(); }
				else if ( item is DolphinEastLargeAddonDeed ) { from.AddToBackpack( new DolphinSouthLargeAddonDeed() ); item.Delete(); }
				else if ( item is DolphinSouthLargeAddonDeed ) { from.AddToBackpack( new DolphinEastLargeAddonDeed() ); item.Delete(); }
				else if ( item is DolphinEastSmallAddonDeed ) { from.AddToBackpack( new DolphinSouthSmallAddonDeed() ); item.Delete(); }
				else if ( item is DolphinSouthSmallAddonDeed ) { from.AddToBackpack( new DolphinEastSmallAddonDeed() ); item.Delete(); }
				else if ( item is RoseEastLargeAddonDeed ) { from.AddToBackpack( new RoseSouthLargeAddonDeed() ); item.Delete(); }
				else if ( item is RoseSouthLargeAddonDeed ) { from.AddToBackpack( new RoseEastLargeAddonDeed() ); item.Delete(); }
				else if ( item is RoseEastSmallAddonDeed ) { from.AddToBackpack( new RoseSouthSmallAddonDeed() ); item.Delete(); }
				else if ( item is RoseSouthSmallAddonDeed ) { from.AddToBackpack( new RoseEastSmallAddonDeed() ); item.Delete(); }
				else if ( item is SkullEastLargeAddonDeed ) { from.AddToBackpack( new SkullSouthLargeAddonDeed() ); item.Delete(); }
				else if ( item is SkullSouthLargeAddonDeed ) { from.AddToBackpack( new SkullEastLargeAddonDeed() ); item.Delete(); }
				else if ( item is SkullEastSmallAddonDeed ) { from.AddToBackpack( new SkullSouthSmallAddonDeed() ); item.Delete(); }
				else if ( item is SkullSouthSmallAddonDeed ) { from.AddToBackpack( new SkullEastSmallAddonDeed() ); item.Delete(); }
				else if ( item is GothicCandelabraA ) { from.AddToBackpack( new GothicCandelabraB() ); item.Delete(); }
				else if ( item is GothicCandelabraB ) { from.AddToBackpack( new GothicCandelabraA() ); item.Delete(); }
				else if ( item is BurningScarecrowA ) { from.AddToBackpack( new BurningScarecrowB() ); item.Delete(); }
				else if ( item is BurningScarecrowB ) { from.AddToBackpack( new BurningScarecrowA() ); item.Delete(); }
				else if ( item is BaseStatueDeed ) { Server.Items.Statues.FlipStatue( (BaseStatueDeed)item, ((BaseStatueDeed)item).StatueID ); }
				else if ( item is DDRelicBearRugsAddonDeed )
				{
					DDRelicBearRugsAddonDeed rug = (DDRelicBearRugsAddonDeed)item;

					int RelCost = rug.RelicGoldValue;
					int RelID = rug.RelicMainID;
					int RelRugID = rug.RelicRugID;
					int RelHue = rug.RelicColor;
					string RelQuality = rug.RelicQuality;
					int RelRolled = rug.RelicFound;

					if ( RelRugID == 1){ RelRugID = 2; RelID = 0x1545; }
					else if ( RelRugID == 2){ RelRugID = 1; RelID = 0x1546; }
					else if ( RelRugID == 3){ RelRugID = 4; RelID = 0x1545; }
					else if ( RelRugID == 4){ RelRugID = 3; RelID = 0x1546; }
					else if ( RelRugID == 5){ RelRugID = 6; RelID = 0x1545; }
					else { RelRugID = 5; RelID = 0x1546; }

					from.AddToBackpack( new DDRelicBearRugsAddonDeed( RelCost, RelID, RelRugID, RelHue, RelQuality, RelRolled ) );
					item.Delete();
				}
				else if ( item is MyTentEastAddonDeed )
				{
					MyTentEastAddonDeed tent = (MyTentEastAddonDeed)item;
					int TentHue = tent.TentColor;
					from.AddToBackpack( new MyTentSouthAddonDeed( TentHue, 1 ) );
					item.Delete();
				}
				else if ( item is MyTentSouthAddonDeed )
				{
					MyTentSouthAddonDeed tent = (MyTentSouthAddonDeed)item;
					int TentHue = tent.TentColor;
					from.AddToBackpack( new MyTentEastAddonDeed( TentHue, 1 ) );
					item.Delete();
				}
				else if ( item is BaseAddonDeed ) { from.SendMessage( "That deed cannot be flipped to face another direction!" ); }
				else { from.SendMessage( "This only flips deeds that are on the floor in your home!" ); }
			}

			private static void Up( Item item, Mobile from )
			{
				int floorZ = GetFloorZ( item );

				if( item is BaseDoor )
					from.SendMessage("You cannot move doors around with this.");
				else if ( floorZ > int.MinValue && item.Z < (floorZ + 15) ) // Confirmed : no height checks here
					item.Location = new Point3D( item.Location, item.Z + 1 );
				else
					from.SendLocalizedMessage( 1042274 ); // You cannot raise it up any higher.
			}

			private static void Down( Item item, Mobile from )
			{
				int floorZ = GetFloorZ( item );

				if( item is BaseDoor )
					from.SendMessage("You cannot move doors around with this.");
				else if ( floorZ > int.MinValue && item.Z > GetFloorZ( item ) )
					item.Location = new Point3D( item.Location, item.Z - 1 );
				else
					from.SendLocalizedMessage( 1042275 ); // You cannot lower it down any further.
			}

			private static void North( Item item, Mobile from, BaseHouse house )
			{
				Point3D m_PointDest = new Point3D( item.X, item.Y - 1, item.Z );

				if( item is BaseDoor )
					from.SendMessage("You cannot move doors around with this.");
				else if ( !SpellHelper.CheckMulti( m_PointDest, from.Map ) )
					from.SendMessage("You cannot move it north any further.");
				else if (house.IsInside(new Point3D(item.X, item.Y - 1, item.Z), item.ItemData.Height))
					item.Y = (item.Y - 1);
				else
					from.SendMessage("You cannot move it north any further.");
			}

			private static void East( Item item, Mobile from, BaseHouse house  )
			{
				Point3D m_PointDest = new Point3D( item.X + 1, item.Y, item.Z );

				if( item is BaseDoor )
					from.SendMessage("You cannot move doors around with this.");
				else if ( !SpellHelper.CheckMulti( m_PointDest, from.Map ) )
					from.SendMessage("You cannot move it east any further.");
				else if (house.IsInside(new Point3D(item.X + 1, item.Y, item.Z), item.ItemData.Height))
					item.X = (item.X + 1);
				else
					from.SendMessage("You cannot move it east any further.");
			}

			private static void South(Item item, Mobile from, BaseHouse house)
			{
				Point3D m_PointDest = new Point3D( item.X, item.Y + 1, item.Z );

				if( item is BaseDoor )
					from.SendMessage("You cannot move doors around with this.");
				else if ( !SpellHelper.CheckMulti( m_PointDest, from.Map ) )
					from.SendMessage("You cannot move it south any further.");
				else if (house.IsInside(new Point3D(item.X, item.Y + 1, item.Z), item.ItemData.Height))
					item.Y = (item.Y + 1);
				else
					from.SendMessage("You cannot move it south any further.");
			}

			private static void West(Item item, Mobile from, BaseHouse house)
			{
				Point3D m_PointDest = new Point3D( item.X - 1, item.Y, item.Z );

				if( item is BaseDoor )
					from.SendMessage("You cannot move doors around with this.");
				else if ( !SpellHelper.CheckMulti( m_PointDest, from.Map ) )
					from.SendMessage("You cannot move it west any further.");
				else if (house.IsInside(new Point3D(item.X - 1, item.Y, item.Z), item.ItemData.Height))
					item.X = (item.X - 1);
				else
					from.SendMessage("You cannot move it west any further.");
			}

			private static int GetFloorZ( Item item )
			{
				Map map = item.Map;

				if ( map == null )
					return int.MinValue;

				StaticTile[] tiles = map.Tiles.GetStaticTiles( item.X, item.Y, true );

				int z = int.MinValue;

				for ( int i = 0; i < tiles.Length; ++i )
				{
					StaticTile tile = tiles[i];
					ItemData id = TileData.ItemTable[tile.ID & TileData.MaxItemValue];

					int top = tile.Z; // Confirmed : no height checks here

					if ( id.Surface && !id.Impassable && top > z && top <= item.Z )
						z = top;
				}

				return z;
			}
		}
	}
}