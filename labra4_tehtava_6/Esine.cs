using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    abstract class Esine
    {
        private string nimi;
        private float arvo;
        private float paino;
        private string kuvas;

        public string Kuvaus
        {
            get { return kuvas; }
            set { kuvas = value; }
        }

        public float Paino
        {
            get { return paino; }
            set { paino = value; }
        }

        public float Arvo
        {
            get { return arvo; }
            set { arvo = value; }
        }

        public string Nimi
        {
            get { return nimi; }
            set { nimi = value; }
        }
        public override string ToString()
        {
            return "Nimi " + nimi + ". Arvo " + arvo + ". Paino " + paino + ". Kuvaus " + kuvas + ". ";
        }
    }
}
