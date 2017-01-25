using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5_tehtava_4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Tehtävä 4 home Kotitehtävä
            Pohdi jokin reaalimaailman asia, jonka kautta voit toteuttaa pienimuotoisen C#-ohjelman/toteutuksen, joka käyttää koostamista. 

            1. Suunnittele luokkarakenne UML-kaaviona.
            2. Laadi tarvittavat luokat ja testipääohjelma.
            */

            Human bob = new Human();

            bob.Nimi = "Bob";
            bob.NpcId = 1;
            bob.Aly = 10;
            bob.Voima = 6;
            bob.Ika = 24;
            bob.Paino = 74f;
            bob.Pituus = 176f;

            Console.WriteLine("bobin statsit");
            Console.WriteLine("nimi: " + bob.Nimi);
            Console.WriteLine("NpcId: " + bob.NpcId);
            Console.WriteLine("Aly: " + bob.Aly);
            Console.WriteLine("Voima: " + bob.Voima);
            Console.WriteLine("Ika: " + bob.Ika);
            Console.WriteLine("Paino: " + bob.Paino);
            Console.WriteLine("Pituus: " + bob.Pituus);

        }
    }
}
