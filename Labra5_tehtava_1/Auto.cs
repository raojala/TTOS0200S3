using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace JAMK.IT
{
    class Auto
    {
        List<Rengas> renkaat = new List<Rengas>();
        int renkaidenLkm = 4;

        public List<Rengas> Renkaat
        {
            get { return renkaat; }
        }
        public string Merkki { get; set; }
        public string Malli { get; set; }
        public int RenkaidenLkm
        {
            get { return renkaidenLkm; }
            set
            {
                if (value < 3)
                {
                    renkaidenLkm = 3;
                }
                else
                {
                    renkaidenLkm = value;
                }
            }
        }
        public Auto (int renkaidenMaara)
        {
            RenkaidenLkm = renkaidenMaara;
        }

        public void LisaaRengas (Rengas rengas)
        {
            if (renkaat.Count < renkaidenLkm)
            {
                renkaat.Add(rengas);
            }           
        }
    }
}
