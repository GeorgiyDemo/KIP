using System;

namespace ConsoleApp1
{
    class Program
    {
        delegate void Message();

       static int counter = 0;
        public static void Show()
        {
            counter++;
            Console.WriteLine("Hello World!"+Convert.ToInt32(counter));
        }


        static void Main(string[] args)
        {
            Message mes = new Message(Show);
           mes += Show;
            mes();
            Console.ReadKey();
        }
    }
}
