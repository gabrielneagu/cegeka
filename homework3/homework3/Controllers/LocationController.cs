using Homework3.Repositories;
using Homework3.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Homework3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private ILocationRepository _locationRepository { get; set; }
        public LocationController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        [HttpGet("displayLocations")]
        public async Task<IActionResult> DisplayLocations()
        {
            var locations = _locationRepository.GetLocations();
            return Ok(locations);
        }

        [HttpPost("addLocation")]
        public async Task<IActionResult> AddLocation(Location location)
        {
            _locationRepository.AddLocation(location);
            return Ok();
        }
    }
}
