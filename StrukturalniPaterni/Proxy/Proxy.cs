using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class Proxy : IIzvještaji
    {
        IIzvještaji izvještaji = new Izvještaji();
        int nivoPristupa = 0;

        public void pristup(string username, string password)
        {
            if (Char.IsDigit(username[username.Length - 1]) && password == "OOAD2021")
            {
                nivoPristupa = 1;
            }
            else if (password == "OOAD2020")
            {
                nivoPristupa = 2;
            }
            else nivoPristupa = 0;
        }

        public string pregledSvihIzvještaja()
        {
            if (nivoPristupa == 1) return izvještaji.pregledSvihIzvještaja();
            else return "PRISTUP ZABRANJEN";
        }

        public string pregledStarihIzvještaja()
        {
            if (nivoPristupa == 1 || nivoPristupa == 2) return izvještaji.pregledStarihIzvještaja();
            else return "PRISTUP ZABRANJEN";
        }
    }
}
