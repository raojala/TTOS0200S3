using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_tehtava_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float summa = 0, keskiarvo = 0;
            float[] luvut = new float[3];
            for (int i = 0; i < luvut.Length; i++)
            {
                Console.WriteLine("Anna luku");
                luvut[i] = float.Parse(Console.ReadLine());
                summa += luvut[i];
            }

            keskiarvo = summa / 3;

            Console.WriteLine("Summa: {0}. Keskiarvo: {1}.", summa, keskiarvo);
        }
    }
}
