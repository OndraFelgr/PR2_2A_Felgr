using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class Wepon : Item
    {
    

        public int DMG { get; private init; }
        public int Attack { get; private init; }
        public bool IsTwoHand { get; private init; }

        

        public Wepon(string name, int weight, int dMG, int attack, bool isTwoHand) : base(name, weight)
        {
            DMG = dMG;
            Attack = attack;
            IsTwoHand = isTwoHand;
        }
    }
}
