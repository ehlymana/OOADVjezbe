using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Igrica
    {
        bool online = false;
        IMode stanje;

        public bool Online { get => online; set => online = value; }

        public void igrajSinglePlayer()
        {
            Console.Out.WriteLine("-------Single Player Igrica-------");

            if (Online)
                stanje = new OnlineMode();
            else
                stanje = new OfflineMode();

            stanje.koristiDestinyWeapons();

            Console.Out.WriteLine("-------Kraj igrice-------");
        }

        public void igrajMultiplayer(List<string> usernames)
        {
            if (Online)
                stanje = new OnlineMode();
            else
                stanje = new OfflineMode();

            stanje.igrajMultiplayer(usernames);

            stanje.koristiDestinyWeapons();
        }
    }
}
