using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * luo olio Pesukone-luokasta
             * Säädä pesukone-oliota erilaisilla arvoilla
             * jätä Console.WriteLine()-tulostuslauseet ohjelmaasi, jotta pesukone-olion käyttäminen jää näkyville. 
             * Toteuta Pesukone-luokkaan muutamia erilaisia konstruktoreita ja alusta niitä käyttämällä oliota pääohjelmasta käsin.
             */

            Pesukone pesukone0 = new Pesukone(Pesukone.PesuOhjelma.LamminNeljakymmenta);
            Pesukone pesukone1 = new Pesukone(Pesukone.PesuOhjelma.Kylma);
            Pesukone pesukone2 = new Pesukone(Pesukone.PesuOhjelma.LamminKahdeksankymmenta);
            Pesukone pesukone3 = new Pesukone(Pesukone.PesuOhjelma.LamminKaksikymmenta);
            Pesukone pesukone4 = new Pesukone(Pesukone.PesuOhjelma.LamminSata);

            pesukone0.Aloita();
            pesukone1.Aloita();
            pesukone2.Aloita();
            pesukone3.Aloita();
            pesukone4.Aloita();

        }
    }
}
