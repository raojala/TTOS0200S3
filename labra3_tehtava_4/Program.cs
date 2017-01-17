using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra3_tehtava_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Luo Vehicle-luokka seuraavien tietojen mukaisesti:

                ominaisuudet

                Name:string
                Speed:int
                Tyres:int

                toiminnot

                PrintData(), tulostaa Vehiclen ominaisuudet näytölle
                ToString():string, palauttaa kaikki Vehiclen ominaisuudet yhtenä merkkijonona

                Toteuta Vehicle-luokan ohjelmointi sekä pääohjelma, jolla luot olion Vehicle-luokasta.
                Muuta olion arvoja ja tulosta olion arvoja konsolille.
             
             */

            Vechile vechile0 = new Vechile("Firraarii", 80, 18);
            Vechile vechile1 = new Vechile("Fiat", 150, 14);
            Vechile vechile2 = new Vechile("Lada", 199, 15);
            Vechile vechile3 = new Vechile("Kikkeliritarin auto", 200, 25);

            vechile0.PrintData();
            vechile1.PrintData();
            vechile2.PrintData();
            vechile3.PrintData();

            vechile0.ToString();
            vechile1.ToString();
            vechile2.ToString();
            vechile3.ToString();
        }
    }
}
