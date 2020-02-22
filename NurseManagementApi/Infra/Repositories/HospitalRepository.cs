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
    public class HospitalRepository : IHospitalRepository
    {
        private readonly IDB _Db;
        public HospitalRepository(IDB dB)
        {
            _Db = dB;
        }

        public void Create(Hospital hospital)
        {
            var sql = "INSERT INTO Hospital (Id, Name, CNPJ,  State, City, Number, Complement, Neighborhood) VALUES (@Id, @Name, @CNPJ,  @State, @City, @Number, @Complement, @Neighborhood)";
            using (var db = _Db.GetCon())
            {
                db.Execute(sql, new
                {
                    @Id = hospital.Id,
                    @Name = hospital.Name,
                    @CNPJ = hospital.CNPJ,
                    @State = hospital.State,
                    @City = hospital.City,
                    @Number = hospital.Number,
                    @Complement = hospital.Complement,
                    @Neighborhood = hospital.Neighborhood
                });
            }
        }

        public void Update(Hospital hospital)
        {
            var sql = "UPDATE Hospital SET Name = @Name, @CNPJ = @CNPJ, State = @State, City = @City, Number = @Number, " +
            " Complement = @Complement, Neighborhood = @Neighborhood WHERE Id = @Id";
            using (var db = _Db.GetCon())
            {
                db.Execute(sql, new
                {
                    @Id = hospital.Id,
                    @Name = hospital.Name,
                    @CNPJ = hospital.CNPJ,
                    @State = hospital.State,
                    @City = hospital.City,
                    @Number = hospital.Number,
                    @Complement = hospital.Complement,
                    @Neighborhood = hospital.Neighborhood
                });
            }
        }

        public void Delete(Guid Id)
        {
            var sql = "DELETE FROM Hospital WHERE Id = @Id";
            using (var db = _Db.GetCon())
            {
                db.Execute(sql, new { Id = Id });
            }
        }

        public async Task<IEnumerable<Hospital>> GetAll()
        {
            var sql = "SELECT * FROM Hospital";
            using (var db = _Db.GetCon())
            {
                var response = await db.QueryAsync<Hospital>(sql);
                return response;
            }
        }

        public async Task<Hospital> GetById(Guid Id)
        {
            var sql = "SELECT * FROM Hospital WHERE Id = @Id";
            using (var db = _Db.GetCon())
            {
                var response = await db.QueryFirstAsync<Hospital>(sql, new { Id = @Id });
                return response;
            }
        }
    }
}
