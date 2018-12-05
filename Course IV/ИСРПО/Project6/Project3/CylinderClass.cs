using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class CylinderClass
    {
        double InputR1 { get; set; }
        double InputH1 { get; set; }

        public CylinderClass(double InputR, double InputH)
        {
            InputR1 = InputR;
            InputH1 = InputH;
        }

        public string Get1Value()
        {
            return Convert.ToString(Math.Round(2 * Math.PI * InputR1 * InputH1, 3));
        }

        public string Get2Value()
        {
            return Convert.ToString(Math.Round(2 * Math.PI + 2 * Math.PI * Math.Round(InputR1, 2), 3));
        }

        public string Get3Value()
        {
            return Convert.ToString(Math.Round(InputH1 * Math.PI * Math.Round(InputR1, 2), 3));
        }

    }
}
