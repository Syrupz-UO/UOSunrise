using System;
using Server;
using Server.Engines.Craft;

namespace Server.Items
{
	public class MagicStaffCraftingTool : BaseTool
	{
		public override CraftSystem CraftSystem{ get{ return DefMagicStaffCrafting.CraftSystem; } }

		[Constructable]
		public MagicStaffCraftingTool() : base( 0x1EBC )
		{
			Weight = 1.0;
			Name = "Magic Staff Crafting Tools";
		}

		[Constructable]
		public MagicStaffCraftingTool( int uses ) : base( uses, 0x1EBC )
		{
			Weight = 1.0;
			Name = "Magic Staff Crafting Tools";

		}

		public MagicStaffCraftingTool( Serial serial ) : base( serial )
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