using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5_tehtava_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Tehtävä 3
            
            Luo abstrakti luokka Nisakas, jolla on Ika-ominaisuus sekä Liiku-metodi, jonka toteutus on jätetty toteuttamatta (abstrakti metodi).

            Peri Nisakas-luokasta Ihminen-luokka.
            Ihmisellä on ominaisuuksina ihmiseen yleisesti liittyviä ominaisuuksia (paino, pituus, nimi). 
            lisää Ihminen-luokkaan metodit: Liiku ja Kasva. 
            joista ensimmäinen tulostaa ruutuun "liikun" ja
            jälkimmäinen lisää ihmisen ikää yhdellä vuodella. Huomioi, että Liiku-metodi ja Ikä-ominaisuus on Nisakas-luokassa

            Peri Ihminen-luokasta Vauva- ja Aikuinen-luokat. Ylikirjoita Vauva-luokassa yliluokan Liiku-metodi tulostamaan "konttaa".
            Ylikirjoita Aikuinen-luokassa myös sama metodi ja laita se tulostamaan "kävelee". Lisää aikuiselle ominaisuus auto (String).
            Lisää vauvalle ominaisuus vaippa (String).

            Toteuta pääohjelmassa muutamia ihmisiä, aikuisia ja vauvoja. Tulostele olioiden tietoja konsolille.
            */

            Vauva vauva = new Vauva();
            Aikuinen aikuinen = new Aikuinen();

            vauva.Age = 0;
            vauva.Name = "poopfactory";
            vauva.Height = 50f;
            vauva.Weight = 5f;
            vauva.Vaippa = "pamppers";
            vauva.Grow();
            vauva.Move();

            aikuinen.Name = "jooseppi";
            aikuinen.Age = 25;
            aikuinen.Weight = 90f;
            aikuinen.Height = 178f;
            aikuinen.Auto = "ooppeli";

            aikuinen.Grow();
            aikuinen.Move();

            Console.WriteLine(aikuinen.Name);
            Console.WriteLine(aikuinen.Age);
            Console.WriteLine(aikuinen.Weight);
            Console.WriteLine(aikuinen.Height);
            Console.WriteLine(aikuinen.Auto);

            Console.WriteLine(vauva.Name);
            Console.WriteLine(vauva.Age);
            Console.WriteLine(vauva.Weight);
            Console.WriteLine(vauva.Height);
            Console.WriteLine(vauva.Vaippa);

        }
    }
}
