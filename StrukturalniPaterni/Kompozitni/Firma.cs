using System;
using System.Collections.Generic;
using System.Text;

namespace Kompozitni
{
    public class Firma
    {
        List<IZaposlenik> zaposlenici = new List<IZaposlenik>();

        public List<IZaposlenik> Zaposlenici { get => zaposlenici; set => zaposlenici = value; }

        public string dajSvePlate()
        {
            string svePlate = "";
            foreach (IZaposlenik z in Zaposlenici)
            {
                svePlate += "Zaposlenik: " + z.GetType().ToString().Substring(11) + ", Plata: " + z.dajPlatu() + " KM\n";
            }
            return svePlate;
        }
    }
}
