using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4_tehtava_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pohdi jokin reaalimaailman asia, jonka kautta voit toteuttaa pienimuotoisen C#-ohjelman/toteutuksen, joka käyttää perintää.
            int i;

            // arvostellaan tilat
            Tilat tilat = new Tilat();
            
            Console.WriteLine("Tiloista lyhyesti?");
            tilat.Lyhyesti = Console.ReadLine();

            Console.Write("Tilojen Yleiskunto? (1-5): ");
            while(!int.TryParse(Console.ReadLine(), out i));
            tilat.Yleiskunto = i;

            Console.Write("Tilojen Siisteys? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            tilat.Siisteys = i;

            Console.Write("Tilojen Tilavuus? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            tilat.Tilavuus = i;

            Console.Write("Tilojen Taustaääni? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            tilat.TaustaAani = i;

            Console.WriteLine("Tilojen lopullinen arvostelu?");
            tilat.Pitemmasti = Console.ReadLine();

            // arvostellaan ateria
            Ateria ateria = new Ateria();

            Console.WriteLine("Annoksesta lyhyesti?");
            ateria.Lyhyesti = Console.ReadLine();

            Console.Write("Annoksen koko? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            ateria.AnnosKoko = i;

            Console.Write("Annoksen somittelu? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            ateria.AnnoksenSomittelu = i;

            Console.Write("Annoksen maku? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            ateria.Maku = i;

            Console.WriteLine("Annoksen lopullinen arvostelu?");
            ateria.Pitemmasti = Console.ReadLine();

            // arvostellaan laskutus
            Laskutus laskutus = new Laskutus();

            Console.WriteLine("Laskutuksesta lyhyesti?");
            laskutus.Lyhyesti = Console.ReadLine();

            Console.Write("Maksuvälineet?");
            laskutus.MaksuTavat = Console.ReadLine();
            
            Console.Write("Laskutuksen kohteliaisuus? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            laskutus.Kohteliaisuus = i;
            
            Console.Write("Laskutuksen asenne? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            laskutus.Asenne = i;
            
            Console.Write("Laskutuksen palvelu into? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            laskutus.PalveluInto = i;

            Console.Write("Laskutuksen toiminnon ripeys? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            laskutus.ToiminnonRipeys = i;

            Console.WriteLine("Laskutuksen yhteenveto?");
            laskutus.Pitemmasti = Console.ReadLine();

            // arvostellaaan tarjoilu
            Tarjoilu tarjoilu = new Tarjoilu();

            // lyhyesti
            Console.WriteLine("tarjoilusta lyhyesti?");
            tarjoilu.Lyhyesti = Console.ReadLine();
            // kohteliaisuus
            Console.Write("tarjoilun kohteliaisuus? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            tarjoilu.Kohteliaisuus = i;
            // asenne
            Console.Write("tarjoilun asenne? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            tarjoilu.Asenne = i;
            // palvelu into
            Console.Write("tarjoilun palvelu into? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            tarjoilu.PalveluInto = i;
            // ripeys
            Console.Write("tarjoilun ripeys? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            tarjoilu.Ripeys = i;
            // opastus
            Console.Write("tarjoilun opastus? (1-5): ");
            while (!int.TryParse(Console.ReadLine(), out i)) ;
            tarjoilu.Opastus = i;

            Console.WriteLine(tilat.ToString());
            Console.WriteLine(ateria.ToString());
            Console.WriteLine(laskutus.ToString());
            Console.WriteLine(tarjoilu.ToString());

        }
    }
}
