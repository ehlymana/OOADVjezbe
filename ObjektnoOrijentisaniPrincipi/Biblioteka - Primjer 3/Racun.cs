using System;

namespace Biblioteka
{
    public class Racun : IPodaci
    {
        #region Atributi

        protected static decimal limitZaPodizanje = 1000;
        protected decimal stanje;
        protected int id;

        #endregion

        #region Properties

        public decimal Stanje { get => stanje; }
        public int Id { get => id; set => id = value; }

        #endregion

        #region Konstruktor

        public Racun(decimal pocetnoStanje)
        {
            stanje = pocetnoStanje;
        }

        #endregion

        #region Metode

        public virtual void PoloziNovac(decimal kol)
        {
            if (kol < 0)
                throw new Exception("Količina novca koju polažete na račun mora biti pozitivna.");
            stanje += kol;
        }

        public virtual void DigniNovac(decimal kol)
        {
            if (kol < 0)
                throw new Exception("Količina novca koju podižete sa računa mora biti pozitivna.");
            else if (kol > limitZaPodizanje)
                throw new Exception("Količina novca koju podižete sa računa mora biti manja od limita za podizanje.");

            stanje -= kol;
        }

        public string DajOpis()
        {
            return "ID: " + id + ", Stanje: " + stanje;
        }
        

        #endregion
    }
}
