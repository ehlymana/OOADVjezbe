using System;
using System.Collections.Generic;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IBuilder> builderi = new List<IBuilder>()
            {
                new AutomatskiBuilder(),
                new ManuelniBuilder()
            };
            ((AutomatskiBuilder)builderi[0]).napraviGraficku();
            ((AutomatskiBuilder)builderi[0]).napraviSpremistePodataka();
            ((AutomatskiBuilder)builderi[0]).napraviCitac();

            ((ManuelniBuilder)builderi[1]).napraviGraficku("AMD", "NVIDIA");
            ((ManuelniBuilder)builderi[1]).napraviSpremistePodataka("256 GB", "");
            ((ManuelniBuilder)builderi[1]).napraviCitac(false, false, true);

            foreach (IBuilder builder in builderi)
            {
                PC pc = builder.dajPC();

                Console.Out.WriteLine("Vrsta buildera: " + builder.GetType().ToString().Substring(8));
                Console.Out.WriteLine("Grafička kartica: " + pc.GrafickaKartica + ", Dodatna grafička kartica: " + pc.DodatnaGrafickaKartica);
                Console.Out.WriteLine("Spremište podataka: " + pc.SpremistePodataka + ", Dodatni HDD: " + pc.DodatniHDD);
                Console.Out.WriteLine("CDROM: " + pc.CDROM1 + ", DVDROM: " + pc.DVDROM1 + ", Floppy: " + pc.Floppy + "\n");
            }
        }
    }
}
