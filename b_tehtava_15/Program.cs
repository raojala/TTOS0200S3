using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_tehtava_15
{
    class Program
    {
        static void Main(string[] args)
        {

            int korkeus = 2; // tästä miinus 3 on ekan rivin pituus
            string[] rivit;
            string s = "";

            // tulostetaan kysymys, ja ajetaan if lauseen sulkujen sisällä integer korkeus muuttujaan
            // (jos ei saada integeriä käyttäjän syötöstä, mennään else haaraan ja tulostetaan virhe
            Console.WriteLine("kuusen korkeus? (minimi 2)");
            if (int.TryParse(Console.ReadLine(), out korkeus))
            {
                // jos korkeus on liien pieni ni niin tulostetaan että liian pieni ja suljetaan ohjelma (koska ohjelmassa ei ole mainlooppia)
                if (korkeus < 2)
                {
                    Console.WriteLine("Korkeus on liian pieni, ohjelma lopetetaan.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                rivit = new string[korkeus];

                // tehdään sisennykset merkillä #
                for (int i = 0; i < korkeus; i++)
                {
                    // eka rivi
                    if (i == 0)
                    {
                        s = "";
                        // mitä -3 tulee, katso kuva kuusirapellys.png
                        for (int x = 0; x < korkeus-3; x++)
                        {
                            s += "#";
                        }
                        rivit[i] = s;
                    }
                    else // toisesta rivistä eteenpäin
                    {
                        s = "";
                        for (int x = 0; x < korkeus - 3 - i; x++)
                        {
                            s += "#";
                        }
                        rivit[i] = s;
                    }
                }

                // tehdään merkit * kuusen muotoon sisennysten perään
                for (int i = 0; i < korkeus; i++)
                {
                    // ensimmäinen rivi
                    if (i == 0)
                    {
                        rivit[i] += "*";
                    }
                    else // toisesta rivistä eteenpäin
                    {
                        s = "";
                        // guom i+(i+1):lla saadaan tarvittavien tähtien määrä tulosteeseen. taas katso kuva kuusirapellys.png
                        // joka pitäisi olla solution explorerissa tehtava 15 alla.
                        for (int x = 0; x < i+(i+1); x++)
                        {
                            s += "*";
                        }
                        rivit[i] += s;
                    }

                    // muokataan kaksi viimeistä riviä vastaamaan ensimmäistä riviä jotta saadaan puun jalka
                    rivit[rivit.Length -1] = rivit[0];
                    rivit[rivit.Length -2] = rivit[0];
                }

                // vaihdetaan sisennyksen merkit '#' vastaamaan ' ' eli välilyöntiä.
                for (int i = 0; i < korkeus; i++)
                {
                    rivit[i] = rivit[i].Replace('#', ' ');
                }

                // tulostetaan puu
                foreach (string ss in rivit)
                {
                    Console.WriteLine(ss);
                }
            }
            else
            {
                Console.WriteLine("Not an integer!");
            }
        }
    }
}