using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieSavedApp.Models;

namespace MovieSavedApp.Controllers
{
    public class InicioController : Controller
    {

        // GET: Inicio
        public ActionResult RegistroIngreso()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistroIngreso(UserViewModel userView)
        {
            using (MovieSavedDbContext db = new MovieSavedDbContext())
            {
                if (ModelState.IsValid)
                {
                    User newUser = new User();
                    newUser.Username = userView.Username;
                    newUser.Email = userView.Email;
                    newUser.Password = userView.Password;
                    db.Users.Add(newUser);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = userView.Username + " se ha registrado exitosamente";
            }
            return View();
        }

        
       
        [ValidateAntiForgeryToken]
        public ActionResult Ingreso(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (MovieSavedDbContext db = new MovieSavedDbContext())
                    {
                        var usr = db.Users.Where(a => a.Username.Equals(user.Username) && a.Password.Equals(user.Password)).FirstOrDefault();
                        if (usr != null)
                        {
                            Session["LogedUserId"] = usr.UserId.ToString();
                            Session["LogedUsername"] = usr.Username.ToString();
                            return RedirectToAction("VistaPoster", "Home");
                        }
                        else
                        {
                            ModelState.AddModelError("keyName", "El usuario o la contraseña es incorrecta");
                            return View("RegistroIngreso");
                        }
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("KeyName", ex.Message);
                    return View("RegistroIngreso");
                }

            }
            return View();
        }

        public ActionResult Salir()
        {
            Session.Abandon();

            //FormsAuthentication.SignOut();
            return RedirectToAction("RegistroIngreso");
        }

    }
}
