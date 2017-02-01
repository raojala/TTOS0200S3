using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Toteuta sovellus, jolla voidaan käsitellä erilaisia kuviota (esim. Circle ja Rectangle). 
            
            Laadi erillinen abstrakti Shape-luokka, josta muut kuviot peryityvät. 
            
            Määrittele Shape-luokan ominaisuutena kuvion nimi (Name) ja abstraktit Area- ja 
            Circumference-metodit (pinta-ala ja ympärysmitta). 
            
            Peri Circle- ja Rectangle-luokat Shape-luokasta ja toteuta Area- ja Circumference-metodit. 
            
            Luo Shapes-luokka ja sen sisälle List-tietorakenne, jonne voit aina lisätä kuvioita. 
            
            Toteuta pääohjelma, jossa käytät Shapes-luokkaa, luo muutamia eri kuviota 
            ja lisää ne Shapes-luokassa olevaan List-tietorakenteeseen. 
            
            Käy pääohjelmassa lopuksi läpi Shapes-luokan List-tietorakenne 
            ja tulosta kaikki sen sisältämät kuviot.
            */

            #region callmain
            try
            {
                paaOhjelma();
            }
            catch (Exception e)
            {
                throw e;
            }
            #endregion
        }

        static void paaOhjelma ()
        {
            try
            {
                Shapes shapes = new IT.Shapes();

                shapes.ShapeList.Add(new Rectangle(2, 5, "Pallo1"));
                shapes.ShapeList.Add(new Rectangle(3, 6, "Pallo2"));
                shapes.ShapeList.Add(new Rectangle(4, 7, "Pallo3"));
                shapes.ShapeList.Add(new Rectangle(5, 8, "Pallo4"));
                shapes.ShapeList.Add(new Rectangle(6, 9, "Pallo5"));
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
