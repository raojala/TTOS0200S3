using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_tehtava_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 0;

            Console.WriteLine("anna luku");
            luku = int.Parse(Console.ReadLine());

            switch (luku)
            {
                case 1:
                    Console.WriteLine("syöttämäsi luku on yksi");
                    break;
                case 2:
                    Console.WriteLine("syöttämäsi luku on kaksi");
                    break;
                case 3:
                    Console.WriteLine("syöttämäsi luku on kolme");
                    break;
                default:
                    Console.WriteLine("syöttämäsi luku on jokin muu kuin 1-3");
                    break;
            }
        }
    }
}
