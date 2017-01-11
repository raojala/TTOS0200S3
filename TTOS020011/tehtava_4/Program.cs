using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika = 0;

            Console.WriteLine("minkä ikäinen olet?");
            ika = int.Parse(Console.ReadLine());

            if (ika < 18)
            {
                Console.WriteLine("Alaikäinen");
            }
            else if (ika <= 65)
            {
                Console.WriteLine("aikuinen");
            }
            else
            {
                Console.WriteLine("seniori");
            }
        }
    }
}
