using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Person
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }

        public Person(Random r)
        {
            Etunimi = Name_Generator.FirstName(r);
            Sukunimi = Name_Generator.SurName(r);
        }

        public override string ToString()
        {
            return Etunimi + " " + Sukunimi;
        }
    }
}
