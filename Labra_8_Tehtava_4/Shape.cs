using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    abstract class Shape
    {
        string Nimi { get; set; }

        virtual public void Pintaala()
        {
        }
        virtual public void Piiri()
        {
        }
    }
}
