using System;

namespace Delegate3
{
    class Program
    {
        private static void Hello() { Console.WriteLine("Hello"); }
        private static int Add(int x, int y) { return x + y; }

        //----- Пусть определены два делегата ---------------------------
        delegate int Operation(int x, int y);
        delegate void Message();
        //----------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            Message mes = Hello;     //Создали переменную делегата Message
            mes.Invoke();            // Вызвали делегата
            Operation op = Add;      //Создали переменную делегата Operation
            Console.WriteLine(op.Invoke(3, 4).ToString());         // Вызвали делегата
            Console.Read();
        }
    }

}
