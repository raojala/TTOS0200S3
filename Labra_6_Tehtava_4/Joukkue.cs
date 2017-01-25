using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Joukkue
    {
        List<Pelaaja> pelaajat;

        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        public List<Pelaaja> Pelaajat { get; set; }

        public Joukkue ()
        {
            pelaajat = new List<Pelaaja>();
            HaePelaajat();
        }

        public void HaePelaajat()
        {
            string line;
            string[] words;

            Pelaaja pelaaja;
            DateTime synntari;


            using (StreamReader sr = new StreamReader("../../joukkue.txt"))
            {

                while ((line = sr.ReadLine()) != null)
                {
                    pelaaja = new Pelaaja();
                    words = line.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

                    pelaaja.Numero = int.Parse(words[0]);
                    pelaaja.Sukunimi = words[1];
                    pelaaja.Etunimi = words[2];
                    synntari = Convert.ToDateTime(words[3]);


                }
            }
        }

    }
}
