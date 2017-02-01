using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Kalastaja : Elio
    {
        // kalastajan perustiedot (nimi, puhelinnumero) ------------
        
        public string PuhNro { get; set; }

        public Kalastaja (string nimi, string puhelin)
        {
            Nimi = nimi;
            PuhNro = puhelin;
        }
        public override string ToString()
        {
            return Nimi + ", " + PuhNro;
        }
    }
}
