using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorater
{
    public class Slika
    {
        string ime;

        public string dajImeSlike()
        {
            return ime;
        }
        public void postaviImeSlike(string s)
        {
            ime = s;
        }
    }
}
