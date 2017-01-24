using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Aikuinen : Ihminen
    {
        public string Auto { get; set; }
        public override string Move()
        {
            return "Walking";
        }
    }
}
