using System;
using System.Collections.Generic;
using System.Text;

namespace Medijator
{
    public class Chat : IMedijator
    {
        List<Klijent> klijenti;

        public Chat(List<Klijent> k)
        {
            foreach (var client in k)
            {
                if (client is MaloljetniKlijent)
                    ((MaloljetniKlijent)client).Medijator = this;
                else if (client is CertificiraniAgent)
                    ((CertificiraniAgent)client).Medijator = this;
            }
            klijenti = k;
        }

        public bool provjeriPorukuPrimalac(Klijent k1, Klijent k2)
        {
            bool maloljetniAgentu = (k1 is MaloljetniKlijent && k2 is CertificiraniAgent);
            bool agentMaloljetnom = (k1 is CertificiraniAgent && k2 is MaloljetniKlijent);
            return (maloljetniAgentu || agentMaloljetnom);
        }

        public bool provjeriPorukuSadrzaj(string sadrzaj)
        {
            return !sadrzaj.Contains("Govor mržnje");
        }

        public void posaljiPoruku(Klijent k1, Klijent k2, string sadrzaj)
        {
            k1.dodajPoslanuPoruku(k2, sadrzaj);
            k2.dodajPrimljenuPoruku(k1, sadrzaj);
        }
    }
}
