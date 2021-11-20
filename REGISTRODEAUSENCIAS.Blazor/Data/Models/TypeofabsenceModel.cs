using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REGISTRODEAUSENCIAS.Blazor.Data.Models
{
    public class TypeofabsenceModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Name { get; set; }
    }
}
