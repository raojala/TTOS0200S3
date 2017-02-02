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
            
            try
            {
                paaOhjelma();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void paaOhjelma ()
        {
            try
            {
                Shapes shapes = new IT.Shapes();

                shapes.ShapeList.Add(new Rectangle(2, 5, "Nelio 1"));
                shapes.ShapeList.Add(new Rectangle(3, 6, "Nelio 2"));
                shapes.ShapeList.Add(new Rectangle(4, 7, "Nelio 3"));
                shapes.ShapeList.Add(new Rectangle(5, 8, "Nelio 4"));
                shapes.ShapeList.Add(new Rectangle(6, 9, "Nelio 5"));

                shapes.ShapeList.Add(new Circle(1, "Pallo 1"));
                shapes.ShapeList.Add(new Circle(2, "Pallo 2"));
                shapes.ShapeList.Add(new Circle(3, "Pallo 3"));
                shapes.ShapeList.Add(new Circle(4, "Pallo 4"));
                shapes.ShapeList.Add(new Circle(5, "Pallo 5"));

                foreach (Shape s in shapes.ShapeList)
                {
                    Console.WriteLine(s.ToString());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
