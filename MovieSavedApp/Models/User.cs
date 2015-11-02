using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieSavedApp.Models
{
    public partial class User
    {
        public User()
        {
            this.MoviesUsers = new List<MovieUser>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual ICollection <MovieUser> MoviesUsers { get; set; }
    }
}
