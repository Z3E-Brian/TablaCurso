using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TablaCurso.DAL.Entities
{
    public partial class U_ABCProgWEBContext : DbContext
    {
        public U_ABCProgWEBContext()
        {
        }

        public U_ABCProgWEBContext(DbContextOptions<U_ABCProgWEBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Curso> Cursos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-Q2L8PRB\\UNEDSQL;" +
                    "Database=U_ABC(Prog.WEB);Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>(entity =>
            {
                entity.Property(e => e.CursoId).HasColumnName("cursoId");

                entity.Property(e => e.CodAsignatura)
                    .HasMaxLength(50)
                    .HasColumnName("codAsignatura")
                    .IsFixedLength();

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .HasColumnName("correo")
                    .IsFixedLength();

                entity.Property(e => e.Creditos).HasColumnName("creditos");

                entity.Property(e => e.CuatriAcademico)
                    .HasMaxLength(10)
                    .HasColumnName("cuatriAcademico")
                    .IsFixedLength();

                entity.Property(e => e.Docente)
                    .HasMaxLength(50)
                    .HasColumnName("docente")
                    .IsFixedLength();

                entity.Property(e => e.DuracionSemanas).HasColumnName("duracionSemanas");

                entity.Property(e => e.InicioPeriodo)
                    .HasColumnType("date")
                    .HasColumnName("inicioPeriodo");

                entity.Property(e => e.NombreAsignatura)
                    .HasMaxLength(50)
                    .HasColumnName("nombreAsignatura")
                    .IsFixedLength();

                entity.Property(e => e.TerminoPeriodo)
                    .HasColumnType("date")
                    .HasColumnName("terminoPeriodo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
