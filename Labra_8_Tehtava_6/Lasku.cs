using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Lasku
    {
        public Dictionary<Product, int> Tuotteet { get; }
        public float Kokonaishinta { get; }

        public Lasku ()
        {
            Tuotteet = new Dictionary<Product, int>();
        }

        public void Ready ()
        {
            foreach (KeyValuePair<Product,int> pair in Tuotteet)
            {

            }
        }
    }
}
