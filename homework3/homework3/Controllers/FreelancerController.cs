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
    public class FreelancerController : ControllerBase
    {
        private IFreelancerRepository _freelancerRepository { get; set; }
        public FreelancerController(IFreelancerRepository freelancerRepository)
        {
            _freelancerRepository = freelancerRepository;
        }

        [HttpGet("displayFreelancers")]
        public async Task<IActionResult> DisplayFreelancers()
        {
            var freelancers = _freelancerRepository.GetFreelancers();
            return Ok(freelancers);
        }

        public async Task<IActionResult> AddFreelancer(Freelancer freelancer)
        {
            _freelancerRepository.AddFreelancer(freelancer);
            return Ok();
        }
    }
}
