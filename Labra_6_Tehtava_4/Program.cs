using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra_6_Tehtava_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tehtävä 4 home Kotitehtävä
            Toteuta ohjelma, jolla voidaan lisätä, poistaa ja listata SM-Liiga-joukkueen
            JYP pelaajia. Luo Pelaaja-luokka jolla on ominaisuudet Etunimi, Sukunimi, Ikä ja Numero.
            Löydät täältä JYP pelaajat kaudella 2016-17. 
            
            Luo myös Joukkue-luokka. Luokalla on ominnaisuudet Nimi, Kotikaupunki ja Pelaajat. 
            Ominaisuus Pelaajat on siis lista Pelaaja-olioita. 
            
            Tee Joukkue-luokalle sisäinen metodi HaePelaajat(string joukkue), jota konstruktori kutsuu. HaePelaajat metodi luo
            Pelaajat-listaan oikeat pelaajat.

            Bonustehtävä: missä ja miten pitäisi pelaajatietoja silloin tallessa kun ohjelma ei ole käynnissä? 
            Listaa erilaiset vaihtoehdot. Toteuta niistä tekstitiedosto-pohjainen ratkaisu.*/

            Joukkue joukkue = new Joukkue();

            joukkue.TallennaPelaajat();


        }
    }
}
