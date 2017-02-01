using JAMK.IT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Labra_7_Tehtava_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tehtävä 4

            Tee ohjelma, jossa voidaan käsitellä TV-ohjelmia.
            
            TV-ohjelman tietoina tulee käsitellä: ohjelman nimi, kanava (jolta ohjelma tulee), alku- ja loppuaika
            sekä pienimuotoinen infoteksti ohjelmasta.
            
            Luo pääohjelmassa muutamia TV-ohjelmaolioita (tiedot voit alustaa suoraan koodista, ei tarvitse kysyä käyttäjältä)
            ja tallenna ne levylle.

            Toteuta ohjelmaan myös tiedostonlukeminen ja tulosta TV-oliot näkyville.
            */

            List<TV_Ohjelma> ohjelmat = new List<TV_Ohjelma>();

            ohjelmat = LoadFromFile(ohjelmat);

            foreach (TV_Ohjelma ohj in ohjelmat)
            {
                Console.WriteLine(ohj.ToString());
            }

            // tiedon teko ja tallennus

            //ohjelmat.Add(new TV_Ohjelma("ylen aamu-tv", TV_Ohjelma.ChannelNames.Yle1, 6.25f, 9.30f, "Ylen aamu-tv:n otsikot. 06.30 uutiset, sää ja urheilu puolen tunnin välein. yle.fi/aamutv HD"));
            //ohjelmat.Add(new TV_Ohjelma("pikkukakkonen", TV_Ohjelma.ChannelNames.Yle2, 6.50f, 6.51f, "Ohjelmaa perheen pienimmille. yle.fi/pikkukakkonen HD"));
            //ohjelmat.Add(new TV_Ohjelma("huomentasuomi", TV_Ohjelma.ChannelNames.Mtv3, 6.25f, 9.05f, "Huomenta Suomi"));
            //ohjelmat.Add(new TV_Ohjelma("lazytown", TV_Ohjelma.ChannelNames.Nelonen, 6.25f, 6.50f, "Kausi 2. Jakso 4/18. Roskapulmia. Stigu ja Pormestari haluavat pitää LazyTownin siistinä ja puhtaana. Kaikki lapset siivoavat kaupunkia, mutta Robilla on muuta mielessä. Naamioituneena jäteautonkuljettajaksi hän kerää jätteet joita lapset ovat koonneet. Hän valmistaa valtavan roskakanuunan levittääkseen roskia joka puolelle. Kun kanuuna menee epäkuntoon, Sportacus saapuu pelastamaan sekä kaupungin että Robin hukkumasta jätteisiin. Suomeksi puhuttu animaatiosarja. (24')"));
            //ohjelmat.Add(new TV_Ohjelma("SVT: Gomorron Sverige", TV_Ohjelma.ChannelNames.Ylefem, 7.25f, 7.30f, "Dagsaktuella gäster i intervjuer, debatter och diskussioner i soffan varje kvart. Tips om mat och resor och recensioner av film och böcker m.m. SVT Nyheter varje halvtimme med start 06.30. Vädret varje halvtimme med start 06.37. Sportnytt sänds kl 07.05, 08.05 och 09.05. Lokala nyheter sänds varje halvtimme med start 07.10. Läs text-tv sid 679."));
            //ohjelmat.Add(new TV_Ohjelma("salatut elämät", TV_Ohjelma.ChannelNames.Sub, 9.30f, 10.00f, "Osa 3124: Severillä on jumalaton kaipuu. Pihlajakadun asukkaista kertovassa sarjassa kuljetaan kiehtovien tarinoiden poluilla koskettavia tai arkojakaan asioita kaihtamatta."));
            //ohjelmat.Add(new TV_Ohjelma("teematieto", TV_Ohjelma.ChannelNames.Yleteema, 4.00f, 17.00f, "teematieto"));
            //ohjelmat.Add(new TV_Ohjelma("ostosruutu", TV_Ohjelma.ChannelNames.Liv, 6.00f, 8.00f, "ostosruutu"));
            //ohjelmat.Add(new TV_Ohjelma("ostosruutu", TV_Ohjelma.ChannelNames.Jim, 6.00f, 8.00f, "ostosruutu"));
            //ohjelmat.Add(new TV_Ohjelma("pelastajat", TV_Ohjelma.ChannelNames.Viitonen, 6.40f, 7.05f, "Kausi 3, osa 3. Kotimaisessa realityssa seurataan vuoden 2008 tapahtumia Espoossa. Sarja näyttää miten vaativaa palomiesten työ on, eikä unohda palomiesten ajatuksia ja tunteita raskaan työn keskellä. Pelastajat kuvaa todellista palo- ja pelastusaseman arkea kaikessa sen hektisyydessään ja dramaattisuudessaan. (Pelastajat, kotimainen tosi-tv, 2009)"));
            //ohjelmat.Add(new TV_Ohjelma("ajan hidastajat", TV_Ohjelma.ChannelNames.Kuutonen, 6.45f, 7.15f, "Kausi 1, osa 7. Samuraimiekan mestari. Jeff ja Matt näyttävät hidastuskuvana samuraimestarin voiman, biljardin huippupelaajan liikkeet ja kolibrin taianomaisen lennon. (Time Warp, viihde, USA, 2008)"));
            //ohjelmat.Add(new TV_Ohjelma("FOX kids: Julius-apina", TV_Ohjelma.ChannelNames.Fox, 6.25f, 6.48f, "Paul Frankin luoma apinahahmo Julius seikkailee kavereineen leikkimökin kautta avautuvassa maagisessa maailmassa, jossa tavalliset esineet heräävät henkiin. Lasten animaatiosarja."));
            //ohjelmat.Add(new TV_Ohjelma("Lemmenviemää", TV_Ohjelma.ChannelNames.Ava, 7.30f, 8.30f, "Oireilua. Werner syöksyy Charlotten ja Beatricen väliin ja rauhoittelee Charlottea: on pidettävä pää kylmänä, ettei tapahdu pahempaa. Beatrice sattuu kuulemaan Sebastianin hallussa olevasta tallenteesta ja keksii oivan keinon usuttaa Luisaa Sebastiania vastaan. Michael ei haluaisi paljastaa Nataschalle, että André on parantunut. Norman saa outoja oireita. Toisaalta romantiikkaakin on ilmassa, kun Carolin kutsuu Normanin sviittiinsä syömään. Joko Norman vihdoin pystyy unohtamaan Alexandran? Saksalainen telenovela huippuhotellin omistajaperheen ja henkilökunnan mutkikkaista ja myrskyisistä ihmissuhteista. Uusinta."));
            //ohjelmat.Add(new TV_Ohjelma("Hotellit haltuun", TV_Ohjelma.ChannelNames.Hero, 8.15f, 9.00f, "Kausi 8. Jakso 4/8. Pomo piilossa. Hotelli Crown Innin omistaja piileksii päivät toimistossaan ja antaa muiden hoitaa käytännön työt. Mutta koska paikka tekee jatkuvasti tappiota ja rahat uhkaavat loppua, hotellipoliisi Alex Polizzin on saatava pomo pois kolostaan. Tämän on aika nähdä hotellinsa vieraiden silmin. Englantilainen realitysarja."));
            //ohjelmat.Add(new TV_Ohjelma("Ihanat kamalat lemmikit", TV_Ohjelma.ChannelNames.Frii, 8.25f, 9.25f, "Kausi 3, osa 6. Siellä se menee. Jaksossa nähdään ruokaa varasteleva ja taloa tuhoava kissa, jääkaapissa tuhoa aiheuttava kani ja koira, joka jahtaa jäätelöautoa niin kauan, että se saa mehujäätelön. (Dogs 101, perhesarja, USA, 2008)"));
            //ohjelmat.Add(new TV_Ohjelma("ensiapuklinikka", TV_Ohjelma.ChannelNames.Tlc, 7.50f, 8.20f, "Kausi 2, osa 7. Warrington Hospital -sairaalan ensiapuklinikalla ei ole rauhallista hetkeä. Sarja seuraa klinikan hektistä arkea lennossa vaihtuvissa tilanteissa. (A&E, tosi-tv, Iso-Britannia, 2008)"));

            //SaveToFile(ohjelmat);

        }

        // load from file method
        public static List<TV_Ohjelma> LoadFromFile(List<TV_Ohjelma> ohj)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("output.bin", FileMode.OpenOrCreate);
                if (stream.Length > 0)
                {
                    ohj = (List<TV_Ohjelma>)formatter.Deserialize(stream);
                }
                return ohj;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static void SaveToFile(List<TV_Ohjelma> ohj)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("output.bin", FileMode.OpenOrCreate);
            formatter.Serialize(stream, ohj);
        }
    }
}
