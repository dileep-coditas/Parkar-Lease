using Dapper.Contrib.Extensions;
using Lease.Common.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lease.Api.Data
{
    public class LeaseRepository : BaseRepository, ILeaseRepository
    {
        public LeaseRepository(IDatabaseFactory databaseFactory) 
            : base(databaseFactory)
        {

        }

        public LeaseItem AddLease(LeaseItem leaseItem)
        {
            var result = DataContext.Insert(leaseItem);
            return leaseItem;
        }
    }

    public interface ILeaseRepository
    {
        LeaseItem AddLease(LeaseItem leaseItem);
    }
}
