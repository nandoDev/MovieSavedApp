using System;
using System.Collections.Generic;

namespace MovieSavedApp.Models
{
    public partial class MovieCountry
    {
        public int MovieCountryId { get; set; }
        public int Country_Id { get; set; }
        public int Movie_Id { get; set; }
        public virtual Country Country { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
