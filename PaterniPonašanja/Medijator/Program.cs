using System;
using System.Collections.Generic;

namespace Medijator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Klijent maloljetni = new MaloljetniKlijent();
            Klijent punoljetni = new PunoljetniKlijent();
            Klijent agent = new CertificiraniAgent();
            Chat chat = new Chat(new List<Klijent> { maloljetni, punoljetni, agent });
            
            chat.posaljiPoruku(punoljetni, maloljetni, "Zdravo!");
            Console.Out.WriteLine("Broj poruka u inboxu maloljetnog klijenta: " + maloljetni.PrimljenePoruke.Count);
            
            chat.posaljiPoruku(maloljetni, agent, "Govor mržnje");
            Console.Out.WriteLine("Broj poruka u inboxu certificiranog agenta: " + agent.PrimljenePoruke.Count);

            chat.posaljiPoruku(punoljetni, agent, "OK");
            Console.Out.WriteLine("Broj poruka u inboxu certificiranog agenta: " + agent.PrimljenePoruke.Count);
        }
    }
}
