using Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands.Inputs.Nurse
{
  public  class UpdateNurseCommand : ICommandInput
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public DateTime BirthDate { get; set; }
        public string Coren { get; set; }
        public Guid Id_Hospital { get; set; }
    }
}
