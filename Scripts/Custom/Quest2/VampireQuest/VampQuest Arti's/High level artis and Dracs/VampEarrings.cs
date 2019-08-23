  /////////////////////////////
 //////  LostSinner  /////////
/////////////////////////////

using System;
namespace Server.Items
{
	public class VampEarrings : BaseEarrings
	{
		public override int ArtifactRarity{ get{ return 66; } }

		[Constructable]
		public VampEarrings() : base( 0x1F07 )
		{
			Name = "Draculas Aegris";
			Hue = 37;
			//Attributes.WeaponDamage = 15;
			Attributes.ReflectPhysical = 15;
			Attributes.CastSpeed = 2;
			Attributes.CastRecovery = 4;
			Attributes.RegenStam = 2;
			Attributes.RegenMana = 2;
			Attributes.RegenHits = 2;
			Attributes.NightSight = 1;
		}

		public VampEarrings( Serial serial ) : base( serial )
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