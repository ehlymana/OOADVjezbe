using System;

namespace Primjer_1___Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inicijalizacija nizova podataka
            int[] ocjene = new int[15]
            {
                6, 6, 6, 7, 7, 7, 8, 8, 8, 8, 8, 9, 9, 10, 10
            };

            Tuple<int, double>[] ponavljanjaOcjena = new Tuple<int, double>[5]
            {
                new Tuple<int, double>(6, 0),
                new Tuple<int, double>(7, 0),
                new Tuple<int, double>(8, 0),
                new Tuple<int, double>(9, 0),
                new Tuple<int, double>(10, 0)
            };

            // računanje broja ponavljanja svih ocjena
            foreach (var ocjena in ocjene)
                ponavljanjaOcjena[ocjena - 6] = new Tuple<int, double>(ocjena, ponavljanjaOcjena[ocjena - 6].Item2 + 1);

            // pretvaranje broja ponavljanja u postotke
            for (int i = 0; i < ponavljanjaOcjena.Length; i++)
                ponavljanjaOcjena[i] = new Tuple<int, double>(ponavljanjaOcjena[i].Item1, ponavljanjaOcjena[i].Item2 / ocjene.Length * 100);

            // prikaz rezultata
            foreach (var ocjena in ponavljanjaOcjena)
                Console.WriteLine("  Ocjena: " + ocjena.Item1 + ", Postotak: " + ocjena.Item2 + "% studenata");
        }
    }
}
