using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_tehtava_15
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Tee ohjelma, joka tulostaa seuraavanlaisen kuvion. Kysy käyttäjältä puunkorkeus käytä juurena kaksi korkeuden yksikkö.

                Anna Luku > 7 [Enter]    
                    *
                   ***
                  *****
                 *******
                *********
                    *
                    *
            */

            // minimi korkeus 2
            //

            int korkeus = 2;
            string[] rivit;

            Console.WriteLine("kuusen korkeus? (minimi 2)");
            int.TryParse(Console.ReadLine(), out korkeus);

            if (korkeus < 2)
            {
                Environment.Exit(0);
            }

            rivit = new string[korkeus];

            for (int i = 0; i < korkeus; i++)
            {
                for (int x = 0; x < korkeus; x++)
                {
                    rivit[i] = 
                }
            }

        }
    }
}
