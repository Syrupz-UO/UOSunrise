using System;
using System.Collections;
using Server;
using System.Collections.Generic;
using Server.Mobiles;
using Server.Regions;
using Server.Engines.CannedEvil;
using Server.Items;
using System.Xml;
using Server.Commands;
using Server.Network;
using Server.Gumps;
using Server.Engines.XmlSpawner2;


// This allows players to Pause in most situations. It will prevent them from moving and disable combat mode. It also hides the player so that other players can't "camp" them.
// Note: Several changes have been made since the original release. This is now an Xml attachment, and is no longer based on the AFK script.


namespace Server.Engines.XmlSpawner2
{
  
   public class Pause : XmlAttachment
   {
      
      private bool mPaused;
      private bool mCanPause = true;
        
        [CommandProperty(AccessLevel.GameMaster)]
        public bool Paused
        {
            get { return mPaused; }
            set { mPaused = value;  }
        }
        
        [CommandProperty(AccessLevel.GameMaster)]
        public bool CanPause
        {
            get { return mCanPause; }
            set { mCanPause = value;  }
        }
    

      public static void Initialize()
      {
         CommandSystem.Register( "pause", AccessLevel.Player, new CommandEventHandler( Pause_OnCommand ) );
         EventSink.Login += new LoginEventHandler( OnLogin );
         EventSink.CharacterCreated += new CharacterCreatedEventHandler(EventSink_CharacterCreated);
      }

      public static void OnLogin( LoginEventArgs e )
      {
         Pause pauseatt = (Pause)XmlAttach.FindAttachment(e.Mobile, typeof(Pause));
        
          if ( pauseatt == null )
            {
                XmlAttach.AttachTo(e.Mobile, new Pause());
                
                return;
            
            }
        
        if ( pauseatt.Paused == true )
        {
            e.Mobile.SendGump( new Pausegump( e.Mobile) );
            e.Mobile.Blessed = true;
            e.Mobile.Hidden = true;
            e.Mobile.Paralyzed = true;
            e.Mobile.Frozen = true;
        }
 
      }
      
      private static void EventSink_CharacterCreated(CharacterCreatedEventArgs e)
        {
             Pause pauseatt = (Pause)XmlAttach.FindAttachment(e.Mobile, typeof(Pause));
        
          if ( pauseatt == null )
            {
                XmlAttach.AttachTo(e.Mobile, new Pause());
                
                return;
            
            }
        }
      
      
       [Usage("Pause")]
        [Description("Pauses your character")]
      public static void Pause_OnCommand( CommandEventArgs e )
      {
         Pause pauseatt = (Pause)XmlAttach.FindAttachment(e.Mobile, typeof(Pause));
        
         if ( pauseatt == null )
            {
                XmlAttach.AttachTo(e.Mobile, new Pause());
                
                return;
            
            }
        
            if ( pauseatt.Paused == true )
            {
                pauseatt.Paused = false;
                e.Mobile.Hidden = false;
                e.Mobile.Paralyzed = false;
                e.Mobile.Frozen = false;
                e.Mobile.Blessed = false;
                
                if (e.Mobile.HasGump(typeof(Pausegump)) );
                {
                    e.Mobile.CloseGump(typeof(Pausegump));
                }
            
                
                PlayerMobile pm = (PlayerMobile)e.Mobile;
                ((PlayerMobile)pm).ClaimAutoStabledPets();
                
             }
            
             else
             {
                // region check only requires player to be about 30 steps away from the altar. this still puts them too close to the altar and could allow players to "steal" a champion spawn from another player. so I've used range check instead.
                    //if (e.Mobile.Region.IsPartOf(typeof(ChampionSpawnRegion)) )
                foreach ( Item item in e.Mobile.GetItemsInRange( 50 ) ) // 50 = range.
                {
                    if ( item is ChampionAltar  )
                    {
                        // if you change the range above or if you use Region check instead of range, you'll want to change the message below
                        e.Mobile.SendMessage( "You must be more than 50 steps away from the Champion's altar to use Pause." );
                        return;
                    }
                }
                // prevents players from using pause if they're paralyzed, frozen, holding a faction sigil, "holding" a spell target, in the middle of casting a spell, or currently attacking something.
                
                if( e.Mobile.Paralyzed == true || e.Mobile.Frozen == true || Factions.Sigil.ExistsOn( e.Mobile ) || Server.Spells.SpellHelper.CheckCombat( e.Mobile ) || e.Mobile.Spell != null || e.Mobile.Combatant != null )
                {
                  e.Mobile.SendMessage( "You cannot pause at this time." );
                  return;
                }
                
                // if (e.Mobile is PlayerMobile && (e.Mobile as PlayerMobile).DuelContext != null)
                //{
                //    e.Mobile.SendMessage( "You cannot pause while duelling!" );
               //     return;
                
               // }
                //if ( e.Mobile.Region.IsPartOf(typeof(Engines.ConPVP.SafeZone) ) )
               // {
                ///    e.Mobile.SendMessage( "You cannot pause while duelling!" );
                //    return;
               // }
                if ( pauseatt.CanPause == false )
                {
                    e.Mobile.SendMessage( "Your ability to Pause has been deactivated." );
                    return;
                }
                
                pauseatt.Paused = true;
                e.Mobile.Hidden = true;
                e.Mobile.Paralyzed = true;
                e.Mobile.Frozen = true;
                e.Mobile.Warmode = false;
                e.Mobile.Blessed = true;
                
                e.Mobile.SendGump( new Pausegump( e.Mobile) );
                
                PlayerMobile pm = (PlayerMobile)e.Mobile;
            
                if (((!pm.Mounted || (pm.Mount != null && pm.Mount is EtherealMount)) && (pm.AllFollowers.Count > pm.AutoStabled.Count)) || (pm.Mounted && (pm.AllFollowers.Count > (pm.AutoStabled.Count + 1))))
                    {
                        pm.AutoStablePets(); /* autostable checks summons, et al: no need here */
                    }
                    
                for (int i = pm.AllFollowers.Count - 1; i >= 0; --i)
                {
                    BaseCreature pet = pm.AllFollowers[i] as BaseCreature;
                    if (pet.Summoned)
                        {
                            //if (pet.Map != Map)
                            //{
                                pet.PlaySound(pet.GetAngerSound());
                                Timer.DelayCall(TimeSpan.Zero, pet.Delete);
                            //}
                            
                        }
                }
             }
            
        
      }
      
      
      public Pause( ASerial serial ) : base( serial )
        {
        }
        
