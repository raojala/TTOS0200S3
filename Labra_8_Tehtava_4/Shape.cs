using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    abstract class Shape
    {
        virtual public string Nimi { get; set; }
        virtual public float PintaAla { get; }
        virtual public float Piiri { get; }

        virtual public void Pintaala()
        {
        }
        virtual public void LaskePiiri()
        {
        }
    }
}
