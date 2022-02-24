using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class OnlineMode : IMode
    {
        public void koristiDestinyWeapons()
        {
            Console.Out.WriteLine("Koriste se destiny weapons!");
        }

        public void igrajMultiplayer(List<string> usernames)
        {
            Console.Out.WriteLine("-------Multiplayer Igrica-------");
            Console.Out.Write("Igrači: ");
            foreach (string user in usernames)
                Console.Out.Write(user + " ");
            Console.Out.WriteLine("\n-------Kraj igrice-------");
        }
    }
}
