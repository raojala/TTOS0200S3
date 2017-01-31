using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class TV_Ohjelma
    {
        /*
        TV-ohjelman tietoina tulee käsitellä: ohjelman nimi, kanava (jolta ohjelma tulee), alku- ja loppuaika
        sekä pienimuotoinen infoteksti ohjelmasta.
        */

        public string Name { get; set; }
        public ChannelNames ChannelName { get; }
        public float StartTime { get; set; }
        public float EndTime { get; set; }
        public string Description { get; set; }

        public TV_Ohjelma (string name, ChannelNames channel, float start, float end, string description)
        {
            Name = name;
            ChannelName = channel;
            StartTime = start;
            EndTime = end;
            Description = description;
        }

        public override string ToString()
        {
            return Name + ";" + ChannelName + ";" + StartTime + ";" + EndTime + ";" + Description;
        }

        public enum ChannelNames
        {
            Yle1,
            Yle2,
            Mtv3,
            Nelonen,
            Sub,
            Jim,
            Liv,
            Fox,
            Yleteema,
            Ylefem,
            Ava,
            Viitonen,
            Kuutonen,
            Hero,
            Frii,
            Tlc
        }
    }
}
