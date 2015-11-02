using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieSavedApp.Models;

namespace MovieSavedApp.Controllers
{
    public class FiltrosController : Controller
    {
        MovieSavedDbContext db = new MovieSavedDbContext();

        // GET: Filtros
        public ActionResult FiltroGenero(string genero)
        {
            if ((Session["LogedUserId"]) != null)
            {
                var id_User = (Session["LogedUserId"]);
                var logedUser = Convert.ToInt32(id_User);
                var generoFiltro = db.Genres.Single(u=>u.Name.Equals(genero));


                var relacionpeliculasporusuario = db.MoviesUsers.Where(u=>u.User_Id == logedUser);
                List<Movie>peliculasporusuario = new List<Movie>();

                foreach(var relacion in relacionpeliculasporusuario)
                {
                    peliculasporusuario.Add(db.Movies.Single(u=>u.MovieId==relacion.Movie_Id));  
                }

                List<MovieGenre>relacionusuariogenero = new List<MovieGenre>();

                foreach (var movie in peliculasporusuario)
                {
                    foreach (var relaciongenero in movie.MoviesGenres)
                    { 
                          relacionusuariogenero.Add(relaciongenero);
                    }
                }

                var peliculaGeneroFiltro = relacionusuariogenero.Where(u => u.Genre_Id == generoFiltro.GenreId);
                var peliculasfiltradas = peliculaGeneroFiltro.Select(u=>u.Movie).ToList();


                return View(peliculasfiltradas);
            }
            return RedirectToAction("RegistroIngreso", "Inicio");    
         }
    }
}




