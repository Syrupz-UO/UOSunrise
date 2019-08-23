using System;
using Server;
using System.Collections;
using Server.Misc;
using Server.Network;
using Server.Commands;
using Server.Commands.Generic;
using Server.Mobiles;
using Server.Accounting;
using Server.Items;

namespace Server.Misc
{
    class WearAndTear
    {
		public static void OnUsed( Item tool )
		{
			if ( 50 > Utility.Random( 100 ) && tool is BaseWeapon ) // 50% chance to lower durability
			{
				if ( ((BaseWeapon)tool).WeaponAttributes.SelfRepair > Utility.Random( 10 ) )
				{
					((BaseWeapon)tool).HitPoints += 2;
				}
				else
				{
					int wear = Utility.Random( 2 );

					if ( wear > 0 && ((BaseWeapon)tool).MaxHitPoints > 0 )
					{
						if ( ((BaseWeapon)tool).HitPoints >= wear )
						{
							((BaseWeapon)tool).HitPoints -= wear;
							wear = 0;
						}
						else
						{
							wear -= ((BaseWeapon)tool).HitPoints;
							((BaseWeapon)tool).HitPoints = 0;
						}

						if ( wear > 0 )
						{
							if ( ((BaseWeapon)tool).MaxHitPoints > wear )
							{
								((BaseWeapon)tool).MaxHitPoints -= wear;

								if ( ((BaseWeapon)tool).Parent is Mobile )
									((Mobile)(((BaseWeapon)tool).Parent)).LocalOverheadMessage( MessageType.Regular, 0x3B2, 1061121 ); // Your equipment is severely damaged.
							}
							else
							{
								tool.Delete();
							}
						}
					}
				}
			}
		}
	}
}