        [Attachable]
        public Pause()
        {
        }
        
        public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer );
            writer.Write( (int) 0 ); // version
            
            writer.Write(mPaused);
            writer.Write(mCanPause);
        }
        
         public override void Deserialize( GenericReader reader )
        {
            base.Deserialize( reader );
            int version = reader.ReadInt();
            
            mPaused = reader.ReadBool();
            mCanPause = reader.ReadBool();
        
        }
        
   }
}


namespace Server.Gumps
{
    public class Pausegump : Gump
    {
    
        
        
        public Pausegump(Mobile from) : base(200, 200)
        {
            
        
            Closable=false;
            Disposable=false;
            Dragable=false;
            Resizable=false;
            
            AddPage(0);
            
            AddBackground(0, 0, 625, 450, 2600);
            
            AddHtml( 49, 46, 525, 306, @"<BASEFONT SIZE=5><div align=center>Your character has been paused</BASEFONT><br><br><div align=left>Any pets have been stabled and any summons have been dispelled.<br><br>You cannot be seen or harmed while paused. <br><br>When you are ready to continue playing use the command [pause again or press the button below.", (bool)true, (bool)false);
            
            AddButton(55, 373, 247, 248, 1, GumpButtonType.Reply, 0);
            AddLabel(122, 373, 1153, @"I am ready to continue playing");
        }

        
        public override void OnResponse( NetState sender, RelayInfo info )
        {
            Mobile from = sender.Mobile;
            
            Pause pauseatt = (Pause)XmlAttach.FindAttachment(from, typeof(Pause));
            
            switch(info.ButtonID)
            {
                case 0:
                {
                    from.CloseGump( typeof( Pausegump ) );     
                    break;
                }
            
                case 1:
                {
                    
                    from.CloseGump( typeof( Pausegump ) );     
                    
                    if( pauseatt.Paused == true )
                    {
                        pauseatt.Paused = false;
                        from.Hidden = false;
                        from.Paralyzed = false;
                        from.Frozen = false;
                        from.Blessed = false;
                        
                        from.SendMessage( "Pause deactivated." );
                        
                        PlayerMobile pm = (PlayerMobile)from;
                        ((PlayerMobile)pm).ClaimAutoStabledPets();
                    }
                    break;
                    
                    
                }
                
                
            }
        }
    }
}