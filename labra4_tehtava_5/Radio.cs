using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Radio
    {
        /*Tehtävässä tulee toteuttaa C#-ohjelma radion perustoimintojen testaamiseen.

        Kannettavassa radiossa on vain kolme säädintä: päälle/pois-kytkin,
        äänen voimakkuuden säädin (arvot 0, 1, 2,..., 9) 
        ja kuunneltavan kanavan taajuusvalinta (2000.0 - 26000.0). 
        
        Laadi luokka kannettavan radion toteutukseksi.
        Käytä tekemääsi luokkaa pääohjelmasta käsin, eli testaile radion toimivuutta
        erilaisilla voimakkuuden ja taajuuden arvoilla. Jätä asetus- ja tulostuslauseet
        näkyville pääohjelmaan, jotta radio-olion käyttö voidaan todentaa.*/

        private bool onkoPaalla;
        private float taajuus;
        private int volyymi;

        public bool OnkoPaalla
        {
            get { return onkoPaalla; }
            set { onkoPaalla = value; }
        }

        public float Taajuus
        {
            get { return taajuus; }
            set
            {
                if (value >=2000.0f && value <= 26000.0f)
                {
                    taajuus = value;
                }
            }
        }

        public int Volyymi
        {
            get { return volyymi; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    volyymi = value;
                }
            }
        }

        public override string ToString()
        {
            return "Päällä=" + onkoPaalla + ". Taajuus: " + taajuus + ". Volyymi: " + volyymi;
        }
    }
}
