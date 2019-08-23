/////////////////////////////////////
//**Generated by Ryan**//
/////////////////////////////////////
using System;
using Server;

namespace Server.Items
{
	public class NoxTunic : LeatherChest
	{
	 	public override int ArtifactRarity{ get{ return 10; } }
	 	public override int InitMinHits{ get{ return 255; } }
	 	public override int InitMaxHits{ get{ return 255; } }

	 	[Constructable]
	 	public NoxTunic()
	 	{
	 	 	Name = "Tunic of the Swamp Queen";
	 	 	Hue = 2210;
	 	 	ArmorAttributes.MageArmor = 0;
	 	 	ArmorAttributes.SelfRepair = 5;
            PhysicalBonus = 10;
            PoisonBonus = 10;
            EnergyBonus = 10;
            ColdBonus = 10;
            FireBonus = 10;
			Attributes.BonusDex = 8;
			Attributes.BonusHits = 10;
			Attributes.CastRecovery = 0;
			Attributes.CastSpeed = 0;
			Attributes.DefendChance = 15;
			Attributes.Luck = 150;
			Attributes.NightSight = 0;
			Attributes.ReflectPhysical = 15;
			Attributes.RegenHits = 2;
			Attributes.RegenMana = 2;
			Attributes.SpellDamage = 25;
			Attributes.WeaponDamage = 15;
			Attributes.WeaponSpeed = 10;
	 	}

	 	public NoxTunic(Serial serial) : base( serial )
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
	}
}