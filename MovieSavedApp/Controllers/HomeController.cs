using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieSavedApp.Models;

namespace MovieSavedApp.Controllers
{
    public class HomeController : Controller
    {
        MovieSavedDbContext db = new MovieSavedDbContext();

        public ActionResult VistaTabla()
        {
            if ((Session["LogedUserId"]) != null)
            {
                var id_User = (Session["LogedUserId"]);
                var logedUser = Convert.ToInt32(id_User);
                var listaRelacionMovieUser = db.MoviesUsers.Where(u => u.User_Id == logedUser);
                //var peliculasUsuario = listaRelacionMovieUser.Select(u => u.Movie).ToList();
                return View(listaRelacionMovieUser);
            }
            return RedirectToAction("RegistroIngreso", "Inicio");
        }

        public ActionResult VistaPoster()
        {
            if ((Session["LogedUserId"]) != null)
            { 
                var id_User = (Session["LogedUserId"]);
                var logedUser = Convert.ToInt32(id_User);
                var listaRelacionMovieUser = db.MoviesUsers.Where(u => u.User_Id == logedUser);
                var peliculasUsuario = listaRelacionMovieUser.Select(u => u.Movie).ToList();
                return View(peliculasUsuario);
            }
            return RedirectToAction("RegistroIngreso", "Inicio");
        }

        [ChildActionOnly]
        public ActionResult GeneroMenu()
        {
            var id_User = (Session["LogedUserId"]);
            var logedUser = Convert.ToInt32(id_User);
            var generos = db.Genres.ToList();

            var relacionpeliculasporusuario = db.MoviesUsers.Where(u=>u.User_Id == logedUser);
            List<Movie>peliculasporusuario = new List<Movie>();

            foreach(var relacion in relacionpeliculasporusuario)
            {
               peliculasporusuario.Add(db.Movies.Single(u=>u.MovieId==relacion.Movie_Id));  
            }

            List<MovieGenre>relacionusuariogenero = new List<MovieGenre>();

            foreach (var movie in peliculasporusuario)
            {
                foreach (var relaciongenero in movie.MoviesGenres) { 
                    relacionusuariogenero.Add(relaciongenero);
                }
            }
            return PartialView(relacionusuariogenero);
        }
    }
}
