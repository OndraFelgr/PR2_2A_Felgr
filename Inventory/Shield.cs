using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class Shield : DefItem
    {
        public Shield(int defence, string name, int weight) : base(defence, name, weight)
        {
        }
    }
}
