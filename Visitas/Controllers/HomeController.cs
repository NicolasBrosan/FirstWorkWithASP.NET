using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Visitas.Models;

namespace Visitas.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Formulario()
        {
            return View();
        }
        public ActionResult CargaDeDatos()
        {
            var nombre = Request.Form["nombre"].ToString();
            var comentarios = Request.Form["comentarios"].ToString();
            var libro = new LibroDeVisitas();
            libro.Grabar(nombre, comentarios);
            return View();
        }
        public ActionResult ListadoDeVisitas()
        {
            var libro = new LibroDeVisitas();
            string contenido = libro.Leer();
            ViewData["libro"] = contenido;
            return View();
        }
    }
}