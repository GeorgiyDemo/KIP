using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите строку => ");
            string meow = Console.ReadLine();
            Console.Write("Введите число => ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
                Console.WriteLine(Convert.ToString(i + 1) + " " + meow);
        }
    }
}
