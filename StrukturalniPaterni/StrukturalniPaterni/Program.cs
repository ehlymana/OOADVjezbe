using System;
using System.Collections.Generic;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IReprodukcija> filmovi = new List<IReprodukcija>()
            {
                new AVIFilm(),
                new FilmAdapter()
            };

            foreach (var film in filmovi)
                film.Reproduciraj();
        }
    }
}
