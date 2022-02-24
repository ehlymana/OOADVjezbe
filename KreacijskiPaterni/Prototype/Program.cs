using System;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paint paint = new Paint();
            Oblik crveniTrougao = new Oblik("trougao", "crvena", "crna", "linija", 10, 1, 0, 0, 100, 150);

            paint.kreirajNoviOblik(crveniTrougao);
            paint.kopirajOblik(crveniTrougao);

            Console.Out.WriteLine("Oblici: ");
            foreach (Oblik oblik in paint.Oblici)
                Console.Out.WriteLine("X: " + oblik.X + ", Y: " + oblik.Y);
        }
    }
}
