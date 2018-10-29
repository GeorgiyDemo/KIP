using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    public class StringClass
    {
        protected string LocalFirstString, LocalSecondString;
        public StringClass(string FirstString, string SecondString)
        {
            LocalFirstString = FirstString;
        }

        public string ToUpperMethod()
        {
            return (LocalFirstString + " " +LocalSecondString).ToUpper();
        }

        public string ToLowerMethod()
        {
            return (LocalFirstString + " " + LocalSecondString).ToLower();
        }

        public string SubstringTrimrMethod()
        {
            return LocalFirstString.IndexOf(LocalSecondString).ToString();
        }

        public string SplitMethod()
        {
            string outstr = "";
            string [] bufstrarr = LocalFirstString.Split(LocalSecondString[0]);
            for (int i = 0; i < bufstrarr.GetLength(0); i++)
                outstr += (i + 1).ToString() + " -> [" + bufstrarr[i] + "]\n";
            return outstr;
        }

        public string JoidMethod()
        {
            string outstr = "";
            string[] bufstrarr = LocalFirstString.Split(LocalSecondString[0]);
            for (int i = 0; i < bufstrarr.GetLength(0); i++)
                outstr += (i + 1).ToString() + " -> [" + bufstrarr[i] + "]\n";
            outstr += "\bРезультат: "+string.Join(",", bufstrarr);

            return outstr;
        }

        public string ReplaceMethod()
        {
            return LocalFirstString.Replace(LocalSecondString[0], '-');
        }


    }
}
