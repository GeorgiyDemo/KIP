using System;

namespace DeligateExample
{
    delegate void Del1(int a, double b);

    class Program
    {
        static void summ(int a, double b)
        {
            Console.WriteLine("Сумма = {0}", a + b);
        }

        static void summ2(int a, double b)
        {
            Console.WriteLine("Сумма2 = {0}", a + b + 2);
        }

        static void summ3(int a, double b)
        {
            Console.WriteLine("Сумма3 = {0}", a + b + 3);
        }

        static void Main(string[] args)
        {

            Del1 de1 = null;
            de1 += summ;
            de1 += summ2;
            de1 += summ3;
            de1(1, 3.5);
        }
    }
}