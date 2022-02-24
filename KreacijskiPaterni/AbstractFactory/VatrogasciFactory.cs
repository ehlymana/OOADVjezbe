using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class VatrogasciFactory : IFactory
    {
        Mexicana pizza = new Mexicana();
        PilecaSupa supa = new PilecaSupa();
        public Pizza dajPizzu()
        {
            return pizza;
        }
        public Supa dajSupu()
        {
            return supa;
        }
    }
}
