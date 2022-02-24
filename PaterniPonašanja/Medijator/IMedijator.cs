using System;
using System.Collections.Generic;
using System.Text;

namespace Medijator
{
    public interface IMedijator
    {
        public bool provjeriPorukuPrimalac(Klijent k1, Klijent k2);
        public bool provjeriPorukuSadrzaj(string sadrzaj);
    }
}
