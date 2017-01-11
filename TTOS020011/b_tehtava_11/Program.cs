using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_tehtava_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int rivit = 0;

            Console.WriteLine("Anna rivien määrä: ");
            rivit = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rivit; i++)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
