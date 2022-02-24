using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ManuelniBuilder : IBuilder
    {
        PC racunar = new PC();
        public void napraviGraficku(string prva, string druga)
        {
            racunar.GrafickaKartica = prva;
            racunar.DodatnaGrafickaKartica = druga;
        }
        public void napraviSpremistePodataka(string HDD, string SSD)
        {
            if (SSD != "")
            {
                racunar.SpremistePodataka = SSD;
                racunar.DodatniHDD = HDD;
            }
            else
            {
                racunar.SpremistePodataka = HDD;
                racunar.DodatniHDD = "Nema";
            }
            
        }
        public void napraviCitac(bool CDROM, bool DVDROM, bool floppy)
        {
            racunar.CDROM1 = CDROM;
            racunar.DVDROM1 = DVDROM;
            racunar.Floppy = floppy;
        }
        public PC dajPC()
        {
            return racunar;
        }
    }
}
