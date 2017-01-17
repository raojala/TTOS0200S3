using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class CD_Levy
    {
        public string Artisti { get; set; }
        public string LevynNimi { get; set; }
        public float Hinta { get; set; }
        public string[] Laulut { get; set; }
        public enum Genre
        {
            Pop,
            EdmDance,
            Party,
            HipHop,
            Rock,
            Romantic,
            IndieAlternative,
            Metal,
            Jazz,
            Soul,
            Country,
            Folk,
            Classic,
            Reggae,
            Funk,
            Punk,
            Blues,
            Games
        } ;
        public Genre genre { get; set; }

        public override string ToString()
        {
            string s = Artisti +", "+ LevynNimi + ", " + Hinta + ", " + genre;
            foreach (string ss in Laulut)
            {
                s += "\n" + ss;
            }
            return s;
        }
    }
}
