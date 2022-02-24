using System;

namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Avatar musko = new MuskiAvatar();
            try
            {
                musko.stvoriAvatara("Zelena", "Podignuta", true);
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
            Avatar zensko = new ZenskiAvatar();
            zensko.stvoriAvatara("Smeđa", "Puštena", true);
            Console.Out.WriteLine("Šminkanje ženskog avatara uspješno!");
            try
            {
                zensko.stvoriAvatara("Plava", "Podignuta", true);
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
        }
    }
}
