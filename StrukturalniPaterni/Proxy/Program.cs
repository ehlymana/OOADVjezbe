using System;

namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            string izvještaji = proxy.pregledSvihIzvještaja();
            Console.Out.WriteLine("Svi izvještaji bez autentifikacije: \n" + izvještaji);
            izvještaji = proxy.pregledStarihIzvještaja();
            Console.Out.WriteLine("Stari izvještaji bez autentifikacije: \n" + izvještaji + "\n");

            proxy.pristup("Student1", "OOAD2020");
            izvještaji = proxy.pregledSvihIzvještaja();
            Console.Out.WriteLine("Svi izvještaji za nivo pristupa 2: \n" + izvještaji);
            izvještaji = proxy.pregledStarihIzvještaja();
            Console.Out.WriteLine("Stari izvještaji za nivo pristupa 2: \n" + izvještaji + "\n");

            proxy.pristup("Student1", "OOAD2021");
            izvještaji = proxy.pregledSvihIzvještaja();
            Console.Out.WriteLine("Svi izvještaji za nivo pristupa 1: \n" + izvještaji);
            izvještaji = proxy.pregledStarihIzvještaja();
            Console.Out.WriteLine("Stari izvještaji za nivo pristupa 1: \n" + izvještaji);
        }
    }
}
