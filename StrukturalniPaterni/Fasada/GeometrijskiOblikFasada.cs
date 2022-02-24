using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada
{
    public class GeometrijskiOblikFasada
    {
        public Krug napraviKrug(int x, int y, double radijus)
        {
            Linija linija = new Linija(radijus, new Tačka(x, y - (int)radijus), new Tačka(x, y + (int)radijus));
            Tačka centar = new Tačka(x, y);
            return new Krug(linija, centar);
        }

        public Četverougao napraviČetverougao(int xGoreLijevo, int yGoreLijevo, int xDoleDesno,
         int yDoleDesno, double dužina)
        {
            Tačka goreLijevo = new Tačka(xGoreLijevo, yGoreLijevo);
            Tačka goreDesno = new Tačka(xDoleDesno, yGoreLijevo);
            Tačka doleLijevo = new Tačka(xGoreLijevo, yDoleDesno);
            Tačka doleDesno = new Tačka(xDoleDesno, yDoleDesno);
            List<Linija> stranice = new List<Linija>()
            {
                new Linija(dužina, goreLijevo, goreDesno),
                new Linija(dužina, doleLijevo, doleDesno),
                new Linija(dužina, goreLijevo, doleLijevo),
                new Linija(dužina, goreDesno, doleDesno)
            };
            return new Četverougao(stranice);
        }
    }
}
