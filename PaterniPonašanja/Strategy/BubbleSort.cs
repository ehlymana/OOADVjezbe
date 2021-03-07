using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class BubbleSort : ISortiranje
    {
        public void sortirajKarte(List<Karta> spil)
        {
            Console.Out.WriteLine("Sortiranje koristeći Bubble Sort");
        }
    }
}
