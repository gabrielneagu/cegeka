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
    public class ProjectAllocationController : ControllerBase
    {
        private IProjectAllocationRepository _projectAllocationRepository { get; set; }
        public ProjectAllocationController(IProjectAllocationRepository projectAllocationRepository)
        {
            _projectAllocationRepository = projectAllocationRepository;
        }

        [HttpGet("displayProjectAllocations")]
        public async Task<IActionResult> DisplayProjectAllocations()
        {
            var projectAllocations = _projectAllocationRepository.GetProjectAllocations();
            return Ok(projectAllocations);
        }

        public async Task<IActionResult> AddProjectAllocation(ProjectAllocation projectAllocation)
        {
            _projectAllocationRepository.AddProjectAllocation(projectAllocation);
            return Ok();
        }
    }
}
