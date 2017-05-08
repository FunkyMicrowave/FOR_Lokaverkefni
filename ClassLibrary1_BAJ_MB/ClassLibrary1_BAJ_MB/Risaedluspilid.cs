using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_BAJ_MB
{
#pragma warning disable CS0436 // Type conflicts with imported type
    public class Risaedluspilid : Spil
#pragma warning restore CS0436 // Type conflicts with imported type
    {
        public Risaedluspilid(string nafn, string flokkur1, string flokkur2, string flokkur3, string flokkur4, string flokkur5, string flokkur6)
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
            return string.Format("Nafn: {0}\n Hæð: {1}m\n þyngd: {2}kg\n Lengd: {3}m\n Drápseðli: {4}\n Greind: {5}\n Aldur: {6} milljón ár\n", Nafn, Flokkur1, Flokkur2, Flokkur3, Flokkur4, Flokkur5, Flokkur6);
        }
    }
}
