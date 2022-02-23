using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IIzvjestaj> izvještaji = new List<IIzvjestaj>()
            {
                new StariIzvjestaj(),
                new NoviIzvjestaj()
            };

            izvještaji.ForEach(izvještaj => izvještaj.napraviIzvjestaj());

            foreach (Izvjestaj izvještaj in izvještaji)
            {
                Console.Out.Write("Tip izvještaja: " + izvještaj.GetType().ToString().Substring(14));
                Console.Out.Write(", Tip statistike: " + izvještaj.Statistika.GetType().ToString().Substring(14));
                Console.Out.Write(", Tip ankete: " + izvještaj.Anketa.GetType().ToString().Substring(14) + "\n\n");
            }
        }
    }
}
