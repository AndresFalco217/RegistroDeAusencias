using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REGISTRODEAUSENCIAS.Blazor.Data.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Names { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Surnames { get; set; }
    }
}
