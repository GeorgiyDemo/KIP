using System;

namespace GenericExample
{
    class Program
    {
        static T max<T> (T a,T b) where T: IComparable
        {
            T max = a;
            if (b.CompareTo(max)>0)
                max = b;
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(max(2,2.3));
        }
    }
}
