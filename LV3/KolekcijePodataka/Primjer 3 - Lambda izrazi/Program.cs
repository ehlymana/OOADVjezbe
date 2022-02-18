using System;
using System.Collections.Generic;
using System.Linq;

namespace Primjer_3___Lambda_izrazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inicijalizacija liste studenata
            List<Tuple<string, int>> studenti = new List<Tuple<string, int>>()
            {
                new Tuple<string, int>("Emina", 16000),
                new Tuple<string, int>("Amina", 15000),
                new Tuple<string, int>("Edina", 18000),
                new Tuple<string, int>("Emin", 17000),
                new Tuple<string, int>("Edin", 19001),
                new Tuple<string, int>("Edin", 19000),
                new Tuple<string, int>("Amina", 15001)
            };

            // brisanje svih studenata koji ispunjavaju kriterij
            studenti.RemoveAll(student => student.Item2 < 16000);

            // pokušaj pronalaska dva studenta s istim indeksom
            if (studenti.Any(student => studenti.Where(student2 => student2.Item2 == student.Item2).ToList().Count > 1))
            {
                Console.WriteLine("U listi postoje dva studenta sa istim indeksom - greška!");
                return;
            }

            // sortiranje preostalih studenata
            studenti = studenti.OrderBy(student => student.Item1).ThenBy(student => student.Item2).ToList();

            // prikaz rezultata
            Console.WriteLine("Studenti nakon sortiranja:");
            foreach (var student in studenti)
            {
                Console.WriteLine("Ime: " + student.Item1 + ", Indeks: " + student.Item2.ToString());
            }
        }
    }
}
