using System;
using IronPython.Hosting;

namespace PythonInteroperability
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating IronPython objects
            Console.WriteLine("Testing Python");
            dynamic python = Python.CreateRuntime().UseFile(@"..\..\..\..\CustomerDB.py");
            dynamic pythonCustomer = python.GetNewCustomer(100, "Fred", "888");
            dynamic pythonCustomerDB = python.GetCustomerDB();
            pythonCustomerDB.storeCustomer(pythonCustomer);
            pythonCustomer = python.GetNewCustomer(101, "Sid", "999");
            pythonCustomerDB.storeCustomer(pythonCustomer);
            Console.WriteLine("{0}", pythonCustomerDB);
        }
    }
}
