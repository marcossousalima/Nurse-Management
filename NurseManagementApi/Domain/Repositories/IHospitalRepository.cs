using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IHospitalRepository
    {
        void Create(Hospital hospital);
        void Update(Hospital hospital);
        void Delete(Guid Id);
        Task<Hospital> GetById(Guid Id);
        Task<IEnumerable<Hospital>> GetAll();
    }
}
