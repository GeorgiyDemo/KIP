using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{

    class Peoples
    {
        enum Groups : ulong { PKS115, PKS215, PKS315 };
        int age;
        string name;
        double heigth;

        public Peoples(int age1, string name1, double heigth1)
        {
            age = age1;
            name = name1;
            heigth = heigth1;
            ShowVal();

        }

        private void ShowVal()
        {
            for (Groups group = Groups.PKS115; group <= Groups.PKS315; group++)
                Console.WriteLine(group);

            Console.WriteLine("age: "+age.ToString());
            Console.WriteLine("name: " + name.ToString());
            Console.WriteLine("heigth: " + heigth.ToString());

        }
        public Peoples() : this(8,"Котиков", 0.3)
        {
        }

        
    }

    class Project2
    {
        static void Main(string[] args)
        {
            Peoples Gena = new Peoples(19,"Геннадий",1.86);
            Peoples kot = new Peoples();
            Console.ReadKey();
        }
    }
}
