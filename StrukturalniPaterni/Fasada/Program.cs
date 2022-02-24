using System;

namespace Fasada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometrijskiOblikFasada fasada = new GeometrijskiOblikFasada();
            Krug krug = fasada.napraviKrug(0, 0, 10);
            Četverougao četverougao = fasada.napraviČetverougao(10, 0, 0, 10, 10);
        }
    }
}
