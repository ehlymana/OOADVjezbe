using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorater
{
    public class SlikaOsnovnePromjene : ISlika
    {
        Slika slika;

        public void edituj(int vrsta)
        {
            string stara = slika.dajImeSlike();
            if (vrsta == 0) stara = "Rotirana " + stara;
            else if (vrsta == 1) stara = "Smanjena " + stara;
            else stara = "Svijetla " + stara;
            slika.postaviImeSlike(stara);
        }

        public Slika dajSliku()
        {
            return slika;
        }

        public void postaviSliku(Slika s)
        {
            slika = s;
        }
    }
}
