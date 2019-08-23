using System;
using Server.Network;

namespace Server.Items
{
	public class ChampField2 : Item
	{
		[Constructable]
		public ChampField2() : base( 3915 )
		{
		  switch ( Utility.Random( 2 ) )
                  {
                      case 0: this.ItemID = 0x3915; break;
                      case 1: this.ItemID = 0x3922; break;
                  } 
		  new InternalTimer( this ).Start();
		}

                public override bool OnMoveOver( Mobile m )
		{
			if ( m.AccessLevel > AccessLevel.Player )
				return true;

			return false;
		}
              
		public ChampField2( Serial serial ) : base( serial )
		{
                     new InternalTimer( this ).Start();
		}

                private class InternalTimer : Timer
		{
			private Item m_Field2;

			public InternalTimer( Item field2 ) : base( TimeSpan.FromSeconds( 60.0 ) )
			{
				Priority = TimerPriority.OneSecond;

				m_Field2 = field2;
			}

			protected override void OnTick()
			{
				m_Field2.Delete();
			}
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