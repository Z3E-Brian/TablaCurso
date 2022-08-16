using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablaCurso.BLL.Models;
using TablaCurso.DAL.Entities;

namespace TablaCurso.BLL.Services
{
    internal class CursoService
    {
        private readonly U_ABCProgWEBContext CursoDBContext;

        public CursoService(U_ABCProgWEBContext cursoDBContext)
        {
            this.CursoDBContext = cursoDBContext;
        }

        public async Task<CursoDetailModel> GetCursoByIdAsync(int codCurso)
        {
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
            return await CursoDBContext.Cursos.Select(
                s => new CursoDetailModel
                {
                    CursoId = s.CursoId,
                    CodAsignatura = s.CodAsignatura,
                    NombreAsignatura = s.NombreAsignatura,
                    Creditos = s.Creditos,
                    CuatriAcademico = s.CuatriAcademico,
                    HorasSemana = s.HorasSemana,
                    DuracionSemanas = s.DuracionSemanas,
                    InicioPeriodo = s.InicioPeriodo,
                    TerminoPeriodo = s.TerminoPeriodo,
                    Docente = s.Docente,
                    Correo = s.Correo
                }).FirstOrDefaultAsync(s => s.CursoId == codCurso);
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
        }

        public async Task<List<CursoListModel>> GetAllCursoAsync()
        {
            return await CursoDBContext.Cursos.Select(
                s => new CursoListModel
                {
                    CursoId = s.CursoId,
                    CodAsignatura = s.CodAsignatura,
                    NombreAsignatura = s.NombreAsignatura
                }).ToListAsync();
        }

        public async Task InsertCursoAsync (CursoDetailModel curso)
        {
            var entity = new Curso()
            {
                CursoId = curso.CursoId,
                CodAsignatura = curso.CodAsignatura,
                NombreAsignatura = curso.NombreAsignatura,
                Creditos = curso.Creditos,
                CuatriAcademico = curso.CuatriAcademico,
                HorasSemana = curso.HorasSemana,
                DuracionSemanas = curso.DuracionSemanas,
                InicioPeriodo = curso.InicioPeriodo,
                TerminoPeriodo = curso.TerminoPeriodo,
                Docente = curso.Docente,
                Correo = curso.Correo
            };
            CursoDBContext.Cursos.Add(entity);
            await CursoDBContext.SaveChangesAsync();
        }

        public async Task UpdateCursoAsync(CursoDetailModel curso)
        {
            var entity = await CursoDBContext.Cursos.FirstOrDefaultAsync(s => s.CursoId == curso.CursoId);

            entity.NombreAsignatura = curso.NombreAsignatura;
            entity.Creditos = curso.Creditos;
            entity.CuatriAcademico = curso.CuatriAcademico;
            entity.HorasSemana = curso.HorasSemana;
            entity.DuracionSemanas = curso.DuracionSemanas;
            entity.InicioPeriodo = curso.InicioPeriodo;
            entity.TerminoPeriodo = curso.TerminoPeriodo;
            entity.Docente = curso.Docente;
            entity.Correo = curso.Correo;

            await CursoDBContext.SaveChangesAsync();

        }

        public async Task DeleteCursoAsync(int cursoid)
        {
            var entity = new Curso()
            {
                CursoId = cursoid

            };
            CursoDBContext.Cursos.Attach(entity);
            CursoDBContext.Cursos.Remove(entity);

            await CursoDBContext.SaveChangesAsync();
        }

    }
}
