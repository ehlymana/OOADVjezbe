using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozitni
{
    public class Zaposlenik : IZaposlenik
    {
        int osnovica = 250;
        public double dajPlatu()
        {
            return (osnovica * 1.5);
        }
    }
}
