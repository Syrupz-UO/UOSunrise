using System;
using Server;
using Server.Spells;

namespace Server.ACC.CSS.Systems.Master
{
	public abstract class MasterSpell : CSpell
	{
		public MasterSpell( Mobile caster, Item scroll, SpellInfo info ) : base( caster, scroll, info )
		{
		}
        
        public abstract SpellCircle Circle { get; }
        
        public override TimeSpan CastDelayBase { get { return TimeSpan.FromSeconds(3 * CastDelaySecondsPerTick); } }
        public override SkillName CastSkill { get { return SkillName.Magery; } }
        public override SkillName DamageSkill { get { return SkillName.EvalInt; } }

        public override bool ClearHandsOnCast { get { return true; } }

		public override void GetCastSkills( out double min, out double max )
		{
			min = RequiredSkill;
			max = RequiredSkill;
		}

		public override int GetMana()
		{
			return RequiredMana;
		}

		public override TimeSpan GetCastDelay()
		{
			return TimeSpan.FromSeconds( CastDelay );
		}
	}
}

