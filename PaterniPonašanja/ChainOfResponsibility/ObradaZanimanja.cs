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
            Cv.Fakultet = "Fakultet za zanimanje - inžinjer elektrotehnike";
        }

        public override void obradi()
        {
            nadiFakultet();
        }
    }
}
