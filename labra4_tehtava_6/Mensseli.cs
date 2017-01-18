using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Mensseli : Esine
    {
        private int koko;
        private Tyyppi tyyppi;

        public Tyyppi MensselinTyyppi
        {
            get { return tyyppi; }
            set { tyyppi = value; }
        }
        
        public int Koko
        {
            get { return koko; }
            set { koko = value; }
        }

        public enum Tyyppi
        {
            Tahti,
            Taltta,
            torx
        };
        public override string ToString()
        {
            return base.ToString() + "Koko: " + koko + ". tyyppi: " + tyyppi + ". ";
        }
    }
}
