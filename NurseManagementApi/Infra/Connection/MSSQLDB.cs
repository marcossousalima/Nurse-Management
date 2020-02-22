using Infra.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Connection
{
    public class MSSQLDB : IDB
    {
        private SqlConnection _conexao;
        private string _configuration;

        public MSSQLDB(IdbConfiguration configuration)
        {
            _configuration = configuration.ConnectionString;
        }
        public void Dispose()
        {
            _conexao.Close();
            _conexao.Dispose();
        }

        public IDbConnection GetCon()
        {
            if (_conexao == null)
            {
                return _conexao = new SqlConnection(_configuration);
            }
            else
            {
                if (_conexao.State != ConnectionState.Open)
                    _conexao.ConnectionString = _configuration;
            }
            return _conexao;
        }
    }
}
