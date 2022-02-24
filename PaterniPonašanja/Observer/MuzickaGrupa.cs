using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class MuzickaGrupa
    {
        Dictionary<string, DateTime> zakazaniKoncerti = new Dictionary<string, DateTime>();
        List<Fan> fanovi;
        List<IPretplatnik> pretplatnici;

        public List<Fan> Fanovi { get => fanovi; set => fanovi = value; }
        public List<IPretplatnik> Pretplatnici { get => pretplatnici; set => pretplatnici = value; }

        public void zakaziNoviKoncert(string mjesto, DateTime vrijeme)
        {
            zakazaniKoncerti.Add(mjesto, vrijeme);
            obavijestiFanove(mjesto, vrijeme);
        }
        public void obavijestiFanove(string mjesto, DateTime vrijeme)
        {
            foreach (IPretplatnik pretplatnik in Pretplatnici)
                pretplatnik.kupiKartuIRezervisiSmjestaj(mjesto, vrijeme);
        }
    }
}
