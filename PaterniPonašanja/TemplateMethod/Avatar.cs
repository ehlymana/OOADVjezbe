using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class Avatar
    {
        protected string bojaOciju, frizura;
        protected bool sminka;
        
        public void odaberiBojuOciju(string boja)
        {
            if (new List<string> { "Zelena", "Plava", "Smeđa" }.Find(x => x == boja) != null)
                bojaOciju = boja;
            else
                throw new Exception("Nedozvoljena boja očiju!");
        }
        
        public abstract void odaberiFrizuru(string frizura);
        
        public virtual void dodajSminku(bool sminka)
        {
            throw new Exception("Nije dozvoljeno šminkanje avatara!");
        }
        
        public void stvoriAvatara(string boja, string frizura, bool sminka)
        {
            odaberiBojuOciju(boja);
            odaberiFrizuru(frizura);
            dodajSminku(sminka);
        }
    }
}
