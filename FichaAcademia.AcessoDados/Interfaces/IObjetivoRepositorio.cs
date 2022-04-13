using FichaAcademia.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FichaAcademia.AcessoDados.Interfaces
{
    public interface IObjetivoRepositorio :IRepositorioGenerico<Objetivo>
    {
        Task<bool> ObjetivoExiste(string nome);
        Task<bool> ObjetivoExiste(string nome, int objetivoId);
    }
}
