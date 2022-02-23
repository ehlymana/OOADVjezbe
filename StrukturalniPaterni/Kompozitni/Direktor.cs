using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozitni
{
    public class Direktor : IZaposlenik
    {
        int osnovica = 500;
        double dodatak = 150;
        public double dajPlatu()
        {
            return (osnovica * 2 + dodatak);
        }
    }
}
