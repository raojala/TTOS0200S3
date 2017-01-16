using JAMK.IT; // helpottaa meidän luokkien löytämistä
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaKiuas();
        }

        // tehtävän 1 kiuas-luokan testaus

        static void TestaaKiuas ()
        {
            // luodaan kiuas olio
            Kiuas kiuas = new Kiuas();

            // pistetään kiuas lämpenemään ja asetetaan lämpöä ja kosteutta
            kiuas.OnkoPäällä = true;
            kiuas.Lämpötila = 90F;
            kiuas.Kosteus = 50F;

            // näytetään konsolilla
            Console.WriteLine("Kiuas on päällä {0}", kiuas.OnkoPäällä);
            Console.WriteLine("Kiukaan lämpötila on {0}", kiuas.Lämpötila);
            Console.WriteLine("Kiukaan kosteus on  {0}", kiuas.Kosteus);

            // mita tapahtuu jos kosteus yli rajojen
            kiuas.Kosteus = 101F;
            Console.WriteLine("Kiukaan kosteus on  {0}", kiuas.Kosteus);
        }
    }
}
