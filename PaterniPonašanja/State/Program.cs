using System;
using System.Collections.Generic;

namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Igrač je online i želi da igra single player");
            Igrica igrica = new Igrica();
            igrica.Online = true;
            igrica.igrajSinglePlayer();
            Console.Out.WriteLine();
            try
            {
                igrica.Online = false;
                Console.Out.WriteLine("Igrač je sada offline i ponovo želi igrati single player");
                igrica.igrajSinglePlayer();
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
                Console.Out.WriteLine();
                igrica.Online = true;
                Console.Out.WriteLine("Igrač je sada online i želi igrati multiplayer");
            }
            Console.Out.WriteLine();
            igrica.igrajMultiplayer(new List<string> { "Igrač 1", "Igrač 2", "Igrač 3" });
        }
    }
}
