using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Car
    {
        public int Id { get; set; }
        public int Plate { get; set; }
        public int Model { get; set; }
        public int Brand { get; set; }
        public DataTime Purchase { get; set; }
    }
}
