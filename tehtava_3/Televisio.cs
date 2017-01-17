using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Televisio
    {
        public int Kanava { get; set; }
        public bool OnkoPaalla { get; set; }

        public Televisio () { }
        public Televisio(int kanava)
        {
            Kanava = kanava;
        }
    }
}
