using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial.Controllers
{
    public class EstudiantesController : Controller
    {
        // GET: Estudiantes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Estudiantes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Estudiantes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudiantes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudiantes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estudiantes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estudiantes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estudiantes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
