using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class PC
    {
        string grafickaKartica, dodatnaGrafickaKartica, spremistePodataka, dodatniHDD;
        bool CDROM, DVDROM, floppy;

        public string GrafickaKartica { get => grafickaKartica; set => grafickaKartica = value; }
        public string DodatnaGrafickaKartica { get => dodatnaGrafickaKartica; set => dodatnaGrafickaKartica = value; }
        public string SpremistePodataka { get => spremistePodataka; set => spremistePodataka = value; }
        public string DodatniHDD { get => dodatniHDD; set => dodatniHDD = value; }
        public bool CDROM1 { get => CDROM; set => CDROM = value; }
        public bool DVDROM1 { get => DVDROM; set => DVDROM = value; }
        public bool Floppy { get => floppy; set => floppy = value; }
    }
}
