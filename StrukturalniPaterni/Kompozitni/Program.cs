using System;

namespace Kompozitni
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma firma = new Firma();
            firma.Zaposlenici.Add(new Direktor());
            firma.Zaposlenici.Add(new Zaposlenik());
            Console.Out.WriteLine("Sve plate zaposlenika firme:");
            Console.Out.WriteLine(firma.dajSvePlate());
        }
    }
}
