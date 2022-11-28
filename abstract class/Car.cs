using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    internal class Car:Vehicle
    {
        byte Doorcount;
        public int doorcount { get=>doorcount; set=>value=doorcount; }
        public int OilCapacity { get; set; }
        public int vCurrentOil { get; set; }
        public int FuelType { get; set; }
        
       
    }
}
