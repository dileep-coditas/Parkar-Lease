using System;
using System.Collections.Generic;
using System.Text;

namespace Lease.Common.Shared
{
    public class Term
    {
        public Term()
        {

        }

        public Term(int termId, string termName)
        {
            TermId = termId;
            TermName = termName;
        }
        public int TermId { get; set; }
        public string TermName { get; set; }
    }
}
