using System;
using Server;
using Server.Misc;

namespace Server.Items
{
	public class OrbOfTheAbyss : MagicTalisman
	{
		public Mobile owner;

		[CommandProperty( AccessLevel.GameMaster )]
		public Mobile Owner { get{ return owner; } set{ owner = value; } }

		[Constructable]
		public OrbOfTheAbyss()
		{
			Name = "orb of the abyss";
			ItemID = 0x2C84;
			Hue = 0x489;
		}

		public override bool OnEquip( Mobile from )
		{
			if ( owner != from )
			{
				from.SendMessage ("This is not your orb!");
				return false;
			}

			return base.OnEquip( from );
		}

        public override void AddNameProperties(ObjectPropertyList list)
		{
            base.AddNameProperties(list);
            if ( owner != null ){ list.Add( 1049644, "Belongs to " + owner.Name + ""); }
        } 

		public OrbOfTheAbyss( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 1 ); // version
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