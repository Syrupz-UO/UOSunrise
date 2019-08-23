using System;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "a horse corpse" )]
	public class EvilHorse : BaseMount
	{
		private static int[] m_IDs = new int[]
			{
				0xC8, 0x3E9F,
				0xE2, 0x3EA0,
				0xE4, 0x3EA1,
				0xE2, 0x3EA0
			};

		[Constructable]
		public EvilHorse() : this( "a horse" )
		{
		}

		[Constructable]
		public EvilHorse( string name ) : base( name, 0xE2, 0x3EA0, AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			int random = Utility.Random( 4 );

			Body = m_IDs[random * 2];
			ItemID = m_IDs[random * 2 + 1];
			Hue = Utility.RandomList( 0, 0, 0, 0, 0, 0x967, 0x968, 0x969, 0x96A, 0x96B, 0x96C, 0x973, 0x974, 0x975, 0x976, 0x977, 0x978, 0x979, 0x97A, 0x97B, 0x97C, 0x97D, 0x97E );
			BaseSoundID = 0xA8;

			SetStr( 22, 98 );
			SetDex( 56, 75 );
			SetInt( 6, 10 );

			SetHits( 28, 45 );
			SetMana( 0 );

			SetDamage( 3, 4 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 15, 20 );

			SetSkill( SkillName.MagicResist, 25.1, 30.0 );
			SetSkill( SkillName.Tactics, 29.3, 44.0 );
			SetSkill( SkillName.Wrestling, 29.3, 44.0 );

			Fame = 0;
			Karma = 0;

			Tamable = false;
			ControlSlots = 1;
			MinTameSkill = 29.1;
		}

		public override int Meat{ get{ return 3; } }
		public override int Hides{ get{ return 10; } }

		public EvilHorse( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
			if ( Rider == null ){ Timer.DelayCall( TimeSpan.FromSeconds( 5.0 ), new TimerCallback( Delete ) ); }
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			if ( Rider == null ){ Timer.DelayCall( TimeSpan.FromSeconds( 5.0 ), new TimerCallback( Delete ) ); }
		}
	}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	[CorpseName( "an ostard corpse" )]
	public class EvilOstard : BaseMount
	{
		[Constructable]
		public EvilOstard() : this( "an ostard" )
		{
		}

		[Constructable]
		public EvilOstard( string name ) : base( name, 0xD2, 0x3EA3, AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			int Hue1 = Utility.RandomHairHue() | 0x8000;
			int Hue2 = 1701;
			int Hue3 = 0x89f;

			Hue = Utility.RandomList( Hue1, Hue2, Hue3 );
			BaseSoundID = 0x270;

			SetStr( 94, 170 );
			SetDex( 56, 75 );
			SetInt( 6, 10 );

			SetHits( 71, 88 );
			SetMana( 0 );

			SetDamage( 8, 14 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 15, 20 );

			SetSkill( SkillName.MagicResist, 27.1, 32.0 );
			SetSkill( SkillName.Tactics, 29.3, 44.0 );
			SetSkill( SkillName.Wrestling, 29.3, 44.0 );

			Fame = 0;
			Karma = 0;

			Tamable = false;
			ControlSlots = 1;
			MinTameSkill = 29.1;
		}

		public override int Meat{ get{ return 3; } }

		public EvilOstard( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
			if ( Rider == null ){ Timer.DelayCall( TimeSpan.FromSeconds( 5.0 ), new TimerCallback( Delete ) ); }
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			if ( Rider == null ){ Timer.DelayCall( TimeSpan.FromSeconds( 5.0 ), new TimerCallback( Delete ) ); }
		}
	}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	[CorpseName( "a wolf corpse" )]
	public class EvilWolf : BaseMount
	{
		[Constructable]
		public EvilWolf() : this( "a wolf" )
		{
		}

		[Constructable]
		public EvilWolf( string name ) : base( name, 277, 16017, AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			Body = 277;
			BaseSoundID = 0xE5;
			ItemID = 16017;
			Hue = Utility.RandomList( 1899, 2312, 0x430 );

			SetStr( 56, 80 );
			SetDex( 56, 75 );
			SetInt( 31, 55 );

			SetHits( 34, 48 );
			SetMana( 0 );

			SetDamage( 3, 7 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 15, 20 );
			SetResistance( ResistanceType.Fire, 10, 15 );
			SetResistance( ResistanceType.Cold, 20, 25 );
			SetResistance( ResistanceType.Poison, 10, 15 );
			SetResistance( ResistanceType.Energy, 10, 15 );

			SetSkill( SkillName.MagicResist, 20.1, 35.0 );
			SetSkill( SkillName.Tactics, 45.1, 60.0 );
			SetSkill( SkillName.Wrestling, 45.1, 60.0 );

			Fame = 450;
			Karma = 0;

			VirtualArmor = 16;

			Tamable = false;
			ControlSlots = 1;
			MinTameSkill = 29.1;
		}

		public override int Meat{ get{ return 1; } }
		public override int Hides{ get{ return 6; } }

		public EvilWolf( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
			if ( Rider == null ){ Timer.DelayCall( TimeSpan.FromSeconds( 5.0 ), new TimerCallback( Delete ) ); }
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			if ( Rider == null ){ Timer.DelayCall( TimeSpan.FromSeconds( 5.0 ), new TimerCallback( Delete ) ); }
		}
	}
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
	[CorpseName( "a dinosaur corpse" )]
	public class EvilRidgeback : BaseMount
	{
		[Constructable]
		public EvilRidgeback() : this( "a rakasaurus" )
		{
		}

		[Constructable]
		public EvilRidgeback( string name ) : base( name, 187, 0x3EBA, AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			BaseSoundID = 0x3F3;
			Hue = Utility.RandomList( 0x7D1, 0x7D2, 0x7D3, 0x7D4, 0x7D5, 0x7D6, 0x7D7, 0x7D8, 0x7D9, 0x7DA, 0x7DB, 0x7DC );

			SetStr( 58, 100 );
			SetDex( 56, 75 );
			SetInt( 16, 30 );

			SetHits( 41, 54 );
			SetMana( 0 );

			SetDamage( 3, 5 );

			SetDamageType( ResistanceType.Physical, 100 );

			SetResistance( ResistanceType.Physical, 15, 25 );
			SetResistance( ResistanceType.Fire, 5, 10 );
			SetResistance( ResistanceType.Cold, 5, 10 );
			SetResistance( ResistanceType.Poison, 5, 10 );
			SetResistance( ResistanceType.Energy, 5, 10 );

			SetSkill( SkillName.MagicResist, 25.3, 40.0 );
			SetSkill( SkillName.Tactics, 29.3, 44.0 );
			SetSkill( SkillName.Wrestling, 35.1, 45.0 );

			Fame = 300;
			Karma = 0;

			Tamable = false;
			ControlSlots = 1;
			MinTameSkill = 83.1;
		}

		public override int Meat{ get{ return 1; } }
		public override int Hides{ get{ return 12; } }
		public override HideType HideType{ get{ return HideType.Dinosaur; } }
		public override int Scales{ get{ return 3; } }
		public override ScaleType ScaleType{ get{ return ScaleType.Dinosaur; } }
		public override FoodType FavoriteFood{ get{ return FoodType.FruitsAndVegies | FoodType.GrainsAndHay; } }

		public EvilRidgeback( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
			if ( Rider == null ){ Timer.DelayCall( TimeSpan.FromSeconds( 5.0 ), new TimerCallback( Delete ) ); }
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			if ( Rider == null ){ Timer.DelayCall( TimeSpan.FromSeconds( 5.0 ), new TimerCallback( Delete ) ); }
		}
	}
}