using System;
using Server;
using Server.Targeting;

namespace Server.Items
{
	[FlipableAttribute( 0x1db9, 0x1dba )]
	public class LeatherCap : BaseArmor
	{
		public override int BasePhysicalResistance{ get{ return 2; } }
		public override int BaseFireResistance{ get{ return 4; } }
		public override int BaseColdResistance{ get{ return 3; } }
		public override int BasePoisonResistance{ get{ return 3; } }
		public override int BaseEnergyResistance{ get{ return 3; } }

		public override int InitMinHits{ get{ return 30; } }
		public override int InitMaxHits{ get{ return 40; } }

		public override int AosStrReq{ get{ return 20; } }
		public override int OldStrReq{ get{ return 15; } }

		public override int ArmorBase{ get{ return 13; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Leather; } }
		public override CraftResource DefaultResource{ get{ return CraftResource.RegularLeather; } }

		public override ArmorMeditationAllowance DefMedAllowance{ get{ return ArmorMeditationAllowance.All; } }

		[Constructable]
		public LeatherCap() : base( 0x1DB9 )
		{
			Weight = 2.0;
		}

		public override void OnDoubleClick( Mobile from )
		{
			if ( this.ItemID == 0x3176 || this.ItemID == 0x3177 || this.ItemID == 0x2B71 || this.ItemID == 0x3168 )
			{
				if ( from.FindItemOnLayer( Layer.Helm ) != this )
				{
					from.SendMessage( "You must be wearing this to change the color." );
				}
				else
				{
					Target t;

					from.SendMessage( "What worn item do you wish to match the color of?" );
					t = new HatTarget( this );
					from.Target = t;
				}
			}
        }

		private class HatTarget : Target
		{
			private Item m_Hats;

			public HatTarget( Item cowl ) : base( 1, false, TargetFlags.None )
			{
				m_Hats = cowl;
			}

			protected override void OnTarget( Mobile from, object targeted )
			{
				if ( targeted is Item )
				{
					Item iColorHat = targeted as Item;

					int color = 0;

					if ( from.FindItemOnLayer( Layer.Helm ) != m_Hats ) { from.SendMessage( "You must be wearing this to change the color." ); }
					else if ( from.FindItemOnLayer( Layer.Waist ) == iColorHat ) { color = iColorHat.Hue; }
					else if ( from.FindItemOnLayer( Layer.OuterTorso ) == iColorHat ) { color = iColorHat.Hue; }
					else if ( from.FindItemOnLayer( Layer.Arms ) == iColorHat ) { color = iColorHat.Hue; }
					else if ( from.FindItemOnLayer( Layer.OuterLegs ) == iColorHat ) { color = iColorHat.Hue; }
					else if ( from.FindItemOnLayer( Layer.Neck ) == iColorHat ) { color = iColorHat.Hue; }
					else if ( from.FindItemOnLayer( Layer.Gloves ) == iColorHat ) { color = iColorHat.Hue; }
					else if ( from.FindItemOnLayer( Layer.Shoes ) == iColorHat ) { color = iColorHat.Hue; }
					else if ( from.FindItemOnLayer( Layer.Cloak ) == iColorHat ) { color = iColorHat.Hue; }
					else if ( from.FindItemOnLayer( Layer.FirstValid ) == iColorHat ) { color = iColorHat.Hue; }
					else if ( from.FindItemOnLayer( Layer.InnerLegs ) == iColorHat ) { color = iColorHat.Hue; }
					else if ( from.FindItemOnLayer( Layer.InnerTorso ) == iColorHat ) { color = iColorHat.Hue; }
					else if ( from.FindItemOnLayer( Layer.Pants ) == iColorHat ) { color = iColorHat.Hue; }
					else if ( from.FindItemOnLayer( Layer.Shirt ) == iColorHat ) { color = iColorHat.Hue; }
					else
					{
						from.SendMessage( "You can only match colors of certain equipped items." );
					}

					if ( color > 0 )
					{
						m_Hats.Hue = color;
						from.SendMessage( "You change the color to match the item." );
					}
					else
					{
						from.SendMessage( "Items selected must have a distinct color." );
					}
				}
				else
				{
					from.SendMessage( "You can only match color of certain equipped items that have distinct colors." );
				}
			}
		}

		public LeatherCap( Serial serial ) : base( serial )
		{
		}
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();

			if ( Weight == 1.0 )
				Weight = 2.0;
		}
	}
}