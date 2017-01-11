using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello1
{
    class Henkilo
    {
        public string Nimi { get; set; }
        public int Ika { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
        }

        static void ShowNames (Henkilo[] henkilo)
        {
            // TODO
            Array.Sort(henkilo, (x, y) => String.Compare(x.Nimi, y.Nimi));
            foreach (Henkilo h in henkilo)
            {
                Console.WriteLine(h.Nimi);
            }
            Console.WriteLine("ohjelma suoritettu onnistuneesti");
        }
        // Array.Sort(names, (x,y) => String.Compare(x.Name, y.Name));

        static void SayHello()
        {
            // luodaan olio henkilö luokasta
            Henkilo[] hlo = new Henkilo[5];

            // luodaan henkilö oliot
            for (int i = 0; i < 5; i++)
            {
                hlo[i] = new Henkilo();
            }

            Console.WriteLine("anna nimi");
            hlo[0].Nimi = Console.ReadLine();

            Console.WriteLine("anna nimi");
            hlo[1].Nimi = Console.ReadLine();

            Console.WriteLine("anna nimi");
            hlo[2].Nimi = Console.ReadLine();

            Console.WriteLine("anna nimi");
            hlo[3].Nimi = Console.ReadLine();

            Console.WriteLine("anna nimi");
            hlo[4].Nimi = Console.ReadLine();

            ShowNames(hlo);

        }



    }
}
