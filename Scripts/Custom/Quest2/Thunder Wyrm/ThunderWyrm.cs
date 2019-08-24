using System;
using System.Collections;
using Server.Items;
using Server.Targeting;



using Server;

using System.Collections.Generic;
using Server.Misc;

using Server.Network;
using Server.Commands;
using Server.Commands.Generic;
using Server.Mobiles;
using Server.Accounting;
using Server.Regions;
using Server.Spells;

namespace Server.Mobiles
{
	[CorpseName( "a thunder wyrm corpse" )]
	public class ThunderWyrm : BaseCreature
	{
		//
		private DateTime m_NextPickup;
		//
		
		[Constructable]
		public ThunderWyrm() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = "a thunder wyrm";
			Body = 46;
			Hue = 1154;
			BaseSoundID = 362;


			SetStr( 1021, 1060 );
			SetDex( 901, 930 );
			SetInt( 1386, 1425 );

			SetHits( 119433, 119456 );

			SetDamage( 20, 30 );

			SetDamageType( ResistanceType.Energy, 100 );

			SetResistance( ResistanceType.Physical, 120, 120 );
			SetResistance( ResistanceType.Fire, 120, 120 );
			SetResistance( ResistanceType.Cold, 80, 90 );
			SetResistance( ResistanceType.Poison, 120, 120 );
			SetResistance( ResistanceType.Energy, 120, 120 );

			SetSkill( SkillName.EvalInt, 149.1, 150.0 );
			SetSkill( SkillName.Magery, 149.1, 150.0 );
			SetSkill( SkillName.MagicResist, 149.1, 150.0 );
			SetSkill( SkillName.Tactics, 120.0, 130.0 );
			SetSkill( SkillName.Wrestling, 121.1, 130.0 );
			SetSkill( SkillName.Anatomy, 105.5, 120.4 );
			SetSkill( SkillName.Healing, 90.0, 120.9 );

			Fame = 18000;
			Karma = -18000;

			VirtualArmor = 94;

			PackGold( 1500, 2000  );
		 switch ( Utility.Random( 50 ) ) //Rarity 10 
                        { 
                          case 0: PackItem( new WQStonebow( ) ); 
                          break; 
                          case 1: PackItem( new WQStonekryss( ) ); 
                          break; 
                          case 2: PackItem( new WQStonefork( ) ); 
                          break; 
                          case 3: PackItem( new WQStoneshield( ) ); 
                          break; 
                          case 4: PackItem( new WQStonemace( ) ); 
                          break; 
				  case 5: PackItem( new WQStonekatana( ) );
				  break;
                        } 

	
		}
		public override bool CanHeal{ get{ return true; } }
		public override int BreathPhysicalDamage{ get{ return 55; } }
		public override int BreathFireDamage{ get{ return 55; } }
		public override int BreathColdDamage{ get{ return 55; } }
		public override int BreathPoisonDamage{ get{ return 100; } }
		public override int BreathEnergyDamage{ get{ return 100; } }
		public override int BreathEffectHue{ get{ return 0x9C2; } }
		public override int BreathEffectSound{ get{ return 0x665; } }
		public override int BreathEffectItemID{ get{ return 0x3818; } }
		public override bool ReacquireOnMovement{ get{ return !Controlled; } }
		public override bool HasBreath{ get{ return true; } }
		public override double BreathEffectDelay{ get{ return 0.1; } }
		public override void BreathDealDamage( Mobile target, int form ){ base.BreathDealDamage( target, 1 ); }
///////////////////////
		
