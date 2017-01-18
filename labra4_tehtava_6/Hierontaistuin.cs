using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Hierontaistuin : Esine
    {
        private bool lammitin;
        private bool pika;
        private Ohjelma ohjelma;

        public Ohjelma HierontaOhjelma
        {
            get { return ohjelma; }
            set { ohjelma = value; }
        }

        public bool Pikahieronta
        {
            get { return pika; }
            set { pika = value; }
        }

        public bool Lammitin
        {
            get { return lammitin; }
            set { lammitin = value; }
        }

        public enum Ohjelma
        {
            Shiatsu,
            Normaali,
            Thai,
            Rystys,
            Kauhutappo
        };

        public override string ToString()
        {
            return base.ToString() + "Lämmitin päällä= "+lammitin+ ". Pikahieronta= "+pika+ ". Ohjelma: " +ohjelma+". ";
        }
    }
}
