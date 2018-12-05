using System;

namespace Delegate4
{
    class Program
    {
        delegate void GetMessage();      // Определили делегат GetMessage()

        static void Main(string[] args)
        {
            if (DateTime.Now.Hour < 12)
            {
                GetMessage mes = new GetMessage(GoodMorning);
                Show_Message(mes);
            }
            else
            {

                GetMessage mes = new GetMessage(GoodEvening);
                Show_Message(mes);
            }
            Console.ReadLine();
        }
        //-------Методы класса Program -----------------------------------
        private static void Show_Message(GetMessage _del)
        { _del.Invoke(); }
        private static void GoodMorning()
        { Console.WriteLine("Good Morning"); }
        private static void GoodEvening()
        { Console.WriteLine("Good Evening"); }
    }

}
