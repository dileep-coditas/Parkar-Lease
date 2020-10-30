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
    public class StateController : ControllerBase
    {
        private readonly ILocationRepository _locationRepository;
        public StateController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        [HttpGet]
        public IEnumerable<State> Get()
        {
            return _locationRepository.GetAllStates();
        }
    }
}
