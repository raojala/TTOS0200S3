using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    abstract class Asiakaspalvelu : Arvostelu
    {
        private int kohteliaisuus;
        private int asenne;
        private int palveluInto;

        public int PalveluInto
        {
            get { return palveluInto; }
            set { if (value >= 1 && value <= 5) palveluInto = value; }
        }

        public int Asenne
        {
            get { return asenne; }
            set { if (value >= 1 && value <= 5) asenne = value; }
        }

        public int Kohteliaisuus
        {
            get { return kohteliaisuus; }
            set { if (value >= 1 && value <= 5) kohteliaisuus = value; }
        }
        public override string ToString()
        {
            return base.ToString() + ". " + "Kohteliaisuus: " + kohteliaisuus + ". " + "Asenne: " + asenne + ". " + "Palveluinto: " + palveluInto + ". ";
        }
    }
}
