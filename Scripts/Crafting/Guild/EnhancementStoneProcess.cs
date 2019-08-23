using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Server.Gumps;

namespace Server.Items
{
    public class GuildCraftingProcess
    {
        private int BaseCost = 30;
        private bool AttrCountAffectsCost = true;
        public int MaxAttrCount = 10;

        public Mobile Owner = null;
        public Item ItemToUpgrade = null;
        public int CurrentAttributeCount = 0;

        public GuildCraftingProcess(Mobile from, Item target)
        {
            Owner = from;
            ItemToUpgrade = target;
        }

        public void BeginProcess()
        {
            CurrentAttributeCount = 0;

            if (!(ItemToUpgrade is BaseShield || ItemToUpgrade is BaseClothing || ItemToUpgrade is BaseArmor || ItemToUpgrade is BaseWeapon || ItemToUpgrade is BaseJewel || ItemToUpgrade is Spellbook))
            {
                Owner.SendMessage("This cannot be enhanced.");
            }
            else
            {
                int MaxedAttributes = 0;

                foreach (AttributeHandler handler in AttributeHandler.Definitions)
                {
                    int attr = handler.Upgrade(ItemToUpgrade, true);
                    
                    if (attr > 0)
                        CurrentAttributeCount++;

                    if (attr >= handler.MaxValue)
                        MaxedAttributes++;
                }

                if (CurrentAttributeCount > MaxAttrCount || MaxedAttributes >= MaxAttrCount)
                    Owner.SendMessage("This piece of equipment cannot be enhanced any further.");
                else
                    Owner.SendGump(new EnhancementGump(this));
            }
        }

        public void BeginUpgrade(AttributeHandler handler)
        {
            if (SpendGold(GetCostToUpgrade(handler)))
            {
                handler.Upgrade(ItemToUpgrade, false);
                BeginProcess();
            }
        }

        private bool SpendGold(int amount)
        {
            bool bought = (Owner.AccessLevel >= AccessLevel.GameMaster);
            bool fromBank = false;

            Container cont = Owner.Backpack;
            if (!bought && cont != null)
            {
                if (cont.ConsumeTotal(typeof(Gold), amount))
                    bought = true;
                else
                {
                    cont = Owner.FindBankNoCreate();
                    if (cont != null && cont.ConsumeTotal(typeof(Gold), amount))
                    {
                        bought = true;
                        fromBank = true;
                    }
                    else
                    {
                        Owner.SendLocalizedMessage(500192);
                    }
                }
            }

            if (bought)
            {
                if (Owner.AccessLevel >= AccessLevel.GameMaster)
                    Owner.SendMessage("{0} gold would have been withdrawn from your bank if you were not a GM.", amount);
                else if (fromBank)
                    Owner.SendMessage("The total of your purchase is {0} gold, which has been withdrawn from your bank account.  My thanks for your patronage.", amount);
                else
                    Owner.SendMessage("The total of your purchase is {0} gold.  My thanks for your patronage.", amount);
            }

			Owner.PlaySound( 0x2A );
			Owner.Animate( 32, 5, 1, true, false, 0 );
            return bought;
        }

        public int GetCostToUpgrade(AttributeHandler handler)
        {
            int attrMultiplier = 1;

            if (AttrCountAffectsCost)
            {
                foreach (AttributeHandler h in AttributeHandler.Definitions)
                    if (h.Name != handler.Name && h.Upgrade(ItemToUpgrade, true) > 0)
                        attrMultiplier++;
            }

            decimal cost = 0;

            int max = handler.MaxValue / handler.IncrementValue;
            int level = handler.Upgrade(ItemToUpgrade, true) / handler.IncrementValue;

            decimal currentLevel = 20M / max * level;
            decimal nextLevel = 20M / max * (level + 1);

            int loopCurrentLevel = (int)currentLevel;
            int loopNextLevel = (int)nextLevel;

            for (int i = loopCurrentLevel; i < loopNextLevel; i++)
            {
                if (i == loopCurrentLevel && loopCurrentLevel != currentLevel)
                {
                    decimal multiplier = i + 1 - (currentLevel - (decimal)loopCurrentLevel);
                    multiplier = multiplier * multiplier;
                    cost += multiplier * BaseCost;
                }
                else if (i == loopNextLevel - 1 && loopNextLevel != nextLevel)
                {
                    decimal multiplier = nextLevel;
                    multiplier = multiplier * multiplier;
                    cost += multiplier * BaseCost;
                }
                else
                    cost += (i + 1) * (i + 1) * BaseCost;
            }

            cost = cost * attrMultiplier;

            return (int)cost;
        }
    }
}