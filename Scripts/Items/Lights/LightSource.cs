using System;

namespace Server.Items
{
	public class LightSource : Item
	{
		[Constructable]
		public LightSource() : base( 0x1647 )
		{
			Layer = Layer.Talisman;
			//Layer = Layer.TwoHanded;
			Movable = false;
			LootType = LootType.Blessed;
		}

		public LightSource( Serial serial ) : base( serial )
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

	public class LighterSource : Item
	{
		[Constructable]
		public LighterSource() : base( 0x17F3 )
		{
			Layer = Layer.Talisman;
			Movable = false;
			LootType = LootType.Blessed;
		}

		public LighterSource( Serial serial ) : base( serial )
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