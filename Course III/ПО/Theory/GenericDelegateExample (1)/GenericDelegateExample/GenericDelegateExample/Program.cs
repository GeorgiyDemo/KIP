using System;

namespace GenericDelegateExample
{


    class Program
    {

        static void Main(string[] args)
        {
            int i;
            Action<int> first = null;
            Func<int, int> second = null;

            first += (x) => Console.WriteLine("first = {0}", x++);
            first += (x) => Console.WriteLine("meme = {0}", x -= 8);

            second = (x) => {
                Console.WriteLine("second = {0}, {0}", x -= 15);
                return x;
            };

            second += (x) => {
                Console.WriteLine("second = {0}, {0}", x -= 15);
                return x;
            };

            first(6);
            i = (int) second(7);
            Console.WriteLine("i={0}", i);

        }
    }
}
