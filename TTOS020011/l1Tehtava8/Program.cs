using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1Tehtava8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luku = new int[3];
            int isoin = 0;

            Console.WriteLine("Anna luku 1");
            luku[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna luku 2");
            luku[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("Anna luku 3");
            luku[2] = int.Parse(Console.ReadLine());

            isoin = Math.Max(luku[0], Math.Max(luku[1], luku[2]));

            Console.WriteLine(isoin + " on suurin");
        }
    }
}
