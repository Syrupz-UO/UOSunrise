using System;
using Server;
using Server.Commands;
using Server.Mobiles;
using Server.Regions;
using Server.Gumps;
using System.Collections;
using System.Collections.Generic;
using Server.Items;

namespace Server.Items
{
    public class EventStone : Item
    {
        #region Private Variables
		 private static List<Mobile> m_DuelList; //----List of players that signed up.
		 private List<Mobile> m_BroadcastList; //----List of players to broadcast to.
		 private static bool m_Running;//---------Are we running the event?
		 private static bool m_AcceptingPlayers;//-----Are we accepting players?
		 private static Point3D m_StartLocation;//-----Start Location of event.
		 private static Map m_MapLocation;//-----------Event Stone Map
		 private InternalTimer m_RestartTimer;
         private bool m_TimerEnabled;
		 private static TimeSpan m_EventRate;
         private static DateTime m_LastEvent;
         private static DateTime m_LastReset;
		 //How many times the join message will be broadcasted
         private const int BroadCastMaxTicks = 4;
         private const int BroadCastTickDelay = 60; //seconds
         private int m_CurrentBroadCastTicks;
         private static BroadcastTimer BCastTimer;
         private int m_CountDown;
         private int m_BroadcastHue;
		 
		 
		#endregion 
 /////////////////////////////////////////////////////////////////////////////		
 
        [CommandProperty(AccessLevel.Developer)]
        public DateTime LastReset
        {
            get { return m_LastReset; }
            set { m_LastReset = value; }
        }
		
		 public List<Mobile> DuelList
        {
            get { return m_DuelList; }
        }
		
        [CommandProperty(AccessLevel.Developer)]
        public bool TimerEnabled
        {
            get { return m_TimerEnabled; }
            set 
            { 
                m_TimerEnabled = value;
                if (value)
                    m_RestartTimer.Start();
            }
        }
		
		  [CommandProperty(AccessLevel.Developer)]
        public int BroadCastHue
        {
            get { return m_BroadcastHue; }
            set { m_BroadcastHue = value; }
        }
		
        [CommandProperty(AccessLevel.Developer)]
        public Map MapLocation
        {
            get { return m_MapLocation; }
            set { m_MapLocation = value; }
        }

        [CommandProperty(AccessLevel.Developer)]
        public static bool Running
        {
            get { return m_Running; }
            set { m_Running = value; }
        }

        [CommandProperty(AccessLevel.Developer)]
        public static bool AcceptingPlayers
        {
            get { return m_AcceptingPlayers; }
            set { m_AcceptingPlayers = value; }
        }

        [CommandProperty(AccessLevel.Developer)]
        public static DateTime LastEvent
        {
            get { return m_LastEvent; }
            set { m_LastEvent = value; }
        }

        [CommandProperty(AccessLevel.Developer)]
        public TimeSpan EventRate
        {
            get { return m_EventRate; }
            set { m_EventRate = value; }
        }

        [CommandProperty(AccessLevel.Developer)]
        public static Point3D StartLocation
        {
            get { return m_StartLocation; }
            set { m_StartLocation = value; }
        }

        [CommandProperty(AccessLevel.Developer)]
        public bool KickStart
        {
            get { return false; }
            set
            {
                if (value && !m_Running)
                    StartPvP();
            }
        }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region Constructor

        [Constructable]
        public EventStone() : base(0xEDC)
        {
            Name = "Event Stone";
            Movable = false;
            Visible = false;
            m_Running = false;
			m_EventRate = TimeSpan.FromHours(6.0);
			m_LastEvent = DateTime.Now;
		    m_StartLocation = new Point3D(6927, 2122, 5);
			m_MapLocation = Map.Felucca;
			m_RestartTimer = new InternalTimer(this, TimeSpan.FromSeconds(1.0));
            m_LastReset = DateTime.Now;
            m_TimerEnabled = false;
			m_BroadcastHue = 269;
            m_BroadcastList = new List<Mobile>();
			
        }

        #endregion
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        #region Misc Methods

        /// <summary>
        /// Double click the PvP Stone to open up the properties window for it. (Game Master+)
        /// </summary>
        /// <param name="from"></param>
        public override void OnDoubleClick(Mobile from)
        {
            if (from.AccessLevel > AccessLevel.GameMaster)
                from.SendGump(new PropertiesGump(from, this));
        }

