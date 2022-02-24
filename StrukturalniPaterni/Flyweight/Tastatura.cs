using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class Tastatura
    {
        List<ISlovo> slova = new List<ISlovo>();

        public List<ISlovo> Slova { get => slova; set => slova = value; }

        public ISlovo dajSlovo(string vrsta, int broj)
        {
            foreach (ISlovo s in Slova)
            {
                if (s.dajVrstu() == vrsta && s.dajBroj() == broj) return s;
            }
            ISlovo slovo;
            if (vrsta == "Veliko slovo") slovo = new VelikoSlovo(broj);
            else slovo = new MaloSlovo(broj);
            Slova.Add(slovo);
            return slovo;
        }
    }
}
