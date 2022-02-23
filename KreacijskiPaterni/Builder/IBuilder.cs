using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IBuilder
    {
        public void napraviGraficku(string prva, string druga);
        public void napraviSpremistePodataka(string HDD, string SSD);
        public void napraviCitac(bool CDROM, bool DVDROM, bool floppy);
        public PC dajPC();
    }
}
