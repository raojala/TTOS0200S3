using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT
{
    public class Boat : Kulkuneuvo
    {

        int istuinPaikat;
        VeneenTyyppi tyyppi;

        public int IstuinPaikat
        {
            get
            {
                return istuinPaikat;
            }
            set
            {
                istuinPaikat = value;
            }
        }
        public VeneenTyyppi Tyyppi
        {
            get
            {
                return tyyppi;
            }
            set
            {
                tyyppi = value;
            }
        }

        public override string ToString()
        {
            return tyyppi + " paikat: " + istuinPaikat + ", " + base.ToString();
        }

        public enum VeneenTyyppi
        {
            Soutuvene,
            Purjevene,
            Kanootti,
            Moottorivene,
            Kajakki,
            Tankkeri,
            Sukellusvene,
            Troolari,
            Kumivene,
            Uimarengas
        };
    }
}
