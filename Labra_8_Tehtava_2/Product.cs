using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Product
    {
        public string Nimi { get; }
        public float Hinta { get; set; }

        public Product (string nimi, float hinta)
        {
            Nimi = nimi;
            Hinta = hinta;
        }

        public override string ToString()
        {
            return Nimi + " Hintaan " + Hinta + " egee";
        }
    }
}
