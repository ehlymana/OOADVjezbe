using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class PrivremeniRacun : Racun
    {
        #region Atributi

        DateTime pocetak, kraj;

        #endregion

        #region Konstruktor

        public PrivremeniRacun(decimal pocetnoStanje) : base(pocetnoStanje)
        {
            pocetak = DateTime.Now;
            kraj = DateTime.Now.AddMonths(1);
        }

        #endregion

        #region Metode

        public override void PoloziNovac(decimal kol)
        {
            if (kol < 0 || DateTime.Now.Hour < 8 || DateTime.Now.Hour > 15)
                throw new Exception("Količina novca koju polažete na račun mora biti pozitivna.");
            stanje += kol;
        }

        public override void DigniNovac(decimal kol)
        {
            if (kol < 0 || DateTime.Now.Hour < 8 || DateTime.Now.Hour > 15)
                throw new Exception("Količina novca koju podižete sa računa mora biti pozitivna.");
            else if (kol > limitZaPodizanje)
                throw new Exception("Količina novca koju podižete sa računa mora biti manja od limita za podizanje.");

            stanje -= kol;
        }

        public void ProduziTrajanje()
        {
            if (kraj.AddDays(-7) <= DateTime.Now && stanje >= 500)
                kraj = kraj.AddDays(30);
        }

        #endregion
    }
}
