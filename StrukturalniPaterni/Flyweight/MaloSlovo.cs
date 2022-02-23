using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    public class MaloSlovo : ISlovo
    {
        int veličina = 10;
        bool veliko = false;
        bool štampano = true;
        int broj;

        public MaloSlovo(int no)
        {
            broj = no;
        }

        public string dajVrstu()
        {
            return "Malo slovo";
        }

        public int dajBroj()
        {
            return broj;
        }
    }
}
