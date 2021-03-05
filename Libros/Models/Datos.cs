using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Libros.Models
{
    public class Datos
    {
        [Required(ErrorMessage = "El id es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "El id debe ser un numero")]
        public int id { get; set; }

        [Required(ErrorMessage = "El isbn es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "El isbn debe ser un numero")]
        public string isbn { get; set; }


        [Required(ErrorMessage = "El titulo es requerido")]
        public string titulo { get; set; }

        [Required(ErrorMessage = "El numero de pagina es requerido")]
        [Range(0, int.MaxValue, ErrorMessage ="El dato debe ser un numero")]
        public string npaginas { get; set; }


        [Required(ErrorMessage = "El dato es requerido")]
        public string editorial { get; set; }


        [Required(ErrorMessage = "El autor es requerido")]
        public string autor { get; set; }


        [Required(ErrorMessage = "El dato es requerido")]
        public string fpublicacion { get; set; }
    }
}