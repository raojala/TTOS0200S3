using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra4_tehtava_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boat = new Boat();
            Bicycle bicycle = new Bicycle();

            boat.Nimi = "Inkeri";
            boat.Malli = "kakka";
            boat.Vuosimalli = 2007;
            boat.Color = "Ruskea";
            boat.Tyyppi = Boat.VeneenTyyppi.Kanootti;
            boat.IstuinPaikat = 2;

            bicycle.Nimi = "Tunturi";
            bicycle.Malli = "Rust";
            bicycle.Vuosimalli = 1987;
            bicycle.Color = "Valkoinen";
            bicycle.OnkoVaihteet = true;
            if (bicycle.OnkoVaihteet)
            {
                bicycle.VaihteidenMalli = "KAKKAVAIHTETE";
            }

            Console.WriteLine(bicycle.ToString());
            Console.WriteLine(boat.ToString());
        }
    }
}
