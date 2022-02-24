using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Špil
    {
        List<Karta> karte = new List<Karta>();
        ISortiranje strategija;

        public Špil(List<Karta> cards)
        {
            karte = cards;
        }

        public void sortiraj()
        {
            strategija.sortirajKarte(karte);
        }

        public void promijeniStrategiju(ISortiranje nova)
        {
            strategija = nova;
        }
    }
}
