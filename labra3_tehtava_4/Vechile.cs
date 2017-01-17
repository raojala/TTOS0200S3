using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Vechile
    {
            /*  Luo Vehicle-luokka seuraavien tietojen mukaisesti:

                ominaisuudet

                Name:string
                Speed:int
                Tyres:int

                toiminnot

                PrintData(), tulostaa Vehiclen ominaisuudet näytölle
                ToString():string, palauttaa kaikki Vehiclen ominaisuudet yhtenä merkkijonona

                Toteuta Vehicle-luokan ohjelmointi sekä pääohjelma, jolla luot olion Vehicle-luokasta.
                Muuta olion arvoja ja tulosta olion arvoja konsolille.
             
             */

        public string Name { get; }

        int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (!(value >= 0 && value <= 200))
                    speed = value;
                else
                    speed = 0;
            }
        }

        int tyres;
        public int Tyres {
            get
            {
                return tyres;
            }
            set
            {
                if (!(value >= 10 && value <= 25))
                    tyres = 14;
                else
                    tyres = value;
            }
        }

        public Vechile (string name, int vechileSpeed, int tires)
        {
            if (!(speed >= 0 && speed <= 200))
                vechileSpeed = 0;

            if (tyres >= 10 && tyres <= 25)
                tires = 14;

            speed = vechileSpeed;
            tyres = tires;
            Name = name;
        }

        public void PrintData()
        {
            Console.WriteLine("Vechile: " + Name);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Tyres: " + Tyres);
        }

        public override string ToString()
        {
            string s = Name + ", " + Speed + ", " + Tyres;
            return "";
        }
    }
}
