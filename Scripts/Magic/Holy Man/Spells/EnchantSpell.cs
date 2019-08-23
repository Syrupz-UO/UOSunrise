using System;
using System.Collections;
using Server;
using Server.Items;
using Server.Gumps;
using Server.Spells;
using Server.Targeting;
using Server.Network;
using Server.Regions;
using Server.Misc;

namespace Server.Spells.HolyMan
{
	public class EnchantSpell : HolyManSpell
    {
        private static SpellInfo m_Info = new SpellInfo(
				"Enchant", "Fascinare",
				266,
				9040
			);

		public override TimeSpan CastDelayBase { get { return TimeSpan.FromSeconds( 3 ); } }
		public override int RequiredTithing{ get{ return 180; } }
		public override double RequiredSkill{ get{ return 90.0; } }
		public override int RequiredMana{ get{ return 45; } }

        private int m_Hue;
        private string m_Name;
		private SlayerName m_Slayer;
		private SlayerName m_Slayer2;

        public EnchantSpell(Mobile caster, Item scroll) : base(caster, scroll, m_Info)
        {
        }

        public override void OnCast()
        {
            if (CheckSequence())
            {
                m_Name = null;
                Caster.Target = new InternalTarget(this);
            }
        }

        public override bool CheckCast()
        {
            if (!base.CheckCast())
                return false;

            return true;
        }

        public void Target(BaseWeapon weapon)
        {
            if (!Caster.CanSee(weapon))
            {
                Caster.SendLocalizedMessage(500237); // Target can not be seen.
            }
            else if (!Caster.CanBeginAction(typeof(EnchantSpell)))
            {
                Caster.SendLocalizedMessage(1005559); // This spell is already in effect.
            }
			else if ( !weapon.IsChildOf( Caster.Backpack ) )
			{
				Caster.SendMessage( "The weapon must be in your pack to enchant." );
			}
            else if (CheckSequence())
            {
                if (Caster.BeginAction(typeof(EnchantSpell)))
                {
					if (this.Scroll != null)
						Scroll.Consume();

					m_Hue = weapon.Hue;

					m_Name = weapon.Name;
					if ( weapon.Name != null && weapon.Name != "" ){ m_Name = weapon.Name; }
					if ( m_Name == null ){ m_Name = MorphingItem.AddSpacesToSentence( (weapon.GetType()).Name ); }

					m_Slayer = weapon.Slayer;
					m_Slayer2 = weapon.Slayer2;

					weapon.Name = "" + m_Name + " [enchanted]";
					weapon.Hue = 0x9C4;
					weapon.Attributes.WeaponDamage += 50;
					weapon.Slayer = SlayerName.Silver;
					weapon.Slayer2 = SlayerName.Exorcism;

					Caster.FixedParticles( 0x375A, 9, 20, 5027, EffectLayer.Waist );
					Caster.PlaySound( 0x1F7 );

					StopTimer(Caster);

					Timer t = new InternalTimer(Caster, weapon, m_Hue, m_Name, m_Slayer, m_Slayer2);

					m_Timers[Caster] = t;

					t.Start();
                }
                else if (!Caster.CanBeginAction(typeof(EnchantSpell)))
                {
                    DoFizzle();
                }
            }

            FinishSequence();
        }

        private class InternalTarget : Target
        {
            private EnchantSpell m_Owner;

            public InternalTarget(EnchantSpell owner) : base(12, false, TargetFlags.None)
            {
                m_Owner = owner;
            }

            protected override void OnTarget(Mobile from, object o)
            {
                if (o is BaseWeapon)
                {
                    m_Owner.Target((BaseWeapon)o);
                }
                else
                {
                    from.SendMessage("That cannot be enchanted.");
                }
            }

            protected override void OnTargetFinish(Mobile from)
            {
                m_Owner.FinishSequence();
            }
        }
        private static Hashtable m_Timers = new Hashtable();

        public static bool StopTimer(Mobile m)
        {
            Timer t = (Timer)m_Timers[m];

            if (t != null)
            {
                t.Stop();
                m_Timers.Remove(m);
            }

            return (t != null);
        }

        private class InternalTimer : Timer
        {
            private Mobile m_Owner;
            private BaseWeapon m_Weapon;
            private int m_weaponhue;
            private string m_Name;
			private SlayerName m_slayer;
			private SlayerName m_slayer2;

            public InternalTimer( Mobile owner, BaseWeapon weapon, int m_Hue, string m_WeaponName, SlayerName m_Slayer, SlayerName m_Slayer2 ) : base(TimeSpan.FromSeconds(0))
            {
                m_Owner = owner;
                m_Weapon = weapon;
                m_weaponhue = m_Hue;
                m_Name = m_WeaponName;
				m_slayer = m_Slayer;
				m_slayer2 = m_Slayer2;

                int val = (int)owner.Skills[SkillName.Healing].Value;

                if (val > 100)
                    val = 100;

                Delay = TimeSpan.FromMinutes( (int)(val / 5 ));
                Priority = TimerPriority.TwoFiftyMS;
            }

            protected override void OnTick()
            {
                if (!m_Owner.CanBeginAction(typeof(EnchantSpell)))
                {
                    m_Weapon.Hue = m_weaponhue;
                    m_Weapon.Name = m_Name;
                    m_Weapon.Attributes.WeaponDamage -= 50;
                    m_Weapon.Slayer = m_slayer;
                    m_Weapon.Slayer2 = m_slayer2;
                    m_Owner.EndAction(typeof(EnchantSpell));
                }
            }
        }
    }
}
