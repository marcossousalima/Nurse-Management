using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagement.Models
{
    public class Hospital
    {
        public Guid Id { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Campo é obrigatório.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O Nome deve ter no mínimo 5 e no máximo 100 caracteres.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O CNPJ é obrigatório.")]
        public string CNPJ { get; set; }
        [Display(Name = "Número")]
        [Required(ErrorMessage = "O Número é obrigatório.")]
        public int Number { get; set; }
        [Display(Name = "Complemento")]
        public string Complement { get; set; }
        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "Informe a Cidade.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "A Cidade deve ter no mínimo 5 e no máximo 100 caracteres.")]
        public string City { get; set; }
        [Display(Name = "Bairro")]
        public string Neighborhood { get; set; }
        [Display(Name = "Estado")]
        [Required(ErrorMessage = "Informe a Estado.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O Estado deve ter no mínimo 5 e no máximo 100 caracteres.")]
        public string State { get; set; }

    }
}
