using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Ihminen : Nisakas
    {
        public float Weight { get; set; }
        public float Height { get; set; }
        public string Name { get; set; }

        public override string Move ()
        {
            return "I'm moving";
        }

        public void Grow ()
        {
            Age++;
        }
    }
}
