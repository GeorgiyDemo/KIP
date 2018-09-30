using System;

namespace PowerExample
{
    public static class Checker
    {
        public static double PowerCheck(this double a, int power)
        {
            double returner = 1;
            for (int i = 0; i < power; i++)
            {
                returner *= a;
            }
            return returner;
        }
    }

    public class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Введите число");

            double a = System.Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите степень числа");
            int power = System.Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a.PowerCheck(power));
        }
    }
}
