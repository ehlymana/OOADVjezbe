using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class ZenskiAvatar : Avatar
    {
        public override void odaberiFrizuru(string frizura)
        {
            if (new List<string> { "Rep", "Puštena", "Pletenice", "Šiške", "Ombre" }.Find(x => x == frizura) != null)
                this.frizura = frizura;
            else
                throw new Exception("Nedozvoljena frizura!");
        }
        public override void dodajSminku(bool sminka)
        {
            this.sminka = sminka;
        }
    }
}
