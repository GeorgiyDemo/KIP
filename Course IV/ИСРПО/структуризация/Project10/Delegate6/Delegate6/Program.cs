using System;

namespace Delegate6
{
    using System;
    using My;

    class Program
    {
        public static void Main(string[] args)
        {
            string S = "#######################";
            First Ob = new First(S);     //------ Создаем объект БАЗОВОГО класса---------------

            //--- Создаем делегат с привязкой к конкретной функции - fun1 через объект Ob
            Del Od = new Del(Ob.fun1);
            Od();   // Вызов делегата (работает функция fun1)

            Od = new Del(Ob.Report); // Перевод Od на функцию Report
            Od(); // Будет отрабатывать функция Report

            //---- Меняем содержание строки S--------------------------
            S = "****************************";

            //---- Создаем новый объект базового класса ---------------
            First Ob1 = new First(S); // Конструктор работает уже с новой строкой


            Od = new Del(Ob1.fun2);    //--- Привязка делегата к функции fun2 через объект Ob1 
            Od(); // Вызов функции fun2

            Od = new Del(Ob1.Report); // Привязка делегата к функции Report через объект Ob1
            Od(); // Вызов функции Report

            Od = new Del(Ob1.fun3);// Привязка делегата к функции fun3
            Od(); // Вызов функции fun3

            Od = new Del(Ob1.Report); // Перевод делегата опять на Report
            Od(); // Вызов функции Report

            Del OdS = new Del(First.funStatic);  // Привязка делегата к статической функции базового класса
            OdS(); // Работает статическая функция

            Console.WriteLine("\n\n");

            S = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
            Second ObSecond = new Second(S); // Создаем объект производного класса

            //------ Создаем делегат на основе объекта производного класса с привязкой к fun5 ------
            Del OdSecond = new Del(ObSecond.fun5);
            OdSecond(); // Вызов делегата

            OdSecond = new Del(ObSecond.Report);
            OdSecond();

            OdSecond = new Del(ObSecond.fun1);
            OdSecond();

            OdSecond = new Del(ObSecond.Report);
            OdSecond();

            Console.ReadLine();

        }  //Main(string[] args)

    }// Конец класса Program


}


namespace My
{
    public delegate void Del();  // Объявили делегат
                                 //--------------------------------------------------------------------------------
    class First
    {
        protected string str = "";                   // Защищенное поле класса

        public First(string s) { this.str = s; }   // Через параметр конструктора класса
                                                   //передается значение защищенному полю класса First

        //------- Создаем ряд функций класса First--------------------------------
        public void fun1()
        {
            Console.Write("работает fun1\n"); str += '1';
        }
        public void fun2()
        {
            Console.Write("работает fun2\n"); str += '2' + str;
        }
        public void fun3()
        {
            Console.Write("работает fun3\n"); str += '3';
        }
        public static void funStatic()
        {
            Console.Write("работает статическая функция\n");
        }
        public void Report()
        {
            Console.Write("работает функция Report. Итоговое значение str = " + str + "\n");
        }

    }// Конец класса First

    //-------------------------------------------------------------------------------------
    class Second : First              // Потомок класса First
    { //--- Создаем конструктор класса Second-----------------
        public Second(string str) : base(str) { } // Передача параметра конструктору 
        public void fun5()
        {
            Console.Write("работает fun5 класса Second\n"); str += '5';  // Дописывается в конец строки
        }
    }// Конец класса Second
}