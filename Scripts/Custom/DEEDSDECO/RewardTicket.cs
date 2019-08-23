/*Monolith-KHzspeed 2011
ArtifactGumballRewards*/

using System;

namespace Server.Items
{
	public class RewardTicket : Item
	{
		[Constructable]
		public RewardTicket() : this( 1 )
		{
		}

		[Constructable]
		public RewardTicket( int amount ) : base( 0xEF3 )
		{
			Name = "Reward Ticket";
			LootType=LootType.Blessed;
			Hue = 1260 ;
			Stackable = true;
			Amount = amount;
		}

		public RewardTicket( Serial serial ) : base( serial )
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