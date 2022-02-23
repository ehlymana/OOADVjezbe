using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FilmAdapter : IReprodukcija
    {
        MKVFilm film = new MKVFilm();
        public void Reproduciraj()
        {
            film.HDReprodukcija();
        }
    }
}
