using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Amp
    {
        const int MAXVOL = 100, MINVOL = 0;
        int curVol = 0;
        public int CurValue {
            get
            {
                return curVol;
            }
            set
            {
                if (value > MAXVOL)
                {
                    curVol = MAXVOL;
                }
                else if (value < MINVOL)
                {
                    curVol = MINVOL;
                }
                else
                {
                    curVol = value;
                }
            }
        }

        public override string ToString()
        {
            return curVol.ToString();
        }
    }
}
