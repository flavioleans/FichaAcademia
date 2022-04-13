using FichaAcademia.AcessoDados;
using FichaAcademia.AcessoDados.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FichaAcademia.ViewComponents
{
    public class ListagemExerciciosFichaViewComponent : ViewComponent
    {
        private readonly Contexto _contexto;
        public ListagemExerciciosFichaViewComponent(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IViewComponentResult> InvokeAsync(int fichaId)
        {
            return View(await _contexto.ListasExercicios.Include(l => l.Exercicio).Where(l => l.FichaId == fichaId).ToListAsync());
        }


    }
}
