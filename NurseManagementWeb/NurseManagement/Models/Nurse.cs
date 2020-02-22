using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NurseManagement.Models
{
    public class Nurse
    {
        public Guid Id { get; set; }
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O Nome é obrigatório.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "A Cidade deve ter no mínimo 5 e no máximo 100 caracteres.")]
        public string Name { get; set; }
        [Display(Name = "N.Inscrição Coren")]
        public string Coren { get; set; }
        [Required(ErrorMessage = "O CPF é obrigatório.")]
        public string CPF { get; set; }
        public Guid Id_Hospital { get; set; }
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "O Data de Nascimento é obrigatório.")]
        public DateTime BirthDate { get; set; }

        //Variavel Auxiliar
        [Display(Name = "Hospital Vinculado")]
        public string NameHospital { get; set; }
    }
}
