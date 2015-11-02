using System;
using System.Collections.Generic;

namespace MovieSavedApp.Models
{
    public partial class MovieGenre
    {
        public int MovieGenreId { get; set; }
        public int Genre_Id { get; set; }
        public int Movie_Id { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
