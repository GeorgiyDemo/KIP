using System;
using System.Collections;

namespace ConsoleApplication1
{
    class mem
    {
       
        public void TableEnter()
        {

            Hashtable ht = new Hashtable()
            {
                {"GENA", "12345"},
                {"MEOW", "kot123"},
                {"WOW", "DOGE"},
                {"NASTYA", "4321"}
            };
        
            ICollection keys = ht.Keys;

            foreach (string s in keys)
                Console.WriteLine(s + ": " + ht[s]);

            Console.WriteLine("-----------------------\nПосле удаления:\n---------------------");
            ht.Remove("GENA");
            ht.Remove("NASTYA");

            foreach (string s in keys)
                Console.WriteLine(s + ": " + ht[s]);
            Console.ReadLine();    
        }  
    }



    class Program
    {
        static void Main()
        {
            mem mem_obj = new mem();
            mem_obj.TableEnter();
        }
    }
}