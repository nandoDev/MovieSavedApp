using System;
using System.Collections.Generic;

namespace MovieSavedApp.Models
{
    public partial class Director
    {
        public Director()
        {
            this.MoviesDirectors = new List<MovieDirector>();
        }

        public int DirectorId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MovieDirector> MoviesDirectors { get; set; }
    }
}
