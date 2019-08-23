using System;
using Server;
using Server.Items;
using System.Text;
using Server.Mobiles;
using Server.Gumps;

namespace Server.Items
{
	public class WantedMangar : Item
	{
		[Constructable]
		public WantedMangar( ) : base( 0x1E5E )
		{
			Name = "Wanted!";
		}

		public class WantedMangarGump : Gump
		{
			public WantedMangarGump( Mobile from ): base( 10, 10 )
			{
				Closable=true;
				Disposable=false;
				Dragable=true;
				Resizable=false;
				AddPage(0);
				AddImage(76, 111, 299);
			}
		}

		public override void OnDoubleClick( Mobile e )
		{
			if ( e.InRange( this.GetWorldLocation(), 4 ) )
			{
				e.CloseGump( typeof( WantedMangarGump ) );
				e.SendGump( new WantedMangarGump( e ) );
			}
			else
			{
				e.SendLocalizedMessage( 502138 ); // That is too far away for you to use
			}
		}

		public WantedMangar(Serial serial) : base(serial)
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