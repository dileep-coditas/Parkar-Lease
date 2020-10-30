using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Lease.Api.Data
{
    public class BaseRepository
    {
        private IDbConnection _dbContext;
        public BaseRepository(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        protected IDbConnection DataContext
        {
            get { return _dbContext ?? (_dbContext = DatabaseFactory.Get()); }
        }
    }
}
