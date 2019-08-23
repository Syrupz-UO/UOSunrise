using System;
using Server.Network;

namespace Server.Items
{
	public class ChampField : Item
	{
		[Constructable]
		public ChampField() : base( 0x993 )
		{
		  switch ( Utility.Random( 2 ) )
                  {
                      case 0: this.ItemID = 0x3996; break;
                      case 1: this.ItemID = 0x398C; break;
                  } 

                  new InternalTimer( this ).Start();
		}

                public override bool OnMoveOver( Mobile m )
		{
			if ( m.AccessLevel > AccessLevel.Player )
				return true;

			return false;
		}
              
		public ChampField( Serial serial ) : base( serial )
		{
                     new InternalTimer( this ).Start();
		}

                private class InternalTimer : Timer
		{
			private Item m_Field;

			public InternalTimer( Item field ) : base( TimeSpan.FromSeconds( 60.0 ) )
			{
				Priority = TimerPriority.OneSecond;

				m_Field = field;
			}

			protected override void OnTick()
			{
				m_Field.Delete();
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