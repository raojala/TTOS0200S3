using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Munakello : Esine
    {
        private float ajastin;
        private float aikaaJaljella;

        public float AikaaJaljella
        {
            get { return aikaaJaljella; }
            set { aikaaJaljella = value; }
        }

        public float Ajastin
        {
            get { return ajastin; }
            set { ajastin = value; }
        }
        public override string ToString()
        {
            return base.ToString() + "Aika " + ajastin + ". Aikaa jäljellä? " + aikaaJaljella + ". " ;
        }
    }
}
