using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{

    class CellPhone
    {
        public int ID;
        public string Make;
        public string Model;
        public int NetworkID;
    }

    class CellPhoneNetwork
    {
        public int ID;
        public string Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<CellPhone> phones = new[] {
            new CellPhone{ID =1, Make="1", Model="M1", NetworkID=1 },
            new CellPhone{ID =2, Make="2", Model="M2", NetworkID=2 },
            new CellPhone{ID =3, Make="3", Model="M3", NetworkID=3 },
        };

            IEnumerable<CellPhoneNetwork> networks = new[]
            {
            new CellPhoneNetwork{ID =1, Name="N1"},
            new CellPhoneNetwork{ID =2, Name="N2"},
        };

            var result = phones.Select(p => p).Join(networks, p => p.NetworkID, n => n.ID, (p, n) => new { p.Make, p.Model, n.Name });


            foreach (var s in result)
                Console.WriteLine(s);
            //Console.WriteLine(phones);
            Console.ReadKey();
        }
    }
}
