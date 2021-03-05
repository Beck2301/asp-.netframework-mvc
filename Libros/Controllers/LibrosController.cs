using Libros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa;

namespace Libros.Controllers
{
 

    public class LibrosController : Controller

    {
        Datos modelo = new Datos();
        Agregar registros = new Agregar();
        // GET: Libros
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Formulario()
        {
            Datos model = new Datos();
            return View(model);
        }


        [HttpPost]
        public ActionResult AgregarDato(Datos datos)
        {
            if (ModelState.IsValid)
            {
                registros.Guardar(datos);
                return View("Correcto");

            }
            else
            {
                return View("Formulario",datos);
            }
      
        }

        public ActionResult MostrarDatos()
        {
            string todos = registros.Leer();
            ViewData["datos"] = todos;
            return View();
        }

        public ActionResult ImprimirPDF()
        {
            string todos = registros.Leer();
            ViewData["datos"] = todos;
            return new ViewAsPdf("PDF")
            {
                PageMargins = new Rotativa.Options.Margins(10, 20,10,20),
                FileName="Datos.pdf"
            };
        }
    }
}