using System;
using System.Collections.Generic;
using Server;
using System.Collections;
using Server.Items;
using Server.Misc;
using Server.Network;
using Server.Mobiles;
using Server.Spells.Necromancy;
using Server.Spells;

namespace Server.Mobiles
{
	[CorpseName( "a Bloody Mary corpse" )]
	public class BloodyMary : BaseCreature
	{
        public override bool BardImmune { get { return !Core.SE; } }
        public override bool Unprovokable { get { return Core.SE; } }
        public override bool Uncalmable { get { return Core.SE; } }
        public override bool IsScaryToPets { get { return true; } }


		[Constructable]
		public BloodyMary() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
            Name = "Bloody Mary";
			Body = 0x191;
            Female = true;
            Hue = 2573;
            HairItemID = 0x203C;
            HairHue = 52;

            BaseSoundID = 402;

			SetStr( 250, 350 );
			SetDex( 300, 400 );
			SetInt( 1500, 1700 );

			SetHits( 5000, 10000 );	

			SetDamage( 11, 18 );
			
			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Energy, 50 );

			SetResistance( ResistanceType.Physical, 40, 60 );
			SetResistance( ResistanceType.Fire, 40, 50 );
			SetResistance( ResistanceType.Cold, 55, 65 );
			SetResistance( ResistanceType.Poison, 70, 75 );
			SetResistance( ResistanceType.Energy, 70, 80 );
			
			SetSkill( SkillName.Swords, 110, 120 );
			SetSkill( SkillName.Tactics, 100, 105 );
			SetSkill( SkillName.MagicResist,110, 120 );
			SetSkill( SkillName.Magery, 110, 120 );
			SetSkill( SkillName.EvalInt, 110, 120 );
			SetSkill( SkillName.Meditation, 110, 120 );
			SetSkill( SkillName.Necromancy, 110, 120 );
			SetSkill( SkillName.SpiritSpeak, 110, 120 );

			Fame = 25000;
			Karma = -25000;

            Shirt shirt = new Shirt();
            shirt.Movable = false;
            AddItem(shirt);
            LongPants pants = new LongPants();
            pants.Movable = false;
            AddItem(pants);
            Sandals shoes = new Sandals();
            shoes.Movable = false;
            AddItem(shoes);
            BloodyMarysApron fullapron = new BloodyMarysApron();
            fullapron.Movable = false;
            AddItem(fullapron);
            Cleaver weapon = new Cleaver();
            weapon.Movable = false;
            AddItem(weapon);
		}

		public override void GenerateLoot()
		{
            AddLoot(LootPack.SuperBoss, 2);
		}
        public override void OnDeath(Container c)
        {
            base.OnDeath(c);

            if (0.50 > Utility.RandomDouble()) // 50% chance to drop
            {           
                c.DropItem(new BloodyMarysApron());             
            }
        }
        public override void OnThink()
        {
            base.OnThink();

            {
                Blood blood = new Blood();
                blood.ItemID = Utility.Random(0x122A, 5);
                blood.MoveToWorld(Location, Map);
            }
        }

		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
        public override bool AlwaysMurderer { get { return true; } }

        public override int GetAttackSound()
        {
            return 916;
        }

        public override int GetAngerSound()
        {
            return 916;
        }

        public override int GetDeathSound()
        {
            return 917;
        }
        public BloodyMary(Serial serial)
            : base(serial)
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