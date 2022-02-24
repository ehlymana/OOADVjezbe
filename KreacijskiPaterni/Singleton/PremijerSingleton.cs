using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class PremijerSingleton
    {
        String ime, prezime;
        DateTime pocetakMandata;
        static PremijerSingleton premijer;

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime PocetakMandata { get => pocetakMandata; set => pocetakMandata = value; }

        public void izaberiPremijera(string ime, string prezime)
        {
            if (premijer == null || (DateTime.Now - premijer.PocetakMandata).TotalDays >= 365 * 4)
            {
                premijer = new PremijerSingleton();
                premijer.Ime = ime;
                premijer.Prezime = prezime;
                premijer.PocetakMandata = DateTime.Now;
            }
        }

        public static PremijerSingleton dajPremijera()
        {
            return premijer;
        }
    }
}
