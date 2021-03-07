using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class ObradaSlike : CVMaker
    {
        public ObradaSlike(CV c)
        {
            Cv = c;
        }
        public void dodajSliku()
        {
            Console.Out.WriteLine("Pretraga slika s interneta...");
            Cv.Slika = "Slika s interneta";
        }
        public override void obradi()
        {
            dodajSliku();
        }
    }
}
