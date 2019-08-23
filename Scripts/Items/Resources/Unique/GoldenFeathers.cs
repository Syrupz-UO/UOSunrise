using System;
using Server;
using System.Collections.Generic;
using Server.Mobiles;
using Server.Items;
using System.Collections;
using Server.Misc;

namespace Server.Items
{
	public class GoldenFeathers : Item
	{
		public Mobile owner;

		[CommandProperty( AccessLevel.GameMaster )]
		public Mobile Owner
		{
			get{ return owner; }
			set{ owner = value; }
		}

		[Constructable]
		public GoldenFeathers( Mobile from ) : base( 0x1021 )
		{
			this.owner = from;	
			Name = "golden feathers";
			Weight = 1.0;
			Hue = 0x501;
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
			if ( owner != null ){ list.Add( 1070722, "Gifted to " + owner.Name + ""); }
        } 

		public GoldenFeathers( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
			writer.Write( (Mobile)owner);
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			owner = reader.ReadMobile();
		}
	}
}