using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;

namespace Server.Mobiles
{
	public class ChucklesJester : BasePerson
	{
		private DateTime m_NextTalk;
		public DateTime NextTalk{ get{ return m_NextTalk; } set{ m_NextTalk = value; } }
		public override void OnMovement( Mobile m, Point3D oldLocation )
		{
			if( m is PlayerMobile )
			{
				if ( DateTime.UtcNow >= m_NextTalk && InRange( m, 4 ) && InLOS( m ) )
				{
					switch ( Utility.Random( 22 ))
					{
						case 0: Say("Why did the king go to the dentist? To get his teeth crowned."); break;
						case 1: Say("When a knight in armor was killed in battle, what sign did they put on his grave? Rust in peace!"); break;
						case 2: Say("What do you call a mosquito in a tin suit? A bite in shining armor."); break;
						case 3: Say("There are many castles in the world, but who is strong enough to move one? Any chess player"); break;
						case 4: Say("What king was famous because he spent so many nights at his Round Table writing books? King Author!"); break;
						case 5: Say("How do you find a princess? You follow the foot prince."); break;
						case 6: Say("Why were the early days called the dark ages? Because there were so many knights!"); break;
						case 7: Say("Why did Arthur have a round table? So no one could corner him!"); break;
						case 8: Say("Who invented King Arthur's round table? Sir Cumference!"); break;
						case 9: Say("Why did the knight run about shouting for a tin opener? He had a bee in his suit of armor!"); break;
						case 10: Say("What was Camelot famous for? It's knight life!"); break;
						case 11: Say("What did the toad say when the princess would not kiss him? Warts the matter with you?"); break;
						case 12: Say("What do you call the young royal who keeps falling down? Prince Harming!"); break;
						case 13: Say("What do you call a cat that flies over the castle wall? A cat-a-pult!"); break;
						case 14: Say("What game do the fish play in the moat? Trout or dare!"); break;
						case 15: Say("What did the fish say to the other when the horse fell in the moat? See horse!"); break;
						case 16: Say("What do you call an angry princess just awakened from a long sleep? Slapping beauty!"); break;
						case 17: Say("How did the prince get into the castle when the drawbridge was broken? He used a rowmoat!"); break;
						case 18: Say("How did the girl dragon win the beauty contest? She was the beast of the show!"); break;
						case 19: Say("Why did the dinosaur live longer than the dragon? Because it didn’t smoke!"); break;
						case 20: Say("What did the dragon say when it saw the Knight? 'Not more tinned food!'"); break;
						case 21: Say("What do you do with a green dragon? Wait until it ripens!"); break;
					};
					m_NextTalk = (DateTime.UtcNow + TimeSpan.FromSeconds( 30 ));
				}
			}
		}

		[Constructable]
		public ChucklesJester() : base( )
		{
			SpeechHue = 1150;
			NameHue = 1154;

			Body = 0x190;

			Name = "Chuckles";
			Title = "the Jester";
			Hue = Utility.RandomSkinHue();

			SetStr( 100 );
			SetDex( 100 );
			SetInt( 100 );

			SetDamage( 15, 20 );
			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 35, 45 );
			SetResistance( ResistanceType.Fire, 25, 30 );
			SetResistance( ResistanceType.Cold, 25, 30 );
			SetResistance( ResistanceType.Poison, 10, 20 );
			SetResistance( ResistanceType.Energy, 10, 20 );

			SetSkill( SkillName.Wrestling, 100 );
			Karma = 1000;
			VirtualArmor = 30;

			AddItem( new ShortPants( Utility.RandomNeutralHue() ) );
			AddItem( new Shoes( Utility.RandomNeutralHue() ) );
			AddItem( new JesterSuit( Utility.RandomNeutralHue() ) );
			AddItem( new JesterHat( Utility.RandomNeutralHue() ) );

			Utility.AssignRandomHair( this );
		}


		public override bool OnDragDrop( Mobile from, Item dropped )
		{
			if ( dropped is JokeBook )
			{
				if ( from.Blessed )
				{
					string sSay = "I cannot deal with you while you are in that state.";
					this.PrivateOverheadMessage(MessageType.Regular, 1153, false, sSay, from.NetState);
					return false;
				}
				else if ( DifficultyLevel.GetMyEnemies( from, this, false ) == true )
				{
					string sSay = "I don't think I should accept that from you.";
					this.PrivateOverheadMessage(MessageType.Regular, 1153, false, sSay, from.NetState);
					return false;
				}
				else
				{
					if ( Utility.RandomBool() )
					{
						GiftJesterHat hat = new GiftJesterHat();
						hat.Name = "Magical Jester Hat";
						hat.Hue = 0;
						hat.m_Owner = from;
						hat.m_Gifter = "Chuckles the Jester";
						hat.m_How = "Given to";
						hat.m_Points = Utility.RandomMinMax( 80, 100 );

						from.AddToBackpack ( hat );
						from.SendMessage( "Chuckles gave you one of his hats!" );
					}
					else
					{
						GiftFancyDress coat = new GiftFancyDress();
						coat.Name = "Magical Jester Suit";
						coat.Hue = 0;
						coat.ItemID = Utility.RandomList( 0x2B6B, 0x3162 );
						coat.m_Owner = from;
						coat.m_Gifter = "Chuckles the Jester";
						coat.m_How = "Given to";
						coat.m_Points = Utility.RandomMinMax( 80, 100 );

						from.AddToBackpack ( coat );
						from.SendMessage( "Chuckles gave you one of his suits!" );
					}
					this.Say( "Thank you, " + from.Name + "! I am always looking for some new jokes." );
					from.SendSound( 0x3D );
					dropped.Delete();
					return true;

					from.SendMessage( "Single click on it to customize it." );
				}
			}

			return base.OnDragDrop( from, dropped );
		}

		public ChucklesJester( Serial serial ) : base( serial )
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
		}
	}
}