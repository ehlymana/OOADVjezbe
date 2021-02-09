using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class Klijent
    {
        #region Atributi

        int identitet;
        string ime;
        List<Racun> racuni = new List<Racun>();

        #endregion

        #region Properties

        public int Identitet { get => identitet; }
        public string Ime { get => ime; set => ime = value; }
        public List<Racun> Racuni { get => racuni; set => racuni = value; }

        #endregion

        #region Konstruktor

        public Klijent(int id, string name)
        {
            identitet = id;
            ime = name;
        }

        #endregion
    }


}
