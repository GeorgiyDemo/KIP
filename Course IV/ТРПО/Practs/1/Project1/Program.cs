using System;
using System.Text;
using System.Windows;
namespace Project1
{
    class Program
    {
        static public string Checker(double x, double y)
        {
            StringBuilder str = new StringBuilder();
            try
            { 
            if (y == 0)
                throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Делитель равно нулю, все печально");
            }

            try
            {
                if ((int)x > 100)
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Первый аргумент x больше 100!");
            }

            str.Append("Сложение: " + System.Convert.ToString(x + y));
            str.Append("\nВычитание: "+ System.Convert.ToString(x - y));
            str.Append("\nУмножение: " + System.Convert.ToString(x * y));
            str.Append("\nДеление: " + System.Convert.ToString(x / y));

            return str.ToString();


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите аргумент x:");
            double x = System.Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите аргумент y:");
            double y = System.Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Checker(x, y));

            Console.ReadKey();
        }
    }
}
