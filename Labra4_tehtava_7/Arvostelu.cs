using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    abstract class Arvostelu
    {
        private string lyhyesti;
        private string pitemmasti;

        public string Pitemmasti
        {
            get { return pitemmasti; }
            set { pitemmasti = value; }
        }

        public string Lyhyesti
        {
            get { return lyhyesti; }
            set { lyhyesti = value; }
        }

        public override string ToString()
        {
            return "Lyhyesti: " + lyhyesti + ". ";
        }

    }
}
