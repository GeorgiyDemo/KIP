using System;

namespace EnumExample
{
    class Program
    {
        enum Seasons : int { Spring, Summer, Fall, Winter }

        static void Main(string[] args)
        {
            for (Seasons s = Seasons.Spring; s <= Seasons.Winter; s++)
                Console.WriteLine(s);
        }
    }
}
