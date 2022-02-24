using System;
using System.Collections.Generic;
using System.Text;

namespace Medijator
{
    public abstract class Klijent
    {
        Dictionary<Klijent, string> primljenePoruke = new Dictionary<Klijent, string>(), poslanePoruke = new Dictionary<Klijent, string>();

        public Dictionary<Klijent, string> PoslanePoruke { get => poslanePoruke; set => poslanePoruke = value; }
        public Dictionary<Klijent, string> PrimljenePoruke { get => primljenePoruke; set => primljenePoruke = value; }

        public virtual void dodajPoslanuPoruku(Klijent primalac, string sadržaj)
        {
            poslanePoruke.Add(primalac, sadržaj);
        }

        public virtual void dodajPrimljenuPoruku(Klijent pošiljalac, string sadržaj)
        {
            primljenePoruke.Add(pošiljalac, sadržaj);
        }
    }
}
