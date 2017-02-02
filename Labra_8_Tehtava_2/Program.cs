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
            /*
            sovellus, jolla voit hallita ostoskärryn sisältöä. 
            
            TUOTE , NIMI JA HINTA
            
            Toteuta Product-luokka ja lisää pääohjelmassa esimerkiksi 
            
            List-tietorakenteeseen muutamia Product-luokan oliota. 
            
            Tulosta lopuksi kokoelman sisältö.
            */

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
            List<Product> tuotteet = new List<Product>();

            try
            {
                tuotteet.Add(new Product("Maggara", 2.0f));
                tuotteet.Add(new Product("Galija", 1.0f));
                tuotteet.Add(new Product("Borkkana", 0.50f));
                tuotteet.Add(new Product("Beruna", 3.25f));

                foreach (Product p in tuotteet)
                {
                    Console.WriteLine(p.ToString());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
