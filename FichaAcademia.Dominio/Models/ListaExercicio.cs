using System.ComponentModel.DataAnnotations;

namespace FichaAcademia.Dominio.Models
{
    public class ListaExercicio
    {
        public int ListaExercicioId { get; set; }
        public int ExercicioId { get; set; }
        public Exercicio Exercicio { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, 10, ErrorMessage = "Frequência inválida")]
        public int Frequencia { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, 10, ErrorMessage = "Número inválido")]
        public int Repeticoes { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Range(1, 200, ErrorMessage = "Número inválido")]
        public int Carga { get; set; }

        public int FichaId { get; set; }
        public Ficha Ficha { get; set; }
    }
}
