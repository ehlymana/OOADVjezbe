using System;
using System.Collections.Generic;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Igrač želi da igra single player");
            Igrica igrica = new Igrica();
            igrica.igrajSinglePlayer();
            Console.Out.WriteLine();
            try
            {
                igrica.Online = false;
                Console.Out.WriteLine("Igrač je sada offline");
                igrica.koristiDestinyWeapons();
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
                Console.Out.WriteLine();
                igrica.Online = true;
                Console.Out.WriteLine("Igrač je sada online");
                igrica.koristiDestinyWeapons();
            }
            Console.Out.WriteLine();
            igrica.igrajMultiplayer(new List<string> { "Igrač 1", "Igrač 2", "Igrač 3" });
        }
    }
}
