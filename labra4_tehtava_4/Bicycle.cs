using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Bicycle : Kulkuneuvo
    {
        bool onkoVaihteet;
        private string vaihteidenMalli;

        public bool OnkoVaihteet
        {
            get
            {
                return onkoVaihteet;
            }
            set
            {
                onkoVaihteet = value;
            }
        }
        public string VaihteidenMalli
        {
            get { return vaihteidenMalli; }
            set { vaihteidenMalli = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " vaihteet:" + onkoVaihteet + " " + vaihteidenMalli;
        }
    }
}
