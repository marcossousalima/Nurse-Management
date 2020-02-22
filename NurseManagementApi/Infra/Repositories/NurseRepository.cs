using Dapper;
using Domain.Entities;
using Domain.Repositories;
using Infra.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public class NurseRepository : INurseRepository
    {
        private readonly IDB _Db;

        public NurseRepository(IDB dB)
        {
            _Db = dB;
        }

        public void Create(Nurse nurse)
        {
            var sql = "INSERT INTO Nurse (Id, Name, CPF, BirthDate, Coren, Id_Hospital) VALUES (@Id, @Name, @CPF, @BirthDate, @Coren, @Id_Hospital)";
            using (var db = _Db.GetCon())
            {
                db.Execute(sql, new
                {
                    @Id = nurse.Id,
                    @Name = nurse.Name,
                    @CPF = nurse.CPF,
                    @BirthDate = nurse.BirthDate,
                    @Coren = nurse.Coren,
                    @Id_Hospital = nurse.Id_Hospital
                });
            }
        }

        public void Update(Nurse nurse)
        {
            var sql = "UPDATE Nurse SET Name= @Name, @CPF = @CPF, BirthDate = @BirthDate, Coren = @Coren, Id_Hospital = @Id_Hospital WHERE Id = @Id";
            using (var db = _Db.GetCon())
            {
                db.Execute(sql, new
                {
                    @Id = nurse.Id,
                    @Name = nurse.Name,
                    @BirthDate = nurse.BirthDate,
                    @Coren = nurse.Coren,
                    @Id_Hospital = nurse.Id_Hospital,
                    @CPF = nurse.CPF
                });
            }
        }

        public void Delete(Guid Id)
        {
            var sql = "DELETE FROM Nurse WHERE Id = @Id";
            using (var db = _Db.GetCon())
            {
                db.Execute(sql, new
                {
                    @Id = Id
                });
            }
        }

        public async Task<IEnumerable<Nurse>> GetAll()
        {
            var sql = "SELECT n.*, h.Name as NameHospital FROM Nurse as n inner join Hospital as h on n.Id_hospital = h.Id";
            using (var db = _Db.GetCon())
            {
                var response = await db.QueryAsync<Nurse>(sql);
                return response;
            }
        }

        public async Task<Nurse> GetById(Guid Id)
        {
            var sql = "select n.*, h.Name as NameHospital from Nurse as n inner join Hospital as h on n.Id_hospital = h.id where n.Id = @Id";
            using (var db = _Db.GetCon())
            {
                var response = await db.QueryFirstAsync<Nurse>(sql, new { Id = @Id });
                return response;
            }
        }

        public void DeleteNursePerHospital(Guid Id_hospital)
        {
            var sql = "DELETE Nurse WHERE Id_hospital = @Id_hospital";
            using (var db = _Db.GetCon())
            {
                db.Execute(sql, new { Id_hospital = Id_hospital });
            }
        }

        public async Task<IEnumerable<Nurse>> GetAllPerHospital(Guid Id_hospital)
        {
            var sql = "SELECT * from Nurse WHERE Id_hospital = @Id_hospital";
            using (var db = _Db.GetCon())
            {
                var response = await db.QueryAsync<Nurse>(sql, new { Id_hospital = @Id_hospital });
                return response;
            }
        }
    }
}


