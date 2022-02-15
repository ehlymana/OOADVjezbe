using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Racun
    {
        #region Atributi

        static decimal limitZaPodizanje = 1000;
        decimal stanje;
        int id;

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

        public void PoloziNovac(decimal kol)
        {
            if (kol < 0)
                throw new Exception("Količina novca koju polažete na račun mora biti pozitivna.");
            stanje += kol;
        }

        public void DigniNovac(decimal kol)
        {
            if (kol < 0)
                throw new Exception("Količina novca koju podižete sa računa mora biti pozitivna.");
            else if (kol > limitZaPodizanje)
                throw new Exception("Količina novca koju podižete sa računa mora biti manja od limita za podizanje.");

            stanje -= kol;
        }

        #endregion
    }
}
