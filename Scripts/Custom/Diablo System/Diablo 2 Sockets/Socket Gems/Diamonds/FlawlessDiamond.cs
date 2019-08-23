using System; 
using Server; 
using Server.Gumps; 
using Server.Network; 
using Server.Misc; 
using Server.Mobiles; 
using Server.Targeting;

namespace Server.Items
{
	public class FlawlessDiamond : Item
	{
		private string m_ModifierList;
	
		[Constructable]
		public FlawlessDiamond() : base( 7847 )
		{
			Stackable = true;
			Weight = 1;
			Name = "a flawless diamond";
			Hue = 2101;
		}
		
		public override void OnDoubleClick( Mobile from ) 
		{
		 
		 PlayerMobile pm = from as PlayerMobile;
		
			if ( !IsChildOf( from.Backpack ) )
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
			else if ( pm == null || from.Skills[SkillName.Tinkering].Base < 120.0 )
			{
				from.SendMessage( 38,"Only a Legendary Tinker can enhance socketed items." );
			}
		    else if( from.InRange( this.GetWorldLocation(), 1 ) )
		    { 
				from.SendMessage( 55,"Make sure you unstack gems so you only use one gem at a time." );
				from.SendMessage( 55,"Select the item to enhance." ); 
				from.Target = new InternalTarget( this ); 
		    } 
		    else 
		    { 
				from.SendLocalizedMessage( 500446 ); // That is too far away. 
		    } 
		} 
		
		private class InternalTarget : Target 
		{ 
			private FlawlessDiamond m_Augmentation; 
		
			public InternalTarget( FlawlessDiamond augmentation ) : base( 1, false, TargetFlags.None ) 
			{ 
				m_Augmentation = augmentation; 
			} 
		
