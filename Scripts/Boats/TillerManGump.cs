using Server.Mobiles;
using Server.Multis;
using Server.Network;

namespace Server.Gumps 
{
    public class TillerManGump : Gump
    {
		private Mobile m_From;
		private BaseBoat m_Boat;
		private bool ToggleOneStep;

		private static int Map = 9006;
		
        public TillerManGump ( Mobile from, BaseBoat boat, bool onestep ) : base ( 0, 0 )
        {
			m_From = from;
			m_Boat = boat;

			ToggleOneStep = onestep;
			
			Closable=true;
			Disposable=false;
			Dragable=true;
			Resizable=false;
			AddPage(0);

			AddButton(77, 358, 9780, 9780, 100, GumpButtonType.Reply, 1);			// STOP

			AddImage(108, 308, 103);

			AddButton(128, 328, 10006, 10006, 9, GumpButtonType.Reply, 1);			// ONE STEP
			if( !ToggleOneStep ){ AddLabel(147, 324, 0x477, @"One Step"); } else { AddLabel(147, 324, 0x477, @"Full Speed"); }

			AddButton(128, 353, 10006, 10006, 10, GumpButtonType.Reply, 1);			// ANCHOR
			if( m_Boat.Anchored ){ AddLabel(147, 349, 0x477, @"Raise Anchor"); } else { AddLabel(147, 349, 0x477, @"Drop Anchor"); }

			AddButton(128, 377, 10006, 10006, 99, GumpButtonType.Reply, 1);			// RENAME SHIP
			AddLabel(147, 374, 0x477, @"Rename Ship");

			if ( Map == 9006 ) // LARGE MAP
			{
				AddImage(38, 39, 9006);
				AddButton(251, 350, 10505, 10505, 101, GumpButtonType.Reply, 1);
				AddButton(244, 91, 11320, 11320, 1, GumpButtonType.Reply, 1);			// N
				AddButton(279, 167, 11320, 11320, 2, GumpButtonType.Reply, 1);			// NE
				AddButton(244, 243, 11320, 11320, 3, GumpButtonType.Reply, 1);			// E
				AddButton(166, 279, 11320, 11320, 4, GumpButtonType.Reply, 1);			// SE
				AddButton(90, 245, 11320, 11320, 5, GumpButtonType.Reply, 1);			// S
				AddButton(54, 168, 11320, 11320, 6, GumpButtonType.Reply, 1);			// SW
				AddButton(90, 90, 11320, 11320, 7, GumpButtonType.Reply, 1);			// W
				AddButton(167, 55, 11320, 11320, 8, GumpButtonType.Reply, 1);			// NW
			}
			else
			{
				AddImage(78, 107, 9007);
				AddButton(251, 350, 10502, 10502, 101, GumpButtonType.Reply, 1);
				AddButton(223, 138, 11320, 11320, 1, GumpButtonType.Reply, 1);			// N
				AddButton(250, 195, 11320, 11320, 2, GumpButtonType.Reply, 1);			// NE
				AddButton(223, 252, 11320, 11320, 3, GumpButtonType.Reply, 1);			// E
				AddButton(166, 279, 11320, 11320, 4, GumpButtonType.Reply, 1);			// SE
				AddButton(110, 253, 11320, 11320, 5, GumpButtonType.Reply, 1);			// S
				AddButton(82, 195, 11320, 11320, 6, GumpButtonType.Reply, 1);			// SW
				AddButton(109, 138, 11320, 11320, 7, GumpButtonType.Reply, 1);			// W
				AddButton(166, 111, 11320, 11320, 8, GumpButtonType.Reply, 1);			// NW
			}

			AddButton(88, 308, 9909, 9909, 11, GumpButtonType.Reply, 1);			// TURN LEFT
			AddButton(250, 307, 9903, 9903, 12, GumpButtonType.Reply, 1);			// TURN RIGHT
			AddButton(169, 407, 9906, 9906, 13, GumpButtonType.Reply, 1);			// COME ABOUT
        }

