using System;
using System.Collections.Generic;

namespace MovieSavedApp.Models
{
    public partial class MovieActor
    {
        public int MovieActorId { get; set; }
        public int Actor_Id { get; set; }
        public int Movie_Id { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
