using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_BAJ_MB
{
    public class Risaelduspilid : Spil
    {
        public Risaelduspilid(string nafn, string flokkur1, string flokkur2, string flokkur3, string flokkur4, string flokkur5, string flokkur6)
            : base(nafn, flokkur1, flokkur2, flokkur3, flokkur4, flokkur5, flokkur6)
        {
            Nafn = nafn;
            Flokkur1 = flokkur1;
            Flokkur2 = flokkur2;
            Flokkur3 = flokkur3;
            Flokkur4 = flokkur4;
            Flokkur5 = flokkur5;
            Flokkur6 = flokkur6;
        }

        public override string ToString()
        {
            return string.Format("Nafn: {0} Fágæti: {1} Sædýra stofn: {2} Hætta á áfalli: {3} Verndar þörf: {4} Hætta á útrýmingar hættu {5}");
        }
    }
}
