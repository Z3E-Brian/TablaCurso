using System;
using System.Collections.Generic;

namespace TablaCurso.DAL.Entities
{
    public partial class Curso
    {
        public int CursoId { get; set; }
        public int CodAsignatura { get; set; }
        public string NombreAsignatura { get; set; } = null!;
        public float Creditos { get; set; }
        public string CuatriAcademico { get; set; } = null!;
        public int HorasSemana { get; set; }
        public int DuracionSemanas { get; set; }
        public DateTime InicioPeriodo { get; set; }
        public DateTime TerminoPeriodo { get; set; }
        public string Docente { get; set; } = null!;
        public string Correo { get; set; } = null!;
    }
}
