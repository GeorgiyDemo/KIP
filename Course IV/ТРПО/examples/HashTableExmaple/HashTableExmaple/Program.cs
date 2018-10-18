using System;
using System.Collections;
namespace HashTableExmaple
{


    class Program
    {

        public static SortedList SortGenerator()
        {
            SortedList s = new SortedList();
            s.Add("ОДИН", "1");
            s.Add("ДВАДВАДЕВЯТЬ", "229");
            s.Add("ДВА", "2");
            s.Add("ТРИ", "3");
            s.Add("ЧЕТЫРЕ", "4");
            s.Add("ПЯТЬ", "5");
            s.Add("ШЕСТЬ", "6");
            s.Add("СЕМЬ", "7");
            s.Add("ВОСЕМЬ", "8");
            s.Add("ДЕВЯТЬ", "9");
            s.Add("НОЛЬ", "0");

            s.RemoveAt(1);

            return s;
        }
        public static Hashtable HashGenerator()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("1", "ОДИН");
            hashtable.Add("2", "ДВА");
            hashtable.Add("3", "ТРИ");
            hashtable.Add("4", "ЧЕТЫРЕ");
            hashtable.Add("5", "ПЯТЬ");
            hashtable.Add("6", "ШЕСТЬ");
            hashtable.Add("7", "СЕМЬ");
            hashtable.Add("8", "ВОСЕМЬ");
            hashtable.Add("9", "ДЕВЯТЬ");
            hashtable.Add("0", "НОЛЬ");

            hashtable.Add("213", "ДВЕСТИТРИНАДЦАТЬ");
            hashtable.Remove("213");
            return hashtable;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число -> ");
            string bufstr = Console.ReadLine();
            for (int i = 0; i < bufstr.Length; i++)
                Console.Write(SortGenerator()[HashGenerator()[bufstr[i].ToString()]]);
            Console.WriteLine("\n|" + HashGenerator()["213"] + "|");
            Console.WriteLine("\n|" + SortGenerator()["ДВАДВАДЕВЯТЬ"] + "|");
        }
    }
}
