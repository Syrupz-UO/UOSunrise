using System;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "a hellsteed corpse" )]
	public class HellSteed : BaseMount
	{
		public override int BreathPhysicalDamage{ get{ return 0; } }
		public override int BreathFireDamage{ get{ return 0; } }
		public override int BreathColdDamage{ get{ return 100; } }
		public override int BreathPoisonDamage{ get{ return 0; } }
		public override int BreathEnergyDamage{ get{ return 0; } }
		public override int BreathEffectHue{ get{ return 0x481; } }
		public override int BreathEffectSound{ get{ return 0x64F; } }
		public override bool ReacquireOnMovement{ get{ return true; } }
		public override bool HasBreath{ get{ return true; } }
		public override void BreathDealDamage( Mobile target, int form ){ base.BreathDealDamage( target, 19 ); }

		[Constructable] 
		public HellSteed() : this( "a hellsteed" )
		{
		}

		[Constructable]
		public HellSteed( string name ) : base( name, 793, 0x3EBB, AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			SetStr( 201, 210 );
			SetDex( 101, 110 );
			SetInt( 101, 115 );

			SetHits( 201, 220 );

			SetDamage( 20, 24 );

			SetDamageType( ResistanceType.Physical, 25 );
			SetDamageType( ResistanceType.Fire, 75 );

			SetResistance( ResistanceType.Physical, 60, 70 );
			SetResistance( ResistanceType.Fire, 90 );
			SetResistance( ResistanceType.Poison, 100 );

			SetSkill( SkillName.MagicResist, 90.1, 110.0 );
			SetSkill( SkillName.Tactics, 50.0 );
			SetSkill( SkillName.Wrestling, 90.1, 110.0 );

			Fame = 2000;
			Karma = -2000;
		}

		public override Poison PoisonImmune{ get{ return Poison.Deadly; } }
		public override int Hides{ get{ return 12; } }
		public override HideType HideType{ get{ return HideType.Volcanic; } }

		public HellSteed( Serial serial ) : base( serial )
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