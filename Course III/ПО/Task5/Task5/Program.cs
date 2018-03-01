using System;

namespace Task5
{
    class Program
    {   


        static void Main(string[] args)
        {
            // Вычисление квадратного корня из P с погрешностью е при начальном приближении x0.
            Console.Write("Введите квадратный корень =>");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите погрешность =>");
            double e = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите начальное приближение =>");
            double x0 = Convert.ToDouble(Console.ReadLine());

            double x = x0; // Шаг 1
            while (true)
            {
                double f = x * x - P;
                if (Math.Abs(f) < e) // Шаги 4, 5
                    break;
                double dx = -f / (2.0 * x); // Шаг 2
                x += dx; // Шаг 3.
            }

            Console.Write("При double: "+x);


            decimal P1 = (decimal) P;
            decimal e1 = (decimal) e;
            decimal x01 = (decimal) x0;

            decimal x1 = (decimal) x0; // Шаг 1
            while (true)
            {
                decimal f1 = x1 * x1 - P1;
                if (Math.Abs(f1) < e1) // Шаги 4, 5
                    break;
                decimal dx1 = -f1 / (2.0m * x1); // Шаг 2
                x1 += dx1; // Шаг 3.
            }

            Console.Write("\nПри decimal: " + x1);
            Console.WriteLine("\nПри помощи Math: "+Math.Sqrt(P));
 
        }
    }
}
