using System;
using System.Collections.Generic;
using System.Text;

namespace Fasada
{
    public class Linija
    {
        double dužina;
        Tačka početnaTačka, krajnjaTačka;

        public Linija(double length, Tačka start, Tačka end)
        {
            dužina = length;
            početnaTačka = start;
            krajnjaTačka = end;
        }
    }
}
