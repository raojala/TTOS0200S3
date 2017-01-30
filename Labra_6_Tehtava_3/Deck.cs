using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Deck
    {
        public List<Card> cards;
        
        public Deck ()
        {
            cards = new List<Card>();
            Card card;

            for (int i = 0; i < 4; i++)
            {
                for (int y = 1; y <= 13; y++)
                {
                    card = new Card();
                    card.CardValue = y;
                    if (i == 0)
                        card.CardSuite = Card.Suite.Clubs;
                    else if (i == 1)
                        card.CardSuite = Card.Suite.Hearts;
                    else if (i == 2)
                        card.CardSuite = Card.Suite.Spades;
                    else if (i == 3)
                        card.CardSuite = Card.Suite.Diamonds;

                    cards.Add(card);

                }
            }
        }

        public Card DrawCard()
        {
            Random rnd = new Random();
            Card card = cards[rnd.Next(0, cards.Count)];
            cards.Remove(card);
            return card;
        }

    }
}
