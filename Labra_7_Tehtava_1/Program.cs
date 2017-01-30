using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra_7_Tehtava_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tehtävä 1 - Tiedostoon kirjoittaminen ja lukeminen
            Tee ohjelma, joka kirjoittaa käyttäjän antamat merkkijonot tiedostoon (lopetusehdon voit päättää itse) ja sulje tiedosto. Avaa tämän jälkeen tiedosto lukemista varten ja tulosta näyttölaitteelle tiedoston sisältö riveittäin. Huomioi mahdolliset poikkeukset, joita tiedoston käsittely voi aiheuttaa.

            Esimerkkitulostus:

                Give a text line (enter ends) : Matti
                Give a text line (enter ends) : Teppo
                Give a text line (enter ends) : Seppo
                Give a text line (enter ends) : Jorma
                Give a text line (enter ends) :
    
                Contents of T1TextLines.txt:
                Matti
                Teppo
                Seppo
                Jorma
             */

            List<string> input = new List<string>();

            while (true)
            {
                Console.WriteLine("Anna nimi zero (0) to exit.");
                input.Add(Console.ReadLine());
                switch (input[input.Count-1])
                {
                    case "0":
                        goto exit;
                }
            }
            exit:

            try
            {
                using (StreamWriter sw = new StreamWriter("output.txt"))
                {
                    for (int i = 0; i < input.Count; i++)
                    {
                        sw.WriteLine(input[i]);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }
    }
}
