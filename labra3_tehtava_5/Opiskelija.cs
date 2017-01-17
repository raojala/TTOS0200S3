using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Opiskelija
    {
        string tunnus;
        public string Tunnus
        {
            get
            {
                return tunnus;
            }
        }
        public string ENimi { get; set; }
        public string SNimi { get; set; }

        public override string ToString()
        {
            string s = tunnus + ", " + ENimi + ", " + SNimi;
            return s;
        }
        public void Tayta ()
        {
            Console.WriteLine("Syötä Tunnus");
            tunnus = Console.ReadLine();
            Console.WriteLine("Syötä Etu nimi");
            ENimi = Console.ReadLine();
            Console.WriteLine("Syötä Suku nimi");
            SNimi = Console.ReadLine();
        }
    }
}
