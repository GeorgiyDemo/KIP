using System;

namespace DeligateExample
{
    delegate void Del1();
    delegate void Del2(int a);

    class Program
    {
        static void summ(int a)
        {
            Console.WriteLine("Сумма = {0}", a + a);
        }

        static void summ2(int a)
        {
            Console.WriteLine("Сумма2 = {0}", a + a + 1);
        }

        static void summ3(int a)
        {
            Console.WriteLine("Сумма3 = {0}", a + a + 2);
        }

        static void Main()
        {
            //Del1 de1 = new Del1();

            Del2 de2 = null;
            de2 += summ;
            de2 += summ2;
            de2 += summ3;
            de2(1);
        }
    }
}