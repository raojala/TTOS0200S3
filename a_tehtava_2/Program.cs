using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_tehtava_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pisteet = 0;

            Console.WriteLine("paljonko sait pisteitä?");
            pisteet = int.Parse(Console.ReadLine());

            if (pisteet > 9)
            {
                Console.WriteLine("arvosana 5");
            }
            else if (pisteet > 7)
            {
                Console.WriteLine("arvosana 4");
            }
            else if (pisteet > 5)
            {
                Console.WriteLine("arvosana 3");
            }
            else if (pisteet > 3)
            {
                Console.WriteLine("arvosana 2");
            }
            else if (pisteet > 1)
            {
                Console.WriteLine("arvosana 1");
            }
            else
            {
                Console.WriteLine("arvosana 0");
            }
        }
    }
}
