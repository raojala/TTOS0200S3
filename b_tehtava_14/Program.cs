using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_tehtava_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arvosana = new int[6];
            int input = 0;
            string s = "";
            bool kytkin = true;

            while (kytkin)
            {
                Console.WriteLine("Anna arvosana (9. stop input and print and quit)");
                s = Console.ReadLine();
                int.TryParse(s,out input);

                switch (input)
                {
                    case 0:
                        arvosana[0]++;
                        break;
                    case 1:
                        arvosana[1]++;
                        break;
                    case 2:
                        arvosana[2]++;
                        break;
                    case 3:
                        arvosana[3]++;
                        break;
                    case 4:
                        arvosana[4]++;
                        break;
                    case 5:
                        arvosana[5]++;
                        break;
                    case 9:
                        kytkin = false;
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < arvosana.Length; i++)
            {
                Console.Write(i + ". ");
                for (int x = 0; x < arvosana[i]; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
