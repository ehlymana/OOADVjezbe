using System;
using System.Collections.Generic;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MuzickaGrupa grupa = new MuzickaGrupa();
            List<Fan> fanovi = new List<Fan> { new Fan(), new Fan() };
            grupa.Fanovi = fanovi;

            grupa.Pretplatnici = new List<IPretplatnik> { fanovi[0] };
            grupa.zakaziNoviKoncert("Sarajevo", new DateTime(2020, 12, 31));
            
            foreach(Fan fan in fanovi)
                Console.Out.WriteLine("Broj karata koje je fan kupio: " + fan.KupljeneKarte.Count);
        }
    }
}
