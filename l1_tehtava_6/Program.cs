using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1_tehtava_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float matka = 0F, bensaHinta = 1.595F, kokonaisKulutus = 0F, kokonaisHinta = 0F, autonKulutus = 0F;
            

            autonKulutus = 7.02F / 100;

            Console.WriteLine("Kuinka pitkä matka?");
            matka = float.Parse(Console.ReadLine());

            kokonaisKulutus = autonKulutus * matka;
            kokonaisHinta = kokonaisKulutus * bensaHinta;

            Console.WriteLine("Bensaa kuluu: {0}. Kustannus: {1:F2}", kokonaisKulutus, kokonaisHinta);

        }
    }
}
