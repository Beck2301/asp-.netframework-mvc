using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace Libros.Models
{
    public class Agregar
    {
        public void Guardar(Datos model)
        {
            StreamWriter datos = new StreamWriter(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt", true);
            datos.WriteLine(
                "<tr>" +
                "<td>" + model.id + "</td>" +
                 "<td>" + model.isbn + "</td>" +
                "<td>" + model.titulo + "</td>" +
                 "<td>" + model.npaginas + "</td>" +
                  "<td>" + model.editorial + "</td>" +
                   "<td>" + model.autor + "</td>" +
                    "<td>" + @Convert.ToDateTime(model.fpublicacion).ToString(("dd/MM/yyyy")) + "</td>" +
                   "</tr>");
            datos.Close();
        }
        public string Leer()
        {
            StreamReader datos = new StreamReader(HostingEnvironment.MapPath("~") + "/App_Data/datos.txt");
            string todos = datos.ReadToEnd();
            datos.Close();
            return todos;
        }
    }
}