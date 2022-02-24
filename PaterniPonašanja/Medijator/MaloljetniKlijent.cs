using System;
using System.Collections.Generic;
using System.Text;

namespace Medijator
{
    public class MaloljetniKlijent : Klijent
    {
        IMedijator medijator;

        public IMedijator Medijator { get => medijator; set => medijator = value; }

        public override void dodajPoslanuPoruku(Klijent primalac, string sadržaj)
        {
            if (Medijator.provjeriPorukuPrimalac(this, primalac))
                PoslanePoruke.Add(primalac, sadržaj);
        }

        public override void dodajPrimljenuPoruku(Klijent pošiljalac, string sadržaj)
        {
            if (Medijator.provjeriPorukuPrimalac(this, pošiljalac))
                PrimljenePoruke.Add(pošiljalac, sadržaj);
        }
    }
}