		public override void OnResponse( NetState sender, RelayInfo info )
		{
			if( m_Boat == null || m_From == null )
				return;
				
			if( !m_Boat.Contains( m_From ) )
			{
				m_From.SendMessage( "You have to be on the boat to do that" );
				m_From.CloseGump( typeof( TillerManGump ) );
				return;
			}

			switch ( info.ButtonID )
			{
				case 100: m_Boat.StopMove( true ); break;
				case 101: 
				{
					switch( Map )
					{
						case 9006: Map = 9007; break;
						case 9007: Map = 9006; break;
					}
					break;
				}
				case 99: m_Boat.BeginRename( m_From ); break;

				case 1: // N
				{
					if ( m_Boat.Facing == Direction.North ){      if( !ToggleOneStep ){ m_Boat.StartMove( Direction.North, true ); } else { m_Boat.OneMove( Direction.North ); }	}
					else if ( m_Boat.Facing == Direction.South ){ if( !ToggleOneStep ){ m_Boat.StartMove( Direction.South, true ); } else { m_Boat.OneMove( Direction.South ); }	}
					else if ( m_Boat.Facing == Direction.East ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.West, true ); } else { m_Boat.OneMove( Direction.West ); }	}
					else if ( m_Boat.Facing == Direction.West ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.East, true ); } else { m_Boat.OneMove( Direction.East ); }	}
					break;
				}
				case 2: // NE
				{
					if ( m_Boat.Facing == Direction.North ){      if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Right, true ); } else { m_Boat.OneMove( Direction.Right ); }	}
					else if ( m_Boat.Facing == Direction.South ){ if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Left, true ); } else { m_Boat.OneMove( Direction.Left ); }	}
					else if ( m_Boat.Facing == Direction.East ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Up, true ); } else { m_Boat.OneMove( Direction.Up ); }	}
					else if ( m_Boat.Facing == Direction.West ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Down, true ); } else { m_Boat.OneMove( Direction.Down ); }	}
					break;
				}
				case 3: // E
				{
					if ( m_Boat.Facing == Direction.North ){      if( !ToggleOneStep ){ m_Boat.StartMove( Direction.East, true ); } else { m_Boat.OneMove( Direction.East ); }	}
					else if ( m_Boat.Facing == Direction.South ){ if( !ToggleOneStep ){ m_Boat.StartMove( Direction.West, true ); } else { m_Boat.OneMove( Direction.West ); }	}
					else if ( m_Boat.Facing == Direction.East ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.North, true ); } else { m_Boat.OneMove( Direction.North ); }	}
					else if ( m_Boat.Facing == Direction.West ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.South, true ); } else { m_Boat.OneMove( Direction.South ); }	}
					break;
				}
				case 4: // SE
				{
					if ( m_Boat.Facing == Direction.North ){      if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Down, true ); } else { m_Boat.OneMove( Direction.Down ); }	}
					else if ( m_Boat.Facing == Direction.South ){ if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Up, true ); } else { m_Boat.OneMove( Direction.Up ); }	}
					else if ( m_Boat.Facing == Direction.East ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Right, true ); } else { m_Boat.OneMove( Direction.Right ); }	}
					else if ( m_Boat.Facing == Direction.West ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Left, true ); } else { m_Boat.OneMove( Direction.Left ); }	}
					break;
				}
				case 5: // S
				{
					if ( m_Boat.Facing == Direction.North ){      if( !ToggleOneStep ){ m_Boat.StartMove( Direction.South, true ); } else { m_Boat.OneMove( Direction.South ); }	}
					else if ( m_Boat.Facing == Direction.South ){ if( !ToggleOneStep ){ m_Boat.StartMove( Direction.North, true ); } else { m_Boat.OneMove( Direction.North ); }	}
					else if ( m_Boat.Facing == Direction.East ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.East, true ); } else { m_Boat.OneMove( Direction.East ); }	}
					else if ( m_Boat.Facing == Direction.West ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.West, true ); } else { m_Boat.OneMove( Direction.West ); }	}
					break;
				}
				case 6: // SW
				{
					if ( m_Boat.Facing == Direction.North ){      if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Left, true ); } else { m_Boat.OneMove( Direction.Left ); }	}
					else if ( m_Boat.Facing == Direction.South ){ if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Right, true ); } else { m_Boat.OneMove( Direction.Right ); }	}
					else if ( m_Boat.Facing == Direction.East ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Down, true ); } else { m_Boat.OneMove( Direction.Down ); }	}
					else if ( m_Boat.Facing == Direction.West ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Up, true ); } else { m_Boat.OneMove( Direction.Up ); }	}
					break;
				}
				case 7: // W
				{
					if ( m_Boat.Facing == Direction.North ){      if( !ToggleOneStep ){ m_Boat.StartMove( Direction.West, true ); } else { m_Boat.OneMove( Direction.West ); }	}
					else if ( m_Boat.Facing == Direction.South ){ if( !ToggleOneStep ){ m_Boat.StartMove( Direction.East, true ); } else { m_Boat.OneMove( Direction.East ); }	}
					else if ( m_Boat.Facing == Direction.East ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.South, true ); } else { m_Boat.OneMove( Direction.South ); }	}
					else if ( m_Boat.Facing == Direction.West ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.North, true ); } else { m_Boat.OneMove( Direction.North ); }	}
					break;
				}
				case 8: // NW
				{
					if ( m_Boat.Facing == Direction.North ){      if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Up, true ); } else { m_Boat.OneMove( Direction.Up ); }	}
					else if ( m_Boat.Facing == Direction.South ){ if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Down, true ); } else { m_Boat.OneMove( Direction.Down ); }	}
					else if ( m_Boat.Facing == Direction.East ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Left, true ); } else { m_Boat.OneMove( Direction.Left ); }	}
					else if ( m_Boat.Facing == Direction.West ){  if( !ToggleOneStep ){ m_Boat.StartMove( Direction.Right, true ); } else { m_Boat.OneMove( Direction.Right ); }	}
					break;
				}

				case 9:	// TOGGLE ONE STEP
				{
					if( !ToggleOneStep )
						ToggleOneStep = true;
					else ToggleOneStep = false;
					break;
				}
				case 10:	// RAISE / DROP ANCHOR
				{
					if( m_Boat.Anchored )
						m_Boat.RaiseAnchor( true );
					else 
						m_Boat.LowerAnchor( true );
					break;
				}
				case 11:	// TURN LEFT/RIGHT/AROUND
				{
					m_Boat.StartTurn(  -2, true );	// LEFT		
					break;
				}
				case 12:
				{
					m_Boat.StartTurn(  2, true );	// RIGHT
					break;
				}
				case 13:
				{
					m_Boat.StartTurn(  -4, true );	// AROUND
					break;
				}
			}

			m_From.CloseGump( typeof( TillerManGump ) );
			m_From.SendGump( new TillerManGump( m_From, m_Boat, ToggleOneStep ) );
		}	
    }
}