using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StringApp
{
    public class StringClass
    {
        protected string LocalFirstString, LocalSecondString;
        public StringClass(string FirstString, string SecondString)
        {
            LocalFirstString = FirstString;
            LocalSecondString = SecondString;
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
        public string InsertMethod()
        {
            LocalFirstString = LocalFirstString.Insert(0, LocalSecondString);
            return LocalFirstString.Insert(0, LocalSecondString);
        }

        public string IndexOfMethod()
        {
            return LocalFirstString.IndexOf(LocalSecondString[0]).ToString();
        }

        public string CopyToMethod()
        {
            char[] checkarr = LocalSecondString.ToCharArray();
            LocalFirstString.CopyTo(2, checkarr, 4, 3);
            return new string(checkarr);
        }

    }
}
