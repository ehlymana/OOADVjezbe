using System;
using System.Collections.Generic;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPlata> zaposlenici = new List<IPlata>()
            {
                new MedicinskaSestra(1.5),
                new Doktor(2.0)
            };
            foreach (var zaposlenik in zaposlenici)
            {
                Bridge bridge = new Bridge(zaposlenik);
                Console.Out.WriteLine("Plata za zaposlenika " + zaposlenik.GetType().ToString().Substring(7) + " iznosi " + bridge.dajPlatu().ToString() + " KM.");
            }
        }
    }
}
