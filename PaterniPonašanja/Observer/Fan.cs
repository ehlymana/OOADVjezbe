using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Fan : IPretplatnik
    {
        List<string> kupljeneKarte = new List<string>();
        List<DateTime> rezervisaniSmjestaji = new List<DateTime>();

        public List<string> KupljeneKarte { get => kupljeneKarte; set => kupljeneKarte = value; }

        public void kupiKartuIRezervisiSmjestaj(string koncert, DateTime vrijeme)
        {
            KupljeneKarte.Add(koncert);
            rezervisaniSmjestaji.Add(vrijeme);
        }
    }
}
