using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra3_tehtava_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Suunnittele UML-editorilla Opiskelija-luokka, joka sisältää opiskelijalle tyypillisiä tietoja ja toimintoja.
             * Tee uusi projekti. Ohjelmoi Opiskelija-luokka sekä toteuta pääohjelma, joka luo muutamia opiskelijoita
             * ja tallentaa opiskelijat taulukkoon (esim. 5 opiskelijaa). Tulosta taulukossa olevien opiskelijoiden
             * tiedot käyttämällä toistorakennetta.*/

            Opiskelija[] opiskelija = new Opiskelija[5];

            // alustetaan opiskelijat
            for (int i = 0; i < 5; i++)
            {
                opiskelija[i] = new Opiskelija();
                opiskelija[i].Tayta();
            }

            Console.Clear();
            
            foreach (Opiskelija o in opiskelija)
            {
                Console.WriteLine(o.ToString());
            }
        }
    }
}
