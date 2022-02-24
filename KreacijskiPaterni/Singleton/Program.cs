using System;
using System.Collections.Generic;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vlada vlada = new Vlada();
            List<bool> saglasnosti = new List<bool> { true, true };
            vlada.izaberiPremijera("Premijer", "1", saglasnosti);
            Console.Out.WriteLine("Premijer nakon prvog pokušaja postavljanja: " + PremijerSingleton.dajPremijera().Ime + " " + PremijerSingleton.dajPremijera().Prezime);
            
            vlada.izaberiPremijera("Premijer", "2", saglasnosti);
            Console.Out.WriteLine("Premijer nakon drugog pokušaja postavljanja: " + PremijerSingleton.dajPremijera().Ime + " " + PremijerSingleton.dajPremijera().Prezime);
        }
    }
}
