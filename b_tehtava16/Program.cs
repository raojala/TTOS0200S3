using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_tehtava16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Tehtävä 16
                arpoo satunnaisluvun väliltä 0-100.
                käyttäjää kehoitetaan arvaaman arvottu luku.
                antaa vihjeen arvauksen jälkeen onko arvottu luku pienempi vai suurempi.
                vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun.
                Tulosta lopuksi arvausten määrä näytölle.

                Esimerkkitoiminta:

                Arvaa luku > 50 [Enter]
                Luku on suurempi
                Arvaa luku > 75 [Enter]
                Luku on pienempi
                Arvaa luku > 66 [Enter]
                Hienoa, arvasit luvun 3 kerralla.
            */

            Random rand = new Random();
            int arvaus = 0, randomi = rand.Next(1, 101), yritykset = 0;
            bool loop = true;

            while (loop)
            {
                yritykset++;

                Console.Write("Arvaa luku > ");
                if (int.TryParse(Console.ReadLine(), out arvaus))
                {
                    if (arvaus == randomi)
                    {
                        Console.WriteLine("jee oikein {0}:lla yrityksellä!", yritykset);
                        loop = false;
                    }
                    else if (arvaus < randomi)
                    {
                        Console.WriteLine("Luku on suurempi");
                    }
                    else
                    {
                        Console.WriteLine("Luku on pienempi");
                    }

                }
                else
                {
                    Console.WriteLine("Not an integer!");
                }
            }
        }
    }
}
