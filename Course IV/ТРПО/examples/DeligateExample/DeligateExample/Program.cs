using System;

namespace Delegate
{
    delegate void FirstDelegate();
    delegate void SecondDelegate(string zz);
    class Program
    {
        private static void DelWithConstr()
        {
            Console.WriteLine("Делагат с конструктором");
        }
        public static void DelWithOutConstructor(string zz)
        {
            Console.WriteLine("Делагат без конструктора " + zz);
        }
        static void Main(string[] args)
        {
            string zz = Console.ReadLine();
            FirstDelegate del = new FirstDelegate(DelWithConstr);
            del();
            SecondDelegate del2 = zz1 => DelWithOutConstructor(zz);
            del2(zz);
            Console.ReadKey();
        }
    }
}
