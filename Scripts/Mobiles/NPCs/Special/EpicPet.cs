using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;

namespace Server.Mobiles
{
	public class EpicPet : BasePerson
	{
		[Constructable]
		public EpicPet () : base( )
		{
			Blessed = true;
			Name = "an enslaved demon";
			Body = 9;
			BaseSoundID = 357;
			CantWalk = true;
			Direction = Direction.East;
		}

		public override void OnAfterSpawn()
		{
			base.OnAfterSpawn();
			Server.Misc.MorphingTime.CheckMorph( this );
			Blessed = true;
			Name = "an enslaved demon";
			Body = 9;
			BaseSoundID = 357;
			CantWalk = true;
			Direction = Direction.East;
		}

		public EpicPet( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
			Blessed = true;
			Name = "an enslaved demon";
			Body = 9;
			BaseSoundID = 357;
			CantWalk = true;
			Direction = Direction.East;
		}
	}
}