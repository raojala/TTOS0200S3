using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Circle : Shape
    {
        public override string Nimi { get; set; }
        public override float PintaAla { get; }
        public override float Piiri { get; }

        public Circle (int radius, string name)
        {
            Nimi = name;
            PintaAla = Pintaala(radius);
            Piiri = LaskePiiri(radius);
        }

        public float Pintaala(float r)
        {
            /*
            pi r*2 pinta-ala
            */
            return (float)(Math.PI * Math.Pow(r, 2));

        }
        public float LaskePiiri(float r)
        {
            /*
            2 pi r keehä
            */
            return (float)(2*Math.PI*r);
        }

        public override string ToString()
        {
            return Nimi + ":n " + "Pinta-ala: " + PintaAla + ", Piiri: " + Piiri;
        }
    }
}
