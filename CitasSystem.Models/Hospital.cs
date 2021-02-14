using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CitasSystem.Models
{
    public class Hospital : EntityBase
    {
        [Required(ErrorMessage = "El código no debe ser menor de 5 caracteres")]
        public int CodeHospital { get; set; }
        [Required(ErrorMessage = "Esta campo no puede quedar vacío")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Esta campo no puede quedar vacío")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Esta campo no puede quedar vacío")]
        public int Cellphone { get; set; }
    }
}
