using System;
using System.Collections.Generic;

namespace MovieSavedApp.Models
{
    public partial class Movie
    {
        public Movie()
        {
            this.MoviesActors = new List<MovieActor>();
            this.MoviesCountries = new List<MovieCountry>();
            this.MoviesDirectors = new List<MovieDirector>();
            this.MoviesUsers = new List<MovieUser>();
            this.MoviesGenres = new List<MovieGenre>();
        }

        public int MovieId { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string PosterUrl { get; set; }
        public string ImdbId { get; set; }
        public virtual ICollection<MovieActor> MoviesActors { get; set; }
        public virtual ICollection<MovieCountry> MoviesCountries { get; set; }
        public virtual ICollection<MovieDirector> MoviesDirectors { get; set; }
        public virtual ICollection<MovieUser> MoviesUsers { get; set; }
        public virtual ICollection<MovieGenre> MoviesGenres { get; set; }
    }
}
