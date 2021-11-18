using System;
using System.Collections.Generic;

#nullable disable

namespace REGISTRODEAUSENCIAS.Blazor.Data
{
    public partial class TypeOfAbsence
    {
        public TypeOfAbsence()
        {
            Absences = new HashSet<Absence>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Absence> Absences { get; set; }
    }
}
