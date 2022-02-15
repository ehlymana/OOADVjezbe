using Biblioteka;
using System;

namespace Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banka banka = new Banka();
            Console.WriteLine("  Dobro došli u sistem za rad sa bankom!");
            string ulaz = "";
            do
            {
                Console.WriteLine("  1 - Rad s klijentima, 0 - Izlaz");
                ulaz = Console.ReadLine();
                if (ulaz == "1")
                {
                    Console.WriteLine("  1 - Dodavanje, 2 - Pretraga");
                    ulaz = Console.ReadLine();
                    if (ulaz == "1")
                    {
                        Console.WriteLine("  ID klijenta:");
                        int id = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("  Ime klijenta:");
                        string ime = Console.ReadLine();
                        Klijent klijent = new Klijent(id, ime);
                        banka.DodajKlijenta(klijent);
                    }
                    else if (ulaz == "2")
                    {
                        Console.WriteLine("  ID klijenta:");
                        int id = Int32.Parse(Console.ReadLine());
                        Klijent pronađeni = banka.PronadiKlijenta(id);
                        if (pronađeni == null)
                            Console.WriteLine("  Traženi klijent ne postoji u bazi podataka!");
                        else
                            Console.WriteLine("  ID: " + pronađeni.Identitet + ", Ime: " + pronađeni.Ime + ", Broj otvorenih računa: " + pronađeni.Racuni.Count);
                    }
                }
            }
            while (ulaz != "0");
        }
    }
}
