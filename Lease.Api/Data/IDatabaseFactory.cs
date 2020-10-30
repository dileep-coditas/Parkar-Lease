using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Lease.Api.Data
{
    public interface IDatabaseFactory
    {
        IDbConnection Get();
    }
}
