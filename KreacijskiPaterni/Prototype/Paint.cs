using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Paint
    {
        List<IPrototip> oblici = new List<IPrototip>();

        public List<IPrototip> Oblici { get => oblici; set => oblici = value; }

        public void kreirajNoviOblik(Oblik o)
        {
            Oblici.Add(o);
        }
        public void kopirajOblik(Oblik o)
        {
            Oblici.Add(o.kloniraj());
        }
    }
}
