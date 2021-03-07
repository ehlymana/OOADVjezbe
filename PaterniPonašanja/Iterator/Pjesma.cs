using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class Pjesma
    {
        string naziv, izvodac, zanr;

        public string Naziv { get => naziv; set => naziv = value; }
        public string Izvodac { get => izvodac; set => izvodac = value; }
        public string Zanr { get => zanr; set => zanr = value; }

        public Pjesma(string name, string artist, string genre)
        {
            Naziv = name;
            Izvodac = artist;
            Zanr = genre;
        }
    }
}
