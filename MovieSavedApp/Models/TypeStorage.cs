using System;
using System.Collections.Generic;

namespace MovieSavedApp.Models
{
    public partial class TypeStorage
    {
        public TypeStorage()
        {
            this.MoviesUsersTypeStorages = new List<MovieUserTypeStorage>();
        }

        public int TypeStorageId { get; set; }
        public string TypeStorageName { get; set; }
        public virtual ICollection<MovieUserTypeStorage> MoviesUsersTypeStorages { get; set; }
    }
}
