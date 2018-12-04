using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConSultass.Models
{
    public class mPerfil
    {
        [Key]
        public int ID_Perfil { get; set; }
        [Required]
        public string Nombre_Perfil { get; set; }
    }
}