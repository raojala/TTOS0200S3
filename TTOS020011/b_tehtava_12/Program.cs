using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_tehtava_12
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] luvut = new float[5];

            for (int i = 0; i < luvut.Length; i++)
            {
                Console.WriteLine("Anna luku");
                luvut[i] = float.Parse(Console.ReadLine());
            }

            Console.Write("Luvut ovat");
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(", " + luvut[i]);
            }
            Console.WriteLine();

        }
    }
}
