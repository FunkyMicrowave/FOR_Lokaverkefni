using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_BAJ_MB
{
    public class Sjávardýr : Spil
    {
        string NafnSjavardyri;
        public string Fágæti { get; set; }
        public string Sædýrasofn { get; set; }
        public string HættaÁÁfollum { get; set; }
        public string Verndarþörf { get; set; }
        public string HættaÁÚtrýmingu { get; set; }
        string tómt = null;

        public Sjávardýr(string nafn, string flokkur1, string flokkur2, string flokkur3, string flokkur4, string flokkur5, string flokkur6)
            : base(nafn, flokkur1, flokkur2, flokkur3, flokkur4, flokkur5, flokkur6)
        {
            NafnSjavardyri = nafn;
            flokkur1 = Fágæti;
            flokkur2 = Sædýrasofn;
            flokkur3 = HættaÁÁfollum;
            flokkur4 = Verndarþörf;
            HættaÁÚtrýmingu = flokkur5;
            tómt = flokkur6;
        }

          /*   public CD(string comment, string gotIt, string playingTime, string title, string artist, string numberOfTracks)
            : base(comment, gotIt, playingTime, title)
        {
            Artist = artist;
            NumerOfTracks = numberOfTracks;
        }//end public CD*/
    }
}
