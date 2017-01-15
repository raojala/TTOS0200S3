using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_tehtava_19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Tehtävä 19
                Tee tekstipohjainen Hirsipuu-peli. 
                Voit kovakoodata arvattavan sanan 
                toteuta looppi, jossa käyttäjältä kysytään seuraavaa kirjainta.
                Muista näyttää aina kirjaimen jälkeen oikein arvatut kirjaimet sanan oikealla kohdalla (käytä esim _-alaviivaa ei arvattujen kirjainten kohdalla).
                Voit näyttää myös jo arvatut ei käytetyt -kirjaimet.
                Päätä itse milloin pelaaja joutuu hirteen.
            */

            int arvauksiaJaljella = 7;
            string arvattavaSana = "kakkapylly", tuloste = "__________", arvatutKirjaimet = "";
            char arvausArvo;
            bool oikein;

            StringBuilder sb = new StringBuilder(tuloste);

            while (arvauksiaJaljella > 0)
            {
                Console.WriteLine(tuloste);

                oikein = false;
                arvausArvo = arvaus();

                for (int i = 0; i < arvattavaSana.Length; i++)
                {
                    if (arvattavaSana[i] == arvausArvo)
                    {
                        oikein = true;
                        sb[i] = arvausArvo;
                        tuloste = sb.ToString();
                    }
                }

                if (tuloste == arvattavaSana)
                {
                    Console.WriteLine("JEEEEE OIKEIN!");
                    break;
                }


                if(!oikein)
                {
                    Console.WriteLine("VOE EI IHAN PÄIN PERSETTÄ MÄN!");
                    arvauksiaJaljella--;
                }
            }
        }

        static char arvaus ()
        {
            char c;
            Console.WriteLine("Arvaa Kirjain");
            while (true)
            {
                // parsetaan tuloste c muuttujaan ja suljetaan looppi jos se on öökkönen
                if (char.TryParse(Console.ReadLine(), out c) && char.IsLetter(c))
                {
                    char.ToLower(c);
                    break;
                }
                else
                {
                    Console.WriteLine("Syötä vain YKSI KIRJAIN");
                }
            }
            return c;
        }
    }
}
