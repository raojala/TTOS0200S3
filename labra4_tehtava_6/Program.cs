using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra4_tehtava_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ICT-opiskelijan kirjahyllystä löytyy vaikka mitä erilaisia tavaroita: kirjoja, 
             * lehtiä, cd-levyjä, dvd-levyjä, bluray-levyjä, puhelimia, tabletteja, läppäreitä, ... 
             * jne. Pohdi UML-kaaviota käyttäen millaisia luokkarakenteita (ainakin luokkien ja 
             * ominaisuuksien osalta) esiintyy ja käytä apua perintää, jos tavaroille löytyy yhteisiä
             * ominaisuuksia. Toteuta tämän jälkeen muutamia luokkia, joissa perintää esiintyy. 
             * Tee myös pääohjelma, jossa käytät tekemiäsi luokkia ja luot olioita.*/

            // ruuvari, munakello, hieromatuolipäällynen

            Mensseli mensseli = new Mensseli();
            Munakello munakello = new Munakello();
            Hierontaistuin hieronta = new Hierontaistuin();

            mensseli.Nimi = "Skruuvdrägare";
            mensseli.Arvo = 10f;
            mensseli.Paino = 0.400f;
            mensseli.Kuvaus = "aika kakka ruuvari";
            mensseli.MensselinTyyppi = Mensseli.Tyyppi.Tahti;
            mensseli.Koko = 12;

            munakello.Nimi = "Elmeri";
            munakello.Arvo = 20f;
            munakello.Paino = 0.240f;
            munakello.Kuvaus = "Rumasti huutava muna kello ettei makkarat pala uuniin.";
            munakello.Ajastin = 45f;
            munakello.AikaaJaljella = 45f;

            hieronta.Nimi = "Elviira";
            hieronta.Arvo = 40f;
            hieronta.Paino = 1.45f;
            hieronta.Kuvaus = "Tuolin päälle lisättävä hieronta laite jonka päällä voi istua";
            hieronta.HierontaOhjelma = Hierontaistuin.Ohjelma.Shiatsu;
            hieronta.Lammitin = false;
            hieronta.Pikahieronta = true;

            Console.WriteLine(mensseli.ToString());
            Console.WriteLine(munakello.ToString());
            Console.WriteLine(hieronta.ToString());

        }
    }
}
