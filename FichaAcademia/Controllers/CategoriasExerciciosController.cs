﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FichaAcademia.AcessoDados;
using FichaAcademia.Dominio.Models;
using FichaAcademia.AcessoDados.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace FichaAcademia.Controllers
{
    [Authorize]
    public class CategoriasExerciciosController : Controller
    {
        private readonly ICategoriaExercicioRepositorio _categoriaExercicioRepositorio;

        public CategoriasExerciciosController(ICategoriaExercicioRepositorio categoriaExercicioRepositorio)
        {
            _categoriaExercicioRepositorio = categoriaExercicioRepositorio;
        }

        // GET: CategoriasExercicios
        public async Task<IActionResult> Index()
        {
            return View(_categoriaExercicioRepositorio.PegarTodos());
        }

        // GET: CategoriasExercicios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CategoriasExercicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoriaExercicioId,Nome")] CategoriaExercicio categoriaExercicio)
        {
            if (ModelState.IsValid)
            {
                await _categoriaExercicioRepositorio.Inserir(categoriaExercicio);
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaExercicio);
        }

        // GET: CategoriasExercicios/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriaExercicio = await _categoriaExercicioRepositorio.PegarPeloId(id);
            if (categoriaExercicio == null)
            {
                return NotFound();
            }
            return View(categoriaExercicio);
        }

        // POST: CategoriasExercicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoriaExercicioId,Nome")] CategoriaExercicio categoriaExercicio)
        {
            if (id != categoriaExercicio.CategoriaExercicioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _categoriaExercicioRepositorio.Atualizar(categoriaExercicio);
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaExercicio);
        }

        // POST: CategoriasExercicios/Delete/5
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            await _categoriaExercicioRepositorio.Excluir(id);
            return Json("Categoria excluído com sucesso");
        }

       //validação remota
       public async Task<JsonResult> CategoriaExiste(string nome, int categoriaExercicioId)
        {
            if (categoriaExercicioId == 0)
            {
                if (await _categoriaExercicioRepositorio.CategoriaExiste(nome))
                    return Json("Categoria já existe");

                return Json(true);

            }

            else
            {
                if (await _categoriaExercicioRepositorio.CategoriaExiste(nome, categoriaExercicioId))
                    return Json("Categoria já existe");
                
                return Json(true);
            }
        }
    }
}
