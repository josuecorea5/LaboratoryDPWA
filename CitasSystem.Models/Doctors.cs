using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CitasSystem.Models
{
    public class Doctors : EntityBase
    {
        [Required]
        [MinLength(5, ErrorMessage ="El numero de caracteres debe ser mayor a 5")]
        public int CodeNumber { get; set; }
        [Required(ErrorMessage ="Campo no debe quedar vacío")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Campo no debe quedar vacío")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Campo no debe quedar vacío")]
        public string Specialty { get; set; }
        [Required(ErrorMessage = "Campo no debe quedar vacío")]
        public string Schedule { get; set; }
    }
}
