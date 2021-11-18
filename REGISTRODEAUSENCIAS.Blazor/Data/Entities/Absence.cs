using System;
using System.Collections.Generic;

#nullable disable

namespace REGISTRODEAUSENCIAS.Blazor.Data
{
    public partial class Absence
    {
        public int Id { get; set; }
        public int IdEmployee { get; set; }
        public int IdAbsence { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hours { get; set; }
        public string ObservationsObservationsObservations { get; set; }

        public virtual TypeOfAbsence IdAbsenceNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
    }
}
