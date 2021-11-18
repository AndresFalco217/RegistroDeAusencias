using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace REGISTRODEAUSENCIAS.Blazor.Data
{
    public partial class DBEMPLEADOSContext : DbContext
    {
        public DBEMPLEADOSContext()
        {
        }

        public DBEMPLEADOSContext(DbContextOptions<DBEMPLEADOSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Absence> Absences { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<TypeOfAbsence> TypeOfAbsences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=DBEMPLEADOS; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Absence>(entity =>
            {
                entity.ToTable("Absence");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ObservationsObservationsObservations)
                    .HasMaxLength(200)
                    .HasColumnName("Observations\r\nobservations\r\nObservations]]]]]]]");

                entity.HasOne(d => d.IdAbsenceNavigation)
                    .WithMany(p => p.Absences)
                    .HasForeignKey(d => d.IdAbsence)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Absence_Type of absence");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Absences)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Absence_employee");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.Names)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Surnames)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TypeOfAbsence>(entity =>
            {
                entity.ToTable("Type of absence");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
