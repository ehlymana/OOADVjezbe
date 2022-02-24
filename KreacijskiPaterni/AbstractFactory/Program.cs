using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFactory> meniji = new List<IFactory>()
            {
                new PolicajciFactory(),
                new VatrogasciFactory()
            };

            foreach (IFactory menu in meniji)
            {
                Console.Out.Write("Meni: " + menu.GetType().ToString().Substring(16));
                Console.Out.Write(", Pizza: " + menu.dajPizzu().GetType().ToString().Substring(16));
                Console.Out.Write(", Supa: " + menu.dajSupu().GetType().ToString().Substring(16) + "\n\n");
            }
        }
    }
}
