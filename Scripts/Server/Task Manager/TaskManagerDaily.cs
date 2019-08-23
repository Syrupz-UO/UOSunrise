using System;
using Server.Items;
using Server.Network;
using System.Collections.Generic;
using System.Collections;
using Server.Mobiles;
using Server.Misc;
using Server.Targeting;

namespace Server.Items
{
	public class TaskManagerDaily : Item
	{
		[Constructable]
		public TaskManagerDaily () : base( 0x0EDE )
		{
			Movable = false;
			Name = "Task Manager Daily";
			Visible = false;
			TaskTimer thisTimer = new TaskTimer( this ); 
			thisTimer.Start(); 
		}

        public TaskManagerDaily(Serial serial) : base(serial)
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
			public TaskTimer( Item task ) : base( TimeSpan.FromMinutes( 1440.0 ) )
			{ 
				Priority = TimerPriority.OneMinute; 
				i_item = task; 
			} 

			protected override void OnTick() 
			{
				TaskTimer thisTimer = new TaskTimer( i_item ); 
				thisTimer.Start(); 
				RunThis();
			} 
		}

		public class FirstTimer : Timer 
		{ 
			private Item i_item; 
			public FirstTimer( Item task ) : base( TimeSpan.FromSeconds( 10.0 ) )
			{ 
				Priority = TimerPriority.OneSecond; 
				i_item = task; 
			} 

			protected override void OnTick() 
			{
				TaskTimer thisTimer = new TaskTimer( i_item ); 
				thisTimer.Start(); 
				RunThis();
			} 
		}

		public static void RunThis()
		{
			LoggingFunctions.LogServer( "Start - Arrange Quest Search Crates" );
			
			///// MOVE THE SEARCH PEDESTALS //////////////////////////////////////
			BuildQuests.SearchCreate();

			LoggingFunctions.LogServer( "Done - Arrange Quest Search Crates" );
			
			LoggingFunctions.LogServer( "Start - Change Stealing Pedestals" );
			
			///// MAKE THE STEAL PEDS LOOK DIFFERENT /////////////////////////////
			BuildSteadPeds.CreateStealPeds();

			LoggingFunctions.LogServer( "Done - Change Stealing Pedestals" );

			LoggingFunctions.LogServer( "Start - Remove Spread Out Monsters, Drinkers, And Healers" );
			
			///// CLEANUP THE CREATURES MASS SPREAD OUT IN THE LAND //////////////

			ArrayList targets = new ArrayList();
			ArrayList healers = new ArrayList();
			ArrayList exodus = new ArrayList();
			ArrayList gargoyle = new ArrayList();
			foreach ( Mobile creature in World.Mobiles.Values )
			{
				if ( creature is CodexGargoyleA || creature is CodexGargoyleB )
				{
					gargoyle.Add( creature );
				}
				else if ( creature.WhisperHue == 999 || creature.WhisperHue == 911 )
				{
					if ( creature != null )
					{
						if ( creature is WanderingHealer || creature is Courier ){ healers.Add( creature ); }
						else if ( creature is Exodus ){ exodus.Add( creature ); }
						else { targets.Add( creature ); }
					}
				}
			}
			for ( int i = 0; i < targets.Count; ++i )
			{
				Mobile creature = ( Mobile )targets[ i ];
				if ( creature.Hidden == false )
				{
					if ( creature.WhisperHue == 911 )
					{
						Effects.SendLocationEffect( creature.Location, creature.Map, 0x3400, 60, 0x6E4, 0 );
						Effects.PlaySound( creature.Location, creature.Map, 0x108 );
					}
					else
					{
						creature.PlaySound( 0x026 );
						Effects.SendLocationEffect( creature.Location, creature.Map, 0x352D, 16, 4 );
					}
				}
				creature.Delete();
			}
			for ( int i = 0; i < exodus.Count; ++i )
			{
				Mobile creature = ( Mobile )exodus[ i ];
				Server.Misc.IntelligentAction.BurnAway( creature );
				Worlds.MoveToRandomDungeon( creature );
				Server.Misc.IntelligentAction.BurnAway( creature );
			}
			for ( int i = 0; i < gargoyle.Count; ++i )
			{
				Mobile creature = ( Mobile )gargoyle[ i ];
				Server.Misc.IntelligentAction.BurnAway( creature );
				Worlds.MoveToRandomDungeon( creature );
				Server.Misc.IntelligentAction.BurnAway( creature );
			}
			for ( int i = 0; i < healers.Count; ++i )
			{
				Mobile healer = ( Mobile )healers[ i ];
				Effects.SendLocationParticles( EffectItem.Create( healer.Location, healer.Map, EffectItem.DefaultDuration ), 0x3728, 10, 10, 2023 );
				healer.PlaySound( 0x1FE );
				healer.Delete();
			}

			ArrayList drinkers = new ArrayList();
			foreach ( Mobile drunk in World.Mobiles.Values )
			if ( drunk is BarFlyWizardWest || drunk is BarFlyWizardSouth || drunk is BarFlyWizardNorth || drunk is BarFlyWizardEast || drunk is BarFlyWarriorWest || drunk is BarFlyWarriorSouth || drunk is BarFlyWarriorNorth || drunk is BarFlyWarriorEast )
			{
				if ( drunk != null )
				{
					drinkers.Add( drunk );
				}
			}
			for ( int i = 0; i < drinkers.Count; ++i )
			{
				Mobile drunk = ( Mobile )drinkers[ i ];
				Effects.SendLocationParticles( EffectItem.Create( drunk.Location, drunk.Map, EffectItem.DefaultDuration ), 0x3728, 8, 20, 5042 );
				Effects.PlaySound( drunk, drunk.Map, 0x201 );
				drunk.Delete();
			}

			LoggingFunctions.LogServer( "Done - Remove Spread Out Monsters, Drinkers, And Healers" );
		}
	}
}