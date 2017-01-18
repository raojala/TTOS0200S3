using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Laskutus : Asiakaspalvelu
    {
        private int toiminnonRipeys;
        private string maksuTavat;

        public string MaksuTavat
        {
            get { return maksuTavat; }
            set { maksuTavat = value; }
        }


        public int ToiminnonRipeys
        {
            get { return toiminnonRipeys; }
            set { if (value >= 1 && value <= 5) toiminnonRipeys = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "Maksuvälineet: " + maksuTavat + ". " + "Toiminnon ripeys: " + toiminnonRipeys + ". ";
        }
    }
}
