using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1Tehtava7
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi = 0;

            Console.WriteLine("mikä vuosi?");
            vuosi = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(vuosi))
            {
                Console.WriteLine("{0}, on karkausvuosi.", vuosi);
            }
            else
            {
                Console.WriteLine("{0} Ei ole karkausvuosi.", vuosi);
            }
        }
    }
}
