using System;
using System.Collections.Generic;

#nullable disable

namespace REGISTRODEAUSENCIAS.Blazor.Data
{
    public partial class Employee
    {
        public Employee()
        {
            Absences = new HashSet<Absence>();
        }

        public int Id { get; set; }
        public string Names { get; set; }
        public string Surnames { get; set; }

        public virtual ICollection<Absence> Absences { get; set; }
    }
}
