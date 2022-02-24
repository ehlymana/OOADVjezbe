using System;
using System.Collections.Generic;

namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tastatura t = new Tastatura();

            for (int i = 0; i < 5; i++)
            {
                t.dajSlovo("Veliko slovo", i);
                t.dajSlovo("Malo slovo", i);
            }

            Console.Out.WriteLine("Broj slova u listi nakon dodavanja 5 novih slova: " + t.Slova.Count);

            for (int i = 0; i < 5; i++)
            {
                t.dajSlovo("Veliko slovo", i);
                t.dajSlovo("Malo slovo", i);
            }

            Console.Out.WriteLine("Broj slova u listi nakon dodavanja 5 istih slova: " + t.Slova.Count);
        }
    }
}
