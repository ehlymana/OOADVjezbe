using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class OfflineMode : IMode
    {
        int joystick = 2;

        public void koristiDestinyWeapons()
        {
            throw new Exception("Nemoguće koristiti destiny weapons u offline mode-u!");
        }

        public void igrajMultiplayer(List<string> usernames)
        {
            if (joystick != 2)
                throw new Exception("Konektujte dva joysticka na USB portove!");

            Console.Out.WriteLine("-------Multiplayer Igrica-------");
            Console.Out.Write("Igrači: ");
            foreach (string user in usernames)
                Console.Out.Write(user + " ");
            Console.Out.WriteLine("\n-------Kraj igrice-------");
        }
    }
}
