using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConSultass.Models
{
    public class mPacientes
    {
        public int Id_Paciente { get; set; }
        public String Cedula { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Display(Name = "Fecha Nacimiento")]
        [Required]
        public DateTime Fecha_Nacimiento { get; set; }
        [Required]
        [Display(Name = "Tipo Sangre")]
        public string Tipo_Sangre { get; set; }
    }
}