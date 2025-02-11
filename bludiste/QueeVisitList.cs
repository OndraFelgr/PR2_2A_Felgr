using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class QueeVisitList : Interface1
    {
        Queue<Coords> _quee = [];
        public int Count => _quee.Count();

        public void Add(Coords place)
        {
            _quee.Enqueue(place);
        }

        public Coords NextPlace()
        {
           return _quee.Dequeue();
        }
    }
}
