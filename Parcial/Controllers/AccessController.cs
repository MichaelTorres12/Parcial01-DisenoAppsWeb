using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        private RC101320Entities1 db = new RC101320Entities1();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string user, string password)
        {
            var usuario = db.Usuarios.FirstOrDefault(u => u.User == user && u.Password == password);

            if (usuario != null)
            {
                return RedirectToAction("MenuPrincipal", "Home");
            }

            ViewBag.Error = "El usuario " + user + " no existe en la base de datos";
            return RedirectToAction("Login", "Access", new { error = "El usuario " + user + " no existe en la base de datos" });
        }
    }
}
