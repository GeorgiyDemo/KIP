using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Georgiy Demenchuk");
            double x = -20;
            Console.WriteLine("A=");
            double y = 0;
            string a_s = Console.ReadLine();
            double a = Convert.ToDouble(a_s);
            bool flag = false;
            bool flag1 = false;
            double u = 0;
            string osh = "Деление на ноль";
            string osh1 = "Нет решения функциии";
            Console.WriteLine("     __________________________________");
            Console.WriteLine("     |    x      |           y        |");
            for (x = -20; x < 21; x++)
            {
                if (x < 0)
                {
                    y = x * x * Math.Sin(x + a);
                }
                else if (x >= 0)
                {
                    u = Math.Log(x + a);
                    if (u == 0)
                        flag = true;

                    y = x / u;
                    if (Double.IsNaN(y))
                    {
                        flag1 = true;
                    }

                }
                if (flag1)
                {
                    Console.WriteLine("     |    {0,3}    |{1,20}|", Math.Round(x, 2), osh1);
                }
                else if (flag)
                {
                    Console.WriteLine("     |    {0,3}    |{1,20}|", Math.Round(x, 2), osh);
                }
                else
                {
                    Console.WriteLine("     |    {0,3}    |{1,20}|", Math.Round(x, 2), Math.Round(y, 3));
                }

                flag = false;
                flag1 = false;
            }
            Console.WriteLine("     ————————————————————————————————--");
            Console.ReadKey();
        }
    }
}
