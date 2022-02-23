using System;
using System.Collections.Generic;

namespace Dekorater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Slika osnovnaSlika = new Slika();
            osnovnaSlika.postaviImeSlike("Slika");

            List<ISlika> dekoracije = new List<ISlika>()
            { 
                new SlikaOsnovnePromjene(),
                new SlikaFilteri()
            };

            Console.Out.WriteLine("Slika prije promjena: " + osnovnaSlika.dajImeSlike());

            dekoracije[0].postaviSliku(osnovnaSlika);
            dekoracije[0].edituj(0);
            Console.Out.WriteLine("Slika nakon osnovnih promjena: " + dekoracije[0].dajSliku().dajImeSlike());

            dekoracije[1].postaviSliku(dekoracije[0].dajSliku());
            dekoracije[1].edituj(1);
            Console.Out.WriteLine("Slika nakon promjena sa filterima: " + dekoracije[1].dajSliku().dajImeSlike());
        }
    }
}
