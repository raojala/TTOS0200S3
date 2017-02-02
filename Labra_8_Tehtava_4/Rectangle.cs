using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Rectangle : Shape
    {
        public override string Nimi { get; set; }
        public override float PintaAla { get; }
        public override float Piiri { get; }

        public Rectangle (int kanta, int korkeus, string nimi)
        {
            Nimi = nimi;
            PintaAla = Pintaala(kanta, korkeus);
            Piiri = LaskePiiri(kanta, korkeus);
        }

        public float Pintaala(int kanta, int korkeus)
        {
            return (float)kanta * (float)korkeus;
        }
        public float LaskePiiri(int kanta, int korkeus)
        {
            return ((float)kanta + (float)korkeus)*2;
        }

        public override string ToString()
        {
            return Nimi + ":n " + "Pinta-ala: " + PintaAla + ", Piiri: " + Piiri;
        }
    }
}
