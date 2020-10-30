using Lease.Common.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lease.Api.Data
{
    public class LocationRepository : BaseRepository, ILocationRepository
    {
        public LocationRepository(IDatabaseFactory databaseFactory) 
            : base(databaseFactory)
        {

        }

        public List<State> GetAllStates()
        {
            return new List<State>()
            {
                new State(1, "Alabama"),
                new State(2, "Alaska"),
                new State(3, "California"),
                new State(4, "Florida"),
                new State(5, "Georgia"),
            };
        }
    }

    public interface ILocationRepository
    {
        List<State> GetAllStates();
    }
}
