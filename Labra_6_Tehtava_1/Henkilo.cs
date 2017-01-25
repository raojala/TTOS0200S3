using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    /// <summary>
    /// Thiss class contains person properties
    /// </summary>
    class Henkilo
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Hetu { get; set; }
        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + Hetu;
        }
    }

    /// <summary>
    /// This class person information in a collection
    /// </summary>
    class Henkilot
    {
        private List<Henkilo> henkilot;

        public List<Henkilo> Henkilolista
        {
            get { return henkilot; }
        }

        public Henkilot ()
        {
            henkilot = new List<Henkilo>();
        }

        public void LisaaHenkilo (Henkilo h)
        {
            henkilot.Add(h);
        }
        public Henkilo HaeHenkilo(int index)
        {
            if (index < henkilot.Count)
            {
                return henkilot.ElementAt(index);
            }
            else
                return null;
        }

        public Henkilo HaeHenkiloHetulla(string s)
        {
            foreach (Henkilo h in henkilot)
            {
                if (h.Hetu == s)
                {
                    return h;
                }
            }
            return null;
        }
    }
}
