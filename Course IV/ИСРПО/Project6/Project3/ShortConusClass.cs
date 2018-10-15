using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class ShortConusClass
    {

        double InputR1, Inputr1, InputH1, InputL1;

        public ShortConusClass(double InputR, double Inputr, double InputH, double InputL)
        {
            InputR1 = InputR;
            Inputr1 = Inputr;
            InputH1 = InputH;
            InputL1 = InputL;

        }

        public string Get1Value()
        {
            return Convert.ToString(Math.Round(Math.PI * InputR1 * InputR1, 3));
        }

        public string Get2Value()
        {
            return Convert.ToString(Math.Round(Math.PI * Inputr1 * Inputr1, 3));
        }

        public string Get3Value()
        {
            return Convert.ToString(Math.Round(Math.PI * InputL1 * (Inputr1 + InputR1) + Math.PI * Math.Pow(InputR1, 2) + Math.PI * Math.Pow(Inputr1, 2), 3));
        }

        public string Get4Value()
        {
            return Convert.ToString(Math.Round(InputH1 * 1 / 3 * Math.PI * (Math.Pow(Inputr1, 2) + Math.Pow(InputR1, 2) + Inputr1 * InputR1), 3));
        }

        public string GetVValue()
        {
            return Convert.ToString(Math.Round(Math.PI * InputL1 * (Inputr1 + InputR1), 3));
        }

    }
}
