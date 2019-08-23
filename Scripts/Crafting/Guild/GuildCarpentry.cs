using System;
using Server;
using Server.Targeting;
using Server.Mobiles;

namespace Server.Items
{
    public class GuildCarpentry : Item
    {
        [Constructable]
        public GuildCarpentry() : base(0x1EBA)
        {
            Name = "Carpenters Guild Tools";
			Weight = 5.0;
			Hue = 0x430;
        }

        public GuildCarpentry(Serial serial) : base(serial)
		{
		}

        public override void OnDoubleClick( Mobile from )
        {
			if ( from is PlayerMobile )
			{
				int guildmaster = 0;

				foreach ( Mobile m in this.GetMobilesInRange( 20 ) )
				{
					if ( m is CarpenterGuildmaster )
						++guildmaster;
				}

				PlayerMobile pc = (PlayerMobile)from;
				if ( pc.NpcGuild != NpcGuild.CarpentersGuild )
				{
					from.SendMessage( "Only those of the Carpenters Guild may use this!" );
				}
				else if ( from.Skills[SkillName.Carpentry].Value < 90 )
				{
					from.SendMessage( "Only a master carpenter can use this!" );
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
				else if ( item is BaseWeapon && !(item is BaseRanged) )
				{
					BaseWeapon weapon = (BaseWeapon)item;

					if ( (   weapon.Resource == CraftResource.RegularWood )
						|| ( weapon.Resource == CraftResource.AshTree )
						|| ( weapon.Resource == CraftResource.CherryTree )
						|| ( weapon.Resource == CraftResource.EbonyTree )
						|| ( weapon.Resource == CraftResource.GoldenOakTree )
						|| ( weapon.Resource == CraftResource.HickoryTree )
						|| ( weapon.Resource == CraftResource.MahoganyTree )
						|| ( weapon.Resource == CraftResource.OakTree )
						|| ( weapon.Resource == CraftResource.PineTree )
						|| ( weapon.Resource == CraftResource.RosewoodTree )
						|| ( weapon.Resource == CraftResource.WalnutTree ) )
					{
						GuildCraftingProcess process = new GuildCraftingProcess(from, (Item)obj);
						process.BeginProcess();
					}
					else
					{
						from.SendMessage( "You cannot enhance this item!" );
					}
				}
				else if ( item is BaseArmor )
				{
					BaseArmor armor = (BaseArmor)item;

					if ( (   armor.Resource == CraftResource.RegularWood )
						|| ( armor.Resource == CraftResource.AshTree )
						|| ( armor.Resource == CraftResource.CherryTree )
						|| ( armor.Resource == CraftResource.EbonyTree )
						|| ( armor.Resource == CraftResource.GoldenOakTree )
						|| ( armor.Resource == CraftResource.HickoryTree )
						|| ( armor.Resource == CraftResource.MahoganyTree )
						|| ( armor.Resource == CraftResource.OakTree )
						|| ( armor.Resource == CraftResource.PineTree )
						|| ( armor.Resource == CraftResource.RosewoodTree )
						|| ( armor.Resource == CraftResource.ElvenTree )
						|| ( armor.Resource == CraftResource.WalnutTree ) )
					{
						GuildCraftingProcess process = new GuildCraftingProcess(from, (Item)obj);
						process.BeginProcess();
					}
					else
					{
						from.SendMessage( "You cannot enhance this item!" );
					}
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