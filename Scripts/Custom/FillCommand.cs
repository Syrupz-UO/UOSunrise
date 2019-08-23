using System;
using Server;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Mobiles;
using Server.Targets;
using Server.Network;
using Server.Targeting;
using Server.Commands;
using Solaris.ItemStore;

namespace Server.Scripts.Commands
{
    public class Fill
    {
        public static void Initialize()
        {
            Register( "Fill", AccessLevel.Player, new CommandEventHandler( FillCommand ) );
        }
        public static void Register( string command, AccessLevel access, CommandEventHandler handler )
        {
            CommandSystem.Register( command, access, handler );
        }

        [Usage( "Fill" )]
        [Description( "Fills master keys from command" )]
public static void FillCommand ( CommandEventArgs e )
{
    Mobile from = e.Mobile;

    Item masterkeys = from.Backpack.FindItemByType(typeof(MasterItemStoreKey));

    if (masterkeys != null )
    {
        ((MasterItemStoreKey)masterkeys).Fill(from);
    }
}
}

}







































