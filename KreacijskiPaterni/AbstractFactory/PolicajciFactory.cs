using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class PolicajciFactory : IFactory
    {
        Capricciosa pizza = new Capricciosa();
        TelecaSupa supa = new TelecaSupa();
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
