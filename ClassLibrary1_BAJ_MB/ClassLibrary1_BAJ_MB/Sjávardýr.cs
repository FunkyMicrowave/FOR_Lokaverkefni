using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Brynjolfur
 * Matthias
 */
namespace ClassLibrary1_BAJ_MB
{
#pragma warning disable CS0436 // Type conflicts with imported type
    public class Sjávardýr : Spil
#pragma warning restore CS0436 // Type conflicts with imported type
    { 
        public Sjávardýr(string nafn, string flokkur1, string flokkur2, string flokkur3, string flokkur4, string flokkur5, string flokkur6)
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
            return string.Format("Nafn: {0}\n Fágæti: {1}\n Sædýra stofn: {2}\n Hætta á áfalli: {3}\n Verndar þörf: {4}\n Hætta á útrýmingar hættu {5}\n {6}",Nafn , Flokkur1, Flokkur2, Flokkur3, Flokkur4, Flokkur5, Flokkur6);
        }
    }
}
