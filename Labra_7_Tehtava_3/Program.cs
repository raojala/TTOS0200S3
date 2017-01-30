using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra_7_Tehtava_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tehtävä 3

            Tee ohjelma, joka kysyy käyttäjältä lukuja (joko kokonaisluku tai reaaliluku) ja tallenna kokonaisluvut
            eri tiedostoon kuin reaaliluvut. Sovellus tulee lopettaa, jos käyttäjä ei syötä kokonais- tai reaalilukua.
            Tarkista tiedostojen sisältö jollain tekstieditorilla.

            Esimerkkitulostus:

                Give a number (enter or not a number ends) : 1,0
                Give a number (enter or not a number ends) : 2,0
                Give a number (enter or not a number ends) : 3,0
                Give a number (enter or not a number ends) : 4
                Give a number (enter or not a number ends) : 5
                Give a number (enter or not a number ends) : 6
                Give a number (enter or not a number ends) :
    
                Contents of T2Integers.txt:
                4
                5
                6

                Contents of T2Doubles.txt:
                1,0
                2,0
                3,0
             */

            try
            {
                List<float> floatList = new List<float>();
                List<int> intList = new List<int>();
                string s;
                int i; float f;
                do
                {
                    Console.WriteLine("Anna kokonaisluku TAI reaaliluku joku muu kuin numero lopettaa.");
                    s = Console.ReadLine();
                    if (int.TryParse(s, out i))
                    {
                        intList.Add(i);
                    }
                    else if (float.TryParse(s, out f))
                    {
                        floatList.Add(f);
                    }
                }
                while (int.TryParse(s, out i) || float.TryParse(s, out f));

                using (StreamWriter sw = new StreamWriter("intoutput.txt"))
                {
                    foreach (int integer in intList)
                    {
                        sw.WriteLine(integer);
                    }
                }
                using (StreamWriter sw = new StreamWriter("floatoutput.txt"))
                {
                    foreach (float floatter in floatList)
                    {
                        sw.WriteLine(floatter);
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
