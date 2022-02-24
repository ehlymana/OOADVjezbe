using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class MP3Player : IKreatorIteratora
    {
        IIterator iterator;
        public IIterator kreirajIterator(int vrsta, List<Pjesma> pjesme)
        {
            if (vrsta == 0)
                iterator = new AbecedniIterator(pjesme);
            else if (vrsta == 1)
                iterator = new ShuffleIterator(pjesme);

            return iterator;
        }
        public Pjesma pustiSljedecuPjesmu()
        {
            return iterator.pustiSljedecuPjesmu();
        }
    }
}
