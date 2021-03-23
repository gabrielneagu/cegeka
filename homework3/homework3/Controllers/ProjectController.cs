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
    public class ProjectController : ControllerBase
    {
        private IProjectRepository _projectRepository { get; set; }
        public ProjectController(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        [HttpGet("displayProjects")]
        public async Task<IActionResult> DisplayProjects()
        {
            var projects = _projectRepository.GetProjects();
            return Ok(projects);
        }

        public async Task<IActionResult> AddProject(Project project)
        {
            _projectRepository.AddProject(project);
            return Ok();
        }
    }
}
