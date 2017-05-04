using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Brynjólfur Axel Jóhannesson
 * Matthías Birgisson
 */
namespace ClassLibrary1_BAJ_MB
{
    public class Spil
    {
        public Spil(string nafn, string flokkur1, string flokkur2, string flokkur3, string flokkur4, string flokkur5, string flokkur6)
        {
            Nafn = nafn;
            Flokkur1 = flokkur1;
            Flokkur2 = flokkur2;
            Flokkur3 = flokkur3;
            Flokkur4 = flokkur4;
            Flokkur5 = flokkur5;
            Flokkur6 = flokkur6;
        }

        public string Nafn { get; set; }
        public string Flokkur1 { get; set; }
        public string Flokkur2 { get; set; }
        public string Flokkur3 { get; set; }
        public string Flokkur4 { get; set; }
        public string Flokkur5 { get; set; }
        public string Flokkur6 { get; set; }
        public string Flokkur7 { get; set; }
    }
}
