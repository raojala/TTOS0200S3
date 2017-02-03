using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    // MIKSI TÄMÄN PUBLIC - INTERNAL VAIKUTTAA LASKUN TUOTTEET DICTIONARYYN?!
    /* CS0053	Inconsistent accessibility: property type 'Dictionary<Product, int>' 
     * is less accessible than property 'Lasku.Tuotteet'	Labra_8_Tehtava_6	
     * E:\GitHub\oop-koti\Labra_8_Tehtava_6\Lasku.cs	12	Active
    */
    public class Product
    {
        public string Nimi { get; set; }
        public float Hinta { get; set; }

        public Product (string nimi, float hinta)
        {
            Nimi = nimi;
            Hinta = hinta;
        }
    }
}
