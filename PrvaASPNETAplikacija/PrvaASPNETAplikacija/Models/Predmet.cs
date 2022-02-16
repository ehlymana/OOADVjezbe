using System;
using System.Collections.Generic;

namespace PrvaASPNETAplikacija.Models
{
    public class Predmet
    {
        int ID;
        string naziv;
        double ECTS;
        List<Student> upisaniStudenti;

        public int GenerišiID()
        {
            int id = 0;
            Random generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                id += (int)Math.Pow(10, i) * generator.Next(0, 9);
            }
            return id;
        }
    }
}
