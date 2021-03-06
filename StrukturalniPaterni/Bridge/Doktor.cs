using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Doktor : IPlata
    {
        double koeficijent;
        int dodatak;
        public Doktor(double c, int a = 400)
        {
            koeficijent = c;
            dodatak = a;
        }
        public double izračunajPlatu()
        {
            return koeficijent * 105 + dodatak;
        }
    }
}
