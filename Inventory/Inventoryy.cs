using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class Inventoryy
    {
       private List<Item> items = new List<Item>();

        public int TotalWeight
        {
            get
            {
                int weight = 0;
                foreach (Item i in items)
                {
                    weight += i.Weight;
                }
                return weight;
            }
        }
        public void Take(Item item)
        {
            if(items.Contains(item))
            {
                return;
            }    
            items.Add(item);

        }

        public void Drop(Item item)
        {
            items.Remove(item);
        }

    }
}
