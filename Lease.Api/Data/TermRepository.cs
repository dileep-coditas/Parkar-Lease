using Lease.Common.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lease.Api.Data
{
    public class TermRepository : BaseRepository, ITermRepository
    {
        public TermRepository(IDatabaseFactory databaseFactory) 
            : base(databaseFactory)
        {
        }

        public List<Term> GetAllTerms()
        {
            return new List<Term>()
            {
                new Term(1, "1 Month"),
                new Term(2, "2 Months"),
                new Term(3, "3 Months"),
                new Term(4, "4 Months"),
                new Term(5, "5 Months"),
            };
        }
    }

    public interface ITermRepository
    {
        List<Term> GetAllTerms();
    }
}
