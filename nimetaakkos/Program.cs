using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nimetaakkos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nimet = new string[5];

            for (int i=0; i < nimet.Length; i++)
            {
                Console.WriteLine("anna nimi " + i);
                nimet[i] = Console.ReadLine();
            }

            foreach (string s in nimet)
            {
                Console.WriteLine(s);
            }
            Array.Sort(nimet);

            Console.WriteLine("Nimet aakkosjärjestyksessä");
            foreach (string s in nimet)
            {
                Console.WriteLine(s);
            }
        }
    }
}
