using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ConSultass.Models
{
    public class mUsuario
    {

        [Key]
        public int ID_Usuario { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Apellido { get; set; }
        [Required]
        public String Cedula { get; set; }
        [Required]
        public String Direccion { get; set; }
        [Required]
        public String Telefono { get; set; }
        [Required]
        public String Perfil { get; set; }

    }
}