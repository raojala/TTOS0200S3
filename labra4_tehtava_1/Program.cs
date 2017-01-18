using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra4_tehtava_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();

            int i = 0;
            Console.WriteLine("mihin kerrokseen?");

            while (!int.TryParse(Console.ReadLine(), out i));
            hissi.SeuraavaKerros = i;

            Console.WriteLine("olet kerroksessa: " + hissi.Kerros);
            


        }
    }
}
