using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lease.Api.Data;
using Lease.Common.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Lease.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaseController : ControllerBase
    {
        private readonly ILeaseRepository _leaseRepository;
        public LeaseController(ILeaseRepository leaseRepository)
        {
            _leaseRepository = leaseRepository;
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] LeaseItem leaseItem)
        {
            if(leaseItem == null)
            {
                return BadRequest();
            }

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var lease = _leaseRepository.AddLease(leaseItem);
            if(lease == null || lease.LeaseId <= 0)
            {
                ModelState.AddModelError("Process Error", "Unable to process lease.");
                return BadRequest(ModelState);
            }
            else
            {
                return Created("lease", lease);
            }
        }
    }
}
