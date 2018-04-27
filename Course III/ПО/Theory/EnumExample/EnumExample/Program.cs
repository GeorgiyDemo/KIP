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
       
        public Test(int s = 0, int a1 = 0)
        {
            a = a1;
            b = s;
            p = 0;
        }

        public Test(int m=1): this(0,0){
        }

        public void Show(){

            Console.WriteLine("------------\na: "+a+"\nb: "+b+"\np: "+p);

        }

      

    }

    class Program
    {
        enum Seasons : int { Season, Season1, Season2, Season3 };
        enum Brat : long { brat, brat1, brat2, brat3, brat4 };
        enum Meow : byte { meow, meow228, Meow };
        enum WOW : sbyte { WOW, BMW1, BMW2, BMW3, BMW4, BMW5, BMW6, W0W};
        enum Groups : ulong { PKS115, PKS215, PKS315 };


        static void Main()
        {
            Console.WriteLine("Seasons\n");
            for (Seasons s = Seasons.Season; s <= Seasons.Season3; s++)
                Console.WriteLine(s);
            Console.WriteLine("BRAT\n");

            for (Brat b = Brat.brat; b <= Brat.brat4; b++)
                Console.WriteLine(b);

            for (Meow meow = Meow.meow; meow <= Meow.Meow; meow++)
                Console.WriteLine(meow);

            for (WOW WOW = WOW.WOW; WOW <= WOW.W0W; WOW++)
                Console.WriteLine(WOW);

            for (Groups group = Groups.PKS115; group <= Groups.PKS315; group++)
                Console.WriteLine(group);

            Test MyStruct_obj = new Test();
            MyStruct_obj.a = 2;
            MyStruct_obj.p = 2.5;
            MyStruct_obj.b = 5;

            MyStruct_obj.Show();



        }
    }
}
