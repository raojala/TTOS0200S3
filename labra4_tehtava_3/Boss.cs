using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Boss : Employee
    {
        string auto = "";
        float palkkaBonus = 0f;
        public string Auto
        {
            get
            {
                return auto;
            }
            set
            {
                auto = value;
            }
        }
        public float PalkkaBonus
        {
            get
            {
                return palkkaBonus;
            }
            set
            {
                palkkaBonus = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + ". Palkkaboonus: " + palkkaBonus + ". Auto: " + auto;
        }
    }
}
