using System;
using Server;
using Server.Targeting;
using Server.Mobiles;

namespace Server.Items
{
    public class GuildSewing : Item
    {
        [Constructable]
        public GuildSewing() : base(0xF9D)
        {
            Name = "Tailors Guild Sewing Kit";
			Weight = 2.0;
			Hue = 0x430;
        }

        public GuildSewing(Serial serial) : base(serial)
		{
		}

        public override void OnDoubleClick( Mobile from )
        {
			if ( from is PlayerMobile )
			{
				int guildmaster = 0;

				foreach ( Mobile m in this.GetMobilesInRange( 20 ) )
				{
					if ( m is TailorGuildmaster )
						++guildmaster;
				}

				PlayerMobile pc = (PlayerMobile)from;
				if ( pc.NpcGuild != NpcGuild.TailorsGuild )
				{
					from.SendMessage( "Only those of the Tailors Guild may use this!" );
				}
				else if ( from.Skills[SkillName.Tailoring].Value < 90 )
				{
					from.SendMessage( "Only a master tailor can use this!" );
				}
				else if ( guildmaster == 0 )
				{
					from.SendMessage( "You need to be near your guildmaster to use this!" );
				}
				else
				{
					from.SendMessage("Select the equipment you would like to enhance...");
					from.BeginTarget(-1, false, TargetFlags.None, new TargetCallback(OnTarget));
				}
			}
        }

        public void OnTarget(Mobile from, object obj)
        {
            if ( obj is Item )
            {
				Item item = (Item)obj;

                if (((Item)obj).RootParent != from)
                {
                    from.SendLocalizedMessage(1042001); // That must be in your pack for you to use it.
                }
				else if ( item is ILevelable )
				{
					from.SendMessage( "You cannot enhance legendary artifacts!" );
				}
				else if ( item is BaseJewel && ( item is MagicRobe || item is MagicHat || item is MagicCloak || item is MagicBoots || item is MagicBelt || item is MagicSash ) )
				{
					GuildCraftingProcess process = new GuildCraftingProcess(from, (Item)obj);
					process.BeginProcess();
				}
				else if ( item is BaseWeapon && ( item is ThrowingGloves || item is PugilistGlove || item is PugilistGloves || item is PugilistMits ) )
				{
					GuildCraftingProcess process = new GuildCraftingProcess(from, (Item)obj);
					process.BeginProcess();
				}
				else if ( item is BaseArmor )
				{
					BaseArmor armor = (BaseArmor)item;

					if ( Server.Misc.MaterialInfo.IsAnyKindOfClothItem( item ) )
                    {
						GuildCraftingProcess process = new GuildCraftingProcess(from, (Item)obj);
						process.BeginProcess();
					}
					else
					{
						from.SendMessage( "You cannot enhance this item!" );
					}
				}
				else if ( item is BaseClothing )
				{
					GuildCraftingProcess process = new GuildCraftingProcess(from, (Item)obj);
					process.BeginProcess();
				}
                else
                {
					from.SendMessage( "You cannot enhance this item!" );
                }
            }
        }
        
        public override void Serialize(GenericWriter writer)
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