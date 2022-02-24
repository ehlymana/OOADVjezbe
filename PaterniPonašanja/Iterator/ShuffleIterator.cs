using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class ShuffleIterator : IIterator
    {
        List<Pjesma> pjesme;
        int trenutnaPjesma;

        public ShuffleIterator(List<Pjesma> songs)
        {
            pjesme = songs;
        }

        public Pjesma pustiSljedecuPjesmu()
        {
            Random random = new Random();
            int noviIndex = random.Next(0, pjesme.Count - 1);
            trenutnaPjesma = noviIndex + 1;
            if (trenutnaPjesma >= pjesme.Count)
                trenutnaPjesma -= pjesme.Count;
            return pjesme[trenutnaPjesma];
        }
    }
}
