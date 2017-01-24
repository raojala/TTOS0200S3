using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5_tehtava_2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Tehtävä 2
             Pohdi jääkaappia reaalimaailman käsitteenä ja erityisesti sitä mitä sieltä löytyy. 
             Tee pienimuotoinen toteutus, joka koostaa jääkaapin sisältöä muutamista eri asioista/olioista.
            */

            Fridge fridge = new Fridge();
            RuokaAines aines1 = new RuokaAines("Maito");
            RuokaAines aines2 = new RuokaAines("Makkara");
            RuokaAines aines3 = new RuokaAines("Porkkana");

            fridge.LisaaAines(aines1);
            fridge.LisaaAines(aines2);
            fridge.LisaaAines(aines3);

            Console.WriteLine("Jääkaapissa");
            foreach (RuokaAines r in fridge.RuokaAines)
            {
                Console.WriteLine(r.Nimi);
            }

            Console.WriteLine("Syödään maggara");
            fridge.PoistaAines(aines2);

            Console.WriteLine("Jääkaapissa");
            foreach (RuokaAines r in fridge.RuokaAines)
            {
                Console.WriteLine(r.Nimi);
            }


        }
    }
}
