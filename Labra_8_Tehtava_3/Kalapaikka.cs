using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Kalapaikka : Elio
    {
        // kalapaikan perustiedot (nimi ja paikka) ---------
        public string Paikka { get; set; }

        public Kalapaikka(string nimi, string paikka)
        {
            Nimi = nimi;
            Paikka = paikka;
        }

        public override string ToString()
        {
            return Nimi + ", " + Paikka;
        }
    }
}
