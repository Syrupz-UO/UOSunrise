using System;
using Server;

namespace Server.Items
{
	


	public class Mirror : BronzeShield
	{

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		public override int ArtifactRarity{ get{ return 50; } }

		[Constructable]
		public Mirror()
		{
			Name = "Mirror Shield";
			Hue = 1150;

			Attributes.DefendChance = 50;
			Attributes.AttackChance = 50;
			FireBonus = 100;
			PhysicalBonus = 25;
			Attributes.WeaponDamage = 30;
			Attributes.WeaponSpeed = 30;
			ArmorAttributes.SelfRepair = 100;
			Attributes.SpellChanneling = 5;

		}

		public Mirror( Serial serial ) : base( serial )
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
	public class MegatonHammer : WarHammer
	{

      		public override int AosMinDamage{ get{ return 50; } } 
      		public override int AosMaxDamage{ get{ return 75; } } 
      		public override int AosSpeed{ get{ return 40; } } 


		public override int ArtifactRarity{ get{ return 50; } }
public override float MlSpeed{ get{ return 2.50f; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public MegatonHammer()
		{
			Name = "Megaton Hammer";
			Hue = 1161;

			WeaponAttributes.UseBestSkill = 1;
			Attributes.WeaponSpeed = 50;
			Attributes.WeaponDamage = 50;
			Attributes.BonusDex = 10;
			Attributes.BonusStr = 10;
			
			

		}

		public MegatonHammer( Serial serial ) : base( serial )
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
	public class Mastersword : Longsword
	{

		public override int ArtifactRarity{ get{ return 50; } }
public override float MlSpeed{ get{ return 2.50f; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public Mastersword()
		{
			Name = "The Master Sword";
			Hue = 2220;

			WeaponAttributes.UseBestSkill = 1;
			WeaponAttributes.HitEnergyArea = 100;
			WeaponAttributes.HitPhysicalArea = 100;
			WeaponAttributes.HitPoisonArea = 100;
			WeaponAttributes.HitColdArea = 100;
			WeaponAttributes.HitFireArea = 100;
			Attributes.WeaponDamage = 150;
			Attributes.BonusStr = 15;
			Attributes.RegenHits = 5;
			Attributes.BonusDex = 10;
			Attributes.BonusStr = 10;
			Attributes.BonusInt = 10;

		}

		public Mastersword( Serial serial ) : base( serial )
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
	public class KokiriKnife : SkinningKnife
	{

		public override int ArtifactRarity{ get{ return 50; } }
public override float MlSpeed{ get{ return 1.25f; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public KokiriKnife()
		{
			Name = "Kokiri Knife";
			Hue = 547;

			Attributes.SpellChanneling = 1;
			Attributes.SpellDamage = 10;
			WeaponAttributes.UseBestSkill = 1;
			Attributes.WeaponSpeed = 150;
			Attributes.WeaponDamage = -50;
			Attributes.BonusInt = 10;

		}

		public KokiriKnife( Serial serial ) : base( serial )
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
	public class GreatFairyS : BaseSword
	{

	      public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.Disarm; } }
	      public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

		public override int AosMinDamage{ get{ return 20; } } 
		public override int AosMaxDamage{ get{ return 40; } } 
		public override int AosSpeed{ get{ return 25; } } 
public override float MlSpeed{ get{ return 2.50f; } }


		public override int ArtifactRarity{ get{ return 50; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public GreatFairyS() : base( 0x26CF )
		{
			Name = "Great Fairy Sword";
			Hue = 1150;


			WeaponAttributes.UseBestSkill = 1;
			Attributes.WeaponSpeed = 50;
			Attributes.RegenMana = 10;
			Attributes.WeaponDamage = 50;
			Attributes.BonusDex = 20;
			Attributes.BonusStr = 20;
			Attributes.RegenHits = 5;

		}

		public GreatFairyS( Serial serial ) : base( serial )
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
	public class DekuShield : BronzeShield
	{

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		public override int ArtifactRarity{ get{ return 50; } }

		[Constructable]
		public DekuShield()
		{
			Name = "Deku Shield";
			Hue = 347;

			Attributes.DefendChance = 40;
			Attributes.AttackChance = 40;
			FireBonus = -40;
			PhysicalBonus = 25;
			Attributes.SpellDamage = 15;
			Attributes.WeaponSpeed = 10;
			ArmorAttributes.SelfRepair = 5;
			Attributes.SpellChanneling = 1;

		}

		public DekuShield( Serial serial ) : base( serial )
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
	public class Biggoron : BaseSword
	{

	      public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.Disarm; } }
	      public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

		public override int AosMinDamage{ get{ return 20; } } 
		public override int AosMaxDamage{ get{ return 40; } } 
		public override int AosSpeed{ get{ return 25; } } 
public override float MlSpeed{ get{ return 2.50f; } }


		public override int ArtifactRarity{ get{ return 50; } }

		public override int InitMinHits{ get{ return 255; } }
		public override int InitMaxHits{ get{ return 255; } }

		[Constructable]
		public Biggoron() : base( 0x26CF )
		{
			Name = "Biggoron Sword";
			Hue = 2101;

			WeaponAttributes.UseBestSkill = 1;
			Attributes.WeaponDamage = 50;
			Attributes.BonusDex = 20;
			Attributes.BonusStr = 20;
			Attributes.RegenHits = 5;

		}

		public Biggoron( Serial serial ) : base( serial )
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