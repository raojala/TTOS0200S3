using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Hissi
    {
        int maxKerros = 5, minKerros = 1;
        public int MaxKerros
        {
            get
            {
                return maxKerros;
            }
            set
            {
                maxKerros = value;
            }
        }
        public int MinKerros
        {
            get
            {
                return minKerros;
            }
            set
            {
                minKerros = value;
            }
        }
        int kerros = 0;
        public int Kerros
        {
            get
            {
                return kerros;
            }
            set
            {
                kerros = value;
            }
        }

        int seuraavaKerros = 0;
        public int SeuraavaKerros
        {
            get
            {
                return seuraavaKerros;
            }
            set
            {
                if (value >= minKerros && value <= maxKerros)
                {
                    seuraavaKerros = value;
                    AjaHissi();
                }
            }
        }

        void AjaHissi ()
        {
            if (SeuraavaKerros != Kerros)
            {
                Kerros = SeuraavaKerros;
            }
        }
    }
}
