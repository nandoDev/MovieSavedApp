using System;
using System.Collections.Generic;

namespace MovieSavedApp.Models
{
    public partial class Genre
    {
        public Genre()
        {
            this.MoviesGenres = new List<MovieGenre>();
        }

        public int GenreId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MovieGenre> MoviesGenres { get; set; }
    }
}
