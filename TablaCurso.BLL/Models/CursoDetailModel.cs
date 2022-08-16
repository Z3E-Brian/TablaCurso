using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablaCurso.BLL.Models
{
    internal class CursoDetailModel
    {
        public int CursoId { get; set; }
        [Required]
        public string NombreAsignatura { get; set; }
        [Required]
        public int CodAsignatura { get; set; }
        [Required]
        public float Creditos { get; set; }
        [Required]
        public string CuatriAcademico { get; set; }
        [Required]
        public int HorasSemana { get; set; }
        [Required]
        public int DuracionSemanas { get; set; }
        [Required]
        public DateTime InicioPeriodo { get; set; }
        [Required]
        public DateTime TerminoPeriodo { get; set; }
        [Required]
        public string Docente { get; set; }
        [Required]
        public string Correo { get; set; }
    }
}
