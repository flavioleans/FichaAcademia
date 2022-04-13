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
    public class AlunoRepositorio : RepositorioGenerico<Aluno>, IAlunoRepositorio
    {
        private readonly Contexto _contexto;
        public AlunoRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
        public async Task<bool> AlunoExiste(string nome)
        {
            return await _contexto.Alunos.AnyAsync(a => a.NomeCompleto == nome);
        }

        public async Task<bool> AlunoExiste(string nome, int alunoId)
        {
            return await _contexto.Alunos.AnyAsync(a => a.NomeCompleto == nome && a.AlunoId != alunoId);
        }

        public async Task<Aluno> PegarDadosAlunoPeloId(int alunoId)
        {
            return await _contexto.Alunos.Include(a => a.Objetivo).Include(a => a.Professor).Where(a => a.AlunoId == alunoId).FirstAsync();
        }

        public string PegarNomeAlunoPeloId(int id)
        {
            return _contexto.Alunos.Where(a => a.AlunoId == id).Select(a => a.NomeCompleto).First();
        }

        async Task<IEnumerable<Aluno>> IAlunoRepositorio.PegarTodos()
        {
            return await _contexto.Alunos.Include(a => a.Objetivo).Include(a => a.Professor).ToListAsync();
        }
    }
}
