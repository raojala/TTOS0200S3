using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Pesukone
    {
        public enum PesuOhjelma
        {
            LamminKaksikymmenta,
            LamminNeljakymmenta,
            LamminKuusikymmenta,
            LamminKahdeksankymmenta,
            LamminSata,
            Kylma
        };
        PesuOhjelma pesuOhjelma;

        public bool OnkoVirtaa { get; set; }
        public bool Pyoriiko { get; set; }
        public bool Linkoaako { get; set; }
        

        public Pesukone ()
        {
            Console.WriteLine("Tekee pesukonetta");
        }

        public Pesukone (PesuOhjelma ohjelma) : base()
        {
            pesuOhjelma = ohjelma;
        }

        public Pesukone(PesuOhjelma ohjelma, bool onkoVirtaa) : this(ohjelma)
        {
            OnkoVirtaa = onkoVirtaa;
        }

        public Pesukone(PesuOhjelma ohjelma, bool onkoVirtaa, bool pyoriiko) : this(ohjelma, onkoVirtaa)
        {
            Pyoriiko = pyoriiko;
        }

        public Pesukone(PesuOhjelma ohjelma, bool onkoVirtaa, bool pyoriiko, bool linkoaako) : this(ohjelma, onkoVirtaa, pyoriiko)
        {
            Linkoaako = linkoaako;
        }

        public void Aloita ()
        {
            switch (pesuOhjelma)
            {
                case PesuOhjelma.LamminKaksikymmenta:
                    Console.WriteLine("Ohjelma alkaa kestää kaks vuotta :D");
                    break;
                case PesuOhjelma.LamminNeljakymmenta:
                    Console.WriteLine("Ohjelma alkaa kestää ainaki kakskymmentä vuotta :D");
                    break;
                case PesuOhjelma.LamminKuusikymmenta:
                    Console.WriteLine("Ohjelma alkaa kestää puoli vuotta :D");
                    break;
                case PesuOhjelma.LamminKahdeksankymmenta:
                    Console.WriteLine("Ohjelma alkaa kestää kolme vuotta :D");
                    break;
                case PesuOhjelma.LamminSata:
                    Console.WriteLine("Ohjelma alkaa kestää kaksisataa vuotta :D");
                    break;
                case PesuOhjelma.Kylma:
                    Console.WriteLine("Ohjelma alkaa kestää sata vuotta :D");
                    break;
                default:
                    Console.WriteLine("Ohjelmaa ei valittu.");
                    break;
            }
        }
    }
}
