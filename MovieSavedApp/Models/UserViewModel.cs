using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieSavedApp.Models
{
    public partial class UserViewModel
    {
        public UserViewModel()
        {
            
        }
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Nombre de usuario es requerido.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email es requerido.")]
        [RegularExpression(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
            + "@"
            + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", ErrorMessage = "E-mail no es válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Contraseña es requerida.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Por favor, confirmar su contraseña")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public virtual ICollection<MovieUser> MoviesUsers { get; set; }
    }
}