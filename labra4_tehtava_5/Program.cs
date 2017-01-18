using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra4_tehtava_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();
            Radio radio2 = new Radio();

            radio.Volyymi = 100;
            radio.Taajuus = 2000.0f;
            radio.OnkoPaalla = true;

            radio2.Volyymi = 85;
            radio2.Taajuus = 4548;
            radio2.OnkoPaalla = true;

            Console.WriteLine(radio.ToString());
            Console.WriteLine(radio2.ToString());
        }
    }
}
