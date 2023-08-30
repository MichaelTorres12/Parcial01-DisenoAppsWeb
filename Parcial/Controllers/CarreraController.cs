using Parcial.Models;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace Parcial.Controllers
{
    public class CarreraController : Controller
    {
        private RC101320Entities1 db = new RC101320Entities1();
        // GET: Carrera

        public ActionResult Index()
        {
            var carreras = db.Database.SqlQuery<Carrera>("ObtenerCarreras_Result").ToList();
            return View(carreras);
        }

        public ActionResult Detalle(int id)
        {
            var carrera = db.Carreras.Find(id);
            if (carrera == null)
            {
                return HttpNotFound();
            }
            return View(carrera);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
