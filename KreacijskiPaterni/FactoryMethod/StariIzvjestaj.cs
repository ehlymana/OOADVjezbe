using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class StariIzvjestaj : Izvjestaj, IIzvjestaj
    {
        public void napraviIzvjestaj()
        {
            Statistika = new GodisnjaStatistika();
            Anketa = new StudentskaAnketa();
        }
    }
}
