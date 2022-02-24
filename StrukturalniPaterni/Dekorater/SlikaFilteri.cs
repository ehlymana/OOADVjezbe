using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorater
{
    public class SlikaFilteri : ISlika
    {
        Slika slika;

        public void edituj(int vrsta)
        {
            string stara = slika.dajImeSlike();
            if (vrsta == 0) stara = "Crno-bijela " + stara;
            else if (vrsta == 1) stara = "Izoštrena " + stara;
            else stara = "Zamagljena " + stara;
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
