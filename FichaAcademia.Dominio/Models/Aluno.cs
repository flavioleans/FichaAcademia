﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FichaAcademia.Dominio.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [StringLength(100, ErrorMessage = "Use menos caracteres")]
        [Remote("AlunoExiste", "Alunos", AdditionalFields = "alunoId")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(14, 100, ErrorMessage = "Idade inválida")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(14, 100, ErrorMessage = "Peso inválido")]
        public double Peso { get; set; }

        public int ObjetivoId { get; set; }
        public Objetivo Objetivo { get; set; }

        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, 7, ErrorMessage = "Frequência inválida")]
        public int FrequenciaSemanal { get; set; }

        public ICollection<Ficha> Fichas { get; set; }
    }
}
