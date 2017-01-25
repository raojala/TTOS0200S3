using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Name_Generator
    {
        public static string FirstName(Random r)
        {
            string Etunimi = "";
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            // etunimi
            for (int i = 0; i < 4; i++)
            {
                Etunimi += chars[r.Next(0, chars.Length)];
            }
            return Etunimi;
        }
        public static string SurName(Random r)
        {
            string Sukunimi = "";
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // sukunimi
            for (int i = 0; i < 10; i++)
            {
                Sukunimi += chars[r.Next(26)];
            }

            return Sukunimi;
        }
    }
}
