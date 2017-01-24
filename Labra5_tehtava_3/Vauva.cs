using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Vauva:Ihminen
    {
        public string Vaippa { get; set; }
        public override string Move()
        {
            return "Crawling!";
        }
    }
}
