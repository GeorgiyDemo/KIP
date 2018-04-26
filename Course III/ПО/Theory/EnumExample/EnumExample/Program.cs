using System;
using System.Runtime.InteropServices;
namespace EnumExample
{
    [StructLayout(LayoutKind.Explicit)]
    struct Test
    {
        [FieldOffset(0)] public int a;
        [FieldOffset(4)] public double p;
        [FieldOffset(16)] public int b;
        //Пример конструктора
        public Test(int s=0){
            a = 0;
            b = 0;
            p = 0;
        }
    }

    class Program
    {
        enum Seasons : int { Spring, Summer, Fall, Winter }

        static void Main(string[] args)
        {
            Test t1 = new Test();
            Test t2 = new Test();
            t1 = t2;
            Console.WriteLine(t1.a);

            for (Seasons s = Seasons.Spring; s <= Seasons.Winter; s++)
                Console.WriteLine(s);
        }
    }
}
