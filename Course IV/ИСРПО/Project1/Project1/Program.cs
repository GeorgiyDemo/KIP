using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.Write("Введите a -> ");
            double a = System.Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x          |         y");

            for (int i = -20; i < 21; i++)
                if ((i >= -20) && (i <= 20))
                    Console.WriteLine(i.ToString()+ "           |          "+Convert.ToString(Math.Round(Checker(i, a),4)));
            Console.ReadKey();
        }

        static public double Checker(double x, double a)
        {
            if (x < 0)
                return x * x * Math.Sin(x + a);
            else if (x >= 0)
                return x / Math.Log(x + a);
            return 0;

        }
    }
}