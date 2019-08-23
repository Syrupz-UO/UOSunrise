//Hands Of God~Kindred Owner~http://hellinc.ath.cx


using System;
using Server.Items;
using Server.Gumps;
using Server.Accounting;

namespace Server.Items
{
	public class PlayerSuggestionStone : Item
	{
		[Constructable]
		public PlayerSuggestionStone() : base( 0xED4 )
		{
			Movable = false;
			Hue = 2831;
			Name = "Player Suggestion Stone";
		}

		public override void OnDoubleClick( Mobile from )
		{
                  
			from.SendGump (new PlayerSuggestion());
		
		   	
					
		}

		public PlayerSuggestionStone( Serial serial ) : base( serial )
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
