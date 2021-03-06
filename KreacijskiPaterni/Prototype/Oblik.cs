using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Oblik : IPrototip
    {
        String oblik, boja, bojaIvica, tipIvica;
        double velicina;
        int debljinaIvica, zakrivljenost, transparentnost, x, y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public Oblik (string o, string b, string b2, string t, double v, int d, int z, int t2, int x2, int y2)
        {
            oblik = o; boja = b; bojaIvica = b2; tipIvica = t; velicina = v; debljinaIvica = d; zakrivljenost = z; transparentnost = t2; X = x2; Y = y2; 
        }

        public IPrototip kloniraj()
        {
            Oblik klon = new Oblik(oblik, boja, bojaIvica, tipIvica, velicina, debljinaIvica, zakrivljenost, transparentnost, X + 10, Y + 10);
            return klon;
        }
    }
}
