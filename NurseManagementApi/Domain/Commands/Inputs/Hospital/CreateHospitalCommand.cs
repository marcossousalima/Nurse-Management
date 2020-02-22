using Shared.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands.Inputs.Hospital
{
    public class CreateHospitalCommand : ICommandInput
    {
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
    }
}
