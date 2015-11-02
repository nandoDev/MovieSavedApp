using System;
using System.Collections.Generic;

namespace MovieSavedApp.Models
{
    public partial class MovieUserTypeStorage
    {
        public int MovieUserTypeStorageId { get; set; }
        public int MovieUser_Id { get; set; }
        public int TypeStorage_Id { get; set; }
        public virtual MovieUser MovieUser { get; set; }
        public virtual TypeStorage TypeStorage { get; set; }
    }
}
