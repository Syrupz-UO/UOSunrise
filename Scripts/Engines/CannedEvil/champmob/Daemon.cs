using System;
using Server;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.Misc;
using Server.Engines.CannedEvil;

namespace Server.Mobiles
{
	[CorpseName( "a Daemon corpse" )]
	public class ADaemon : BaseCreature
	{
		public override double DispelDifficulty{ get{ return 125.0; } }
		public override double DispelFocus{ get{ return 45.0; } }

		[Constructable]
		public ADaemon () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = NameList.RandomName( "Daemon" );
			Title = "the Daemon";

			Body = Utility.RandomList( 9, 10 );
			BaseSoundID = 357;

			if ( Utility.RandomMinMax( 1, 4 ) == 1 ) // FEMALE
			{
				Name = NameList.RandomName( "goddess" );
				Body = 260;
				BaseSoundID = 0x4B0;
			}

			SetStr( 476, 505 );
			SetDex( 76, 95 );
			SetInt( 301, 325 );

			SetHits( 286, 303 );

			SetDamage( 7, 14 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 45, 60 );
			SetResistance( ResistanceType.Fire, 50, 60 );
			SetResistance( ResistanceType.Cold, 30, 40 );
			SetResistance( ResistanceType.Poison, 20, 30 );
			SetResistance( ResistanceType.Energy, 30, 40 );

			SetSkill( SkillName.EvalInt, 70.1, 80.0 );
			SetSkill( SkillName.Magery, 70.1, 80.0 );
			SetSkill( SkillName.MagicResist, 85.1, 95.0 );
			SetSkill( SkillName.Tactics, 70.1, 80.0 );
			SetSkill( SkillName.Wrestling, 60.1, 80.0 );

			Fame = 15000;
			Karma = -15000;

			VirtualArmor = 58;
			ControlSlots = Core.SE ? 4 : 5;

			if ( Body == 353 ){ PackItem( new Longsword() ); }
		}

		public override void GenerateLoot()
		{
			if (this.Region is ChampionSpawnRegion)
			{
			return;
			}
			else
			{
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.Average, 2 );
			AddLoot( LootPack.MedScrolls, 2 );
		}
		}
		public override void OnDeath( Container c )
		{
			base.OnDeath( c );

			Mobile killer = this.LastKiller;
			if ( killer != null && this.Body == 353 )
			{
				if ( killer is BaseCreature )
					killer = ((BaseCreature)killer).GetMaster();

				if ( killer is PlayerMobile )
				{
					if ( GetPlayerInfo.LuckyKiller( killer.Luck ) && Utility.RandomMinMax( 1, 4 ) == 1 )
					{
						BaseWeapon sword = new Longsword();
						sword.AccuracyLevel = WeaponAccuracyLevel.Supremely;
						sword.MinDamage = sword.MinDamage + 4;
						sword.MaxDamage = sword.MaxDamage + 9;
            			sword.Attributes.BonusHits = 50;
						sword.AosElementDamages.Fire = 50;
						sword.Name = "sword of " + this.Title;
						if ( Utility.RandomMinMax( 0, 100 ) > 75 ){ sword.Slayer = SlayerName.Repond; }
						if ( Utility.RandomMinMax( 0, 100 ) > 75 ){ sword.WeaponAttributes.HitFireball = 10; }
						sword.Hue = 0x54B;
						c.DropItem( sword );
					}
				}
			}
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Regular; } }
		public override int TreasureMapLevel{ get{ return 4; } }
		public override int Meat{ get{ return 1; } }
		public override int Hides{ get{ return 18; } }
		public override HideType HideType{ get{ return HideType.Hellish; } }

		public ADaemon( Serial serial ) : base( serial )
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
