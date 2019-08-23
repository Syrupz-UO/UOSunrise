using System;
using Server.Items;
using Server.Network;
using System.Collections.Generic;
using System.Collections;
using Server.Mobiles;
using Server.Misc;

namespace Server.Items
{
	public class TaskManager3Hour : Item
	{
		[Constructable]
		public TaskManager3Hour () : base( 0x0EDE )
		{
			Movable = false;
			Name = "Task Manager 3 Hours";
			Visible = false;
			TaskTimer thisTimer = new TaskTimer( this ); 
			thisTimer.Start(); 
		}

        public TaskManager3Hour(Serial serial) : base(serial)
		{
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

			if ( Server.Misc.DifficultyLevel.RunRoutinesAtStartup() )
			{
				FirstTimer thisTimer = new FirstTimer( this ); 
				thisTimer.Start();
			}
		}

		public class TaskTimer : Timer 
		{ 
			private Item i_item; 
			public TaskTimer( Item task ) : base( TimeSpan.FromMinutes( 180.0 ) )
			{ 
				Priority = TimerPriority.OneMinute; 
				i_item = task; 
			} 

			protected override void OnTick() 
			{
				LoggingFunctions.LogServer( "Start - Planting Gardens" );
				
				TaskTimer thisTimer = new TaskTimer( i_item ); 
				thisTimer.Start(); 
				RunThis( false );
			} 
		}

		public class FirstTimer : Timer 
		{ 
			private Item i_item; 
			public FirstTimer( Item task ) : base( TimeSpan.FromSeconds( 5.0 ) )
			{ 
				Priority = TimerPriority.OneSecond; 
				i_item = task; 
			} 

			protected override void OnTick() 
			{
				TaskTimer thisTimer = new TaskTimer( i_item ); 
				thisTimer.Start(); 
				RunThis( true );
			} 
		}

		public static void RunThis( bool DoAction )
		{
			///// PLANT THE GARDENS //////////////////////////////////////
			Farms.PlantGardens();
			
			LoggingFunctions.LogServer( "Done - Planting Gardens" );

			///// ADD RANDOM CITIZENS IN SETTLEMENTS /////////////////////
			Server.Mobiles.Citizen.PopulateCities();

			///// RECONFIGURE SOME LAND SPAWNS AND OTHER ITEMS ///////////

			ArrayList spawns = new ArrayList();
			foreach ( Item item in World.Items.Values )
			{
				if ( item is PremiumSpawner )
				{
					PremiumSpawner spawner = (PremiumSpawner)item;

					if ( spawner.SpawnID == 8888 )
					{
						bool reconfigure = true;

						foreach ( NetState state in NetState.Instances )
						{
							Mobile m = state.Mobile;

							if ( m is PlayerMobile && m.InRange( spawner.Location, (spawner.HomeRange+20) ) )
							{
								reconfigure = false;
							}
						}

						if ( reconfigure ){ spawns.Add( item ); }
					}
				}
				else if ( item is Coffer )
				{
					Coffer coffer = (Coffer)item;
					Server.Items.Coffer.SetupCoffer( coffer );
				}
				else if ( item is HayCrate || item is HollowStump )
				{
					item.Stackable = false;
				}
			}

			for ( int i = 0; i < spawns.Count; ++i )
			{
				PremiumSpawner spawners = ( PremiumSpawner )spawns[ i ];
				Server.Mobiles.PremiumSpawner.Reconfigure( spawners, DoAction );
			}
		}
	}
}