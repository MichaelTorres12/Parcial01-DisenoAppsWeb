using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Parcial.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string user, string password)
        {
            try
            {
                using (RC101320Entities db = new RC101320Entities())
                {
                    var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password); // Hashea la contraseña ingresada

                    var userInDb = db.Estudiantes.FirstOrDefault(u => u.email == user && u.password == password);

                    if (userInDb != null && BCrypt.Net.BCrypt.Verify(password, userInDb.password))
                    {
                       return RedirectToAction("Index","Home");    
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "usuario o contraseña invalido";
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones, registra el error o realiza otras acciones necesarias.
                Debug.WriteLine("Error en el inicio de sesión: " + ex.Message);
                return Content("Error en el inicio de sesión");
            }

          
        }

    }
}
