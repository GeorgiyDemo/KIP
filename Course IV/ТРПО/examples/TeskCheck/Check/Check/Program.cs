using System;

namespace Check
{


    class Employee{
        public virtual string GetTypeName(){
            return "THIS IS EMPLOYEW";

        }
    }
    class Manager:Employee{
        public override string GetTypeName()
        {
            return "THIS IS MANAGER";
        }
    }

    class ManualWorker : Employee{

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee myEmaployee;
            Manager myManager = new Manager();
            ManualWorker myWorker = new ManualWorker();

            myEmaployee = myManager;
            Console.WriteLine(myEmaployee.GetTypeName());

            myEmaployee = myWorker;
            Console.WriteLine(myEmaployee.GetTypeName());
        }
    }
}
