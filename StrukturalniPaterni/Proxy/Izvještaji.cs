using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class Izvještaji : IIzvještaji
    {
        public string pregledSvihIzvještaja()
        {
            return "Svi izvještaji";
        }
        public string pregledStarihIzvještaja()
        {
            return "Stari izvještaji";
        }
    }
}
