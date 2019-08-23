using System;
using Server;
using Server.Items;
using Server.Mobiles;
using Server.Misc;
using Server.Network;

namespace Server.Mobiles
{
	[CorpseName( "a demon corpse" )]
	public class BloodDemon : BaseCreature
	{
		public override double DispelDifficulty{ get{ return 150.0; } }
		public override double DispelFocus{ get{ return 25.0; } }

		[Constructable]
		public BloodDemon () : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			Name = NameList.RandomName( "demonic" );

			switch ( Utility.RandomMinMax( 0, 5 ) )
			{
				case 0: Title = "the blood daemon"; break;
				case 1: Title = "the daemon of blood"; break;
				case 2: Title = "of the bloody veil"; break;
				case 3: Title = "of the bleeding void"; break;
				case 4: Title = "the bloodletter"; break;
				case 5: Title = "of bloodletting"; break;
			}

			Body = 9;
			Hue = 0xB9E;
			BaseSoundID = 357;


			SetStr( 508, 640 );
			SetDex( 141, 190 );
			SetInt( 518, 677 );

			SetHits( 342, 383 );

			SetDamage( 22, 32 );

			SetDamageType( ResistanceType.Physical, 75 );
			SetDamageType( ResistanceType.Energy, 25 );

			SetResistance( ResistanceType.Physical, 80, 90 );
			SetResistance( ResistanceType.Fire, 70, 80 );
			SetResistance( ResistanceType.Cold, 40, 50 );
			SetResistance( ResistanceType.Poison, 50, 60 );
			SetResistance( ResistanceType.Energy, 50, 60 );

			SetSkill( SkillName.EvalInt, 90.1, 100.0 );
			SetSkill( SkillName.Magery, 99.1, 100.0 );
			SetSkill( SkillName.Meditation, 90.1, 100.0 );
			SetSkill( SkillName.MagicResist, 100.5, 150.0 );
			SetSkill( SkillName.Tactics, 80.1, 90.0 );
			SetSkill( SkillName.Wrestling, 80.1, 90.0 );

			Fame = 29000;
			Karma = -29000;

			VirtualArmor = 85;
		}

		public override void GenerateLoot()
		{
			AddLoot( LootPack.FilthyRich, 2 );
			AddLoot( LootPack.Rich );
			AddLoot( LootPack.MedScrolls, 2 );
		}

		public override bool CanRummageCorpses{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Deadly; } }
		public override int TreasureMapLevel{ get{ return 5; } }
		public override int Meat{ get{ return 1; } }
		public override int Hides{ get{ return 18; } }
		public override HideType HideType{ get{ return HideType.Hellish; } }

		public override void OnDeath( Container c )
		{
			base.OnDeath( c );

			Mobile killer = this.LastKiller;
			if ( killer != null && this.Body == 320 )
			{
				if ( killer is BaseCreature )
					killer = ((BaseCreature)killer).GetMaster();

				if ( killer is PlayerMobile )
				{
					if ( GetPlayerInfo.LuckyKiller( killer.Luck ) && Utility.RandomMinMax( 1, 4 ) == 1 )
					{
						string blade = this.Title;
							if ( blade.Contains("of ") ){ blade = this.Title; }
							else if ( blade.Contains("the ") ){ blade = "of " + this.Title; }

						BaseWeapon sword = new Longsword();
						sword.AccuracyLevel = WeaponAccuracyLevel.Supremely;
						sword.MinDamage = sword.MinDamage + 7;
						sword.MaxDamage = sword.MaxDamage + 12;
            			sword.Attributes.BonusHits = 50;
						sword.AosElementDamages.Poison = 25;
						sword.Name = "sword " + blade;
						sword.Slayer = SlayerName.Repond;
						if ( Utility.RandomMinMax( 0, 100 ) > 50 ){ sword.WeaponAttributes.HitLeechHits = 25; }
						sword.Hue = 0xB9E;
						c.DropItem( sword );
					}
				}
			}
		}

		public override void OnGotMeleeAttack( Mobile attacker )
		{
			base.OnGotMeleeAttack( attacker );

			if ( Utility.RandomMinMax( 1, 4 ) == 1 )
			{
				int goo = 0;

				foreach ( Item splash in this.GetItemsInRange( 10 ) ){ if ( splash is MonsterSplatter && splash.Name == "thick blood" ){ goo++; } }

				if ( goo == 0 )
				{
					MonsterSplatter.AddSplatter( this.X, this.Y, this.Z, this.Map, this.Location, this, "thick blood", 0x485, 0 );
				}
			}
		}

		public BloodDemon( Serial serial ) : base( serial )
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