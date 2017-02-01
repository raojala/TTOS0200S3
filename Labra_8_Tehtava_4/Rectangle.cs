using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Rectangle : Shape
    {
        public string Nimi { get; set; }
        public float PintaAla { get; }

        public Rectangle (int kanta, int korkeus, string nimi)
        {
            Nimi = nimi;
            PintaAla = Pintaala(kanta, korkeus);
        }

        public float Pintaala(int kanta, int korkeus)
        {
            return (float)kanta * (float)korkeus;
        }
        public float Piiri(int kanta, int korkeus)
        {
            return ((float)kanta + (float)korkeus)*2;
        }
    }
}
