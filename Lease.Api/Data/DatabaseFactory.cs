using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Lease.Api.Data
{
    public class DatabaseFactory : IDatabaseFactory
    {
        private readonly string _connectionString;
        public DatabaseFactory(string connectionString)
        {
            _connectionString = connectionString;
        }
        private IDbConnection _dbContext;
        public IDbConnection Get()
        {
            if (_dbContext == null)
            {
                try
                {
                    _dbContext = new SqlConnection(_connectionString);
                }
                catch (Exception ex)
                {
                    //Handle Exception or throw or log
                }
            }
            return _dbContext;
        }
    }
}