		public override bool AutoDispel{ get{ return true; } }
		public override bool BardImmune{ get{ return true; } }
		public override bool Unprovokable{ get{ return true; } }
		public override bool Uncalmable{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		public override bool IsScaryToPets { get { return true; } }
		public override bool CanRummageCorpses { get { return true; } }
        public override bool PlayerRangeSensitive { get { return true; } }
   
		////////////////////
		
		#region Weapon Abilities
        public override WeaponAbility GetWeaponAbility()
        {
                 switch (Utility.Random(5))
                  {
                   case 0: return WeaponAbility.BleedAttack; break;
                   case 1: return WeaponAbility.ParalyzingBlow; break;
                   case 2: return WeaponAbility.MortalStrike; break;
                   case 3: return WeaponAbility.CrushingBlow; break;
                   case 4: return WeaponAbility.WhirlwindAttack; break;
                  }
                   return null;
            }
        #endregion

        #region Immune to Pets
        public override void AlterMeleeDamageFrom(Mobile from, ref int damage)
        {
            if (from is BaseCreature)
            {
                BaseCreature bc = (BaseCreature)from;

                if (bc.Controlled || bc.BardTarget == this)
                    damage = 0; // Immune to pets and provoked creatures
            }
        }
        #endregion            
		
		public override void AddNameProperties( ObjectPropertyList list )
		{
			
			
			list.Add("Elder God of Wyrms");
			
		
		}
		
	#region Mass Curse
           public void MassCurse()
        {
            Map map = this.Map;

            if (map == null)
                return;

            ArrayList targets = new ArrayList();

            foreach (Mobile m in this.GetMobilesInRange(15))
            {
                if (m == this || !this.CanBeHarmful(m))
                    continue;

                if (m is BaseCreature && (((BaseCreature)m).Controlled || ((BaseCreature)m).Summoned || ((BaseCreature)m).Team != this.Team))
                    targets.Add(m);
                else if (m.Player)
                    targets.Add(m);
            }

            for (int i = 0; i < targets.Count; ++i)
                {
                    Mobile m = (Mobile)targets[i];

                    this.DoHarmful(m);

                    SpellHelper.AddStatCurse(this, m, StatType.Str);
                    SpellHelper.DisableSkillCheck = true;
                    SpellHelper.AddStatCurse(this, m, StatType.Dex);
                    SpellHelper.AddStatCurse(this, m, StatType.Int);
                    SpellHelper.DisableSkillCheck = false;

                    m.FixedParticles(0x374A, 10, 15, 5028, EffectLayer.Waist);
                    m.PlaySound(0x1FB);
                    int percentage = (int)(SpellHelper.GetOffsetScalar(this, m, true) * 100);
                    TimeSpan length = SpellHelper.GetDuration(this, m);

                    string args = String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", percentage, percentage, percentage, 10, 10, 10, 10);
                    BuffInfo.AddBuff(m, new BuffInfo(BuffIcon.Curse, 1075835, 1075836, length, m, args.ToString()));
                    m.SendMessage("You have been cursed!");
                }
        }
           #endregion	
		
		
		public override void OnThink()
		{
			base.OnThink();
			
			if (0.20 >= Utility.RandomDouble())
                {
                    MassCurse();
                }
				
			if ( DateTime.UtcNow < m_NextPickup )
				return;

			m_NextPickup = DateTime.UtcNow + TimeSpan.FromSeconds( Utility.RandomMinMax( 10, 20 ) );

			switch( Utility.RandomMinMax( 0, 11 ) )
			{
				case 0:	Peace( Combatant ); break;
				case 1:	Undress( Combatant ); break;
				case 2:	Suppress( Combatant ); break;
				case 3:	Provoke( Combatant ); break;
			}
		}
			#region Peace
		private DateTime m_NextPeace;

		public void Peace( Mobile target )
		{
			if ( target == null || Deleted || !Alive || m_NextPeace > DateTime.UtcNow || 0.1 < Utility.RandomDouble() )
				return;

			PlayerMobile p = target as PlayerMobile;

			if ( p != null && p.PeacedUntil < DateTime.UtcNow && !p.Hidden && CanBeHarmful( p ) )
			{
				p.PeacedUntil = DateTime.UtcNow + TimeSpan.FromMinutes( 1 );
				p.SendLocalizedMessage( 500616 ); // You hear lovely music, and forget to continue battling!
				p.FixedParticles( 0x376A, 1, 32, 0x15BD, EffectLayer.Waist );
				p.Combatant = null;

				PlaySound( 0x58D );
			}

			m_NextPeace = DateTime.UtcNow + TimeSpan.FromSeconds( 5 );
		}
		#endregion

		#region Suppress
		private static Dictionary<Mobile, Timer> m_Suppressed = new Dictionary<Mobile, Timer>();
		private DateTime m_NextSuppress;

		public void Suppress( Mobile target )
		{
			if ( target == null || m_Suppressed.ContainsKey( target ) || Deleted || !Alive || m_NextSuppress > DateTime.UtcNow || 0.1 < Utility.RandomDouble() )
				return;

			TimeSpan delay = TimeSpan.FromSeconds( Utility.RandomMinMax( 5, 10 ) );

			if ( !target.Hidden && CanBeHarmful( target ) )
			{
				target.SendLocalizedMessage( 1072061 ); // You hear jarring music, suppressing your strength.

				for ( int i = 0; i < target.Skills.Length; i++ )
				{
					Skill s = target.Skills[ i ];

					target.AddSkillMod( new TimedSkillMod( s.SkillName, true, s.Base * -0.28, delay ) );
				}

				int count = (int) Math.Round( delay.TotalSeconds / 1.25 );
				Timer timer = new AnimateTimer( target, count );
				m_Suppressed.Add( target, timer );
				timer.Start();

				PlaySound( 0x58C );
			}

			m_NextSuppress = DateTime.UtcNow + TimeSpan.FromSeconds( 10 );
		}

		public static void SuppressRemove( Mobile target )
		{
			if ( target != null && m_Suppressed.ContainsKey( target ) )
			{
				Timer timer = m_Suppressed[ target ];

				if ( timer != null || timer.Running )
					timer.Stop();

				m_Suppressed.Remove( target );
			}
		}

		private class AnimateTimer : Timer
		{
			private Mobile m_Owner;
			private int m_Count;

			public AnimateTimer( Mobile owner, int count ) : base( TimeSpan.Zero, TimeSpan.FromSeconds( 1.25 ) )
			{
				m_Owner = owner;
				m_Count = count;
			}

			protected override void OnTick()
			{
				if ( m_Owner.Deleted || !m_Owner.Alive || m_Count-- < 0 )
				{
					SuppressRemove( m_Owner );
				}
				else
					m_Owner.FixedParticles( 0x376A, 1, 32, 0x15BD, EffectLayer.Waist );
			}
		}
		#endregion

		#region Undress
		private DateTime m_NextUndress;

		public void Undress( Mobile target )
		{
			if ( target == null || Deleted || !Alive || m_NextUndress > DateTime.UtcNow || 0.005 < Utility.RandomDouble() )
				return;

			if ( target.Player && target.Female && !target.Hidden && CanBeHarmful( target ) )
			{
				UndressItem( target, Layer.OuterTorso );
				UndressItem( target, Layer.InnerTorso );
				UndressItem( target, Layer.MiddleTorso );
				UndressItem( target, Layer.Pants );
				UndressItem( target, Layer.Shirt );

				target.SendLocalizedMessage( 1072196 ); // The satyr's music makes your blood race. Your clothing is too confining.
			}

			m_NextUndress = DateTime.UtcNow + TimeSpan.FromMinutes( 1 );
		}

		public void UndressItem( Mobile m, Layer layer )
		{
			Item item = m.FindItemOnLayer( layer );

			if ( item != null && item.Movable )
				m.PlaceInBackpack( item );
		}
		#endregion

		#region Provoke
		private DateTime m_NextProvoke;

		public void Provoke( Mobile target )
		{
			if ( target == null || Deleted || !Alive || m_NextProvoke > DateTime.UtcNow || 0.05 < Utility.RandomDouble() )
				return;

			foreach ( Mobile m in GetMobilesInRange( RangePerception ) )
			{
				if ( m is BaseCreature )
				{
					BaseCreature c = (BaseCreature) m;

					if ( c == this || c == target || c.Unprovokable || c.IsParagon ||  c.BardProvoked || c.AccessLevel != AccessLevel.Player || !c.CanBeHarmful( target ) )
						continue;

					c.Provoke( this, target, true );

					if ( target.Player )
						target.SendLocalizedMessage( 1072062 ); // You hear angry music, and start to fight.

					PlaySound( 0x58A );
					break;
				}
			}

			m_NextProvoke = DateTime.UtcNow + TimeSpan.FromSeconds(5 );
		}
		#endregion
		////////////////////
		public ThunderWyrm( Serial serial ) : base( serial )
		{
		}

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
