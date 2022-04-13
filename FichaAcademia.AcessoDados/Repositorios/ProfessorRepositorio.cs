﻿using FichaAcademia.AcessoDados.Interfaces;
using FichaAcademia.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaAcademia.AcessoDados.Repositorios
{
    public class ProfessorRepositorio : RepositorioGenerico<Professor>, IProfessorRepositorio
    {
        private readonly Contexto _contexto;
        public ProfessorRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;        
        }
        public async Task<bool> ProfessorExiste(string nome)
        {
            return await _contexto.Professores.AnyAsync(p => p.Nome == nome);
        }

        public async Task<bool> ProfessorExiste(string nome, int professorId)
        {
            return await _contexto.Professores.AnyAsync(p => p.Nome == nome && p.ProfessorId != professorId);
        }
    }
}
