using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka___Nasljeđivanje
{
    public class Banka
    {
        #region Atributi

        List<Klijent> klijenti = new List<Klijent>();
        List<Racun> racuni = new List<Racun>();

        #endregion

        #region Metode

        public void DodajKlijenta(Klijent osoba)
        {
            klijenti.Add(osoba);
        }

        public void OtvoriRacunZaOsobu(Klijent osoba)
        {
            Racun racun = new Racun(0)
            {
                Id = racuni.Count
            };
            racuni.Add(racun);
            osoba.Racuni.Add(racun);
        }

        public Klijent PronadiKlijenta(int identitet)
        {
            return klijenti.Find(osoba => osoba.Identitet == identitet);
        }

        public void PrebaciNovac(Racun racun, decimal kolicina)
        {
            racun.PoloziNovac(kolicina);
        }

        #endregion
    }
}
