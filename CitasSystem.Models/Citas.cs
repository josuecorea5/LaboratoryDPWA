using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CitasSystem.Models
{
    public class Citas : EntityBase
    {
        [Required(ErrorMessage = "El código no debe ser menor de 5 caracteres")]
        public int IdCita { get; set; }
        [Required(ErrorMessage = "Esta campo no puede quedar vacío")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Esta campo no puede quedar vacío")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Esta campo no puede quedar vacío")]
        public DateTime Hour  { get; set; }
        [Required(ErrorMessage = "Esta campo no puede quedar vacío")]
        public int CodeHospital { get; set; }
        [Required(ErrorMessage = "Esta campo no puede quedar vacío")]
        public int CodeNumber { get; set; }
        public Hospital Hospital { get; set; }
        public Doctors Doctors { get; set; }
    }
}
