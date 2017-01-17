using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Mikro
    {
        public bool SaakoVirtaa { get; set; }
        public int Teho { get; set; }
        public int Kesto { get; set; }

        // ajastin metodi että mikro kilahtaa kahden minuutin kuluttua
        public void Kaynnista()
        {
            if (SaakoVirtaa)
            {
                System.Threading.Thread.Sleep(Kesto * 1000);
                Console.WriteLine("DING!!!");
            }
        }
    }
}
