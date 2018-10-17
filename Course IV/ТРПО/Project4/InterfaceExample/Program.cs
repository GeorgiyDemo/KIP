using System;
using System.Diagnostics;
namespace DEMKA
{

    interface ICalculator
    {
        double Subtraction(double a, double b);
        double Addition(double a, double b);
    }


    public class DEMKADestructor : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Вызвали Dispose (какие мы молодцы)");
            Trace.WriteLine("Вызван деструктор");
        }

        ~DEMKADestructor()
        {
            Console.WriteLine("Работа деструктора");
        }

    }
    class DEMKACalculator : ICalculator
    {
        public double Addition(double x, double y)
        {
            return x + y;
        }
        public double Subtraction(double x, double y)
        {
            return x - y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Часть №1\n Введите первый аргумент -> ");
            double localea = System.Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число второй аргумент -> ");
            double localeb = System.Convert.ToDouble(Console.ReadLine());

            DEMKACalculator DEMKACalculator_obj = new DEMKACalculator();
            Console.WriteLine("\nПолучили " + DEMKACalculator_obj.Addition(localea, localeb).ToString() + " через метод класса сложение");
            Console.WriteLine("Получили " + DEMKACalculator_obj.Subtraction(localea, localeb) + " через метод класса вычитание");
          
            DEMKACalculator DEMKAAlterCalculator_obj = new DEMKACalculator();
            ICalculator ICalculator_obj = DEMKAAlterCalculator_obj;

            Console.WriteLine("Получили " + ICalculator_obj.Addition(localea, localeb).ToString() + " через интерфейс сложения");
            Console.WriteLine("Получили " + ICalculator_obj.Subtraction(localea, localeb).ToString() + " через интерфейс вычитания");

            Console.WriteLine("\nЧасть №2");
            DEMKADestructor DEMKADestructor_obj = new DEMKADestructor();
            DEMKADestructor_obj.Dispose();
            GC.Collect();
            GC.WaitForPendingFinalizers();


        }
    }
}
