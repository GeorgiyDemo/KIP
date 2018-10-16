using System;
//Из параллельного потока вывести с задержкой
using System.Threading;
namespace AsyncApp
{
    class Program
    {
        public delegate int DisplayHandler();

        static void Main(string[] args)
        {
            DisplayHandler handler = new DisplayHandler(MEOW);
            handler.BeginInvoke(null, null);

            Console.WriteLine("Продолжается работа метода Main");

            Console.ReadLine();
        }

        static int MEOW()
        {
            Console.WriteLine("Начинается работа метода Display....");

            int result = 0;
            for (int i = 1; i < 10; i++)
            {
                result += i * i;
            }
            Thread.Sleep(3000);
            Console.WriteLine("Завершается работа метода Display....");
            return result;
        }

        static void HandleDisplayHandler()
        {
        }

    }
}
