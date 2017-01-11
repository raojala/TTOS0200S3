using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_tehtava_13
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] arvosana = new float[5];
            float summa=0F, min=0F, max=0F;

            for (int i = 0; i < arvosana.Length; i++)
            {
                Console.WriteLine("Anna arvosana " + i);
                arvosana[i] = float.Parse(Console.ReadLine());
                summa += arvosana[i];
            }

            max = Math.Max(arvosana[0], Math.Max(arvosana[1], Math.Max(arvosana[2], Math.Max(arvosana[3], arvosana[4]))));
            min = Math.Min(arvosana[0], Math.Min(arvosana[1], Math.Min(arvosana[2], Math.Min(arvosana[3], arvosana[4]))));

            summa = summa - min - max;

            Console.WriteLine("suorituksen arvosana: " + summa);
        }
    }
}
