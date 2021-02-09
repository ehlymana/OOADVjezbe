using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class Banka
    {
        #region Atributi

        List<IPodaci> objekti = new List<IPodaci>();

        #endregion

        #region Metode

        public void DodajKlijentaIliRacun(IPodaci objekat)
        {
            objekti.Add(objekat);
        }

        public void OtvoriRacunZaOsobu(IPodaci osoba)
        {
            IPodaci racun = new Racun(0)
            {
                Id = osoba.GenerišiID()
            };
            objekti.Add(racun);
            ((Klijent)osoba).Racuni.Add((Racun)racun);
        }

        public IPodaci PronadiKlijenta(int identitet)
        {
            return objekti.Find(osoba => osoba is Klijent && ((Klijent)osoba).Identitet == identitet);
        }

        public void PrebaciNovac(Racun racun, decimal kolicina)
        {
            racun.PoloziNovac(kolicina);
        }

        #endregion
    }
}
