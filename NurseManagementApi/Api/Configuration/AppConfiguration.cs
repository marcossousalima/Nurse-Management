using Infra.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Configuration
{
    public class AppConfiguration : IdbConfiguration
    {
        private readonly IConfiguration _dbConfiguration;

        public AppConfiguration(IConfiguration dbConfiguration)
        {
            _dbConfiguration = dbConfiguration;
        }
        public string ConnectionString => _dbConfiguration.GetConnectionString("DefaultConnection");
    }
}
