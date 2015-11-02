using System;
using System.Collections.Generic;

namespace MovieSavedApp.Models
{
    public partial class MovieUser
    {
        public MovieUser()
        {
            this.MoviesUsersTypeStorages = new List<MovieUserTypeStorage>();
        }

        public int MovieUserId { get; set; }
        public int User_Id { get; set; }
        public int Movie_Id { get; set; }
        public Nullable<bool> Seen { get; set; }
        public Nullable<bool> Favorite { get; set; }
        public Nullable<int> PersonalScore { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<MovieUserTypeStorage> MoviesUsersTypeStorages { get; set; }
    }
}
