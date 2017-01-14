using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b_tehtava_18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tehtävä 18
            // Tee ohjelma, joka kysyy käyttäjältä merkkijonon(lause).
            // Sovelluksen tulee ilmoittaa käyttäjälle oliko annettu merkkijono palidromi.

            Console.WriteLine("Give a sentence to check for palindrome");
            string s = Console.ReadLine();

            if (IsPalindrome(s))
            {
                Console.WriteLine("{0} is palindrome", s);
            }
            else
            {
                Console.WriteLine("{0} is not palindrome", s);
            }
        }

        // A man, a plan, a canal: Panama.

        static bool IsPalindrome(string s)
        {

            int fromBeginning = 0, fromEnd = s.Length - 1;

            // iteroidaan jokainen kirjain alusta ja lopusta 1 kerrallaan kunnes ensimmäinen ja viimeinen indexi on sama
            for (fromBeginning = 0; fromBeginning < fromEnd; fromBeginning++, fromEnd--)
            {
                // luetaan pois erikoismerkit alusta
                while (!char.IsLetterOrDigit(s[fromBeginning]))
                {
                    fromBeginning++;
                }

                // luetaan pois erikoismerkit lopusta
                while (!char.IsLetterOrDigit(s[fromEnd]))
                {
                    fromEnd--;
                }

                // palautetaan false jos kirjaimet eivät ole samat
                if (char.ToLower(s[fromBeginning]) != char.ToLower(s[fromEnd]))
                {
                    return false;
                }
            }
            // palautetaan tosi koska kaikki oli samat ja kirjaimet loppu
            return true;
        }
    }
}
