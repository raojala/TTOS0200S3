using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5_tehtava_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Tehtävä 1
                Tee Rengas-luokka, jolla on seuraavat ominaisuudet: merkki, tyyppi ja rengaskoko. Tee tämän jälkeen Kulkuneuvo-luokka muutamilla kulkuneuvoon kuuluvilla ominaisuuksilla (nimi, malli) ja käytä tekemääsi Rengas-luokkaa apuna renkaiden käsittelyyn. Tässä vaiheessa voit koostaa kulkuneuvon renkaat Rengas-olioina esim. taulukkoon tai kurssimateriaalissa esitettyy List-rakenteeseen (kokoelmaluokat käsitellään tarkemmin seuraavissa demoissa). Tee pääohjelma, jossa luot muutamia kulkuneuvoja (esim. auto ja moottoripyörä) renkaineen. Tietoja ei tarvitse kysyä käyttäjältä, vaan voit alustaa niitä suoraan pääohjelman koodissa.

                Esimerkkitoiminta:


                    Created a new vehichle Porsche model 911
                    Tyre Nokia added to vehicle Porsche
                    Tyre Nokia added to vehicle Porsche
                    Tyre Nokia added to vehicle Porsche
                    Tyre Nokia added to vehicle Porsche
    
                    Vechicle Name: Porsche Model:911
                    Tyres:
                    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
                    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
                    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
                    -Name: Nokia Model:Hakkapeliitta TyreSize:205R16
    
                    Created a new vehichle Ducati model Diavel
                    Tyre MIC added to vehicle Ducati
                    Tyre MIC added to vehicle Ducati
    
                    Vechicle Name: Ducati Model:Diavel
                    Tyres:
                    -Name: MIC Model:Pilot TyreSize:160R17
                    -Name: MIC Model:Pilot TyreSize:140R16    
                    ...
             */

            List<Auto> autot = new List<Auto>();

            bool poop = true;

            Auto tempAuto;
            Rengas tempRengas;

            for (int i = 0; i < 2; i++)
            {
                tempAuto = new Auto(4);

                Console.WriteLine("Auton Merkki");
                tempAuto.Merkki = Console.ReadLine();

                Console.WriteLine("Auton Malli");
                tempAuto.Malli = Console.ReadLine();

                for (int y = 0; y < tempAuto.RenkaidenLkm; y++)
                {
                    tempRengas = new Rengas();
                    tempRengas.Valmistaja = "Nokia";
                    tempRengas.Malli = "3110";
                    tempRengas.Rengaskoko = 15;
                    tempRengas.Tyyppi = "Talvi";
                    tempAuto.LisaaRengas(tempRengas);
                }
                autot.Add(tempAuto);
            }

            foreach (Auto a in autot)
            {
                Console.WriteLine("Merkki: " + a.Merkki + ", Malli: " + a.Malli);
                foreach (Rengas r in a.Renkaat)
                {
                    Console.WriteLine("Renkaan valmistaja: " + r.Valmistaja + ", malli: " + r.Malli + ", tyyppi: " + r.Tyyppi + ", koko: " + r.Rengaskoko);
                }
            }


        }
    }
}
