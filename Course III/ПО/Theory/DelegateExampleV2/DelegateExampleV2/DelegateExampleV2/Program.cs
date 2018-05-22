using System;

namespace DelegateExampleV2
{
    class Program
    {
        public delegate void dell(int x, double y);
        static void Shower(dell del)
        {
            Console.WriteLine(" ***Вызов метода Show***\n");
            del(14, 8.8);
        }

        static void Main(string[] args)
        {
            dell DELEGAT_BRO = (int x, double y) =>
            {
                x++;
                y--;
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y + "\n");
            };

            DELEGAT_BRO += (int x, double y) =>
            {
                x += 8;
                y -= 12;
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y + "\n");
            };


            DELEGAT_BRO += (int x, double y) =>
            {
                x += 9;
                y /= 7;
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y + "\n");
            };

            Shower(DELEGAT_BRO);
        }
    }
}