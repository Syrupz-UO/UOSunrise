using Server.Targeting; 
using System; 
using Server; 
using Server.Gumps; 
using Server.Network; 
using Server.Menus; 
using Server.Menus.Questions; 
using Server.Mobiles; 
using System.Collections; 
using Server.Engines.CannedEvil;

namespace Server.Items 
{ 
   	public class ChampionActivator : Item 
   	{ 
    		private int m_Charges = 1;

		[CommandProperty( AccessLevel.GameMaster )]
		public int Charges
		{
			get{ return m_Charges; }
			set{ m_Charges = value; InvalidateProperties(); }
		}

      		[Constructable] 
      		public ChampionActivator() : base( 0x315C ) 
      		{ 
         		Weight = 1.0;  
         		Movable = true; 
         		Name="Champion Challenge Horn";
				Hue = 33;		
          	} 

		public override void AddNameProperties( ObjectPropertyList list )
		{
			base.AddNameProperties( list );

			list.Add( 1060658, "Charges\t{0}", m_Charges.ToString() );
		}

      		public ChampionActivator( Serial serial ) : base( serial ) 
      		{ 
      		} 
      		public override void OnDoubleClick( Mobile from ) 
     	 	{ 

			if ( !IsChildOf( from.Backpack ) )
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
			
			else 
			{
           			from.Target = new LeashTarget( this );
				from.SendMessage( "Target the idol of the champion you wish to challenge..." );
			}
      		} 

      		public override void Serialize( GenericWriter writer ) 
      		{ 
         		base.Serialize( writer ); 

         		writer.Write( (int) 0 );

			writer.Write( m_Charges ); 
      		} 

      		public override void Deserialize( GenericReader reader ) 
      		{ 
         		base.Deserialize( reader ); 

         		int version = reader.ReadInt(); 

			m_Charges = reader.ReadInt();
      		} 


  		private class LeashTarget : Target 
      		{ 
         		private Mobile m_Owner; 
      
         		private ChampionActivator m_Powder; 

         		public LeashTarget( ChampionActivator charge ) : base ( 10, false, TargetFlags.None ) 
         		{ 
            			m_Powder=charge; 
         		} 
          
         		protected override void OnTarget( Mobile from, object target ) 
         		{ 
            			if ( target == from ) 
               				from.SendMessage( "You don't look like a champion to me!" );

				else if ( target is PlayerMobile )
					from.SendMessage( "That person gives you a dirty look." );

				

          			else if ( target is IdolOfTheChampion ) 
          			{ 
						IdolOfTheChampion idol = target as IdolOfTheChampion;
						if( idol == null || idol.Deleted || idol.Spawn == null || idol.Spawn.Deleted )
						from.SendLocalizedMessage( 1054035 ); // You must target a Champion Idol to challenge the Champion's spawn!
						
						else if (idol.Spawn.Active == false)
							{
							from.SendMessage("You challenge this Champion Spawn!");
							idol.Spawn.Active = true;
							m_Powder.Charges -= 1;
							if ( m_Powder.Charges == 0 )
							m_Powder.Delete();
							}
					}

						
					}
  
            			}
         		} 
      		} 
 
