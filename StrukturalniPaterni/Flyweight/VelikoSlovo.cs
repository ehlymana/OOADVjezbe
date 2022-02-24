using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class VelikoSlovo : ISlovo
    {
        int veličina = 12;
        bool veliko = true;
        bool štampano = true;
        int broj;

        public VelikoSlovo(int no)
        {
            broj = no;
        }

        public string dajVrstu()
        {
            return "Veliko slovo";
        }

        public int dajBroj()
        {
            return broj;
        }
    }
}
