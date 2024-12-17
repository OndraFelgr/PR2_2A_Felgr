using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal abstract class DefItem :Item
    {
        protected DefItem(int defence, string name, int weight) : base(name, weight)
        {
            Defence = defence;
        }

        public int Defence { get; private init; }


    }
}
