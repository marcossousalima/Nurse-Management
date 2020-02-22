using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.ViewModel
{
    public class NurseViewModel
    {
        public NurseViewModel(Guid id, string name, string cPF, DateTime birthDate, string coren, string hospital)
        {
            Id = id;
            Name = name;
            CPF = cPF;
            BirthDate = birthDate;
            Coren = coren;
            Hospital = hospital;
        }
        public NurseViewModel()
        {

        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public DateTime BirthDate { get; set; }
        public string Coren { get;  set; }
        public string Hospital { get; set; }
    }
}
