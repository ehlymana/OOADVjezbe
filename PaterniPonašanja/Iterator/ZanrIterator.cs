using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iterator
{
    public class ZanrIterator : IIterator
    {
        List<Pjesma> pjesme;
        int trenutnaPjesma;
        public ZanrIterator(List<Pjesma> songs)
        {
            pjesme = songs;
        }
        public Pjesma pustiSljedecuPjesmu()
        {
            Pjesma trenutna = pjesme[trenutnaPjesma];
            pjesme = pjesme.OrderBy(x => x.Zanr).ToList();
            int noviIndex = pjesme.IndexOf(trenutna);
            trenutnaPjesma = noviIndex + 1;
            if (trenutnaPjesma >= pjesme.Count)
                trenutnaPjesma -= pjesme.Count;
            return pjesme[trenutnaPjesma];
        }
    }
}
