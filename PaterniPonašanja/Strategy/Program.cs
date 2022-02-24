using System;
using System.Collections.Generic;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Karta> karte = new List<Karta> { new Karta("baklava", "1"), new Karta("list", "2") };
            Špil spil = new Špil(karte);

            spil.promijeniStrategiju(new BubbleSort());
            spil.sortiraj();

            spil.promijeniStrategiju(new RadixSort());
            spil.sortiraj();
        }
    }
}
