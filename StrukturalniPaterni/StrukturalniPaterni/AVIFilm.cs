using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class AVIFilm : IReprodukcija
    {
        public void Reproduciraj()
        {
            Console.Out.WriteLine("Reprodukcija u starom formatu!");
        }
    }
}
