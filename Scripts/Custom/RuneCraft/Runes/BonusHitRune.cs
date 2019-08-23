using System;
using System.Collections;
using System.Collections.Generic;
using Server.Multis;
using Server.Mobiles;
using Server.Network;
using Server.ContextMenus;
using Server.Spells;
using Server.Targeting;
using Server.Misc;

namespace Server.Items
{
	public class BonusHitRune : Item
	{
		[Constructable]
		public BonusHitRune() : base( 0x1F14 )
		{
			Weight = 0.2;  // ?
			Name = "Hit Point Inc. Rune";
			Hue = 2101;
		}

		public override void OnDoubleClick( Mobile from ) 
		{
			double minSkill = 70.0;
		 
			PlayerMobile pm = from as PlayerMobile;
		
			if ( !IsChildOf( from.Backpack ) )
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}

			else if ( pm == null || from.Skills[SkillName.Inscribe].Base < 70.0 )
			{
				from.SendMessage( "You are not skilled enough to attempt this enhancement." );
			}

		        else if( from.InRange( this.GetWorldLocation(), 1 ) ) 
		        {
				double maxSkill = minSkill + 40.0;

				if ( !from.CheckSkill( SkillName.Inscribe, minSkill, maxSkill ) )
				{
					from.SendMessage( "The rune shatters, releasing the magic energy." );
					from.PlaySound( 65 );
					from.PlaySound( 0x1F8 );
					Delete();
					return;
				}
				else
				{
					from.SendMessage( "Select the item to enhance." );
					from.Target = new InternalTarget( this );
				}
		        } 

		        else 
		        { 
		        	from.SendLocalizedMessage( 500446 ); // That is too far away. 
		        } 
		} 
		
		private class InternalTarget : Target 
		{
			private BonusHitRune m_BonusHitRune;

			public InternalTarget( BonusHitRune runeaug ) : base( 1, false, TargetFlags.None )
			{
				m_BonusHitRune = runeaug;
			}

		 	protected override void OnTarget( Mobile from, object targeted ) 
		 	{ 
				int DestroyChance = Utility.Random( 4 );
				int augment = Utility.Random( 7 ) + 1;

                    	    if ( targeted is Item  )  // protects from crash if targeting a Mobile. 
			    {
				Item item = (Item) targeted;

				if ( !from.InRange( ((Item)targeted).GetWorldLocation(), 1 ) ) 
				{ 
			         	from.SendLocalizedMessage( 500446 ); // That is too far away. 
		       		}

				else if (( ((Item)targeted).Parent != null ) && ( ((Item)targeted).Parent is Mobile ) ) 
			       	{ 
			          	from.SendMessage( "You cannot enhance that in it's current location." ); 
		       		}

			    	else if ( targeted is BaseWeapon ) 
				{ 
			       		BaseWeapon Weapon = targeted as BaseWeapon; 
		       			{				
						if ( DestroyChance > 0 ) // Success
						{
							Weapon.Attributes.BonusHits += augment; 
							from.SendMessage( "The Rune enhances your weapon." );
				                  	from.PlaySound( 0x1F5 );
			        	          	m_BonusHitRune.Delete();
			          		}

						else // Fail
						{
					  		from.SendMessage( "You have failed to enhance the weapon!" );
							from.SendMessage( "The weapon is damaged beyond repair!" );
							from.PlaySound( 42 );
						  	Weapon.Delete();
							m_BonusHitRune.Delete();
				  		}
					}
				}

			    	else if ( targeted is BaseArmor ) 
				{ 
			       		BaseArmor Armor = targeted as BaseArmor; 
		       			{
						if ( DestroyChance > 0 ) // Success
						{
							Armor.Attributes.BonusHits += augment; 
							from.SendMessage( "The Rune enhances your armor." );
				                  	from.PlaySound( 0x1F5 );
			        	          	m_BonusHitRune.Delete();
			          		}

						else // Fail
						{
					  		from.SendMessage( "You have failed to enhance the armor!" );
							from.SendMessage( "The armor is damaged beyond repair!" );
							from.PlaySound( 42 );
							Armor.Delete();
							m_BonusHitRune.Delete();
				  		}
					}
				}

			    	else if ( targeted is BaseShield ) 
				{ 
			       		BaseShield Shield = targeted as BaseShield; 
		       			{
						if ( DestroyChance > 0 ) // Success
						{
							Shield.Attributes.BonusHits += augment; 
							from.SendMessage( "The Rune enhances your shield." );
				                  	from.PlaySound( 0x1F5 );
			        	          	m_BonusHitRune.Delete();
			          		}

						else // Fail
						{
					  		from.SendMessage( "You have failed to enhance the shield!" );
							from.SendMessage( "The shield is damaged beyond repair!" );
							from.PlaySound( 42 );
						  	Shield.Delete();
							m_BonusHitRune.Delete();
				  		}
					}
				}

			    	else if ( targeted is BaseClothing ) 
				{ 
			       		BaseClothing Clothing = targeted as BaseClothing; 
		       			{
						if ( DestroyChance > 0 ) // Success
						{
							Clothing.Attributes.BonusHits += augment; 
							from.SendMessage( "The Rune enhances your clothing." );
				                  	from.PlaySound( 0x1F5 );
			        	          	m_BonusHitRune.Delete();
			          		}

						else // Fail
						{
					  		from.SendMessage( "You have failed to enhance the clothing!" );
							from.SendMessage( "The clothing is damaged beyond repair!" );
							from.PlaySound( 88 );
						  	Clothing.Delete();
							m_BonusHitRune.Delete();
				  		}
					}
				}

			    	else if ( targeted is BaseJewel ) 
				{ 
			       		BaseJewel Jewel = targeted as BaseJewel; 
		       			{
						if ( DestroyChance > 0 ) // Success
						{
							Jewel.Attributes.BonusHits += augment; 
							from.SendMessage( "The Rune enhances your jewelry." );
				                  	from.PlaySound( 0x1F5 );
			        	          	m_BonusHitRune.Delete();
			          		}

						else // Fail
						{
					  		from.SendMessage( "You have failed to enhance the jewelery!" );
							from.SendMessage( "The jewelery is damaged beyond repair!" );
							from.PlaySound( 62 );
						  	Jewel.Delete();
							m_BonusHitRune.Delete();
				  		}
					}
				}
			}
		    	else 
		    	{ 
		       		from.SendMessage( "You cannot enhance that." );
		    	} 
		  	}
		
		}

		public override bool DisplayLootType{ get{ return false; } }  // ha ha!

		public BonusHitRune( Serial serial ) : base( serial )
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
		//public override void AddNameProperty( ObjectPropertyList list )
		//{
		//	base.AddNameProperty(list);
		//	list.Add( "Hit Point Increase" );
		//}
	}
}