using System;

namespace DelegateGenericExample
{
    class Program
    {
        static void Plus<T>( T a, T b)
        {
            T c = (dynamic) a + b;
            Console.WriteLine(c);

        }
        static void Main(string[] args)
        {
            
            Plus("GENA", "_KIRILL");
            Plus(6, 8);
        }
    }
}
