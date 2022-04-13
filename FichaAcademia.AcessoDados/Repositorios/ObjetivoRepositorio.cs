using FichaAcademia.AcessoDados.Interfaces;
using FichaAcademia.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichaAcademia.AcessoDados.Repositorios
{
    public class ObjetivoRepositorio : RepositorioGenerico<Objetivo>, IObjetivoRepositorio
    {
        private readonly Contexto _contexto;
        public ObjetivoRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
        public async Task<bool> ObjetivoExiste(string nome)
        {
            return await _contexto.Objetivos.AnyAsync(o => o.Nome == nome);
        }

        public async Task<bool> ObjetivoExiste(string nome, int objetivoId)
        {
            return await _contexto.Objetivos.AnyAsync(o => o.Nome == nome && o.ObjetivoId != objetivoId);

        }
    }
}
