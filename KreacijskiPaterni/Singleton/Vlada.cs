using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Vlada
    {
        PremijerSingleton premijer = new PremijerSingleton();

        public bool izaberiPremijera(string ime, string prezime, List<bool> saglasnosti)
        {
            if (saglasnosti.FindAll(x => x == true).Count > 0.67 * saglasnosti.Count)
            {
                premijer.izaberiPremijera(ime, prezime);
                return true;
            }
            return false;
        }
    }
}
