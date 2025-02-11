using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal interface Interface1
    {
        int Count { get; }
        void Add(Coords place);
            Coords NextPlace();
    }
}
