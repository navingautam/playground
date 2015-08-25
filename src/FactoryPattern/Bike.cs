using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Bike : IChoice
    {
        public string Buy()
        {
            return ("You choose Bike");
        }
    }
}
