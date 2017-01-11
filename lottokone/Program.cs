using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottokone
{
    class LottoLappu
    {
        int maara;
        LottoRivi[] rivi;

        public int Maara
        {
            get
            {
                return maara;
            }
            set
            {
                maara = value;
            }
        }

        public void Create ()
        {
            rivi = new LottoRivi[maara];

            for (int i = 0; i < maara; i++)
            {
                rivi[i] = new LottoRivi();
                rivi[i].Create();
            }

            for (int i = 0; i < rivi.Length; i++)
            {
                for (int x = i+1; x < rivi.Length; x++)
                {
                    bool makeNew = true;

                    for (int y = 0; y < rivi.Length; y++)
                    {
                        
                        for (int z = y + 1; z < rivi[i].Rivi.Length; z++)
                        {
                            if (rivi[i].Rivi[y] != rivi[x].Rivi[z])
                            {
                                makeNew = false;
                            }
                        }
                    }

                    if (makeNew)
                    {
                        Console.WriteLine("remake line " + rivi[x]);
                        rivi[x].Create();
                    }
                }
            }
        }

        public void Print ()
        {

            for (int i = 0; i < rivi.Length; i++)
            {
                foreach (int x in rivi[i].Rivi)
                {
                    Console.Write(x + ", ");
                }
                Console.WriteLine();
            }
        }
    }

    class LottoRivi
    {
        Random rand;

        int[] rivi = new int[7];

        public int[] Rivi
        {
            get
            {
                return rivi;
            }
        }

        public void Create ()
        {
            for (int i = 0; i < rivi.Length; i++)
            {
                rand = new Random();
                rivi[i] = rand.Next(1, 40);
            }

            for (int i = 0; i < rivi.Length; i++)
            {
                for (int x = i+1; x < rivi.Length; x++)
                {
                    while (rivi[i] == rivi[x])
                    {
                        rand = new Random();
                        rivi[x] = rand.Next(1, 40);
                    }
                }
            }
            Array.Sort(rivi);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            LottoLappu lappu = new LottoLappu();

            Console.WriteLine("montako riviä pelaat lottoa?");
            lappu.Maara = int.Parse(Console.ReadLine());

            lappu.Create();
            lappu.Print();

        }

    }
}
