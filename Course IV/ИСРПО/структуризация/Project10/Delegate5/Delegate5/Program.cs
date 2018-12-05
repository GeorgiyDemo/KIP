using System;

namespace Delegate5
{
    class Program
{ //---пусть есть два метода-----------------------------------
    private static void Hello()
    {Console.WriteLine("Hello");}
    private static void HowAreYou()
    {Console.WriteLine("How are you?");}

//-------Описываем делегат----------------------------------
    delegate void Message();
        delegate string Messa(string x, string y);
 
    static void Main(string[] args)
    {
            Messa mess = (x, y) => String.Concat(x, y);
        Message mes1 = Hello;
        Message mes2 = HowAreYou;
        Message mes3 = mes1 + mes2; // объединяем однотипные делегаты
        mes3(); // вызываются все методы из mes1 и mes2
            Console.WriteLine(mess("Fine, ", "thank you"));
            mes3 -= mes2;
            mes3();
        Console.Read();
    }
    
   }
}


