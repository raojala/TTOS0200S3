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
            Toteuta ArrayCalcs-niminen luokka ja sen sisälle seuraavat staattiset-metodit: Sum, Average, Min ja Max. 
            
            Metodit ottavat parametriksi double[]-taulukon ja laskevat nimensä mukaisen laskutoimintuksen taulukon 
            alkioille ja palauttavat tuloksen kutsuvalle ohjelmalle.

            Toteuta pääohjelma ja esimerkiksi seuraavaa dataa sisältävä taulukko: 
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 }; 
            Kutsu pääohjelmasta ArrayCalcs-luokan staattisia laskutoimituksia tekeviä metodeja annetun taulukon arvoilla ja tulosta tulokset näyttölaitteelle.
    
            ArrayCalcs-luokan metodien testaaminen

            Toteuta solutioniin uusi yksikkötestaukseen liittyvä projekti ja testaa ArrayCalcs-luokan kaikki metodit.
            Kuinka ArrayCalcs-luokan metodit toimivat, jos välität parametrina tyhjän double[]-taulukon: double[] array = { };
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
            try
            {
                double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
                Console.WriteLine("Summa: " + ArrayCalcs.Sum(array));
                Console.WriteLine("Keskiarvo: " + ArrayCalcs.Average(array));
                Console.WriteLine("Suurin: " + ArrayCalcs.Max(array));
                Console.WriteLine("Pienin: " + ArrayCalcs.Min(array));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
