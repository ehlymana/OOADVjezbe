using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
