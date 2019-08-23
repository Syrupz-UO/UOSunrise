using System;
using Server.Prompts;
using System.Collections;
using Server.Items;
using Server.Targeting;
using Server.Misc;
using System.IO;
using System.Text;
using Server;
using Server.Network;

namespace Server.Items
{
	[Furniture]
	[FlipableAttribute(0x4B20, 0x4B21)]
	public class CustomizableWallSign : Item
	{
		[Constructable]
		public CustomizableWallSign() : base( 0x4B20 )
		{
		}

		public override void OnDoubleClick( Mobile from )
		{
				
			if ( IsChildOf( from.Backpack ) || Parent == from )
			{

				from.Prompt = new RenamePrompt( this );

				from.SendMessage( "Please enter what you would like etched on this sign." );
			}
			else
			{
				from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
		}

		private class RenamePrompt : Prompt
		{
			private CustomizableWallSign m_Rune;

			public RenamePrompt( CustomizableWallSign rune )
			{
				m_Rune = rune;
			}

			public override void OnResponse( Mobile from, string text )
			{

				m_Rune.Name = text;
				from.SendMessage( "You change the etching on the sign." );

			}
		}
		
		public CustomizableWallSign(Serial serial) : base(serial)
		{
		}

		public override void Serialize(GenericWriter writer)
		{
			base.Serialize(writer);

			writer.Write((int) 0);
		}

		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize(reader);

			int version = reader.ReadInt();
		}
	}
}

