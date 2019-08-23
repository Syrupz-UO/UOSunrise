// Scripted by Karmageddon
using System;
using Server;
using Server.Guilds;

namespace Server.Items
{
	public class TunicofDragonF : FemalePlateChest	
	{
		//public override int LabelNumber{ get{ return 1061099; } } // Tunic of Fire
		public override int ArtifactRarity{ get{ return 15; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public TunicofDragonF()
		{
			Hue = 1157;
			Name = "Chest of the Dragon";
			Attributes.DefendChance = 20;
			Attributes.BonusHits = 20;
			Attributes.RegenHits = 2;
			Attributes.WeaponSpeed = 5;
			Attributes.AttackChance = 20;
			ArmorAttributes.MageArmor = 1;
			PhysicalBonus = 20;
			FireBonus = 20;
			ColdBonus = 15;
			PoisonBonus = 20;
			EnergyBonus = 15;		
		}

		public TunicofDragonF( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}   

		public override bool OnEquip( Mobile from )
		{
			return Validate( from ) && base.OnEquip( from );
		}

		public override void OnSingleClick( Mobile from )
		{
			if ( Validate( Parent as Mobile ) )
				base.OnSingleClick( from );
		}

		public bool Validate( Mobile m )
		{
			if ( m == null || !m.Player )
				return true;
			{
				m.FixedParticles( 0x3709, 10, 30, 5052, EffectLayer.LeftFoot );
				m.PlaySound( 0x208 );
				m.SendMessage( "You feel the power of a dragon embrace you as the tunic attaches to you!" );

			}
			
			return true;
		}
	}
}
