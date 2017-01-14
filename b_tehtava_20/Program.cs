using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_tehtava_20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tehtävä 20
            // Toteuta jokin oma villi-ideasi ja yllätä opettaja toteutuksellasi.

            // ajastin
            // huvikseni käytän goto kohta; korvaamaan looppeja testimielessä.

            int timer = 0;

            // kysytään käyttäjältä montako sekuntia ajastimeen syötetään
            Console.WriteLine("Ajastimen aika (sekunteina): ");
            ask:
            if(!int.TryParse(Console.ReadLine(), out timer))
            {
                Console.WriteLine("not a float");
                goto ask;
            }

            int now = DateTime.Now.Second;

        timerLoop:
            if (now < DateTime.Now.Second)
            {
                timer--;
                now = DateTime.Now.Second;
                if (now >= 59)
                    now = 0;
                Console.WriteLine(timer);
            }
            if (timer <= 0)
                goto stopProgram;
            goto timerLoop;

        stopProgram:;
        }
    }
}
