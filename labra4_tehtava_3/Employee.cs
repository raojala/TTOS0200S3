using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Employee
    {
        string nimi = "", ammatti = "";
        float palkka = 0f;
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
        public string Ammatti
        {
            get
            {
                return ammatti;
            }
            set
            {
                ammatti = value;
            }
        }
        public float Palkka
        {
            get
            {
                return palkka;
            }
            set
            {
                palkka = value;
            }
        }

        public override string ToString()
        {
            return "nimi: " + nimi + ". Ammatti: " + ammatti + ". Palkka: " + palkka;
        }
    }
}
