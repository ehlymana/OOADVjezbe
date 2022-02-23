using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class Bridge
    {
        IPlata bridge;
        public Bridge(IPlata b)
        {
            bridge = b;
        }
        public double dajPlatu()
        {
            return 400 + bridge.izračunajPlatu();
        }
    }
}
