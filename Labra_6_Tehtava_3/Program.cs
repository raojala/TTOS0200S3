using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra_6_Tehtava_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Tehtävä 3 home Kotitehtävä
            Toteuta ohjelma, joka tallentaa kaikki korttipelin kortit (hertta, ruutu, risti ja pata. Numerot 1-52.) 
            valitsemaasi tietorakenteeseen ja tulostaa tietorakenteen sisällön. Bonustehtävä: kuinka voisit
            toteuttaa korttipakan sekoittamisen?
            */

            Deck deck = new Deck();

            List<Card> cards = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                cards.Add(deck.DrawCard());
            }

            //cards.Sort();

            foreach (Card c in cards)
            {
                Console.WriteLine(c.CardValue + " of " + c.CardSuite);
            }



        }
    }
}
