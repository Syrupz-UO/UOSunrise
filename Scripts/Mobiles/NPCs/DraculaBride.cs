using System;
using System.Collections;
using Server.Items;
using Server.ContextMenus;
using Server.Misc;
using Server.Network;

namespace Server.Mobiles
{
	[CorpseName( "a pile of ash" )]
	public class DraculaBride : BaseCreature
	{
		[Constructable]
		public DraculaBride () : base( AIType.AI_Animal, FightMode.Aggressor, 10, 1, 0.2, 0.4 )
		{
			BaseSoundID = 0x17F;
			Blessed = true;

			Name = "Dolengen";
			Title = "the Countess of Gratz";

			CantWalk = true;
			Direction = Direction.East;

			Body = 401;

			int GhostHue = 0x47E;

			Hue = GhostHue;

			Utility.AssignRandomHair( this );
			HairHue = GhostHue;

			AddItem( new Sandals() );

			switch( Utility.RandomMinMax( 0, 2 ) )
			{
				case 0: AddItem( new FancyDress() );	break;
				case 1: AddItem( new GildedDress() );	break;
				case 2: AddItem( new PlainDress() );	break;
			}

			MorphingTime.BlessMyClothes( this );
			MorphingTime.ColorMyClothes( this, GhostHue );
		}

        public override int GetAngerSound()
        {
            return 0x17F;
        }

        public override int GetDeathSound()
        {
            return 0x17F;
        }

        public override int GetHurtSound()
        {
            return 0x17F;
        }

        public override int GetIdleSound()
        {
            return 0x17F;
        }

		public DraculaBride( Serial serial ) : base( serial )
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
		}
	}
}