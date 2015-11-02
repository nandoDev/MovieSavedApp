using System;
using System.Collections.Generic;

namespace MovieSavedApp.Models
{
    public partial class MovieDirector
    {
        public int MovieDirectorId { get; set; }
        public int Movie_Id { get; set; }
        public int Director_Id { get; set; }
        public virtual Director Director { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
