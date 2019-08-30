/*  _________________________________
 -=(_)_______________________________)=-
   /   .   .   . ____  . ___      _/
  /~ /    /   / /     / /   )2005 /
 (~ (____(___/ (____ / /___/     (
  \ ----------------------------- \
   \     lucidnagual@gmail.com     \
    \_     ===================      \
     \   -Admin of "The Conjuring"-  \
      \_     ===================     ~\
       )      Advanced Archery         )
      /~      Version [2].0.1        _/
    _/_______________________________/
 -=(_)_______________________________)=-
 */
using System;
using Server.Items;
using Server.Network;
using Server.Spells;
using Server.Mobiles;
using Server.Targeting;


namespace Server.Items
{
	/*public enum ArrowType
	{
		Normal,
		Poison,
		Explosive,
		ArmorPiercing,
		Freeze,
		Lightning
	}
	
	public enum BoltType
	{
		Normal,
		Poison,
		Explosive,
		ArmorPiercing,
		Freeze,
		Lightning
	}*/
	
	public abstract class CBaseRanged : BaseMeleeWeapon
	{
		public static readonly TimeSpan PlayerFreezeDuration = TimeSpan.FromSeconds(3.0);
		public static readonly TimeSpan NPCFreezeDuration = TimeSpan.FromSeconds(6.0);
		
		public abstract int EffectID { get; }
		public abstract Type AmmoType { get; }
		public abstract Item Ammo { get; }
		public override int DefHitSound { get { return 0x234; } }
		public override int DefMissSound { get { return 0x238; } }
		public override SkillName DefSkill { get { return SkillName.Archery; } }
		public override WeaponType DefType { get { return WeaponType.Ranged; } }
		public override WeaponAnimation DefAnimation { get { return WeaponAnimation.ShootXBow; } }
		public override SkillName AccuracySkill { get { return SkillName.Archery; } }
		
		public ArrowType m_ArrowType;
		public BoltType m_BoltType;
		internal object obj;
		
		[CommandProperty(AccessLevel.GameMaster)]
		public ArrowType ArrowSelection	{ get { return m_ArrowType; } set { m_ArrowType = value;
				InvalidateProperties(); } }
		
		[CommandProperty(AccessLevel.GameMaster)]
		public BoltType BoltSelection { get { return m_BoltType; } set { m_BoltType = value;
				InvalidateProperties(); } }
		
		public CBaseRanged( int itemID ) : base( itemID )
		{
		}
		
		public CBaseRanged(Serial serial) : base( serial )
		{
		}
		
		//public override void OnDoubleClick( Mobile from )
		//{
		//	base.OnDoubleClick( from );
		//}
		
		public override TimeSpan OnSwing(Mobile attacker, Mobile defender)
		{
			// Make sure we've been standing still for one second
			if (Core.TickCount > attacker.LastMoveTime + (Core.AOS ? 500 : 1000) || (Core.AOS && WeaponAbility.GetCurrentAbility(attacker) is MovingShot))
			{
				bool canSwing = true;
				
				if (Core.AOS)
				{
					canSwing = (!attacker.Paralyzed && !attacker.Frozen);
					
					if (canSwing)
					{
						Spell sp = attacker.Spell as Spell;
						
						canSwing = (sp == null || !sp.IsCasting || !sp.BlocksMovement);
					}
				}
				
				if (canSwing && attacker.HarmfulCheck(defender))
				{
					attacker.DisruptiveAction();
					attacker.Send(new Swing(0, attacker, defender));
					
					if ( OnFired( attacker, defender ))
					{
						if ( CheckHit( attacker, defender ))
							OnHit( attacker, defender );
						
						else
							OnMiss( attacker, defender );
					}
				}
				
				return GetDelay(attacker);
			}
			else
			{
				return TimeSpan.FromSeconds(0.25);
			}
		}
		
