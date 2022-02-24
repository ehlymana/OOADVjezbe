using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class MuskiAvatar : Avatar
    {
        public override void odaberiFrizuru(string frizura)
        {
            if (new List<string> { "Podignuta", "Kratka", "Ošišana na ćelavo" }.Find(x => x == frizura) != null)
                this.frizura = frizura;
            else
                throw new Exception("Nedozvoljena frizura!");
        }
    }
}
