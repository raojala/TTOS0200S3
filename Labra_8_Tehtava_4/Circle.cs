using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Circle : Shape
    {
        public string Nimi { get; set; }

        public Circle (int radius, string name)
        {
            Nimi = name;
        }

        public override void Pintaala()
        {
            /*
            2 pi r keehä
            pi r*2 pinta-ala
            */




        }
        public override void Piiri()
        {
            throw new NotImplementedException();
        }
    }
}
