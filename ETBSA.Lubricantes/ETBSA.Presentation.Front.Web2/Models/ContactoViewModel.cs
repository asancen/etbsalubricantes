using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ETBSA.Presentation.Front.Web2.Models
{
    public class ContactoViewModel
    {
        [DisplayName("Nombre")]
        [Required]
        public string Nombre { get; set;}
        [DisplayName("Teléfono")]
        [Required]
        public string Telefono { get; set; }

        [DisplayName("Correo")]
        [EmailAddress(ErrorMessage = "Dirección de correo inválida")]
        [Required]
        public string Correo { get; set; }

        [DisplayName("Mensaje")]
        [Required]
        public string Mensaje { get; set; }
    }
}