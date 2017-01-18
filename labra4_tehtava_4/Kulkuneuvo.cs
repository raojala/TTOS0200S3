using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public abstract class Kulkuneuvo
    {
        string nimi, malli, vari;
        int vuosimalli;

        public string Nimi
        {
            get
            {
                return nimi;
            }
            set
            {
                nimi = value;
            }
        }
        public string Malli
        {
            get
            {
                return malli;
            }
            set
            {
                malli = value;
            }
        }
        public string Color
        {
            get
            {
                return vari;
            }
            set
            {
                vari = value;
            }
        }
        public int Vuosimalli
        {
            get
            {
                return vuosimalli;
            }
            set
            {
                vuosimalli = value;
            }
        }

        public override string ToString()
        {
            return nimi + " " + malli + " " + vari + " " + vuosimalli;
        }

    }
}
