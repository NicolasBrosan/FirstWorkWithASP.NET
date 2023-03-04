using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Visitas.Models
{
    public class LibroDeVisitas
    {
        public void Grabar(string nombre, string comentarios)
        {
            var archivo = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt", true);
            archivo.WriteLine("Nombre: " + nombre + "<br>Comentarios: " + comentarios + "<hr>");
            archivo.Close();
        }
        public string Leer()
        {
            var archivo = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt");
            string contenido = archivo.ReadToEnd();
            archivo.Close();
            return contenido;
        }
    }
}