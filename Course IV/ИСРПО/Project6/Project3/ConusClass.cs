using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class ConusClass
    {
        double InputR1 { get; set; }
        double InputH1 { get; set; }
        double InputL1 { get; set; }

        public ConusClass(string InputRString, string InputHString, string InputLString)
        {
            InputR1 = Convert.ToDouble(InputRString);
            InputH1 = Convert.ToDouble(InputHString);
            InputL1 = Convert.ToDouble(InputLString);
        }

        public string Get1Value()
        {
            return Convert.ToString(Math.Round(InputH1 * 1 / 3 * Math.PI * Math.Pow(InputR1, 2), 3));
        }

        public string Get2Value()
        {
            return Convert.ToString(Math.Round(Math.PI * InputR1 * InputR1, 3));
        }

        public string Get3Value()
        {
            return Convert.ToString(Math.Round(Math.PI * InputR1 * InputL1, 3));
        }

        public string Get4Value()
        {
            return Convert.ToString(Math.Round(Math.PI * InputR1 * (InputR1 + InputL1), 3));
        }
    }

}
