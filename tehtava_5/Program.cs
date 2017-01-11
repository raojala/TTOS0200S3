using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sekunnit = 0, minuutit = 0, tunnit = 0;

            Console.WriteLine("anna sekunttimäärä");
            sekunnit = int.Parse(Console.ReadLine());

            tunnit = sekunnit / 3600;
            sekunnit = sekunnit % 3600;

            minuutit = sekunnit / 60;

            sekunnit = sekunnit % 60;

            Console.WriteLine("{0}:{1}:{2}", tunnit, minuutit, sekunnit);


        }
    }
}
