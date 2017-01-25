using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Card
    {
        public int CardValue { get; set; }
        public Suite CardSuite { get; set; }

        public enum Suite
        {
            Hearts,
            Spades,
            Diamonds,
            Clubs
        }
    }
}
