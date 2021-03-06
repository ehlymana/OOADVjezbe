using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorater
{
    public interface ISlika
    {
        void edituj(int vrsta);
        Slika dajSliku();
        void postaviSliku(Slika s);
    }
}
