using System;
using System.Text;
using Server;
using Server.Items;

namespace Server.Commands
{
	public class SetDecay
	{
		public static void Initialize()
		{
			CommandSystem.Register( "SetDecay", AccessLevel.Administrator, new CommandEventHandler( SetDecay_OnCommand ) );
			Item.DefaultDecayTime = TimeSpan.FromMinutes(60);
		}

		[Usage( "SetDecay [minutes]" )]
		[Description( "Sets/reports the default decay time for items in minutes" )]
		public static void SetDecay_OnCommand( CommandEventArgs e )
		{
			if( e.Arguments.Length > 0 )
			{
				try
				{
					int minutes = Convert.ToInt32(e.Arguments[0]);

					Item.DefaultDecayTime = TimeSpan.FromMinutes(minutes);
				}
				catch {}
			}

			e.Mobile.SendMessage("Default decay time set to {0}",Item.DefaultDecayTime);
		}
	}
}