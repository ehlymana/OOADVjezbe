using System;
using System.Collections.Generic;
using System.Text;

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
