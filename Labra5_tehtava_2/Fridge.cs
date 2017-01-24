using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5_tehtava_2
{
    class Fridge
    {
        List<RuokaAines> ruokaAines = new List<RuokaAines>();

        public List<RuokaAines> RuokaAines
        {
            get
            {
                return ruokaAines;
            }
        }

        public void LisaaAines (RuokaAines aines)
        {
            ruokaAines.Add(aines);
        }

        public void PoistaAines (RuokaAines aines)
        {
            ruokaAines.Remove(aines);
        }
    }
}
