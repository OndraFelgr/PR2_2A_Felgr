using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class Character
    {
        public string Name { get; private init; }
        public int Health { get; private set; }
        public int MaxHealth { get; private init; }
        public int MaxWeight { get; private init; }
        public int CarryWeight
        {
            get
            {
                return
                    inventory.TotalWeight
                    + ((LeftHand.Weight != null) ? LeftHand.Weight : 0
                    + RightHand.Weight ?? 
                    + Wearing.Weight;

            }
        }

        private Inventoryy inventory = new Inventoryy();

        public Item? RightHand = null;
        public Item? LeftHand = null;
        public Armor? Wearing = null;

        public Character(string name, int maxHealth, int maxWeight)
        {
            MaxWeight = maxWeight;
            Name = name;
            MaxHealth = maxHealth;
        }

        public void Take(Item item)
        {
            inventory.Take(item);
        }
    }
}
