using Pdbc.Music.Domain.Model;
using System;
using System.Linq;

namespace Pdbc.Music.Data.Seed
{
    public class MusicDataObjects : IHaveDataObjects
    {
        private readonly MusicDbContext _context;

        public MusicDataObjects(MusicDbContext context)
        {
            _context = context;
        }

        public void LoadObjects()
        {
            GenreLatin = GetGenreFor(MusicDataObjectsValues.GenreLatin);
            GenreElectricMusic = GetGenreFor(MusicDataObjectsValues.GenreElectricMusic);
            GenreDutch = GetGenreFor(MusicDataObjectsValues.GenreDutch);
            GenreFolk = GetGenreFor(MusicDataObjectsValues.GenreFolk);

        }

        public Genre GenreLatin { get; set; }
        public Genre GenreElectricMusic { get; set; }
        public Genre GenreDutch { get; set; }
        public Genre GenreFolk { get; set; }


        public Genre GetGenreFor(String name)
        {
            var genre = _context.Genres.FirstOrDefault(x => x.Name == name);
            return genre;
        }


    }
}