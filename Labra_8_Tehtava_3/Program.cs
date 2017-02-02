using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                paaOhjelma();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void paaOhjelma ()
        {
            List<Elio> rekisteri = new List<Elio>();

            /*
            Toteuta pääohjelmassa kalastaja ja muutamia kaloja. 
            
            Tulosta lopuksi kalarekisterin sisältö. 
            */
            try
            {
                rekisteri.Add(new Kala("Hauki", 20f, 10f));
                rekisteri.Add(new Kala("Ahven", 12f, 13f));
                rekisteri.Add(new Kala("Särki", 2f, 3f));
                rekisteri.Add(new Kalastaja("Mauno", "045454545"));
                rekisteri.Add(new Kalapaikka("Jyväsjärvi", "Jyväskylä"));

                foreach (Elio e in rekisteri)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
