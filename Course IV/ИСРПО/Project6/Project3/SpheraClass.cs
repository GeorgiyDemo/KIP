using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class SpheraClass
    {
        double InputR { get; set; }

        public SpheraClass(double OutInputR)
        {
            InputR = OutInputR;
        }

        public string Get1Value()
        {
            return System.Convert.ToString((4 / 3) * Math.PI * Math.Pow(System.Convert.ToDouble(InputR), 3));
        }

        public string Get2Value()
        {
            return System.Convert.ToString(4 * Math.PI * Math.Pow(System.Convert.ToDouble(InputR), 2));
        }
         
    }
}
