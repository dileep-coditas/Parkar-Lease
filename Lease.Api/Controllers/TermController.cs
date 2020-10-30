using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lease.Api.Data;
using Lease.Common.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lease.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TermController : ControllerBase
    {
        private readonly ITermRepository _termRepository;
        public TermController(ITermRepository termRepository)
        {
            _termRepository = termRepository;
        }

        [HttpGet]
        public IEnumerable<Term> Get()
        {
            return _termRepository.GetAllTerms();
        }
    }
}
