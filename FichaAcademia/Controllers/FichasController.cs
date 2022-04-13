using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FichaAcademia.AcessoDados;
using FichaAcademia.Dominio.Models;
using FichaAcademia.AcessoDados.Interfaces;
using Rotativa.AspNetCore;
using Microsoft.AspNetCore.Authorization;

namespace FichaAcademia.Controllers
{
    [Authorize]
    public class FichasController : Controller
    {
        private readonly IFichaRepositorio _fichaRepositorio;
        private readonly IAlunoRepositorio _alunoRepositorio;
        private readonly IObjetivoRepositorio _objetivoRepositorio;

        public FichasController(IFichaRepositorio fichaRepositorio, IAlunoRepositorio alunoRepositorio, IObjetivoRepositorio objetivoRepositorio)
        {
            _fichaRepositorio = fichaRepositorio;
            _alunoRepositorio = alunoRepositorio;
            _objetivoRepositorio = objetivoRepositorio;
        }

        // GET: Fichas
        public async Task<IActionResult> Index(int AlunoId)
        {
            ViewBag.AlunoId = AlunoId;
            return View(await _fichaRepositorio.PegarTodasFichasPeloAlunoId(AlunoId));
        }

        // GET: Fichas/Details/5
        public async Task<IActionResult> Details(int fichaId)
        {
            var ficha = await _fichaRepositorio.PegarFichaAlunoPeloId(fichaId);
                
            if (ficha == null)
            {
                return NotFound();
            }

            return View(ficha);
        }

        //PDF
        public async Task<IActionResult> VisualizarPDF(int fichaId)
        {
            var ficha = await _fichaRepositorio.PegarFichaAlunoPeloId(fichaId);

            if (ficha == null)
            {
                return NotFound();
            }

            return new ViewAsPdf("PDF", ficha) { FileName="Ficha.PDF"};
        }

        // GET: Fichas/Create
        public IActionResult Create(int alunoId)
        {
            Ficha ficha = new Ficha();
            ficha.AlunoId = alunoId;
            return View(ficha);
        }

        // POST: Fichas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FichaId,Nome,Cadastro,Validade,AlunoId")] Ficha ficha)
        {
            ficha.Cadastro = DateTime.Parse(DateTime.Now.ToShortDateString());
            ficha.Validade = DateTime.Parse(DateTime.Now.AddYears(1).ToShortDateString());

            if (ModelState.IsValid)
            {
                await _fichaRepositorio.Inserir(ficha);
                return RedirectToAction(nameof(Index), new { AlunoId = ficha.AlunoId });
            }
            return View(ficha);
        }

        // GET: Fichas/Edit/5
        public async Task<IActionResult> Edit(int fichaId)
        {
            
            var ficha = await _fichaRepositorio.PegarPeloId(fichaId);
            if (ficha == null)
            {
                return NotFound();
            }
            return View(ficha);
        }

        // POST: Fichas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int fichaId, [Bind("FichaId,Nome,Cadastro,Validade,AlunoId")] Ficha ficha)
        {
            if (fichaId != ficha.FichaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _fichaRepositorio.Atualizar(ficha);
                return RedirectToAction(nameof(Index), new { AlunoId = ficha.AlunoId});
            }
            return View(ficha);
        }

        // POST: Fichas/Delete/5
        [HttpPost]
        public async Task<JsonResult> Delete(int fichaId)
        {
            await _fichaRepositorio.Excluir(fichaId);
            return Json("Ficha excluída com sucesso");
        }

        public async Task<JsonResult> FichaExiste(string nome, int fichaId)
        {
            if (fichaId == 0)
            {
                if (await _fichaRepositorio.FichaExiste(nome))
                    return Json("Ficha já cadastrada");

                return Json(true);
            }
            else
            {
                if (await _fichaRepositorio.FichaExiste(nome, fichaId))
                    return Json("Ficha já cadastrada");

                return Json(true);
            }
        }

    }
}
