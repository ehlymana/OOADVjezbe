using System;
using System.Collections.Generic;

namespace Primjer_2___List
{
    class Program
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

            List<Tuple<string, int>> studentiZaBrisanje = new List<Tuple<string, int>>();

            // pronalazak studenata koji se trebaju obrisati
            foreach (var student in studenti)
            {
                if (student.Item2 < 16000)
                    studentiZaBrisanje.Add(student);
            }

            // brisanje studenata
            foreach (var student in studentiZaBrisanje)
                studenti.Remove(student);

            // sortiranje preostalih studenata
            for (int i = 0; i < studenti.Count; i++)
            {
                int min = i;
                for (int j = i + 1; j < studenti.Count; j++)
                {
                    // indeksi isti - potrebno ispisati poruku o grešci
                    if (studenti[j].Item2 == studenti[min].Item2)
                    {
                        Console.WriteLine("U listi postoje dva studenta sa istim indeksom - greška!");
                        return;
                    }

                    // pronađeni element je abecedno prije trenutno najmanjeg elementa
                    if (string.Compare(studenti[j].Item1, studenti[min].Item1) < 0)
                        min = j;

                    // elementi su isti - potrebno provjeriti broj indeksa
                    else if (string.Compare(studenti[j].Item1, studenti[min].Item1) == 0)
                    {
                        // indeks pronađenog elementa manji od trenutno najmanjeg
                        if (studenti[j].Item2 < studenti[min].Item2)
                            min = j;
                    }
                }

                // zamjena elemenata
                Tuple<string, int> temp = studenti[i];
                studenti[i] = studenti[min];
                studenti[min] = temp;
            }

            // prikaz rezultata
            Console.WriteLine("  Studenti nakon sortiranja:");
            foreach(var student in studenti)
            {
                Console.WriteLine("  Ime: " + student.Item1 + ", Indeks: " + student.Item2.ToString());
            }
        }
    }
}
