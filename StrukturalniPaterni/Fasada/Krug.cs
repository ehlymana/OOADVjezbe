using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada
{
    public class Krug
    {
        Linija radijus;
        Tačka centar;

        public Krug(Linija r, Tačka c)
        {
            radijus = r;
            centar = c;
        }
    }
}
