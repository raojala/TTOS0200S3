using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Kala : Elio
    {
        // kalan perustiedot (laji, pituus ja paino),--------------
        
        public float Pituus { get; set; }
        public float Paino { get; set; }

        public Kala (string nimi, float pituus, float paino)
        {
            Nimi = nimi;
            Pituus = pituus;
            Paino = paino;
        }

        public override string ToString()
        {
            return Nimi + ", " + Pituus + ", " + Paino;
        }
    }
}
