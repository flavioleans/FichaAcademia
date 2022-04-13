using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FichaAcademia.ViewModels
{
    public class AdministradorViewModel
    {
        [Required(ErrorMessage ="Campo obrigatorio")]
        [DataType(DataType.EmailAddress, ErrorMessage ="E-mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
