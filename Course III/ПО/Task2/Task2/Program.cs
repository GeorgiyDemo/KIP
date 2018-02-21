using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 0;
            Console.Write("Введите число №1 => ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число №2 => ");
            double b = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("1. Умножение\n2. Деление\n3. Вычитание\n4. Сложение");
                n = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine("Результат: ");
                switch (n)
                {
                    case 1:
                        Console.WriteLine(a * b);
                        break;
                    case 2:
                        Console.WriteLine(a / b);
                        break;
                    case 3:
                        Console.WriteLine(a - b);
                        break;
                    case 4:
                        Console.WriteLine(a + b);
                        break;

                }

            }
            while (n != 0);
               
        }
    }
}