        /// <summary>
        /// Display any needed data here for the stone properties.
        /// </summary>
        /// <param name="list"></param>
        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);
           
        }

        #endregion
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
      #region Command Events [pvp

        /// <summary>
        /// When the PvP Event is active, players have access to join it.
        /// </summary>
        /// <param name="e">Command Event Args</param>
        public static void JoinEventCommandEvent(CommandEventArgs e)
        {
            if (!e.Mobile.Alive)
            {
                e.Mobile.SendMessage("you can not enter an event if your dead.");
                return;
            }
            if (Running)
            {
                if (AcceptingPlayers)
                {
                    e.Mobile.MoveToWorld(StartLocation, m_MapLocation);
                    e.Mobile.Hidden = false;
                }
                else
                {
                    e.Mobile.SendMessage("the event is not accepting anymore players");
                }
            }
            else
            {
                e.Mobile.SendMessage("The event is not running");
            }
        }


        /// <summary>
        /// When the Server boots up, add the [pvp command to the list.
        /// </summary>
        public static void Initialize()
        {
            CommandSystem.Register("JoinBridge", AccessLevel.Player, new CommandEventHandler(JoinEventCommandEvent));
        }

        #endregion		
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

///////////////////////////////////////////////////////////////////////////////////////////INITIALIZEEVENT--INITIALIZEEVENT--/////////////////////////////////////////////////////////////////////////////////////////////////
    

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////////////////////////////STARTPVPENVENT - STARTPVPEVENT///////////////////////////////////////////////////////////////////////////////////////////////////
      /// <summary>
        /// Starts the PvP Event
        /// </summary>
        public void StartPvP()
        {
            if (!Running)
            {
                Running = true;
                AcceptingPlayers = true;
                LastEvent = DateTime.Now;
                BCastTimer = new BroadcastTimer(this, TimeSpan.FromSeconds(BroadCastTickDelay), TimeSpan.FromSeconds(BroadCastTickDelay));
                BCastTimer.Start();
                string text = "A Bridge Event is starting up. Type [joinbridge To Join.";
                World.Broadcast(m_BroadcastHue, true, String.Format("{0}", text));
				
				
				
				switch( Utility.Random( 4 ) )

			{

				case 0:// Wooden Chest

					SunriseScroll Scroll = new SunriseScroll();
					Scroll.MoveToWorld(new Point3D(6952, 2121, 5), Map.Felucca); // <-------Place the reward on the other platform

					break;



				case 1:// Metal Chest

					BankBell Bell = new BankBell();
					Bell.MoveToWorld(new Point3D(6952, 2121, 5), Map.Felucca); // <-------Place the reward on the other platform

					break;



				case 2:// Metal Golden Chest

					SunriseScroll Scrolls = new SunriseScroll();
					Scrolls.MoveToWorld(new Point3D(6952, 2121, 5), Map.Felucca); // <-------Place the reward on the other platform

					break;



				case 3:// Keg

					ScrollBinderDeed Scroll2 = new ScrollBinderDeed();
					Scroll2.MoveToWorld(new Point3D(6952, 2121, 5), Map.Felucca); // <-------Place the reward on the other platform

					break;

			}

		}
				
				
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////////////////CLOSE EVENT-CLOSE EVENT/////////////////////////////////////////////////////////////////////////////////////////////////////////
 /// <summary>
        /// Close the event down here.
        /// </summary>
        public void CloseEvent()
        {
          
            //clear the broadcast list
            m_BroadcastList.Clear();
            //shut event off
            m_Running = false;
            //clear broadcastticks
            m_CurrentBroadCastTicks = 0;
            //close command to join

            if (m_RestartTimer != null)
            {
                m_AcceptingPlayers = false; m_RestartTimer = new InternalTimer(this, TimeSpan.FromSeconds(1.0));
                m_RestartTimer.Start();
            }
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////////////////////////CLEAN PLAYERS FOR EVENT/////////////////////////////////////////////////////////////////////////////////////////////////////////
 
        public void CleanPlayer(Mobile pm)
        {
            //Cure Poison
            pm.CurePoison(pm);
            //Reset Hit Points
            pm.Hits = pm.HitsMax;
            //Rest Mana
            pm.Mana = pm.ManaMax;
            //Reset Stam
            pm.Stam = pm.StamMax;
            //Cancel any targeting
            Targeting.Target.Cancel(pm);
            //remove abosorption for magic
            pm.MagicDamageAbsorb = 0;
            //remove absorption for melee
            pm.MeleeDamageAbsorb = 0;
            //clear protection spell
            Spells.Second.ProtectionSpell.Registry.Remove(pm);
            //clear curse effect
            Spells.Fourth.CurseSpell.RemoveEffect(pm);
            //clear corpseskin
            Server.Spells.Necromancy.CorpseSkinSpell.RemoveCurse(pm);
            //clear blodd oath
            Server.Spells.Necromancy.BloodOathSpell.RemoveCurse(pm);
            //clear evil omen
            //Server.Spells.Necromancy.EvilOmenSpell.RemoveCurse(pm);
            //remove strangle
            Server.Spells.Necromancy.StrangleSpell.RemoveCurse(pm);
            //clear Paralyzed
            pm.Paralyzed = false;
            //clear defensive spell
            DefensiveSpell.Nullify(pm);
            //remove any combatant
            pm.Combatant = null;
            //remove war mode
            pm.Warmode = false;
            //remove criminal
            pm.Criminal = false;
            //clear agressed list
            pm.Aggressed.Clear();
            //clear agressor list
            pm.Aggressors.Clear();
            //clear delta notoriety
            pm.Delta(MobileDelta.Noto);
            //invalidate any properties due to the previous changes
            pm.InvalidateProperties();
        }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////SERIALIZE-DESERIALIZE///////////////////////////////////////////////////////////////////////////////////////////////////////////
        #region serial/deserialize

        public EventStone( Serial serial ) : base( serial )
		{
		}

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1); // version
			writer.Write((bool)m_AcceptingPlayers);
            writer.Write((bool)m_Running);
			writer.Write((Point3D)m_StartLocation);
			writer.Write((Map)m_MapLocation);
			writer.Write((DateTime)m_LastReset);
			writer.Write((bool)m_TimerEnabled);
			writer.Write((TimeSpan)m_EventRate);
			writer.Write((DateTime)m_LastEvent);
			writer.Write((int)m_BroadcastHue);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
				  case 1:
                    {
                        m_AcceptingPlayers = (bool)reader.ReadBool();
                        goto case 0;
                    }
				  case 0:
                    {
						m_Running = (bool)reader.ReadBool();
						m_StartLocation = (Point3D)reader.ReadPoint3D();
						m_MapLocation = (Map)reader.ReadMap();
						m_LastReset = (DateTime)reader.ReadDateTime();
						m_TimerEnabled = (bool)reader.ReadBool();
						m_EventRate = (TimeSpan)reader.ReadTimeSpan();
						m_LastEvent = (DateTime)reader.ReadDateTime();
						m_BroadcastHue = (int)reader.ReadInt();
						break;
					}			
            }
					if (version == 0)
					{	
					m_LastReset = DateTime.Now;
					}
					m_RestartTimer = new InternalTimer(this, TimeSpan.FromSeconds(1.0));
            
					if(m_TimerEnabled)
					m_RestartTimer.Start();
			}
        #endregion
