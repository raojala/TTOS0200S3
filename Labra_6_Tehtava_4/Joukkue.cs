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

        private void HaePelaajat()
        {
            string line;
            string[] words;

            Pelaaja pelaaja;


            using (StreamReader sr = new StreamReader("../../joukkue.txt"))
            {

                while ((line = sr.ReadLine()) != null)
                {
                    pelaaja = new Pelaaja();
                    words = line.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

                    pelaaja.Numero = int.Parse(words[0]);
                    pelaaja.Sukunimi = words[1];
                    pelaaja.Etunimi = words[2];
                    pelaaja.Syntymapaiva = Convert.ToDateTime(words[3]);

                    pelaaja.Ika = DateTime.Now.Year - pelaaja.Syntymapaiva.Year;

                    if (pelaaja.Syntymapaiva.Month >= DateTime.Now.Month)
                    {
                        if (pelaaja.Syntymapaiva.Day > DateTime.Now.Day)
                        {
                            pelaaja.Ika++;
                        }
                    }

                    pelaajat.Add(pelaaja);

                }
            }
        }

        public void TallennaPelaajat ()
        {
            string s = "";
            using (StreamWriter sw = new StreamWriter("../../joukkue.txt"))
            {
                foreach (Pelaaja p in pelaajat)
                {
                    s = p.Numero.ToString() + " " + p.Sukunimi + " " + p.Etunimi + " " + p.Syntymapaiva;
                    sw.WriteLine(s);
                }
            }
        }
    }
}
