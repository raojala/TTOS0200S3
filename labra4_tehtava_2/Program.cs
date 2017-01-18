using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra4_tehtava_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Amp amp = new Amp();

            amp.CurValue = 30;

            Console.WriteLine("current volume: " + amp.ToString());
        }
    }
}
