using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class ObradaZanimanja : CVMaker
    {
        public ObradaZanimanja(CV c)
        {
            Cv = c;
        }
        public void nadiFakultet()
        {
            Console.Out.WriteLine("Pretraga fakulteta...");
            Cv.Fakultet = "Fakultet";
        }
        public void dodajSmjerove()
        {
            Console.Out.WriteLine("Pretraga smjerova...");
            Cv.Smjerovi = new List<string>() { "Smjer 1", "Smjer 2" };
        }
        public override void obradi()
        {
            nadiFakultet();
            dodajSmjerove();
        }
    }
}
