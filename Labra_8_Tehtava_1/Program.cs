using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tehtävä 1 - Noppa home Kotitehtävä
            Toteuta Noppa-luokka siten, että noppaa voidaan heittää. 
            Nopan tulee palauttaa satunnainen luku jokaisella heittokerralla. 
            Toteuta pääohjelmassa nopan heittäminen. Kokeile ensin heittää noppaa kerran 
            ja tulosta nopan luku. Toteuta tämän jälkeen ohjelma siten, että kysyt 
            käyttäjältä heittojen määrän. Heitä noppaa ja tulosta heittojen lukujen 
            keskiarvo.

            */
            try
            {
                paaOhjelma();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public static void paaOhjelma ()
        {
            int heittojenMaara = 0, summa = 0;
            Noppa noppa = new Noppa();

            Console.WriteLine("Montako heittoa haluat heittää ja tulostaa?");

            try
            {
                int.TryParse(Console.ReadLine(), out heittojenMaara);

                for (int i = 0; i < heittojenMaara; i++)
                {
                    noppa.NopanHeitto();
                    summa = summa + noppa.Value;
                    Console.WriteLine(noppa.Value);
                }
                Console.WriteLine("{0}:n heiton keskiarvo oli: {1}", heittojenMaara, (float)summa / (float)heittojenMaara);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
