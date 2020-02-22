using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface INurseRepository
    {
        void Create(Nurse nurse);
        void Update(Nurse nurse);
        void Delete(Guid Id);
        void DeleteNursePerHospital(Guid Id);
        Task<Nurse> GetById(Guid Id);
        Task<IEnumerable<Nurse>> GetAll();
        Task<IEnumerable<Nurse>> GetAllPerHospital(Guid Id);
    }
}
