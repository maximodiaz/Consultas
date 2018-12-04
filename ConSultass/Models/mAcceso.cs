using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConSultass.Models
{
    public class mAcceso
    {
        public int ID_acceso { get; set; }
        [Required]
        public String usuario { get; set; }
        [Required]
        public String contraseña { get; set; }
        [Required]
        public String perfil { get; set; }

    }
}