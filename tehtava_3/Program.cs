using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Tehtävä 3 
                
                mitä ominaisuuksia ja toimintoja tekisit Televisio-luokkaan?

                UML

                Suunnittele Televisio-luokan ominaisuudet ja toiminnot UML-luokkakaaviona.

                Ohjelmointi

                Toteuta Televisio-luokan ohjelmointi sekä pääohjelma, jolla luot olion Televisio-luokasta.
                Säädä luomaasi Televsio-oliota erilaisilla arvoilla, jätä Console.WriteLine()-tulostuslauseet ohjelmaasi,
                jotta televisio-olion käyttäminen jää näkyville.
            */

            int kanava;

            Televisio tv = new Televisio();

            // käynnistä telkkari.
            tv.OnkoPaalla = true;

            if (tv.OnkoPaalla)
            {
                Console.WriteLine("TV on nyt päällä");
            }

            // kysytään käyttäjältä kanava.
            Console.WriteLine("Mikä kanava?");
            if (int.TryParse(Console.ReadLine(), out kanava))
            {
                tv.Kanava = kanava;
            }

            Console.WriteLine("Katsot kanavaa: " + tv.Kanava);

            // sammutetaan telkkari
            tv.OnkoPaalla = false;
            if (!tv.OnkoPaalla)
            {
                Console.WriteLine("Televisio on pois päältä");
            }

        }
    }
}
