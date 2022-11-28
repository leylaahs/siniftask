using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    internal abstract  class Vehicle
    {
        int _drivetime;
        int _drivepath;
       public int drivetime
        {
            get => drivetime; set
            {
                if (value > 0)

                {
                    drivetime = value;
                }
            }
        }
         public int drivepath { get => drivepath; set
            {
                if (value > 0)
                {
                    drivepath = value;
                }
            } 
        } 
     
    }
}
