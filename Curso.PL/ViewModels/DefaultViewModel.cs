using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotVVM.Framework.ViewModel;
using TablaCurso.BLL;

namespace Curso.PL.ViewModels
{
    public class DefaultViewModel : MasterPageViewModel
    {
		private readonly CursoService cursoService;

		public DefaultViewModel(CursoService cursoService)
		{
			this.cursoService = cursoService;
		}

		public List<CursoListModel> Cursos { get; set; }

		public override async Task PreRender()
		{
			Cursos = await cursoService.GetAllCursosAsync();
			await base.PreRender();
		}

    }
}
