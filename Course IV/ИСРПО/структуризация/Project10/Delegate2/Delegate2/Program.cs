using System;

namespace Delegate2
{
    delegate T Operation<T, K>(K val);

    class Program
    {
        static void Main(string[] args)
        {
            Operation<decimal, int> op = Square;

            Console.WriteLine(op(5));
            Console.Read();
        }

        static decimal Square(int n)
        {
            return n * n;
        }

    }
}
