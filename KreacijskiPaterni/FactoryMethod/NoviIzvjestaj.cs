using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class NoviIzvjestaj : Izvjestaj, IIzvjestaj
    {
        public void napraviIzvjestaj()
        {
            Statistika = new SemestralnaStatistika();
            Anketa = new AnketaNastavnogOsoblja();
        }
    }
}
