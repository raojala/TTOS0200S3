using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1Tehtava10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100].
             * Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
             */

            int[] luvut = new int[] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            foreach (int i in luvut)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine("{0}, HEP!", i);
                }
                else
                {
                    Console.WriteLine("{0}, ei parillinen.", i);
                }
            }

        }
    }
}
