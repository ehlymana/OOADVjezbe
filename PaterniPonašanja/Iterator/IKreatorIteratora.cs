using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public interface IKreatorIteratora
    {
        public IIterator kreirajIterator(int vrsta, List<Pjesma> pjesme);
    }
}
