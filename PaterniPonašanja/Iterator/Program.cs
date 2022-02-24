using System;
using System.Collections.Generic;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MP3Player player = new MP3Player();
            List<Pjesma> pjesme = new List<Pjesma>
            {
                new Pjesma("Song A", "Artist 1", "Pop"),
                new Pjesma("Song B", "Artist 2", "Pop"),
                new Pjesma("Song C", "Artist 3", "Pop")
            };
            Pjesma p1 = null;

            player.kreirajIterator(0, pjesme);
            Console.Out.WriteLine("Trenutni iterator: Abecedni");
            for (int i = 0; i < 5; i++)
            {
                p1 = player.pustiSljedecuPjesmu();
                Console.Out.WriteLine("Trenutno je puštena pjesma: " + p1.Naziv + " koju izvodi " + p1.Izvodac);
            }

            player.kreirajIterator(1, pjesme);
            Console.Out.WriteLine("\nTrenutni iterator: Shuffle");
            for (int i = 0; i < 5; i++)
            {
                p1 = player.pustiSljedecuPjesmu();
                Console.Out.WriteLine("Trenutno je puštena pjesma: " + p1.Naziv + " koju izvodi " + p1.Izvodac);
            }
        }
    }
}
