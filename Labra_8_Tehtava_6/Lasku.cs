﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Lasku
    {
        float kokonaishinta = 0f;
        public Dictionary<Product, int> Tuotteet { get; }
        public float Kokonaishinta { get { return kokonaishinta; } }

        public Lasku ()
        {
            Tuotteet = new Dictionary<Product, int>();
        }

        public void Ready ()
        {
            foreach (KeyValuePair<Product,int> pair in Tuotteet)
            {
                kokonaishinta += pair.Key.Hinta * pair.Value;
            }
        }

        public override string ToString()
        {
            string s = "Tilatut tuotteet: \n";

            foreach (KeyValuePair<Product, int> pair in Tuotteet)
            {
                s += pair.Key.Nimi + " " + pair.Value + " Kappaletta " + "Yksikköhinta: " + pair.Key.Hinta + "\n";
            }
            s += "Kokonaishinta: " + Kokonaishinta;
            return s;
        }
    }
}
