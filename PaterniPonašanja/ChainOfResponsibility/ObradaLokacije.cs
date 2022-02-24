using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class ObradaLokacije : CVMaker
    {
        public ObradaLokacije(CV c)
        {
            Cv = c;
        }

        public void nadiUniverzitet()
        {
            Console.Out.WriteLine("Pretraga najbližih univerziteta...");
            Cv.Univerzitet = "Najbliži univerzitet";
        }

        public void dodajRating()
        {
            Console.Out.WriteLine("Pretraga ratinga za univerzitete...");
            Cv.Rating = 10;
        }

        public override void obradi()
        {
            nadiUniverzitet();
            dodajRating();
        }
    }
}

