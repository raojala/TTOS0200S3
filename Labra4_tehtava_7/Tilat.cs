using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Tilat : Arvostelu
    {
        private int yleiskunto;
        private int siisteys;
        private int tilavuus;
        private int taustaAani;

        public int TaustaAani
        {
            get { return taustaAani; }
            set { if (value >= 1 && value <= 5)taustaAani = value; }
        }

        public int Tilavuus
        {
            get { return tilavuus; }
            set { if (value >= 1 && value <= 5) tilavuus = value; }
        }

        public int Siisteys
        {
            get { return siisteys; }
            set { if (value >= 1 && value <= 5) siisteys = value; }
        }

        public int Yleiskunto
        {
            get { return yleiskunto; }
            set { if (value >= 1 && value <= 5) yleiskunto = value; }
        }
        public override string ToString()
        {
            return base.ToString() + "Yleiskunto: " + yleiskunto + ". " + "Siisteys: " + siisteys + ". " + "Tilavuus: " + tilavuus + ". " + "Taustaääni" + taustaAani + ". ";
        }
    }
}
