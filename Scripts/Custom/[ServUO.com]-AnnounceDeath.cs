using System;
using System.Collections;
using Server.Network;
using Server.Mobiles;

namespace Server
{
	public class AnnounceDeath
	{
		public static void Initialize()
		{
			EventSink.PlayerDeath += new PlayerDeathEventHandler( OnDeath );
		}

		public static void OnDeath( PlayerDeathEventArgs args )
		{
			Mobile from = args.Mobile;
			Mobile c = from.LastKiller;
			string victim = from.Name;
			string killer = "";
			if ( c != null )
			{
				killer = c.Name + " " + c.Title;
				BaseCreature bc = c as BaseCreature;
				if ( bc != null && bc.ControlMaster != null )
				{
					killer = bc.ControlMaster.Name;
					if ( from == bc.ControlMaster )
						killer = "their own pet";
				}
			}

			if ( c == null )
				World.Broadcast( 0x18, true, "{0} died at the hands of a {1}", victim,killer );
			else if ( c == from )
				World.Broadcast( 0x18, true, "{0} has committed suicide!", victim );
			else if ( c is PlayerMobile )
				World.Broadcast( 0x18, true, "{0} has been murdered by {1}!", victim, killer );
			else 
				World.Broadcast( 0x18, true, "{0} has been killed by {1}!", victim, killer );
		}
	}
}
