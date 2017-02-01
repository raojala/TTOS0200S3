using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Noppa
    {
        Random rand = new Random();
        int heitto = 0,
            max = 7,
            min = 0;
        public int Value { get { return heitto; } }

        public void NopanHeitto ()
        {
            heitto = rand.Next(min, max);
        }
    }
}
