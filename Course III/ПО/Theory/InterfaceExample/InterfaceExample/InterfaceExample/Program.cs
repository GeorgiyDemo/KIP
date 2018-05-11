using System;

namespace InterfaceExample
{
    interface IDEMKA
    {
        
        void SampleShowMethod();
        int SampleCountMethod(int a, int b);

    }

    class ImplementationClass : IDEMKA
    {

        void IDEMKA.SampleShowMethod()
        
        {
            Console.WriteLine("MEOW");
        }

        int IDEMKA.SampleCountMethod(int a, int b)
        {
            return a + b;
        }
}

    class Program
    {
        static void Main(string[] args)
        {
            IDEMKA obj = new ImplementationClass();
            obj.SampleShowMethod();
            Console.WriteLine(obj.SampleCountMethod(3, 3));

        }
    }
}