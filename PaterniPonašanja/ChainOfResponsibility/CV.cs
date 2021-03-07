using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class CV
    {
        string ime, prezime, mjestoStanovanja, zanimanje, univerzitet, fakultet, slika;
        double rating;
        List<string> smjerovi = new List<string>();

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string MjestoStanovanja { get => mjestoStanovanja; set => mjestoStanovanja = value; }
        public string Zanimanje { get => zanimanje; set => zanimanje = value; }
        public string Univerzitet { get => univerzitet; set => univerzitet = value; }
        public string Fakultet { get => fakultet; set => fakultet = value; }
        public string Slika { get => slika; set => slika = value; }
        public double Rating { get => rating; set => rating = value; }
        public List<string> Smjerovi { get => smjerovi; set => smjerovi = value; }
    }
}
