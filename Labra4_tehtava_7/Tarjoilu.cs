using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    class Tarjoilu : Asiakaspalvelu
    {
        private int ripeys;
        private int opastus;

        public int Opastus
        {
            get { return opastus; }
            set { if (value >= 1 && value <= 5) opastus = value; }
        }

        public int Ripeys
        {
            get { return ripeys; }
            set { if (value >= 1 && value <= 5) ripeys = value; }
        }
        public override string ToString()
        {
            return base.ToString() + "Ripeys: " + ripeys + ". " + "Opastus: " + opastus + ". ";
        }
    }
}