//////////////////////////////////////////////////////////////////////////////////////////////////BROADCASTER-BROADCASTER//////////////////////////////////////////////////////////////////////////////////////////////////////
       #region Broadcasting System

        /// <summary>
        /// Send a broadcast worldwide for players to join
        /// </summary>
        public virtual void DoBcast()
        {
            m_CurrentBroadCastTicks++;
            if (m_CurrentBroadCastTicks <= BroadCastMaxTicks)
            {
                int minutesleft = BroadCastMaxTicks - m_CurrentBroadCastTicks + 1;
                string text = "A Bridge Event is starting up. " + minutesleft.ToString() + " minutes left to join.  Type [joinbridge To Join.";
                World.Broadcast(m_BroadcastHue, true, String.Format("{0}", text));
            }
            else
            {
                m_CurrentBroadCastTicks = 0;
                BCastTimer.Stop();
                m_AcceptingPlayers = false;
                //InitializeEvent();
            }
        }
		#endregion
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		
//////////////////////////////////////////////////////////////////////////////////////////////////TIMERS-TIMERS-TIMERS/////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Timer Class for Broad Casting to players every 15 seconds.
        /// </summary>
        private class BroadcastTimer : Timer
        {
            private EventStone m_stone;
            public BroadcastTimer(EventStone stone, TimeSpan span1, TimeSpan span2) : base(span1, span2)
            {
                Priority = TimerPriority.OneSecond;
                m_stone = stone;
            }

            protected override void OnTick()
            {
                m_stone.DoBcast();
            }
        }

        #region AutoTimer

        private void RestartTick()
        {
            if (m_TimerEnabled)
            {
                if (m_LastEvent + m_EventRate <= DateTime.Now)
                {
                    KickStart = true;
                    m_LastEvent = DateTime.Now;
                }

                if (m_RestartTimer != null)
                    m_RestartTimer.Stop();

                if (!m_Running && m_RestartTimer != null)
                {
                    m_RestartTimer = new InternalTimer(this, TimeSpan.FromSeconds(1.0));
                    m_RestartTimer.Start();
                }
            }
        }

        public override void OnDelete()
        {
            base.OnDelete();

            if (m_RestartTimer != null)
                m_RestartTimer.Stop();
        }

        private class InternalTimer : Timer
        {
            private EventStone m_stone;

            public InternalTimer(EventStone spawner, TimeSpan delay) : base(delay)
            {
                m_stone = spawner;
            }

            protected override void OnTick()
            {
                if (m_stone != null)
                    if (!m_stone.Deleted)
                        m_stone.RestartTick();
            }
        }

        #endregion		
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////	
}
}
