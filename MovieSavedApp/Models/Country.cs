using System;
using System.Collections.Generic;

namespace MovieSavedApp.Models
{
    public partial class Country
    {
        public Country()
        {
            this.MoviesCountries = new List<MovieCountry>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MovieCountry> MoviesCountries { get; set; }
    }
}
