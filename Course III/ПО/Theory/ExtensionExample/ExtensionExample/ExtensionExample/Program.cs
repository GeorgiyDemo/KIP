using System;

namespace ExtensionExample
{

    static class MyClass{
        public static double Stepen(this double n, int p){
            double result=1.0;
            for (int i = 0; i < p;i++){
                result *= n;
            }
            return result;

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите исходное число => ");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите число для возведения в степень => ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n.Stepen(p));
        }
    }
}
