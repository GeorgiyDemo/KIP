using System;

namespace VirtualExample
{


    public class A
    {
       
        public virtual double Func(double a)
        {
            return Math.Pow(a, 2);
        }

    }


    public class B : A
    {

        public override double Func(double a)
        {
            return Math.Pow(a, 3);
        }

    }

    public class C : B
    {
        public virtual double Func(double a)
        {
            return Math.Pow(a, 2);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double a = System.Convert.ToDouble(Console.ReadLine());



            A a_obj = new A();
            Console.WriteLine("A: "+a_obj.Func(a));
            B b_obj = new B();
            Console.WriteLine("B: "+b_obj.Func(a));
            C c_obj = new C();
            Console.WriteLine("C: "+c_obj.Func(a));

        }
    }
}
