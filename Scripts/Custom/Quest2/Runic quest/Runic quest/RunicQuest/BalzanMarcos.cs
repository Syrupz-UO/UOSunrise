using System; 
using System.Collections; 
using Server.Misc; 
using Server.Items; 
using Server.Mobiles; 

namespace Server.Mobiles 
{ 
	[CorpseName( "the corpse of balzan marcos" )]
	public class BalzanMarcos : BaseCreature
	{

	private static bool m_Talked;

        string[] kfcsay = new string[]
      { 
		 "You will need to kill me to get the order list",
		 "You shall never get the order list",
		 "You will die",
		 
      }; 
	 
	 
		[Constructable] 
		public BalzanMarcos() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 ) 
		{ 
			SetStr( 205, 245 );
			SetDex( 81, 95 );
			SetInt( 61, 100 );
			SetHits( 630, 800);

			SetDamage( 32, 65 );

			SetDamageType( ResistanceType.Physical, 100 );
 			
			Name = "Balzan Marcos";
			Title = "the evil theif";
			Body = 0x190; 

			SpeechHue = Utility.RandomDyedHue(); 

			Hue = Utility.RandomSkinHue(); 

						
			RingmailChest chest = new RingmailChest(); 
			chest.Hue = 0x966; 
			AddItem( chest ); 
			RingmailArms arms = new RingmailArms(); 
			arms.Hue = 0x966; 
			AddItem( arms ); 
			RingmailGloves gloves = new RingmailGloves(); 
			gloves.Hue = 0x966; 
			AddItem( gloves ); 
			PlateGorget gorget = new PlateGorget(); 
			gorget.Hue = 0x966; 
			AddItem( gorget ); 
			RingmailLegs legs = new RingmailLegs(); 
			legs.Hue = 0x966; 
			AddItem( legs ); 
			
			
			
			PackGold( 420, 690 );
			if (Utility.RandomDouble() < .1 ) // generates random less than 1
        		PackItem( new OrderList() );


			SetDamageType( ResistanceType.Physical, 100 );

			SetSkill( SkillName.Anatomy, 65.3, 83.2 ); 
			SetSkill( SkillName.Tactics, 75.3, 93.2 ); 
			SetSkill( SkillName.MagicResist, 95.3, 100.0 );  
			SetSkill( SkillName.Wrestling, 65.3, 83.2 ); 
			SetSkill( SkillName.Magery, 60.4, 100.0 );
			SetSkill( SkillName.Meditation, 90.1, 100.0 );

			Fame = 2500;
			Karma = -2500;
			

		} 

		public override void OnMovement( Mobile m, Point3D oldLocation ) 
               			{                                                    
         		if( m_Talked == false ) 
         		{ 
            			if ( m.InRange( this, 4 ) ) 
            			{                
               				m_Talked = true; 
               				SayRandom( kfcsay, this ); 
               				this.Move( GetDirectionTo( m.Location ) ); 
                  				// Start timer to prevent spam 
               				SpamTimer t = new SpamTimer(); 
               				t.Start(); 
            			} 
		 			}
	  			}		

		public BalzanMarcos( Serial serial ) : base( serial )
		{
		}

		private class SpamTimer : Timer 
      		{ 
         		public SpamTimer() : base( TimeSpan.FromSeconds( 3 ) ) 
         		{ 
			Priority = TimerPriority.OneSecond;
         		} 

         	protected override void OnTick() 
         	{ 
            		m_Talked = false; 
         	} 
	  	}

	  	private static void SayRandom( string[] say, Mobile m )
	  	{
		 	m.Say( say[Utility.Random( say.Length )] );
	  	}

		public override bool AlwaysMurderer{ get{ return true; } }
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader ) 
		{ 
			base.Deserialize( reader ); 

			int version = reader.ReadInt(); 
		} 
	} 
}