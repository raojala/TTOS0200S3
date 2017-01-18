using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Ateria : Arvostelu
    {
        private int annosKoko;
        private int annoksenSomittelu;
        private int maku;

        public int Maku
        {
            get { return maku; }
            set { if (value >= 1 && value <= 5) maku = value; }
        }

        public int AnnoksenSomittelu
        {
            get { return annoksenSomittelu; }
            set { if (value >= 1 && value <= 5) annoksenSomittelu = value; }
        }


        public int AnnosKoko
        {
            get { return annosKoko; }
            set { if (value >= 1 && value <= 5) annosKoko = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "Annoskoko: " + annosKoko + ". " + "Annoksen somittelu: " + annoksenSomittelu + ". " + "Maku: " + maku + ": ";
        }
    }
}
