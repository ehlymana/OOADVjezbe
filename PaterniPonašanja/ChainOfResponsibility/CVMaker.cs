using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class CVMaker : IHandler
    {
        CV cv = new CV();
        CVMaker obrada;

        public CV Cv { get => cv; set => cv = value; }

        public void napraviCV(string imeIPrezime, string mjesto, string zanimanje)
        {
            Cv.ImeIPrezime = imeIPrezime;
            Cv.MjestoStanovanja = mjesto;
            Cv.Zanimanje = zanimanje;
        }

        public void proslijediDalje()
        {
            if (obrada is null)
                obrada = new ObradaLokacije(Cv);
            else if (obrada is ObradaLokacije)
                obrada = new ObradaZanimanja(Cv);
        }

        public virtual void obradi()
        {
            obrada.obradi();
            Cv = obrada.Cv;
        }
    }
}