			protected override void OnTarget( Mobile from, object targeted ) 
			{ 
				if ( targeted is BaseWeapon ) 
				{ 
					BaseWeapon Weapon = targeted as BaseWeapon; 
					
					if ( !from.InRange( m_Augmentation.GetWorldLocation(), 1 ) || !from.InRange( ((Item)targeted).GetWorldLocation(), 1 ) ) 
					{ 
						from.SendLocalizedMessage( 500446 ); // That is too far away. 
					} 
					else if (( ((Item)targeted).Parent != null ) && ( ((Item)targeted).Parent is Mobile ) ) 
					{ 
						from.SendMessage( 38,"You cannot enhance that in it's current location." ); 
					} 
					else if ( Weapon.Type == WeaponType.Ranged )
					{
						if ( from.Skills[SkillName.Fletching].Base < 120.0 )
						{
							from.SendMessage( 38,"Only a Legendary Fletcher can enhance ranged weapons." );
						}
						else if ( Weapon.UsedSockets >= Weapon.MaxSockets )
						{
							from.SendMessage( 38,"That weapon is already enhanced to its limits!" );
						}
						else
						{
							int EnhanceChance = Utility.Random( 20 );
								if ( EnhanceChance == 19 )
								{
									EnhanceChance = 1;
								}											
								else
								{
									EnhanceChance = 0;
								}
							int DestroyChance = Utility.Random( 100 );
								if ( DestroyChance == 99 )
								{
									DestroyChance = 1;
								}											
								else
								{
									DestroyChance = 0;
								}
		               	  
							if ( EnhanceChance == 0 ) // Success
							{
								Weapon.UsedSockets += 1;
								Weapon.WeaponAttributes.HitPhysicalArea += 25;
								Weapon.Hue = 2101;			                  
								Weapon.AugmentList = Weapon.AugmentList + "\n" + m_Augmentation.Name;
								from.PlaySound( 0x2A ); // Anvil
								from.SendMessage( 55,"You have successfully enhanced the weapon!" );
			                  m_Augmentation.Delete();
							}
							else // Fail
							{
								if ( DestroyChance == 0 ) // Weapon not destroyed
								{
									from.SendMessage( 38,"You have failed to enhance the weapon!" );
									from.SendMessage( 38,"The augmentation crumbles in your hand," );
									from.SendMessage( 38,"you have damaged the weapon in the process!" );
									Weapon.MaxHitPoints -= 3;
									Weapon.HitPoints -= 3;
								}
								else // Weapon is destroyed
								{
									from.SendMessage( 38,"You have failed to enhance the weapon!" );
									from.SendMessage( 38,"You have damaged the weapon in the process," );
									from.SendMessage( 38,"the weapon is damaged beyond repair and crumbles in your hand!" );
									Weapon.Delete();
								}
				  	
								m_Augmentation.Delete();
							}
						}
					}
					else if ( Weapon.Type == WeaponType.Polearm || Weapon.Type == WeaponType.Piercing || Weapon.Type == WeaponType.Staff || Weapon.Type == WeaponType.Slashing || Weapon.Type == WeaponType.Bashing || Weapon.Type == WeaponType.Axe ) 
					{
						if ( from.Skills[SkillName.Blacksmith].Base < 120.0 )
						{
							from.SendMessage( 38,"Only a Legendary Blacksmith can enhance items." );
						}
						else if ( Weapon.UsedSockets >= Weapon.MaxSockets )
						{
							from.SendMessage( 38,"That weapon is already enhanced to its limits!" );
						}
						else
						{
							int EnhanceChance = Utility.Random( 20 );
								if ( EnhanceChance == 19 )
								{
									EnhanceChance = 1;
								}											
								else
								{
									EnhanceChance = 0;
								}
							int DestroyChance = Utility.Random( 100 );
								if ( DestroyChance == 99 )
								{
									DestroyChance = 1;
								}											
								else
								{
									DestroyChance = 0;
								}
		               	  
							if ( EnhanceChance == 0 ) // Success
							{
								Weapon.UsedSockets += 1;
								Weapon.WeaponAttributes.HitPhysicalArea += 25;
								Weapon.Hue = 2101;			                  
								Weapon.AugmentList = Weapon.AugmentList + "\n" + m_Augmentation.Name;
								from.PlaySound( 0x2A ); // Anvil
								from.SendMessage( 55,"You have successfully enhanced the weapon!" );
								m_Augmentation.Delete();
							}
							else // Fail
							{
								if ( DestroyChance == 0 ) // Weapon not destroyed
								{
									from.SendMessage( 38,"You have failed to enhance the weapon!" );
									from.SendMessage( 38,"The augmentation crumbles in your hand," );
									from.SendMessage( 38,"you have damaged the weapon in the process!" );
									Weapon.MaxHitPoints -= 3;
									Weapon.HitPoints -= 3;
								}
								else // Weapon is destroyed
								{
									from.SendMessage( 38,"You have failed to enhance the weapon!" );
									from.SendMessage( 38,"You have damaged the weapon in the process," );
									from.SendMessage( 38,"the weapon is damaged beyond repair and crumbles in your hand!" );
									Weapon.Delete();
								}
				  	
								m_Augmentation.Delete();
							}
						}
					}
				}

				if ( targeted is BaseArmor ) 
				{
					BaseArmor Armor = targeted as BaseArmor; 
					if ( !from.InRange( m_Augmentation.GetWorldLocation(), 1 ) || !from.InRange( ((Item)targeted).GetWorldLocation(), 1 ) ) 
					{ 
						from.SendLocalizedMessage( 500446 ); // That is too far away. 
					} 
					else if (( ((Item)targeted).Parent != null ) && ( ((Item)targeted).Parent is Mobile ) ) 
					{ 
						from.SendMessage( 38,"You cannot enhance that in it's current location." ); 
					} 
					else if ( Armor.BodyPosition == ArmorBodyType.Gorget || Armor.BodyPosition == ArmorBodyType.Gloves 
					|| Armor.BodyPosition == ArmorBodyType.Helmet || Armor.BodyPosition == ArmorBodyType.Arms || Armor.BodyPosition == ArmorBodyType.Legs 
					|| Armor.BodyPosition == ArmorBodyType.Chest ) 
					{
						if ( Armor.MaterialType == ArmorMaterialType.Plate || Armor.MaterialType == ArmorMaterialType.Chainmail || Armor.MaterialType == ArmorMaterialType.Ringmail ) 
						{  
							if ( from.Skills[SkillName.Blacksmith].Base < 120.0 )
							{
								from.SendMessage( 38,"Only a Legendary Blacksmith can enhance this type of armor." );
							}					
							else if ( Armor.UsedSockets >= Armor.MaxSockets )
							{
							from.SendMessage( 38,"That armor is already enhanced to its limits!" );
							}	
							else
							{
								int EnhanceChance = Utility.Random( 20 );
									if ( EnhanceChance == 19 )
									{
										EnhanceChance = 1;
									}											
									else
									{
										EnhanceChance = 0;
									}
								int DestroyChance = Utility.Random( 100 );
									if ( DestroyChance == 99 )
									{
										DestroyChance = 1;
									}											
									else
									{
										DestroyChance = 0;
									}
							  
								if ( EnhanceChance == 0 ) // Success
								{
									Armor.UsedSockets += 1;
									Armor.Attributes.AttackChance += 5;
									Armor.Hue = 2101;			                  
									Armor.AugmentList = Armor.AugmentList + "\n" + m_Augmentation.Name;
									from.PlaySound( 0x2A ); // Anvil
									from.SendMessage( 55,"You have successfully enhanced the armor!" );
									m_Augmentation.Delete();
								}
								else // Fail
								{
									if ( DestroyChance == 0 ) // Armor not destroyed
									{
										from.SendMessage( 38,"You have failed to enhance the armor!" );
										from.SendMessage( 38,"The augmentation crumbles in your hand," );
										from.SendMessage( 38,"you have damaged the armor in the process!" );
										Armor.MaxHitPoints -= 3;
										Armor.HitPoints -= 3;
									}	
									else // Armor is destroyed
									{
										from.SendMessage( 38,"You have failed to enhance the armor!" );
										from.SendMessage( 38,"You have damaged the armor in the process," );
										from.SendMessage( 38,"the armor is damaged beyond repair and crumbles in your hand!" );
										Armor.Delete();
									}
									
									m_Augmentation.Delete();
								}
							}
						}
						else
						{
							if ( from.Skills[SkillName.Tailoring].Base < 120.0 )
							{
								from.SendMessage( 38,"Only a Legendary Tailor can enhance this type of Armor." );
							}
							else if ( Armor.UsedSockets >= Armor.MaxSockets )
							{
							from.SendMessage( 38,"That armor is already enhanced to its limits!" );
							}
							else
							{
								int EnhanceChance = Utility.Random( 20 );
									if ( EnhanceChance == 19 )
									{
										EnhanceChance = 1;
									}											
									else
									{
										EnhanceChance = 0;
									}
								int DestroyChance = Utility.Random( 100 );
									if ( DestroyChance == 99 )
									{
										DestroyChance = 1;
									}											
									else
									{
										DestroyChance = 0;
									}
							  
								if ( EnhanceChance == 0 ) // Success
								{
									Armor.UsedSockets += 1;
									Armor.Attributes.AttackChance += 5;
									Armor.Hue = 2101;			                  
									Armor.AugmentList = Armor.AugmentList + "\n" + m_Augmentation.Name;
									from.PlaySound( 0x2A ); // Anvil
									from.SendMessage( 55,"You have successfully enhanced the armor!" );
									m_Augmentation.Delete();
								}
								else // Fail
								{
									if ( DestroyChance == 0 ) // Armor not destroyed
									{
										from.SendMessage( 38,"You have failed to enhance the armor!" );
										from.SendMessage( 38,"The augmentation crumbles in your hand," );
										from.SendMessage( 38,"you have damaged the armor in the process!" );
										Armor.MaxHitPoints -= 3;
										Armor.HitPoints -= 3;
									}	
									else // Armor is destroyed
									{
										from.SendMessage( 38,"You have failed to enhance the armor!" );
										from.SendMessage( 38,"You have damaged the armor in the process," );
										from.SendMessage( 38,"the armor is damaged beyond repair and crumbles in your hand!" );
										Armor.Delete();
									}
									
									m_Augmentation.Delete();
								}
							}
						}
					}	
				}

				if ( targeted is BaseShield ) 
				{
					BaseShield Shield = targeted as BaseShield; 
					if ( !from.InRange( m_Augmentation.GetWorldLocation(), 1 ) || !from.InRange( ((Item)targeted).GetWorldLocation(), 1 ) ) 
					{ 
						from.SendLocalizedMessage( 500446 ); // That is too far away. 
					} 
					else if (( ((Item)targeted).Parent != null ) && ( ((Item)targeted).Parent is Mobile ) ) 
					{ 
						from.SendMessage( 38,"You cannot enhance that in it's current location." ); 
					} 
					else if ( Shield.MaterialType == ArmorMaterialType.Plate ) 
					{
						if ( from.Skills[SkillName.Blacksmith].Base < 120.0 )
						{
							from.SendMessage( 38,"Only a Legendary Blacksmith can enhance items." );
						}
						else if ( Shield.UsedSockets >= Shield.MaxSockets )
						{
						from.SendMessage( 38,"That shield is already enhanced to its limits!" );
						}
						else
						{
							int EnhanceChance = Utility.Random( 20 );
								if ( EnhanceChance == 19 )
								{
									EnhanceChance = 1;
								}											
								else
								{
									EnhanceChance = 0;
								}
							int DestroyChance = Utility.Random( 100 );
								if ( DestroyChance == 99 )
								{
									DestroyChance = 1;
								}											
								else
								{
									DestroyChance = 0;
								}
		               	  
							if ( EnhanceChance == 0 ) // Success
							{
			                  Shield.UsedSockets += 1;
			                  Shield.EnergyBonus += 4;
			                  Shield.FireBonus += 4;
			                  Shield.PoisonBonus += 4;
			                  Shield.PhysicalBonus += 4;
			                  Shield.ColdBonus += 4;
                              Shield.Hue = 2101;			                  
			                  Shield.AugmentList = Shield.AugmentList + "\n" + m_Augmentation.Name;
			                  from.PlaySound( 0x2A ); // Anvil
			                  from.SendMessage( 55,"You have successfully enhanced the shield!" );
			                  m_Augmentation.Delete();
							}
							else // Fail
							{
								if ( DestroyChance == 0 ) // Shield not destroyed
								{
									from.SendMessage( 38,"You have failed to enhance the shield!" );
									from.SendMessage( 38,"The augmentation crumbles in your hand," );
									from.SendMessage( 38,"you have damaged the shield!" );
									Shield.MaxHitPoints -= 3;
									Shield.HitPoints -= 3;
								}
								else // Shield is destroyed
								{
									from.SendMessage( 38,"You have failed to enhance the shield!" );
									from.SendMessage( 38,"You have cracked the shield in the process," );
									from.SendMessage( 38,"the shield is damaged beyond repair and crumbles in your hand!" );
									Shield.Delete();
								}		
				  	
								m_Augmentation.Delete();
							}
						}
					}
				}
			}  
		}		

		public FlawlessDiamond( Serial serial ) : base( serial )
		{
		}

		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties(list);
			list.Add( 1050045," \tW +25% PhysArea - A +5% Hit - S +4% AllRes\t " );
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