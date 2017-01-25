using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra_6_Tehtava_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Person temp;

            DateTime start = DateTime.Now, end;

            List<Person> persons = new List<Person>();

            for (int i = 0; i < 10000; i++)
            {
                temp = new Person(rand);
                persons.Add(temp);
            }

            end = DateTime.Now;

            Console.WriteLine("persons added. Time: " + (end - start));
            Console.WriteLine("Random Person: " + persons[rand.Next(persons.Count)]);

            // find person by random name
            start = DateTime.Now;
            for (int i = 0; i < 1000; i++)
            {
                FindPerson(persons, rand);
            }
            end = DateTime.Now;
            Console.WriteLine("Time it took to find names: " + (end - start));

            /*
                Bonus+Tehtävä 5
                List-tietorakenteeseen lisätään satunnaisesti luotuja Person-luokan oliota 10.000 kappaletta.
                
                Person-luokan olion etunimessä on käytettävä satunnaisesti kirjaimia väliltä A-Z ja etunimen pituus on 4 merkkiä.
                Sukunimi samoin, mutta pituus on 10 merkkiä.

                Ohjelman tulee tulostaa henkilöiden lisäykseen kulunut aika millisekunteina.
                
                Etsi tämän jälkeen tietorakenteesta 1000 satunnaista henkilöä rekisteristä etunimen perusteella. 
                Tulosta löydettyjen henkilöiden tiedot sekä hakuun
                yhteensä kulunut aika millisekuntteina.

                Esimerkkitoiminta:
    
                Kokeile samaa Dictionary-rakenteelle, käytä avaimena etunimeä. Muista sisällyttää rakenteeseen 10.000 alkiota ja aloittaa satunnainen haku vasta sen jälkeen. Muista, että Dictonary kokoelmassa ei voi olla kahta samaa avainta.

                Esimerkkitoiminta:


                    Dictionary Collection:
                    - Adding time : xx ms
                    - Persons count : 10000
                    - Random person : SQKP BOIYJURHIE VWDMKNJPKBG

                    Finding persons in collection (by firstname):
                    - Found person with ENGR firstname : ENGR NYHOKHXSME 
                    - Found person with QFQX firstname : QFQX BYTRKKAJDF 
                    - Found person with FAQI firstname : FAQI AJYBJIDWLL 
                    - Found person with JJQS firstname : JJQS WUPNIPXWHJ 
                    - Found person with YWSJ firstname : YWSJ MCPRUIJPOX 
                    - Found person with TTTF firstname : TTTF BVLGVOSHSA 
                    - Found person with STST firstname : STST YHIALLHQJN 
                    - Found person with QRJH firstname : QRJH DJDYWITDRM 
                    - Found person with XCOH firstname : XCOH NIQRIACAJI 
                    - Found person with NKNM firstname : NKNM LSQMRQAFPJ 
                    - Found person with REVI firstname : REVI DQVFRQQGYU 
                    - Found person with GVPO firstname : GVPO GQOAKJUHAH 
                    - Found person with IYIQ firstname : IYIQ ASAVXHKYKQ 
                    - Found person with VKHV firstname : VKHV DOVNHWOQDA 
                    - Found person with WVWN firstname : WVWN TQNBJBCLNF 
                    - Found person with YQPF firstname : YQPF PPOJUTJHGF 
                    - Found person with DGOP firstname : DGOP ANMHNUXSIS 
                    - Found person with MNGV firstname : MNGV UVWWOUKSPE 
                    - Found person with YYIB firstname : YYIB FWOSQBFANJ 
                    - Found person with NVVD firstname : NVVD LVFETNIVWK 
                    - Found person with KDNA firstname : KDNA URXQKPIISG 
                    - Found person with EKDE firstname : EKDE IQLPJAAWHI 
                    - Found person with NBLY firstname : NBLY KSXSQAANTY 
                    - Found person with BFSR firstname : BFSR PNCWVACIRJ 
                    - Found person with UNVV firstname : UNVV RYPGKOHDJG 
                    - Found person with VJPA firstname : VJPA CSFXJVQMOM 
                    - Found person with QFHP firstname : QFHP FWISPWLMET 
                    - Found person with DFPU firstname : DFPU TSRXGQWLQI 
                    - Found person with YDXM firstname : YDXM TOHSVSAEIU 
                    - Found person with MTWH firstname : MTWH OHFHXUGAAC 
                    - Found person with WUAB firstname : WUAB FCDKGECMMY 
                    - Found person with LATH firstname : LATH KQYLVLFONL 

                    - Persons tried to fiend : 1000
                    - Total finding time : xx ms

                    Press enter key to continue...
    
                Millaisia eroja nopeuksissa havaitsit?
             */
        }

        public static void FindPerson (List<Person> p, Random r)
        {
            string s = Name_Generator.FirstName(r);
            foreach (Person person in p)
            {
                if (person.Etunimi == s)
                {
                    Console.WriteLine("found: " + person.ToString() + " with random name generator");
                }
            }
        }
    }
}