		public override void OnHit(Mobile attacker, Mobile defender)
		{
			if ( attacker == null || defender == null )
				return;
			
			if (AmmoType == typeof( PoisonArrow ) )
			{
				switch (Utility.Random(4))
				{
						case 0: defender.ApplyPoison(defender, Poison.Deadly);
						defender.FixedParticles(0x3728, 200, 25, 69, EffectLayer.Waist); break;
						case 1: defender.ApplyPoison(defender, Poison.Greater);
						defender.FixedParticles(0x3728, 200, 25, 69, EffectLayer.Waist); break;
						case 2: defender.ApplyPoison(defender, Poison.Regular);
						defender.FixedParticles(0x3728, 200, 25, 69, EffectLayer.Waist); break;
						case 3: defender.ApplyPoison(defender, Poison.Lesser);
						defender.FixedParticles(0x3728, 200, 25, 69, EffectLayer.Waist); break;
				}
			}
			else if (AmmoType == typeof( PoisonBolt ) )
			{
				switch (Utility.Random(4))
				{
						case 0: defender.ApplyPoison(defender, Poison.Deadly);
						defender.FixedParticles(0x3728, 200, 25, 69, EffectLayer.Waist); break;
						case 1: defender.ApplyPoison(defender, Poison.Greater);
						defender.FixedParticles(0x3728, 200, 25, 69, EffectLayer.Waist); break;
						case 2: defender.ApplyPoison(defender, Poison.Regular);
						defender.FixedParticles(0x3728, 200, 25, 69, EffectLayer.Waist); break;
						case 3: defender.ApplyPoison(defender, Poison.Lesser);
						defender.FixedParticles(0x3728, 200, 25, 69, EffectLayer.Waist); break;
				}
			}
			else if (AmmoType == typeof( ExplosiveArrow ) )
			{
				switch (Utility.Random(3))
				{
						case 0: defender.FixedParticles(0x36BD, 20, 10, 5044, EffectLayer.Waist);
						defender.PlaySound(0x307);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(10, 50), 0, 100, 0, 0, 0); break;
						
						case 1: defender.FixedParticles(0x36BD, 20, 10, 5044, EffectLayer.Waist);
						defender.PlaySound(0x307);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(30, 70), 0, 100, 0, 0, 0); break;
						
						case 2: defender.FixedParticles(0x36BD, 20, 10, 5044, EffectLayer.Waist);
						defender.PlaySound(0x307);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(50, 100), 0, 100, 0, 0, 0); break;
				}
				
			}
			else if (AmmoType == typeof( ExplosiveBolt ) )
			{
				switch (Utility.Random(3))
				{
						case 0: defender.FixedParticles(0x36BD, 20, 10, 5044, EffectLayer.Waist);
						defender.PlaySound(0x307);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(10, 50), 0, 100, 0, 0, 0); break;
						
						case 1: defender.FixedParticles(0x36BD, 20, 10, 5044, EffectLayer.Waist);
						defender.PlaySound(0x307);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(30, 70), 0, 100, 0, 0, 0); break;
						
						case 2: defender.FixedParticles(0x36BD, 20, 10, 5044, EffectLayer.Waist);
						defender.PlaySound(0x307);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(50, 100), 0, 100, 0, 0, 0); break;
				}
				
			}
			else if (AmmoType == typeof( ArmorPiercingArrow ) )
			{
				switch (Utility.Random(3))
				{
						case 0: defender.PlaySound(0x56);
						defender.FixedParticles(0x3728, 200, 25, 9942, EffectLayer.Waist);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(10, 50), 100, 0, 0, 0, 0); break;
						
						case 1: defender.PlaySound(0x56);
						defender.FixedParticles(0x3728, 200, 25, 9942, EffectLayer.Waist);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(30, 70), 100, 0, 0, 0, 0); break;
						
						case 2: defender.PlaySound(0x56);
						defender.FixedParticles(0x3728, 200, 25, 9942, EffectLayer.Waist);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(50, 100), 100, 0, 0, 0, 0); break;
				}
			}
			else if (AmmoType == typeof( ArmorPiercingBolt ) )
			{
				switch (Utility.Random(3))
				{
						case 0: defender.PlaySound(0x56);
						defender.FixedParticles(0x3728, 200, 25, 9942, EffectLayer.Waist);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(10, 50), 100, 0, 0, 0, 0); break;
						
						case 1: defender.PlaySound(0x56);
						defender.FixedParticles(0x3728, 200, 25, 9942, EffectLayer.Waist);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(30, 70), 100, 0, 0, 0, 0); break;
						
						case 2: defender.PlaySound(0x56);
						defender.FixedParticles(0x3728, 200, 25, 9942, EffectLayer.Waist);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(50, 100), 100, 0, 0, 0, 0); break;
				}
			}
			else if (AmmoType == typeof( FreezeArrow ) )
			{
				switch (Utility.Random(3))
				{
						case 0: defender.PlaySound(0x204);
						defender.Freeze(defender.Player ? PlayerFreezeDuration : NPCFreezeDuration);
						defender.FixedEffect(0x376A, 9, 32);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(10, 50), 0, 0, 100, 0, 0); break;
						
						case 1: defender.PlaySound(0x204);
						defender.Freeze(defender.Player ? PlayerFreezeDuration : NPCFreezeDuration);
						defender.FixedEffect(0x376A, 9, 32);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(30, 70), 0, 0, 100, 0, 0); break;
						
						case 2: defender.PlaySound(0x204);
						defender.Freeze(defender.Player ? PlayerFreezeDuration : NPCFreezeDuration);
						defender.FixedEffect(0x376A, 9, 32);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(50, 100), 0, 0, 100, 0, 0); break;
				}
			}
			else if (AmmoType == typeof( FreezeBolt ) )
			{
				switch (Utility.Random(3))
				{
						case 0: defender.PlaySound(0x204);
						defender.Freeze(defender.Player ? PlayerFreezeDuration : NPCFreezeDuration);
						defender.FixedEffect(0x376A, 9, 32);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(10, 50), 0, 0, 100, 0, 0); break;
						
						case 1: defender.PlaySound(0x204);
						defender.Freeze(defender.Player ? PlayerFreezeDuration : NPCFreezeDuration);
						defender.FixedEffect(0x376A, 9, 32);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(30, 70), 0, 0, 100, 0, 0); break;
						
						case 2: defender.PlaySound(0x204);
						defender.Freeze(defender.Player ? PlayerFreezeDuration : NPCFreezeDuration);
						defender.FixedEffect(0x376A, 9, 32);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(50, 100), 0, 0, 100, 0, 0); break;
				}
			}
			else if (AmmoType == typeof( ALightningArrow ) )
			{
				switch (Utility.Random(3))
				{
						case 0: defender.PlaySound(1471);
						defender.BoltEffect(0);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(10, 50), 100, 0, 0, 0, 0); break;
						
						case 1: defender.PlaySound(1471);
						defender.BoltEffect(0);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(30, 70), 100, 0, 0, 0, 0); break;
						
						case 2: defender.PlaySound(1471);
						defender.BoltEffect(0);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(50, 100), 100, 0, 0, 0, 0); break;
				}
			}
			else if (AmmoType == typeof( LightningBolt2 ) )
			{
				switch (Utility.Random(3))
				{
						case 0: defender.PlaySound(1471);
						defender.BoltEffect(0);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(10, 50), 100, 0, 0, 0, 0); break;
						
						case 1: defender.PlaySound(1471);
						defender.BoltEffect(0);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(30, 70), 100, 0, 0, 0, 0); break;
						
						case 2: defender.PlaySound(1471);
						defender.BoltEffect(0);
						attacker.DoHarmful(defender);
						AOS.Damage(defender, attacker, Utility.RandomMinMax(50, 100), 100, 0, 0, 0, 0); break;
				}
			}
			
			else if ( Ammo == null )
				attacker.SendMessage( "You are out of arrows, or may have to choose a different type of arrow by double clicking the bow." );
			
			if (attacker.Player && !defender.Player && (defender.Body.IsAnimal || defender.Body.IsMonster) && 0.4 >= Utility.RandomDouble())
				defender.AddToBackpack(Ammo);
			
			base.OnHit(attacker, defender);
		}
		
		public override void OnMiss(Mobile attacker, Mobile defender)
		{
			if ( attacker == null || defender == null )
				return;
			
			if (attacker.Player && 0.4 >= Utility.RandomDouble())
				Ammo.MoveToWorld(new Point3D(defender.X + Utility.RandomMinMax(-1, 1), defender.Y + Utility.RandomMinMax(-1, 1), defender.Z), defender.Map);
			
			base.OnMiss(attacker, defender);
		}
		
		
		public virtual bool OnFired( Mobile attacker, Mobile defender ) // TODO: Maybe check only primary container? Then it could done with less code.
		{
			
			Container cont = attacker.FindItemOnLayer( Layer.Cloak ) as BaseQuiver;
				Container pack = attacker.Backpack;
			if ( cont != null )
			{
				if ( ((BaseQuiver)cont).LowerAmmoCost > Utility.Random( 100 ) ) //Crashes if not BaseQuiver Container
				{
					attacker.MovingEffect( defender, EffectID, 18, 1, false, false );
					return true;
				}
				else if ( cont.ConsumeTotal( AmmoType, 1 ) )
				{
					attacker.MovingEffect( defender, EffectID, 18, 1, false, false );
					return true;
				}
			}
			cont = attacker.Backpack;
			if ( cont != null && cont.ConsumeTotal( AmmoType, 1 ) )
			{
				attacker.MovingEffect( defender, EffectID, 18, 1, false, false );
				return true;
			}

			return false;
		}
		
		public virtual Item AmmoArrowSelected()
		{
			switch ( m_ArrowType )
			{
				case ArrowType.Normal:
					return new Arrow();
				case ArrowType.Poison:
					return new PoisonArrow();
				case ArrowType.Explosive:
					return new ExplosiveArrow();
				case ArrowType.ArmorPiercing:
					return new ArmorPiercingArrow();
				case ArrowType.Freeze:
					return new FreezeArrow();
				case ArrowType.Lightning:
					return new ALightningArrow();
					
				default:
					return new Arrow();
			}
		}
		
		public virtual Type GetArrowSelected()
		{
			switch ( m_ArrowType )
			{
				case ArrowType.Normal:
					return typeof(Arrow);
				case ArrowType.Poison:
					return typeof(PoisonArrow);
				case ArrowType.Explosive:
					return typeof(ExplosiveArrow);
				case ArrowType.ArmorPiercing:
					return typeof(ArmorPiercingArrow);
				case ArrowType.Freeze:
					return typeof(FreezeArrow);
				case ArrowType.Lightning:
					return typeof(ALightningArrow);
					
				default:
					return typeof(Arrow);
			}
		}
		
		public virtual Item AmmoBoltSelected()
		{
			switch ( m_BoltType )
			{
				case BoltType.Normal:
					return new Bolt();
				case BoltType.Poison:
					return new PoisonBolt();
				case BoltType.Explosive:
					return new ExplosiveBolt();
				case BoltType.ArmorPiercing:
					return new ArmorPiercingBolt();
				case BoltType.Freeze:
					return new FreezeBolt();
				case BoltType.Lightning:
					return new LightningBolt2();
					
				default:
					return new Bolt();
			}
		}
		
		public virtual Type GetBoltSelected()
		{
			switch ( m_BoltType )
			{
				case BoltType.Normal:
					return typeof(Bolt);
				case BoltType.Poison:
					return typeof(PoisonBolt);
				case BoltType.Explosive:
					return typeof(ExplosiveBolt);
				case BoltType.ArmorPiercing:
					return typeof(ArmorPiercingBolt);
				case BoltType.Freeze:
					return typeof(FreezeBolt);
				case BoltType.Lightning:
					return typeof(LightningBolt2);
					
				default:
					return typeof(Bolt);
			}
		}
		
		public override void OnDoubleClick( Mobile from )
		{
			if ( from == null )
				return;
			
			if ( IsChildOf( from.Backpack ) || Parent == from )
			{
				if ( from != null && this is Bow || this is CompositeBow || this is ElvenCompositeLongbow ||
				    this is MagicalShortbow || this is Yumi )
				{
					from.SendMessage( "Please choose which type of arrows you wish to use." );
					from.Target = new BowInternalTarget( this );
				}
				
				if ( from != null && this is Crossbow || this is HeavyCrossbow || this is RepeatingCrossbow )
				{
					from.SendMessage( "Please choose which type of bolts you wish to use." );
					from.Target = new CrossbowInternalTarget( this );
				}
			}
			
			else
				return;
		}
		
		private class BowInternalTarget : Target
		{
			private CBaseRanged it_Ranged;
			
			public BowInternalTarget( CBaseRanged ranged ) : base(1, false, TargetFlags.None)
			{
				it_Ranged = ranged;
			}
			
			protected override void OnTarget(Mobile from, object targeted)
			{
				if ( targeted is Item && targeted is Arrow )
				{
					Item item = (Item)targeted;
					
					if (item.GetType() == typeof(Arrow))
						it_Ranged.ArrowSelection = ArrowType.Normal;
					else if (item.GetType() == typeof(PoisonArrow) )
						it_Ranged.ArrowSelection = ArrowType.Poison;
					else if (item.GetType() == typeof(ExplosiveArrow) )
						it_Ranged.ArrowSelection = ArrowType.Explosive;
					else if (item.GetType() == typeof(ArmorPiercingArrow) )
						it_Ranged.ArrowSelection = ArrowType.ArmorPiercing;
					else if (item.GetType() == typeof(FreezeArrow) )
						it_Ranged.ArrowSelection = ArrowType.Freeze;
					else if (item.GetType() == typeof(ALightningArrow) )
						it_Ranged.ArrowSelection = ArrowType.Lightning;
					
					else
						from.SendMessage( "Must select an Arrow Type." );
				}
				else
					from.SendMessage( " Can Only Target Arrow Items!" );
			}
		}
		
		private class CrossbowInternalTarget : Target
		{
			private CBaseRanged it_Ranged;
			
			public CrossbowInternalTarget( CBaseRanged ranged ) : base(1, false, TargetFlags.None)
			{
				it_Ranged = ranged;
			}
			
			protected override void OnTarget(Mobile from, object targeted)
			{
				if ( targeted is Item && targeted is Bolt )
				{
					Item item = (Item)targeted;
					
					if (item.GetType() == typeof(Bolt))
						it_Ranged.BoltSelection = BoltType.Normal;
					else if (item.GetType() == typeof(PoisonBolt) )
						it_Ranged.BoltSelection = BoltType.Poison;
					else if (item.GetType() == typeof(ExplosiveBolt) )
						it_Ranged.BoltSelection = BoltType.Explosive;
					else if (item.GetType() == typeof(ArmorPiercingBolt) )
						it_Ranged.BoltSelection = BoltType.ArmorPiercing;
					else if (item.GetType() == typeof(FreezeBolt) )
						it_Ranged.BoltSelection = BoltType.Freeze;
					else if (item.GetType() == typeof(LightningBolt2) )
						it_Ranged.BoltSelection = BoltType.Lightning;
					else
						from.SendMessage( "Must select an Bolt Type." );
					
				}
				else
					from.SendMessage( " Can Only Target Bolt Items!" );
			}
		}
		
		public override void GetProperties( ObjectPropertyList list )
		{
			if ( this is Bow || this is CompositeBow || this is ElvenCompositeLongbow ||
			    this is MagicalShortbow || this is Yumi )
			{
				base.GetProperties(list);
				list.Add(1060662, "{0}\t{1}", "Quiver using", m_ArrowType.ToString());
			}
			
			if ( this is Crossbow || this is HeavyCrossbow || this is RepeatingCrossbow )
			{
				base.GetProperties(list);
				list.Add(1060662, "{0}\t{1}", "Quiver using", m_BoltType.ToString());
			}
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize(writer);
			writer.Write(( int ) 3); //Version Number
			
			writer.WriteEncodedInt(( int )m_ArrowType ); //Version 2
			writer.WriteEncodedInt(( int )m_BoltType );  //Version 2
		}
		
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize(reader);
			int version = reader.ReadInt();
			
			switch (version)
			{
				case 3:
				case 2:
					{
						m_ArrowType = ( ArrowType )reader.ReadEncodedInt();
						m_BoltType = (BoltType)reader.ReadEncodedInt();
						break;
					}
				case 1:
					{
						break;
					}
				case 0:
					{
						/*m_EffectID =*/
						reader.ReadInt();
						break;
					}
			}
			
			if (version < 2)
			{
				WeaponAttributes.MageWeapon = 0;
				WeaponAttributes.UseBestSkill = 0;
			}
		}
	}
}
