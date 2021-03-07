using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public interface IPretplatnik
    {
        public void kupiKartuIRezervisiSmjestaj(string koncert, DateTime vrijeme);
    }
}
