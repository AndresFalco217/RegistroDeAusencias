using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace REGISTRODEAUSENCIAS.Blazor.Data.Models
{
    public class AbsenceModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo empleado es obligatorio")]
        public int IdEmployee { get; set; }
        [Required(ErrorMessage = "El campo ausencia es obligatorio")]
        public int IdAbsence { get; set; }
        [Required(ErrorMessage = "La fecha es obligatoria")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int Hours { get; set; }
        public string ObservationsObservationsObservations { get; set; }

    }
}
