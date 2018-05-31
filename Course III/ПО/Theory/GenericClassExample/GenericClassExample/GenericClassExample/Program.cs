using System;
namespace GenericClassExample
{

    public class meow<T> where T: IComparable<T>
    {
        public void add(T item1, T item2)
        {
            T result = (dynamic)item1 + item2;
            Console.WriteLine(result);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            meow<int> meow_obj = new meow<int>();
            meow_obj.add(1, 2);

            meow<string> meow_obj1 = new meow<string>();
            meow_obj1.add("MEOW", "KOT");
        }
    }
}
