using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	public class SocketedCrossbow : Crossbow
	{
		[Constructable]
		public SocketedCrossbow()
		{
			UsedSockets = 0;

			switch ( Utility.Random( 20 ) ) 
			{ 
			case 0: MaxSockets = 1; break;
			case 1: MaxSockets = 1; break;
			case 2: MaxSockets = 1; break;
			case 3: MaxSockets = 1; break;
			case 4: MaxSockets = 1; break;
			case 5: MaxSockets = 1; break;
			case 6: MaxSockets = 1; break;
			case 7: MaxSockets = 1; break;
			case 8: MaxSockets = 1; break;
			case 9: MaxSockets = 1; break;
			case 10: MaxSockets = 1; break;
			case 11: MaxSockets = 1; break;
			case 12: MaxSockets = 1; break;
			case 13: MaxSockets = 1; break;
			case 14: MaxSockets = 1; break;
			case 15: MaxSockets = 1; break;
			case 16: MaxSockets = 2; break;
			case 17: MaxSockets = 2; break;
			case 18: MaxSockets = 2; break;
			case 19: MaxSockets = 3; break;
			}
		}
		
		public override void GetProperties( ObjectPropertyList list )
		{
			base.GetProperties(list);
			
			SocketLabel = "Sockets: " + UsedSockets + "/" + MaxSockets + AugmentList;
			list.Add( 1042971, SocketLabel );
		}

		public SocketedCrossbow( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 1 ); // version

			writer.Write( (int) UsedSockets );
			writer.Write( (int) MaxSockets );

			

			writer.Write( (string) AugmentList );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
			UsedSockets = reader.ReadInt();
			MaxSockets = reader.ReadInt();

			if ( version >=1 )
			{
			AugmentList = reader.ReadString();
			}
		}
	}
}