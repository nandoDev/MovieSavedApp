using System;
using System.Collections.Generic;

namespace MovieSavedApp.Models
{
    public partial class Actor
    {
        public Actor()
        {
            this.MoviesActors = new List<MovieActor>();
        }

        public int ActorId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MovieActor> MoviesActors { get; set; }
    }
}
