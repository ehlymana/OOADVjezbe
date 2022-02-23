using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Izvjestaj
    {
        StatistikaUpisa statistika;
        Anketa anketa;

        public StatistikaUpisa Statistika { get => statistika; set => statistika = value; }
        public Anketa Anketa { get => anketa; set => anketa = value; }
    }
}
