using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1Tehtava9
{
    class Program
    {
        static void Main(string[] args)
        {
            float luku = 0, tulos = 0;

            while (true)
            {
                Console.WriteLine("anna luku");
                luku = float.Parse(Console.ReadLine());
                if (luku == 0)
                {
                    break;
                }
                tulos += luku;
            }

            Console.WriteLine(tulos);
        }
    }
}
