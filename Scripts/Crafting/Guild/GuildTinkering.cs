using System;
using Server;
using Server.Targeting;
using Server.Mobiles;

namespace Server.Items
{
    public class GuildTinkering : Item
    {
        [Constructable]
        public GuildTinkering() : base(0x1EBB)
        {
            Name = "Tinkers Guild Tools";
			Weight = 5.0;
			Hue = 0x430;
        }

        public GuildTinkering(Serial serial) : base(serial)
		{
		}

        public override void OnDoubleClick( Mobile from )
        {
			if ( from is PlayerMobile )
			{
				int guildmaster = 0;

				foreach ( Mobile m in this.GetMobilesInRange( 20 ) )
				{
					if ( m is TinkerGuildmaster )
						++guildmaster;
				}

				PlayerMobile pc = (PlayerMobile)from;
				if ( pc.NpcGuild != NpcGuild.TinkersGuild )
				{
					from.SendMessage( "Only those of the Tinkers Guild may use this!" );
				}
				else if ( from.Skills[SkillName.Tinkering].Value < 90 )
				{
					from.SendMessage( "Only a master tinker can use this!" );
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
				else if ( item is BaseJewel && !(item is MagicTorch) && !(item is MagicTalisman) && !(item is MagicCandle) && !(item is MagicRobe) && !(item is MagicHat) && !(item is MagicCloak) && !(item is MagicBoots) && !(item is MagicBelt) && !(item is MagicSash) )
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