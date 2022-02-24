using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class AutomatskiBuilder : IBuilder
    {
        PC racunar = new PC();
        public void napraviGraficku(string prva = "", string druga = "")
        {
            racunar.GrafickaKartica = "Najnovija NVIDIA kartica";
            racunar.DodatnaGrafickaKartica = "Nema";
        }
        public void napraviSpremistePodataka(string HDD = "", string SSD = "")
        {
            racunar.SpremistePodataka = "1 TB";
            racunar.DodatniHDD = "256 GB";
        }
        public void napraviCitac(bool CDROM = false, bool DVDROM = true, bool floppy = false)
        {
            racunar.CDROM1 = false;
            racunar.DVDROM1 = true;
            racunar.Floppy = false;
        }
        public PC dajPC()
        {
            return racunar;
        }
    }
}
