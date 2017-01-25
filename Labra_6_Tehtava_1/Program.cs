using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra_6_Tehtava_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Toteutetaan opettajan kanssa yhdessä konsolipohjainen ohjelma,
            // jolla voidaan hallita henkilöitä eli henkilörekisteri.

            TestaaHenkiloRekisteri();
        }

        static void TestaaHenkiloRekisteri ()
        {
            // luodaan muutaman testi henkilo
            Henkilot poppoo = new Henkilot();
            Henkilo h0 = new Henkilo { Etunimi = "Jack", Sukunimi = "Russel", Hetu = "311270-123A" };
            Henkilo h1 = new Henkilo { Etunimi = "Jaakko", Sukunimi = "Teppo", Hetu = "232232-123B" };
            Henkilo h2 = new Henkilo { Etunimi = "KyrpäJooseppi", Sukunimi = "EEHHEEHHEEEHHHEEE", Hetu = "B===D" };

            poppoo.LisaaHenkilo(h0);
            poppoo.LisaaHenkilo(h1);
            poppoo.LisaaHenkilo(h2);

            foreach (Henkilo h in poppoo.Henkilolista )
            {
                Console.WriteLine("{0}", h.ToString());
            }

            // todo kysy käyttäjältä hetu ja haetaan sitä vastaava henkilö näytölle

            Console.WriteLine("Anna Hetu (muodossa: 123456-123a)");
            Console.WriteLine(poppoo.HaeHenkiloHetulla(Console.ReadLine()));

        }
    }
}
