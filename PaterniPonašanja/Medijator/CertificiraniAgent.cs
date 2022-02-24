using System;
using System.Collections.Generic;
using System.Text;

namespace Medijator
{
    public class CertificiraniAgent : Klijent
    {
        IMedijator medijator;

        public IMedijator Medijator { get => medijator; set => medijator = value; }

        public override void dodajPrimljenuPoruku(Klijent pošiljalac, string sadržaj)
        {
            if (Medijator.provjeriPorukuSadrzaj(sadržaj))
                PrimljenePoruke.Add(pošiljalac, sadržaj);
        }
    }
}
