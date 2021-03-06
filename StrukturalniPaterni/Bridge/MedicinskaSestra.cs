using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class MedicinskaSestra : IPlata
    {
        double koeficijent;
        public MedicinskaSestra(double c)
        {
            koeficijent = c;
        }
        public double izračunajPlatu()
        {
            return koeficijent * 100;
        }
    }
}
